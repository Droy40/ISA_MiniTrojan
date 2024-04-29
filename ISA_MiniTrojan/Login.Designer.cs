namespace ISA_MiniTrojan
{
    partial class Login
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
            this.panelDepan = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelBlkng = new System.Windows.Forms.Panel();
            this.panelDepan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDepan
            // 
            this.panelDepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panelDepan.Controls.Add(this.buttonBack);
            this.panelDepan.Controls.Add(this.textBoxPassword);
            this.panelDepan.Controls.Add(this.labelPassword);
            this.panelDepan.Controls.Add(this.buttonLogin);
            this.panelDepan.Controls.Add(this.linkLabelRegister);
            this.panelDepan.Controls.Add(this.textBoxUser);
            this.panelDepan.Controls.Add(this.labelUsername);
            this.panelDepan.Controls.Add(this.labelLogin);
            this.panelDepan.Location = new System.Drawing.Point(185, 55);
            this.panelDepan.Name = "panelDepan";
            this.panelDepan.Size = new System.Drawing.Size(430, 339);
            this.panelDepan.TabIndex = 6;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 47;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(144, 157);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(231, 27);
            this.textBoxPassword.TabIndex = 46;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPassword.Location = new System.Drawing.Point(23, 157);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(109, 22);
            this.labelPassword.TabIndex = 45;
            this.labelPassword.Text = "Password :";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Yellow;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(154, 262);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(147, 35);
            this.buttonLogin.TabIndex = 44;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(46, 231);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(58, 16);
            this.linkLabelRegister.TabIndex = 21;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(144, 124);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(231, 27);
            this.textBoxUser.TabIndex = 18;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUsername.Location = new System.Drawing.Point(20, 124);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(112, 22);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "Username :";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(191)))), ((int)(((byte)(10)))));
            this.labelLogin.Location = new System.Drawing.Point(87, 16);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(251, 65);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBlkng
            // 
            this.panelBlkng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(185)))), ((int)(((byte)(13)))));
            this.panelBlkng.Location = new System.Drawing.Point(180, 49);
            this.panelBlkng.Name = "panelBlkng";
            this.panelBlkng.Size = new System.Drawing.Size(440, 353);
            this.panelBlkng.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDepan);
            this.Controls.Add(this.panelBlkng);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelDepan.ResumeLayout(false);
            this.panelDepan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDepan;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelBlkng;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonBack;
    }
}