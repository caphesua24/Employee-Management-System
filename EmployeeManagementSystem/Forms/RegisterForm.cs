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
	public partial class RegisterForm : Form
	{
		Connect connect = new Connect();

		public RegisterForm()
		{
			InitializeComponent();
		}

		private void register_lbExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void register_btnSignIn_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
			this.Hide();
		}

		private void register_chboxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if(register_chboxShowPassword.Checked)
			{
				register_txbPassword.UseSystemPasswordChar = false;
			} else
			{
				register_txbPassword.UseSystemPasswordChar = true;
			}
		}

		private void register_btnSignup_Click(object sender, EventArgs e)
		{
			if(register_txbUsername.Text == "" || register_txbPassword.Text == "")
			{
				MessageBox.Show("Please fill all the required fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					//OPEN CONNECT TO DATABASE
					connect.OpenConnection();

					DateTime date_register = DateTime.Today;

					//TO CHECK THE USER IS EXISTING ALREADY
					string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

					using (SqlCommand checkUser = new SqlCommand(selectUsername, connect.conn))
					{
						checkUser.Parameters.AddWithValue("@user", register_txbUsername.Text.Trim());
						int count = (int)checkUser.ExecuteScalar();

                        if (count > 1)
						{
							MessageBox.Show(register_txbUsername.Text.Trim() + " is existing already.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							string query = "INSERT INTO users (username, password, date_register) VALUES (@username, @password, @date_register)";

							using(SqlCommand cmd = new SqlCommand(query, connect.conn))
							{
								cmd.Parameters.AddWithValue("@username", register_txbUsername.Text.Trim());
								cmd.Parameters.AddWithValue("@password", register_txbPassword.Text.Trim());
								cmd.Parameters.AddWithValue("@date_register", date_register);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Register successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

								LoginForm loginForm = new LoginForm();
								loginForm.Show();
								this.Hide();
							}
						}
                    }
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
