namespace EmployeeManagementSystem.Forms
{
	partial class Salary
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.salary_cbxPosition = new System.Windows.Forms.ComboBox();
			this.salary_txbPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.salary_cbxGender = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.salary_btnClear = new System.Windows.Forms.Button();
			this.salary_btnUpdate = new System.Windows.Forms.Button();
			this.salary_txbSalary = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.salary_txbFullname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.salary_txbEmployeeID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(17, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 260);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(840, 260);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.salary_cbxPosition);
			this.panel2.Controls.Add(this.salary_txbPhone);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.salary_cbxGender);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.salary_btnClear);
			this.panel2.Controls.Add(this.salary_btnUpdate);
			this.panel2.Controls.Add(this.salary_txbSalary);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.salary_txbFullname);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.salary_txbEmployeeID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(17, 340);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 210);
			this.panel2.TabIndex = 1;
			// 
			// salary_cbxPosition
			// 
			this.salary_cbxPosition.FormattingEnabled = true;
			this.salary_cbxPosition.Items.AddRange(new object[] {
            "Software Developer",
            "Tester",
            "Leader",
            "Manager",
            "General"});
			this.salary_cbxPosition.Location = new System.Drawing.Point(576, 63);
			this.salary_cbxPosition.Name = "salary_cbxPosition";
			this.salary_cbxPosition.Size = new System.Drawing.Size(121, 21);
			this.salary_cbxPosition.TabIndex = 25;
			// 
			// salary_txbPhone
			// 
			this.salary_txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.salary_txbPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_txbPhone.Location = new System.Drawing.Point(576, 24);
			this.salary_txbPhone.Name = "salary_txbPhone";
			this.salary_txbPhone.Size = new System.Drawing.Size(230, 23);
			this.salary_txbPhone.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(466, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Phone Number:";
			// 
			// salary_cbxGender
			// 
			this.salary_cbxGender.FormattingEnabled = true;
			this.salary_cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
			this.salary_cbxGender.Location = new System.Drawing.Point(132, 103);
			this.salary_cbxGender.Name = "salary_cbxGender";
			this.salary_cbxGender.Size = new System.Drawing.Size(121, 21);
			this.salary_cbxGender.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(22, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 16);
			this.label6.TabIndex = 21;
			this.label6.Text = "Gender:";
			// 
			// salary_btnClear
			// 
			this.salary_btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.salary_btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.salary_btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.salary_btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.salary_btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_btnClear.ForeColor = System.Drawing.Color.White;
			this.salary_btnClear.Location = new System.Drawing.Point(462, 174);
			this.salary_btnClear.Name = "salary_btnClear";
			this.salary_btnClear.Size = new System.Drawing.Size(100, 33);
			this.salary_btnClear.TabIndex = 20;
			this.salary_btnClear.Text = "Clear";
			this.salary_btnClear.UseVisualStyleBackColor = false;
			this.salary_btnClear.Click += new System.EventHandler(this.salary_btnClear_Click);
			// 
			// salary_btnUpdate
			// 
			this.salary_btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.salary_btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.salary_btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.salary_btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.salary_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.salary_btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_btnUpdate.ForeColor = System.Drawing.Color.White;
			this.salary_btnUpdate.Location = new System.Drawing.Point(262, 174);
			this.salary_btnUpdate.Name = "salary_btnUpdate";
			this.salary_btnUpdate.Size = new System.Drawing.Size(100, 33);
			this.salary_btnUpdate.TabIndex = 18;
			this.salary_btnUpdate.Text = "Update";
			this.salary_btnUpdate.UseVisualStyleBackColor = false;
			this.salary_btnUpdate.Click += new System.EventHandler(this.salary_btnUpdate_Click);
			// 
			// salary_txbSalary
			// 
			this.salary_txbSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.salary_txbSalary.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_txbSalary.Location = new System.Drawing.Point(576, 101);
			this.salary_txbSalary.Name = "salary_txbSalary";
			this.salary_txbSalary.Size = new System.Drawing.Size(230, 23);
			this.salary_txbSalary.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(466, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Salary:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(466, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Position:";
			// 
			// salary_txbFullname
			// 
			this.salary_txbFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.salary_txbFullname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_txbFullname.Location = new System.Drawing.Point(132, 63);
			this.salary_txbFullname.Name = "salary_txbFullname";
			this.salary_txbFullname.Size = new System.Drawing.Size(230, 23);
			this.salary_txbFullname.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(22, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "Full Name:";
			// 
			// salary_txbEmployeeID
			// 
			this.salary_txbEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.salary_txbEmployeeID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.salary_txbEmployeeID.Location = new System.Drawing.Point(132, 24);
			this.salary_txbEmployeeID.Name = "salary_txbEmployeeID";
			this.salary_txbEmployeeID.Size = new System.Drawing.Size(230, 23);
			this.salary_txbEmployeeID.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(22, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Employee ID:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Location = new System.Drawing.Point(15, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 50);
			this.panel3.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(78, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "SALARY";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 50);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Salary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Salary";
			this.Size = new System.Drawing.Size(875, 565);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox salary_txbSalary;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox salary_txbFullname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox salary_txbEmployeeID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button salary_btnClear;
		private System.Windows.Forms.Button salary_btnUpdate;
		private System.Windows.Forms.TextBox salary_txbPhone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox salary_cbxGender;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox salary_cbxPosition;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
