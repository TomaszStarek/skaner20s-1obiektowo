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

        public Form1()
        {
            InitializeComponent();
            _myWindow = this;

            radioButton_linky.Checked = false;
            radioButton_smets.Checked = false;
            radioButton_cyble8.Checked = false;
            radioButton_cyble12.Checked = false;


            //Initialize the event driven client
            client = new EventDrivenTCPClient(IPAddress.Parse("192.168.100.101"), int.Parse("9004"));
            //Initialize the events
            var scanner1 = new ScannerTcpConnection();
            client.DataReceived += new EventDrivenTCPClient.delDataReceived(scanner1.client_DataReceived);
            client.ConnectionStatusChanged += new EventDrivenTCPClient.delConnectionStatusChanged(scanner1.client_ConnectionStatusChanged);
            UpdateControl(label_status101, SystemColors.Window, scanner1.connection_status, true);
            UpdateControl(label_b101, SystemColors.Window, scanner1.strData1, true);
            client.Connect();



            //Initialize the event driven client
            client2 = new EventDrivenTCPClient(IPAddress.Parse("192.168.100.100"), int.Parse("9004"));
            //Initialize the events
            var scanner2 = new ScannerTcpConnection();
            client2.DataReceived += new EventDrivenTCPClient.delDataReceived(scanner2.client_DataReceived2);
            client2.ConnectionStatusChanged += new EventDrivenTCPClient.delConnectionStatusChanged(scanner2.client_ConnectionStatusChanged2);
            UpdateControl(label_status101, SystemColors.Window, scanner2.connection_status2, true);
            UpdateControl(label_b100, SystemColors.Window, scanner2.strData2, true);
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
            //          port.Write("LON\r");
        }


        public void clear_barkodes()
        {
            //  Thread.Sleep(1000);

            Thread.Sleep(2500);

            this.Invoke(new MethodInvoker(delegate {
                // Executes the following code on the GUI thread.
                this.BackColor = SystemColors.ScrollBar;
            }));

            if (eq == 4)
            {
                UpdateControl(label_barkod1, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 3)
            {
                UpdateControl(label_barkod1, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 2)
            {
                UpdateControl(label_barkod1, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod4, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod10, SystemColors.ScrollBar, "", true);
            }
            else if (eq == 1)
            {
                UpdateControl(label_barkod1, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod4, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod5, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod6, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod10, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod11, SystemColors.ScrollBar, "", true);
                UpdateControl(label_barkod12, SystemColors.ScrollBar, "", true);
            }



            }



        public void show_barkodes(string barkode, int n_barkode)
        {

            lock (x)
            {
               // Thread.Sleep(100);

                if (eq == 4)
                {
                    switch (n_barkode)
                    {
                        case 1:
                            UpdateControl(label_barkod1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(label_barkod2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(label_barkod7, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(label_barkod8, Color.PaleGreen, barkode, true);
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
                            UpdateControl(label_barkod1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(label_barkod2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(label_barkod3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(label_barkod7, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(label_barkod8, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(label_barkod9, Color.PaleGreen, barkode, true);
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
                            UpdateControl(label_barkod1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(label_barkod2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(label_barkod3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(label_barkod4, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(label_barkod7, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(label_barkod8, Color.PaleGreen, barkode, true);
                            break;
                        case 7:
                            UpdateControl(label_barkod9, Color.PaleGreen, barkode, true);
                            break;
                        case 8:
                            UpdateControl(label_barkod10, Color.PaleGreen, barkode, true);
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
                            UpdateControl(label_barkod1, Color.PaleGreen, barkode, true);
                            break;

                        case 2:
                            UpdateControl(label_barkod2, Color.PaleGreen, barkode, true);
                            break;
                        case 3:
                            UpdateControl(label_barkod3, Color.PaleGreen, barkode, true);
                            break;
                        case 4:
                            UpdateControl(label_barkod4, Color.PaleGreen, barkode, true);
                            break;
                        case 5:
                            UpdateControl(label_barkod5, Color.PaleGreen, barkode, true);
                            break;
                        case 6:
                            UpdateControl(label_barkod6, Color.PaleGreen, barkode, true);
                            break;
                        case 7:
                            UpdateControl(label_barkod7, Color.PaleGreen, barkode, true);
                            break;
                        case 8:
                            UpdateControl(label_barkod8, Color.PaleGreen, barkode, true);
                            break;
                        case 9:
                            UpdateControl(label_barkod9, Color.PaleGreen, barkode, true);
                            break;
                        case 10:
                            UpdateControl(label_barkod10, Color.PaleGreen, barkode, true);
                            break;
                        case 11:
                            UpdateControl(label_barkod11, Color.PaleGreen, barkode, true);
                            break;
                        case 12:
                            UpdateControl(label_barkod12, Color.PaleGreen, barkode, true);
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
                UpdateControl(label_ozn1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(label_ozn2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(label_ozn7, SystemColors.Control, "Barkod3:", true);
                UpdateControl(label_ozn8, SystemColors.Control, "Barkod4:", true);

                UpdateControl(label_barkod1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "Barkod4:", true);

                UpdateControl(label_ozn3, SystemColors.Control, "Barkod3:", false);
                UpdateControl(label_ozn4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(label_ozn5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_ozn6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_ozn9, SystemColors.Control, "Barkod9:", false);
                UpdateControl(label_ozn10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(label_ozn11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_ozn12, SystemColors.Control, "Barkod12:", false);

                UpdateControl(label_barkod3, SystemColors.Control, "Barkod3:", false);
                UpdateControl(label_barkod4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(label_barkod5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_barkod6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_barkod9, SystemColors.Control, "Barkod9:", false);
                UpdateControl(label_barkod10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(label_barkod11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_barkod12, SystemColors.Control, "Barkod12:", false);
            }
            else if (c_count == 6)
            {
                UpdateControl(label_ozn1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(label_ozn2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(label_ozn3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(label_ozn7, SystemColors.Control, "Barkod4:", true);
                UpdateControl(label_ozn8, SystemColors.Control, "Barkod5:", true);
                UpdateControl(label_ozn9, SystemColors.Control, "Barkod6:", true);

                UpdateControl(label_barkod1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "Barkod6:", true);

                UpdateControl(label_ozn4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(label_ozn5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_ozn6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_ozn10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(label_ozn11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_ozn12, SystemColors.Control, "Barkod12:", false);

                UpdateControl(label_barkod4, SystemColors.Control, "Barkod4:", false);
                UpdateControl(label_barkod5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_barkod6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_barkod10, SystemColors.Control, "Barkod10:", false);
                UpdateControl(label_barkod11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_barkod12, SystemColors.Control, "Barkod12:", false);


            }
            else if (c_count == 8)
            {
                UpdateControl(label_ozn1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(label_ozn2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(label_ozn3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(label_ozn4, SystemColors.Control, "Barkod4:", true);
                UpdateControl(label_ozn7, SystemColors.Control, "Barkod5:", true);
                UpdateControl(label_ozn8, SystemColors.Control, "Barkod6:", true);
                UpdateControl(label_ozn9, SystemColors.Control, "Barkod7:", true);
                UpdateControl(label_ozn10, SystemColors.Control, "Barkod8:", true);

                UpdateControl(label_barkod1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(label_barkod4, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "Barkod6:", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "Barkod7:", true);
                UpdateControl(label_barkod10, SystemColors.ScrollBar, "Barkod8:", true);


                UpdateControl(label_ozn5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_ozn6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_ozn11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_ozn12, SystemColors.Control, "Barkod12:", false);

                
                UpdateControl(label_barkod5, SystemColors.Control, "Barkod5:", false);
                UpdateControl(label_barkod6, SystemColors.Control, "Barkod6:", false);
                UpdateControl(label_barkod11, SystemColors.Control, "Barkod11:", false);
                UpdateControl(label_barkod12, SystemColors.Control, "Barkod12:", false);


            }
            else if (c_count == 12)
            {
                UpdateControl(label_ozn1, SystemColors.Control, "Barkod1:", true);
                UpdateControl(label_ozn2, SystemColors.Control, "Barkod2:", true);
                UpdateControl(label_ozn3, SystemColors.Control, "Barkod3:", true);
                UpdateControl(label_ozn4, SystemColors.Control, "Barkod4:", true);
                UpdateControl(label_ozn5, SystemColors.Control, "Barkod5:", true);
                UpdateControl(label_ozn6, SystemColors.Control, "Barkod6:", true);
                UpdateControl(label_ozn7, SystemColors.Control, "Barkod7:", true);
                UpdateControl(label_ozn8, SystemColors.Control, "Barkod8:", true);
                UpdateControl(label_ozn9, SystemColors.Control, "Barkod9:", true);
                UpdateControl(label_ozn10, SystemColors.Control, "Barkod10:", true);
                UpdateControl(label_ozn11, SystemColors.Control, "Barkod11:", true);
                UpdateControl(label_ozn12, SystemColors.Control, "Barkod12:", true);

                UpdateControl(label_barkod1, SystemColors.ScrollBar, "Barkod1:", true);
                UpdateControl(label_barkod2, SystemColors.ScrollBar, "Barkod2:", true);
                UpdateControl(label_barkod3, SystemColors.ScrollBar, "Barkod3:", true);
                UpdateControl(label_barkod4, SystemColors.ScrollBar, "Barkod4:", true);
                UpdateControl(label_barkod5, SystemColors.ScrollBar, "Barkod5:", true);
                UpdateControl(label_barkod6, SystemColors.ScrollBar, "Barkod6:", true);
                UpdateControl(label_barkod7, SystemColors.ScrollBar, "Barkod7:", true);
                UpdateControl(label_barkod8, SystemColors.ScrollBar, "Barkod8:", true);
                UpdateControl(label_barkod9, SystemColors.ScrollBar, "Barkod9:", true);
                UpdateControl(label_barkod10, SystemColors.ScrollBar, "Barkod10:", true);
                UpdateControl(label_barkod11, SystemColors.ScrollBar, "Barkod11:", true);
                UpdateControl(label_barkod12, SystemColors.ScrollBar, "Barkod12:", true);


            }


        }




        public static int eq;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (((RadioButton)sender).Checked == true)
            {
                UpdateControl(label_aktualny_produkt, SystemColors.Window, ((RadioButton)sender).Text, true);
            }

            if (radioButton_linky.Checked)
            {
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
            else if (radioButton_smets.Checked)
            {
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

            else if (radioButton_cyble8.Checked)
            {
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
            else if (radioButton_cyble12.Checked)
            {
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
            if (textBox1.Text.ToUpper().Contains("UTR"))
                UpdateControl(label_zaslonaUTR, SystemColors.ScrollBar, "", false);
            else
                UpdateControl(label_zaslonaUTR, SystemColors.ScrollBar, "", true);
        }
    }
}
