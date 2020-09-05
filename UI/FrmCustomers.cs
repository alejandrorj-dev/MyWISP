/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 27/01/2020
 * Time: 16:05
 * 
 * 
 */
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all Customers registered.
	/// </summary>
	public partial class FrmCustomers : Form
	{
		public FrmCustomers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		
		public Customer SelectedCustomer {get; set;}
		
		void FrmCustomersLoad(object sender, EventArgs e)
			{
				dgvCustomers.DataSource = CustomerBL.GetAllCustomers();
			}
		void BtnAddUserClick(object sender, EventArgs e)
		{
			FrmCustomerInformation frmaddcustomer = new FrmCustomerInformation();
			frmaddcustomer.Show();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnSearchCustomerClick(object sender, EventArgs e)
		{
			dgvCustomers.DataSource = CustomerBL.SearchCustomer(txtSeacrhCustomer.Text);
		}
		void BtnEditCustomerClick(object sender, EventArgs e)
		{
			if(dgvCustomers.SelectedRows.Count == 1)
			{
				String idcustomer = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);
				SelectedCustomer = CustomerBL.GetCustomer(idcustomer);
				FrmCustomerInformation frmcustomerinfo = new FrmCustomerInformation();
				frmcustomerinfo.CustomerSelected = SelectedCustomer;
				frmcustomerinfo.Show();
			}
			else
			{
				MessageBox.Show("Debe seleccionar una fila.", "Seleccionar Fila", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void BtnRefreshDataGridViewClick(object sender, EventArgs e)
		{
			dgvCustomers.DataSource = CustomerBL.GetAllCustomers();
		}
		
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		
		void BtnGenerateExcelCustomersClick(object sender, EventArgs e)
		{
			List<Customer> CustomerList = new List<Customer>();
			CustomerList = CustomerBL.GetAllCustomers();
			ExcelReport.GenerateCustomersExcel(CustomerList);
		}
		
	 
	}
}
