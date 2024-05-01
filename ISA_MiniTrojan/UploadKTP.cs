using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ISA_MiniTrojan
{
    public partial class UploadKTP : Form
    {
        public UploadKTP()
        {
            InitializeComponent();
        }
        Register form;
        public string filePath;
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory = @"C:\github\ISA_MiniTrojan\KTP";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBoxKtp.ImageLocation = textBoxFilePath.Text;
            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            //Bitmap img = new Bitmap(textBoxFilePath.Text);

            //for (int i = 0; i < img.Width; i++)
            //{
            //    for (int j = 0; j < img.Height; j++)
            //    {
            //        Color pixel = img.GetPixel(i, j);

            //        if (i < 1 && j < textBoxNoKTP.TextLength)
            //        {
            //            Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
            //            Console.WriteLine("G = [" + i + "][" + j + "] = " + pixel.G);
            //            Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

            //            char letter = Convert.ToChar(textBoxNoKTP.Text.Substring(j, 1));
            //            int value = Convert.ToInt32(letter);
            //            Console.WriteLine("letter : " + letter + " value : " + value);

            //            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
            //        }

            //        if (i == img.Width - 1 && j == img.Height - 1)
            //        {
            //            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, textBoxNoKTP.TextLength));
            //        }

            //    }
            //}

            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            //saveFile.InitialDirectory = @"C:\github\ISA_MiniTrojan";

            //if (saveFile.ShowDialog() == DialogResult.OK)
            //{
            //    textBoxFilePath.Text = saveFile.FileName.ToString();
            //    pictureBoxKtp.ImageLocation = textBoxFilePath.Text;

            //    img.Save(textBoxFilePath.Text);
            //    User u = new User();
            //    User.SimpanGambar(u, pictureBoxKtp.Image);
            //    MessageBox.Show("Photo has been saved!");
            //}
        }

    private void UploadKTP_Load(object sender, EventArgs e)
        {
            form = (Register)this.Owner;
            buttonRegister.Enabled = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //User.Register(form, filePath,textBoxNoKTP.Text);
                MessageBox.Show("Register Berhasil");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
