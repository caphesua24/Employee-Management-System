using EmployeeManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Forms
{
	public partial class AddEmployee : UserControl
	{
		Connect connect = new Connect();

		MessagesCustom messages = new MessagesCustom();

		public AddEmployee()
		{
			InitializeComponent();

			LoadEmployees();

			dataGridView1.EnableDoubleBuffering(true);

			DatagridviewForm();
		}

		//LOAD DATA FORM DATABASE TO DATA GRID VIEW
		void LoadEmployees()
		{
			connect.OpenConnection();

			//string loadEmployee = "SELECT * FROM employees";
			//string loadEmployee = "SELECT id, employee_id, full_name, contact_number, gender, position, salary, image, status, insert_date from employees";
			string loadEmployee = "SELECT id, employee_id, full_name, contact_number, gender, position, salary, image, status, insert_date FROM employees WHERE delete_date IS NULL";

			dataGridView1.DataSource = connect.tb(loadEmployee).DefaultView;
		}

		//SET CUSTOM COLUMN HEADERS
		private void DatagridviewForm()
		{
			dataGridView1.Columns["id"].HeaderText = "ID";
			dataGridView1.Columns["employee_id"].HeaderText = "EmployeeID";
			dataGridView1.Columns["full_name"].HeaderText = "Name";
			dataGridView1.Columns["gender"].HeaderText = "Gender";
			dataGridView1.Columns["contact_number"].HeaderText = "Contact";
			dataGridView1.Columns["position"].HeaderText = "Position";
			dataGridView1.Columns["status"].HeaderText = "Status";
			dataGridView1.Columns["salary"].HeaderText = "Salary";
			dataGridView1.Columns["image"].HeaderText = "Image";
			dataGridView1.Columns["insert_date"].HeaderText = "InsertDate";
		}

		//CLEAR ALL FILED
		void ClearAllField()
		{
			addEmployee_txbEmployeeID.Text = "";
			addEmployee_txbFullname.Text = "";
			addEmployee_txbPhone.Text = "";
			addEmployee_cbxGender.SelectedIndex = -1;
			addEmployee_cbxPosition.SelectedIndex = -1;
			addEmployee_cbxStatus.SelectedIndex = -1 ;
			addEmployee_pictureBox.Image = null;
		}

		//IMPORT IMAGE BUTTON
		private void addEmployee_btnImport_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "Image file(*.jpg;*.png) |*.jpg;*.png";

				string imagePath = "";

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					imagePath = dialog.FileName;
					addEmployee_pictureBox.ImageLocation = imagePath;
				}
			}
			catch (Exception ex)
			{
				messages.ErrorMessage("Error: " + ex.Message);
			}
		}

		//ADD BUTTON
		private void adEmployee_btnAdd_Click(object sender, EventArgs e)
		{
			string EmployeeID = addEmployee_txbEmployeeID.Text;

			DateTime today = DateTime.Today;

			if (addEmployee_txbEmployeeID.Text == "" || addEmployee_txbFullname.Text == "" ||
				addEmployee_txbPhone.Text == "" || addEmployee_cbxGender.Text == "" || 
				addEmployee_cbxPosition.Text == "" || addEmployee_cbxStatus.Text == "")
			{
				messages.ErrorMessage("Please fill all the required field.");
			}
			else
			{
				try
				{
					connect.OpenConnection();

					string checkEmID = "SELECT * FROM employees WHERE employee_id = '" + EmployeeID + "' AND delete_date IS NULL";

					int emID = connect.tb(checkEmID).Rows.Count;

					if(emID == 1)
					{
						messages.ErrorMessage("This employee existed.");
					}
					else
					{
						string path = Path.Combine(@"C:\Users\ASUS\source\repos\EmployeeManagementSystem\EmployeeManagementSystem\Images_Employees\"
						 + addEmployee_txbEmployeeID.Text.Trim() + ".jpg");

						string ImagesEmPath = Path.GetDirectoryName(path);

						if(Directory.Exists(ImagesEmPath))


						{
							Directory.CreateDirectory(ImagesEmPath);
						}

						File.Copy(addEmployee_pictureBox.ImageLocation, path, true);

						string insertEmployee = "INSERT INTO employees (employee_id, full_name, gender, contact_number, position, salary, image, insert_date, status)" +
							"VALUES (@employee_id, @full_name, @gender, @contact_number, @position, @salary, @image, @insert_date, @status)";

						using(SqlCommand cmd = new SqlCommand(insertEmployee, connect.conn))
						{
							cmd.Parameters.AddWithValue("@employee_id", addEmployee_txbEmployeeID.Text.Trim());
							cmd.Parameters.AddWithValue("@full_name", addEmployee_txbFullname.Text.Trim());
							cmd.Parameters.AddWithValue("@gender", addEmployee_cbxGender.Text.Trim());
							cmd.Parameters.AddWithValue("@contact_number", addEmployee_txbPhone.Text.Trim());
							cmd.Parameters.AddWithValue("@position", addEmployee_cbxPosition.Text.Trim());
							cmd.Parameters.AddWithValue("@image", path);
							cmd.Parameters.AddWithValue("@insert_date", today);
							cmd.Parameters.AddWithValue("@status", addEmployee_cbxStatus.Text.Trim());
							cmd.Parameters.AddWithValue("@salary", 0);

							cmd.ExecuteNonQuery();

							LoadEmployees();

							messages.SuccessMessage("Add successfully!");

							ClearAllField();
						}
					}
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
		}

		//UPDATE BUTTON
		private void addEmployee_btnUpdate_Click(object sender, EventArgs e)
		{
			string EmployeeID = addEmployee_txbEmployeeID.Text.Trim();

			DialogResult result = MessageBox.Show("Are you sure you want to UPDATE Employee ID " + EmployeeID, "Confirmation Message",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				if (addEmployee_txbEmployeeID.Text == "" || addEmployee_txbFullname.Text == "" ||
				addEmployee_txbPhone.Text == "" || addEmployee_cbxGender.Text == "" ||
				addEmployee_cbxStatus.Text == "" || addEmployee_pictureBox.Image == null
				)
				{
					messages.ErrorMessage("Please fill all the required field.");
				}
				else
				{
					try
					{
						connect.OpenConnection();

						string query = "SELECT * FROM employees WHERE employee_id = '" + EmployeeID + "' AND delete_date IS NULL";

						int count = connect.tb(query).Rows.Count;

						if (count != 1)
						{
							messages.ErrorMessage("This Employee is not exist. Please check again!");
						}
						else
						{
							DateTime today = DateTime.Today;
							string updateQuery = "UPDATE employees SET full_name = @fullName, contact_number = @phone, "
								+ "gender = @gender, position = @position, status = @status, update_date = @updateDate "
								+ "WHERE employee_id = @employeeID";

							using (SqlCommand cmd = new SqlCommand(updateQuery, connect.conn))
							{
								cmd.Parameters.AddWithValue("@fullName", addEmployee_txbFullname.Text.Trim());
								cmd.Parameters.AddWithValue("@phone", addEmployee_txbPhone.Text.Trim());
								cmd.Parameters.AddWithValue("@gender", addEmployee_cbxGender.Text.Trim());
								cmd.Parameters.AddWithValue("@position", addEmployee_cbxPosition.Text.Trim());
								cmd.Parameters.AddWithValue("@status", addEmployee_cbxStatus.Text.Trim());
								cmd.Parameters.AddWithValue("@updateDate", today);
								cmd.Parameters.AddWithValue("@employeeID", EmployeeID);

								cmd.ExecuteNonQuery();

								LoadEmployees();

								messages.SuccessMessage("Update Employee ID " + EmployeeID + " successfully!");

								ClearAllField();
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
			else
			{
				MessageBox.Show("Canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		//DELETE BUTTON
		private void addEmployee_btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to UPDATE ?", "Confirmation Message", 
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(result == DialogResult.Yes)
			{
				if (addEmployee_txbEmployeeID.Text == "")
				{
					messages.ErrorMessage("Please fill the employee ID field.");
				}
				else
				{
					try
					{
						connect.OpenConnection();

						string EmployeeID = addEmployee_txbEmployeeID.Text.Trim();	

						string checkID = "SELECT * FROM employees WHERE employee_id = '" + EmployeeID + "' AND delete_date IS NULL";

						int emID = connect.tb(checkID).Rows.Count;

						if (emID != 1)
						{
							messages.ErrorMessage("Employee ID is not exist.");
						}
						else
						{
							//string sql = "DELETE FROM employees WHERE employee_id = '" + EmployeeID + "'";
							DateTime today = DateTime.Today;

							string sql = "UPDATE employees SET delete_date = @delete_date WHERE employee_id = @employeeID";

							using (SqlCommand cmd = new SqlCommand(sql, connect.conn))
							{
								cmd.Parameters.AddWithValue("@delete_date", today);
								cmd.Parameters.AddWithValue("@employeeID", EmployeeID);

								cmd.ExecuteNonQuery();

								LoadEmployees();
							}
							messages.SuccessMessage("Delete Employee " + EmployeeID + " successfully.");

							ClearAllField();
						}
					}
					catch (Exception ex)
					{
						messages.ErrorMessage("Cannot delete this employee. Error: " + ex.Message);
					}
					finally
					{
						connect.CloseConnection();
					}
				}
			}
			else
			{
				MessageBox.Show("Canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		//CLEAR BUTTON
		private void addEmployee_btnClear_Click(object sender, EventArgs e)
		{
			ClearAllField();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

				addEmployee_txbEmployeeID.Text = row.Cells[1].Value.ToString();
				addEmployee_txbFullname.Text = row.Cells[2].Value.ToString();
				addEmployee_txbPhone.Text = row.Cells[3].Value.ToString();
				addEmployee_cbxGender.Text = row.Cells[4].Value.ToString();
				addEmployee_cbxPosition.Text = row.Cells[5].Value.ToString();

				string imagePath = row.Cells[7].Value.ToString();

				if (imagePath != null)
				{
					addEmployee_pictureBox.Image = Image.FromFile(imagePath);
				}
				else
				{
					addEmployee_pictureBox.Image = null;
				}

				addEmployee_cbxStatus.Text = row.Cells[8].Value.ToString();
			}
		}

	}
}
