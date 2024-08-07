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

namespace EmployeeManagementSystem.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			lbWelcome.Text = "Welcome, " + Helper.UserName;
		}

		Connect connect = new Connect();
		
		//SWITCH ADMIN CONTROL TO ADD USER CONTROL
		public void SwitchAdminToAddUser()
		{
			addUser1.Visible = true;
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = false;
			employee1.Visible = false;

			Admin admin = admin1 as Admin;

			if(admin != null)
			{
				admin.RefreshData();
			}
		}

		//SWITCH ADD USER CONTROL TO ADMIN CONTROL
		public void SwitchAddUserToAdmin()
		{
			addUser1.Visible = false;
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = true;
			employee1.Visible = false;

			Admin admin = admin1 as Admin;

			if(admin != null)
			{
				admin.RefreshData();
			}
		}

		//SWITCH EMPLOYEES CONTROL TO ADD EMPLOYEE CONTROL
		public void SwitchEmployeeToAddEmployee()
		{
			addEmployee1.Visible = true;
			addUser1.Visible = false;
			dashboard1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = false;
			employee1.Visible = false;

			Employee employee = employee1 as Employee;

			if(employee != null)
			{
				employee.RefreshData();
			}
		}
		
		//DASHBOARD BUTTON
		private void main_btnDashboard_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = true;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = false;
			employee1.Visible = false;
			addUser1.Visible = false;	

			Dashboard dashboard = dashboard1 as Dashboard;

			if(dashboard != null)
			{
				dashboard.RefreshData();
			}
		}

		//EMPLOYEE BUTTON
		private void main_btnEmployee_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = false;
			addUser1.Visible = false;
			employee1.Visible = true;

			Employee employee = employee1 as Employee;

			if(employee != null)
			{
				employee.RefreshData();
			}
		}

		//SALARY BUTTON
		private void main_btnSalary_Click(object sender, EventArgs e)
		{
			if (Helper.UserRights == "User")
			{
				MessageBox.Show("You don't have permission to open.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			else
			{
				dashboard1.Visible = false;
				addEmployee1.Visible = false;
				salary1.Visible = true;
				support1.Visible = false;
				admin1.Visible = false;
				employee1.Visible = false;
				addUser1.Visible = false;

				Salary salary = salary1 as Salary;

				if (salary != null)
				{
					salary.RefreshData();
				}
			}
		}

		//HELP BUTTON
		private void main_btnHelp_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = true;
			admin1.Visible = false;
			employee1.Visible = false;
			addUser1.Visible = false;
		}

		//ADMIN BUTTON
		private void main_btnAdmin_Click(object sender, EventArgs e)
		{				
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
			admin1.Visible = true;
			employee1.Visible = false;
			addUser1.Visible = false;

			Admin admin = admin1 as Admin;

			if (admin != null)
			{
				admin.RefreshData();
			}
		}

		//EXIT BUTTON
		private void main_btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		//LOG OUT BUTTON
		private void btn_Logout_Click(object sender, EventArgs e)
		{
			DialogResult check = MessageBox.Show("Are you sure you want to logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (check == DialogResult.Yes)
			{
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
				this.Hide();
			}
		}
	}
}
