namespace ISA_MiniTrojan
{
    partial class TopUpLanjutan
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
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBoxBukti = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBukti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.labelNoInvoice.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(15, 9);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(624, 54);
            this.labelNoInvoice.TabIndex = 25;
            this.labelNoInvoice.Text = "Upload Bukti Top-Up";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(176, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 401);
            this.panel2.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel8.Controls.Add(this.pictureBoxBukti);
            this.panel8.Location = new System.Drawing.Point(3, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 390);
            this.panel8.TabIndex = 24;
            // 
            // pictureBoxBukti
            // 
            this.pictureBoxBukti.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBukti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBukti.Name = "pictureBoxBukti";
            this.pictureBoxBukti.Size = new System.Drawing.Size(293, 386);
            this.pictureBoxBukti.TabIndex = 0;
            this.pictureBoxBukti.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(207, 113);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(207, 186);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 41;
            this.pictureBox5.TabStop = false;
            // 
            // TopUpLanjutan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.labelNoInvoice);
            this.DoubleBuffered = true;
            this.Name = "TopUpLanjutan";
            this.Text = "TopUpLanjutan";
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBukti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNoInvoice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBoxBukti;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}