using EmployeeManagementSystem.Class;
using EmployeeManagementSystem.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmployeeManagementSystem.Forms
{
	public partial class Admin : UserControl
	{

		Connect connect = new Connect();

		MessagesCustom messages = new MessagesCustom();

		private string userRights = Helper.UserRights;

		public Admin()
		{
			InitializeComponent();

			dataGridView1.EnableDoubleBuffering(true);

			LoadUsers();

			Warning();
		}

		//WARNING MESSAGE FOR USER RIGHTS
		private void Warning()
		{
			if(userRights == "User")
			{
				admin_lbWarning.Text = "You don't have permission to modify.";

				pbWarningIcon.Visible = true;
			}
			else
			{
				pbWarningIcon.Visible = false;
				admin_lbWarning.Visible = false;
			}
		}

		//LOAD USERS FROM DATABASE TO DATA GRID VIEW
		void LoadUsers()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, username, date_register, status, rights, position, department FROM users";

				dataGridView1.DataSource = connect.tb(sql).DefaultView;

				admin_cbxStatusFilter.SelectedIndex = 0;

				ColumnHeaderCustom(); 
			}
			catch(Exception ex)
			{
				messages.ErrorMessage("Error: " + ex.Message);
			}
			finally
			{
				connect.CloseConnection();
			}
		}

		//SET COLUMN HEADER
		void ColumnHeaderCustom()
		{
			dataGridView1.Columns["id"].HeaderText = "ID";
			dataGridView1.Columns["username"].HeaderText = "Username";
			dataGridView1.Columns["position"].HeaderText = "Position";
			dataGridView1.Columns["department"].HeaderText = "Department";
			dataGridView1.Columns["status"].HeaderText = "Status";
			dataGridView1.Columns["rights"].HeaderText = "Rights";
			dataGridView1.Columns["date_register"].HeaderText = "RegisterDate";
		}

		//REFRESH DATA WHEN UPDATE
		public void RefreshData()
		{
			if(InvokeRequired)
			{
				Invoke((MethodInvoker)RefreshData);
				return;
			}
			LoadUsers();
		}

		//FILTER DATA
		private void admin_cbxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, username, date_register, status, rights, position, department FROM users";

				switch (admin_cbxStatusFilter.SelectedIndex)
				{
					case 1: // Active
						sql += " WHERE status = 'Active'";
						break;
					case 2: // Inactive
						sql += " WHERE status = 'Inactive'";
						break;
				}

				if (!string.IsNullOrEmpty(sql))
				{
					dataGridView1.DataSource = connect.tb(sql).DefaultView;
					ColumnHeaderCustom();
				}

				admin_txbSearch.Clear();
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

		//SEARCH BOX
		private void admin_txbSearch_TextChanged(object sender, EventArgs e)
		{
			string sql = "";

			string keyword = admin_txbSearch.Text.Trim();

			sql = $"SELECT id, username, date_register, status, rights, position, department FROM users WHERE [id] LIKE '%{keyword}%' OR [username] LIKE '%{keyword}%' OR [date_register] LIKE '%{keyword}%' OR [status] LIKE '%{keyword}%' OR [rights] LIKE '%{keyword}%' OR [position] LIKE '%{keyword}%'";


			if (string.IsNullOrEmpty(keyword))
			{
				LoadUsers();
			}
            
			if (!string.IsNullOrEmpty(sql)) 
			{
				dataGridView1.DataSource = null;
				dataGridView1.DataSource = connect.tb(sql).DefaultView;
			}
        }
		
		//ADD NEW USER BUTTON
		private void admin_btnAdd_Click(object sender, EventArgs e)
		{
			if (userRights == "User")
			{
				messages.ErrorMessage("You dont have permission to open.");
			}
			else
			{
				AddUser addUser = new AddUser();
				addUser.Visible = true;
				this.Visible = false;
			}
			//Call method from MainForm to display AddUserControl
			(this.Parent as MainForm)?.SwitchAdminToAddUser();
		}
	}
}
