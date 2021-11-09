using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class SplitComparecs
    {

        public static void SplitCompare(string to_split)
        {
            int b_lenght;
            int b_count;
            int n_count = 0;


            switch (Form1.eq)
            {
                case 4:
                    b_lenght = 20;
                    b_count = 4;
                    break;

                case 3:
                    b_lenght = 27;
                    b_count = 6;
                    break;

                case 2:
                    b_lenght = 20;
                    b_count = 8;
                    break;
                case 1:
                    b_lenght = 20;
                    b_count = 12;
                    break;

                default:

                    b_lenght = 0;
                    b_count = 0;
                    MessageBox.Show("Wybierz ponownie produkt!");
                    break;
            }


            if (b_lenght > 0)
            {
                string[] subs = to_split.Split(',');

                string[] bufor = new string[b_count + 5];

                foreach (var sub in subs)
                {

                    if (sub.Length >= b_lenght)
                    {
                        if (b_count > n_count)
                            bufor[n_count] = @sub;
                        else
                            MessageBox.Show("Przekroczono miejsce tablicy!", "Błąd");
                        n_count++;

                        if (b_count == n_count)
                        {
                            Thread t = new Thread(SendToPlc.SendToPlcActuatorState);
                            t.Start();

                            int counter = 0;

                            foreach (var sub2 in bufor)
                            {

                                counter++;

                                SaveLog.CreateFileLog(sub2, Form1.eq);
                                Form1._myWindow.show_barkodes(sub2, counter);

                                switch (Form1.eq)
                                {
                                    case 4:
                                        if (counter >= 4)
                                        {
                                            Task.Run(() => Form1._myWindow.clear_barkodes());
                                        }
                                        break;

                                    case 3:
                                        if (counter >= 6)
                                        {
                                            Task.Run(() => Form1._myWindow.clear_barkodes());
                                        }
                                        break;
                                    case 2:
                                        if (counter >= 8)
                                        {
                                            Task.Run(() => Form1._myWindow.clear_barkodes());
                                        }
                                        break;
                                    case 1:
                                        if (counter >= 12)
                                        {
                                            Task.Run(() => Form1._myWindow.clear_barkodes());
                                        }


                                        break;
                                    default:

                                        break;
                                }
                            }

                        }
                        else
                        {
                        }
                    }

                }

                if (b_count > n_count)
                {
                    try
                    {
                        Thread.Sleep(100);
                        Form1.client.Send("LON\r");

                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się wysłać komendy LON\r", "Błąd");
                    }
                }


            }



        }

    }
}
