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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.admin_lbWarning = new System.Windows.Forms.Label();
			this.pbWarningIcon = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.admin_txbSearch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.admin_cbxStatusFilter = new System.Windows.Forms.ComboBox();
			this.admin__btnAdd = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).BeginInit();
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
			this.label8.Text = "USERS MANAGEMENT";
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
			this.panel1.Location = new System.Drawing.Point(15, 193);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(840, 341);
			this.panel1.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
			this.dataGridView1.Size = new System.Drawing.Size(840, 341);
			this.dataGridView1.TabIndex = 8;
			// 
			// admin_lbWarning
			// 
			this.admin_lbWarning.AutoSize = true;
			this.admin_lbWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_lbWarning.Location = new System.Drawing.Point(33, 152);
			this.admin_lbWarning.Name = "admin_lbWarning";
			this.admin_lbWarning.Size = new System.Drawing.Size(57, 16);
			this.admin_lbWarning.TabIndex = 8;
			this.admin_lbWarning.Text = "Warning";
			// 
			// pbWarningIcon
			// 
			this.pbWarningIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbWarningIcon.Image")));
			this.pbWarningIcon.Location = new System.Drawing.Point(15, 153);
			this.pbWarningIcon.Name = "pbWarningIcon";
			this.pbWarningIcon.Size = new System.Drawing.Size(15, 15);
			this.pbWarningIcon.TabIndex = 9;
			this.pbWarningIcon.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(17, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Search";
			// 
			// admin_txbSearch
			// 
			this.admin_txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.admin_txbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin_txbSearch.Location = new System.Drawing.Point(70, 13);
			this.admin_txbSearch.Name = "admin_txbSearch";
			this.admin_txbSearch.Size = new System.Drawing.Size(148, 23);
			this.admin_txbSearch.TabIndex = 19;
			this.admin_txbSearch.TextChanged += new System.EventHandler(this.admin_txbSearch_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.Location = new System.Drawing.Point(342, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 16);
			this.label10.TabIndex = 22;
			this.label10.Text = "Status:";
			// 
			// admin_cbxStatusFilter
			// 
			this.admin_cbxStatusFilter.FormattingEnabled = true;
			this.admin_cbxStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
			this.admin_cbxStatusFilter.Location = new System.Drawing.Point(395, 14);
			this.admin_cbxStatusFilter.Name = "admin_cbxStatusFilter";
			this.admin_cbxStatusFilter.Size = new System.Drawing.Size(148, 21);
			this.admin_cbxStatusFilter.TabIndex = 21;
			this.admin_cbxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.admin_cbxStatusFilter_SelectedIndexChanged);
			// 
			// admin__btnAdd
			// 
			this.admin__btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.admin__btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.admin__btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.admin__btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.admin__btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.admin__btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.admin__btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.admin__btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.admin__btnAdd.ForeColor = System.Drawing.Color.White;
			this.admin__btnAdd.Location = new System.Drawing.Point(724, 8);
			this.admin__btnAdd.Name = "admin__btnAdd";
			this.admin__btnAdd.Size = new System.Drawing.Size(100, 33);
			this.admin__btnAdd.TabIndex = 9;
			this.admin__btnAdd.Text = "ADD";
			this.admin__btnAdd.UseVisualStyleBackColor = false;
			this.admin__btnAdd.Click += new System.EventHandler(this.admin_btnAdd_Click);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.admin__btnAdd);
			this.panel4.Controls.Add(this.admin_cbxStatusFilter);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.admin_txbSearch);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new System.Drawing.Point(15, 85);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(840, 50);
			this.panel4.TabIndex = 7;
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pbWarningIcon);
			this.Controls.Add(this.admin_lbWarning);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Name = "Admin";
			this.Size = new System.Drawing.Size(875, 565);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbWarningIcon)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label admin_lbWarning;
		private System.Windows.Forms.PictureBox pbWarningIcon;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox admin_txbSearch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox admin_cbxStatusFilter;
		private System.Windows.Forms.Button admin__btnAdd;
		private System.Windows.Forms.Panel panel4;
	}
}
