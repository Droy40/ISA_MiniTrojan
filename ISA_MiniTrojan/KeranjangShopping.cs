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
    public partial class KeranjangShopping : Form
    {
        public KeranjangShopping()
        {
            InitializeComponent();
        }
        Dashboard utama;
        List<Keranjang> listKeranjang;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KeranjangShopping_Load(object sender, EventArgs e)
        {
            utama = (Dashboard)this.Owner;
            listKeranjang = Keranjang.BacaData("u.id", utama.user.Id.ToString());
            dataGridViewKeranjang.Rows.Clear();
            DisplayData();

        }

        private void DisplayData()
        {
            foreach (Keranjang k in listKeranjang)
            {
                dataGridViewKeranjang.Rows.Add(false, k.Product.Name, k.Product.Price, k.Jumlah);
            }
        }
    }
}
