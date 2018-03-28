using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Reporting
{
    public partial class FormReporting : Form
    {
        public FormReporting()
        {
            InitializeComponent();
        }

        private void FormReporting_Load(object sender, EventArgs e)
        {
            ConnectionStr.connnectsql();
            Process[] pname = Process.GetProcessesByName("KitCash");
            if (pname.Length == 0)
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบ");
                Close();
            }
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panelLogo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void b_showreport_Click(object sender, EventArgs e)
        {
            DateTime dtstart = Convert.ToDateTime(dt1.Value.ToString());
            DateTime dtend = Convert.ToDateTime(dt2.Value.ToString());

            Telerik.Reporting.SqlDataSource report = new Telerik.Reporting.SqlDataSource();
            report.ConnectionString = ConnectionStr.strcon;
            report.SelectCommand = "SELECT Tbl_Sale.TR_Id, Tbl_Sale.TR_Date, Tbl_Sale.TR_Total, Tbl_Sale.Cus_Name, Tbl_Sale.Emp_Name, Tbl_SaleDetail.Pro_ID, Tbl_SaleDetail.Pro_Name, Tbl_SaleDetail.Pro_Price, Tbl_SaleDetail.Pro_Qty, Tbl_SaleDetail.Pro_Unit, Tbl_SaleDetail.Pro_Total FROM Tbl_Sale INNER JOIN Tbl_SaleDetail ON Tbl_Sale.TR_Id = Tbl_SaleDetail.TR_Id WHERE Tbl_Sale.TR_Date BETWEEN '" + dtstart.ToString("yyyy-MM-dd", new CultureInfo("en-US")) + "' AND '" + dtend.ToString("yyyy-MM-dd" + " 23:59:59", new CultureInfo("en-US")) + "'";

            reportSale1.DataSource = report;
            reportViewer1.ReportSource = reportSale1;
            reportViewer1.RefreshReport();
        }

        private void b_showtotal_Click(object sender, EventArgs e)
        {
            DateTime dtstart = Convert.ToDateTime(dt1.Value.ToString());
            DateTime dtend = Convert.ToDateTime(dt2.Value.ToString());

            DataTable showpriceSum = ConnectionStr.executsql("select sum(TR_Total) as total from tbl_sale where TR_Date between '" + dtstart.ToString("yyyy-MM-dd", new CultureInfo("en-US")) + "' and '" + dtend.ToString("yyyy-MM-dd" + " 23:59:59", new CultureInfo("en-US")) + "'");

            showtotal.Text = showpriceSum.Rows[0]["total"].ToString();
            string Str = showtotal.Text.Trim();

            double Num;

            bool isNum = double.TryParse(Str, out Num);

            if (isNum)

                showtotal.Text = Convert.ToDouble(showtotal.Text).ToString("##,##0.00");

            else

                showtotal.Text = "0.00";
        }

        private void b_sendline_Click(object sender, EventArgs e)
        {
            //'stickerPackageId=1&stickerId=1 //stick=https://devdocs.line.me/files/sticker_list.pdf
            //'&imageThumbnail=URL.png&imageFullsize=URL" //Photo
            //'Getline api token = https://notify-bot.line.me/my/

            var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
            var postData = string.Format("message={0}", "ยอดขายจากวันที่ " + dt1.Value + " ถึงวันที่่ " + dt2.Value + "= ยอดเงิน " + showtotal.Text + " บาท");
            var data = Encoding.UTF8.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.Headers.Add("Authorization", "Bearer JdxPUN8KCUnzX3Rp7n6OXEqs5Sqj3FJyoxcKSKgdanm");

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
        }

    }
}
