using EmployeeManagementSystem.Class;
using System;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms
{
	public partial class Salary : UserControl
	{
		Connect connect = new Connect();

		MessagesCustom messageCus = new MessagesCustom();

		public Salary()
		{
			InitializeComponent();

			dataGridView1.EnableDoubleBuffering(true);

			LoadEmployees();

			DatagridviewForm();

			DisableField();
		}

		//DISABLE FIELD
		void DisableField()
		{
			salary_txbEmployeeID.Enabled = false;
			salary_txbFullname.Enabled = false;
			salary_cbxGender.Enabled = false;
			salary_txbPhone.Enabled = false;
			salary_cbxPosition.Enabled = false;
		}

		//LOAD DATA FROM DATABASE TO DATA GRID VIEW
		void LoadEmployees()
		{
			connect.OpenConnection();

			//string loadEmployee = "SELECT * FROM employees";
			//string loadEmployee = "SELECT id, employee_id, full_name, contact_number, gender, position, salary, image, status, insert_date from employees";

			string loadEmployee = "SELECT employee_id, full_name, contact_number, gender, position, salary FROM employees WHERE delete_date IS NULL";

			dataGridView1.DataSource = connect.tb(loadEmployee).DefaultView;
		}

		//CLEAR ALL FIELD
		void ClearField()
		{
			salary_txbEmployeeID.Text = "";
			salary_txbFullname.Text = "";
			salary_cbxGender.SelectedIndex = -1;
			salary_txbSalary.Text = "";
			salary_cbxPosition.SelectedIndex = -1;
			salary_txbPhone.Text = "";
		}

		//SET CUSTOM COLUMN HEADERS
		private void DatagridviewForm()
		{
			dataGridView1.Columns["employee_id"].HeaderText = "EmployeeID";
			dataGridView1.Columns["full_name"].HeaderText = "Name";
			dataGridView1.Columns["gender"].HeaderText = "Gender";
			dataGridView1.Columns["contact_number"].HeaderText = "Contact";
			dataGridView1.Columns["position"].HeaderText = "Position";
			dataGridView1.Columns["salary"].HeaderText = "Salary";
		}

		private void salary_btnUpdate_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Today;

			if (salary_txbEmployeeID.Text == "" || salary_txbFullname.Text == "" ||
				salary_txbPhone.Text == "" || salary_cbxGender.Text == "" ||
				salary_cbxPosition.Text == "" || salary_txbSalary.Text == "")
			{
				messageCus.ErrorMessage("Please fill all the required fields.");
			}
			else
			{
				DialogResult result = MessageBox.Show("Are you sure you want to UPDATE?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						connect.OpenConnection();

						string update = "UPDATE employees SET salary = @salary, update_date = @updateDate WHERE employee_id = @employeeID";

						using (SqlCommand cmd = new SqlCommand(update, connect.conn))
						{
							cmd.Parameters.AddWithValue("@salary", salary_txbSalary.Text.Trim());
							cmd.Parameters.AddWithValue("@updateDate", today);
							cmd.Parameters.AddWithValue("@employeeID", salary_txbEmployeeID.Text.Trim());

							cmd.ExecuteNonQuery();
							LoadEmployees();

							messageCus.SuccessMessage("Update successfully!");

							ClearField();
						}
					}
					catch (Exception ex)
					{
						messageCus.ErrorMessage("Error: " + ex.Message);
					}
					finally
					{
						connect.CloseConnection();
					}
				}
				else
				{
					MessageBox.Show("Update canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				salary_txbEmployeeID.Text = row.Cells[0].Value.ToString();
				salary_txbFullname.Text = row.Cells[1].Value.ToString();
				salary_txbPhone.Text = row.Cells[2].Value.ToString();
				salary_cbxGender.Text = row.Cells[3].Value.ToString();
				salary_cbxPosition.Text = row.Cells[4].Value.ToString();
				salary_txbSalary.Text = row.Cells[5].Value.ToString();

			}
		}

		private void salary_btnClear_Click(object sender, EventArgs e)
		{
			ClearField();
		}
	}
}
