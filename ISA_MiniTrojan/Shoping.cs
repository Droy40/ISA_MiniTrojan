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
    public partial class Shoping : Form
    {
        Dashboard formDashboard;
        public Shoping()
        {
            InitializeComponent();
        }

        private void Shoping_Load(object sender, EventArgs e)
        {
            formDashboard = (Dashboard)this.Owner;

            comboBoxBarang.DataSource = Product.BacaData();
            comboBoxBarang.DisplayMember = "Name";
            textBoxHarga.Text = Product.BacaData("P.Price", comboBoxBarang.SelectedValue);

            labelDeskripsi.Text = Product.BacaData("P.Description", comboBoxBarang.SelectedItem.ToString());
            labelHargaTotal.Text = (int.Parse(textBoxHarga.Text) * (int)numericUpDownJumlah.Value).ToString();
            labelDiskonHarga.Text = "";
            labelHargaAkhir.Text = (int.Parse(labelTotal.Text) * int.Parse(labelDiskon.Text)).ToString();
            labelTotalSaldo.Text = "";
        }
    }
}
