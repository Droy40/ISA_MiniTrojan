using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Stegano
    {
        public static void SembunyikanPesan(string pesan, string imagePath, string outputImagePath)
        {
            SteganographyHelper steganographyHelper = new SteganographyHelper();
            steganographyHelper.HideText(pesan, imagePath, outputImagePath);
        }

    public static string DapatkanPesanDariGambar(string imagePath)
        {
            SteganographyHelper steganographyHelper = new SteganographyHelper();
            return steganographyHelper.GetText(imagePath);
        }+
}
