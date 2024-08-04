namespace EmployeeManagementSystem.Controls
{
	partial class AddUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.addUser_cbxStatusFilter = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.addUser_txbSearch = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.addUser_cbxStatus = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.addUser_cbxPosition = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.addUser_btnDelete = new System.Windows.Forms.Button();
			this.addUser_btnClear = new System.Windows.Forms.Button();
			this.addUser_btnUpdate = new System.Windows.Forms.Button();
			this.addUser_txbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addUser_cbxRights = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.addUser_txbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.addUser_txbID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addUser_btnAdd = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.addUser_btnReturnUserManagement = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
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
			// addUser_cbxStatusFilter
			// 
			this.addUser_cbxStatusFilter.FormattingEnabled = true;
			this.addUser_cbxStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
			this.addUser_cbxStatusFilter.Location = new System.Drawing.Point(70, 64);
			this.addUser_cbxStatusFilter.Name = "addUser_cbxStatusFilter";
			this.addUser_cbxStatusFilter.Size = new System.Drawing.Size(148, 21);
			this.addUser_cbxStatusFilter.TabIndex = 21;
			this.addUser_cbxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.addUser_cbxStatusFilter_SelectedIndexChanged);
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
			// addUser_txbSearch
			// 
			this.addUser_txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addUser_txbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_txbSearch.Location = new System.Drawing.Point(70, 24);
			this.addUser_txbSearch.Name = "addUser_txbSearch";
			this.addUser_txbSearch.Size = new System.Drawing.Size(148, 23);
			this.addUser_txbSearch.TabIndex = 19;
			this.addUser_txbSearch.TextChanged += new System.EventHandler(this.addUser_txbSearch_TextChanged);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.addUser_btnReturnUserManagement);
			this.panel4.Controls.Add(this.addUser_cbxStatusFilter);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.addUser_txbSearch);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new System.Drawing.Point(615, 340);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(241, 210);
			this.panel4.TabIndex = 11;
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
			// addUser_cbxStatus
			// 
			this.addUser_cbxStatus.FormattingEnabled = true;
			this.addUser_cbxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
			this.addUser_cbxStatus.Location = new System.Drawing.Point(446, 109);
			this.addUser_cbxStatus.Name = "addUser_cbxStatus";
			this.addUser_cbxStatus.Size = new System.Drawing.Size(121, 21);
			this.addUser_cbxStatus.TabIndex = 6;
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
			// addUser_cbxPosition
			// 
			this.addUser_cbxPosition.FormattingEnabled = true;
			this.addUser_cbxPosition.Items.AddRange(new object[] {
            "Software Developer",
            "Tester",
            "Leader",
            "Manager",
            "General"});
			this.addUser_cbxPosition.Location = new System.Drawing.Point(446, 66);
			this.addUser_cbxPosition.Name = "addUser_cbxPosition";
			this.addUser_cbxPosition.Size = new System.Drawing.Size(121, 21);
			this.addUser_cbxPosition.TabIndex = 4;
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
			// addUser_btnDelete
			// 
			this.addUser_btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addUser_btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addUser_btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addUser_btnDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser_btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_btnDelete.ForeColor = System.Drawing.Color.White;
			this.addUser_btnDelete.Location = new System.Drawing.Point(320, 161);
			this.addUser_btnDelete.Name = "addUser_btnDelete";
			this.addUser_btnDelete.Size = new System.Drawing.Size(100, 33);
			this.addUser_btnDelete.TabIndex = 10;
			this.addUser_btnDelete.Text = "Delete";
			this.addUser_btnDelete.UseVisualStyleBackColor = false;
			this.addUser_btnDelete.Click += new System.EventHandler(this.addUser_btnDelete_Click);
			// 
			// addUser_btnClear
			// 
			this.addUser_btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addUser_btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addUser_btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addUser_btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser_btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_btnClear.ForeColor = System.Drawing.Color.White;
			this.addUser_btnClear.Location = new System.Drawing.Point(467, 161);
			this.addUser_btnClear.Name = "addUser_btnClear";
			this.addUser_btnClear.Size = new System.Drawing.Size(100, 33);
			this.addUser_btnClear.TabIndex = 11;
			this.addUser_btnClear.Text = "Clear";
			this.addUser_btnClear.UseVisualStyleBackColor = false;
			this.addUser_btnClear.Click += new System.EventHandler(this.addUser_btnClear_Click);
			// 
			// addUser_btnUpdate
			// 
			this.addUser_btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addUser_btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addUser_btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addUser_btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser_btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_btnUpdate.ForeColor = System.Drawing.Color.White;
			this.addUser_btnUpdate.Location = new System.Drawing.Point(167, 161);
			this.addUser_btnUpdate.Name = "addUser_btnUpdate";
			this.addUser_btnUpdate.Size = new System.Drawing.Size(100, 33);
			this.addUser_btnUpdate.TabIndex = 9;
			this.addUser_btnUpdate.Text = "Update";
			this.addUser_btnUpdate.UseVisualStyleBackColor = false;
			this.addUser_btnUpdate.Click += new System.EventHandler(this.addUser_btnUpdate_Click);
			// 
			// addUser_txbPassword
			// 
			this.addUser_txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addUser_txbPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_txbPassword.Location = new System.Drawing.Point(99, 108);
			this.addUser_txbPassword.Name = "addUser_txbPassword";
			this.addUser_txbPassword.Size = new System.Drawing.Size(230, 23);
			this.addUser_txbPassword.TabIndex = 5;
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
			// addUser_cbxRights
			// 
			this.addUser_cbxRights.FormattingEnabled = true;
			this.addUser_cbxRights.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.addUser_cbxRights.Location = new System.Drawing.Point(446, 21);
			this.addUser_cbxRights.Name = "addUser_cbxRights";
			this.addUser_cbxRights.Size = new System.Drawing.Size(121, 21);
			this.addUser_cbxRights.TabIndex = 2;
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
			// addUser_txbUsername
			// 
			this.addUser_txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addUser_txbUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_txbUsername.Location = new System.Drawing.Point(99, 64);
			this.addUser_txbUsername.Name = "addUser_txbUsername";
			this.addUser_txbUsername.Size = new System.Drawing.Size(230, 23);
			this.addUser_txbUsername.TabIndex = 3;
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
			// addUser_txbID
			// 
			this.addUser_txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.addUser_txbID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_txbID.Location = new System.Drawing.Point(99, 24);
			this.addUser_txbID.Name = "addUser_txbID";
			this.addUser_txbID.Size = new System.Drawing.Size(230, 23);
			this.addUser_txbID.TabIndex = 1;
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
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.addUser_cbxStatus);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.addUser_cbxPosition);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.addUser_btnAdd);
			this.panel2.Controls.Add(this.addUser_btnDelete);
			this.panel2.Controls.Add(this.addUser_btnClear);
			this.panel2.Controls.Add(this.addUser_btnUpdate);
			this.panel2.Controls.Add(this.addUser_txbPassword);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.addUser_cbxRights);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.addUser_txbUsername);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.addUser_txbID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(18, 340);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(591, 210);
			this.panel2.TabIndex = 10;
			// 
			// addUser_btnAdd
			// 
			this.addUser_btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addUser_btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addUser_btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addUser_btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser_btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_btnAdd.ForeColor = System.Drawing.Color.White;
			this.addUser_btnAdd.Location = new System.Drawing.Point(23, 161);
			this.addUser_btnAdd.Name = "addUser_btnAdd";
			this.addUser_btnAdd.Size = new System.Drawing.Size(100, 33);
			this.addUser_btnAdd.TabIndex = 8;
			this.addUser_btnAdd.Text = "Add";
			this.addUser_btnAdd.UseVisualStyleBackColor = false;
			this.addUser_btnAdd.Click += new System.EventHandler(this.addUser_btnAdd_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(18, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 260);
			this.panel1.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(78, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(121, 25);
			this.label8.TabIndex = 2;
			this.label8.Text = "ADD USER";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(16, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 50);
			this.panel3.TabIndex = 8;
			// 
			// addUser_btnReturnUserManagement
			// 
			this.addUser_btnReturnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.addUser_btnReturnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addUser_btnReturnUserManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.addUser_btnReturnUserManagement.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnReturnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnReturnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.addUser_btnReturnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addUser_btnReturnUserManagement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addUser_btnReturnUserManagement.ForeColor = System.Drawing.Color.White;
			this.addUser_btnReturnUserManagement.Location = new System.Drawing.Point(20, 161);
			this.addUser_btnReturnUserManagement.Name = "addUser_btnReturnUserManagement";
			this.addUser_btnReturnUserManagement.Size = new System.Drawing.Size(198, 33);
			this.addUser_btnReturnUserManagement.TabIndex = 23;
			this.addUser_btnReturnUserManagement.Text = "USERS MANAGEMENT";
			this.addUser_btnReturnUserManagement.UseVisualStyleBackColor = false;
			this.addUser_btnReturnUserManagement.Click += new System.EventHandler(this.addUser_btnReturnUserManagement_Click);
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "AddUser";
			this.Size = new System.Drawing.Size(875, 565);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox addUser_cbxStatusFilter;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox addUser_txbSearch;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox addUser_cbxStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox addUser_cbxPosition;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button addUser_btnDelete;
		private System.Windows.Forms.Button addUser_btnClear;
		private System.Windows.Forms.Button addUser_btnUpdate;
		private System.Windows.Forms.TextBox addUser_txbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox addUser_cbxRights;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox addUser_txbUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox addUser_txbID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button addUser_btnAdd;
		private System.Windows.Forms.Button addUser_btnReturnUserManagement;
	}
}
