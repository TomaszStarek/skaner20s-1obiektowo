using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EasyModbus;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Timers;
using System.Net;

namespace WindowsFormsApp5
{


    public partial class Form1 : Form
    {
        //modbus do sterownika
        public static ModbusClient modbusClient = new ModbusClient("192.168.100.8", 502);    //Ip-Address and Port of Modbus-TCP-Server


        //do skanerow
        public static EventDrivenTCPClient client;
        public static EventDrivenTCPClient client2;

        private readonly object x = new object();

        public static Form1 _myWindow;

        public static string lotNumber;

        public static int eq;

        public Form1()
        {
            InitializeComponent();
            _myWindow = this;

            radioButtonLinky.Checked = false;
            radioButtonSmets.Checked = false;
            radioButtonCyble8.Checked = false;
            radioButtonCyble12.Checked = false;

            //Initialize the event driven client
            client = new EventDrivenTCPClient(IPAddress.Parse("192.168.100.101"), int.Parse("9004"));
            //Initialize the events
            var scanner1 = new ScannerTcpConnection();
            client.DataReceived += new EventDrivenTCPClient.delDataReceived(scanner1.client_DataReceived);
            client.ConnectionStatusChanged += new EventDrivenTCPClient.delConnectionStatusChanged(scanner1.client_ConnectionStatusChanged);
            client.Connect();

            //Initialize the event driven client
            client2 = new EventDrivenTCPClient(IPAddress.Parse("192.168.100.100"), int.Parse("9004"));
            //Initialize the events
            var scanner2 = new ScannerTcpConnection();
            client2.DataReceived += new EventDrivenTCPClient.delDataReceived(scanner2.client_DataReceived2);
            client2.ConnectionStatusChanged += new EventDrivenTCPClient.delConnectionStatusChanged(scanner2.client_ConnectionStatusChanged2);
            client2.Connect();         

            try
            {
                modbusClient.Connect();
            }
            catch (EasyModbus.Exceptions.ConnectionException ex)
            {
                MessageBox.Show("Modbus ConnectionException: " + ex);
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                MessageBox.Show("Modbus SocketException: " + ex);
            }

            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            textBox1.KeyDown += textBox2_KeyDown;

        }

        private void textBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string buff;

            if (e.KeyCode == Keys.Enter)
            {
                buff = textBox1.Text.ToUpper();
                buff = Regex.Replace(buff, @"\s+", string.Empty);
                if (buff.Length >= 20 && buff.Length <= 27)
                {
                    SaveLog.CreateFileLog(buff, eq);
                    textBox1.Text = "";
                }
                else
                    MessageBox.Show("zla dlugosc znakow!");
                
            }
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }
        public void UpdateControl(Control myControl, Color c, String s, bool widzialnosc)
        {
            try
            {
                //Check if invoke requied if so return - as i will be recalled in correct thread
                if (ControlInvokeRequired(myControl, () => UpdateControl(myControl, c, s, widzialnosc))) return;
                myControl.Text = s;
                myControl.BackColor = c;
                myControl.Visible = widzialnosc;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //port.Write("LON\r");
        }

        public void clear_barkodes()
        {
            Thread.Sleep(2500);

            this.Invoke(new MethodInvoker(delegate {
                // Executes the following code on the GUI thread.
                this.BackColor = SystemColors.ScrollBar;
            }));

            if (eq == 4)
            {
                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 3)
            {
                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 2)
            {
                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode4, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode10, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 1)
            {
                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode4, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode5, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode6, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode10, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode11, SystemColors.ScrollBar, "", true);
                UpdateControl(labelBarcode12, SystemColors.ScrollBar, "", true);
            }
         }


        public void show_barkodes(string barkode, int n_barkode)
        {
            lock (x)
            {
                if (eq == 4)
                {
                    switch (n_barkode)
                    {
                        case 1:
                            UpdateControl(labelBarcode1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(labelBarcode2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(labelBarcode7, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(labelBarcode8, Color.PaleGreen, barkode, true);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                // Executes the following code on the GUI thread.
                                this.BackColor = Color.PaleGreen;
                            }));
                            break;

                        default:
                            break;
                    }
                }
                else if (eq == 3)
                {
                    switch (n_barkode)
                    {
                        case 1:
                            UpdateControl(labelBarcode1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(labelBarcode2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(labelBarcode3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(labelBarcode7, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(labelBarcode8, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(labelBarcode9, Color.PaleGreen, barkode, true);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                // Executes the following code on the GUI thread.
                                this.BackColor = Color.PaleGreen;
                            }));
                            break;

                        default:
                            break;
                    }
                }
                else if (eq == 2)
                {
                    switch (n_barkode)
                    {
                        case 1:
                            UpdateControl(labelBarcode1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(labelBarcode2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(labelBarcode3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(labelBarcode4, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(labelBarcode7, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(labelBarcode8, Color.PaleGreen, barkode, true);
                            break;
                        case 7:
                            UpdateControl(labelBarcode9, Color.PaleGreen, barkode, true);
                            break;
                        case 8:
                            UpdateControl(labelBarcode10, Color.PaleGreen, barkode, true);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                // Executes the following code on the GUI thread.
                                this.BackColor = Color.PaleGreen;
                            }));
                            break;

                        default:
                            break;
                    }
                }
                else if (eq == 1)
                {
                    switch (n_barkode)
                    {
                        case 1:
                            UpdateControl(labelBarcode1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(labelBarcode2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(labelBarcode3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(labelBarcode4, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(labelBarcode5, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(labelBarcode6, Color.PaleGreen, barkode, true);
                            break;
                        case 7:
                            UpdateControl(labelBarcode7, Color.PaleGreen, barkode, true);
                            break;
                        case 8:
                            UpdateControl(labelBarcode8, Color.PaleGreen, barkode, true);
                            break;
                        case 9:
                            UpdateControl(labelBarcode9, Color.PaleGreen, barkode, true);
                            break;
                        case 10:
                            UpdateControl(labelBarcode10, Color.PaleGreen, barkode, true);
                            break;
                        case 11:
                            UpdateControl(labelBarcode11, Color.PaleGreen, barkode, true);
                            break;
                        case 12:
                            UpdateControl(labelBarcode12, Color.PaleGreen, barkode, true);
                            this.Invoke(new MethodInvoker(delegate
                            {
                                // Executes the following code on the GUI thread.
                                this.BackColor = Color.PaleGreen;
                            }));
                            break;

                        default:
                            break;
                    }
                }
            }
        }



        private void show_controls(int c_count)
        {
            if (c_count == 4)
            {
                UpdateControl(labelDescription1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(labelDescription2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(labelDescription7, SystemColors.Control, "Barkod3:", true);
                UpdateControl(labelDescription8, SystemColors.Control, "Barkod4:", true);

                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "Barkod4:", true);

                UpdateControl(labelDescription3, SystemColors.Control, "Barkod3:", false);
                UpdateControl(labelDescription4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(labelDescription5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelDescription6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelDescription9, SystemColors.Control, "Barkod9:", false);
                UpdateControl(labelDescription10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(labelDescription11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelDescription12, SystemColors.Control, "Barkod12:", false);

                UpdateControl(labelBarcode3, SystemColors.Control, "Barkod3:", false);
                UpdateControl(labelBarcode4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(labelBarcode5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelBarcode6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelBarcode9, SystemColors.Control, "Barkod9:", false);
                UpdateControl(labelBarcode10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(labelBarcode11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelBarcode12, SystemColors.Control, "Barkod12:", false);
            }
            else if (c_count == 6)
            {
                UpdateControl(labelDescription1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(labelDescription2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(labelDescription3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(labelDescription7, SystemColors.Control, "Barkod4:", true);
                UpdateControl(labelDescription8, SystemColors.Control, "Barkod5:", true);
                UpdateControl(labelDescription9, SystemColors.Control, "Barkod6:", true);

                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "Barkod6:", true);

                UpdateControl(labelDescription4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(labelDescription5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelDescription6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelDescription10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(labelDescription11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelDescription12, SystemColors.Control, "Barkod12:", false);

                UpdateControl(labelBarcode4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(labelBarcode5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelBarcode6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelBarcode10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(labelBarcode11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelBarcode12, SystemColors.Control, "Barkod12:", false);


            }
            else if (c_count == 8)
            {
                UpdateControl(labelDescription1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(labelDescription2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(labelDescription3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(labelDescription4, SystemColors.Control, "Barkod4:", true);
                UpdateControl(labelDescription7, SystemColors.Control, "Barkod5:", true);
                UpdateControl(labelDescription8, SystemColors.Control, "Barkod6:", true);
                UpdateControl(labelDescription9, SystemColors.Control, "Barkod7:", true);
                UpdateControl(labelDescription10, SystemColors.Control, "Barkod8:", true);

                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(labelBarcode4, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "Barkod6:", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "Barkod7:", true);
                UpdateControl(labelBarcode10, SystemColors.ScrollBar, "Barkod8:", true);


                UpdateControl(labelDescription5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelDescription6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelDescription11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelDescription12, SystemColors.Control, "Barkod12:", false);

                
                UpdateControl(labelBarcode5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(labelBarcode6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(labelBarcode11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(labelBarcode12, SystemColors.Control, "Barkod12:", false);


            }
            else if (c_count == 12)
            {
                UpdateControl(labelDescription1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(labelDescription2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(labelDescription3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(labelDescription4, SystemColors.Control, "Barkod4:", true);
                UpdateControl(labelDescription5, SystemColors.Control, "Barkod5:", true);
                UpdateControl(labelDescription6, SystemColors.Control, "Barkod6:", true);
                UpdateControl(labelDescription7, SystemColors.Control, "Barkod7:", true);
                UpdateControl(labelDescription8, SystemColors.Control, "Barkod8:", true);
                UpdateControl(labelDescription9, SystemColors.Control, "Barkod9:", true);
                UpdateControl(labelDescription10, SystemColors.Control, "Barkod10:", true);
                UpdateControl(labelDescription11, SystemColors.Control, "Barkod11:", true);
                UpdateControl(labelDescription12, SystemColors.Control, "Barkod12:", true);

                UpdateControl(labelBarcode1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(labelBarcode2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(labelBarcode3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(labelBarcode4, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(labelBarcode5, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(labelBarcode6, SystemColors.ScrollBar, "Barkod6:", true);
                UpdateControl(labelBarcode7, SystemColors.ScrollBar, "Barkod7:", true);
                UpdateControl(labelBarcode8, SystemColors.ScrollBar, "Barkod8:", true);
                UpdateControl(labelBarcode9, SystemColors.ScrollBar, "Barkod9:", true);
                UpdateControl(labelBarcode10, SystemColors.ScrollBar, "Barkod10:", true);
                UpdateControl(labelBarcode11, SystemColors.ScrollBar, "Barkod11:", true);
                UpdateControl(labelBarcode12, SystemColors.ScrollBar, "Barkod12:", true);


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                UpdateControl(labelAktualnyProdukt, SystemColors.Window, ((RadioButton)sender).Text, true);
            }

            if (radioButtonLinky.Checked)
            {
                UpdateControl(labelNapisPodajLot, SystemColors.Window, "Podaj numer LOT baterii:", false);
                UpdateControl(textBoxLot, SystemColors.Window, "", false);
                try
                {
                    modbusClient.WriteSingleRegister(1002, 1);
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać do streownika info o trybie", "Błąd");
                }

                try
                {
                    client.Send("BLOAD,4\r");
                    client2.Send("BLOAD,4\r");
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać konfiguracji do skanera", "Błąd");
                }
                eq = 4;

                show_controls(4);

            }
            else if (radioButtonSmets.Checked)
            {
                UpdateControl(labelNapisPodajLot, SystemColors.Window, "Podaj numer LOT baterii:", false);
                UpdateControl(textBoxLot, SystemColors.Window, "", false);
                try
                {
                    modbusClient.WriteSingleRegister(1002, 1);
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać do streownika info o trybie", "Błąd");
                }
                try
                {
                    client.Send("BLOAD,3\r");
                    client2.Send("BLOAD,3\r");
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać konfiguracji do skanera", "Błąd");
                }
                eq = 3;

                show_controls(6);

            }
            else if (radioButtonCyble8.Checked)
            {
                UpdateControl(labelNapisPodajLot, SystemColors.Window, "Podaj numer LOT baterii:", true);
                UpdateControl(textBoxLot, SystemColors.Window, "", true);
                try
                {
                    modbusClient.WriteSingleRegister(1002, 2);
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać do streownika info o trybie", "Błąd");
                }
                try
                {
                    client.Send("BLOAD,2\r");
                    client2.Send("BLOAD,2\r");
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać konfiguracji do skanera", "Błąd");
                }
                eq = 2;
                show_controls(8);
            }
            else if (radioButtonCyble12.Checked)
            {
                UpdateControl(labelNapisPodajLot, SystemColors.Window, "Podaj numer LOT baterii:", true);
                UpdateControl(textBoxLot, SystemColors.Window, "", true);
                try
                {
                    modbusClient.WriteSingleRegister(1002, 2);
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać do streownika info o trybie", "Błąd");
                }

                try
                {
                    client.Send("BLOAD,1\r");
                    client2.Send("BLOAD,1\r");
                }
                catch
                {
                    MessageBox.Show("Nie udało się wysłać konfiguracji do skanera", "Błąd");
                }
                eq = 1;
                show_controls(12);
            }
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            //try
            //{
            //    modbusClient.WriteSingleRegister(1002, 0);
            //    modbusClient.WriteSingleRegister(1003, 0);
            //    modbusClient.WriteSingleRegister(1004, 1);
            //}
            //catch
            //{
            //    MessageBox.Show("Nie udało się wysłać do streownika info o trybie", "Błąd");
            //}

            try
            {
                client.Disconnect();
                client2.Disconnect();
                modbusClient.Disconnect();
            }
            catch
            {
                MessageBox.Show("Błąd w zamknięciu portów", "Błąd");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (modbusClient.Connected)
            {
                int[] readHoldingRegisters_boxresult = modbusClient.ReadHoldingRegisters(1001, 10);

                foreach (var sub in readHoldingRegisters_boxresult)
                {
                    MessageBox.Show(sub.ToString());
                }

                modbusClient.WriteSingleRegister(1002, 2);
                modbusClient.WriteSingleRegister(1003, 2);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                client2.Send("LON\r");
            }
            catch
            {
                MessageBox.Show("Błąd w wyzwalaniu skanera 101", "Błąd");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                client.Send("LON\r");
            }
            catch
            {
                MessageBox.Show("Błąd w wyzwalaniu skanera 100", "Błąd");
            }
        }

        private void label_barkod2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int modbus_tryb;
            if (eq == 3 || eq == 4)
                modbus_tryb = 1;
            else
                modbus_tryb = 2;

            try
            {
                modbusClient.WriteSingleRegister(1003, modbus_tryb);
                clear_barkodes();
            }
            catch
            {
                MessageBox.Show("Nie udało się wysłać do sterownika sterowania siłownika", "Błąd");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUtr.Text.ToUpper().Contains("UTR"))
                UpdateControl(labelCoverUTR, SystemColors.ScrollBar, "", false);
            else
                UpdateControl(labelCoverUTR, SystemColors.ScrollBar, "", true);
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            lotNumber = textBoxLot.Text.ToUpper();
        }
    }
}
