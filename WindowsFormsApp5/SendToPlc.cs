using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    class SendToPlc
    {
        public static void SendToPlcActuatorState()
        {
            int modbus_tryb;
            if (Form1.eq == 3 || Form1.eq == 4)
                modbus_tryb = 1;
            else
                modbus_tryb = 2;

            try
            {
                Form1.modbusClient.WriteSingleRegister(1003, modbus_tryb);
                //   clear_barkodes();

            }
            catch
            {
                MessageBox.Show("Nie udało się wysłać do sterownika sterowania siłownika", "Błąd");
            }
        }
    }
}
