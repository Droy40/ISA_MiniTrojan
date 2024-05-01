namespace ISA_MiniTrojan
{
    partial class DetailTransaksi
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRegister = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.ColumnProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNominal = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.labelRegister);
            this.panel3.Location = new System.Drawing.Point(167, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 60);
            this.panel3.TabIndex = 40;
            // 
            // labelRegister
            // 
            this.labelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.labelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelRegister.Location = new System.Drawing.Point(5, 6);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(307, 48);
            this.labelRegister.TabIndex = 34;
            this.labelRegister.Text = "Detail Transaksi";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduk,
            this.ColumnJumlah,
            this.ColumnHarga});
            this.dataGridViewInvoice.Location = new System.Drawing.Point(36, 272);
            this.dataGridViewInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.RowHeadersWidth = 51;
            this.dataGridViewInvoice.RowTemplate.Height = 24;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(573, 180);
            this.dataGridViewInvoice.TabIndex = 41;
            // 
            // ColumnProduk
            // 
            this.ColumnProduk.HeaderText = "Produk";
            this.ColumnProduk.MinimumWidth = 6;
            this.ColumnProduk.Name = "ColumnProduk";
            this.ColumnProduk.ReadOnly = true;
            this.ColumnProduk.Width = 125;
            // 
            // ColumnJumlah
            // 
            this.ColumnJumlah.HeaderText = "Jumlah";
            this.ColumnJumlah.MinimumWidth = 6;
            this.ColumnJumlah.Name = "ColumnJumlah";
            this.ColumnJumlah.ReadOnly = true;
            this.ColumnJumlah.Width = 125;
            // 
            // ColumnHarga
            // 
            this.ColumnHarga.HeaderText = "Harga";
            this.ColumnHarga.MinimumWidth = 6;
            this.ColumnHarga.Name = "ColumnHarga";
            this.ColumnHarga.ReadOnly = true;
            this.ColumnHarga.Width = 125;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBack.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack.Image = global::ISA_MiniTrojan.Properties.Resources.back_1689837_1280_removebg_preview;
            this.pictureBoxBack.Location = new System.Drawing.Point(36, 470);
            this.pictureBoxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(51, 48);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBack.TabIndex = 44;
            this.pictureBoxBack.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.labelNominal);
            this.panel1.Controls.Add(this.labelTanggal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelNama);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 137);
            this.panel1.TabIndex = 45;
            // 
            // labelNominal
            // 
            this.labelNominal.AutoSize = true;
            this.labelNominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNominal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNominal.Location = new System.Drawing.Point(450, 86);
            this.labelNominal.Name = "labelNominal";
            this.labelNominal.Size = new System.Drawing.Size(80, 22);
            this.labelNominal.TabIndex = 8;
            this.labelNominal.Text = "0000000";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelTanggal.Location = new System.Drawing.Point(434, 19);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(104, 22);
            this.labelTanggal.TabIndex = 7;
            this.labelTanggal.Text = "dd/MM/yyyy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(417, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelNama.Location = new System.Drawing.Point(147, 21);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(54, 22);
            this.labelNama.TabIndex = 5;
            this.labelNama.Text = "nama";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelId.Location = new System.Drawing.Point(147, 88);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(30, 22);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(293, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(293, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Nominal :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama User :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(18, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Transaksi :";
            // 
            // DetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridViewInvoice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DetailTransaksi";
            this.Text = "DetailTransaksi";
            this.Load += new System.EventHandler(this.DetailTransaksi_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHarga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNominal;
    }
}