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
    public partial class DaftarStaff : Form
    {
        public DaftarStaff()
        {
            InitializeComponent();
        }
        Dashboard utama;
        private void DaftarStaff_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.Parent;
            List<User> listHasil = User.BacaDataStaff();
            dataGridViewUser.Rows.Clear();
            foreach (User u in listHasil)
            {
                dataGridViewUser.Rows.Add(u.Id, u.Username, u.Email, u.Nama, u.Saldo, u.Sisa_percobaan_login);
            }

            if (dataGridViewUser.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnDel);

                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbahGrid";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnUbah);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TambahStaff form = new TambahStaff();
            form.Owner = this;
            form.ShowDialog();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
