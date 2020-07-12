/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/27/2020
 * Time: 3:52 PM
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
	/// This form it allows to update information about Point Of Sale.
	/// </summary>
	public partial class FrmEditPointOfSale : Form
	{
		public FrmEditPointOfSale()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Point_of_Sale PointOfSaleChosen {get; set;}
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtNamePoint.Text)) || (string.IsNullOrEmpty(txtDepartment.Text)) || (string.IsNullOrEmpty(txtMunicipality.Text)) || (string.IsNullOrEmpty(txtAddress.Text)) || (string.IsNullOrEmpty(txtNameOwner.Text)))
			{
				MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Point_of_Sale PointOfSaleForUpdate = new Point_of_Sale();
				PointOfSaleForUpdate.NamePoint = txtNamePoint.Text;
				PointOfSaleForUpdate.Department = txtDepartment.Text;
				PointOfSaleForUpdate.Municipality = txtMunicipality.Text;
				PointOfSaleForUpdate.Address = txtAddress.Text;
				PointOfSaleForUpdate.NameOwner = txtNameOwner.Text;
				PointOfSaleForUpdate.Phone = txtPhone.Text;
				PointOfSaleForUpdate.E_mail = txtEmail.Text;
				PointOfSaleForUpdate.AmountCodes = txtAmountCodes.Text;
				PointOfSaleForUpdate.PrefixCode = txtPrefix.Text;
				
				int idPointOfSale = Convert.ToInt32(txtIdPOS.Text);
				if(Point_of_SaleBL.EditPointOfSale(PointOfSaleForUpdate, idPointOfSale) > 0)
				{
					MessageBox.Show("La informacion del punto de venta ha sido actualizada con exito.", "Informacion de Punto de Venta Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("La informacion del punto de venta aun no ha sido actualizada, ha ocurrido un error.", "Informacion de Punto de Venta no Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void FrmEditPointOfSaleLoad(object sender, EventArgs e)
		{
			if(PointOfSaleChosen != null)
			{
				txtIdPOS.Text = Convert.ToString(PointOfSaleChosen.IdPointOfSale);
				txtNamePoint.Text = PointOfSaleChosen.NamePoint;
				txtDepartment.Text = PointOfSaleChosen.Department;
				txtMunicipality.Text = PointOfSaleChosen.Municipality;
				txtAddress.Text = PointOfSaleChosen.Address;
				txtNameOwner.Text = PointOfSaleChosen.NameOwner;
				txtPhone.Text = PointOfSaleChosen.Phone;
				txtEmail.Text = PointOfSaleChosen.E_mail;
				txtAmountCodes.Text = PointOfSaleChosen.AmountCodes;
				txtPrefix.Text = PointOfSaleChosen.PrefixCode;
				
			}
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
