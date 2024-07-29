using EmployeeManagementSystem.Class;
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

namespace EmployeeManagementSystem.Forms
{
	public partial class Admin : UserControl
	{

		Connect connect = new Connect();

		MessagesCustom messages = new MessagesCustom();

		public Admin()
		{
			InitializeComponent();

			dataGridView1.EnableDoubleBuffering(true);

			LoadUsers();
		}

		//LOAD USERS FROM DATABASE TO DATA GRID VIEW
		void LoadUsers()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, username, password, date_register, status, rights, position, department FROM users";

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
			dataGridView1.Columns["password"].HeaderText = "Password";
			dataGridView1.Columns["position"].HeaderText = "Position";
			dataGridView1.Columns["department"].HeaderText = "Department";
			dataGridView1.Columns["status"].HeaderText = "Status";
			dataGridView1.Columns["rights"].HeaderText = "Rights";
			dataGridView1.Columns["date_register"].HeaderText = "RegisterDate";
		}

		//CLEAR FIELDS
		void ClearField()
		{
			admin_txbUsername.Text = "";
			admin_txbPassword.Text = "";
			admin_txbID.Text = "";
			admin_cbxPosition.Text = "";
			admin_cbxRights.Text = "";
			admin_cbxStatus.Text = "";

			admin_txbSearch.Text = "";
			admin_cbxStatusFilter.SelectedIndex = 0;
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

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

		}

		private void admin_cbxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				connect.OpenConnection();
				if (admin_cbxStatusFilter.SelectedIndex == 0)
				{
					string sql = "SELECT id, username, password, date_register, status, rights, position, department FROM users";

					dataGridView1.DataSource = connect.tb(sql).DefaultView;

					ColumnHeaderCustom();
				}
				else if (admin_cbxStatusFilter.SelectedIndex == 1)
				{
					string sql = "SELECT id, username, password, date_register, status, rights, position, department FROM users WHERE status = 'Active'";

					dataGridView1.DataSource = connect.tb(sql).DefaultView;

					ColumnHeaderCustom();
				}
				else if (admin_cbxStatusFilter.SelectedIndex == 2)
				{
					string sql = "SELECT id, username, password, date_register, status, rights, position, department FROM users WHERE status = 'Inactive'";

					dataGridView1.DataSource = connect.tb(sql).DefaultView;

					ColumnHeaderCustom();
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

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				admin_txbID.Text = row.Cells[0].Value.ToString();
				admin_txbUsername.Text = row.Cells[1].Value.ToString();
				admin_txbPassword.Text = row.Cells[2].Value.ToString();
				admin_cbxStatus.Text = row.Cells[4].Value.ToString();
				admin_cbxRights.Text = row.Cells[5].Value.ToString();
				admin_cbxPosition.Text = row.Cells[6].Value.ToString();
			}
		}

		private void addEmployee_btnUpdate_Click(object sender, EventArgs e)
		{
			if(admin_txbID.Text == "" || admin_txbUsername.Text == "" || 
				admin_txbPassword.Text == "" || admin_cbxRights.SelectedIndex == -1 || 
				admin_cbxPosition.SelectedIndex == -1 || admin_cbxStatus.SelectedIndex == -1) 
			{
				messages.ErrorMessage("Please fill all the required fields.");
			}
			else
			{
				DialogResult result = MessageBox.Show("Do you want to update ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						connect.OpenConnection();

						string update = "UPDATE users SET username = @username, password = @password, status = @status, rights = @rights, position = @position WHERE id = @id";

						using (SqlCommand cmd = new SqlCommand(update, connect.conn))
						{
							cmd.Parameters.AddWithValue("@username", admin_txbUsername.Text.Trim());
							cmd.Parameters.AddWithValue("@password", admin_txbPassword.Text.Trim());
							cmd.Parameters.AddWithValue("@status", admin_cbxStatus.Text.Trim());
							cmd.Parameters.AddWithValue("@rights", admin_cbxRights.Text.Trim());
							cmd.Parameters.AddWithValue("@position", admin_cbxPosition.Text.Trim());
							cmd.Parameters.AddWithValue("@id", admin_txbID.Text.Trim());

							cmd.ExecuteNonQuery();

							LoadUsers();

							messages.SuccessMessage("Update successfully!");

							ClearField();
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
				else
				{
					messages.ConfirmationMessage("Canceled.");
				}

			}
		}

		private void addEmployee_btnClear_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		private void addEmployee_btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Do you want to delete this user ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(result == DialogResult.Yes)
			{
				try
				{
					connect.OpenConnection();


					string sql = "DELETE FROM users WHERE id = @id";

					using (SqlCommand cmd = new SqlCommand(sql, connect.conn))
					{
						cmd.Parameters.AddWithValue("@id", admin_txbID.Text.Trim());

						cmd.ExecuteNonQuery();

						LoadUsers();

						messages.SuccessMessage("Delete successfully.");

						ClearField();
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
			else
			{
				messages.ConfirmationMessage("Canceled.");
			}
		}

		private void adEmployee_btnAdd_Click(object sender, EventArgs e)
		{
			if (admin_txbID.Text == "" || admin_txbUsername.Text == "" || 
				admin_txbPassword.Text == "" || admin_cbxRights.Text ==  "" ||
				admin_cbxPosition.Text == "" || admin_cbxStatus.Text == "")
			{
				messages.ErrorMessage("Please fill all the required fields.");
			}
			else
			{
				try
				{
					connect.OpenConnection();

					string checkID = "SELECT * FROM users WHERE id  = @id";

					int count = connect.tb(checkID).Rows.Count;

					if(count != 1)
					{
						messages.ErrorMessage("This user is existing.");
					}
					else
					{
						string query = "INSERT INTO users (id, username, password, status, rights, position) VALUES (@id, @name, @password, @status, @rights, @position)";

						using(SqlCommand cmd = new SqlCommand(query, connect.conn))
						{
							cmd.Parameters.AddWithValue("@id", admin_txbID.Text.Trim());
						}
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
}
