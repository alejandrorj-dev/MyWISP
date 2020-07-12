/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/10/2020
 * Time: 11:16 AM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to show all Services Plan registered and select it for add in field Service Plan in FrmCustomerInformation in zone Instalations.
	/// </summary>
	public partial class FrmServicesAux : Form
	{
		public FrmServicesAux()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSearchServiceClick(object sender, EventArgs e)
		{
			dgvServices.DataSource = Service_PlanBL.SearchServicePlan(txtSearchPlan.Text);
		}
		void FrmServicesAuxLoad(object sender, EventArgs e)
		{
			dgvServices.DataSource = Service_PlanBL.GetAllServices();
		}
		void BtnAcceptClick(object sender, EventArgs e)
		{
			if(dgvServices.SelectedRows.Count == 1)
			{
				String idService = Convert.ToString(dgvServices.CurrentRow.Cells[0].Value);
				Clipboard.SetText(idService);
				this.Close();
			}
			else
			{
				MessageBox.Show("Debe seleccionar un plan de servicio", "Seleccionar Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
