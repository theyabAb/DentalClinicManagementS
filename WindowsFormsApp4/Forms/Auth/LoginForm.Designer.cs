namespace WindowsFormsApp4.Forms.Auth
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Login = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Showpass = new System.Windows.Forms.CheckBox();
            this.picShowpass = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowpass)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(317, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcom BACK";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(301, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please Login to continue";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(345, 214);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(250, 24);
            this.userName.TabIndex = 7;
            this.userName.Text = "Enter user name";
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(345, 266);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(250, 24);
            this.password.TabIndex = 9;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Login
            // 
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Image = global::WindowsFormsApp4.Properties.Resources._245_2458089_loginbutton_login_button_logo_png_1_;
            this.Login.Location = new System.Drawing.Point(345, 438);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(231, 60);
            this.Login.TabIndex = 14;
            this.Login.TabStop = false;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp4.Properties.Resources._609584bc_0509_42cf_8cb3_d2a559be34d3;
            this.pictureBox2.Location = new System.Drawing.Point(570, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Showpass
            // 
            this.Showpass.AutoSize = true;
            this.Showpass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Showpass.Location = new System.Drawing.Point(423, 322);
            this.Showpass.Name = "Showpass";
            this.Showpass.Size = new System.Drawing.Size(91, 21);
            this.Showpass.TabIndex = 10;
            this.Showpass.Text = "Showpass";
            this.Showpass.UseVisualStyleBackColor = true;
            this.Showpass.CheckedChanged += new System.EventHandler(this.Showpass_CheckedChanged);
            // 
            // picShowpass
            // 
            this.picShowpass.Image = global::WindowsFormsApp4.Properties.Resources.invisible;
            this.picShowpass.Location = new System.Drawing.Point(570, 266);
            this.picShowpass.Name = "picShowpass";
            this.picShowpass.Size = new System.Drawing.Size(25, 24);
            this.picShowpass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowpass.TabIndex = 15;
            this.picShowpass.TabStop = false;
            this.picShowpass.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Version 1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DentalClinicManagementSystem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.cross;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_Close.Location = new System.Drawing.Point(844, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.b7644f80_4867_4c67_b25a_5ae4d92012261;
            this.ClientSize = new System.Drawing.Size(872, 579);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picShowpass);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Showpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseClick);
            this.MouseHover += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowpass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.CheckBox Showpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox picShowpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
    }
}