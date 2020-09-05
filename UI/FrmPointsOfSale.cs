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
			ExcelReport.ExportPointOfSaleExcel(ListPointsOfSale);
		}
		
		
	}
}
