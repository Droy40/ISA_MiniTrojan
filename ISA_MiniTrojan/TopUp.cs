using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class TopUp : Form
    {
        Dashboard dashboard;
        public TopUp()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Topup topup = new Topup();
                topup.User = dashboard.user;
                topup.Nominal = double.Parse(textBoxNominal.Text);

                if (Topup.TambahData(topup))
                {
                    MessageBox.Show("Topup berhasil");
                }
                else
                {
                    MessageBox.Show("Topup gagal");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TopUp_Load(object sender, EventArgs e)
        {
            dashboard = (Dashboard)this.Owner;
        }
    }
}
