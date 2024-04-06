using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User();
                u.Name = textBoxNama.Text;
                u.Email = textBoxEmail.Text;
                if (radioButtonMale.Checked)
                {
                    u.Gender = "M";
                }
                else
                {
                    u.Gender = "L";
                }
                u.NoKtp = textBoxNoKTP.Text;
                u.Password = textBoxPassword.Text;
                //u.ImgKtp = upload ktp
                User.TambahData(u);
                MessageBox.Show("Register Berhasil");
                this.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
