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
    public partial class LED_and_Telephone : Form
    {
        public LED_and_Telephone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StationInfo.LEDCheck_OK = true;
            StationInfo.LEDCheck = true;
            this.Close();
        }

        private void bt_fail_Click(object sender, EventArgs e)
        {
            StationInfo.LEDCheck_OK = true;
            StationInfo.LEDCheck = false;
            this.Close();
        }
    }
}
