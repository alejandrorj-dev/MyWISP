/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/26/2020
 * Time: 5:16 PM
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
	/// This form it allows to add information about Point of Sale.
	/// </summary>
	public partial class FrmAddPointOfSale : Form
	{
		public FrmAddPointOfSale()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnSavePointOfSaleClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtNamePointOfSale.Text)) || (string.IsNullOrEmpty(txtDepartment.Text)) || (string.IsNullOrEmpty(txtMunicipality.Text)) || (string.IsNullOrEmpty(txtAddress.Text)) || (string.IsNullOrEmpty(txtNameOwner.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que todos los campos marcados con (*) se encuentren llenos.", "Campos Requeridos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Point_of_Sale NewPointOfSale = new Point_of_Sale();
				NewPointOfSale.NamePoint = txtNamePointOfSale.Text;
				NewPointOfSale.Department = txtDepartment.Text;
				NewPointOfSale.Municipality = txtMunicipality.Text;
				NewPointOfSale.Address = txtAddress.Text;
				NewPointOfSale.NameOwner = txtNameOwner.Text;
				NewPointOfSale.Phone = txtPhone.Text;
				NewPointOfSale.E_mail = txtEmail.Text;
				NewPointOfSale.AmountCodes = txtAmountCodes.Text;
				NewPointOfSale.PrefixCode = txtPrefix.Text;
				
				if(Point_of_SaleBL.AddPointOfSale(NewPointOfSale) > 0)
				{
					MessageBox.Show("El punto de venta ha sido agregado con exito.", "Punto de Venta Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Cleaner();
				}
				else
				{
					MessageBox.Show("El punto de venta aun no ha sido agregado, ha ocurrido un error.", "Punto de Venta no Agergado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		
		void Cleaner()
		{
			txtNamePointOfSale.Clear();
			txtDepartment.Clear();
			txtMunicipality.Clear();
			txtAddress.Clear();
			txtNameOwner.Clear();
			txtPhone.Clear();
			txtEmail.Clear();
			txtAmountCodes.Clear();
			txtPrefix.Clear();
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
