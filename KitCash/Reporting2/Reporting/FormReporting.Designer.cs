namespace Reporting
{
    partial class FormReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporting));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelheader = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.showtotal = new System.Windows.Forms.TextBox();
            this.b_sendline = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_showreport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.b_showtotal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportViewer1 = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.reportBook1 = new Telerik.Reporting.ReportBook();
            this.reportSale1 = new Reporting.ReportSale();
            this.panelHeader.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportSale1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.labelheader);
            this.panelHeader.Controls.Add(this.panelLogo);
            this.panelHeader.Controls.Add(this.min);
            this.panelHeader.Controls.Add(this.exit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 78);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // labelheader
            // 
            this.labelheader.AutoSize = true;
            this.labelheader.BackColor = System.Drawing.Color.Transparent;
            this.labelheader.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheader.ForeColor = System.Drawing.Color.White;
            this.labelheader.Location = new System.Drawing.Point(270, 27);
            this.labelheader.Name = "labelheader";
            this.labelheader.Size = new System.Drawing.Size(232, 32);
            this.labelheader.TabIndex = 6;
            this.labelheader.Text = "ITEM_REPORTING";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 78);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseMove);
            this.panelLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cloud", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "KitCash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Font = new System.Drawing.Font("Cloud", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(842, 4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(18, 28);
            this.min.TabIndex = 4;
            this.min.Text = "-";
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Cloud", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(867, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(21, 21);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dt2);
            this.panel1.Controls.Add(this.dt1);
            this.panel1.Controls.Add(this.showtotal);
            this.panel1.Controls.Add(this.b_sendline);
            this.panel1.Controls.Add(this.b_showreport);
            this.panel1.Controls.Add(this.b_showtotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 68);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "ถึงวันที่";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Font = new System.Drawing.Font("Cloud Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "จากวันที่";
            // 
            // dt2
            // 
            this.dt2.Font = new System.Drawing.Font("Cloud Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt2.Location = new System.Drawing.Point(98, 37);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(148, 25);
            this.dt2.TabIndex = 17;
            // 
            // dt1
            // 
            this.dt1.CustomFormat = "";
            this.dt1.Font = new System.Drawing.Font("Cloud Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt1.Location = new System.Drawing.Point(98, 6);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(148, 25);
            this.dt1.TabIndex = 16;
            // 
            // showtotal
            // 
            this.showtotal.Font = new System.Drawing.Font("Cloud Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtotal.Location = new System.Drawing.Point(418, 12);
            this.showtotal.Name = "showtotal";
            this.showtotal.Size = new System.Drawing.Size(140, 43);
            this.showtotal.TabIndex = 15;
            // 
            // b_sendline
            // 
            this.b_sendline.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_sendline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_sendline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_sendline.BorderRadius = 0;
            this.b_sendline.ButtonText = "ส่งเข้าไลน์";
            this.b_sendline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_sendline.DisabledColor = System.Drawing.Color.Gray;
            this.b_sendline.Iconcolor = System.Drawing.Color.Transparent;
            this.b_sendline.Iconimage = ((System.Drawing.Image)(resources.GetObject("b_sendline.Iconimage")));
            this.b_sendline.Iconimage_right = null;
            this.b_sendline.Iconimage_right_Selected = null;
            this.b_sendline.Iconimage_Selected = null;
            this.b_sendline.IconMarginLeft = 0;
            this.b_sendline.IconMarginRight = 0;
            this.b_sendline.IconRightVisible = true;
            this.b_sendline.IconRightZoom = 0D;
            this.b_sendline.IconVisible = true;
            this.b_sendline.IconZoom = 90D;
            this.b_sendline.IsTab = false;
            this.b_sendline.Location = new System.Drawing.Point(720, 10);
            this.b_sendline.Name = "b_sendline";
            this.b_sendline.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_sendline.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_sendline.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.b_sendline.selected = false;
            this.b_sendline.Size = new System.Drawing.Size(140, 48);
            this.b_sendline.TabIndex = 14;
            this.b_sendline.Text = "ส่งเข้าไลน์";
            this.b_sendline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_sendline.Textcolor = System.Drawing.Color.White;
            this.b_sendline.TextFont = new System.Drawing.Font("Cloud Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sendline.Click += new System.EventHandler(this.b_sendline_Click);
            // 
            // b_showreport
            // 
            this.b_showreport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_showreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_showreport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_showreport.BorderRadius = 0;
            this.b_showreport.ButtonText = "แสดงข้อมูล";
            this.b_showreport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_showreport.DisabledColor = System.Drawing.Color.Gray;
            this.b_showreport.Iconcolor = System.Drawing.Color.Transparent;
            this.b_showreport.Iconimage = ((System.Drawing.Image)(resources.GetObject("b_showreport.Iconimage")));
            this.b_showreport.Iconimage_right = null;
            this.b_showreport.Iconimage_right_Selected = null;
            this.b_showreport.Iconimage_Selected = null;
            this.b_showreport.IconMarginLeft = 0;
            this.b_showreport.IconMarginRight = 0;
            this.b_showreport.IconRightVisible = true;
            this.b_showreport.IconRightZoom = 0D;
            this.b_showreport.IconVisible = true;
            this.b_showreport.IconZoom = 90D;
            this.b_showreport.IsTab = false;
            this.b_showreport.Location = new System.Drawing.Point(262, 10);
            this.b_showreport.Name = "b_showreport";
            this.b_showreport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_showreport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_showreport.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.b_showreport.selected = false;
            this.b_showreport.Size = new System.Drawing.Size(140, 48);
            this.b_showreport.TabIndex = 9;
            this.b_showreport.Text = "แสดงข้อมูล";
            this.b_showreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_showreport.Textcolor = System.Drawing.Color.White;
            this.b_showreport.TextFont = new System.Drawing.Font("Cloud Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_showreport.Click += new System.EventHandler(this.b_showreport_Click);
            // 
            // b_showtotal
            // 
            this.b_showtotal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_showtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_showtotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_showtotal.BorderRadius = 0;
            this.b_showtotal.ButtonText = "แสดงยอด";
            this.b_showtotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_showtotal.DisabledColor = System.Drawing.Color.Gray;
            this.b_showtotal.Iconcolor = System.Drawing.Color.Transparent;
            this.b_showtotal.Iconimage = ((System.Drawing.Image)(resources.GetObject("b_showtotal.Iconimage")));
            this.b_showtotal.Iconimage_right = null;
            this.b_showtotal.Iconimage_right_Selected = null;
            this.b_showtotal.Iconimage_Selected = null;
            this.b_showtotal.IconMarginLeft = 0;
            this.b_showtotal.IconMarginRight = 0;
            this.b_showtotal.IconRightVisible = true;
            this.b_showtotal.IconRightZoom = 0D;
            this.b_showtotal.IconVisible = true;
            this.b_showtotal.IconZoom = 90D;
            this.b_showtotal.IsTab = false;
            this.b_showtotal.Location = new System.Drawing.Point(574, 10);
            this.b_showtotal.Name = "b_showtotal";
            this.b_showtotal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.b_showtotal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.b_showtotal.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.b_showtotal.selected = false;
            this.b_showtotal.Size = new System.Drawing.Size(140, 48);
            this.b_showtotal.TabIndex = 13;
            this.b_showtotal.Text = "แสดงยอด";
            this.b_showtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_showtotal.Textcolor = System.Drawing.Color.White;
            this.b_showtotal.TextFont = new System.Drawing.Font("Cloud Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_showtotal.Click += new System.EventHandler(this.b_showtotal_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 152);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(876, 509);
            this.reportViewer1.TabIndex = 14;
            this.reportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview;
            // 
            // reportSale1
            // 
            this.reportSale1.Name = "Reporting";
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(900, 673);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporting";
            this.Text = "Reporting";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportSale1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelheader;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox showtotal;
        private Bunifu.Framework.UI.BunifuFlatButton b_sendline;
        private Bunifu.Framework.UI.BunifuFlatButton b_showreport;
        private Bunifu.Framework.UI.BunifuFlatButton b_showtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.DateTimePicker dt1;
        private Telerik.ReportViewer.WinForms.ReportViewer reportViewer1;
        private ReportSale reportSale1;
        private Telerik.Reporting.ReportBook reportBook1;
    }
}