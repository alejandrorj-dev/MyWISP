/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/26/2020
 * Time: 4:55 PM
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
	/// This form it allows to show all Points Of Sale registered.
	/// </summary>
	public partial class FrmPointsOfSale : Form
	{
		public FrmPointsOfSale()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Point_of_Sale PointOfSaleSelected {get; set;}
		
		void BtnAddNewClick(object sender, EventArgs e)
		{
			FrmAddPointOfSale frmaddpointofsale = new FrmAddPointOfSale();
			frmaddpointofsale.ShowDialog();
		}
		void FrmPointsOfSaleLoad(object sender, EventArgs e)
		{
			dgvPointsOfSale.DataSource = Point_of_SaleBL.GetAllPointsOfSale();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnEditClick(object sender, EventArgs e)
		{
			if(dgvPointsOfSale.SelectedRows.Count == 1)
			{
				int idPointOfSaleSelected = Convert.ToInt32(dgvPointsOfSale.CurrentRow.Cells[0].Value);
				PointOfSaleSelected = Point_of_SaleBL.GetPointOfSale(idPointOfSaleSelected);
				FrmEditPointOfSale frmeditpointofsale = new FrmEditPointOfSale();
				frmeditpointofsale.PointOfSaleChosen = PointOfSaleSelected;
				frmeditpointofsale.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un punto de venta para actualizar.", "Seleccione Punto de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void BtnRefreshClick(object sender, EventArgs e)
		{
			dgvPointsOfSale.DataSource = Point_of_SaleBL.GetAllPointsOfSale();
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(dgvPointsOfSale.SelectedRows.Count == 1)
			{
				if(MessageBox.Show("Esta seguro de eliminar este punto de venta y toda su informacion?", "Eliminar Punto de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int idPOS = Convert.ToInt32(dgvPointsOfSale.CurrentRow.Cells[0].Value);
					if(Point_of_SaleBL.DeletePointOfSale(idPOS) > 0)
					{
						MessageBox.Show("El punto de venta y su informacion han sido eliminados exitosamente.", "Punto de Venta Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("El punto de venta y su informacion aun no han sido eliminados, ha ocurrido un error.", "Punto de Venta no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		void BtnSearchPointOfSaleClick(object sender, EventArgs e)
		{
			dgvPointsOfSale.DataSource = Point_of_SaleBL.SearchPointOfSale(txtSearchPointOfSale.Text);
		}
		void BtnExportToExcelClick(object sender, EventArgs e)
		{
			List<Point_of_Sale> ListPointsOfSale = new List<Point_of_Sale>();
			ListPointsOfSale = Point_of_SaleBL.GetAllPointsOfSale();
			ExportPointOfSaleExcel(ListPointsOfSale);
		}
		
		void ExportPointOfSaleExcel(List<Point_of_Sale> ListPointsOfSale)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Puntos de Venta Registrados"};
			
			
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
				ExcelSheet.Range["A1", "J1"].Merge();
				ExcelSheet.Range["A1", "J1"].Font.Bold = true;
				ExcelSheet.Range["A1", "J1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "J1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "J1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "J1"].RowHeight = 110;
				
				
				ExcelSheet.Cells[2, "D"] = "Listado de Puntos de Venta Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "J2"].Merge();
				ExcelSheet.Range["A2", "J2"].Font.Bold = true;
				ExcelSheet.Range["A2", "J2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "J3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Id Punto de Venta";
				ExcelSheet.Cells[3, "B"] = "Nombre";
				ExcelSheet.Cells[3, "C"] = "Departamento";
				ExcelSheet.Cells[3, "D"] = "Municipio";
				ExcelSheet.Cells[3, "E"] = "Direccion";
				ExcelSheet.Cells[3, "F"] = "Nombre del Encargado";
				ExcelSheet.Cells[3, "G"] = "Telefono";
				ExcelSheet.Cells[3, "H"] = "E-mail";
				ExcelSheet.Cells[3, "I"] = "Cantidad de Pines Actual";
				ExcelSheet.Cells[3, "J"] = "Prefijo Actual";
				
				int row = 3;
				foreach(var pointofsale in ListPointsOfSale)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = pointofsale.IdPointOfSale;
					ExcelSheet.Cells[row, "B"] = pointofsale.NamePoint;
					ExcelSheet.Cells[row, "C"] = pointofsale.Department;
					ExcelSheet.Cells[row, "D"] = pointofsale.Municipality;
					ExcelSheet.Cells[row, "E"] = pointofsale.Address;
					ExcelSheet.Cells[row, "F"] = pointofsale.NameOwner;
					ExcelSheet.Cells[row, "G"] = pointofsale.Phone;
					ExcelSheet.Cells[row, "H"] = pointofsale.E_mail;
					ExcelSheet.Cells[row, "I"] = pointofsale.AmountCodes;
					ExcelSheet.Cells[row, "J"] = pointofsale.PrefixCode;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
			} 
		} 
	}
}
