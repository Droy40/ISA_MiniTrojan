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
    public partial class CekKTP : Form
    {
        public CekKTP()
        {
            InitializeComponent();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUser.SelectedIndex != -1)
            {
                User selectedUser = (User)(comboBoxUser.SelectedItem);
                pictureBoxKtp.Image = User.BacaGambar(selectedUser.Foto_ktp);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBoxKtp.Image);
            string message = "";

            Color lastpixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastpixel.B;

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j < msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });

                        message = message + letter;
                    }
                }
            }

            textBoxHasilDecode.Text = message;
        }
    }
}
