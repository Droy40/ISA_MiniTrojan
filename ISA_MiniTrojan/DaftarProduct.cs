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
    public partial class DaftarProduct : Form
    {
        public DaftarProduct()
        {
            InitializeComponent();
        }
        Dashboard utama;
        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DaftarProduct_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.MdiParent;
            List<Product> listHasil = Product.BacaData();
            dataGridViewHasil.Rows.Clear();
            foreach (Studio f in listHasil)
            {
                dataGridViewHasil.Rows.Add(f.Nama, f.Kapasitas, f.Jenis.Nama, f.Cinema.NamaCabang, f.HargaWeekday, f.HargaWeekend);
            }

            if (dataGridViewHasil.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnDel = new DataGridViewButtonColumn();
                btnDel.HeaderText = "AKSI";
                btnDel.Text = "HAPUS";
                btnDel.Name = "buttonHapusGrid";
                btnDel.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnDel);

                DataGridViewButtonColumn btnUbah = new DataGridViewButtonColumn();
                btnUbah.HeaderText = "AKSI";
                btnUbah.Text = "UBAH";
                btnUbah.Name = "buttonUbahGrid";
                btnUbah.UseColumnTextForButtonValue = true;
                dataGridViewHasil.Columns.Add(btnUbah);
            }
        }
    }
}
