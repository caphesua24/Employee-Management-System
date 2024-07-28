﻿using EmployeeManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		}

		private void label1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void lbWelcome_Click(object sender, EventArgs e)
		{

		}
		
		private void main_btnLogout_Click(object sender, EventArgs e)
		{
			DialogResult check = MessageBox.Show("Are you sure you want to logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (check == DialogResult.Yes)
			{
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
				this.Hide();

			}
		}

		private void main_btnDashboard_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = true;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = false;
		}

		private void main_btnAddEmployee_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = false;
			addEmployee1.Visible = true;
			salary1.Visible = false;
			support1.Visible = false;
		}

		private void main_btnSalary_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = true;
			support1.Visible = false;
		}

		private void main_btnHelp_Click(object sender, EventArgs e)
		{
			dashboard1.Visible = false;
			addEmployee1.Visible = false;
			salary1.Visible = false;
			support1.Visible = true;
		}
	}
}