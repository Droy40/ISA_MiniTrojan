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
    public partial class UploadKTP : Form
    {
        public UploadKTP()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            openDialog.InitialDirectory =@"C:";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = openDialog.FileName.ToString();
                pictureBoxKtp.ImageLocation = textBoxFilePath.Text;

            }
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);

            for(int i = 0; i < img.Width; i++)
            {
                for(int j = 0;  j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if(i < 1 && j > textBoxNoKTP.TextLength)
                    {
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.R);
                        Console.WriteLine("R = [" + i + "][" + j + "] = " + pixel.G);
                        Console.WriteLine("B = [" + i + "][" + j + "] = " + pixel.B);

                        char letter = Convert.ToChar(textBoxNoKTP.Text.Substring(j,1));
                        int value = Convert.ToInt32(letter);
                        Console.WriteLine("Letter : " + letter + " value : " + pixel.B);
                        img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, value));
                    }

                    if(i == img.Width - 1 && j == img.Height - 1)
                    {
                        img.SetPixel(1, j, Color.FromArgb(pixel.R,pixel.G, textBoxNoKTP.TextLength));
                    }
                }              
            }
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Image Files (*.png, *.jpg) | *.png; *.jpg";
            saveFile.InitialDirectory = @"C:";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = saveFile.FileName.ToString();
                pictureBoxKtp.ImageLocation = textBoxFilePath.Text;
                img.Save(textBoxFilePath.Text);
            }
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(textBoxFilePath.Text);
            string message = "";
            Color lastPixel = img.GetPixel(img.Width - 1, img.Height - 1);
            int msgLength = lastPixel.B;
            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color pixel = img.GetPixel(i, j);

                    if (i < 1 && j > msgLength)
                    {
                        int value = pixel.B;
                        char c = Convert.ToChar(value);
                        string letter = System.Text.Encoding.ASCII.GetString(new byte[] {Convert.ToByte(c)});                       
                        
                        message += letter;
                    }
                }
            }
            textBoxNoKTP.Text = message;
        }
    }
}
