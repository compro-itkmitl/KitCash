#pragma once
#using <Microsoft.VisualBasic.dll>

using namespace System;
using namespace System::ComponentModel;
using namespace System::Collections;
using namespace System::Windows::Forms;
using namespace System::Data;
using namespace System::Drawing;
using namespace Data;
using namespace Data::SqlClient;
using namespace Microsoft::Win32;
using namespace Microsoft::VisualBasic;

ref class Connection2
{
public: Connection2();
	static String^ strcon;
	static String^ strcon2;
	static String^ connnectsql(String^ sql, String^ dts, String^ dtn, String^ un, String^ pas, String^ cs, int state)
	{
		if (sql == "online")
		{
			strcon = "Data Source="+dts+";Initial Catalog="+dtn+";Integrated Security=False;User ID="+un+";Password="+pas+";Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			if (state == 1)
				strcon2 = strcon->Replace(dtn, "master");
		}
		else if (sql == "offline")
		{
			strcon = "Data Source = "+dts+";Initial Catalog = "+dtn+";Integrated Security = True";
			if (state == 1)
				strcon2 = strcon->Replace(dtn, "master");
		}
		else if (sql == "cons")
		{
			strcon = cs;
			strcon2 = strcon;
		}
		else if (sql == "none")
		{
			strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=Minimart.mdf;Trusted_Connection=True;AttachDbFilename =|DataDirectory|Database\\Minimart.mdf; Integrated Security = True;";
			strcon2 = strcon;
		}
		/*String^ strcon = "Data Source=kitcash.database.windows.net;Initial Catalog=Minimart;Integrated Security=False;User ID=kitcash;Password=1475369nN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";*/
		/*String^ strcon = "Data Source = PXONEZ;Initial Catalog = Minimart;Integrated Security = True";*/
		return strcon;
	}

	static DataTable^ executesql(String^ sql)
	{
		SqlConnection^ objConn = gcnew SqlConnection();
		SqlDataAdapter^ dtAdapter = gcnew SqlDataAdapter();
		DataTable^ dt = gcnew DataTable();
		try
		{
			objConn->ConnectionString = strcon;
			objConn->Open();
			dtAdapter = gcnew SqlDataAdapter(sql, objConn);
			dtAdapter->Fill(dt);
			objConn->Close();
			objConn = nullptr;
			return dt;
		}
		catch (Exception^ ex)
		{
			MessageBox::Show(strcon);
		}

		return dt;
	}

	static String^ executesql2(int num ,String^ name, String^ sql)
	{
		strcon2 = strcon2->Replace("master", name);
		String^ connectionString = strcon2;/*"Data Source = PXONEZ;Initial Catalog = "+name+";Integrated Security = True";*/
		String^ query = sql;
		SqlConnection^ conn = gcnew SqlConnection(connectionString);
		SqlCommand^ command = gcnew SqlCommand(query, conn);
		try
		{
			conn->Open();
			command->ExecuteNonQuery();
		} 
		catch (Exception^ ex)
		{
			MessageBox::Show(ex->Message);
		}
		return sql;
	}

	static String^ testsql(String^ sql, String^ dts, String^ dtn, String^ un, String^ pas, String^ cs)
	{
		String^ test;
		if (sql == "online")
		{
			test = "Data Source=" + dts + ";Initial Catalog=" + dtn + ";Integrated Security=False;User ID=" + un + ";Password=" + pas + ";Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		}
		else if (sql == "offline")
		{
			test = "Data Source = " + dts + ";Initial Catalog = " + dtn + ";Integrated Security = True";
		}
		else if (sql == "cons")
		{
			test = cs;
		}
		else if (sql == "none")
		{
			test = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=Minimart.mdf;Trusted_Connection=True;AttachDbFilename =|DataDirectory|Database\\Minimart.mdf; Integrated Security = True;";
		}
		return test;
	}
};

