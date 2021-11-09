using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WindowsFormsApp5
{
    public class ScannerTcpConnection : Control
    {
        private static string _barcodes_read;
        public string strData1;
        public string strData2;

        public string connection_status;
        public string connection_status2;


 //   public object Invoke(Delegate method, params object[] args);

        //Fired when the connection status changes in the TCP client - parsing these messages is up to the developer
        //I'm just adding the .ToString() of the state enum to a richtextbox here
        public void client_ConnectionStatusChanged(EventDrivenTCPClient sender, EventDrivenTCPClient.ConnectionStatus status)
        {
            connection_status = "Connection: " + status.ToString() + Environment.NewLine;

            //Check if this event was fired on a different thread, if it is then we must invoke it on the UI thread
            if (InvokeRequired)
            {
                Invoke(new EventDrivenTCPClient.delConnectionStatusChanged(client_ConnectionStatusChanged), sender, status);
                return;
            }

            //UpdateControl(label_status101, SystemColors.Window, connection_status, true);


        }


        public void client_ConnectionStatusChanged2(EventDrivenTCPClient sender, EventDrivenTCPClient.ConnectionStatus status)
        {

            //Check if this event was fired on a different thread, if it is then we must invoke it on the UI thread
            if (InvokeRequired)
            {
                Invoke(new EventDrivenTCPClient.delConnectionStatusChanged(client_ConnectionStatusChanged2), sender, status);
                return;
            }
            connection_status2 = "Connection: " + status.ToString() + Environment.NewLine;

            //      Form1._myWindow.UpdateControl(Form1._myWindow.label_status100, SystemColors.Window, connection_status, true);


        }



        //Fired when new data is received in the TCP client
        public void client_DataReceived(EventDrivenTCPClient sender, object data)
        {
            //Again, check if this needs to be invoked in the UI thread
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new EventDrivenTCPClient.delDataReceived(client_DataReceived), sender, data);
                }
                catch
                { }
                return;
            }
            //Interpret the received data object as a string
            strData1 = data as string;
            //Add the received data to a rich text box
            //  label3.Text = strData + Environment.NewLine;

            int b_lenght;

            switch (Form1.eq)
            {
                case 4:
                    b_lenght = 42;

                    break;

                case 3:
                    b_lenght = 84;
                    break;

                case 2:
                    b_lenght = 84;
                    break;
                case 1:
                    b_lenght = 126;
                    break;

                default:
                    b_lenght = 0;
                    MessageBox.Show("Wybierz ponownie produkt!");
                    break;
            }


      //      UpdateControl(label_b101, SystemColors.Window, strData, true);

            if (strData1.Length >= b_lenght)
            {
                _barcodes_read = strData1;
                try
                {
                    Thread.Sleep(100);
                    Form1.client2.Send("LON\r");

                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać komendy LON\r", "Błąd skaner 100");
                }
            }
            else if (!strData1.Contains("LOAD"))
            {

                try
                {
                    Thread.Sleep(100);
                    Form1.client.Send("LON\r");


                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać komendy LON\r", "Błąd skaner 101");
                }


            }

        }



        public void client_DataReceived2(EventDrivenTCPClient sender, object data2)
        {

            //Again, check if this needs to be invoked in the UI thread
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new EventDrivenTCPClient.delDataReceived(client_DataReceived2), sender, data2);
                }
                catch
                { }
                return;
            }
            //Interpret the received data object as a string
            strData2 = data2 as string;
            //Add the received data to a rich text box
            //  label3.Text = strData + Environment.NewLine;
            int b_lenght;

            switch (Form1.eq)
            {
                case 4:
                    b_lenght = 42 - 1;

                    break;

                case 3:
                    b_lenght = 84 - 1;
                    break;

                case 2:
                    b_lenght = 84 - 1;
                    break;
                case 1:
                    b_lenght = 126 - 1;
                    break;

                default:
                    b_lenght = 0;
                    MessageBox.Show("Wybierz ponownie produkt!");
                    break;
            }

     //       UpdateControl(label_b100, SystemColors.Window, strData2, true);

            if (strData2.Length >= b_lenght)
            {
                _barcodes_read += strData2;
                //         modbusClient.WriteSingleRegister(1003, 1);
                //   wysun_silownik();
                SplitComparecs.SplitCompare(_barcodes_read);



            }
            else if (!strData2.Contains("LOAD"))
            {
                try
                {
                    Thread.Sleep(100);
                    Form1.client2.Send("LON\r");

                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać komendy LON\r", "Błąd skaner 101");
                }
            }

        }


    }
}
