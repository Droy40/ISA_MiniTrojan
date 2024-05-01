namespace ISA_MiniTrojan
{
    partial class RiwayatTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiwayatTransaksi));
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.ColumnIdHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTgl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJenis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRegister = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack.Image")));
            this.pictureBoxBack.Location = new System.Drawing.Point(18, 366);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(38, 39);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 39;
            this.pictureBoxBack.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 19;
            this.guna2Panel1.Controls.Add(this.textBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(2)))), ((int)(((byte)(3)))));
            this.guna2Panel1.Location = new System.Drawing.Point(18, 70);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(510, 41);
            this.guna2Panel1.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Transaction";
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdHistory,
            this.ColumnTgl,
            this.ColumnNominal,
            this.ColumnJenis,
            this.ColumnIdTransaksi});
            this.dataGridViewInvoice.Location = new System.Drawing.Point(18, 122);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.RowTemplate.Height = 24;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(510, 239);
            this.dataGridViewInvoice.TabIndex = 37;
            this.dataGridViewInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInvoice_CellContentClick);
            // 
            // ColumnIdHistory
            // 
            this.ColumnIdHistory.HeaderText = "Id History";
            this.ColumnIdHistory.MinimumWidth = 6;
            this.ColumnIdHistory.Name = "ColumnIdHistory";
            this.ColumnIdHistory.ReadOnly = true;
            this.ColumnIdHistory.Width = 125;
            // 
            // ColumnTgl
            // 
            this.ColumnTgl.HeaderText = "Tanggal Transaksi";
            this.ColumnTgl.MinimumWidth = 6;
            this.ColumnTgl.Name = "ColumnTgl";
            this.ColumnTgl.ReadOnly = true;
            this.ColumnTgl.Width = 125;
            // 
            // ColumnNominal
            // 
            this.ColumnNominal.HeaderText = "Nominal Transaksi";
            this.ColumnNominal.MinimumWidth = 6;
            this.ColumnNominal.Name = "ColumnNominal";
            this.ColumnNominal.ReadOnly = true;
            this.ColumnNominal.Width = 125;
            // 
            // ColumnJenis
            // 
            this.ColumnJenis.HeaderText = "Jenis Transaksi";
            this.ColumnJenis.MinimumWidth = 6;
            this.ColumnJenis.Name = "ColumnJenis";
            this.ColumnJenis.ReadOnly = true;
            this.ColumnJenis.Width = 125;
            // 
            // ColumnIdTransaksi
            // 
            this.ColumnIdTransaksi.HeaderText = "Id Transaksi";
            this.ColumnIdTransaksi.MinimumWidth = 6;
            this.ColumnIdTransaksi.Name = "ColumnIdTransaksi";
            this.ColumnIdTransaksi.ReadOnly = true;
            this.ColumnIdTransaksi.Width = 125;
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.labelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelRegister.Location = new System.Drawing.Point(4, 5);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(231, 39);
            this.labelRegister.TabIndex = 34;
            this.labelRegister.Text = "Riwayat Transaksi";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.labelRegister);
            this.panel3.Location = new System.Drawing.Point(164, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 49);
            this.panel3.TabIndex = 34;
            // 
            // RiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 444);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RiwayatTransaksi";
            this.Text = "RiwayatTransaksi";
            this.Load += new System.EventHandler(this.RiwayatTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJenis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdTransaksi;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Panel panel3;
    }
}