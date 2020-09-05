/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/21/2020
 * Time: 6:35 PM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all Session Customers registered.
	/// </summary>
	public partial class FrmSessionCustomers : Form
	{
		public FrmSessionCustomers()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Session_Customer SessionCustomerSelected {get; set;}
		void BtnAddNewClick(object sender, EventArgs e)
		{
			FrmAddSessionCustomer frmaddsessioncustomer = new FrmAddSessionCustomer();
			frmaddsessioncustomer.ShowDialog();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void FrmSessionCustomersLoad(object sender, EventArgs e)
		{
			dgvSessionCustomers.DataSource = Session_CustomerBL.GetAllSessionCustomers();
		}
		void BtnRefreshDgvClick(object sender, EventArgs e)
		{
			dgvSessionCustomers.DataSource = Session_CustomerBL.GetAllSessionCustomers();
		}
		void BtnEditClick(object sender, EventArgs e)
		{
			if(dgvSessionCustomers.SelectedRows.Count == 1)
			{
				FrmEditSessionCustomer frmeditsessioncustomer = new FrmEditSessionCustomer();
				String idCustomer = Convert.ToString(dgvSessionCustomers.CurrentRow.Cells[0].Value);
				SessionCustomerSelected = Session_CustomerBL.GetSessionCustomerById(idCustomer);
				frmeditsessioncustomer.SessionCustomerChosen = SessionCustomerSelected;
				frmeditsessioncustomer.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un cliente de sesion.", "Seleccione un Cliente de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(dgvSessionCustomers.SelectedRows.Count == 1)
			{
				if(MessageBox.Show("Esta seguro de eliminar este cliente de sesion y toda su informacion?", "Eliminar Cliente de Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					String idSessionCustomer = Convert.ToString(dgvSessionCustomers.CurrentRow.Cells[0].Value);
					if(Session_CustomerBL.DeleteSessionCustomer(idSessionCustomer) > 0)
					{
						MessageBox.Show("El cliente de sesion ha sido eliminado exitosamente.", "Eliminacion de Cliente de Sesion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("El cliente de sesion aun no ha sido eliminado, ha ocurrido un error.", "Cliente de Sesion no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Debe seleccionar un cliente de sesion.", "Seleccione un Cliente de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnSearchSessionCustomerClick(object sender, EventArgs e)
		{
			dgvSessionCustomers.DataSource = Session_CustomerBL.SearchSessionCustomer(txtSearchSessionCustomer.Text);
		}
		void BtnExportToExcelClick(object sender, EventArgs e)
		{
			List<Session_Customer> ListSessionCustomers = new List<Session_Customer>();
			ListSessionCustomers = Session_CustomerBL.GetAllSessionCustomers();
			ExcelReport.ExportSessionCustomersExcel(ListSessionCustomers);
		}
		


	}
}
