/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 04/02/2020
 * Time: 15:13
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
	/// This form it allows to update information about Service Plan.
	/// </summary>
	public partial class FrmEditService : Form
	{
		public FrmEditService()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Service_Plan ServiceSelected {get; set;}
		void BtnEditServiceClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtIdService.Text)) || (string.IsNullOrEmpty(txtNameService.Text)) || (string.IsNullOrEmpty(txtPriceService.Text)) || (string.IsNullOrEmpty(rtbDescription.Text)))
			{
				MessageBox.Show("Algunos campos requeridos no estan llenos. Por favor, verifique que los campos marcados com (*) se encuentren llenos.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				
					double numberDouble;
					if(Double.TryParse(txtPriceService.Text, out numberDouble))
					{
						Service_Plan pServicePlan = new Service_Plan();
						pServicePlan.Id = txtIdService.Text;
						pServicePlan.Name_Plan = txtNameService.Text;
						pServicePlan.Price_Plan = numberDouble;
						pServicePlan.Description = rtbDescription.Text;
						
						String idService = Convert.ToString(ServiceSelected.Id);
						
						if((Service_PlanBL.EditServicePlan(pServicePlan, idService)) > 0)
						{
							MessageBox.Show("El plan de servicio ha sido editado exitosamente.", "Plan de Servicio Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							FrmServices frmservices = new FrmServices();
							frmservices.RefreshdgvServices();
							this.Close();
						}
						else
						{
							MessageBox.Show("El plan de servicio no ha sido editado, ha ocurrido un error. Es probable que esté siendo usado en alguna instalación de un cliente.", "Error al Editar Plan de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
					}
					else
					{
						MessageBox.Show("Solo debe ingresarse numeros en el campo de precio. Por favor, ingrese solo numeros en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				
				
				
			}
		}
		
		void FrmEditServiceLoad(object sender, EventArgs e)
		{
						
			txtIdService.Text = ServiceSelected.Id;
			txtNameService.Text = ServiceSelected.Name_Plan;
			txtPriceService.Text = Convert.ToString(ServiceSelected.Price_Plan);
			rtbDescription.Text = ServiceSelected.Description;
			
			//txtIdService.Enabled = false;
			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
