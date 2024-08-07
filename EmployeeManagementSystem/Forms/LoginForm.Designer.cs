namespace EmployeeManagementSystem
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.login_picture = new System.Windows.Forms.PictureBox();
			this.login_btnSignup = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.login_lbExit = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.login_txbUsername = new System.Windows.Forms.TextBox();
			this.login_txbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.login_chboxShowPassword = new System.Windows.Forms.CheckBox();
			this.login_btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.login_picture)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.panel1.Controls.Add(this.login_picture);
			this.panel1.Controls.Add(this.login_btnSignup);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(260, 330);
			this.panel1.TabIndex = 0;
			// 
			// login_picture
			// 
			this.login_picture.ImageLocation = "C:\\Users\\ASUS\\source\\repos\\EmployeeManagementSystem\\EmployeeManagementSystem\\Reso" +
    "urces\\welcome_employee.png";
			this.login_picture.Location = new System.Drawing.Point(80, 30);
			this.login_picture.Margin = new System.Windows.Forms.Padding(2);
			this.login_picture.Name = "login_picture";
			this.login_picture.Size = new System.Drawing.Size(100, 100);
			this.login_picture.TabIndex = 11;
			this.login_picture.TabStop = false;
			// 
			// login_btnSignup
			// 
			this.login_btnSignup.BackColor = System.Drawing.SystemColors.Control;
			this.login_btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.login_btnSignup.FlatAppearance.BorderSize = 0;
			this.login_btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.login_btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.login_btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.login_btnSignup.ForeColor = System.Drawing.Color.Black;
			this.login_btnSignup.Location = new System.Drawing.Point(15, 274);
			this.login_btnSignup.Name = "login_btnSignup";
			this.login_btnSignup.Size = new System.Drawing.Size(230, 29);
			this.login_btnSignup.TabIndex = 10;
			this.login_btnSignup.Text = "SIGNUP";
			this.login_btnSignup.UseVisualStyleBackColor = false;
			this.login_btnSignup.Click += new System.EventHandler(this.login_btnSignup_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(61, 250);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 16);
			this.label5.TabIndex = 1;
			this.label5.Text = "Register your Account";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label1.Location = new System.Drawing.Point(274, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "LOGIN ACCOUNT";
			// 
			// login_lbExit
			// 
			this.login_lbExit.AutoSize = true;
			this.login_lbExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.login_lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.login_lbExit.Location = new System.Drawing.Point(474, 9);
			this.login_lbExit.Name = "login_lbExit";
			this.login_lbExit.Size = new System.Drawing.Size(16, 16);
			this.login_lbExit.TabIndex = 2;
			this.login_lbExit.Text = "X";
			this.login_lbExit.Click += new System.EventHandler(this.lbExit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(275, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Username:";
			// 
			// login_txbUsername
			// 
			this.login_txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.login_txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.login_txbUsername.Location = new System.Drawing.Point(278, 144);
			this.login_txbUsername.Name = "login_txbUsername";
			this.login_txbUsername.Size = new System.Drawing.Size(209, 22);
			this.login_txbUsername.TabIndex = 4;
			// 
			// login_txbPassword
			// 
			this.login_txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.login_txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.login_txbPassword.Location = new System.Drawing.Point(278, 201);
			this.login_txbPassword.Name = "login_txbPassword";
			this.login_txbPassword.PasswordChar = '*';
			this.login_txbPassword.Size = new System.Drawing.Size(209, 22);
			this.login_txbPassword.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(275, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(321, 225);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(0, 13);
			this.linkLabel1.TabIndex = 7;
			// 
			// login_chboxShowPassword
			// 
			this.login_chboxShowPassword.AutoSize = true;
			this.login_chboxShowPassword.Location = new System.Drawing.Point(386, 229);
			this.login_chboxShowPassword.Name = "login_chboxShowPassword";
			this.login_chboxShowPassword.Size = new System.Drawing.Size(101, 17);
			this.login_chboxShowPassword.TabIndex = 8;
			this.login_chboxShowPassword.Text = "Show password";
			this.login_chboxShowPassword.UseVisualStyleBackColor = true;
			this.login_chboxShowPassword.CheckedChanged += new System.EventHandler(this.login_chboxShowPassword_CheckedChanged);
			// 
			// login_btnLogin
			// 
			this.login_btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
			this.login_btnLogin.FlatAppearance.BorderSize = 0;
			this.login_btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.login_btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(79)))), ((int)(((byte)(107)))));
			this.login_btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.login_btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.login_btnLogin.ForeColor = System.Drawing.Color.White;
			this.login_btnLogin.Location = new System.Drawing.Point(278, 274);
			this.login_btnLogin.Name = "login_btnLogin";
			this.login_btnLogin.Size = new System.Drawing.Size(76, 29);
			this.login_btnLogin.TabIndex = 9;
			this.login_btnLogin.Text = "Login";
			this.login_btnLogin.UseVisualStyleBackColor = false;
			this.login_btnLogin.Click += new System.EventHandler(this.login_btnLogin_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 330);
			this.Controls.Add(this.login_btnLogin);
			this.Controls.Add(this.login_chboxShowPassword);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.login_txbPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.login_txbUsername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.login_lbExit);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.login_picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label login_lbExit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox login_txbUsername;
		private System.Windows.Forms.TextBox login_txbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.CheckBox login_chboxShowPassword;
		private System.Windows.Forms.Button login_btnLogin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button login_btnSignup;
		private System.Windows.Forms.PictureBox login_picture;
	}
}

