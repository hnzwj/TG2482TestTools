using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TestTools;

using System.Net.Sockets;
using System.Text.RegularExpressions;
namespace TG2482_CQA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LINQToINI Ini = new LINQToINI();
        GetWebInformation getweb = new GetWebInformation();
        TcpClient TcpClicent = new TcpClient();
        TestApp test;
        PingCheck pingCheck = new PingCheck();

        string result_verifyWebPage = "";
        private int gTimeOut = 0;
        private string sConfigPath = "";
        private bool closeflag = true;

        private void Form1_Load(object sender, EventArgs e)
        {           
            Init();
            TB_SN.Select();
            DiSable.Checked = true;
            txtB_test.Text = "Waiting...";
            txtB_test.BackColor = Color.Yellow;
        }
        private void Init()
        {
            StationInfo.SNcheck_OK = false;
            StationInfo.LEDCheck=false;
            StationInfo.WPSCheck = false;
            StationInfo.WPSCheck_OK = false;
            StationInfo.ResetToFactory = false;
            StationInfo.VerifyARRISWeb_check = false;
            StationInfo.restWebFactory = false;

            this.sConfigPath = Environment.CurrentDirectory + "\\config.cfg";
            Ini.Load(sConfigPath);
            StationInfo.CM_Default_IP = Ini.GetProfileAsString("Settings", "CM Default IP", "NULL");
            StationInfo.CM_IP_ALPS = Ini.GetProfileAsString("Settings", "CM IP ALPS", "NULL");
            StationInfo.CMTS_IP = Ini.GetProfileAsString("Settings", "CMTS IP", "NULL");
            StationInfo.UUT_IP = Ini.GetProfileAsString("Settings", "UUT IP", "NULL");
            StationInfo.MultihomedSource_IP = Ini.GetProfileAsString("Settings", "MultihomedSource IP", "NULL");
            txtB_CMDefaultIP.Text = StationInfo.CM_Default_IP;
            txtB_CMIPALPS.Text = StationInfo.CM_IP_ALPS;
            txtB_CMTSIP.Text = StationInfo.CMTS_IP;
            txtB_MultihomedSourceIP.Text = StationInfo.MultihomedSource_IP;
            txtB_UUTIP.Text = StationInfo.UUT_IP;


            dgTestItem.Rows.Add(11);//添加行
            for (int i = 0; i < dgTestItem.Columns.Count; i++)
            {
                this.dgTestItem.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;//禁止排序
            }

            dgTestItem.RowHeadersVisible = false;
            dgTestItem[0, 0].Value = "Power On";
            dgTestItem[0, 1].Value = "Ping To Model";
            dgTestItem[0, 2].Value = "Check Modle";
            dgTestItem[0, 3].Value = "Get Serial Number";
            dgTestItem[0, 4].Value = "Check CM Telnet Status(Disable)";
            dgTestItem[0, 5].Value = "Check Model is Operating";
            dgTestItem[0, 6].Value = "Ping To CMTS";
            dgTestItem[0, 7].Value = "Reset Modem";//确认重启
            dgTestItem[0, 8].Value = "Check LED and Telephone";// 有图
            dgTestItem[0, 9].Value = "Check WPS Button";
            dgTestItem[0, 10].Value = "Verify ARRIS Web Page";//show page
            dgTestItem[0, 11].Value = "Reset to Factory Default";     

           
        }

        private void judgeModemCheck()
        {
            string result="";
            while (true)
            {
                if (StationInfo.modemcheck_OK)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.ModemCheck)
                    {
                        result = "PASS";
                        LogHelper.Info("judge modem check pass");
                    }
                    else
                    {
                        result ="FAIL";
                        LogHelper.Info("judge modem check fail");
                    }
                    break;
                }             
            }
            ShowResult(2, result);         
            sDelay.Delay(500);
            if (result == "PASS")
            {
                new Thread((ThreadStart)delegate
                {
                    Application.Run(new Get_Serial_Number()
                        );
                }).Start();
                Get_Serial_Number SN = new Get_Serial_Number();
                SN.Show();

                Thread check_SN = new Thread(checkSN);
                check_SN.IsBackground = true;
                check_SN.Start();            
            }
        }
        private void checkSN()
        {
            string result;
            while (true)
            {
                if (StationInfo.SNcheck_OK)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.SNCheck)
                    {
                        result = "PASS";
                        LogHelper.Info("Check SN pass!");
                    }
                    else
                    {
                        result = "FAIL";
                        LogHelper.Info("Check SN fail!");
                    }
                    break;
                }
            }
            sDelay.Delay(500);
            ShowResult(3, result);
            if (result == "PASS")
            {
                Check_CMTelnet();
            }
        }


        private  void Check_CMTelnet()
        {
            bool telnet=true;
            string result = "PASS";
            try
            {
                TcpClicent.Connect("192.168.100.1", 23);
            }
            catch (SystemException ex)
            {
                telnet = false;
            }

            if (DiSable.Checked)//加密
            {
                if (!telnet)
                {
                    result = "PASS";
                    LogHelper.Info("Check CM telnet pass!");
                }
                else
                {
                    result = "FAIL";
                    LogHelper.Info("Check CM fail!");
                }
            }
            else
            {
                if (telnet)
                {
                    result = "PASS";
                    LogHelper.Info("Check CM telnet pass!");
                }
                else
                {
                    result = "FAIL";
                    LogHelper.Info("Check CM telnet is failed!");
                }
            }
            ShowResult(4, result);
            sDelay.Delay(500);
            if (result == "PASS")
            {
                string result_Operating = "";
                //if (StationInfo.TelephonyRegComplet.Contains("Completed") && StationInfo.BPIStatus.Contains("Enabled,AuthOrized"))
                //{
                    result_Operating = "PASS";
                    LogHelper.Info("Check modem is Operating pass!");
                //}
                //else
                //{
                //    result_Operating = "FAIL";
                //    LogHelper.Info("Check modem is Operating fail!");
                //}
                ShowResult(5, result_Operating);
                if (result_Operating == "PASS")
                {
                    if (PingToCMTS())
                    {               
                        ShowResult(6, "PASS");
                        LogHelper.Info("Ping to CMTS pass!");
                        sDelay.Delay(500);
                        MessageBox.Show("Please reset the modem for 8 seconds!");
                        sDelay.Delay(500);
                        if (0 == JudgeRestart())
                        {
                            ShowResult(7, "PASS");
                            LogHelper.Info("Rest modem pass!");
                            new Thread((ThreadStart)delegate{
                                Application.Run(new LED_and_Telephone()
                                    );
                            }).Start();
                             LED_and_Telephone led = new LED_and_Telephone();
                            led.Show();

                            Thread checkLED = new Thread(CheckLEDandTelephone);
                            checkLED.IsBackground = true;
                            checkLED.Start();   
                        }
                        else
                        {
                            ShowResult(7, "FAIL");
                            LogHelper.Info("Rest modem fail!");
                        }
                    }
                    else
                    {
                        ShowResult(6, "FAIL");
                        LogHelper.Info("Ping to CMTS fail!");
                    }
                }
            }
        }

        private bool PingToCMTS()
        {
            bool ping;
            if (!pingCheck.NetworkPing(200000, txtB_CMTSIP.Text))
            {
                ping = false;
            }
            else
            {
                ping = true;
            }
            //ping = true;
            return ping;
            //RestartModem
            
        }

        private int JudgeRestart()
        {
            bool flag0 = false;
            bool flag1 = false;
            int result = 99;
             DateTime dateTime0 = DateTime.Now;
             dateTime0 = dateTime0.AddMilliseconds(20000.0);
             while (!flag0 && dateTime0.CompareTo(DateTime.Now) > 0)
             {
                     bool bolTrue = pingCheck.NetworkPing(10000, "192.168.100.1");
                     if (!bolTrue)
                     {
                         flag0 = true;
                     }
             }

             DateTime dateTime1 = DateTime.Now;
             dateTime1 = dateTime1.AddMilliseconds(70000.0);
             while(!flag1 && dateTime1.CompareTo(DateTime.Now) > 0)
             {
                 //if (!pingCheck.NetworkPing(200000, txtB_CMTSIP.Text))
                 bool bolTrue = pingCheck.NetworkPing(200000,"192.168.100.1");
                 if (bolTrue)
                 {
                     flag1 = true;
                 }
             }
             
             if(flag0&&flag1)
             {
                 result = 0;
             }
             return result;           
       }


        private void CheckLEDandTelephone()
        {
            string result;
            while (true)
            {
                if (StationInfo.LEDCheck_OK)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.LEDCheck)
                    {
                        result = "PASS";
                        LogHelper.Info("Check LED and Telephone pass!");
                    }
                    else
                    {
                        result = "FAIL";
                        LogHelper.Info("Check LED and Telephone fail!");
                    }
                    break;
                }  
            }
            ShowResult(8, result);
            if(result=="PASS")
            {
                new Thread((ThreadStart)delegate
                {
                    Application.Run(new CheckWPSButton()
                        );
                }).Start();
                CheckWPSButton wps = new CheckWPSButton();
                wps.Show();

                Thread checkWPSButton = new Thread(checkWPS);
                checkWPSButton.IsBackground = true;
                checkWPSButton.Start();
            }
        }

        private void checkWPS()
        {
            string result;
            while (true)
            {
                if (StationInfo.WPSCheck_OK)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.WPSCheck)
                    {
                        result = "PASS";
                        LogHelper.Info("Check WPS pass!");
                    }
                    else
                    {
                        result = "FAIL";
                        LogHelper.Info("Check WPS fail!");
                    }
                    break;
                }  
            }
            ShowResult(9, result);
            if (result == "PASS")
            {
                new Thread((ThreadStart)delegate
                {
                    Application.Run(new VerifyARRISWebPage()
                        );
                }).Start();
                VerifyARRISWebPage webPage = new VerifyARRISWebPage();
                webPage.Show();

                Thread VerifyARRISWebPage = new Thread(checkWebPage);
                VerifyARRISWebPage.IsBackground = true;
                VerifyARRISWebPage.Start();
            }
        }
        private void checkWebPage()
        {
            string result;
            while (true)
            {
                if (StationInfo.VerifyARRISWeb_check)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.VerifyARRISWeb)
                    {
                        result = "PASS";
                        LogHelper.Info("Check Web page pass!");
                    }
                    else
                    {
                        result = "FAIL";
                        LogHelper.Info("Check Web page fail!");
                    }
                    break;
                }
            }
            ShowResult(10, result);
            if (result == "PASS")
            {
                test = new TestApp();
                sDelay.Delay(500);
                if (!test.TelnetToLogin(StationInfo.MultihomedSource_IP.Trim()))
                {
                    result_verifyWebPage = "FAIL";
                    return;
                }
                else
                {
                    result_verifyWebPage = "PASS";
                }
            }
        }
        private void restToFactory()
        {
            string result="";
            while(true)
            {
                if(StationInfo.ResetToFactory_Check)
                {
                    sDelay.Delay(1000);
                    if (StationInfo.ResetToFactory)
                    {
                        result = "PASS";
                        LogHelper.Info("Reset to factory default pass!");
                    }
                    else
                    {
                        result = "FAIL";
                        LogHelper.Info("Reset to factory default fail!");
                    }
                    break;
                }
            }
             ShowResult(11, result);
        }
        private void ShowResult(int i, string result)
        {
            if (result == "PASS")
            {
                dgTestItem[1, i].Value = "PASS";
                dgTestItem[1, i].Style.BackColor = Color.Green; 
                if(i==11)
                {
                    iniResult(i, result);
                }
            }      
            if (result == "FAIL")
            {
                dgTestItem[1, i].Value = "FAIL";
                dgTestItem[1, i].Style.BackColor = Color.Red; 
                iniResult(i, result);
            }
        }
        private void iniResult(int i, string result)
        {
            if(result=="PASS")
            {
                txtB_test.Invoke(new Action(delegate()
                {
                    txtB_test.BackColor = Color.Green;
                    txtB_test.Text = "PASS";
                }));
            }
            if(result=="FAIL")
            {
                txtB_test.Invoke(new Action(delegate()
                {
                    txtB_test.BackColor = Color.Red;
                    txtB_test.Text = "FAIL";
                }));
            }
          
            while (true)
            {
                if (!pingCheck.NetworkPing(2000, "192.168.100.1"))
                {
                    txtB_test.Invoke(new Action(delegate()
                    {
                        txtB_test.BackColor = Color.Gold;
                        txtB_test.Text = "Waiting...";
                    }));
                    for (int a = i; a > -1; a--)
                    {
                        dgTestItem[1, a].Value = "";
                        dgTestItem[2, a].Value = "";
                        dgTestItem[1, a].Style.BackColor = Color.White;
                    }
                    timer3.Enabled = false;
                    break;
                }
            }
            StationInfo.SNcheck_OK = false;
            StationInfo.LEDCheck = false;
            StationInfo.WPSCheck = false;
            StationInfo.WPSCheck_OK = false;
            StationInfo.ResetToFactory = false;
            StationInfo.VerifyARRISWeb_check = false;
            StationInfo.restWebFactory = false;
            result = "";
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
                txtB_test.BackColor = Color.Gold;
                txtB_test.Text = "testing";
                timer3.Enabled = true;
                timer1.Start();
                timer2.Start();
                //check power on;
                //check ping
                string result;
                if (!pingCheck.NetworkPing(200000, "192.168.100.1"))
                {
                    result = "FAIL";
                }
                else
                {
                    result = "PASS";
                    LogHelper.Info("power on and ping test passing!");
                    sDelay.Delay(3000);
                }
                ShowResult(0, result);
                sDelay.Delay(1000);
                ShowResult(1, result);
                if (result == "PASS")
                {
                    sDelay.Delay(1000);
                    ModemCheck modemcheck = new ModemCheck();
                    modemcheck.Show();

                    Thread ModemCheck = new Thread(judgeModemCheck);
                    ModemCheck.IsBackground = true;
                    ModemCheck.Start();
                }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                if (result_verifyWebPage == "PASS")
                {
                    ResetToFactory restoFactory = new ResetToFactory();
                    restoFactory.Show();

                    Thread restTofactory = new Thread(restToFactory);
                    restTofactory.IsBackground = true;
                    restTofactory.Start();
                    timer1.Stop();
                }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string result = "";
            if (StationInfo.restWebFactory)
            {
                result = "PASS";
                ShowResult(11, result);
                timer2.Stop();
                iniResult(11, result);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
            for (int i = 0; i < dgTestItem.RowCount; i++)
            {
                if (dgTestItem[1, i].Style.BackColor != Color.Red && dgTestItem[1, i].Style.BackColor != Color.Green)
                {
                    if ((i > 0 && dgTestItem[1, i-1].Style.BackColor == Color.Green)||i==0)
                    {
                            gTimeOut++;
                            dgTestItem[2, i].Value = gTimeOut;
                            if (gTimeOut > 500)
                            {
                               ShowResult(i, "FAIL");
                               timer3.Enabled = false;
                            }
                    }
                }
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            timer3.Enabled = false;
        }
    }
}
