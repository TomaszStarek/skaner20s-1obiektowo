using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public static class SaveLog
    {

        public static string Truncate(string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }

            return value;
        }

        public static void CreateFileLog(string sn, int eqiuip)
        {
            int b_lenght;
            if (eqiuip == 3)
                b_lenght = 27;
            else
                b_lenght = 20;


            while ((!(sn[0] == 'J' || sn[0] == '1') || ((sn[0] == 'A') && ((sn[1] == 'D') || (sn[1] == 'V')))) && (sn.Length > b_lenght))
            {

                sn = sn.Remove(0, 1);

            }

            sn = Truncate(sn, b_lenght);


            string sciezka = ("C:/tars/");      //definiowanie ścieżki do której zapisywane logi
            DateTime start = DateTime.Now;
            DateTime stop = DateTime.Now;
            if (Directory.Exists(sciezka))       //sprawdzanie czy sciezka istnieje
            {
                ;
            }
            else
                System.IO.Directory.CreateDirectory(sciezka); //jeśli nie to ją tworzy
            if (sn != null)
                sn = Regex.Replace(sn, @"\s+", string.Empty);

            string sourceFile = @"C:/tars/" + @sn + @"(" + @stop.Day + @"-" + @stop.Month + @"-" + @stop.Year + @" " + @stop.Hour + @"-" + @stop.Minute + @"-" + @stop.Second + @")" + @".Tars";
            string destinationFile = @"C:/copylogi/" + @stop.Day + @"-" + @stop.Month + @"-" + @stop.Year + @"/" + @sn + @"(" + @stop.Day + @"-" + @stop.Month + @"-" + @stop.Year + @" " + @stop.Hour + @"-" + @stop.Minute + @"-" + @stop.Second + @")" + @".Tars";



            using (StreamWriter sw = new StreamWriter(sourceFile))
            {


                sw.WriteLine("S{0}", sn);
                sw.WriteLine("CITRON");

                if (eqiuip == 4)
                {
                    sw.WriteLine("NPLKWIM0T20S1L01_BTM");
                    sw.WriteLine("PPACE_BTM");
                }
                else
                {
                    sw.WriteLine("NPLKWIM0T20S1L01");
                    sw.WriteLine("PPACE_TOP");
                }

                sw.WriteLine("Ooperator");

                sw.WriteLine("[" + start.Year + "-" + start.Month + "-" + start.Day + " " + start.Hour + ":" + start.Minute + ":" + start.Second);
                sw.WriteLine("]" + stop.Year + "-" + stop.Month + "-" + stop.Day + " " + stop.Hour + ":" + stop.Minute + ":" + stop.Second);
                sw.WriteLine("TP");
                if (eqiuip == 1 || eqiuip == 2)
                {
                    //if (!(Form1.lotNumber.Length == 10))
                  //  {
                        sw.WriteLine("MLOT");
                        sw.WriteLine("d" + Form1.lotNumber);
                        sw.WriteLine(">");
                   // }
                }


                }



            if (Directory.Exists(@"C:/copylogi/" + @stop.Day + @"-" + @stop.Month + @"-" + @stop.Year + @"/"))       //sprawdzanie czy sciezka istnieje
            {
                ;
            }
            else
                System.IO.Directory.CreateDirectory(@"C:/copylogi/" + @stop.Day + @"-" + @stop.Month + @"-" + @stop.Year + @"/"); //jeśli nie to ją tworzy

            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }

        }
    }
}
