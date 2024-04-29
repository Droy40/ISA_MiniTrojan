using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static User u;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(buttonLogin.Text == "Lanjut")
                {
                    if (User.CekLoginUsername(AES.Encrypt(textBoxUser.Text, AES.key)))
                    {
                        labelPassword.Visible = true;
                        textBoxPassword.Visible = true;
                        buttonBack.Visible = true;
                        textBoxUser.Enabled = false;

                        buttonLogin.Text = "Login";
                    }                    
                }
                else
                {
                    u = User.CekLoginUsernamePassword(AES.Encrypt(textBoxUser.Text,AES.key), SHA.ComputeHash(textBoxPassword.Text));
                    MessageBox.Show("Login Berhasil");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            buttonBack.Visible = false;
            textBoxUser.Enabled = true;

            buttonLogin.Text = "Lanjut";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            buttonBack.Visible = false;
            textBoxUser.Enabled = true;

            buttonLogin.Text = "Lanjut";

        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register fr = new Register();
            fr.ShowDialog();
        }
    }
}
