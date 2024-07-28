using EmployeeManagementSystem.Class;
using EmployeeManagementSystem.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
	public partial class LoginForm : Form
	{
		Connect connect = new Connect();

		public LoginForm()
		{
			InitializeComponent();
		}

		private void lbExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void login_btnSignup_Click(object sender, EventArgs e)
		{
			RegisterForm resForm = new RegisterForm();
			resForm.Show();
			this.Hide();
		}

		private void login_chboxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			login_txbPassword.PasswordChar = login_chboxShowPassword.Checked ? '\0' : '*';
		}

		private void login_btnLogin_Click(object sender, EventArgs e)
		{
			if(login_txbUsername.Text == "" || login_txbPassword.Text == "")
			{
				MessageBox.Show("Please fill all the required field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					connect.OpenConnection();

					string query = "SELECT * FROM users WHERE username = @username AND password = @password";

					using(SqlCommand cmd = new SqlCommand(query, connect.conn))
					{
						cmd.Parameters.AddWithValue("@username", login_txbUsername.Text.Trim());
						cmd.Parameters.AddWithValue("@password", login_txbPassword.Text.Trim());

						SqlDataAdapter adapter = new SqlDataAdapter(cmd);
						DataTable tb = new DataTable();
						adapter.Fill(tb);

						if (tb.Rows.Count > 0)
						{
							MessageBox.Show("Login Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

							MainForm mainForm = new MainForm();
							mainForm.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Incorrect Username or Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connect.CloseConnection();
				}
			}
		}
	}
}
