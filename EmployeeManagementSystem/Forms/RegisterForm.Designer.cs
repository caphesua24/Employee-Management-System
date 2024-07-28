namespace EmployeeManagementSystem.Forms
{
	partial class RegisterForm
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
			this.register_btnSignup = new System.Windows.Forms.Button();
			this.register_chboxShowPassword = new System.Windows.Forms.CheckBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.register_txbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.register_txbUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.register_lbExit = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.register_btnSignIn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// register_btnSignup
			// 
			this.register_btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.register_btnSignup.FlatAppearance.BorderSize = 0;
			this.register_btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.register_btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.register_btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.register_btnSignup.ForeColor = System.Drawing.Color.White;
			this.register_btnSignup.Location = new System.Drawing.Point(275, 274);
			this.register_btnSignup.Name = "register_btnSignup";
			this.register_btnSignup.Size = new System.Drawing.Size(76, 29);
			this.register_btnSignup.TabIndex = 19;
			this.register_btnSignup.Text = "SIGNUP";
			this.register_btnSignup.UseVisualStyleBackColor = false;
			this.register_btnSignup.Click += new System.EventHandler(this.register_btnSignup_Click);
			// 
			// register_chboxShowPassword
			// 
			this.register_chboxShowPassword.AutoSize = true;
			this.register_chboxShowPassword.Location = new System.Drawing.Point(383, 223);
			this.register_chboxShowPassword.Name = "register_chboxShowPassword";
			this.register_chboxShowPassword.Size = new System.Drawing.Size(101, 17);
			this.register_chboxShowPassword.TabIndex = 18;
			this.register_chboxShowPassword.Text = "Show password";
			this.register_chboxShowPassword.UseVisualStyleBackColor = true;
			this.register_chboxShowPassword.CheckedChanged += new System.EventHandler(this.register_chboxShowPassword_CheckedChanged);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(318, 219);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(0, 13);
			this.linkLabel1.TabIndex = 17;
			// 
			// register_txbPassword
			// 
			this.register_txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.register_txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.register_txbPassword.Location = new System.Drawing.Point(275, 195);
			this.register_txbPassword.Name = "register_txbPassword";
			this.register_txbPassword.Size = new System.Drawing.Size(209, 22);
			this.register_txbPassword.TabIndex = 16;
			this.register_txbPassword.UseSystemPasswordChar = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(272, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 15;
			this.label4.Text = "Password:";
			// 
			// register_txbUsername
			// 
			this.register_txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.register_txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.register_txbUsername.Location = new System.Drawing.Point(275, 138);
			this.register_txbUsername.Name = "register_txbUsername";
			this.register_txbUsername.Size = new System.Drawing.Size(209, 22);
			this.register_txbUsername.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(272, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Username:";
			// 
			// register_lbExit
			// 
			this.register_lbExit.AutoSize = true;
			this.register_lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.register_lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.register_lbExit.Location = new System.Drawing.Point(471, 3);
			this.register_lbExit.Name = "register_lbExit";
			this.register_lbExit.Size = new System.Drawing.Size(16, 16);
			this.register_lbExit.TabIndex = 12;
			this.register_lbExit.Text = "X";
			this.register_lbExit.Click += new System.EventHandler(this.register_lbExit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(271, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = "REGISTER ACCOUNT";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.register_btnSignIn);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 330);
			this.panel1.TabIndex = 10;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.pictureBox1.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\EmployeeManagementSystem\\EmployeeManagementSystem\\Reso" +
    "urces\\welcome_employee.png";
			this.pictureBox1.Location = new System.Drawing.Point(80, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// register_btnSignIn
			// 
			this.register_btnSignIn.BackColor = System.Drawing.SystemColors.Control;
			this.register_btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.register_btnSignIn.FlatAppearance.BorderSize = 0;
			this.register_btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.register_btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.register_btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.register_btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.register_btnSignIn.ForeColor = System.Drawing.Color.Black;
			this.register_btnSignIn.Location = new System.Drawing.Point(15, 274);
			this.register_btnSignIn.Name = "register_btnSignIn";
			this.register_btnSignIn.Size = new System.Drawing.Size(230, 29);
			this.register_btnSignIn.TabIndex = 10;
			this.register_btnSignIn.Text = "SIGN IN";
			this.register_btnSignIn.UseVisualStyleBackColor = false;
			this.register_btnSignIn.Click += new System.EventHandler(this.register_btnSignIn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(43, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "You already have an account";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(12, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(238, 18);
			this.label6.TabIndex = 0;
			this.label6.Text = "Employee Management System";
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 330);
			this.Controls.Add(this.register_btnSignup);
			this.Controls.Add(this.register_chboxShowPassword);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.register_txbPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.register_txbUsername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.register_lbExit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegisterForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button register_btnSignup;
		private System.Windows.Forms.CheckBox register_chboxShowPassword;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox register_txbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox register_txbUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label register_lbExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button register_btnSignIn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}