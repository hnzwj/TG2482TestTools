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
    public partial class Get_Serial_Number : Form
    {
        public Get_Serial_Number()
        {
            InitializeComponent();
        }

        private void Get_Serial_Number_Load(object sender, EventArgs e)
        {
            textBox1.Text = StationInfo.SN;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StationInfo.SNcheck_OK = true;
            StationInfo.SNCheck = true;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StationInfo.SNcheck_OK = true;
            StationInfo.SNCheck = false;
            this.Close();
        }
    }
}
