/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 23/01/2020
 * Time: 15:41
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all active Users.
	/// </summary>
	public partial class FrmUsers : Form
	{
		public FrmUsers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Company CompanyRegisted {get; set;}
		
		void RefreshdgvUsers()
		{
			dgvUsers.DataSource = UserBL.GetAllUsers();
			dgvUsers.Refresh();
		}
		
		void BtnAddNewUserClick(object sender, EventArgs e)
		{
			FrmAddUser frmadduser = new FrmAddUser();
			frmadduser.ShowDialog();
				
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void FrmUsersLoad(object sender, EventArgs e)
		{
			RefreshdgvUsers();
		}
		void BtnSearchClick(object sender, EventArgs e)
		{
			dgvUsers.DataSource = UserBL.SearchUser(txtSearchUser.Text);
		}
		void BtnRefreshdgvUsersClick(object sender, EventArgs e)
		{
			RefreshdgvUsers();
		}
		void BtnCompanyInformationClick(object sender, EventArgs e)
		{
			FrmCompanyInformation frmcompanyinformation = new FrmCompanyInformation();
			CompanyRegisted = CompanyBL.GetInformationCompany();
			frmcompanyinformation.CompanySaved = CompanyRegisted;
			frmcompanyinformation.Show();
		}
	}
}
