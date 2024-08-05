using EmployeeManagementSystem.Class;
using EmployeeManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Controls
{
	public partial class AddUser : UserControl
	{
		Connect connect = new Connect();

		MessagesCustom messages = new MessagesCustom();

		Encryption Encryption = new Encryption();	

		public AddUser()
		{
			InitializeComponent();

			dataGridView1.EnableDoubleBuffering(true);

			LoadUsers();

			addUser_txbID.Enabled = false;
		}

		//LOAD USERS FROM DATABASE TO DATA GRID VIEW
		void LoadUsers()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT id, username, password, date_register, status, rights, position, department FROM users";

				dataGridView1.DataSource = connect.tb(sql).DefaultView;
				addUser_cbxStatusFilter.SelectedIndex = 0;

				ColumnHeaderCustom();
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
			addUser_txbUsername.Text = "";
			addUser_txbPassword.Text = "";
			addUser_txbID.Text = "";
			addUser_cbxPosition.Text = "";
			addUser_cbxRights.Text = "";
			addUser_cbxStatus.Text = "";

			addUser_txbSearch.Text = "";
			addUser_cbxStatusFilter.SelectedIndex = 0;
		}

		//REFRESH DATA WHEN UPDATE
		public void RefreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)RefreshData);
				return;
			}
			LoadUsers();
		}

		//CELL CLICK
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				addUser_txbID.Text = row.Cells[0].Value.ToString();
				addUser_txbUsername.Text = row.Cells[1].Value.ToString();
				addUser_txbPassword.Text = row.Cells[2].Value.ToString();
				addUser_cbxStatus.Text = row.Cells[4].Value.ToString();
				addUser_cbxRights.Text = row.Cells[5].Value.ToString();
				addUser_cbxPosition.Text = row.Cells[6].Value.ToString();
			}
		}

		//ADD USER BUTTON
		private void addUser_btnAdd_Click(object sender, EventArgs e)
		{
			string hashPassword = Encryption.EndcodeSHA256(addUser_txbPassword.Text.Trim());

			if (addUser_txbUsername.Text == "" ||
				addUser_txbPassword.Text == "" || addUser_cbxRights.Text == "" ||
				addUser_cbxPosition.Text == "" || addUser_cbxStatus.Text == "")
			{
				messages.ErrorMessage("Please fill all the required fields.");
			}
			else
			{
				try
				{
					connect.OpenConnection();

					string query = "INSERT INTO users (username, password, status, rights, position, date_register) VALUES (@name, @password, @status, @rights, @position, @date_register)";

					DateTime today = DateTime.Today;

					using (SqlCommand cmd = new SqlCommand(query, connect.conn))
					{
						cmd.Parameters.AddWithValue("@name", addUser_txbUsername.Text.Trim());
						cmd.Parameters.AddWithValue("@password", hashPassword);
						cmd.Parameters.AddWithValue("@status", addUser_cbxStatus.Text.Trim());
						cmd.Parameters.AddWithValue("@rights", addUser_cbxRights.Text.Trim());
						cmd.Parameters.AddWithValue("@position", addUser_cbxPosition.Text.Trim());
						cmd.Parameters.AddWithValue("@date_register", today);

						cmd.ExecuteNonQuery();

						LoadUsers();

						messages.SuccessMessage("Add Successfully!");

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
		}

		//DELETE USER BUTTON
		private void addUser_btnDelete_Click(object sender, EventArgs e)
		{
			if (addUser_txbID.Text == "")
			{
				messages.ErrorMessage("Please fill the ID field.");
			}
			else
			{
				try
				{
					connect.OpenConnection();

					DialogResult result = MessageBox.Show("Do you want to delete this user ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						string idText = addUser_txbID.Text.Trim();
						int id = int.Parse(idText);

						string checkID = "SELECT * FROM users WHERE id = '" + id + "'";
						int count = connect.tb(checkID).Rows.Count;

						if (count != 1)
						{
							messages.ErrorMessage("This ID is not exist. Please check again.");
						}
						else
						{
							string delete = "DELETE FROM users WHERE id = @id";

							using (SqlCommand cmd = new SqlCommand(delete, connect.conn))
							{
								cmd.Parameters.AddWithValue("@id", addUser_txbID.Text.Trim());

								cmd.ExecuteNonQuery();

								LoadUsers();

								messages.SuccessMessage("Delete successfully!");

								ClearField();
							}
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

		//CLEAR BUTTON
		private void addUser_btnClear_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		//UPDATE USER BUTTON
		private void addUser_btnUpdate_Click(object sender, EventArgs e)
		{
			if (addUser_txbID.Text == "" || addUser_txbUsername.Text == "" ||
				addUser_txbPassword.Text == "" || addUser_cbxRights.SelectedIndex == -1 ||
				addUser_cbxPosition.SelectedIndex == -1 || addUser_cbxStatus.SelectedIndex == -1)
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
							cmd.Parameters.AddWithValue("@username", addUser_txbUsername.Text.Trim());
							cmd.Parameters.AddWithValue("@password", addUser_txbPassword.Text.Trim());
							cmd.Parameters.AddWithValue("@status", addUser_cbxStatus.Text.Trim());
							cmd.Parameters.AddWithValue("@rights", addUser_cbxRights.Text.Trim());
							cmd.Parameters.AddWithValue("@position", addUser_cbxPosition.Text.Trim());
							cmd.Parameters.AddWithValue("@id", addUser_txbID.Text.Trim());

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

		//STATUS FILTER
		private void addUser_cbxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT * FROM users";

				switch (addUser_cbxStatusFilter.SelectedIndex)
				{
					case 1:
						sql += " WHERE status = 'Active'";
						break;
					case 2:
						sql += " WHERE status = 'Inactive'";
						break;
				}

				if(!string.IsNullOrEmpty(sql))
				{
					dataGridView1.DataSource = connect.tb(sql).DefaultView;
					ColumnHeaderCustom();
				}

				addUser_txbSearch.Clear();
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
		
		//COMBOBOX STATUS FILTER
		private void addUser_txbSearch_TextChanged(object sender, EventArgs e)
		{
			string sql = "";

			string keyword = addUser_txbSearch.Text.Trim();

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

		//RETURN USERS MANAGEMENT BUTTON
		private void addUser_btnReturnUserManagement_Click(object sender, EventArgs e)
		{
			(this.Parent as MainForm)?.SwitchAddUserToAdmin();
		}
	}
}
