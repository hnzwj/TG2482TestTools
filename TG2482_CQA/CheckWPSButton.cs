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
    public partial class CheckWPSButton : Form
    {
        public CheckWPSButton()
        {
            InitializeComponent();
        }

        private void BT_SetUP_Click(object sender, EventArgs e)
        {
            StationInfo.WPSCheck_OK = true;
            StationInfo.WPSCheck = true;
            this.Close();
        }

        private void bt_fail_Click(object sender, EventArgs e)
        {
            StationInfo.WPSCheck_OK = true;
            StationInfo.WPSCheck = false;
            this.Close();
        }
    }
}
