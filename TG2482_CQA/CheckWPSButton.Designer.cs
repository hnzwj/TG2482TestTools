namespace TG2482_CQA
{
    partial class CheckWPSButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckWPSButton));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_pass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 327);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BT_pass
            // 
            this.BT_pass.BackColor = System.Drawing.Color.White;
            this.BT_pass.Location = new System.Drawing.Point(36, 391);
            this.BT_pass.Name = "BT_pass";
            this.BT_pass.Size = new System.Drawing.Size(75, 31);
            this.BT_pass.TabIndex = 6;
            this.BT_pass.Text = "PASS";
            this.BT_pass.UseVisualStyleBackColor = false;
            this.BT_pass.Click += new System.EventHandler(this.BT_SetUP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please check WPS button:";
            // 
            // bt_fail
            // 
            this.bt_fail.BackColor = System.Drawing.Color.White;
            this.bt_fail.Location = new System.Drawing.Point(147, 391);
            this.bt_fail.Name = "bt_fail";
            this.bt_fail.Size = new System.Drawing.Size(75, 31);
            this.bt_fail.TabIndex = 8;
            this.bt_fail.Text = "FAIL";
            this.bt_fail.UseVisualStyleBackColor = false;
            this.bt_fail.Click += new System.EventHandler(this.bt_fail_Click);
            // 
            // CheckWPSButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 427);
            this.Controls.Add(this.bt_fail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_pass);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CheckWPSButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckWPSButton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fail;

    }
}