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
                
                bool tmp = User.CekLoginUsername(textBoxEmail.Text);
                if(tmp)
                {
                    labelUsername.Visible = false;
                    textBoxEmail.Visible = false;
                    labelPassword.Visible = true;
                    textBoxPassword.Visible = true;
                    u = User.CekLoginPassword(textBoxEmail.Text, textBoxPassword.Text);
                    if (u != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Password salah");
                    }
                }
                else
                {
                    MessageBox.Show(this, "Username salah");
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
    }
}
