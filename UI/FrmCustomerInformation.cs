/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 27/01/2020
 * Time: 17:04
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using BL;
using EL;

namespace UI
{
	/// <summary>
	/// This form it allows to add and update information about Customer, and it allows to add, get, updating and deleting information about Customer's Instalations and Devices.
	/// </summary>
	public partial class FrmCustomerInformation : Form
	{
		public FrmCustomerInformation()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Customer CustomerSelected {get; set;}
		private List<Instalation> InstalationCustomer {get; set;}
		
		void BtnSaveCustomerClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtidCustomer.Text)) || (string.IsNullOrEmpty(txtFullNameCustomer.Text)) || (string.IsNullOrEmpty(txtMunicipality.Text)) || (string.IsNullOrEmpty(txtDepartment.Text)) || (string.IsNullOrEmpty(txtAddress.Text)) || (string.IsNullOrEmpty(cboStatusCustomer.Text)))
			{
				MessageBox.Show("Algún campo obligatorio está vacío. Por favor, verifique que los campos marcados con (*) no estén vacíos.", "Campo Requerido Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				
				if(CustomerBL.verifyCustomerExistence(txtidCustomer.Text) > 0)
				{
					MessageBox.Show("la identificacion del cliente ingresado ya existe. Por favor, verifique si el cliente ya esta registrado.", "Identificacion de Cliente Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				else
				{
					Customer pCustomer = new Customer();
					pCustomer.idCustomer = txtidCustomer.Text;
					pCustomer.Full_Name = txtFullNameCustomer.Text;
					pCustomer.Municipality = txtMunicipality.Text;
					pCustomer.Department = txtDepartment.Text;
					pCustomer.Address = txtAddress.Text;
					pCustomer.Phone = txtPhone.Text;
					pCustomer.E_mail = txtEmail.Text;
					pCustomer.Status = cboStatusCustomer.Text;
					pCustomer.Remark = rtbRemark.Text;
					
					if(CustomerBL.AddCustomer(pCustomer) > 0)
					{
						MessageBox.Show("El cliente se ha guardado correctamente.", "Cliente Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						
					}
					else
					{
						MessageBox.Show("El cliente no ha sido guardado, ha ocurrido un error.", "Cliente no Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				
				}
				
				
			}
			
		}
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		void ClearFormCustomer()
		{
			txtidCustomer.Clear();
			txtFullNameCustomer.Clear();
			txtMunicipality.Clear();
			txtDepartment.Clear();
			txtAddress.Clear();
			txtPhone.Clear();
			txtEmail.Clear();
			rtbRemark.Clear();
		}
		
		void DisableInstalationControls()
		{
			
			dtpDateInstalation.Enabled = false;
			txtPlaceInstalation.Enabled = false;
			rtbMaterialsInstalation.Enabled = false;
			txtReferencePlan.Enabled = false;
			btnSearchService.Enabled = false;
		}
		
		
		
		void EnableInstalationControls()
		{
			dtpDateInstalation.Enabled = true;
			txtPlaceInstalation.Enabled = true;
			rtbMaterialsInstalation.Enabled = true;
			txtReferencePlan.Enabled = true;
			btnSearchService.Enabled = true;
		}
		
		void CleanInstalationTextBox()
		{
			
			dtpDateInstalation.ResetText();
			txtPlaceInstalation.Clear();
			txtReferencePlan.Clear();
			rtbMaterialsInstalation.Clear();
			txtReferencePlan.Clear();
		}
		
		void DisableDeviceControls()
		{
			txtMACDevice.Enabled = false;
			txtNameDevice.Enabled = false;
			txtIPDevice.Enabled = false;
			txtBrandDevice.Enabled = false;
			txtTypeDevice.Enabled = false;
			txtFirmwareDevice.Enabled = false;
		}
		
		void EnableDeviceControls()
		{
			txtMACDevice.Enabled = true;
			txtNameDevice.Enabled = true;
			txtIPDevice.Enabled = true;
			txtBrandDevice.Enabled = true;
			txtTypeDevice.Enabled = true;
			txtFirmwareDevice.Enabled = true;
		}
			
		
		void CleanDeviceControls()
		{
			txtMACDevice.Clear();
			txtNameDevice.Clear();
			txtIPDevice.Clear();
			txtBrandDevice.Clear();
			txtTypeDevice.Clear();
			txtFirmwareDevice.Clear();
		}
		
		
		void LoadStatusCustomerComboBox()
		{
			cboStatusCustomer.Items.Add("Activo");
			cboStatusCustomer.Items.Add("Suspendido");
			cboStatusCustomer.Items.Add("Retirado");
			cboStatusCustomer.Items.Add("En mora");
		}
	
		
		
		void FrmAddCustomerLoad(object sender, EventArgs e)
		{
			
			DisableInstalationControls();
			DisableDeviceControls();
			
			LoadStatusCustomerComboBox();
			
			btnAddInstalation.Enabled = false;
			btnEditInstalation.Enabled = false;
			
			txtIdInstalationDevice.Enabled = false;
			btnAddDevice.Enabled = false;
			btnEditDevice.Enabled = false;
			
			
			if(CustomerSelected != null)
			{
				txtidCustomer.Text = CustomerSelected.idCustomer;
				txtFullNameCustomer.Text = CustomerSelected.Full_Name;
				txtMunicipality.Text = CustomerSelected.Municipality;
				txtDepartment.Text = CustomerSelected.Department;
				txtAddress.Text = CustomerSelected.Address;
				txtPhone.Text = CustomerSelected.Phone;
				txtEmail.Text = CustomerSelected.E_mail;
				cboStatusCustomer.Text = CustomerSelected.Status;
				rtbRemark.Text = CustomerSelected.Remark;
				btnSaveCustomer.Enabled = false;
				
				InstalationCustomer = InstalationBL.GetInstalation(CustomerSelected.idCustomer);
				dgvInstalations.DataSource = InstalationCustomer;
			}
			else
			{
				btnSaveCustomer.Enabled = true;
				btnEditCustomer.Enabled = false;
				
			}
			
		}	
		
		void BtnNewInstalationClick(object sender, EventArgs e)
		{
			EnableInstalationControls();
			CleanInstalationTextBox();
			
			btnAddInstalation.Enabled = true;
			btnEditInstalation.Enabled = false;
		}
		
		void BtnAddInstalationClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtPlaceInstalation.Text)) || (string.IsNullOrEmpty(txtReferencePlan.Text)))
			{
				MessageBox.Show("Algunos campos necesarios para el registro de la instalacion se encuentran vacios. Por favor, verifique que todos los campos marcados con (*) esten marcados, incluyendo la informacion personal del cliente.", "Error al Ingresar Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
					if(CustomerBL.verifyCustomerExistence(txtidCustomer.Text) > 0)
					{
						if(Service_PlanBL.validateReferenceServiceExistence(txtReferencePlan.Text) > 0)
						{
							
							Instalation NewInstalation = new Instalation();
							NewInstalation.Date = dtpDateInstalation.Value.Year + "/" + dtpDateInstalation.Value.Month + "/" +dtpDateInstalation.Value.Day;
							NewInstalation.Materials = rtbMaterialsInstalation.Text;
							NewInstalation.Place = txtPlaceInstalation.Text;
							NewInstalation.IdCustomer = txtidCustomer.Text;
							NewInstalation.idService = txtReferencePlan.Text;
							
							if(InstalationBL.AddInstalation(NewInstalation) > 0)
							{
								MessageBox.Show("La instalacion se ha ingresado exitosamente", "Instalacion Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
								dgvInstalations.DataSource = InstalationBL.GetInstalation(txtidCustomer.Text);
								CleanInstalationTextBox();
								DisableInstalationControls();
								btnAddInstalation.Enabled = false;
							}
							else
							{
								MessageBox.Show("Aun no se ha ingresado la instalacion, ha ocurrido un error.", "Error al Registrar Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("La referencia del plan de servicio no existe. Por favor, verifique que el plan de servicio se encuentre registrado.", "Error de Refrencia de Plan de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
					}
					else
					{
						MessageBox.Show("El cliente al cual se le quiere asignar la instalacion no es hallado. Por favor, diligencie todos los campos requeridos marcados con (*) en el formulario de la informacion personal del cliente, verifique que estos campos esten llenos y guardelo.", "Error al Ingresar Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
				
			}
		}
		void DgvInstalationsSelectionChanged(object sender, EventArgs e)
		{
			if(dgvInstalations.SelectedRows.Count == 1)
			{
				dtpDateInstalation.Text = Convert.ToString(dgvInstalations.CurrentRow.Cells[1].Value);
				rtbMaterialsInstalation.Text = Convert.ToString(dgvInstalations.CurrentRow.Cells[2].Value);
				txtPlaceInstalation.Text = Convert.ToString(dgvInstalations.CurrentRow.Cells[3].Value);
				txtReferencePlan.Text = Convert.ToString(dgvInstalations.CurrentRow.Cells[5].Value);
				
				int idInstalation = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
				dgvDevices.DataSource = Customer_DeviceBL.GetCustomerDevices(idInstalation);
				txtIdInstalationDevice.Text = Convert.ToString(idInstalation);
			}
		}
		void BtnEditInstalationClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtPlaceInstalation.Text)) || (string.IsNullOrEmpty(txtReferencePlan.Text)))
			{
				MessageBox.Show("Algun campo requerido en el formulario de instalacion se encuentra vacio. Por favor, verifique que todos los campos marcados con (*) esten llenos.", "Error al Editar Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Instalation instalationforedit = new Instalation();
				instalationforedit.Id = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
				instalationforedit.Date = dtpDateInstalation.Value.Year + "/" + dtpDateInstalation.Value.Month + "/" + dtpDateInstalation.Value.Day;
				instalationforedit.Materials = rtbMaterialsInstalation.Text;
				instalationforedit.Place = txtPlaceInstalation.Text;
				instalationforedit.idService = txtReferencePlan.Text;
				
				
				
				if(InstalationBL.EditInstalation(instalationforedit) > 0)
				{
					MessageBox.Show("La instalacion ha sido editada exitosamente", "Modificacion de Instalacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DisableInstalationControls();
					btnEditInstalation.Enabled = false;
					dgvInstalations.DataSource = InstalationBL.GetInstalation(txtidCustomer.Text);
				}
				else
				{
					MessageBox.Show("La instalacion aun no se ha editado, ha ocurrido un error.", "Instalacion no Editada", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnEditInstalationSelectedClick(object sender, EventArgs e)
		{
			if(dgvInstalations.SelectedRows.Count == 1)
			{
				EnableInstalationControls();
				btnAddInstalation.Enabled = false;
				btnEditInstalation.Enabled = true;
			}
			else
			{
				MessageBox.Show("Debe seleccionar una instalacion para editar.", "Seleccione Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		void BtnDeleteInstalationClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Esta seguro que desea eliminar esta instalacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
					if(dgvInstalations.SelectedRows.Count == 1)
					{
						int idInstalation = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
						if(InstalationBL.DeleteInstalation(idInstalation) > 0)
						{
							MessageBox.Show("La instalacion se ha eliminado exitosamente.", "Instalacion Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
							dgvInstalations.DataSource = InstalationBL.GetInstalation(txtidCustomer.Text);
							dgvDevices.DataSource = Customer_DeviceBL.GetCustomerDevices(idInstalation);
							CleanInstalationTextBox();
						}
						else
						{
							MessageBox.Show("Aun no se ha eliminado la instalacion, ha ocurrido un error.", "Instalacion no Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Debe seleccionar una instalacion.", "Error al Eliminar Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}			
			
			}			
			
		}
		void BtnSearchServiceClick(object sender, EventArgs e)
		{
			FrmServicesAux frmservicesaux = new FrmServicesAux();
			frmservicesaux.Show();
		}
		void BtnEditCustomerClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtidCustomer.Text)) || (string.IsNullOrEmpty(txtFullNameCustomer.Text)) || (string.IsNullOrEmpty(txtMunicipality.Text)) || (string.IsNullOrEmpty(txtDepartment.Text)) || (string.IsNullOrEmpty(txtAddress.Text)) || (string.IsNullOrEmpty(cboStatusCustomer.Text)))
			{
				MessageBox.Show("Algunos campos requeridos se encuentran vacios. Por favor, verifique que los campos maracados con (*) se encuentren llenos", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Customer pCustomer = new Customer();
				pCustomer.idCustomer = txtidCustomer.Text;
				pCustomer.Full_Name = txtFullNameCustomer.Text;
				pCustomer.Municipality = txtMunicipality.Text;
				pCustomer.Department = txtDepartment.Text;
				pCustomer.Address = txtAddress.Text;
				pCustomer.Phone = txtPhone.Text;
				pCustomer.E_mail = txtEmail.Text;
				pCustomer.Status = cboStatusCustomer.Text;
				pCustomer.Remark = rtbRemark.Text;
				
				String Id = Convert.ToString(CustomerSelected.idCustomer);
				if(CustomerBL.EditCustomer(pCustomer, Id) > 0)
				{
					MessageBox.Show("El cliente se ha editado correctamente.", "Cliente Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Aun no se ha editado el cliente, ha ocurrido un error.", "Cliente no Editado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		void BtnNewDeviceClick(object sender, EventArgs e)
		{
			if(dgvInstalations.SelectedRows.Count == 1)
			{
				EnableDeviceControls();
				CleanDeviceControls();
				
				btnAddDevice.Enabled = true;
				btnEditDevice.Enabled = false;			
			}
			else
			{
				MessageBox.Show("Debe seleccionar una instalacion para agregar un dispositivo.", "Seleccione Instalacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
	
		}
		void BtnAddDeviceClick(object sender, EventArgs e)
		{
						
				if((string.IsNullOrEmpty(txtMACDevice.Text)) || (string.IsNullOrEmpty(txtNameDevice.Text)) || (string.IsNullOrEmpty(txtIPDevice.Text)) || (string.IsNullOrEmpty(txtBrandDevice.Text)) || (string.IsNullOrEmpty(txtTypeDevice.Text)) || (string.IsNullOrEmpty(txtFirmwareDevice.Text)) || (string.IsNullOrEmpty(txtIdInstalationDevice.Text)))
				{
					MessageBox.Show("Algun campo requerido se encuentra vacio. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error al Ingresar Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if(Customer_DeviceBL.verifyCustomerDeviceExistence(txtMACDevice.Text) > 0)
					{
						MessageBox.Show("La MAC de dispositivo ingresada ya existe. Por favor, verifique que la MAC de su dispositivo sea la correcta.", "Error al Ingresar Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						Customer_device NewDevice = new Customer_device();
						NewDevice.MAC = txtMACDevice.Text;
						NewDevice.Name_Device = txtNameDevice.Text;
						NewDevice.IP_Device = txtIPDevice.Text;
						NewDevice.Brand_Device = txtBrandDevice.Text;
						NewDevice.Type_Device = txtTypeDevice.Text;
						NewDevice.Firmware_Device = txtFirmwareDevice.Text;
						NewDevice.idInstalation_Device = Convert.ToInt32(txtIdInstalationDevice.Text);
						
						if(Customer_DeviceBL.AddCustomerDevice(NewDevice) > 0)
						{
							MessageBox.Show("El dispositivo ha sido ingresado exitosamente.", "Dispositivo Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							DisableDeviceControls();
							CleanDeviceControls();
							
							btnAddDevice.Enabled = false;
							
							int idInstalation = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
							dgvDevices.DataSource = Customer_DeviceBL.GetCustomerDevices(idInstalation);
						}
						else
						{
							MessageBox.Show("El dispositivo no ha sido ingresado, ha ocurrido un error.", "Error al Ingresar Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			
			
			
		}
		void BtnDeleteDeviceClick(object sender, EventArgs e)
		{
			
			if(dgvDevices.SelectedRows.Count == 1)
			{
			
				if(MessageBox.Show("Esta seguro de eliminar este dispositivo?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
						String MACDevice = Convert.ToString(dgvDevices.CurrentRow.Cells[0].Value);
						if(Customer_DeviceBL.DeleteCustomerDevice(MACDevice) > 0)
						{
							MessageBox.Show("El dispositivo ha sido eliminado correctamente", "Dispositivo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
							int idInstalation = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
							dgvDevices.DataSource = Customer_DeviceBL.GetCustomerDevices(idInstalation);
							CleanDeviceControls();
						}
						else
						{
							MessageBox.Show("El dispositivo no ha sido eliminado, ha ocurrido un error", "Dispositivo no Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
							
			}
			
			else
			{
				MessageBox.Show("Debe seleccionar un dispositivo", "Seleccione un Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void BtnEditDeviceSelectedClick(object sender, EventArgs e)
		{
			if(dgvDevices.SelectedRows.Count == 1)
			{
				EnableDeviceControls();
				
				btnAddDevice.Enabled = false;
				btnEditDevice.Enabled = true;
			}
			else
			{
				MessageBox.Show("Debe seleccionar un dispositivo para editar.", "Seleccione Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void DgvDevicesSelectionChanged(object sender, EventArgs e)
		{
			if(dgvDevices.SelectedRows.Count == 1)
			{
				txtMACDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[0].Value);
				txtNameDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[1].Value);
				txtIPDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[2].Value);
				txtBrandDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[3].Value);
				txtTypeDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[4].Value);
				txtFirmwareDevice.Text = Convert.ToString(dgvDevices.CurrentRow.Cells[5].Value);				
			}
						
		}
		void BtnEditDeviceClick(object sender, EventArgs e)
		{
			if((string.IsNullOrEmpty(txtMACDevice.Text)) || (string.IsNullOrEmpty(txtNameDevice.Text)) || (string.IsNullOrEmpty(txtIPDevice.Text)) || (string.IsNullOrEmpty(txtBrandDevice.Text)) || (string.IsNullOrEmpty(txtTypeDevice.Text)))
			{
				MessageBox.Show("Algunos campos requeridos se encuentran vacios. Por favor, verifique que los campos marcados con (*) se encuentren llenos.", "Error al Editar Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
					Customer_device CustomerDevice = new Customer_device();
					CustomerDevice.MAC = txtMACDevice.Text;
					CustomerDevice.Name_Device = txtNameDevice.Text;
					CustomerDevice.IP_Device = txtIPDevice.Text;
					CustomerDevice.Brand_Device = txtBrandDevice.Text;
					CustomerDevice.Type_Device = txtTypeDevice.Text;
					CustomerDevice.Firmware_Device = txtFirmwareDevice.Text;
					
					String idInstalation = Convert.ToString(dgvDevices.CurrentRow.Cells[0].Value);
					if(Customer_DeviceBL.EditCustomerDevice(CustomerDevice, idInstalation) > 0)
					{
						MessageBox.Show("El dispositivo se ha editado correctamente.", "Dispositivo Editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
						DisableDeviceControls();
						
						
						btnEditDevice.Enabled = false;
						
						int idInstal = Convert.ToInt32(dgvInstalations.CurrentRow.Cells[0].Value);
						dgvDevices.DataSource = Customer_DeviceBL.GetCustomerDevices(idInstal);
					}
					else
					{
						MessageBox.Show("El dispositivo no ha sido editado, ha ocurrido un error.", "Error al Editar Dispositivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					
			}
		}

		void TxtReferencePlanClick(object sender, EventArgs e)
		{
			IDataObject MyData = Clipboard.GetDataObject();
			
			if(MyData.GetDataPresent(DataFormats.Text))
			{
				txtReferencePlan.Text = (String)MyData.GetData(DataFormats.Text);
			}
			else
			{
				txtReferencePlan.Text = "Referencia no copiada.";
			}
		}		
	
	}
}
