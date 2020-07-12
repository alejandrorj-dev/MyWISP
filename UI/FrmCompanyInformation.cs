/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/14/2020
 * Time: 3:18 PM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using EL;
using BL;

namespace UI
{
	/// <summary>
	/// This form it allows to update information about Company.
	/// </summary>
	public partial class FrmCompanyInformation : Form
	{
		public FrmCompanyInformation()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Company CompanySaved {get; set;}
		private String ChosenImage {get; set;}
		
		
		private String GetCompanyLogo()
		{
			OpenFileDialog OpenFile = new OpenFileDialog{Filter = @"JPG (*.jpg)|*jpg|PNG (*.png)|*.png"};
			
			String nameFile;
			String safenamefile;
			String targetPath;
			String targetPathForSave = "";
			
			if(OpenFile.ShowDialog() == DialogResult.OK)
			{
				Image imageResolution = Image.FromFile(OpenFile.FileName);
				
				if((imageResolution.Width > 150) || (imageResolution.Height > 100))
				{
					MessageBox.Show("Ha escojido una imagen con mayor resolucion de lo requerido. Debe seleccionar una imagen de 150px X 100px como maximo.", "Resolucion de Imagen Mayor", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					nameFile = OpenFile.FileName;
					safenamefile = OpenFile.SafeFileName;
					targetPath = @"C:\Program Files\MyWISPSI\UI\Imgs\Logo\CompanyLogo\" + safenamefile;
					pcbLogoCompany.ImageLocation = nameFile;
					pcbLogoCompany.SizeMode = PictureBoxSizeMode.CenterImage;
										
						try
						{
							File.Copy(nameFile, targetPath, true);
						}
						catch(Exception e)
						{
							MessageBox.Show(e.Message, "Error al Adjuntar Logo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}					
					
					
					targetPathForSave = targetPath.Replace(@"\", @"\\");
					
				}
					
				
			}
			else
			{
				targetPathForSave = "";
			}
	
			return targetPathForSave;
		
		}
		

		void BtnUpdateCompanyClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtNIT.Text)) || (string.IsNullOrEmpty(txtNameCompany.Text)) || (string.IsNullOrEmpty(txtCity.Text)) || (string.IsNullOrEmpty(txtDepartment.Text)))
			{
				MessageBox.Show("Algunos campos requerido se encuentran vacios. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error al Editar Informacion de la Empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Company MyCompany = new Company();
				MyCompany.NIT = txtNIT.Text;
				MyCompany.Name = txtNameCompany.Text;
				MyCompany.City = txtCity.Text;
				MyCompany.Department = txtDepartment.Text;
				MyCompany.Address = txtAddress.Text;
				MyCompany.Phone = txtPhone.Text;
				MyCompany.E_mail = txtEmail.Text;
				MyCompany.Website = txtWebsite.Text;
				MyCompany.Image = ChosenImage;
				
				String idCompany = Convert.ToString(CompanySaved.NIT);
				
				if(CompanyBL.EditCompanyInformation(MyCompany, idCompany) > 0)
				{
					MessageBox.Show("La informacion de la empresa ha sido actualizada correctamente.", "Informacion de la empresa actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("La informacion de la empresa no ha sido actualizada, ha ocurrido un error.", "Informacion de la Empresa no Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void FrmCompanyInformationLoad(object sender, EventArgs e)
		{
			
			
			if(CompanySaved != null)
			{
				txtNIT.Text = CompanySaved.NIT;
				txtNameCompany.Text = CompanySaved.Name;
				txtCity.Text = CompanySaved.City;
				txtDepartment.Text = CompanySaved.Department;
				txtAddress.Text = CompanySaved.Address;
				txtPhone.Text = CompanySaved.Phone;
				txtEmail.Text = CompanySaved.E_mail;
				txtWebsite.Text = CompanySaved.Website;
				pcbLogoCompany.ImageLocation = CompanySaved.Image;
				pcbLogoCompany.SizeMode = PictureBoxSizeMode.CenterImage;
				
				
				String TwoBackSlash = @"\\";
				String BackSlash = @"\";
				
				
				ChosenImage = CompanySaved.Image.Replace(BackSlash, TwoBackSlash);
				
			}
			
			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnAttachImgClick(object sender, EventArgs e)
		{
			ChosenImage = GetCompanyLogo();
		}
	}
}
