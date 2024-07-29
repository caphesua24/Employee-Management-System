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
	public partial class Dashboard : UserControl
	{
		public Dashboard()
		{
			InitializeComponent();

			DisplayTotalEmployee();
			DisplayActiveEmployee();
			DisplayInactiveEmployee();

		}

		Connect connect = new Connect();

		MessagesCustom messageCus = new MessagesCustom();

		//REFRESH DATA WHEN ADD EMPLOYEE
		public void RefreshData()
		{
			if (InvokeRequired)
			{
				Invoke((MethodInvoker)RefreshData);
				return;
			}
			DisplayTotalEmployee();
			DisplayActiveEmployee();
			DisplayInactiveEmployee();
		}

		private void DisplayTotalEmployee()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT COUNT(id) FROM employees WHERE delete_date IS NULL";

				using (SqlCommand cmd = new SqlCommand(sql, connect.conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					if (reader.Read())
					{
						int count = Convert.ToInt32(reader[0]);
						dashboard_totalE.Text = count.ToString();
					}
					reader.Close();
				}
			}
			catch (Exception ex)
			{
				messageCus.ErrorMessage("Error: " + ex.Message);
			}
		}

		private void DisplayActiveEmployee()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

				using(SqlCommand cmd = new SqlCommand(sql, connect.conn))
				{
					cmd.Parameters.AddWithValue("@status", "Active");
					SqlDataReader reader = cmd.ExecuteReader();

					if(reader.Read())
					{
						int count = Convert.ToInt32(reader[0]);
						dashboard_actE.Text = count.ToString();
					}
				}
			}
			catch(Exception ex )
			{
				messageCus.ErrorMessage("Error: " + ex.Message);
			}
		}

		private void DisplayInactiveEmployee()
		{
			try
			{
				connect.OpenConnection();

				string sql = "SELECT COUNT(id) FROM employees WHERE status = @status AND delete_date IS NULL";

				using(SqlCommand cmd = new SqlCommand(sql, connect.conn))
				{
					cmd.Parameters.AddWithValue("@status", "Inactive");
					SqlDataReader reader = cmd.ExecuteReader();

					if(reader.Read())
					{
						int count = Convert.ToInt32(reader[0]);
						dashboard_inActE.Text = count.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				messageCus.ErrorMessage("Error: " + ex.Message);
			}
		}

	}
}
