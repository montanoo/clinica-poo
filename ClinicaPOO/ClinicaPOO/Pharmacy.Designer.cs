
namespace ClinicaPOO
{
    partial class Pharmacy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.btnReturnMenu = new System.Windows.Forms.PictureBox();
            this.ProductTxtBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.PharmacyGridView = new System.Windows.Forms.DataGridView();
            this.AddProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.refreshBtn = new System.Windows.Forms.PictureBox();
            this.QtyLabel = new System.Windows.Forms.Label();
            this.QtyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1417, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NameLabel.Location = new System.Drawing.Point(235, 189);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(148, 60);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // btnReturnMenu
            // 
            this.btnReturnMenu.BackColor = System.Drawing.Color.Transparent;

            this.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnMenu.Location = new System.Drawing.Point(47, 106);
            this.btnReturnMenu.Name = "btnReturnMenu";
            this.btnReturnMenu.Size = new System.Drawing.Size(74, 75);
            this.btnReturnMenu.TabIndex = 2;
            this.btnReturnMenu.TabStop = false;
            this.btnReturnMenu.Click += new System.EventHandler(this.btnReturnMenu_Click);
            // 
            // ProductTxtBox
            // 
            this.ProductTxtBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProductTxtBox.Location = new System.Drawing.Point(404, 189);
            this.ProductTxtBox.Multiline = true;
            this.ProductTxtBox.Name = "ProductTxtBox";
            this.ProductTxtBox.Size = new System.Drawing.Size(736, 59);
            this.ProductTxtBox.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Location = new System.Drawing.Point(1162, 189);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 52);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // PharmacyGridView
            // 
            this.PharmacyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PharmacyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PharmacyGridView.BackgroundColor = System.Drawing.Color.DarkMagenta;
            this.PharmacyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PharmacyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PharmacyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PharmacyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddProduct});
            this.PharmacyGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PharmacyGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PharmacyGridView.EnableHeadersVisualStyles = false;
            this.PharmacyGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PharmacyGridView.Location = new System.Drawing.Point(155, 283);
            this.PharmacyGridView.Name = "PharmacyGridView";
            this.PharmacyGridView.ReadOnly = true;
            this.PharmacyGridView.RowHeadersVisible = false;
            this.PharmacyGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            this.PharmacyGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PharmacyGridView.RowTemplate.Height = 33;
            this.PharmacyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PharmacyGridView.Size = new System.Drawing.Size(1036, 576);
            this.PharmacyGridView.TabIndex = 5;
            this.PharmacyGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PharmacyGridView_CellContentDoubleClick);
            // 
            // AddProduct
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Honeydew;
            this.AddProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProduct.HeaderText = "Add Product";
            this.AddProduct.MinimumWidth = 8;
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.ReadOnly = true;
            this.AddProduct.Text = "ADD";
            this.AddProduct.UseColumnTextForButtonValue = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Location = new System.Drawing.Point(1244, 189);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(55, 52);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.QtyLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QtyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtyLabel.Location = new System.Drawing.Point(1244, 357);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(132, 38);
            this.QtyLabel.TabIndex = 7;
            this.QtyLabel.Text = "Quantity";
            // 
            // QtyTextBox
            // 
            this.QtyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QtyTextBox.Location = new System.Drawing.Point(1279, 424);
            this.QtyTextBox.Name = "QtyTextBox";
            this.QtyTextBox.Size = new System.Drawing.Size(67, 39);
            this.QtyTextBox.TabIndex = 8;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClinicaPOO.Properties.Resources.HD_wallpaper_plain_purple_background_purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.QtyTextBox);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.PharmacyGridView);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ProductTxtBox);
            this.Controls.Add(this.btnReturnMenu);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pharmacy";
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Pharmacy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PharmacyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox btnReturnMenu;
        private System.Windows.Forms.TextBox ProductTxtBox;
        private System.Windows.Forms.PictureBox btnBuscar;
        
        private System.Windows.Forms.DataGridView PharmacyGridView;
        private System.Windows.Forms.PictureBox refreshBtn;
        private System.Windows.Forms.DataGridViewButtonColumn AddProduct;
        private System.Windows.Forms.Label QtyLabel;
        private System.Windows.Forms.TextBox QtyTextBox;
    }
}