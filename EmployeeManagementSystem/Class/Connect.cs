using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Class
{
	public class Connect
	{
		private string connectionString = @"Data Source=LAPTOP-TCB3NNMV\SQLEXPRESS;Initial Catalog=EmployeeManagementSystem;Integrated Security=True;Encrypt=False";

		public SqlConnection conn;

		SqlDataAdapter da;
		DataTable dt;
		SqlCommand cmd;

		//open connect
		public void OpenConnection()
		{
			conn = new SqlConnection(connectionString);

			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		//close connect
		public void CloseConnection()
		{
			conn = new SqlConnection(connectionString);

			try
			{
				if(conn.State == System.Data.ConnectionState.Open)
				{
					conn.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cannot close connect to database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public DataTable tb(string sql)
		{
			OpenConnection();
			da = new SqlDataAdapter(sql, conn);
			dt = new DataTable();
			da.Fill(dt);
			return dt;
		}

		public void ExcuteNonQuery(string query)
		{
			OpenConnection();
			cmd = new SqlCommand(query);
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
	}
}
