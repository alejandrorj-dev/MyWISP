/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 03/02/2020
 * Time: 10:25
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
	/// This form it allows to show all Services Plan.
	/// </summary>
	public partial class FrmServices : Form
	{
		
		public FrmServices()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Service_Plan ServicePlanSelected {get; set;}
		
		public void RefreshdgvServices()
		{
			dgvServices.DataSource = Service_PlanBL.GetAllServices();
			dgvServices.Refresh();
		}
		
		void BtnAddNewClick(object sender, EventArgs e)
		{
			FrmAddServicePlan frmaddservice = new FrmAddServicePlan();
			frmaddservice.ShowDialog();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void FrmServicesLoad(object sender, EventArgs e)
		{
			RefreshdgvServices();
		}
		
		void BtnSearchPlanClick(object sender, EventArgs e)
		{
			dgvServices.DataSource = Service_PlanBL.SearchServicePlan(txtSearchService.Text);
		}
		void BtnDeleteServiceClick(object sender, EventArgs e)
		{
			
			if(dgvServices.SelectedRows.Count == 1)
			{
			
				if((MessageBox.Show("¿Está seguro de eliminar el plan de servicio?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
					{
						String idService = Convert.ToString(dgvServices.CurrentRow.Cells[0].Value);
						
						if((Service_PlanBL.DeleteServicePlan(idService)) > 0)
						{
							MessageBox.Show("El plan de servicio ha sido eliminado correctamente.", "Plan de Servicio Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							RefreshdgvServices();
						}
						else
						{
							MessageBox.Show("El plan de servicio aún no ha sido eliminado, ha surgido un error. Es probable que esté siendo utilizado en alguna instalación de un cliente.", "Error al Eliminar Plan de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
					}
					else
					{
						MessageBox.Show("Se ha cancelado la eliminación del plan de servicio.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
			
			
			}
			else
			{
				MessageBox.Show("Por favor, seleccione un plan de servicio.", "Seleccionar Plan de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			
		}
		
		void BtnEditServiceClick(object sender, EventArgs e)
		{
			if(dgvServices.SelectedRows.Count == 1)
			{
				String idService = Convert.ToString(dgvServices.CurrentRow.Cells[0].Value);
				ServicePlanSelected = Service_PlanBL.GetServiceById(idService);
				FrmEditService frmeditservice = new FrmEditService();
				frmeditservice.ServiceSelected = ServicePlanSelected;
				frmeditservice.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un plan de servicio", "Seleccionar Plan de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnUpdatedgvClick(object sender, EventArgs e)
		{
			RefreshdgvServices();
		}
		void BtnExportToExcelClick(object sender, EventArgs e)
		{
			List<Service_Plan> ListServicePlan = new List<Service_Plan>();
			ListServicePlan = Service_PlanBL.GetAllServices();
			ExportServicesPlanExcel(ListServicePlan);
		}
		
		void ExportServicesPlanExcel(List<Service_Plan> ListServicesPlan)
		{
			SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Planes de Servicio Registrados"};
			
			
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
				ExcelSheet.Range["A1", "D1"].Merge();
				ExcelSheet.Range["A1", "D1"].Font.Bold = true;
				ExcelSheet.Range["A1", "D1"].Font.Size = 12;
				
				ExcelSheet.Range["A2", "D1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				ExcelSheet.Range["A2", "D1"].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A1", "D1"].RowHeight = 110;
				
				
				ExcelSheet.Cells[2, "D"] = "Planes de Servicio Registrados - ["+DateNow+"]";
				ExcelSheet.Range["A2", "D2"].Merge();
				ExcelSheet.Range["A2", "D2"].Font.Bold = true;
				ExcelSheet.Range["A2", "D2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				
				ExcelSheet.Range["A3", "D3"].Font.Bold = true;
				ExcelSheet.Cells[3, "A"] = "Referencia";
				ExcelSheet.Cells[3, "B"] = "Nombre del Plan";
				ExcelSheet.Cells[3, "C"] = "Precio (CO)";
				ExcelSheet.Cells[3, "D"] = "Descripcion";
	
				
				int row = 3;
				foreach(var serviceplan in ListServicesPlan)
				{
					row++;
					ExcelSheet.Cells[row, "A"] = serviceplan.Id;
					ExcelSheet.Cells[row, "B"] = serviceplan.Name_Plan;
					ExcelSheet.Cells[row, "C"] = "$"+serviceplan.Price_Plan;
					ExcelSheet.Cells[row, "D"] = serviceplan.Description;
				}
				
				ExcelSheet.Columns.AutoFit();
				
				ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
				
				ExcelApp.Quit();
				
				GC.Collect();
				
			} 
		} 
		
		
	}
}
