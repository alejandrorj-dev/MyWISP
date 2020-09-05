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
			ExcelReport.ExportServicesPlanExcel(ListServicePlan);
		}
		
		
	}
}
