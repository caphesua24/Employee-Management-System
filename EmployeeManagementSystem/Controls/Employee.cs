using EmployeeManagementSystem.Class;
using EmployeeManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeManagementSystem.Controls
{
	public partial class Employee : UserControl
	{

		Connect connect = new Connect();

		MessagesCustom messages = new MessagesCustom();
		public Employee()
		{
			InitializeComponent();

			dataGridView1.EnableDoubleBuffering(true);

			LoadData();

			ColumnHeaderCustom();
		}

		//COLUMN HEADER CUSTOM
		private void ColumnHeaderCustom()
		{
			dataGridView1.Columns["id"].HeaderText = "ID";
			dataGridView1.Columns["employee_id"].HeaderText = "Employee ID";
			dataGridView1.Columns["full_name"].HeaderText = "Full Name";
			dataGridView1.Columns["gender"].HeaderText = "Gender";
			dataGridView1.Columns["contact_number"].HeaderText = "Contact Number";
			dataGridView1.Columns["position"].HeaderText = "Position";
			dataGridView1.Columns["image"].HeaderText = "Image";
			dataGridView1.Columns["insert_date"].HeaderText = "Insert Date";
			dataGridView1.Columns["status"].HeaderText = "Status";
		}

		//DISPLAY DATA FROM DATABASE TO DATA GRID VIEW
		private void LoadData()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, employee_id, full_name, gender, contact_number, position, image, insert_date, status FROM employees WHERE delete_date IS NULL";

				dataGridView1.DataSource = connect.tb(sql).DefaultView;

				employee_cbxStatusFilter.SelectedIndex = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				connect.CloseConnection();
			}
		}

		//REFRESH DATA WHEN UPDATE
		public void RefreshData()
		{
			if(InvokeRequired)
			{
				Invoke((MethodInvoker)RefreshData);
				return;
			}

			LoadData();
		}

		//ADD NEW EMPLOYEE BUTOTN   
		private void employee_btnAddEmployee_Click(object sender, EventArgs e)
		{
			(this.Parent as MainForm)?.SwitchEmployeeToAddEmployee();
		}

		//filter
		private void employee_cbxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, employee_id, full_name, gender, contact_number, position, image, insert_date, status FROM employees WHERE delete_date IS NULL";

				switch (employee_cbxStatusFilter.SelectedIndex)
				{
					case 1: // Active
						sql += " AND status = 'Active'";
						break;
					case 2: // Inactive
						sql += " AND status = 'Inactive'";
						break;
				}

				if (!string.IsNullOrEmpty(sql))
				{
					dataGridView1.DataSource = connect.tb(sql).DefaultView;
					ColumnHeaderCustom();
				}

				employee_txbSearch.Clear();
			}
			catch (Exception ex)
			{
				messages.ErrorMessage("Error: " + ex.Message);
			}
			finally
			{
				connect.CloseConnection();
			}
		}

		//SEARCH
		private void employee_txbSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				connect.OpenConnection();

				string sql = "";

				string keyword = employee_txbSearch.Text.Trim();

				sql = $"SELECT id, employee_id, full_name, gender, contact_number, position, image, insert_date, status FROM employees WHERE delete_date IS NULL AND ([id] LIKE '%{keyword}%' OR [employee_id] LIKE '%{keyword}%' OR [full_name] LIKE '%{keyword}%' OR [gender] LIKE '%{keyword}%' OR [contact_number] LIKE '%{keyword}%' OR [position] LIKE '%{keyword}%' OR [status] LIKE '%{keyword}%')";

				if (string.IsNullOrEmpty(keyword))
				{
					LoadData();
				}

				else
				{
					dataGridView1.DataSource = null;
					dataGridView1.DataSource = connect.tb(sql).DefaultView;

				}
			}
			catch (Exception ex)
			{
				messages.ErrorMessage("Error: " + ex.Message);
			}
			finally
			{
				connect.CloseConnection();
			}
		}
	}
}
