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
    public partial class RiwayatTransaksi : Form
    {
        public RiwayatTransaksi()
        {
            InitializeComponent();
        }
        Dashboard utama;
        private void RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.Parent;
            List<HistorySaldo> listHistory = HistorySaldo.BacaData("users_id", utama.user.Id.ToString());
            dataGridViewInvoice.Rows.Clear();
            foreach (HistorySaldo hs in listHistory) 
            {
                dataGridViewInvoice.Rows.Add(hs.Id, hs.WaktuTransaksi, hs.Nominal, hs.Jenis, hs.Transaksi.Id);
            }

            if (dataGridViewInvoice.ColumnCount == 5)
            {
                DataGridViewButtonColumn btnNota = new DataGridViewButtonColumn();
                btnNota.HeaderText = "Lihat Nota";
                btnNota.Text = "Lihat";
                btnNota.Name = "buttonNota";
                btnNota.UseColumnTextForButtonValue = true;
                dataGridViewInvoice.Columns.Add(btnNota);
            }
        }

        private void dataGridViewInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kodeTransaksi = dataGridViewInvoice.CurrentRow.Cells["ColumnIdTransaksi"].Value.ToString();
            if (e.ColumnIndex == dataGridViewInvoice.Columns["buttonNota"].Index)
            {
                Laporan.PrintLaporan1(int.Parse(kodeTransaksi));
            }
        }
    }
}
