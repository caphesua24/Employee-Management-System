namespace EmployeeManagementSystem.Forms
{
	partial class AddEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.addEmployee_txbEmployeeID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addEmployee_txbFullname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addEmployee_cbxGender = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addEmployee_txbPhone = new System.Windows.Forms.TextBox();
			this.addEmployee_pictureBox = new System.Windows.Forms.PictureBox();
			this.addEmployee_btnImport = new System.Windows.Forms.Button();
			this.addEmployee_btnUpdate = new System.Windows.Forms.Button();
			this.addEmployee_btnClear = new System.Windows.Forms.Button();
			this.addEmployee_btnDelete = new System.Windows.Forms.Button();
			this.adEmployee_btnAdd = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.addEmployee_cbxPosition = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.addEmployee_cbxStatus = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addEmployee_pictureBox)).BeginInit();
			this.panel2.SuspendLayout();
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
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
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
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(15, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 50);
			this.panel3.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(78, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(202, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "EMPLOYEES DATA";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(57, 45);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(27, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee ID:";
			// 
			// addEmployee_txbEmployeeID
			// 
			this.addEmployee_txbEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addEmployee_txbEmployeeID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_txbEmployeeID.Location = new System.Drawing.Point(137, 20);
			this.addEmployee_txbEmployeeID.Name = "addEmployee_txbEmployeeID";
			this.addEmployee_txbEmployeeID.Size = new System.Drawing.Size(230, 23);
			this.addEmployee_txbEmployeeID.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(27, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full Name:";
			// 
			// addEmployee_txbFullname
			// 
			this.addEmployee_txbFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addEmployee_txbFullname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_txbFullname.Location = new System.Drawing.Point(137, 63);
			this.addEmployee_txbFullname.Name = "addEmployee_txbFullname";
			this.addEmployee_txbFullname.Size = new System.Drawing.Size(230, 23);
			this.addEmployee_txbFullname.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(447, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Gender:";
			// 
			// addEmployee_cbxGender
			// 
			this.addEmployee_cbxGender.FormattingEnabled = true;
			this.addEmployee_cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
			this.addEmployee_cbxGender.Location = new System.Drawing.Point(510, 22);
			this.addEmployee_cbxGender.Name = "addEmployee_cbxGender";
			this.addEmployee_cbxGender.Size = new System.Drawing.Size(121, 21);
			this.addEmployee_cbxGender.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(27, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone Number:";
			// 
			// addEmployee_txbPhone
			// 
			this.addEmployee_txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addEmployee_txbPhone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_txbPhone.Location = new System.Drawing.Point(137, 107);
			this.addEmployee_txbPhone.Name = "addEmployee_txbPhone";
			this.addEmployee_txbPhone.Size = new System.Drawing.Size(230, 23);
			this.addEmployee_txbPhone.TabIndex = 5;
			// 
			// addEmployee_pictureBox
			// 
			this.addEmployee_pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.addEmployee_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addEmployee_pictureBox.Location = new System.Drawing.Point(704, 10);
			this.addEmployee_pictureBox.Name = "addEmployee_pictureBox";
			this.addEmployee_pictureBox.Size = new System.Drawing.Size(100, 120);
			this.addEmployee_pictureBox.TabIndex = 8;
			this.addEmployee_pictureBox.TabStop = false;
			// 
			// addEmployee_btnImport
			// 
			this.addEmployee_btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addEmployee_btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addEmployee_btnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addEmployee_btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addEmployee_btnImport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_btnImport.ForeColor = System.Drawing.Color.White;
			this.addEmployee_btnImport.Location = new System.Drawing.Point(704, 136);
			this.addEmployee_btnImport.Name = "addEmployee_btnImport";
			this.addEmployee_btnImport.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnImport.TabIndex = 7;
			this.addEmployee_btnImport.Text = "Import";
			this.addEmployee_btnImport.UseVisualStyleBackColor = false;
			this.addEmployee_btnImport.Click += new System.EventHandler(this.addEmployee_btnImport_Click);
			// 
			// addEmployee_btnUpdate
			// 
			this.addEmployee_btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addEmployee_btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addEmployee_btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addEmployee_btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addEmployee_btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_btnUpdate.ForeColor = System.Drawing.Color.White;
			this.addEmployee_btnUpdate.Location = new System.Drawing.Point(197, 163);
			this.addEmployee_btnUpdate.Name = "addEmployee_btnUpdate";
			this.addEmployee_btnUpdate.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnUpdate.TabIndex = 9;
			this.addEmployee_btnUpdate.Text = "Update";
			this.addEmployee_btnUpdate.UseVisualStyleBackColor = false;
			this.addEmployee_btnUpdate.Click += new System.EventHandler(this.addEmployee_btnUpdate_Click);
			// 
			// addEmployee_btnClear
			// 
			this.addEmployee_btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addEmployee_btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addEmployee_btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addEmployee_btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addEmployee_btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_btnClear.ForeColor = System.Drawing.Color.White;
			this.addEmployee_btnClear.Location = new System.Drawing.Point(497, 163);
			this.addEmployee_btnClear.Name = "addEmployee_btnClear";
			this.addEmployee_btnClear.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnClear.TabIndex = 11;
			this.addEmployee_btnClear.Text = "Clear";
			this.addEmployee_btnClear.UseVisualStyleBackColor = false;
			this.addEmployee_btnClear.Click += new System.EventHandler(this.addEmployee_btnClear_Click);
			// 
			// addEmployee_btnDelete
			// 
			this.addEmployee_btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addEmployee_btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addEmployee_btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addEmployee_btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addEmployee_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addEmployee_btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addEmployee_btnDelete.ForeColor = System.Drawing.Color.White;
			this.addEmployee_btnDelete.Location = new System.Drawing.Point(350, 163);
			this.addEmployee_btnDelete.Name = "addEmployee_btnDelete";
			this.addEmployee_btnDelete.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnDelete.TabIndex = 10;
			this.addEmployee_btnDelete.Text = "Delete";
			this.addEmployee_btnDelete.UseVisualStyleBackColor = false;
			this.addEmployee_btnDelete.Click += new System.EventHandler(this.addEmployee_btnDelete_Click);
			// 
			// adEmployee_btnAdd
			// 
			this.adEmployee_btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.adEmployee_btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.adEmployee_btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.adEmployee_btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.adEmployee_btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.adEmployee_btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.adEmployee_btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.adEmployee_btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.adEmployee_btnAdd.ForeColor = System.Drawing.Color.White;
			this.adEmployee_btnAdd.Location = new System.Drawing.Point(53, 163);
			this.adEmployee_btnAdd.Name = "adEmployee_btnAdd";
			this.adEmployee_btnAdd.Size = new System.Drawing.Size(100, 33);
			this.adEmployee_btnAdd.TabIndex = 8;
			this.adEmployee_btnAdd.Text = "Add";
			this.adEmployee_btnAdd.UseVisualStyleBackColor = false;
			this.adEmployee_btnAdd.Click += new System.EventHandler(this.adEmployee_btnAdd_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(447, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Position:";
			// 
			// addEmployee_cbxPosition
			// 
			this.addEmployee_cbxPosition.FormattingEnabled = true;
			this.addEmployee_cbxPosition.Items.AddRange(new object[] {
            "Software Developer",
            "Tester",
            "Leader",
            "Manager",
            "General"});
			this.addEmployee_cbxPosition.Location = new System.Drawing.Point(510, 67);
			this.addEmployee_cbxPosition.Name = "addEmployee_cbxPosition";
			this.addEmployee_cbxPosition.Size = new System.Drawing.Size(121, 21);
			this.addEmployee_cbxPosition.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(447, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Status:";
			// 
			// addEmployee_cbxStatus
			// 
			this.addEmployee_cbxStatus.FormattingEnabled = true;
			this.addEmployee_cbxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.addEmployee_cbxStatus.Location = new System.Drawing.Point(510, 110);
			this.addEmployee_cbxStatus.Name = "addEmployee_cbxStatus";
			this.addEmployee_cbxStatus.Size = new System.Drawing.Size(121, 21);
			this.addEmployee_cbxStatus.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.addEmployee_cbxStatus);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.addEmployee_cbxPosition);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.adEmployee_btnAdd);
			this.panel2.Controls.Add(this.addEmployee_btnDelete);
			this.panel2.Controls.Add(this.addEmployee_btnClear);
			this.panel2.Controls.Add(this.addEmployee_btnUpdate);
			this.panel2.Controls.Add(this.addEmployee_btnImport);
			this.panel2.Controls.Add(this.addEmployee_pictureBox);
			this.panel2.Controls.Add(this.addEmployee_txbPhone);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.addEmployee_cbxGender);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.addEmployee_txbFullname);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.addEmployee_txbEmployeeID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(17, 340);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(840, 210);
			this.panel2.TabIndex = 1;
			// 
			// AddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AddEmployee";
			this.Size = new System.Drawing.Size(875, 565);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addEmployee_pictureBox)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox addEmployee_txbEmployeeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox addEmployee_txbFullname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox addEmployee_cbxGender;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox addEmployee_txbPhone;
		private System.Windows.Forms.PictureBox addEmployee_pictureBox;
		private System.Windows.Forms.Button addEmployee_btnImport;
		private System.Windows.Forms.Button addEmployee_btnUpdate;
		private System.Windows.Forms.Button addEmployee_btnClear;
		private System.Windows.Forms.Button addEmployee_btnDelete;
		private System.Windows.Forms.Button adEmployee_btnAdd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox addEmployee_cbxPosition;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox addEmployee_cbxStatus;
		private System.Windows.Forms.Panel panel2;
	}
}
