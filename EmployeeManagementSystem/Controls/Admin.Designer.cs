namespace EmployeeManagementSystem.Forms
{
	partial class Admin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.admin_cbxStatus = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.admin_cbxPosition = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.adEmployee_btnAdd = new System.Windows.Forms.Button();
			this.addEmployee_btnDelete = new System.Windows.Forms.Button();
			this.addEmployee_btnClear = new System.Windows.Forms.Button();
			this.addEmployee_btnUpdate = new System.Windows.Forms.Button();
			this.admin_txbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.admin_cbxRights = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.admin_txbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.admin_txbID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.admin_cbxStatusFilter = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.admin_txbSearch = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(15, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 50);
			this.panel3.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(78, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(241, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "MANAGEMENT USERS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 45);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(17, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 260);
			this.panel1.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(840, 260);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.admin_cbxStatus);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.admin_cbxPosition);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.adEmployee_btnAdd);
			this.panel2.Controls.Add(this.addEmployee_btnDelete);
			this.panel2.Controls.Add(this.addEmployee_btnClear);
			this.panel2.Controls.Add(this.addEmployee_btnUpdate);
			this.panel2.Controls.Add(this.admin_txbPassword);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.admin_cbxRights);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.admin_txbUsername);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.admin_txbID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(17, 340);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(591, 210);
			this.panel2.TabIndex = 6;
			// 
			// admin_cbxStatus
			// 
			this.admin_cbxStatus.FormattingEnabled = true;
			this.admin_cbxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.admin_cbxStatus.Location = new System.Drawing.Point(446, 109);
			this.admin_cbxStatus.Name = "admin_cbxStatus";
			this.admin_cbxStatus.Size = new System.Drawing.Size(121, 21);
			this.admin_cbxStatus.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(383, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 17;
			this.label6.Text = "Status:";
			// 
			// admin_cbxPosition
			// 
			this.admin_cbxPosition.FormattingEnabled = true;
			this.admin_cbxPosition.Items.AddRange(new object[] {
            "Software Developer",
            "Tester",
            "Leader",
            "Manager",
            "General"});
			this.admin_cbxPosition.Location = new System.Drawing.Point(446, 66);
			this.admin_cbxPosition.Name = "admin_cbxPosition";
			this.admin_cbxPosition.Size = new System.Drawing.Size(121, 21);
			this.admin_cbxPosition.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(383, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Position:";
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
			this.adEmployee_btnAdd.Location = new System.Drawing.Point(23, 161);
			this.adEmployee_btnAdd.Name = "adEmployee_btnAdd";
			this.adEmployee_btnAdd.Size = new System.Drawing.Size(100, 33);
			this.adEmployee_btnAdd.TabIndex = 8;
			this.adEmployee_btnAdd.Text = "Add";
			this.adEmployee_btnAdd.UseVisualStyleBackColor = false;
			this.adEmployee_btnAdd.Click += new System.EventHandler(this.adEmployee_btnAdd_Click);
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
			this.addEmployee_btnDelete.Location = new System.Drawing.Point(320, 161);
			this.addEmployee_btnDelete.Name = "addEmployee_btnDelete";
			this.addEmployee_btnDelete.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnDelete.TabIndex = 10;
			this.addEmployee_btnDelete.Text = "Delete";
			this.addEmployee_btnDelete.UseVisualStyleBackColor = false;
			this.addEmployee_btnDelete.Click += new System.EventHandler(this.addEmployee_btnDelete_Click);
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
			this.addEmployee_btnClear.Location = new System.Drawing.Point(467, 161);
			this.addEmployee_btnClear.Name = "addEmployee_btnClear";
			this.addEmployee_btnClear.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnClear.TabIndex = 11;
			this.addEmployee_btnClear.Text = "Clear";
			this.addEmployee_btnClear.UseVisualStyleBackColor = false;
			this.addEmployee_btnClear.Click += new System.EventHandler(this.addEmployee_btnClear_Click);
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
			this.addEmployee_btnUpdate.Location = new System.Drawing.Point(167, 161);
			this.addEmployee_btnUpdate.Name = "addEmployee_btnUpdate";
			this.addEmployee_btnUpdate.Size = new System.Drawing.Size(100, 33);
			this.addEmployee_btnUpdate.TabIndex = 9;
			this.addEmployee_btnUpdate.Text = "Update";
			this.addEmployee_btnUpdate.UseVisualStyleBackColor = false;
			this.addEmployee_btnUpdate.Click += new System.EventHandler(this.addEmployee_btnUpdate_Click);
			// 
			// admin_txbPassword
			// 
			this.admin_txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin_txbPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_txbPassword.Location = new System.Drawing.Point(87, 107);
			this.admin_txbPassword.Name = "admin_txbPassword";
			this.admin_txbPassword.Size = new System.Drawing.Size(230, 23);
			this.admin_txbPassword.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(14, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password:";
			// 
			// admin_cbxRights
			// 
			this.admin_cbxRights.FormattingEnabled = true;
			this.admin_cbxRights.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.admin_cbxRights.Location = new System.Drawing.Point(446, 21);
			this.admin_cbxRights.Name = "admin_cbxRights";
			this.admin_cbxRights.Size = new System.Drawing.Size(121, 21);
			this.admin_cbxRights.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(383, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Rights:";
			// 
			// admin_txbUsername
			// 
			this.admin_txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin_txbUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_txbUsername.Location = new System.Drawing.Point(87, 63);
			this.admin_txbUsername.Name = "admin_txbUsername";
			this.admin_txbUsername.Size = new System.Drawing.Size(230, 23);
			this.admin_txbUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(14, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "User Name:";
			// 
			// admin_txbID
			// 
			this.admin_txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin_txbID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_txbID.Location = new System.Drawing.Point(87, 23);
			this.admin_txbID.Name = "admin_txbID";
			this.admin_txbID.Size = new System.Drawing.Size(230, 23);
			this.admin_txbID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(14, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.admin_cbxStatusFilter);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.admin_txbSearch);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new System.Drawing.Point(614, 340);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(241, 210);
			this.panel4.TabIndex = 7;
			// 
			// admin_cbxStatusFilter
			// 
			this.admin_cbxStatusFilter.FormattingEnabled = true;
			this.admin_cbxStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
			this.admin_cbxStatusFilter.Location = new System.Drawing.Point(70, 64);
			this.admin_cbxStatusFilter.Name = "admin_cbxStatusFilter";
			this.admin_cbxStatusFilter.Size = new System.Drawing.Size(148, 21);
			this.admin_cbxStatusFilter.TabIndex = 21;
			this.admin_cbxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.admin_cbxStatusFilter_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.Location = new System.Drawing.Point(17, 66);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 22;
			this.label10.Text = "Status:";
			// 
			// admin_txbSearch
			// 
			this.admin_txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin_txbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_txbSearch.Location = new System.Drawing.Point(70, 24);
			this.admin_txbSearch.Name = "admin_txbSearch";
			this.admin_txbSearch.Size = new System.Drawing.Size(148, 23);
			this.admin_txbSearch.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(17, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Search";
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "Admin";
			this.Size = new System.Drawing.Size(875, 565);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox admin_cbxStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox admin_cbxPosition;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button adEmployee_btnAdd;
		private System.Windows.Forms.Button addEmployee_btnDelete;
		private System.Windows.Forms.Button addEmployee_btnClear;
		private System.Windows.Forms.Button addEmployee_btnUpdate;
		private System.Windows.Forms.TextBox admin_txbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox admin_cbxRights;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox admin_txbUsername;
		private System.Windows.Forms.TextBox admin_txbID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox admin_txbSearch;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox admin_cbxStatusFilter;
		private System.Windows.Forms.Label label10;
	}
}
