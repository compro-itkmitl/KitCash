using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

public class ConnectionStr
{
    public static string strcon;
    public static void connnectsql()
    

    {
        strcon = "Data Source=kitcash.database.windows.net;Initial Catalog=Minimart;Integrated Security=False;User ID=kitcash;Password=1475369nN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
    }

    public static DataTable executsql(string sql)
    {
        SqlDataAdapter dtAdapter = default(SqlDataAdapter);
        SqlConnection objConn = new SqlConnection();
        DataTable dt = new DataTable();
        try
        {
            objConn.ConnectionString = strcon;
            objConn.Open();
            dtAdapter = new SqlDataAdapter(sql, objConn);
            dtAdapter.Fill(dt);
            objConn.Close();
            objConn = null;
            return dt;
        }
        catch(Exception exx)
        {
            Console.Write(exx.ToString());
            dt = null;
        }

        return dt;
    }




















            ////DateTime Datestart = Convert.ToDateTime(dateTimePicker1.Value.ToString());
            ////+Datestart.ToString("yyyy-MM-dd", new CultureInfo("en-US")) +
            ////DateTime DateEnd = Convert.ToDateTime(dateTimePicker2.Value.ToString());
            ////+DateEnd.ToString("yyyy-MM-dd" + " 23:59:59", new CultureInfo("en-US")) +


  

    //String datestart = ConnectionStr.Getdateend(Convert.ToDateTime(DateTime.Now)).ToString();
    //MessageBox.Show(datestart, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
    public static DateTime Getdate(DateTime datetime)
    {
        //ConnectionStr.Getdateend(Convert.ToDateTime(dateTimePicker1.Value));
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        Console.WriteLine(datetime.ToString("yyyy-MM-dd", ThaiCulture));

     ///   MessageBox.Show(Convert.ToDateTime(datetime.ToString("yyyy-MM-dd", ThaiCulture)), "");
        return Convert.ToDateTime(datetime.ToString("yyyy-MM-dd", ThaiCulture));

    }

    public static DateTime Getdateend(DateTime datetime)
    {
        //ConnectionStr.Getdateend(Convert.ToDateTime(dateTimePicker1.Value));
        CultureInfo ThaiCulture = new CultureInfo("th-TH");
        Console.WriteLine(datetime.ToString("yyyy-MM-dd" + " 23:59:59", ThaiCulture));
        return Convert.ToDateTime(datetime.ToString("yyyy-MM-dd" + " 23:59:59", ThaiCulture));

    }

 
}

