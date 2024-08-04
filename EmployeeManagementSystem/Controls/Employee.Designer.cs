namespace EmployeeManagementSystem.Controls
{
	partial class Employee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label8 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.employee_txbSearch = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.employee_cbxStatusFilter = new System.Windows.Forms.ComboBox();
			this.employee__btnAddEmployee = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
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
			// panel3
			// 
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(16, 15);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(840, 50);
			this.panel3.TabIndex = 6;
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
			this.panel1.TabIndex = 4;
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
			this.dataGridView1.TabIndex = 9;
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
			// employee_txbSearch
			// 
			this.employee_txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.employee_txbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.employee_txbSearch.Location = new System.Drawing.Point(70, 13);
			this.employee_txbSearch.Name = "employee_txbSearch";
			this.employee_txbSearch.Size = new System.Drawing.Size(148, 23);
			this.employee_txbSearch.TabIndex = 19;
			this.employee_txbSearch.TextChanged += new System.EventHandler(this.employee_txbSearch_TextChanged);
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
			// employee_cbxStatusFilter
			// 
			this.employee_cbxStatusFilter.FormattingEnabled = true;
			this.employee_cbxStatusFilter.Items.AddRange(new object[] {
            "All",
            "Active",
            "Inactive"});
			this.employee_cbxStatusFilter.Location = new System.Drawing.Point(395, 14);
			this.employee_cbxStatusFilter.Name = "employee_cbxStatusFilter";
			this.employee_cbxStatusFilter.Size = new System.Drawing.Size(148, 21);
			this.employee_cbxStatusFilter.TabIndex = 21;
			this.employee_cbxStatusFilter.SelectedIndexChanged += new System.EventHandler(this.employee_cbxStatusFilter_SelectedIndexChanged);
			// 
			// employee__btnAddEmployee
			// 
			this.employee__btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.employee__btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.employee__btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.employee__btnAddEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.employee__btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.employee__btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.employee__btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.employee__btnAddEmployee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.employee__btnAddEmployee.ForeColor = System.Drawing.Color.White;
			this.employee__btnAddEmployee.Location = new System.Drawing.Point(724, 8);
			this.employee__btnAddEmployee.Name = "employee__btnAddEmployee";
			this.employee__btnAddEmployee.Size = new System.Drawing.Size(100, 33);
			this.employee__btnAddEmployee.TabIndex = 9;
			this.employee__btnAddEmployee.Text = "ADD";
			this.employee__btnAddEmployee.UseVisualStyleBackColor = false;
			this.employee__btnAddEmployee.Click += new System.EventHandler(this.employee_btnAddEmployee_Click);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.employee__btnAddEmployee);
			this.panel4.Controls.Add(this.employee_cbxStatusFilter);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.employee_txbSearch);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Location = new System.Drawing.Point(15, 85);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(840, 50);
			this.panel4.TabIndex = 8;
			// 
			// Employee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "Employee";
			this.Size = new System.Drawing.Size(875, 565);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox employee_txbSearch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox employee_cbxStatusFilter;
		private System.Windows.Forms.Button employee__btnAddEmployee;
		private System.Windows.Forms.Panel panel4;
	}
}
