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
			GenerateCustomersExcel(CustomerList);
		}
		
	void GenerateCustomersExcel(List<Customer> ListCustomers)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Clientes Registrados"};
			
			
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
				
				
				ExcelSheet.Cells[2, "D"] = "Listado de Clientes Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "I2"].Merge();
				ExcelSheet.Range["A2", "I2"].Font.Bold = true;
				ExcelSheet.Range["A2", "I2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "I3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Identificacion";
				ExcelSheet.Cells[3, "B"] = "Nombre Completo";
				ExcelSheet.Cells[3, "C"] = "Municipio";
				ExcelSheet.Cells[3, "D"] = "Departamento";
				ExcelSheet.Cells[3, "E"] = "Direccion";
				ExcelSheet.Cells[3, "F"] = "Telefono";
				ExcelSheet.Cells[3, "G"] = "E-mail";
				ExcelSheet.Cells[3, "H"] = "Estado";
				ExcelSheet.Cells[3, "I"] = "Observaciones";
				
				
				
				int row = 3;
				foreach(var customer in ListCustomers)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = customer.idCustomer;
					ExcelSheet.Cells[row, "B"] = customer.Full_Name;
					ExcelSheet.Cells[row, "C"] = customer.Municipality;
					ExcelSheet.Cells[row, "D"] = customer.Department;
					ExcelSheet.Cells[row, "E"] = customer.Address;
					ExcelSheet.Cells[row, "F"] = customer.Phone;
					ExcelSheet.Cells[row, "G"] = customer.E_mail;
					ExcelSheet.Cells[row, "H"] = customer.Status;
					ExcelSheet.Cells[row, "I"] = customer.Remark;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			} 
		} 
	}
}
