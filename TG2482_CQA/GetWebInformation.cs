using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TG2482_CQA
{
    class GetWebInformation
    {
        HttpWebRequest httpReq;
        HttpWebResponse httpResp;
        string strBuff = "";
        char[] cbuffer = new char[256];
        int byteRead = 0;
        string path0 = @"C:\FWlog.txt";
        string path1 = @"C:\CMlog.txt";
        public void GetHWandFWversions(out string System, out string HW_REV, out string VENDOR, out string BOOTR, out string SW_REV, out string MODEL, out string FWName, out string FWBuildTime, out string FWRevision,out string SN)
        {
            Uri httpURL = new Uri("http://192.168.100.1/cgi-bin/vers_cgi");//分位信息
            httpReq = (HttpWebRequest)WebRequest.Create(httpURL);
            httpResp = (HttpWebResponse)httpReq.GetResponse();
            Stream respStream = httpResp.GetResponseStream();
            StreamReader respStreamReader = new StreamReader(respStream, Encoding.UTF8);
            byteRead = respStreamReader.Read(cbuffer, 0, 256);
            while (byteRead != 0)
            {
                string strResp = new string(cbuffer, 0, byteRead);
                strBuff = strBuff + strResp;
                byteRead = respStreamReader.Read(cbuffer, 0, 256);
            }
            //ReadWeb = strBuff;
            respStream.Close();
            respStreamReader.Close();
            //if (!Directory.Exists(path0))
            //{
            //    Directory.CreateDirectory(path0);
            //}
            write(path0, strBuff);
            dealFWversionDate(path0, out System, out HW_REV, out VENDOR, out BOOTR, out SW_REV, out MODEL, out FWName, out FWBuildTime, out FWRevision,out SN);
        }


        public void dealFWversionDate(string path, out string System, out string HW_REV, out string VENDOR, out string BOOTR, out string SW_REV, out string MODEL, out string FWName, out string FWBuildTime, out string FWRevision,out string SN)
        {
            System = "";
            HW_REV = "";
            VENDOR = "";
            BOOTR = "";
            SW_REV = "";
            MODEL = "";
            FWName = "";
            FWBuildTime = "";
            FWRevision = "";
            SN = "";
            string strLine;
            int NowTMP = 0;
            int ILnTMP = 0;
            StreamReader streamReader = new StreamReader(path);
            while (null != (strLine = streamReader.ReadLine()))
            {
                ILnTMP++;
                if (strLine.Contains("ARRIS DOCSIS"))
                {
                    string[] array = strLine.Split(new string[] { ">", "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        System = array[2].Trim();

                    }
                }
                if (strLine.Contains("HW_REV"))
                {
                    string[] array = strLine.Split(new string[] { "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        HW_REV = array[0].Trim();
                    }
                }
                if (strLine.Contains("VENDOR"))
                {
                    string[] array = strLine.Split(new string[] { "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        VENDOR = array[0].Trim();
                    }
                }
                if (strLine.Contains("BOOTR"))
                {
                    string[] array = strLine.Split(new string[] { "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        BOOTR = array[0].Trim();
                    }
                }
                if (strLine.Contains("SW_REV"))
                {
                    string[] array = strLine.Split(new string[] { "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        SW_REV = array[0].Trim();
                    }
                }
                if (strLine.Contains("MODEL"))
                {
                    string[] array = strLine.Split(new string[] { "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        MODEL = array[0].Trim();
                    }
                }
                if (strLine.Contains("Serial Number:"))
                {
                    NowTMP = ILnTMP;
                }
                if ((ILnTMP == NowTMP + 1) && ILnTMP > 1)
                {
                    string[] array = strLine.Split(new string[] { "=", ">", "<", "/" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        SN = array[2].Trim();
                    }
                }
                if (strLine.Contains("Firmware Name:"))
                {
                    string[] array = strLine.Split(new string[] { ":", ">", "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        FWName = array[11].Trim();
                    }
                }
                if (strLine.Contains("Firmware Build Time:"))
                {
                    string[] array = strLine.Split(new string[] { ">", "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        FWBuildTime = array[8].Trim();
                    }
                }
                if (strLine.Contains("eSAFE 0 FW Revision:"))
                {
                    string[] array = strLine.Split(new string[] { ":", ">", "<" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        FWRevision = array[9].Trim();
                    }
                }
            }
        }

        public void GetCMState(out string  DocsisDownstreamScanning, out string DocsisDownstreamRanging, out string DocsisUpstreamRanging, out string DocsisDHCP, out string DocsisTFTP, out string DocsisDataRegComplete, out string TelephonyDHCP, out string TelephonyTFTP, out string TelephonyRegwithCallServer,out string TelephonyRegComplete,out string TimeofDay,out string BPIStatus)
        {
            Uri httpURL = new Uri("http://192.168.100.1/cgi-bin/cm_state_cgi");//CMstate
            httpReq = (HttpWebRequest)WebRequest.Create(httpURL);
            httpResp = (HttpWebResponse)httpReq.GetResponse();
            Stream respStream = httpResp.GetResponseStream();
            StreamReader respStreamReader = new StreamReader(respStream, Encoding.UTF8);
            byteRead = respStreamReader.Read(cbuffer, 0, 256);
            while (byteRead != 0)
            {
                string strResp = new string(cbuffer, 0, byteRead);
                strBuff = strBuff + strResp;
                byteRead = respStreamReader.Read(cbuffer, 0, 256);
            }
            respStream.Close();
            //if(!Directory.Exists(path1))
            //{
            //    Directory.CreateDirectory(path1);
            //}
            write(path1, strBuff);       
            dealCMstate(path1, out DocsisDownstreamScanning, out DocsisDownstreamRanging, out  DocsisUpstreamRanging, out  DocsisDHCP, out  DocsisTFTP, out  DocsisDataRegComplete, out  TelephonyDHCP, out  TelephonyTFTP, out  TelephonyRegwithCallServer, out  TelephonyRegComplete, out  TimeofDay, out  BPIStatus);        
        }
        public void dealCMstate(string path, out string DocsisDownstreamScanning, out string DocsisDownstreamRanging, out string DocsisUpstreamRanging, out string DocsisDHCP, out string DocsisTFTP, out string DocsisDataRegComplete, out string TelephonyDHCP, out string TelephonyTFTP, out string TelephonyRegwithCallServer, out string TelephonyRegComplete, out string TimeofDay, out string BPIStatus)
        {
            DocsisDownstreamScanning = ">Docsis-Downstream Scanning</td>";
            GetCMstate(DocsisDownstreamScanning, out DocsisDownstreamScanning);

            DocsisDownstreamRanging = ">Docsis-Downstream Ranging</td>";
            GetCMstate(DocsisDownstreamRanging, out DocsisDownstreamRanging);

            DocsisUpstreamRanging = ">Docsis-Upstream Ranging</td>";
            GetCMstate(DocsisUpstreamRanging, out DocsisUpstreamRanging);

            DocsisDHCP = ">Docsis-DHCP</td>";
            GetCMstate(DocsisDHCP, out DocsisDHCP);

            DocsisTFTP = ">Docsis-TFTP</td>";
            GetCMstate(DocsisTFTP, out DocsisTFTP);

            DocsisDataRegComplete = ">Docsis-Data Reg Complete</td>";
            GetCMstate(DocsisDataRegComplete, out DocsisDataRegComplete);

            TelephonyDHCP = ">Telephony-DHCP</td>";
            GetCMstate(TelephonyDHCP, out TelephonyDHCP);

            TelephonyTFTP = ">Telephony-TFTP</td>";
            GetCMstate(TelephonyTFTP, out TelephonyTFTP);

            TelephonyRegwithCallServer = ">Telephony-Reg with Call Server</td>";
            GetCMstate(TelephonyRegwithCallServer, out TelephonyRegwithCallServer);

            TelephonyRegComplete = ">Telephony-Reg Complete</td>";
            GetCMstate(TelephonyRegComplete, out TelephonyRegComplete);

            TimeofDay = ">Time of Day</td>";
            GetCMstate(TimeofDay, out TimeofDay);

            BPIStatus = ">BPI Status</td>";
            GetCMstate(BPIStatus, out BPIStatus);

        
      }
        private void GetCMstate(string info, out string webinfo)
        {
            //string sTmp;
            string path = @"C:\CMlog.txt";
            StreamReader str = new StreamReader(path);
            webinfo = "";
            string strLine = "";
            int NowTMP = 0;
            int ILnTMP = 0;
            while (null != (strLine = str.ReadLine()))
            {
                ILnTMP++;
                if (strLine.Contains(info))
                {
                    NowTMP = ILnTMP;
                }
                if ((ILnTMP == NowTMP + 1) && ILnTMP > 1)
                {
                    string[] array = strLine.Split(new string[] { "=", ">", "<", "/" }, StringSplitOptions.None);
                    if (array.Length > 1)
                    {
                        webinfo = array[3].Trim();
                        NowTMP = 0;
                        ILnTMP = 0;
                        break;
                    }
                }
            }
        }
        
      
        static void DeleteFile(string FileFullName)
        {
            if (File.Exists(FileFullName))
            {
                File.Delete(FileFullName);
                System.Threading.Thread.Sleep(100);                
            }
        }
        public void write(string path, string web)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(web);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
