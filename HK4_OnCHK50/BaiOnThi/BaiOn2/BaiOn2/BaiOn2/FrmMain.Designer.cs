﻿namespace BaiOn2
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMSV,
            this.mnuMMH,
            this.mnuMDT,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMSV
            // 
            this.mnuMSV.Name = "mnuMSV";
            this.mnuMSV.Size = new System.Drawing.Size(138, 24);
            this.mnuMSV.Text = "Manage SinhVien";
            this.mnuMSV.Click += new System.EventHandler(this.mnuMSV_Click);
            // 
            // mnuMMH
            // 
            this.mnuMMH.Name = "mnuMMH";
            this.mnuMMH.Size = new System.Drawing.Size(138, 24);
            this.mnuMMH.Text = "Manage MonHoc";
            this.mnuMMH.Click += new System.EventHandler(this.mnuMMH_Click);
            // 
            // mnuMDT
            // 
            this.mnuMDT.Name = "mnuMDT";
            this.mnuMDT.Size = new System.Drawing.Size(137, 24);
            this.mnuMDT.Text = "Manage DiemThi";
            this.mnuMDT.Click += new System.EventHandler(this.mnuMDT_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(61, 24);
            this.mnuThoat.Text = "Thoat";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMSV;
        private System.Windows.Forms.ToolStripMenuItem mnuMMH;
        private System.Windows.Forms.ToolStripMenuItem mnuMDT;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}

