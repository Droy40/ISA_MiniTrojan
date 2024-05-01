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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }
        public string kodeUser;
        DaftarUser parent;
        private void Invoice_Load(object sender, EventArgs e)
        {
            parent = (DaftarUser)this.Parent.Parent;
            List<Transaksi> listHasil = Transaksi.BacaData("u.id", kodeUser);
            dataGridViewInvoice.Rows.Clear();
            foreach (Transaksi t in listHasil)
            {
                dataGridViewInvoice.Rows.Add(t.User.Nama, t.User.Id, t.Id, t.Date, t.Total);
            }

            if (dataGridViewInvoice.ColumnCount == 3)
            {
                DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
                btnDetail.HeaderText = "Detail Transaksi";
                btnDetail.Text = "Lihat";
                btnDetail.Name = "buttonDetail";
                btnDetail.UseColumnTextForButtonValue = true;
                dataGridViewInvoice.Columns.Add(btnDetail);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            List<Transaksi> listHasil = Transaksi.BacaData("t.id", textBoxId.Text);
            dataGridViewInvoice.Rows.Clear();
            foreach (Transaksi t in listHasil)
            {
                dataGridViewInvoice.Rows.Add(t.Id, t.Date, t.Total);
            }

            if (dataGridViewInvoice.ColumnCount == 3)
            {
                DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn();
                btnDetail.HeaderText = "Detail Transaksi";
                btnDetail.Text = "Lihat";
                btnDetail.Name = "buttonDetail";
                btnDetail.UseColumnTextForButtonValue = true;
                dataGridViewInvoice.Columns.Add(btnDetail);
            }
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kodeTransaksi = dataGridViewInvoice.CurrentRow.Cells["ColumnId"].Value.ToString();
            if (e.ColumnIndex == dataGridViewInvoice.Columns["buttonDetail"].Index)
            {
                DetailTransaksi form = new DetailTransaksi();
                form.Owner = this;
                form.selectedTransaksi = kodeTransaksi;
                form.ShowDialog();

                Invoice_Load(this, e);
            }
        }
    }
}
