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
    public partial class Shoping : Form
    {
        public Shoping()
        {
            InitializeComponent();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {

        }

        private void Shoping_Load(object sender, EventArgs e)
        {
            formDashboard = (Dashboard)this.Owner;
            comboBoxBarang.DataSource = Product.BacaData();
            comboBoxBarang.DisplayMember = "Name";
            textBoxHarga.Text = ProductName.BacaData("P.Price", comboBoxBarang.SelectedItem.ToString());

            labelTotal.Text = (int.Parse(textBoxHarga.Text) * (int)numericUpDownJumlah.Value).ToString();
            labelDiskon.Text = 0;
            labelTotalAkhir.Text = (int.Parse(labelTotal.Text) * int.Parse(labelDiskon.Text)).ToString();
            labelSaldo.Text = 0;

        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
