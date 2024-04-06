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
                u = User.CekLogin(textBoxEmail.Text, textBoxPassword.Text);
                if(u != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Username/Password salah");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
