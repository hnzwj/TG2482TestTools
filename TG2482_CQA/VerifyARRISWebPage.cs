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
    public partial class VerifyARRISWebPage : Form
    {
        public VerifyARRISWebPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StationInfo.VerifyARRISWeb_check = true;
            StationInfo.VerifyARRISWeb = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StationInfo.VerifyARRISWeb_check = true;
            StationInfo.VerifyARRISWeb = false;
            this.Close();
        }

        private void VerifyARRISWebPage_Load(object sender, EventArgs e)
        {

        }
    }
}
