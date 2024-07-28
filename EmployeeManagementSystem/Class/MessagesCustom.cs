using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Class
{
	public class MessagesCustom
	{
		public void SuccessMessage(string message)
		{
			MessageBox.Show(message, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void ErrorMessage(string error_message)
		{
			MessageBox.Show(error_message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void ConfirmationMessage(string message)
		{
			MessageBox.Show(message, "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
	}
}
