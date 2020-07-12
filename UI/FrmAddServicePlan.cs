/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 29/01/2020
 * Time: 15:33
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
	/// This form it allows to add information about Service Plan.
	/// </summary>
	public partial class FrmAddServicePlan : Form
	{
		public FrmAddServicePlan()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void BtnSaveServiceClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtIdService.Text)) || (string.IsNullOrEmpty(txtNamePlan.Text)) || (string.IsNullOrEmpty(txtPricePlan.Text)) || (string.IsNullOrEmpty(rtbDescriptionPlan.Text)))
			{
				MessageBox.Show("Algún campo ha quedado vacío. Por favor, verifique que los campos marcados con (*) estén llenos.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if((Service_PlanBL.validateReferenceServiceExistence(txtIdService.Text)) > 0)
				{
					MessageBox.Show("La referencia del plan de servicio ya existe. Por favor, ingrese una referencia de plan de servicio diferente.", "Referencia ya Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					
					double numberDouble;
					
					if(Double.TryParse(txtPricePlan.Text, out numberDouble))
					{
						Service_Plan pService_Plan = new Service_Plan();
						pService_Plan.Id = txtIdService.Text;
						pService_Plan.Name_Plan = txtNamePlan.Text;
						pService_Plan.Price_Plan = numberDouble;
						pService_Plan.Description = rtbDescriptionPlan.Text;
						
						if((Service_PlanBL.AddService_Plan(pService_Plan)) > 0)
						{
							MessageBox.Show("El plan de servicio ha sido guardado exitosamente.", "Plan de Servicio Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Cleaner();
						}
						else
						{
							MessageBox.Show("El plan de servicio no ha sido guardado, ha ocurrido un error", "Plan de Servicio no Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}					
					
					}
					else
					{
						MessageBox.Show("Sólo se admiten números en el campo de precio. Por favor, verifique que el formato de entrada sea el correcto.", "Error al Ingresar Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
					
				}
			}
		}
		
		void Cleaner()
		{
			txtIdService.Clear();
			txtNamePlan.Clear();
			txtPricePlan.Clear();
			rtbDescriptionPlan.Clear();
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
	}
}
