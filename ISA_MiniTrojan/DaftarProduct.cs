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
using Guna.UI2.WinForms;

namespace ISA_MiniTrojan
{
    public partial class DaftarProduct : Form
    {
        public DaftarProduct()
        {
            InitializeComponent();
        }
        Dashboard utama;
        List<Product> listHasil;
        

        private void DaftarProduct_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.MdiParent;
            listHasil = Product.BacaData();
            dataGridViewProduct.Rows.Clear();
            foreach (Product p in listHasil)
            {
                dataGridViewProduct.Rows.Add(p.Id, p.Name, p.Price, p.Stock);
            }

            if (dataGridViewProduct.ColumnCount == 4)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewProduct.Columns.Add(btnDel);

                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbahGrid";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewProduct.Columns.Add(btnUbah);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TambahProduk form = new TambahProduk();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DaftarProduct_Load(guna2Button2, e);
            }
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduct.Columns["buttonUbahGrid"].Index && e.RowIndex >= 0)
            {
                EditProduk form = new EditProduk(listHasil[e.RowIndex]);
                form.Owner = this;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DaftarProduct_Load(dataGridViewProduct, e);
                }
            }
            else if (e.ColumnIndex == dataGridViewProduct.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
            {
                string kodeHapus = listHasil[e.RowIndex].Id.ToString();

                DialogResult hasil = MessageBox.Show(this, "anda yakin ingin menghapus produk id - " + kodeHapus + "?",
                    "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Product.HapusData(listHasil[e.RowIndex]);
                    if (hapus == true)
                    {
                        MessageBox.Show("penghapusan data berhasil");
                        DaftarProduct_Load(dataGridViewProduct, e);
                    }
                    else
                    {
                        MessageBox.Show("penghapusan data gagal");
                    }
                }
            }

        }
    }
}
