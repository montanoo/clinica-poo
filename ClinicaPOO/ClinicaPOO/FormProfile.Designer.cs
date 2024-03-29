﻿
namespace ClinicaPOO
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dTPbirth = new System.Windows.Forms.DateTimePicker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditName = new System.Windows.Forms.PictureBox();
            this.btnEditLastn = new System.Windows.Forms.PictureBox();
            this.btnEditEmail = new System.Windows.Forms.PictureBox();
            this.btnEditPwd = new System.Windows.Forms.PictureBox();
            this.btnEditPhone = new System.Windows.Forms.PictureBox();
            this.btnEditBirth = new System.Windows.Forms.PictureBox();
            this.btnSave = new ClinicaPOO.RoundedStart();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLastn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditBirth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, -116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 1097);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(61, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 116);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label10.Location = new System.Drawing.Point(541, 643);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "(At least 8 characters)";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel9.Location = new System.Drawing.Point(959, 567);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(360, 5);
            this.panel9.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label9.Location = new System.Drawing.Point(966, 485);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 31);
            this.label9.TabIndex = 53;
            this.label9.Text = "Date of birth:";
            // 
            // dTPbirth
            // 
            this.dTPbirth.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dTPbirth.CalendarFont = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPbirth.CalendarMonthBackground = System.Drawing.Color.PaleTurquoise;
            this.dTPbirth.CalendarTitleBackColor = System.Drawing.Color.DarkViolet;
            this.dTPbirth.CustomFormat = "yyyy-MM-dd";
            this.dTPbirth.Enabled = false;
            this.dTPbirth.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTPbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPbirth.Location = new System.Drawing.Point(966, 518);
            this.dTPbirth.MaxDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dTPbirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dTPbirth.Name = "dTPbirth";
            this.dTPbirth.Size = new System.Drawing.Size(237, 38);
            this.dTPbirth.TabIndex = 43;
            this.dTPbirth.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel8.Location = new System.Drawing.Point(959, 427);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(360, 5);
            this.panel8.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label8.Location = new System.Drawing.Point(966, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 31);
            this.label8.TabIndex = 51;
            this.label8.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(970, 386);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(349, 31);
            this.txtPhone.TabIndex = 42;
            this.txtPhone.Text = "Type here...";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel7.Location = new System.Drawing.Point(952, 291);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(360, 5);
            this.panel7.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label7.Location = new System.Drawing.Point(959, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.SystemColors.Control;
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDUI.Location = new System.Drawing.Point(963, 250);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.ReadOnly = true;
            this.txtDUI.Size = new System.Drawing.Size(349, 31);
            this.txtDUI.TabIndex = 41;
            this.txtDUI.Text = "Type here...";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel6.Location = new System.Drawing.Point(351, 721);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(360, 5);
            this.panel6.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label6.Location = new System.Drawing.Point(358, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 47;
            this.label6.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(362, 678);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(358, 31);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.Text = "Password";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel5.Location = new System.Drawing.Point(354, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 5);
            this.panel5.TabIndex = 46;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastname.Location = new System.Drawing.Point(360, 385);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.ReadOnly = true;
            this.txtLastname.Size = new System.Drawing.Size(358, 31);
            this.txtLastname.TabIndex = 38;
            this.txtLastname.Text = "Type here...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel3.Location = new System.Drawing.Point(351, 570);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 5);
            this.panel3.TabIndex = 45;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label2.Location = new System.Drawing.Point(358, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 44;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(362, 527);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(358, 31);
            this.txtEmail.TabIndex = 39;
            this.txtEmail.Text = "Type here...";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label3.Location = new System.Drawing.Point(360, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "Lastname:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.panel4.Location = new System.Drawing.Point(360, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 5);
            this.panel4.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(358, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(362, 249);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(358, 31);
            this.txtName.TabIndex = 56;
            this.txtName.Text = "Type here...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label4.Location = new System.Drawing.Point(349, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 81);
            this.label4.TabIndex = 60;
            this.label4.Text = "MY PROFILE";
            // 
            // btnEditName
            // 
            this.btnEditName.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditName.Location = new System.Drawing.Point(727, 235);
            this.btnEditName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(41, 47);
            this.btnEditName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditName.TabIndex = 61;
            this.btnEditName.TabStop = false;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // btnEditLastn
            // 
            this.btnEditLastn.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditLastn.Location = new System.Drawing.Point(727, 372);
            this.btnEditLastn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditLastn.Name = "btnEditLastn";
            this.btnEditLastn.Size = new System.Drawing.Size(41, 47);
            this.btnEditLastn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditLastn.TabIndex = 62;
            this.btnEditLastn.TabStop = false;
            this.btnEditLastn.Click += new System.EventHandler(this.btnEditLastn_Click);
            // 
            // btnEditEmail
            // 
            this.btnEditEmail.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditEmail.Location = new System.Drawing.Point(727, 514);
            this.btnEditEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmail.Name = "btnEditEmail";
            this.btnEditEmail.Size = new System.Drawing.Size(41, 47);
            this.btnEditEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditEmail.TabIndex = 63;
            this.btnEditEmail.TabStop = false;
            this.btnEditEmail.Click += new System.EventHandler(this.btnEditEmail_Click);
            // 
            // btnEditPwd
            // 
            this.btnEditPwd.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditPwd.Location = new System.Drawing.Point(727, 665);
            this.btnEditPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPwd.Name = "btnEditPwd";
            this.btnEditPwd.Size = new System.Drawing.Size(41, 47);
            this.btnEditPwd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditPwd.TabIndex = 64;
            this.btnEditPwd.TabStop = false;
            this.btnEditPwd.Click += new System.EventHandler(this.btnEditPwd_Click);
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditPhone.Location = new System.Drawing.Point(1326, 372);
            this.btnEditPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(41, 47);
            this.btnEditPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditPhone.TabIndex = 66;
            this.btnEditPhone.TabStop = false;
            this.btnEditPhone.Click += new System.EventHandler(this.btnEditPhone_Click);
            // 
            // btnEditBirth
            // 
            this.btnEditBirth.Image = global::ClinicaPOO.Properties.Resources.pngwing_com;
            this.btnEditBirth.Location = new System.Drawing.Point(1326, 514);
            this.btnEditBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditBirth.Name = "btnEditBirth";
            this.btnEditBirth.Size = new System.Drawing.Size(41, 47);
            this.btnEditBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditBirth.TabIndex = 67;
            this.btnEditBirth.TabStop = false;
            this.btnEditBirth.Click += new System.EventHandler(this.btnEditBirth_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(984, 795);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 75);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(22)))), ((int)(((byte)(93)))));
            this.label5.Location = new System.Drawing.Point(349, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(624, 41);
            this.label5.TabIndex = 69;
            this.label5.Text = "Look at your profile, or make some changes!";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEditBirth);
            this.Controls.Add(this.btnEditPhone);
            this.Controls.Add(this.btnEditPwd);
            this.Controls.Add(this.btnEditEmail);
            this.Controls.Add(this.btnEditLastn);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dTPbirth);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEditName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditLastn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditBirth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTPbirth;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnEditName;
        private System.Windows.Forms.PictureBox btnEditLastn;
        private System.Windows.Forms.PictureBox btnEditEmail;
        private System.Windows.Forms.PictureBox btnEditPwd;
        private System.Windows.Forms.PictureBox btnEditPhone;
        private System.Windows.Forms.PictureBox btnEditBirth;
        private RoundedStart btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}