namespace Time_Sentinel_v1
{
    partial class HackerSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HackerSettingsDialog));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hackerBlockTskMgr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(45, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 38);
            this.label8.TabIndex = 36;
            this.label8.Text = "Modifying these options without fully understanding them is discouraged.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hackerBlockTskMgr);
            this.groupBox4.Location = new System.Drawing.Point(16, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 97);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "During restriction period:";
            // 
            // hackerBlockTskMgr
            // 
            this.hackerBlockTskMgr.AutoSize = true;
            this.hackerBlockTskMgr.Location = new System.Drawing.Point(29, 44);
            this.hackerBlockTskMgr.Name = "hackerBlockTskMgr";
            this.hackerBlockTskMgr.Size = new System.Drawing.Size(187, 19);
            this.hackerBlockTskMgr.TabIndex = 14;
            this.hackerBlockTskMgr.Text = "Block access to task manager";
            this.hackerBlockTskMgr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Note:";
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(31, 187);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(96, 24);
            this.btnOkay.TabIndex = 39;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(199, 187);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(96, 24);
            this.btnDefault.TabIndex = 38;
            this.btnDefault.Text = "Reset";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // HackerSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(326, 226);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HackerSettingsDialog";
            this.Text = "Hacker Options";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox hackerBlockTskMgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnDefault;
    }
}