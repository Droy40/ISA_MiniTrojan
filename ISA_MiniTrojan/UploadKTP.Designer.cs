namespace ISA_MiniTrojan
{
    partial class UploadKTP
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
            this.pictureBoxKtp = new System.Windows.Forms.PictureBox();
            this.labelNoKTP = new System.Windows.Forms.Label();
            this.textBoxNoKTP = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKtp
            // 
            this.pictureBoxKtp.Location = new System.Drawing.Point(48, 12);
            this.pictureBoxKtp.Name = "pictureBoxKtp";
            this.pictureBoxKtp.Size = new System.Drawing.Size(357, 185);
            this.pictureBoxKtp.TabIndex = 44;
            this.pictureBoxKtp.TabStop = false;
            // 
            // labelNoKTP
            // 
            this.labelNoKTP.AutoSize = true;
            this.labelNoKTP.BackColor = System.Drawing.Color.Transparent;
            this.labelNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoKTP.ForeColor = System.Drawing.Color.White;
            this.labelNoKTP.Location = new System.Drawing.Point(12, 274);
            this.labelNoKTP.Name = "labelNoKTP";
            this.labelNoKTP.Size = new System.Drawing.Size(83, 20);
            this.labelNoKTP.TabIndex = 45;
            this.labelNoKTP.Text = "No. KTP :";
            // 
            // textBoxNoKTP
            // 
            this.textBoxNoKTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoKTP.Location = new System.Drawing.Point(100, 272);
            this.textBoxNoKTP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNoKTP.Name = "textBoxNoKTP";
            this.textBoxNoKTP.Size = new System.Drawing.Size(325, 24);
            this.textBoxNoKTP.TabIndex = 46;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonOpenFile.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonOpenFile.Location = new System.Drawing.Point(176, 203);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(118, 31);
            this.buttonOpenFile.TabIndex = 49;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            // 
            // buttonEncode
            // 
            this.buttonEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonEncode.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonEncode.Location = new System.Drawing.Point(48, 364);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(118, 31);
            this.buttonEncode.TabIndex = 50;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = false;
            // 
            // buttonDecode
            // 
            this.buttonDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.buttonDecode.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonDecode.Location = new System.Drawing.Point(287, 364);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(118, 31);
            this.buttonDecode.TabIndex = 51;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = false;
            // 
            // UploadKTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISA_MiniTrojan.Properties.Resources.backgroundFix;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxNoKTP);
            this.Controls.Add(this.labelNoKTP);
            this.Controls.Add(this.pictureBoxKtp);
            this.DoubleBuffered = true;
            this.Name = "UploadKTP";
            this.Text = "UploadKTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKtp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxKtp;
        private System.Windows.Forms.Label labelNoKTP;
        private System.Windows.Forms.TextBox textBoxNoKTP;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
    }
}