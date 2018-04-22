#pragma once
#include "Connection2.h"
#include "FormMenu.h"

namespace KitCash {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for FormLogin
	/// </summary>
	public ref class FormLogin : public System::Windows::Forms::Form
	{
	public:
		FormLogin(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~FormLogin()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label27;
	private: System::Windows::Forms::PictureBox^  pictureBox0;
	protected:

	private: Bunifu::Framework::UI::BunifuFlatButton^  b_login;
	private: System::Windows::Forms::Panel^  panel0;

	private: System::Windows::Forms::PictureBox^  pictureBox5;
	private: System::Windows::Forms::PictureBox^  pictureBox4;
	private: Bunifu::Framework::UI::BunifuMetroTextbox^  password;
	private: Bunifu::Framework::UI::BunifuMetroTextbox^  username;
	private: System::Windows::Forms::Label^  min;
	private: System::Windows::Forms::Label^  exit;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(FormLogin::typeid));
			this->label27 = (gcnew System::Windows::Forms::Label());
			this->pictureBox0 = (gcnew System::Windows::Forms::PictureBox());
			this->b_login = (gcnew Bunifu::Framework::UI::BunifuFlatButton());
			this->panel0 = (gcnew System::Windows::Forms::Panel());
			this->pictureBox5 = (gcnew System::Windows::Forms::PictureBox());
			this->pictureBox4 = (gcnew System::Windows::Forms::PictureBox());
			this->password = (gcnew Bunifu::Framework::UI::BunifuMetroTextbox());
			this->username = (gcnew Bunifu::Framework::UI::BunifuMetroTextbox());
			this->min = (gcnew System::Windows::Forms::Label());
			this->exit = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox0))->BeginInit();
			this->panel0->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox5))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox4))->BeginInit();
			this->SuspendLayout();
			// 
			// label27
			// 
			this->label27->AutoSize = true;
			this->label27->Font = (gcnew System::Drawing::Font(L"Century Gothic", 27.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label27->Location = System::Drawing::Point(254, 235);
			this->label27->Name = L"label27";
			this->label27->Size = System::Drawing::Size(206, 44);
			this->label27->TabIndex = 32;
			this->label27->Text = L"- KitCash -";
			// 
			// pictureBox0
			// 
			this->pictureBox0->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox0.Image")));
			this->pictureBox0->Location = System::Drawing::Point(258, 20);
			this->pictureBox0->Name = L"pictureBox0";
			this->pictureBox0->Size = System::Drawing::Size(200, 200);
			this->pictureBox0->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox0->TabIndex = 31;
			this->pictureBox0->TabStop = false;
			// 
			// b_login
			// 
			this->b_login->Activecolor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)), static_cast<System::Int32>(static_cast<System::Byte>(126)),
				static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->b_login->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)), static_cast<System::Int32>(static_cast<System::Byte>(126)),
				static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->b_login->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Stretch;
			this->b_login->BorderRadius = 0;
			this->b_login->ButtonText = L"LOGIN";
			this->b_login->Cursor = System::Windows::Forms::Cursors::Hand;
			this->b_login->DisabledColor = System::Drawing::Color::Gray;
			this->b_login->Iconcolor = System::Drawing::Color::Transparent;
			this->b_login->Iconimage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"b_login.Iconimage")));
			this->b_login->Iconimage_right = nullptr;
			this->b_login->Iconimage_right_Selected = nullptr;
			this->b_login->Iconimage_Selected = nullptr;
			this->b_login->IconMarginLeft = 0;
			this->b_login->IconMarginRight = 0;
			this->b_login->IconRightVisible = true;
			this->b_login->IconRightZoom = 0;
			this->b_login->IconVisible = true;
			this->b_login->IconZoom = 90;
			this->b_login->IsTab = false;
			this->b_login->Location = System::Drawing::Point(285, 423);
			this->b_login->Name = L"b_login";
			this->b_login->Normalcolor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)), static_cast<System::Int32>(static_cast<System::Byte>(126)),
				static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->b_login->OnHovercolor = System::Drawing::Color::DarkOrange;
			this->b_login->OnHoverTextColor = System::Drawing::Color::White;
			this->b_login->selected = false;
			this->b_login->Size = System::Drawing::Size(130, 48);
			this->b_login->TabIndex = 30;
			this->b_login->Text = L"LOGIN";
			this->b_login->TextAlign = System::Drawing::ContentAlignment::MiddleLeft;
			this->b_login->Textcolor = System::Drawing::Color::White;
			this->b_login->TextFont = (gcnew System::Drawing::Font(L"Cloud", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->b_login->Click += gcnew System::EventHandler(this, &FormLogin::b_login_Click);
			// 
			// panel0
			// 
			this->panel0->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->panel0->BackColor = System::Drawing::Color::White;
			this->panel0->Controls->Add(this->pictureBox5);
			this->panel0->Controls->Add(this->pictureBox4);
			this->panel0->Controls->Add(this->password);
			this->panel0->Controls->Add(this->username);
			this->panel0->Controls->Add(this->label27);
			this->panel0->Controls->Add(this->pictureBox0);
			this->panel0->Controls->Add(this->b_login);
			this->panel0->Location = System::Drawing::Point(99, 87);
			this->panel0->Name = L"panel0";
			this->panel0->Size = System::Drawing::Size(697, 491);
			this->panel0->TabIndex = 33;
			// 
			// pictureBox5
			// 
			this->pictureBox5->BackColor = System::Drawing::Color::White;
			this->pictureBox5->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox5.Image")));
			this->pictureBox5->Location = System::Drawing::Point(208, 358);
			this->pictureBox5->Name = L"pictureBox5";
			this->pictureBox5->Size = System::Drawing::Size(47, 49);
			this->pictureBox5->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox5->TabIndex = 38;
			this->pictureBox5->TabStop = false;
			// 
			// pictureBox4
			// 
			this->pictureBox4->BackColor = System::Drawing::Color::White;
			this->pictureBox4->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox4.Image")));
			this->pictureBox4->Location = System::Drawing::Point(207, 293);
			this->pictureBox4->Name = L"pictureBox4";
			this->pictureBox4->Size = System::Drawing::Size(48, 49);
			this->pictureBox4->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox4->TabIndex = 37;
			this->pictureBox4->TabStop = false;
			// 
			// password
			// 
			this->password->BackColor = System::Drawing::Color::White;
			this->password->BorderColorFocused = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)),
				static_cast<System::Int32>(static_cast<System::Byte>(126)), static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->password->BorderColorIdle = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(41)), static_cast<System::Int32>(static_cast<System::Byte>(53)),
				static_cast<System::Int32>(static_cast<System::Byte>(65)));
			this->password->BorderColorMouseHover = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)),
				static_cast<System::Int32>(static_cast<System::Byte>(126)), static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->password->BorderThickness = 3;
			this->password->Cursor = System::Windows::Forms::Cursors::IBeam;
			this->password->Font = (gcnew System::Drawing::Font(L"Cloud", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->password->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(64)), static_cast<System::Int32>(static_cast<System::Byte>(64)),
				static_cast<System::Int32>(static_cast<System::Byte>(64)));
			this->password->isPassword = true;
			this->password->Location = System::Drawing::Point(199, 350);
			this->password->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->password->Name = L"password";
			this->password->Padding = System::Windows::Forms::Padding(60, 5, 0, 0);
			this->password->Size = System::Drawing::Size(310, 64);
			this->password->TabIndex = 36;
			this->password->TextAlign = System::Windows::Forms::HorizontalAlignment::Left;
			// 
			// username
			// 
			this->username->BackColor = System::Drawing::Color::White;
			this->username->BorderColorFocused = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)),
				static_cast<System::Int32>(static_cast<System::Byte>(126)), static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->username->BorderColorIdle = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(41)), static_cast<System::Int32>(static_cast<System::Byte>(53)),
				static_cast<System::Int32>(static_cast<System::Byte>(65)));
			this->username->BorderColorMouseHover = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(229)),
				static_cast<System::Int32>(static_cast<System::Byte>(126)), static_cast<System::Int32>(static_cast<System::Byte>(49)));
			this->username->BorderThickness = 3;
			this->username->Cursor = System::Windows::Forms::Cursors::IBeam;
			this->username->Font = (gcnew System::Drawing::Font(L"Cloud", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->username->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(64)), static_cast<System::Int32>(static_cast<System::Byte>(64)),
				static_cast<System::Int32>(static_cast<System::Byte>(64)));
			this->username->isPassword = false;
			this->username->Location = System::Drawing::Point(199, 285);
			this->username->Margin = System::Windows::Forms::Padding(6, 6, 6, 6);
			this->username->Name = L"username";
			this->username->Padding = System::Windows::Forms::Padding(60, 5, 0, 0);
			this->username->Size = System::Drawing::Size(310, 64);
			this->username->TabIndex = 35;
			this->username->TextAlign = System::Windows::Forms::HorizontalAlignment::Left;
			// 
			// min
			// 
			this->min->AutoSize = true;
			this->min->BackColor = System::Drawing::Color::Transparent;
			this->min->Cursor = System::Windows::Forms::Cursors::Hand;
			this->min->Font = (gcnew System::Drawing::Font(L"Cloud", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->min->ForeColor = System::Drawing::Color::White;
			this->min->Location = System::Drawing::Point(848, 3);
			this->min->Name = L"min";
			this->min->Size = System::Drawing::Size(18, 28);
			this->min->TabIndex = 35;
			this->min->Text = L"-";
			this->min->Click += gcnew System::EventHandler(this, &FormLogin::min_Click);
			// 
			// exit
			// 
			this->exit->AutoSize = true;
			this->exit->BackColor = System::Drawing::Color::Transparent;
			this->exit->Cursor = System::Windows::Forms::Cursors::Hand;
			this->exit->Font = (gcnew System::Drawing::Font(L"Cloud", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->exit->ForeColor = System::Drawing::Color::White;
			this->exit->Location = System::Drawing::Point(873, 8);
			this->exit->Name = L"exit";
			this->exit->Size = System::Drawing::Size(21, 21);
			this->exit->TabIndex = 34;
			this->exit->Text = L"X";
			this->exit->Click += gcnew System::EventHandler(this, &FormLogin::exit_Click);
			// 
			// FormLogin
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(41)), static_cast<System::Int32>(static_cast<System::Byte>(53)),
				static_cast<System::Int32>(static_cast<System::Byte>(65)));
			this->ClientSize = System::Drawing::Size(900, 673);
			this->Controls->Add(this->min);
			this->Controls->Add(this->exit);
			this->Controls->Add(this->panel0);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::None;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->Name = L"FormLogin";
			this->Text = L"KitCash - Login";
			this->Load += gcnew System::EventHandler(this, &FormLogin::FormLogin_Load);
			this->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &FormLogin::FormLogin_MouseDown);
			this->MouseMove += gcnew System::Windows::Forms::MouseEventHandler(this, &FormLogin::FormLogin_MouseMove);
			this->MouseUp += gcnew System::Windows::Forms::MouseEventHandler(this, &FormLogin::FormLogin_MouseUp);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox0))->EndInit();
			this->panel0->ResumeLayout(false);
			this->panel0->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox5))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox4))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: bool dragging;
	private: Point offset;
	private: System::Void FormLogin_Load(System::Object^  sender, System::EventArgs^  e) 
	{
		Connection2::connnectsql();
	}
	private: System::Void b_login_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		//FormMenu^ frmmenu = gcnew FormMenu();
		DataTable^ checkloginemp = Connection2::executesql("SELECT * FROM Tbl_Employee Where Emp_Id = '" + username->Text + "' and Emp_Password = '" + password->Text + "'");
		if (checkloginemp->Rows->Count > 0)
		{
			MessageBox::Show("สำเร็จ", "แจ้งเตือน", MessageBoxButtons::OK, MessageBoxIcon::Information);
			try
			{
				/*String^ strcon = "Data Source=kitcash.database.windows.net;Initial Catalog=Minimart;Integrated Security=False;User ID=kitcash;Password=1475369nN;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";*/
				String^ strcon = "Data Source = PXONEZ;Initial Catalog = Minimart;Integrated Security = True";

				SqlConnection^ con = gcnew SqlConnection(strcon);

				con->Open();

				SqlCommand^ cmdemp = gcnew SqlCommand("select * from tbl_employee where Emp_Id='" + username->Text + "'", con);

				SqlDataReader^ readeremp = cmdemp->ExecuteReader();

				if (readeremp->Read())
				{
					/*frmmenu->stateuser->Text = readeremp["Emp_Name"]->ToString();
					frmmenu->emp->Text = readeremp["Emp_Name"]->ToString();
					
					frmmenu->Show();
					Hide();*/
				}
				else
				{
					/*frmmenu->stateuser->Text = "";*/
				}

				con->Close();

			}
			catch (Exception^ ex)
			{
				MessageBox::Show(ex->Message);
			}
		}
		else
		{
			MessageBox::Show("ไม่สำเร็จ", "แจ้งเตือน", MessageBoxButtons::OK, MessageBoxIcon::Warning);
		}
	}
private: System::Void exit_Click(System::Object^  sender, System::EventArgs^  e) 
{
	Close();
	
}
private: System::Void min_Click(System::Object^  sender, System::EventArgs^  e) 
{
	this->WindowState = FormWindowState::Minimized;
}
private: System::Void FormLogin_MouseDown(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) 
{
	this->dragging = true;
	this->offset = Point(e->X, e->Y);
}
private: System::Void FormLogin_MouseMove(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) 
{
	if (this->dragging) 
	{
		Point currentScreenPos = PointToScreen(e->Location);
		Location = Point(currentScreenPos.X - this->offset.X, currentScreenPos.Y - this->offset.Y);
	}
}
private: System::Void FormLogin_MouseUp(System::Object^  sender, System::Windows::Forms::MouseEventArgs^  e) 
{
	this->dragging = false;
}
};
}
