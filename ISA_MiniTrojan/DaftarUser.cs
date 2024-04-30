using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace ISA_MiniTrojan
{
    public partial class DaftarUser : Form
    {
        public DaftarUser()
        {
            InitializeComponent();
        }
        Dashboard utama;
        private void DaftarUser_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.MdiParent;
            List<User> listHasil = User.BacaData();
            dataGridViewUser.Rows.Clear();
            foreach (User u in listHasil)
            {                
                dataGridViewUser.Rows.Add(u.Id, u.Username, u.Email, u.Nama, u.Saldo, u.Sisa_percobaan_login);
            }

            if (dataGridViewUser.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnAktif = new DataGridViewButtonColumn();
                btnAktif.HeaderText = "Aktivasi Akun";
                btnAktif.Text = "Aktifkan";
                btnAktif.Name = "buttonAktifGrid";
                btnAktif.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnAktif);

                DataGridViewButtonColumn btnTransaksi = new DataGridViewButtonColumn();
                btnTransaksi.HeaderText = "Lihat Transaksi";
                btnTransaksi.Text = "Lihat";
                btnTransaksi.Name = "buttonLihatGrid";
                btnTransaksi.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnTransaksi);
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            List<User> listHasil = User.BacaData("username", textBoxUsername.Text);
            dataGridViewUser.Rows.Clear();
            foreach (User u in listHasil)
            {
                dataGridViewUser.Rows.Add(u.Id, u.Username, u.Email, u.Nama, u.Saldo, u.Sisa_percobaan_login);
            }

            if (dataGridViewUser.ColumnCount == 6)
            {
                DataGridViewButtonColumn btnAktif = new DataGridViewButtonColumn();
                btnAktif.HeaderText = "Aktivasi Akun";
                btnAktif.Text = "Aktifkan";
                btnAktif.Name = "buttonAktifGrid";
                btnAktif.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnAktif);

                DataGridViewButtonColumn btnTransaksi = new DataGridViewButtonColumn();
                btnTransaksi.HeaderText = "Lihat Transaksi";
                btnTransaksi.Text = "Lihat";
                btnTransaksi.Name = "buttonLihatGrid";
                btnTransaksi.UseColumnTextForButtonValue = true;
                dataGridViewUser.Columns.Add(btnTransaksi);
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dataGridViewUser.CurrentRow.Cells["ColumnId"].Value.ToString();
            if (e.ColumnIndex == dataGridViewUser.Columns["buttonAktifGrid"].Index)
            {
                DialogResult hasil = MessageBox.Show("Yakin mengaktifkan akun " + kode + " ?", "AKFITKAN", MessageBoxButtons.YesNo);
                if (hasil == DialogResult.Yes)
                {
                    
                }
            }
            else if (e.ColumnIndex == dataGridViewUser.Columns["buttonLihatGrid"].Index)
            {
                Invoice form = new Invoice();
                form.Owner = this;
                form.kodeUser = kode;
                form.ShowDialog();

                DaftarUser_Load(this, e);
            }
        }
    }
}
