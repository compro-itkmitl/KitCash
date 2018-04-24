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

ref class ConnectionOnline
{
public:
	ConnectionOnline();

	String^ strcon;

	static void connnectsql()
	{
		String^ strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=Minimart.mdf;Trusted_Connection=True;AttachDbFilename =|DataDirectory|Database\\Minimart.mdf; Integrated Security = True;";
		/*String^ strcon = "Data Source=kitcash.database.windows.net;Initial Catalog=Minimart;Integrated Security=False;User ID=kitcash;Password=1475369nN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";*/
		/*String^ strcon = "Data Source = PXONEZ;Initial Catalog = Minimart;Integrated Security = True";*/
	}

	static DataTable^ executesql(String^ sql, String^ test)
	{
		String^ strcon = test;
		/*String^ strcon = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=Minimart.mdf;Trusted_Connection=True;AttachDbFilename =|DataDirectory|Database\\Minimart.mdf; Integrated Security = True;";*/
		/*String^ strcon = "Data Source=kitcash.database.windows.net;Initial Catalog=Minimart;Integrated Security=False;User ID=kitcash;Password=1475369nN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";*/
		/*String^ strcon = "Data Source = PXONEZ;Initial Catalog = Minimart;Integrated Security = True";*/
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
			MessageBox::Show(ex->Message);
		}

		return dt;
	}
};


