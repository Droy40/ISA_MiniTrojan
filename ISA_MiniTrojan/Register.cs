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
        public User u;

        private void buttonUploadKTP_Click(object sender, EventArgs e)
        {
            u = new User();
            u.Email = textBoxEmail.Text;
            u.Username = textBoxUsername.Text;
            u.Nama = textBoxNama.Text;
            u.Password = textBoxPassword.Text;
            u.Role = "Konsumen";

            UploadKTP uploadKTP = new UploadKTP();
            uploadKTP.Owner = this;
            uploadKTP.ShowDialog();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
