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
	public partial class Support : UserControl
	{
		public Support()
		{
			InitializeComponent();
			ShowHelpInPanelWithScroll();
		}

		private void ShowHelpInPanelWithScroll()
		{
			panel1.Controls.Clear();
			panel1.AutoScroll = true;

			Label lblHelpContent = new Label();
			lblHelpContent.Text = "\nSoftware Introduction\n----------------------\n" +
							  "Software Name: Employee Management System\nVersion: 1.0\nPurpose: Manage employee information\n\n" +
							  "User Permissions\n------------------\n" +
							  "The system assigns user permissions to ensure security and task delegation.\n" +
							  "Only users logged in with admin rights can perform add, edit, delete operations in Admin Control and Salary Control.\n\n" +
							  "Dashboard Control\n------------------\n" +
							  "The Dashboard interface displays an overview of the total number of employees in the company.\n\n" +
							  "Admin Control\n--------------\n" +
							  "1. Displays a list of users and admins.\n" +
							  "2. Only users with admin rights can:\n" +
							  "   - Add users: Click the 'Add' button and fill in the information.\n" +
							  "   - Edit user information: Select the user to edit and click 'Update'.\n" +
							  "   - Delete users: Select the user to delete and click 'Delete'.\n\n" +
							  "Employee Control\n-----------------\n" +
							  "1. Displays a list of employees.\n" +
							  "2. Use the ComboBox to filter employee status.\n" +
							  "3. Use the Search Box to search for employees by keyword.\n" +
							  "4. Add, edit, delete employees:\n" +
							  "   - Add employees: Click the 'Add' button and fill in the information.\n" +
							  "   - Edit employee information: Select the employee to edit and click 'Edit'.\n" +
							  "   - Delete employees: Select the employee to delete and click 'Delete'.\n\n" +
							  "Salary Control\n---------------\n" +
							  "1. Displays and updates employee salaries.\n" +
							  "2. Only users with admin rights can access and edit salary information.\n\n" +
							  "Support Control\n----------------\n" +
							  "1. Displays software usage instructions.\n" +
							  "2. Provides contact information for support.\n\n" +
							  "Frequently Asked Questions (FAQ)\n----------------------------------\n" +
							  "Q: How do I add an employee?\n" +
							  "A: Go to Employee Control, click the 'Add Employee' button and fill in the information.\n\n" +
							  "Q: How do I filter data?\n" +
							  "A: Use the search box and ComboBox to filter data.\n\n" +
							  "Troubleshooting\n----------------\n" +
							  "- Connection issues: Check network connection and database configuration.\n\n" +
							  "Support Contact Information\n----------------------------\n" +
							  "Email: nguyenthilua2308@gmail.com\n\n";
			lblHelpContent.AutoSize = true;

			panel1.Controls.Add(lblHelpContent);
		}

	}
}
