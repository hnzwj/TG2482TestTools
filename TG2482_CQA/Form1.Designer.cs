namespace TG2482_CQA
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgTestItem = new System.Windows.Forms.DataGridView();
            this.TestItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiSable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_CMDefaultIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtB_MultihomedSourceIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_CMIPALPS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtB_CMTSIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtB_UUTIP = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtB_test = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_SN = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTestItem
            // 
            this.dgTestItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestItem,
            this.Result,
            this.Time});
            this.dgTestItem.Location = new System.Drawing.Point(15, 85);
            this.dgTestItem.Name = "dgTestItem";
            this.dgTestItem.ReadOnly = true;
            this.dgTestItem.Size = new System.Drawing.Size(396, 298);
            this.dgTestItem.TabIndex = 5;
            // 
            // TestItem
            // 
            this.TestItem.HeaderText = "Test";
            this.TestItem.Name = "TestItem";
            this.TestItem.ReadOnly = true;
            this.TestItem.Width = 155;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 120;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 120;
            // 
            // DiSable
            // 
            this.DiSable.AutoSize = true;
            this.DiSable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiSable.Location = new System.Drawing.Point(57, 57);
            this.DiSable.Name = "DiSable";
            this.DiSable.Size = new System.Drawing.Size(56, 22);
            this.DiSable.TabIndex = 6;
            this.DiSable.Text = "YES";
            this.DiSable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "加密:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CM Default IP:";
            // 
            // txtB_CMDefaultIP
            // 
            this.txtB_CMDefaultIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_CMDefaultIP.Location = new System.Drawing.Point(97, 392);
            this.txtB_CMDefaultIP.Name = "txtB_CMDefaultIP";
            this.txtB_CMDefaultIP.Size = new System.Drawing.Size(110, 22);
            this.txtB_CMDefaultIP.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "MultihomedSourceIP:";
            // 
            // txtB_MultihomedSourceIP
            // 
            this.txtB_MultihomedSourceIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_MultihomedSourceIP.Location = new System.Drawing.Point(158, 470);
            this.txtB_MultihomedSourceIP.Name = "txtB_MultihomedSourceIP";
            this.txtB_MultihomedSourceIP.Size = new System.Drawing.Size(110, 22);
            this.txtB_MultihomedSourceIP.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "CM IP ALPS:";
            // 
            // txtB_CMIPALPS
            // 
            this.txtB_CMIPALPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_CMIPALPS.Location = new System.Drawing.Point(97, 432);
            this.txtB_CMIPALPS.Name = "txtB_CMIPALPS";
            this.txtB_CMIPALPS.Size = new System.Drawing.Size(110, 22);
            this.txtB_CMIPALPS.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "CMTS IP:";
            // 
            // txtB_CMTSIP
            // 
            this.txtB_CMTSIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_CMTSIP.Location = new System.Drawing.Point(293, 389);
            this.txtB_CMTSIP.Name = "txtB_CMTSIP";
            this.txtB_CMTSIP.Size = new System.Drawing.Size(110, 22);
            this.txtB_CMTSIP.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "UUT IP:";
            // 
            // txtB_UUTIP
            // 
            this.txtB_UUTIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_UUTIP.Location = new System.Drawing.Point(293, 429);
            this.txtB_UUTIP.Name = "txtB_UUTIP";
            this.txtB_UUTIP.Size = new System.Drawing.Size(110, 22);
            this.txtB_UUTIP.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtB_test
            // 
            this.txtB_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_test.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtB_test.Location = new System.Drawing.Point(228, 2);
            this.txtB_test.Multiline = true;
            this.txtB_test.Name = "txtB_test";
            this.txtB_test.ReadOnly = true;
            this.txtB_test.Size = new System.Drawing.Size(193, 50);
            this.txtB_test.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 50);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(361, 54);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(50, 26);
            this.bt_start.TabIndex = 30;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scan:";
            // 
            // TB_SN
            // 
            this.TB_SN.Location = new System.Drawing.Point(170, 57);
            this.TB_SN.Multiline = true;
            this.TB_SN.Name = "TB_SN";
            this.TB_SN.Size = new System.Drawing.Size(176, 22);
            this.TB_SN.TabIndex = 1;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(427, 497);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.TB_SN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtB_UUTIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtB_CMTSIP);
            this.Controls.Add(this.txtB_test);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtB_CMIPALPS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtB_MultihomedSourceIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB_CMDefaultIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiSable);
            this.Controls.Add(this.dgTestItem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTestItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTestItem;
        private System.Windows.Forms.CheckBox DiSable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_CMDefaultIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtB_MultihomedSourceIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtB_CMIPALPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtB_CMTSIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtB_UUTIP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.TextBox txtB_test;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_SN;
        private System.Windows.Forms.Timer timer3;
    }
}

