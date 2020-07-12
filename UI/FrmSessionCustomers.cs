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
			ExportSessionCustomersExcel(ListSessionCustomers);
		}
		
		void ExportSessionCustomersExcel(List<Session_Customer> ListSessionCustomers)
			{
				SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Clientes de Sesion Registrados"};
				
				
				if(File.ShowDialog() == DialogResult.OK)
				{
					Excel.Application ExcelApp = new Excel.Application();
					Excel.Workbook ExcelBook = ExcelApp.Workbooks.Add();
					Excel.Worksheet ExcelSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelBook.Sheets["Hoja1"];
					Excel.Pictures MyLogo = (Microsoft.Office.Interop.Excel.Pictures)ExcelSheet.Pictures(System.Reflection.Missing.Value);
					DateTime DateNow = DateTime.Now;
					
					Company MyCompany = CompanyBL.GetInformationCompany();
					
					String Logo = Convert.ToString(MyCompany.Image);
					
					MyLogo.Insert(Logo, ExcelSheet.Cells[1, "A"]);								
					
					
					ExcelSheet.Cells[1, "C"] = MyCompany.Name + "\r\n NIT: " + MyCompany.NIT + "\r\n" + MyCompany.City + " - " + MyCompany.Department + "\r\n Telefono: " + MyCompany.Phone + "\r\n E-mail: " + MyCompany.E_mail + "\r\n" + MyCompany.Website;
					ExcelSheet.Range["A1", "I1"].Merge();
					ExcelSheet.Range["A1", "I1"].Font.Bold = true;
					ExcelSheet.Range["A1", "I1"].Font.Size = 12;
					
					ExcelSheet.Range["A2", "I1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					ExcelSheet.Range["A2", "I1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A1", "I1"].RowHeight = 110;
					
					
					ExcelSheet.Cells[2, "D"] = "Listado de Clientes de Sesion Registrados - ["+DateNow+"]";
					ExcelSheet.Range["A2", "I2"].Merge();
					ExcelSheet.Range["A2", "I2"].Font.Bold = true;
					ExcelSheet.Range["A2", "I2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A3", "H3"].Font.Bold = true;
					ExcelSheet.Cells[3, "A"] = "Identificacion";
					ExcelSheet.Cells[3, "B"] = "Nombre Completo";
					ExcelSheet.Cells[3, "C"] = "Telefono";
					ExcelSheet.Cells[3, "D"] = "E-mail";
					ExcelSheet.Cells[3, "E"] = "Usuario";
					ExcelSheet.Cells[3, "F"] = "Password";
					ExcelSheet.Cells[3, "G"] = "Fecha de Adquisicion";
					ExcelSheet.Cells[3, "H"] = "Estado";
					ExcelSheet.Cells[3, "I"] = "Observaciones";
					
					int row = 3;
					foreach(var sessioncustomer in ListSessionCustomers)
					{
						row++;
						ExcelSheet.Cells[row, "A"] = sessioncustomer.idSessionCustomer;
						ExcelSheet.Cells[row, "B"] = sessioncustomer.Full_Name;
						ExcelSheet.Cells[row, "C"] = sessioncustomer.Phone;
						ExcelSheet.Cells[row, "D"] = sessioncustomer.E_mail;
						ExcelSheet.Cells[row, "E"] = sessioncustomer.User_Session;
						ExcelSheet.Cells[row, "F"] = sessioncustomer.Password_session;
						ExcelSheet.Cells[row, "G"] = sessioncustomer.Date_aquisition;
						ExcelSheet.Cells[row, "H"] = sessioncustomer.Status_session;
						ExcelSheet.Cells[row, "I"] = sessioncustomer.Remarks;
						
					}
					
					ExcelSheet.Columns.AutoFit();
					
					ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
					
					ExcelApp.Quit();
				
					GC.Collect();
				} 
			}


	}
}
