using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using TestTools;

namespace TG2482_CQA
{
    public partial class ResetToFactory : Form
    {
        public ResetToFactory()
        {
            InitializeComponent();
            Login();
        }

        bool bolStopTime = false;
        private LoginStep goPage = LoginStep.LoginPage;
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public delegate void GetDataHandler();
        PingCheck pingCheck = new PingCheck();
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new GetDataHandler(herfCountSwitch));
            if (!bolStopTime)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        private enum LoginStep
        {
            LoginPage,//Wireless 界面
            UtilitiesPage,//Untitle界面
            FactoryDefaultPage,//FactoryDefault界面
            ClickResetPage,
            SucessPage//成功界面
        }

        private void herfCountSwitch()
        {
            switch (goPage)
            {
                case LoginStep.LoginPage:

                    HtmlElement UserName = webBrowser1.Document.GetElementById("UserName");//2.4 G SSID

                    HtmlElement Password = webBrowser1.Document.GetElementById("Password");

                    if (UserName == null && Password == null)
                    {
                        return;
                    }
                    else
                    {
                        UserName.SetAttribute("value", "admin");
                        Password.SetAttribute("value", "password");

                    }

                    HtmlElementCollection htmlele = webBrowser1.Document.GetElementsByTagName("input");
                    foreach (HtmlElement item in htmlele)
                    {
                        //<input value="Apply" class="submitBtn" onclick="{ _onclick_1(arguments[0]);}" type="button">
                        if (item.OuterHtml == "<INPUT onclick=\"{ _onclick_1(arguments[0]);}\" class=submitBtn type=button value=Apply>")
                        {
                            item.InvokeMember("click");
                            goPage = LoginStep.UtilitiesPage;
                            break;
                        }
                    }
                    break;

                case LoginStep.UtilitiesPage:
                    HtmlElementCollection untitleRest = webBrowser1.Document.GetElementsByTagName("a");
                    foreach (HtmlElement item in untitleRest)
                    {
                        if (item.OuterHtml.Contains("Utilities"))
                        {
                            item.InvokeMember("click");
                            goPage = LoginStep.FactoryDefaultPage;
                            break;
                        }
                    }
                    break;

                case LoginStep.FactoryDefaultPage:
                    HtmlElementCollection factoryRest = webBrowser1.Document.GetElementsByTagName("a");
                    foreach (HtmlElement item in factoryRest)
                    {
                        if (item.OuterHtml.Contains("Factory Defaults"))
                        {
                            item.InvokeMember("click");
                            goPage = LoginStep.ClickResetPage;
                            break;
                        }
                    }
                    break;

                case LoginStep.ClickResetPage:
                    HtmlElementCollection FactoryClick = webBrowser1.Document.GetElementsByTagName("input");
                    foreach (HtmlElement item in FactoryClick)
                    {                      
                        if (item.OuterHtml == "<INPUT onclick=\"{ _onclick_1(arguments[0]);}\" class=submitBtn type=button value=\"Factory Defaults\">")
                        {
                            item.InvokeMember("click");
                            win32API.keybd_event((byte)Keys.Enter, 0, 0, 0);
                            win32API.keybd_event((byte)Keys.Enter, 0, 0x2, 0);
                            //sDelay.Delay(3000);
                            //while(true)
                            //{
                            //    if (!pingCheck.NetworkPing(200000, "192.168.100.1"))
                            //    {
                                    goPage = LoginStep.SucessPage;
                                    break;
                                //}
                            //}
                            ////timer.Stop();
                            //StationInfo.restWebFactory = true;                           
                            ////this.Close();
                        }   
                    }
                    break;
                ////this.Close();

                case LoginStep.SucessPage:
                     HtmlElementCollection factoryDefault = webBrowser1.Document.GetElementsByTagName("a");
                     foreach (HtmlElement item in factoryDefault)
                     {
                         if (!item.OuterHtml.Contains("Wireless"))
                         {
                             return;
                         }
                         else
                         {
                             timer.Stop();
                             StationInfo.restWebFactory = true;
                             this.Close();
                             break;
                         }
                     }
                    break;
            }
        }

        public void Login()
        {
            string url = "http://192.168.100.1/cgi-bin/status_cgi";
            // string url = "http://192.168.100.1:8080";
            webBrowser1.Navigate(url);
            timer.AutoReset = true;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
        }

        public bool delay(int delayTime)
        {
            DateTime now = DateTime.Now;
            int s;
            do
            {
                TimeSpan spand = DateTime.Now - now;
                s = spand.Seconds;
                Application.DoEvents();
            }
            while (s < delayTime);
            return true;
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElementCollection htmlRest = webBrowser1.Document.GetElementsByTagName("a");
            foreach (HtmlElement item in htmlRest)
            {
                //if (item.OuterHtml == "<input value=\"Finish\" class=\"btn\" onclick=\"clickSave()\" type=\"submit\">")
                //<a style="width: 16.66%; font-size: 90%;" href="http://192.168.100.1:8080">Wireless</a>
                if (item.OuterHtml.Contains("Wireless"))
                {
                    item.InvokeMember("click");
                    timer.Start();
                    // goPage = LoginStep.RestButtonPage;
                    break;
                }
            }
        }

    }
}