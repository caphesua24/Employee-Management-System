namespace EmployeeManagementSystem.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label2 = new System.Windows.Forms.Label();
			this.main_btnExit = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.main_btnDashboard = new System.Windows.Forms.Button();
			this.main_btnEmployee = new System.Windows.Forms.Button();
			this.main_btnSalary = new System.Windows.Forms.Button();
			this.main_btnHelp = new System.Windows.Forms.Button();
			this.main_btnAdmin = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_Logout = new System.Windows.Forms.Button();
			this.dashboard1 = new EmployeeManagementSystem.Forms.Dashboard();
			this.employee1 = new EmployeeManagementSystem.Controls.Employee();
			this.admin1 = new EmployeeManagementSystem.Forms.Admin();
			this.addEmployee1 = new EmployeeManagementSystem.Forms.AddEmployee();
			this.salary1 = new EmployeeManagementSystem.Forms.Salary();
			this.support1 = new EmployeeManagementSystem.Forms.Support();
			this.addUser1 = new EmployeeManagementSystem.Controls.AddUser();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(2, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Employee Management System";
			// 
			// main_btnExit
			// 
			this.main_btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.main_btnExit.FlatAppearance.BorderSize = 0;
			this.main_btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnExit.ForeColor = System.Drawing.Color.White;
			this.main_btnExit.Location = new System.Drawing.Point(1070, 3);
			this.main_btnExit.Name = "main_btnExit";
			this.main_btnExit.Size = new System.Drawing.Size(25, 25);
			this.main_btnExit.TabIndex = 2;
			this.main_btnExit.Text = "X";
			this.main_btnExit.UseVisualStyleBackColor = false;
			this.main_btnExit.Click += new System.EventHandler(this.main_btnExit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.main_btnExit);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1100, 35);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\EmployeeManagementSystem\\EmployeeManagementSystem\\Reso" +
    "urces\\welcome_employee.png";
			this.pictureBox1.Location = new System.Drawing.Point(59, 24);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lbWelcome
			// 
			this.lbWelcome.AutoSize = true;
			this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbWelcome.ForeColor = System.Drawing.Color.White;
			this.lbWelcome.Location = new System.Drawing.Point(55, 137);
			this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbWelcome.Name = "lbWelcome";
			this.lbWelcome.Size = new System.Drawing.Size(104, 17);
			this.lbWelcome.TabIndex = 1;
			this.lbWelcome.Text = "Welcome, User";
			// 
			// main_btnDashboard
			// 
			this.main_btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.main_btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.main_btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnDashboard.ForeColor = System.Drawing.Color.White;
			this.main_btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("main_btnDashboard.Image")));
			this.main_btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.main_btnDashboard.Location = new System.Drawing.Point(26, 196);
			this.main_btnDashboard.Margin = new System.Windows.Forms.Padding(2);
			this.main_btnDashboard.Name = "main_btnDashboard";
			this.main_btnDashboard.Size = new System.Drawing.Size(170, 37);
			this.main_btnDashboard.TabIndex = 2;
			this.main_btnDashboard.Text = "DASHBOARD";
			this.main_btnDashboard.UseVisualStyleBackColor = true;
			this.main_btnDashboard.Click += new System.EventHandler(this.main_btnDashboard_Click);
			// 
			// main_btnEmployee
			// 
			this.main_btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.main_btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.main_btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnEmployee.ForeColor = System.Drawing.Color.White;
			this.main_btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("main_btnEmployee.Image")));
			this.main_btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.main_btnEmployee.Location = new System.Drawing.Point(26, 306);
			this.main_btnEmployee.Margin = new System.Windows.Forms.Padding(2);
			this.main_btnEmployee.Name = "main_btnEmployee";
			this.main_btnEmployee.Size = new System.Drawing.Size(170, 37);
			this.main_btnEmployee.TabIndex = 3;
			this.main_btnEmployee.Text = "EMPLOYEE";
			this.main_btnEmployee.UseVisualStyleBackColor = true;
			this.main_btnEmployee.Click += new System.EventHandler(this.main_btnEmployee_Click);
			// 
			// main_btnSalary
			// 
			this.main_btnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
			this.main_btnSalary.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.main_btnSalary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnSalary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnSalary.ForeColor = System.Drawing.Color.White;
			this.main_btnSalary.Image = ((System.Drawing.Image)(resources.GetObject("main_btnSalary.Image")));
			this.main_btnSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.main_btnSalary.Location = new System.Drawing.Point(26, 362);
			this.main_btnSalary.Margin = new System.Windows.Forms.Padding(2);
			this.main_btnSalary.Name = "main_btnSalary";
			this.main_btnSalary.Size = new System.Drawing.Size(170, 37);
			this.main_btnSalary.TabIndex = 4;
			this.main_btnSalary.Text = "SALARY";
			this.main_btnSalary.UseVisualStyleBackColor = true;
			this.main_btnSalary.Click += new System.EventHandler(this.main_btnSalary_Click);
			// 
			// main_btnHelp
			// 
			this.main_btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.main_btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.main_btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnHelp.ForeColor = System.Drawing.Color.White;
			this.main_btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("main_btnHelp.Image")));
			this.main_btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.main_btnHelp.Location = new System.Drawing.Point(26, 417);
			this.main_btnHelp.Margin = new System.Windows.Forms.Padding(2);
			this.main_btnHelp.Name = "main_btnHelp";
			this.main_btnHelp.Size = new System.Drawing.Size(170, 37);
			this.main_btnHelp.TabIndex = 5;
			this.main_btnHelp.Text = "SUPPORT";
			this.main_btnHelp.UseVisualStyleBackColor = true;
			this.main_btnHelp.Click += new System.EventHandler(this.main_btnHelp_Click);
			// 
			// main_btnAdmin
			// 
			this.main_btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.main_btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.main_btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.main_btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.main_btnAdmin.ForeColor = System.Drawing.Color.White;
			this.main_btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("main_btnAdmin.Image")));
			this.main_btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.main_btnAdmin.Location = new System.Drawing.Point(26, 252);
			this.main_btnAdmin.Margin = new System.Windows.Forms.Padding(2);
			this.main_btnAdmin.Name = "main_btnAdmin";
			this.main_btnAdmin.Size = new System.Drawing.Size(170, 37);
			this.main_btnAdmin.TabIndex = 7;
			this.main_btnAdmin.Text = "ADMIN";
			this.main_btnAdmin.UseVisualStyleBackColor = true;
			this.main_btnAdmin.Click += new System.EventHandler(this.main_btnAdmin_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.panel2.Controls.Add(this.main_btnAdmin);
			this.panel2.Controls.Add(this.main_btnHelp);
			this.panel2.Controls.Add(this.main_btnSalary);
			this.panel2.Controls.Add(this.main_btnEmployee);
			this.panel2.Controls.Add(this.main_btnDashboard);
			this.panel2.Controls.Add(this.lbWelcome);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.btn_Logout);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.panel2.Location = new System.Drawing.Point(0, 35);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(225, 565);
			this.panel2.TabIndex = 1;
			// 
			// btn_Logout
			// 
			this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.btn_Logout.ForeColor = System.Drawing.Color.White;
			this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Logout.Location = new System.Drawing.Point(0, 540);
			this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Logout.Name = "btn_Logout";
			this.btn_Logout.Size = new System.Drawing.Size(225, 25);
			this.btn_Logout.TabIndex = 8;
			this.btn_Logout.Text = "LOG OUT";
			this.btn_Logout.UseVisualStyleBackColor = true;
			this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
			// 
			// dashboard1
			// 
			this.dashboard1.Location = new System.Drawing.Point(225, 35);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new System.Drawing.Size(875, 565);
			this.dashboard1.TabIndex = 8;
			// 
			// employee1
			// 
			this.employee1.Location = new System.Drawing.Point(225, 35);
			this.employee1.Name = "employee1";
			this.employee1.Size = new System.Drawing.Size(875, 565);
			this.employee1.TabIndex = 7;
			// 
			// admin1
			// 
			this.admin1.AllowDrop = true;
			this.admin1.AutoScroll = true;
			this.admin1.Location = new System.Drawing.Point(225, 35);
			this.admin1.Name = "admin1";
			this.admin1.Size = new System.Drawing.Size(875, 565);
			this.admin1.TabIndex = 6;
			// 
			// addEmployee1
			// 
			this.addEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addEmployee1.Location = new System.Drawing.Point(225, 35);
			this.addEmployee1.Name = "addEmployee1";
			this.addEmployee1.Size = new System.Drawing.Size(875, 565);
			this.addEmployee1.TabIndex = 5;
			// 
			// salary1
			// 
			this.salary1.Location = new System.Drawing.Point(225, 35);
			this.salary1.Name = "salary1";
			this.salary1.Size = new System.Drawing.Size(875, 565);
			this.salary1.TabIndex = 4;
			// 
			// support1
			// 
			this.support1.Location = new System.Drawing.Point(225, 35);
			this.support1.Name = "support1";
			this.support1.Size = new System.Drawing.Size(875, 565);
			this.support1.TabIndex = 3;
			// 
			// addUser1
			// 
			this.addUser1.Location = new System.Drawing.Point(225, 35);
			this.addUser1.Name = "addUser1";
			this.addUser1.Size = new System.Drawing.Size(875, 565);
			this.addUser1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.Controls.Add(this.dashboard1);
			this.Controls.Add(this.employee1);
			this.Controls.Add(this.admin1);
			this.Controls.Add(this.addEmployee1);
			this.Controls.Add(this.salary1);
			this.Controls.Add(this.support1);
			this.Controls.Add(this.addUser1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button main_btnExit;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbWelcome;
		private System.Windows.Forms.Button main_btnDashboard;
		private System.Windows.Forms.Button main_btnEmployee;
		private System.Windows.Forms.Button main_btnSalary;
		private System.Windows.Forms.Button main_btnHelp;
		private System.Windows.Forms.Button main_btnAdmin;
		private System.Windows.Forms.Panel panel2;
		private Controls.AddUser addUser1;
		private Support support1;
		private Salary salary1;
		private AddEmployee addEmployee1;
		private Admin admin1;
		private Controls.Employee employee1;
		private Dashboard dashboard1;
		private System.Windows.Forms.Button btn_Logout;
	}
}