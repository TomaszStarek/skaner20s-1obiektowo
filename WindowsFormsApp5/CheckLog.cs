using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public class CheckLog
    {

        /// <summary>
        /// ////////////MES
        /// </summary>
        const int M_NIENARODZONY = 1;
        const int M_BRAK_KROKU = 2;
        const int M_FAIL = 3;

        const int M_BRAK_POLACZENIA_Z_MES = 4;
        const int M_BRAK_KROKU_FVTRF = 5;
        const int M_BRAK_KROKU_ICT = 6;
        const int M_BRAK_KROKU_FVTPRG = 7;

        const int M_FAIL_FVTRF = 8;
        const int M_FAIL_ICT = 9;
        const int M_FAIL_FVTPRG = 10;


        private int SendRequestToMesAndCheckSteps(string SerialTxt)
        {
            using (MESwebservice.BoardsSoapClient wsMES = new MESwebservice.BoardsSoapClient("BoardsSoap"))
            {
                DataSet Result;
                try
                {
                    Result = wsMES.GetBoardHistoryDS(@"itron", SerialTxt);
                }
                catch
                {
                    return M_BRAK_POLACZENIA_Z_MES;
                }

                var Test = Result.Tables[0].TableName;
                if (Test != "BoardHistory") return M_NIENARODZONY; //numer produktu nie widnieje w systemie MES



                var data2 = (from row in Result.Tables["BoardHistory"].AsEnumerable()
                             where row.Field<string>("Test_Process").ToUpper() == "ICT / ICT".ToUpper() || row.Field<string>("Test_Process").ToUpper() == "ICT / ICT_IZOLACJA".ToUpper()
                             select new
                             {
                                 TestProcess = row.Field<string>("Test_Process"),
                                 TestType = row.Field<string>("TestType"),
                                 TestStatus = row.Field<string>("TestStatus"),
                                 StartDateTime = row.Field<DateTime>("StartDateTime"),
                                 StopDateTime = row.Field<DateTime>("StopDateTime"),
                             }).FirstOrDefault();


                if (data2 != null)
                {
                    //sprawdzamy PASS w poprzednim kroku
                    if ("PASS" == data2.TestStatus.ToUpper()) ; //wszystko jest OK
                    else return M_FAIL_ICT;
                }
                else return M_BRAK_KROKU_ICT; //brak poprzedniego kroku



                var data3 = (from row in Result.Tables["BoardHistory"].AsEnumerable()
                             where row.Field<string>("Test_Process").ToUpper() == "FVT / FVT_PRG".ToUpper() || row.Field<string>("Test_Process").ToUpper() == "FVT / FVT_PRG_IZOLACJA".ToUpper()
                             select new
                             {
                                 TestProcess = row.Field<string>("Test_Process"),
                                 TestType = row.Field<string>("TestType"),
                                 TestStatus = row.Field<string>("TestStatus"),
                                 StartDateTime = row.Field<DateTime>("StartDateTime"),
                                 StopDateTime = row.Field<DateTime>("StopDateTime"),
                             }).FirstOrDefault();


                if (data3 != null)
                {
                    //sprawdzamy PASS w poprzednim kroku
                    if ("PASS" == data3.TestStatus.ToUpper()) ; //wszystko jest OK
                    else return M_FAIL_FVTPRG;
                }
                else return M_BRAK_KROKU_FVTPRG; //brak poprzedniego kroku





                var data = (from row in Result.Tables["BoardHistory"].AsEnumerable()
                            where row.Field<string>("Test_Process").ToUpper() == "FVT / FVT_RF".ToUpper() || row.Field<string>("Test_Process").ToUpper() == "FVT / FVT_RF_IZOLACJA".ToUpper()
                            select new
                            {
                                TestProcess = row.Field<string>("Test_Process"),
                                TestType = row.Field<string>("TestType"),
                                TestStatus = row.Field<string>("TestStatus"),
                                StartDateTime = row.Field<DateTime>("StartDateTime"),
                                StopDateTime = row.Field<DateTime>("StopDateTime"),
                            }).FirstOrDefault();


                if (data != null)
                {
                    //sprawdzamy PASS w poprzednim kroku
                    if ("PASS" == data.TestStatus.ToUpper()) return 0; //wszystko jest OK
                    else return M_FAIL_FVTRF;
                }
                else return M_BRAK_KROKU_FVTRF; //brak poprzedniego kroku



            }
        }
        public int CheckAndDisplayIsMovementOk(string sn)
        {
            int Result;

            Result = SendRequestToMesAndCheckSteps(sn); //przykladowy numer seryjny 9100000668
            switch (Result)
            {
                case M_BRAK_POLACZENIA_Z_MES:
                    MessageBox.Show("Brak połączenia z MES.", "Info", MessageBoxButtons.OK);
                    //            UpdateControl(textBox1, SystemColors.Window, string.Empty, true);
                    //label8.Text = "Brak połączenia z MES.";
                    break;

                case M_NIENARODZONY:
                    MessageBox.Show("Numer nienarodzony w MES.", "Info", MessageBoxButtons.OK);
                    //            UpdateControl(textBox1, SystemColors.Window, string.Empty, true);
                    //label8.Text = "Numer nienarodzony w MES.";
                    break;

                case M_BRAK_KROKU:
                    MessageBox.Show("Brak poprzedniego kroku.", "Info", MessageBoxButtons.OK);
                    //           UpdateControl(textBox1, SystemColors.Window, string.Empty, true);
                    // label8.Text = "Brak poprzedniego kroku.";
                    break;

                case M_FAIL:
                    MessageBox.Show("Poprzedni krok = FAIL.", "Info", MessageBoxButtons.OK);
                    //           UpdateControl(textBox1, SystemColors.Window, string.Empty, true);
                    //  label8.Text = "Poprzedni krok = FAIL.";
                    break;

                default:
                    //     MessageBox.Show("Wszystko jest OK", "Info", MessageBoxButtons.OK);                   
                    return 1;
            }
            return 0;
        }
    }
}
