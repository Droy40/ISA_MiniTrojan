namespace ISA_MiniTrojan
{
    partial class DaftarTopUp
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
            this.dataGridViewTopUp = new System.Windows.Forms.DataGridView();
            this.labelNoInvoice = new System.Windows.Forms.Label();
            this.buttonTopUp = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTopUp
            // 
            this.dataGridViewTopUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTopUp.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewTopUp.Name = "dataGridViewTopUp";
            this.dataGridViewTopUp.RowHeadersWidth = 51;
            this.dataGridViewTopUp.RowTemplate.Height = 24;
            this.dataGridViewTopUp.Size = new System.Drawing.Size(722, 348);
            this.dataGridViewTopUp.TabIndex = 0;
            this.dataGridViewTopUp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTopUp_CellContentClick);
            // 
            // labelNoInvoice
            // 
            this.labelNoInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.labelNoInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNoInvoice.Location = new System.Drawing.Point(248, 9);
            this.labelNoInvoice.Name = "labelNoInvoice";
            this.labelNoInvoice.Size = new System.Drawing.Size(255, 54);
            this.labelNoInvoice.TabIndex = 24;
            this.labelNoInvoice.Text = "Top-Up";
            this.labelNoInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTopUp
            // 
            this.buttonTopUp.AutoRoundedCorners = true;
            this.buttonTopUp.BackColor = System.Drawing.Color.Transparent;
            this.buttonTopUp.BorderColor = System.Drawing.Color.Firebrick;
            this.buttonTopUp.BorderRadius = 22;
            this.buttonTopUp.BorderThickness = 2;
            this.buttonTopUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTopUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonTopUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonTopUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonTopUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonTopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTopUp.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonTopUp.Location = new System.Drawing.Point(554, 419);
            this.buttonTopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTopUp.Name = "buttonTopUp";
            this.buttonTopUp.Size = new System.Drawing.Size(180, 46);
            this.buttonTopUp.TabIndex = 43;
            this.buttonTopUp.Text = "Top-Up";
            // 
            // DaftarTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 476);
            this.Controls.Add(this.buttonTopUp);
            this.Controls.Add(this.labelNoInvoice);
            this.Controls.Add(this.dataGridViewTopUp);
            this.DoubleBuffered = true;
            this.Name = "DaftarTopUp";
            this.Text = "TopUp";
            this.Load += new System.EventHandler(this.TopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTopUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTopUp;
        private System.Windows.Forms.Label labelNoInvoice;
        private Guna.UI2.WinForms.Guna2Button buttonTopUp;
    }
}