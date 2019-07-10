namespace TG2482_CQA
{
    partial class ModemCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_SetUP = new System.Windows.Forms.Button();
            this.GB_Downstream = new System.Windows.Forms.GroupBox();
            this.lb_Downstream = new System.Windows.Forms.ListBox();
            this.GB_Upstream = new System.Windows.Forms.GroupBox();
            this.lb_Upstream = new System.Windows.Forms.ListBox();
            this.GB_ModleCheck = new System.Windows.Forms.GroupBox();
            this.LB_ModleCheck = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LB_CMstatus = new System.Windows.Forms.ListBox();
            this.bt_fail = new System.Windows.Forms.Button();
            this.GB_Downstream.SuspendLayout();
            this.GB_Upstream.SuspendLayout();
            this.GB_ModleCheck.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_SetUP
            // 
            this.BT_SetUP.BackColor = System.Drawing.Color.White;
            this.BT_SetUP.Location = new System.Drawing.Point(238, 402);
            this.BT_SetUP.Name = "BT_SetUP";
            this.BT_SetUP.Size = new System.Drawing.Size(75, 31);
            this.BT_SetUP.TabIndex = 1;
            this.BT_SetUP.Text = "PASS";
            this.BT_SetUP.UseVisualStyleBackColor = false;
            this.BT_SetUP.Click += new System.EventHandler(this.button1_Click);
            // 
            // GB_Downstream
            // 
            this.GB_Downstream.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_Downstream.Controls.Add(this.lb_Downstream);
            this.GB_Downstream.Location = new System.Drawing.Point(13, 255);
            this.GB_Downstream.Name = "GB_Downstream";
            this.GB_Downstream.Size = new System.Drawing.Size(352, 118);
            this.GB_Downstream.TabIndex = 5;
            this.GB_Downstream.TabStop = false;
            this.GB_Downstream.Text = "Downstream";
            // 
            // lb_Downstream
            // 
            this.lb_Downstream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Downstream.FormattingEnabled = true;
            this.lb_Downstream.ItemHeight = 16;
            this.lb_Downstream.Location = new System.Drawing.Point(6, 19);
            this.lb_Downstream.Name = "lb_Downstream";
            this.lb_Downstream.Size = new System.Drawing.Size(338, 84);
            this.lb_Downstream.TabIndex = 1;
            // 
            // GB_Upstream
            // 
            this.GB_Upstream.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_Upstream.Controls.Add(this.lb_Upstream);
            this.GB_Upstream.Location = new System.Drawing.Point(382, 255);
            this.GB_Upstream.Name = "GB_Upstream";
            this.GB_Upstream.Size = new System.Drawing.Size(355, 118);
            this.GB_Upstream.TabIndex = 6;
            this.GB_Upstream.TabStop = false;
            this.GB_Upstream.Text = "Upstream";
            // 
            // lb_Upstream
            // 
            this.lb_Upstream.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Upstream.FormattingEnabled = true;
            this.lb_Upstream.ItemHeight = 16;
            this.lb_Upstream.Location = new System.Drawing.Point(6, 19);
            this.lb_Upstream.Name = "lb_Upstream";
            this.lb_Upstream.Size = new System.Drawing.Size(338, 84);
            this.lb_Upstream.TabIndex = 2;
            // 
            // GB_ModleCheck
            // 
            this.GB_ModleCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_ModleCheck.Controls.Add(this.LB_ModleCheck);
            this.GB_ModleCheck.Location = new System.Drawing.Point(12, 12);
            this.GB_ModleCheck.Name = "GB_ModleCheck";
            this.GB_ModleCheck.Size = new System.Drawing.Size(353, 237);
            this.GB_ModleCheck.TabIndex = 7;
            this.GB_ModleCheck.TabStop = false;
            this.GB_ModleCheck.Text = "HW/FW Versions";
            // 
            // LB_ModleCheck
            // 
            this.LB_ModleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ModleCheck.FormattingEnabled = true;
            this.LB_ModleCheck.ItemHeight = 16;
            this.LB_ModleCheck.Location = new System.Drawing.Point(7, 19);
            this.LB_ModleCheck.Name = "LB_ModleCheck";
            this.LB_ModleCheck.Size = new System.Drawing.Size(338, 212);
            this.LB_ModleCheck.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.LB_CMstatus);
            this.groupBox4.Location = new System.Drawing.Point(382, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 237);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CM status";
            // 
            // LB_CMstatus
            // 
            this.LB_CMstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CMstatus.FormattingEnabled = true;
            this.LB_CMstatus.ItemHeight = 16;
            this.LB_CMstatus.Location = new System.Drawing.Point(6, 19);
            this.LB_CMstatus.Name = "LB_CMstatus";
            this.LB_CMstatus.Size = new System.Drawing.Size(338, 212);
            this.LB_CMstatus.TabIndex = 1;
            // 
            // bt_fail
            // 
            this.bt_fail.BackColor = System.Drawing.Color.White;
            this.bt_fail.Location = new System.Drawing.Point(405, 402);
            this.bt_fail.Name = "bt_fail";
            this.bt_fail.Size = new System.Drawing.Size(75, 31);
            this.bt_fail.TabIndex = 9;
            this.bt_fail.Text = "FAIL";
            this.bt_fail.UseVisualStyleBackColor = false;
            this.bt_fail.Click += new System.EventHandler(this.bt_fail_Click);
            // 
            // ModemCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 457);
            this.Controls.Add(this.bt_fail);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GB_ModleCheck);
            this.Controls.Add(this.GB_Upstream);
            this.Controls.Add(this.GB_Downstream);
            this.Controls.Add(this.BT_SetUP);
            this.Name = "ModemCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModleCheck";
            this.Load += new System.EventHandler(this.ModleCheck_Load);
            this.GB_Downstream.ResumeLayout(false);
            this.GB_Upstream.ResumeLayout(false);
            this.GB_ModleCheck.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_SetUP;
        private System.Windows.Forms.GroupBox GB_Downstream;
        private System.Windows.Forms.GroupBox GB_Upstream;
        private System.Windows.Forms.GroupBox GB_ModleCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lb_Downstream;
        private System.Windows.Forms.ListBox LB_ModleCheck;
        private System.Windows.Forms.ListBox LB_CMstatus;
        private System.Windows.Forms.ListBox lb_Upstream;
        private System.Windows.Forms.Button bt_fail;
    }
}