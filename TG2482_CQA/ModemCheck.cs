using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TG2482_CQA
{
    public partial class ModemCheck : Form
    {
        public ModemCheck()
        {
            InitializeComponent();
        }

        string system = "";
        string HW_REV = "";
        string VENDOR = "";
        string BOOTR = "";
        string SW_REV = "";
        string MODEL = "";
        string FWName = "";
        string FWBuildTime = "";
        string FWRevision = "";
        string SN = "";

        string DocsisDownstreamScanning="";
        string DocsisDownstreamRanging="";
        string DocsisUpstreamRanging="";
        string DocsisDHCP="";
        string DocsisTFTP="";
        string DocsisDataRegComplete="";
        string TelephonyDHCP="";
        string TelephonyTFTP="";
        string TelephonyRegwithCallServer="";
        string TelephonyRegComplete="";
        string TimeofDay="";
        string BPIStatus="";
        private void ModleCheck_Load(object sender, EventArgs e)
        {           
            GetWebInformation getWebDate = new GetWebInformation();

            getWebDate.GetHWandFWversions(out system, out HW_REV, out VENDOR, out BOOTR, out SW_REV, out MODEL, out FWName, out FWBuildTime, out FWRevision,out SN);
            LB_ModleCheck.Items.Add("System:" + "\r\n" + system + "\r\n");
            LB_ModleCheck.Items.Add("HW_REV:" + HW_REV + "\r\n");
            LB_ModleCheck.Items.Add("VENDOR:" + VENDOR + "\r\n");
            LB_ModleCheck.Items.Add("BOOTR:" + BOOTR + "\r\n");
            LB_ModleCheck.Items.Add("SW_REV:" + SW_REV + "\r\n");
            LB_ModleCheck.Items.Add("MODEL:" + MODEL + "\r\n");
            LB_ModleCheck.Items.Add("Serial Number:" + SN + "\r\n");
            LB_ModleCheck.Items.Add("FWName:" + FWName + "\r\n");
            LB_ModleCheck.Items.Add("FWBuildTime:" + FWBuildTime + "\r\n");
            LB_ModleCheck.Items.Add("FWRevision:" + FWRevision + "\r\n");

            LogHelper.Info("Serial Number:" + SN);
            LogHelper.Info("System:" + system);
            LogHelper.Info("HW_REV:" + HW_REV);
            LogHelper.Info("VENDOR:" + VENDOR);
            LogHelper.Info("BOOTR:" + BOOTR);
            LogHelper.Info("SW_REV:" + SW_REV);
            LogHelper.Info("MODEL:" + MODEL);
            LogHelper.Info("Serial Number:" + SN);
            LogHelper.Info("FWName:" + FWName);
            LogHelper.Info("FWBuildTime:" + FWBuildTime);
            LogHelper.Info("FWRevision:" + FWRevision);

            getWebDate.GetCMState(out DocsisDownstreamScanning,out DocsisDownstreamRanging,out DocsisUpstreamRanging,out DocsisDHCP,out DocsisTFTP,out DocsisDataRegComplete,out TelephonyDHCP, out  TelephonyTFTP,out TelephonyRegwithCallServer,out TelephonyRegComplete,out TimeofDay,out BPIStatus);
            LB_CMstatus.Items.Add("Docsis-Downstream Scanning:" + DocsisDownstreamScanning + "\r\n");
            LB_CMstatus.Items.Add("Docsis-Downstream Ranging:" + DocsisDownstreamRanging + "\r\n");
            LB_CMstatus.Items.Add("Docsis-Upstream Ranging:" + DocsisUpstreamRanging + "\r\n");
            LB_CMstatus.Items.Add("Docsis-DHCP:" + DocsisDHCP + "\r\n");
            LB_CMstatus.Items.Add("Docsis-TFTP:" + DocsisTFTP + "\r\n");
            LB_CMstatus.Items.Add("Docsis-Data Reg Complete:" + DocsisDataRegComplete + "\r\n");
            LB_CMstatus.Items.Add("Telephony-DHCP:" + TelephonyDHCP + "\r\n");
            LB_CMstatus.Items.Add("Telephony-TFTP:" + TelephonyTFTP + "\r\n");
            LB_CMstatus.Items.Add("Telephony-Reg with Call Server:" + TelephonyRegwithCallServer + "\r\n");
            LB_CMstatus.Items.Add("Telephony-Reg Complete:" + TelephonyRegComplete + "\r\n");
            LB_CMstatus.Items.Add("Time of Day:" + TimeofDay + "\r\n");
            LB_CMstatus.Items.Add("BPI Status:" + BPIStatus + "\r\n");


            LogHelper.Info("Docsis-Downstream Scanning:" + DocsisDownstreamScanning);
            LogHelper.Info("Docsis-Downstream Ranging:" + DocsisDownstreamRanging);
            LogHelper.Info("Docsis-Upstream Ranging:" + DocsisUpstreamRanging);
            LogHelper.Info("Docsis-DHCP:" + DocsisDHCP);
            LogHelper.Info("Docsis-TFTP:" + DocsisTFTP);
            LogHelper.Info("Docsis-Data Reg Complete:" + DocsisDataRegComplete);
            LogHelper.Info("Telephony-DHCP:" + TelephonyDHCP);
            LogHelper.Info("Telephony-TFTP:" + TelephonyTFTP);
            LogHelper.Info("Telephony-Reg with Call Server:" + TelephonyRegwithCallServer);
            LogHelper.Info("Telephony-Reg Complete:" + TelephonyRegComplete);
            LogHelper.Info("Time of Day:" + TimeofDay);
            LogHelper.Info("BPI Status:" + BPIStatus);

            StationInfo.SN = SN;
            StationInfo.TelephonyRegComplet = TelephonyRegComplete;
            StationInfo.BPIStatus = BPIStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StationInfo.modemcheck_OK = true;
            StationInfo.ModemCheck = true;
            this.Close();
        }

        private void bt_fail_Click(object sender, EventArgs e)
        {
            StationInfo.modemcheck_OK = true;
            StationInfo.ModemCheck = false;
            this.Close();
        }

    }
}
              
