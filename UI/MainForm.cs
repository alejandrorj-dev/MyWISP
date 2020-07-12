/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:08
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;
using EL;


namespace UI
{
	/// <summary>
	/// This form is the Main Window of the application.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public User CurrentUser {get; set;}
		void BtnCloseClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Esta seguro de salir de la aplicacion?", "Salir de la Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
			
		}
		void BtnNewUserClick(object sender, EventArgs e)
		{
			FrmUsers frmusers = new FrmUsers();
			frmusers.Show();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			
			DateTime DateNow = DateTime.Now;
				
			lblDayOfDate.Text = DateNow.ToString("dd");
			lblDayOfWeek.Text = DateNow.ToString("dddd");
			
			
			if(CurrentUser != null)
			{
				lblNameUser.Text = "Hola, "+CurrentUser.Name_User+" "+CurrentUser.First_Surname;
			}
		}
		void BtnCustomersClick(object sender, EventArgs e)
		{
			FrmCustomers frmcustomers = new FrmCustomers();
			frmcustomers.Show();
		}
		void BtnServicePlanClick(object sender, EventArgs e)
		{
			FrmServices frmservicesplan = new FrmServices();
			frmservicesplan.Show();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnCustomerAntennasClick(object sender, EventArgs e)
		{
			FrmCustomerDevices frmcustomerdevices = new FrmCustomerDevices();
			frmcustomerdevices.Show();
		}
		void BtnSessionCustomerClick(object sender, EventArgs e)
		{
			FrmSessionCustomers frmsessioncustomers = new FrmSessionCustomers();
			frmsessioncustomers.Show();
		}
		void BtnPointOfSaleClick(object sender, EventArgs e)
		{
			FrmPointsOfSale frmpointsofsale = new FrmPointsOfSale();
			frmpointsofsale.Show();
		}
		void TxtPinGenerateClick(object sender, EventArgs e)
		{
			FrmGenerateCodeForMikrotik frmgeneratecodeformikrotik = new FrmGenerateCodeForMikrotik();
			frmgeneratecodeformikrotik.Show();
		}
		void BtnEquipmentsClick(object sender, EventArgs e)
		{
			FrmEquipments frmequipments = new FrmEquipments();
			frmequipments.Show();
		}
		void BtnAboutClick(object sender, EventArgs e)
		{
			FrmAbout frmabout = new FrmAbout();
			frmabout.Show();
		}

	}
}
