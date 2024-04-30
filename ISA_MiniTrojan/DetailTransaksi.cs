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
    public partial class DetailTransaksi : Form
    {
        public DetailTransaksi()
        {
            InitializeComponent();
        }
        Invoice parent;
        public string selectedTransaksi;
        private void DetailTransaksi_Load(object sender, EventArgs e)
        {
            parent = (Invoice)this.Parent.Parent.Parent;
            List<Transaksi> listHasil = Transaksi.BacaData("u.id", selectedTransaksi);
            Transaksi pilih = listHasil[0];
            List<ClassLibrary.DetailTransaksi> listDetail = pilih.DetailTransaksiList;
            dataGridViewInvoice.Rows.Clear();
            foreach (ClassLibrary.DetailTransaksi dt in listDetail)
            {
                dataGridViewInvoice.Rows.Add(dt.Product.Name, dt.Quantity, dt.Harga);
            }
        }
    }
}
