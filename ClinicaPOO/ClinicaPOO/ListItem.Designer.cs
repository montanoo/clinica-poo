
namespace ClinicaPOO
{
    partial class ListItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblprocedure = new System.Windows.Forms.Label();
            this.lbldoctor = new System.Windows.Forms.Label();
            this.lbldatetime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblprocedure
            // 
            this.lblprocedure.AutoSize = true;
            this.lblprocedure.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblprocedure.ForeColor = System.Drawing.Color.Indigo;
            this.lblprocedure.Location = new System.Drawing.Point(217, 16);
            this.lblprocedure.Name = "lblprocedure";
            this.lblprocedure.Size = new System.Drawing.Size(126, 32);
            this.lblprocedure.TabIndex = 1;
            this.lblprocedure.Text = "Procedure";
            // 
            // lbldoctor
            // 
            this.lbldoctor.AutoSize = true;
            this.lbldoctor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldoctor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbldoctor.Location = new System.Drawing.Point(217, 49);
            this.lbldoctor.Name = "lbldoctor";
            this.lbldoctor.Size = new System.Drawing.Size(74, 25);
            this.lbldoctor.TabIndex = 2;
            this.lbldoctor.Text = "Doctor";
            // 
            // lbldatetime
            // 
            this.lbldatetime.AutoSize = true;
            this.lbldatetime.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbldatetime.ForeColor = System.Drawing.Color.MediumPurple;
            this.lbldatetime.Location = new System.Drawing.Point(217, 81);
            this.lbldatetime.Name = "lbldatetime";
            this.lbldatetime.Size = new System.Drawing.Size(94, 25);
            this.lbldatetime.TabIndex = 3;
            this.lbldatetime.Text = "0/0/0000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 121);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 10);
            this.panel2.TabIndex = 8;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblprice.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblprice.Location = new System.Drawing.Point(579, 22);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(61, 25);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "$0.00";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbldatetime);
            this.Controls.Add(this.lbldoctor);
            this.Controls.Add(this.lblprocedure);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(800, 121);
            this.MouseEnter += new System.EventHandler(this.ListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblprocedure;
        private System.Windows.Forms.Label lbldoctor;
        private System.Windows.Forms.Label lbldatetime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Panel panel2;
    }
}
