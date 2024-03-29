﻿
namespace ClinicaPOO
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.txtName = new System.Windows.Forms.TextBox();
            this.dTPbirth = new System.Windows.Forms.DateTimePicker();
            this.btnSignUp = new ClinicaPOO.RoundedSignUp();
            this.backToLogin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtDUI = new System.Windows.Forms.MaskedTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(87, 309);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(346, 31);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // dTPbirth
            // 
            this.dTPbirth.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dTPbirth.CalendarFont = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPbirth.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.dTPbirth.CalendarTitleBackColor = System.Drawing.Color.DarkViolet;
            this.dTPbirth.CustomFormat = "yyyy-MM-dd";
            this.dTPbirth.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPbirth.Location = new System.Drawing.Point(82, 780);
            this.dTPbirth.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dTPbirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dTPbirth.Name = "dTPbirth";
            this.dTPbirth.Size = new System.Drawing.Size(237, 38);
            this.dTPbirth.TabIndex = 8;
            this.dTPbirth.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(316, 850);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(195, 71);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnsignup_Click);
            this.btnSignUp.MouseHover += new System.EventHandler(this.btnSignUp_MouseHover);
            // 
            // backToLogin
            // 
            this.backToLogin.BackColor = System.Drawing.SystemColors.Control;
            this.backToLogin.Image = ((System.Drawing.Image)(resources.GetObject("backToLogin.Image")));
            this.backToLogin.Location = new System.Drawing.Point(840, 11);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(53, 53);
            this.backToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backToLogin.TabIndex = 8;
            this.backToLogin.TabStop = false;
            this.backToLogin.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(901, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 982);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(76, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 81);
            this.label4.TabIndex = 15;
            this.label4.Text = "SIGN UP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(84, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(551, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seems like you don\'t have an account...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtDUI);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.linkSignUp);
            this.panel2.Controls.Add(this.backToLogin);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dTPbirth);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtLastname);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 982);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(84, 695);
            this.txtPhone.Mask = "0000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(152, 31);
            this.txtPhone.TabIndex = 7;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDUI.Location = new System.Drawing.Point(87, 593);
            this.txtDUI.Mask = "00000000-0";
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(218, 31);
            this.txtDUI.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel10.Location = new System.Drawing.Point(76, 248);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(589, 5);
            this.panel10.TabIndex = 42;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label12.Location = new System.Drawing.Point(82, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 31);
            this.label12.TabIndex = 41;
            this.label12.Text = "Username:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(87, 206);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(518, 31);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // linkSignUp
            // 
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.linkSignUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(2)))), ((int)(((byte)(48)))));
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(2)))), ((int)(((byte)(48)))));
            this.linkSignUp.Location = new System.Drawing.Point(474, 937);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(54, 20);
            this.linkSignUp.TabIndex = 39;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Log In!";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label11.Location = new System.Drawing.Point(289, 937);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "Have an account already?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label10.Location = new System.Drawing.Point(484, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "(At least 8 characters)";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel9.Location = new System.Drawing.Point(76, 829);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(589, 5);
            this.panel9.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label9.Location = new System.Drawing.Point(82, 746);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 31);
            this.label9.TabIndex = 35;
            this.label9.Text = "Date of birth:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel8.Location = new System.Drawing.Point(76, 732);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(589, 5);
            this.panel8.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label8.Location = new System.Drawing.Point(82, 655);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phone:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel7.Location = new System.Drawing.Point(76, 636);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(589, 5);
            this.panel7.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(82, 559);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "DUI:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel6.Location = new System.Drawing.Point(76, 541);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(589, 5);
            this.panel6.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(82, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(87, 499);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(518, 31);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel5.Location = new System.Drawing.Point(477, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(349, 5);
            this.panel5.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(483, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lastname:";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastname.Location = new System.Drawing.Point(488, 309);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(338, 31);
            this.txtLastname.TabIndex = 3;
            this.txtLastname.Text = "Lastname";
            this.txtLastname.Click += new System.EventHandler(this.txtLastname_Click);
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel3.Location = new System.Drawing.Point(76, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(589, 5);
            this.panel3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(82, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(87, 400);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(518, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel4.Location = new System.Drawing.Point(78, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 5);
            this.panel4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(82, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.backToLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dTPbirth;
        private RoundedSignUp btnSignUp;
        private System.Windows.Forms.PictureBox backToLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.MaskedTextBox txtDUI;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}