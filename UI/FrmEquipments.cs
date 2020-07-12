/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 05/03/2020
 * Time: 5:16 p. m.
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using EL;
using BL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all Equipments registered.
	/// </summary>
	public partial class FrmEquipments : Form
	{
		public FrmEquipments()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			if(VerifytxtSearchEmpty() == true)
			{
				LoadEquipmentsInDataTable();
			}
		}
		
		DataTable DataTableResults = new DataTable();
		
		public Equipment EquipmentSelected {get; set;}
			
		void BtnAddNewClick(object sender, EventArgs e)
		{
			FrmAddEquipment frmaddequipment = new FrmAddEquipment();
			frmaddequipment.ShowDialog();
		}
		void FrmEquipmentsLoad(object sender, EventArgs e)
		{
			//dgvEquipments.DataSource = EquipmentBL.GetAllEquipments();
		}

		void BtnEditClick(object sender, EventArgs e)
		{
			if(dgvEquipments.SelectedRows.Count == 1)
			{
				String IdEquipment = Convert.ToString(dgvEquipments.CurrentRow.Cells[0].Value);
				EquipmentSelected = EquipmentBL.GetEquipment(IdEquipment);
				FrmEditEquipment frmeditequipment = new FrmEditEquipment();
				frmeditequipment.EquipmentChosen = EquipmentSelected;
				frmeditequipment.ShowDialog();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un equipo para actualizar.", "Seleccione Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void LoadEquipmentsInDataTable()
		{
			List<Equipment> ListEquipmentsForDataTable = EquipmentBL.GetAllEquipments();
			DataTableResults.Columns.Add("MAC");
			DataTableResults.Columns.Add("Name");
			DataTableResults.Columns.Add("Brand");
			DataTableResults.Columns.Add("Type");
			DataTableResults.Columns.Add("IP");
			DataTableResults.Columns.Add("Frecuency");
			DataTableResults.Columns.Add("Firmware_version");
			DataTableResults.Columns.Add("Ubication");
			DataTableResults.Columns.Add("Date_instalation");
			DataTableResults.Columns.Add("Remarks");
			
			foreach(var Equipments in ListEquipmentsForDataTable)
			{
				DataTableResults.Rows.Add(Equipments.MAC, Equipments.Name, Equipments.Brand, Equipments.Type, Equipments.IP, Equipments.Frecuency, Equipments.Firmware_version, Equipments.Ubication, Equipments.Date_instalation, Equipments.Remarks);
			}
			
			dgvEquipments.DataSource = DataTableResults;
			
		}
		
		void ReloadEquipmentsInDataTable()
		{
			DataTableResults.Clear();
			
			List<Equipment> ListEquipmentsForDataTable = EquipmentBL.GetAllEquipments();
			
			foreach(var Equipments in ListEquipmentsForDataTable)
			{
				DataTableResults.Rows.Add(Equipments.MAC, Equipments.Name, Equipments.Brand, Equipments.Type, Equipments.IP, Equipments.Frecuency, Equipments.Firmware_version, Equipments.Ubication, Equipments.Date_instalation, Equipments.Remarks);
			}
			
			dgvEquipments.DataSource = DataTableResults;			
		}
		Boolean VerifytxtSearchEmpty()
		{
			if(string.IsNullOrEmpty(txtSearchEquipment.Text))
			{
				return true;
			}
			
			return false;
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnDeleteClick(object sender, EventArgs e)
		{
			if(dgvEquipments.SelectedRows.Count == 1)
			{
				if(MessageBox.Show("¿Está seguro de eliminar este equipo y toda su información?", "Eliminar Equipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					String idEquipment = Convert.ToString(dgvEquipments.CurrentRow.Cells[0].Value);
					if(EquipmentBL.DeleteEquipment(idEquipment) > 0)
					{
						MessageBox.Show("El equipo y toda su informacion han sido eliminados correctamente.","Equipo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ReloadEquipmentsInDataTable();
					}
					else
					{
						MessageBox.Show("El equipo y su informacion aun no han sido eliminados, ha ocurrido un error.", "Equipo no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Debe seleccionar un equipo para eliminar.", "Seleccione un Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void TxtSearchEquipmentKeyPress(object sender, KeyPressEventArgs e)
		{
			DataTableResults.DefaultView.RowFilter = string.Format("MAC like '{0}%' or Name like '{0}%' or Brand like '{0}%' or Type like '{0}%' or IP like '{0}%' or Frecuency like '{0}%' or Firmware_version like '{0}%' or Ubication like '{0}%' or Date_instalation like '{0}%' or Remarks like '{0}%'", txtSearchEquipment.Text);
		}
		void BtnSearchEquipmentClick(object sender, EventArgs e)
		{
			DataTableResults.DefaultView.RowFilter = string.Format("MAC like '{0}%' or Name like '{0}%' or Brand like '{0}%' or Type like '{0}%' or IP like '{0}%' or Frecuency like '{0}%' or Firmware_version like '{0}%' or Ubication like '{0}%' or Date_instalation like '{0}%' or Remarks like '{0}%'", txtSearchEquipment.Text);
		}
		
		void ExportEquipmetsExcel(List<Equipment> ListEquipments)
			{
				SaveFileDialog File = new SaveFileDialog{Filter = @"Excel (*.xls)|*.xls", FileName = "My WISP S. I. - Equipos Registrados"};
				
				
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
					
					
					ExcelSheet.Cells[2, "D"] = "Listado de Equipos Registrados - ["+DateNow+"]";
					ExcelSheet.Range["A2", "J2"].Merge();
					ExcelSheet.Range["A2", "J2"].Font.Bold = true;
					ExcelSheet.Range["A2", "J2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
					
					ExcelSheet.Range["A3", "J3"].Font.Bold = true;
					ExcelSheet.Cells[3, "A"] = "MAC";
					ExcelSheet.Cells[3, "B"] = "Nombre Asignado";
					ExcelSheet.Cells[3, "C"] = "Marca";
					ExcelSheet.Cells[3, "D"] = "Tipo de Dispositivo";
					ExcelSheet.Cells[3, "E"] = "Dirección IP";
					ExcelSheet.Cells[3, "F"] = "Frecuencia";
					ExcelSheet.Cells[3, "G"] = "Versión de Firmware";
					ExcelSheet.Cells[3, "H"] = "Ubicacion";
					ExcelSheet.Cells[3, "I"] = "Fecha de Instalación";
					ExcelSheet.Cells[3, "J"] = "Observaciones";
					
					int row = 3;
					foreach(var equipments in ListEquipments)
					{
						row++;
						ExcelSheet.Cells[row, "A"] = equipments.MAC;
						ExcelSheet.Cells[row, "B"] = equipments.Name;
						ExcelSheet.Cells[row, "C"] = equipments.Brand;
						ExcelSheet.Cells[row, "D"] = equipments.Type;
						ExcelSheet.Cells[row, "E"] = equipments.IP;
						ExcelSheet.Cells[row, "F"] = equipments.Frecuency;
						ExcelSheet.Cells[row, "G"] = equipments.Firmware_version;
						ExcelSheet.Cells[row, "H"] = equipments.Ubication;
						ExcelSheet.Cells[row, "I"] = equipments.Date_instalation;
						ExcelSheet.Cells[row, "J"] = equipments.Remarks;
						
					}
					
					ExcelSheet.Columns.AutoFit();
					
					ExcelBook.SaveAs(File.FileName, Excel.XlFileFormat.xlAddIn);
					
					ExcelApp.Quit();
				
					GC.Collect();
				} 
			}
		void BtnExportToExcelClick(object sender, EventArgs e)
		{
			List<Equipment> ListEquipmentsReceived = new List<Equipment>();
			ListEquipmentsReceived = EquipmentBL.GetAllEquipments();
			ExportEquipmetsExcel(ListEquipmentsReceived);
		}
		void BtnRefreshClick(object sender, EventArgs e)
		{
			ReloadEquipmentsInDataTable();
		}
	}
}
