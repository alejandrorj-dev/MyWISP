/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 27/01/2020
 * Time: 17:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmCustomerInformation
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtidCustomer;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMunicipality;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFullNameCustomer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox rtbRemark;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSaveCustomer;
		private System.Windows.Forms.GroupBox gbInstalations;
		private System.Windows.Forms.Button btnAddInstalation;
		private System.Windows.Forms.DataGridView dgvInstalations;
		private System.Windows.Forms.Button btnNewInstalation;
		private System.Windows.Forms.RichTextBox rtbMaterialsInstalation;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPlaceInstalation;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.TextBox txtReferencePlan;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtpDateInstalation;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox gbDevices;
		private System.Windows.Forms.Button btnNewDevice;
		private System.Windows.Forms.Button btnAddDevice;
		private System.Windows.Forms.DataGridView dgvDevices;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtIPDevice;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtNameDevice;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtMACDevice;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnDeleteInstalation;
		private System.Windows.Forms.Button btnEditInstalationSelected;
		private System.Windows.Forms.Button btnEditInstalation;
		private System.Windows.Forms.Button btnSearchService;
		private System.Windows.Forms.Button btnEditCustomer;
		private System.Windows.Forms.Button btnEditDeviceSelected;
		private System.Windows.Forms.Button btnDeleteDevice;
		private System.Windows.Forms.TextBox txtIdInstalationDevice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtFirmwareDevice;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button btnEditDevice;
		private System.Windows.Forms.TextBox txtTypeDevice;
		private System.Windows.Forms.TextBox txtBrandDevice;
		private System.Windows.Forms.ComboBox cboStatusCustomer;
		private System.Windows.Forms.Label label21;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.GroupBox gbPersonalInformation;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerInformation));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cboStatusCustomer = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.btnEditCustomer = new System.Windows.Forms.Button();
			this.btnSaveCustomer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtidCustomer = new System.Windows.Forms.TextBox();
			this.rtbRemark = new System.Windows.Forms.RichTextBox();
			this.txtMunicipality = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtFullNameCustomer = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.gbInstalations = new System.Windows.Forms.GroupBox();
			this.btnSearchService = new System.Windows.Forms.Button();
			this.btnEditInstalationSelected = new System.Windows.Forms.Button();
			this.btnEditInstalation = new System.Windows.Forms.Button();
			this.btnDeleteInstalation = new System.Windows.Forms.Button();
			this.btnAddInstalation = new System.Windows.Forms.Button();
			this.dgvInstalations = new System.Windows.Forms.DataGridView();
			this.btnNewInstalation = new System.Windows.Forms.Button();
			this.rtbMaterialsInstalation = new System.Windows.Forms.RichTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPlaceInstalation = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtReferencePlan = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtpDateInstalation = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.gbDevices = new System.Windows.Forms.GroupBox();
			this.txtTypeDevice = new System.Windows.Forms.TextBox();
			this.txtBrandDevice = new System.Windows.Forms.TextBox();
			this.btnEditDevice = new System.Windows.Forms.Button();
			this.txtFirmwareDevice = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtIdInstalationDevice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnEditDeviceSelected = new System.Windows.Forms.Button();
			this.btnDeleteDevice = new System.Windows.Forms.Button();
			this.btnNewDevice = new System.Windows.Forms.Button();
			this.btnAddDevice = new System.Windows.Forms.Button();
			this.dgvDevices = new System.Windows.Forms.DataGridView();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.txtIPDevice = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtNameDevice = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtMACDevice = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			gbPersonalInformation = new System.Windows.Forms.GroupBox();
			gbPersonalInformation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.gbInstalations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInstalations)).BeginInit();
			this.gbDevices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).BeginInit();
			this.SuspendLayout();
			// 
			// gbPersonalInformation
			// 
			gbPersonalInformation.Controls.Add(this.cboStatusCustomer);
			gbPersonalInformation.Controls.Add(this.label21);
			gbPersonalInformation.Controls.Add(this.btnEditCustomer);
			gbPersonalInformation.Controls.Add(this.btnSaveCustomer);
			gbPersonalInformation.Controls.Add(this.pictureBox1);
			gbPersonalInformation.Controls.Add(this.label9);
			gbPersonalInformation.Controls.Add(this.txtidCustomer);
			gbPersonalInformation.Controls.Add(this.rtbRemark);
			gbPersonalInformation.Controls.Add(this.txtMunicipality);
			gbPersonalInformation.Controls.Add(this.label5);
			gbPersonalInformation.Controls.Add(this.txtEmail);
			gbPersonalInformation.Controls.Add(this.label4);
			gbPersonalInformation.Controls.Add(this.txtDepartment);
			gbPersonalInformation.Controls.Add(this.txtFullNameCustomer);
			gbPersonalInformation.Controls.Add(this.label8);
			gbPersonalInformation.Controls.Add(this.label6);
			gbPersonalInformation.Controls.Add(this.label2);
			gbPersonalInformation.Controls.Add(this.label3);
			gbPersonalInformation.Controls.Add(this.txtPhone);
			gbPersonalInformation.Controls.Add(this.txtAddress);
			gbPersonalInformation.Controls.Add(this.label7);
			gbPersonalInformation.ForeColor = System.Drawing.Color.White;
			gbPersonalInformation.Location = new System.Drawing.Point(18, 48);
			gbPersonalInformation.Name = "gbPersonalInformation";
			gbPersonalInformation.Size = new System.Drawing.Size(616, 394);
			gbPersonalInformation.TabIndex = 18;
			gbPersonalInformation.TabStop = false;
			gbPersonalInformation.Text = "Datos Personales";
			// 
			// cboStatusCustomer
			// 
			this.cboStatusCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatusCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboStatusCustomer.FormattingEnabled = true;
			this.cboStatusCustomer.Location = new System.Drawing.Point(357, 218);
			this.cboStatusCustomer.Name = "cboStatusCustomer";
			this.cboStatusCustomer.Size = new System.Drawing.Size(121, 21);
			this.cboStatusCustomer.TabIndex = 21;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(259, 218);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(96, 23);
			this.label21.TabIndex = 20;
			this.label21.Text = "Estado:*";
			this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.BackColor = System.Drawing.Color.Orange;
			this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditCustomer.FlatAppearance.BorderSize = 0;
			this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.Image")));
			this.btnEditCustomer.Location = new System.Drawing.Point(423, 324);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(60, 60);
			this.btnEditCustomer.TabIndex = 19;
			this.btnEditCustomer.UseVisualStyleBackColor = false;
			this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomerClick);
			// 
			// btnSaveCustomer
			// 
			this.btnSaveCustomer.BackColor = System.Drawing.Color.DarkBlue;
			this.btnSaveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCustomer.FlatAppearance.BorderSize = 0;
			this.btnSaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCustomer.Image")));
			this.btnSaveCustomer.Location = new System.Drawing.Point(357, 324);
			this.btnSaveCustomer.Name = "btnSaveCustomer";
			this.btnSaveCustomer.Size = new System.Drawing.Size(60, 60);
			this.btnSaveCustomer.TabIndex = 18;
			this.btnSaveCustomer.UseVisualStyleBackColor = false;
			this.btnSaveCustomer.Click += new System.EventHandler(this.BtnSaveCustomerClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(231, 285);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(259, 248);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(96, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "Observaciones:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtidCustomer
			// 
			this.txtidCustomer.Location = new System.Drawing.Point(357, 33);
			this.txtidCustomer.MaxLength = 50;
			this.txtidCustomer.Name = "txtidCustomer";
			this.txtidCustomer.Size = new System.Drawing.Size(203, 20);
			this.txtidCustomer.TabIndex = 2;
			// 
			// rtbRemark
			// 
			this.rtbRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbRemark.Location = new System.Drawing.Point(357, 245);
			this.rtbRemark.MaxLength = 300;
			this.rtbRemark.Name = "rtbRemark";
			this.rtbRemark.Size = new System.Drawing.Size(240, 69);
			this.rtbRemark.TabIndex = 16;
			this.rtbRemark.Text = "";
			// 
			// txtMunicipality
			// 
			this.txtMunicipality.Location = new System.Drawing.Point(357, 85);
			this.txtMunicipality.MaxLength = 45;
			this.txtMunicipality.Name = "txtMunicipality";
			this.txtMunicipality.Size = new System.Drawing.Size(115, 20);
			this.txtMunicipality.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(259, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Departamento: *";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(357, 192);
			this.txtEmail.MaxLength = 60;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(193, 20);
			this.txtEmail.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(243, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Ciudad o Municipio: *";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Location = new System.Drawing.Point(357, 111);
			this.txtDepartment.MaxLength = 45;
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(162, 20);
			this.txtDepartment.TabIndex = 9;
			// 
			// txtFullNameCustomer
			// 
			this.txtFullNameCustomer.Location = new System.Drawing.Point(357, 59);
			this.txtFullNameCustomer.MaxLength = 200;
			this.txtFullNameCustomer.Name = "txtFullNameCustomer";
			this.txtFullNameCustomer.Size = new System.Drawing.Size(240, 20);
			this.txtFullNameCustomer.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(314, 195);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "E-mail:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(289, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Dirección: *";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(259, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Identificación: *";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(243, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre Completo: *";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(357, 163);
			this.txtPhone.MaxLength = 45;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(142, 20);
			this.txtPhone.TabIndex = 13;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(357, 137);
			this.txtAddress.MaxLength = 60;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(211, 20);
			this.txtAddress.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(300, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Teléfono:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1364, 25);
			this.panel1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1339, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Informacion del Cliente";
			// 
			// gbInstalations
			// 
			this.gbInstalations.Controls.Add(this.btnSearchService);
			this.gbInstalations.Controls.Add(this.btnEditInstalationSelected);
			this.gbInstalations.Controls.Add(this.btnEditInstalation);
			this.gbInstalations.Controls.Add(this.btnDeleteInstalation);
			this.gbInstalations.Controls.Add(this.btnAddInstalation);
			this.gbInstalations.Controls.Add(this.dgvInstalations);
			this.gbInstalations.Controls.Add(this.btnNewInstalation);
			this.gbInstalations.Controls.Add(this.rtbMaterialsInstalation);
			this.gbInstalations.Controls.Add(this.label14);
			this.gbInstalations.Controls.Add(this.txtPlaceInstalation);
			this.gbInstalations.Controls.Add(this.label13);
			this.gbInstalations.Controls.Add(this.txtReferencePlan);
			this.gbInstalations.Controls.Add(this.label12);
			this.gbInstalations.Controls.Add(this.dtpDateInstalation);
			this.gbInstalations.Controls.Add(this.label11);
			this.gbInstalations.ForeColor = System.Drawing.Color.White;
			this.gbInstalations.Location = new System.Drawing.Point(655, 48);
			this.gbInstalations.Name = "gbInstalations";
			this.gbInstalations.Size = new System.Drawing.Size(678, 394);
			this.gbInstalations.TabIndex = 19;
			this.gbInstalations.TabStop = false;
			this.gbInstalations.Text = "Instalaciones";
			// 
			// btnSearchService
			// 
			this.btnSearchService.BackColor = System.Drawing.Color.Navy;
			this.btnSearchService.FlatAppearance.BorderSize = 0;
			this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchService.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchService.Image")));
			this.btnSearchService.Location = new System.Drawing.Point(625, 28);
			this.btnSearchService.Name = "btnSearchService";
			this.btnSearchService.Size = new System.Drawing.Size(23, 23);
			this.btnSearchService.TabIndex = 16;
			this.btnSearchService.UseVisualStyleBackColor = false;
			this.btnSearchService.Click += new System.EventHandler(this.BtnSearchServiceClick);
			// 
			// btnEditInstalationSelected
			// 
			this.btnEditInstalationSelected.BackColor = System.Drawing.Color.OrangeRed;
			this.btnEditInstalationSelected.FlatAppearance.BorderSize = 0;
			this.btnEditInstalationSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditInstalationSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInstalationSelected.Image")));
			this.btnEditInstalationSelected.Location = new System.Drawing.Point(586, 163);
			this.btnEditInstalationSelected.Name = "btnEditInstalationSelected";
			this.btnEditInstalationSelected.Size = new System.Drawing.Size(23, 23);
			this.btnEditInstalationSelected.TabIndex = 15;
			this.btnEditInstalationSelected.UseVisualStyleBackColor = false;
			this.btnEditInstalationSelected.Click += new System.EventHandler(this.BtnEditInstalationSelectedClick);
			// 
			// btnEditInstalation
			// 
			this.btnEditInstalation.BackColor = System.Drawing.Color.OrangeRed;
			this.btnEditInstalation.FlatAppearance.BorderSize = 0;
			this.btnEditInstalation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditInstalation.Image = ((System.Drawing.Image)(resources.GetObject("btnEditInstalation.Image")));
			this.btnEditInstalation.Location = new System.Drawing.Point(154, 143);
			this.btnEditInstalation.Name = "btnEditInstalation";
			this.btnEditInstalation.Size = new System.Drawing.Size(23, 23);
			this.btnEditInstalation.TabIndex = 14;
			this.btnEditInstalation.UseVisualStyleBackColor = false;
			this.btnEditInstalation.Click += new System.EventHandler(this.BtnEditInstalationClick);
			// 
			// btnDeleteInstalation
			// 
			this.btnDeleteInstalation.BackColor = System.Drawing.Color.Maroon;
			this.btnDeleteInstalation.FlatAppearance.BorderSize = 0;
			this.btnDeleteInstalation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteInstalation.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteInstalation.Image")));
			this.btnDeleteInstalation.Location = new System.Drawing.Point(615, 163);
			this.btnDeleteInstalation.Name = "btnDeleteInstalation";
			this.btnDeleteInstalation.Size = new System.Drawing.Size(23, 23);
			this.btnDeleteInstalation.TabIndex = 13;
			this.btnDeleteInstalation.UseVisualStyleBackColor = false;
			this.btnDeleteInstalation.Click += new System.EventHandler(this.BtnDeleteInstalationClick);
			// 
			// btnAddInstalation
			// 
			this.btnAddInstalation.BackColor = System.Drawing.Color.Navy;
			this.btnAddInstalation.FlatAppearance.BorderSize = 0;
			this.btnAddInstalation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddInstalation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddInstalation.Image")));
			this.btnAddInstalation.Location = new System.Drawing.Point(125, 143);
			this.btnAddInstalation.Name = "btnAddInstalation";
			this.btnAddInstalation.Size = new System.Drawing.Size(23, 23);
			this.btnAddInstalation.TabIndex = 12;
			this.btnAddInstalation.UseVisualStyleBackColor = false;
			this.btnAddInstalation.Click += new System.EventHandler(this.BtnAddInstalationClick);
			// 
			// dgvInstalations
			// 
			this.dgvInstalations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvInstalations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvInstalations.BackgroundColor = System.Drawing.Color.White;
			this.dgvInstalations.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvInstalations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvInstalations.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvInstalations.GridColor = System.Drawing.Color.White;
			this.dgvInstalations.Location = new System.Drawing.Point(11, 192);
			this.dgvInstalations.Name = "dgvInstalations";
			this.dgvInstalations.Size = new System.Drawing.Size(657, 186);
			this.dgvInstalations.TabIndex = 11;
			this.dgvInstalations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInstalationsSelectionChanged);
			this.dgvInstalations.SelectionChanged += new System.EventHandler(this.DgvInstalationsSelectionChanged);
			// 
			// btnNewInstalation
			// 
			this.btnNewInstalation.BackColor = System.Drawing.Color.ForestGreen;
			this.btnNewInstalation.FlatAppearance.BorderSize = 0;
			this.btnNewInstalation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewInstalation.Image = ((System.Drawing.Image)(resources.GetObject("btnNewInstalation.Image")));
			this.btnNewInstalation.Location = new System.Drawing.Point(644, 163);
			this.btnNewInstalation.Name = "btnNewInstalation";
			this.btnNewInstalation.Size = new System.Drawing.Size(23, 23);
			this.btnNewInstalation.TabIndex = 10;
			this.btnNewInstalation.UseVisualStyleBackColor = false;
			this.btnNewInstalation.Click += new System.EventHandler(this.BtnNewInstalationClick);
			// 
			// rtbMaterialsInstalation
			// 
			this.rtbMaterialsInstalation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbMaterialsInstalation.Location = new System.Drawing.Point(125, 67);
			this.rtbMaterialsInstalation.MaxLength = 400;
			this.rtbMaterialsInstalation.Name = "rtbMaterialsInstalation";
			this.rtbMaterialsInstalation.Size = new System.Drawing.Size(392, 70);
			this.rtbMaterialsInstalation.TabIndex = 9;
			this.rtbMaterialsInstalation.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(6, 65);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(113, 23);
			this.label14.TabIndex = 8;
			this.label14.Text = "Materiales Utilizados:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPlaceInstalation
			// 
			this.txtPlaceInstalation.Location = new System.Drawing.Point(292, 30);
			this.txtPlaceInstalation.MaxLength = 300;
			this.txtPlaceInstalation.Name = "txtPlaceInstalation";
			this.txtPlaceInstalation.Size = new System.Drawing.Size(146, 20);
			this.txtPlaceInstalation.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(176, 29);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(113, 23);
			this.label13.TabIndex = 6;
			this.label13.Text = "Lugar de Instalacion: *";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtReferencePlan
			// 
			this.txtReferencePlan.Location = new System.Drawing.Point(562, 29);
			this.txtReferencePlan.MaxLength = 20;
			this.txtReferencePlan.Name = "txtReferencePlan";
			this.txtReferencePlan.Size = new System.Drawing.Size(57, 20);
			this.txtReferencePlan.TabIndex = 5;
			this.txtReferencePlan.Click += new System.EventHandler(this.TxtReferencePlanClick);
			this.txtReferencePlan.TextChanged += new System.EventHandler(this.TxtReferencePlanClick);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(443, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(113, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Referencia de Plan: *";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDateInstalation
			// 
			this.dtpDateInstalation.Location = new System.Drawing.Point(59, 31);
			this.dtpDateInstalation.Name = "dtpDateInstalation";
			this.dtpDateInstalation.Size = new System.Drawing.Size(108, 20);
			this.dtpDateInstalation.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(9, 30);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(44, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Fecha:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbDevices
			// 
			this.gbDevices.Controls.Add(this.txtTypeDevice);
			this.gbDevices.Controls.Add(this.txtBrandDevice);
			this.gbDevices.Controls.Add(this.btnEditDevice);
			this.gbDevices.Controls.Add(this.txtFirmwareDevice);
			this.gbDevices.Controls.Add(this.label20);
			this.gbDevices.Controls.Add(this.txtIdInstalationDevice);
			this.gbDevices.Controls.Add(this.label10);
			this.gbDevices.Controls.Add(this.btnEditDeviceSelected);
			this.gbDevices.Controls.Add(this.btnDeleteDevice);
			this.gbDevices.Controls.Add(this.btnNewDevice);
			this.gbDevices.Controls.Add(this.btnAddDevice);
			this.gbDevices.Controls.Add(this.dgvDevices);
			this.gbDevices.Controls.Add(this.label19);
			this.gbDevices.Controls.Add(this.label18);
			this.gbDevices.Controls.Add(this.txtIPDevice);
			this.gbDevices.Controls.Add(this.label17);
			this.gbDevices.Controls.Add(this.txtNameDevice);
			this.gbDevices.Controls.Add(this.label16);
			this.gbDevices.Controls.Add(this.txtMACDevice);
			this.gbDevices.Controls.Add(this.label15);
			this.gbDevices.ForeColor = System.Drawing.Color.White;
			this.gbDevices.Location = new System.Drawing.Point(18, 448);
			this.gbDevices.Name = "gbDevices";
			this.gbDevices.Size = new System.Drawing.Size(1315, 270);
			this.gbDevices.TabIndex = 20;
			this.gbDevices.TabStop = false;
			this.gbDevices.Text = "Dispositivos";
			// 
			// txtTypeDevice
			// 
			this.txtTypeDevice.Location = new System.Drawing.Point(857, 30);
			this.txtTypeDevice.Name = "txtTypeDevice";
			this.txtTypeDevice.Size = new System.Drawing.Size(100, 20);
			this.txtTypeDevice.TabIndex = 22;
			// 
			// txtBrandDevice
			// 
			this.txtBrandDevice.Location = new System.Drawing.Point(633, 29);
			this.txtBrandDevice.Name = "txtBrandDevice";
			this.txtBrandDevice.Size = new System.Drawing.Size(100, 20);
			this.txtBrandDevice.TabIndex = 21;
			// 
			// btnEditDevice
			// 
			this.btnEditDevice.BackColor = System.Drawing.Color.OrangeRed;
			this.btnEditDevice.FlatAppearance.BorderSize = 0;
			this.btnEditDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDevice.Image")));
			this.btnEditDevice.Location = new System.Drawing.Point(86, 55);
			this.btnEditDevice.Name = "btnEditDevice";
			this.btnEditDevice.Size = new System.Drawing.Size(23, 23);
			this.btnEditDevice.TabIndex = 20;
			this.btnEditDevice.UseVisualStyleBackColor = false;
			this.btnEditDevice.Click += new System.EventHandler(this.BtnEditDeviceClick);
			// 
			// txtFirmwareDevice
			// 
			this.txtFirmwareDevice.Location = new System.Drawing.Point(1096, 31);
			this.txtFirmwareDevice.MaxLength = 45;
			this.txtFirmwareDevice.Name = "txtFirmwareDevice";
			this.txtFirmwareDevice.Size = new System.Drawing.Size(50, 20);
			this.txtFirmwareDevice.TabIndex = 19;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(979, 29);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(114, 23);
			this.label20.TabIndex = 18;
			this.label20.Text = "Version de Firmware: ";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdInstalationDevice
			// 
			this.txtIdInstalationDevice.Location = new System.Drawing.Point(1238, 32);
			this.txtIdInstalationDevice.MaxLength = 45;
			this.txtIdInstalationDevice.Name = "txtIdInstalationDevice";
			this.txtIdInstalationDevice.Size = new System.Drawing.Size(50, 20);
			this.txtIdInstalationDevice.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(1151, 28);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 23);
			this.label10.TabIndex = 16;
			this.label10.Text = "Id de Instalac.: *";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnEditDeviceSelected
			// 
			this.btnEditDeviceSelected.BackColor = System.Drawing.Color.OrangeRed;
			this.btnEditDeviceSelected.FlatAppearance.BorderSize = 0;
			this.btnEditDeviceSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditDeviceSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnEditDeviceSelected.Image")));
			this.btnEditDeviceSelected.Location = new System.Drawing.Point(1213, 79);
			this.btnEditDeviceSelected.Name = "btnEditDeviceSelected";
			this.btnEditDeviceSelected.Size = new System.Drawing.Size(23, 23);
			this.btnEditDeviceSelected.TabIndex = 15;
			this.btnEditDeviceSelected.UseVisualStyleBackColor = false;
			this.btnEditDeviceSelected.Click += new System.EventHandler(this.BtnEditDeviceSelectedClick);
			// 
			// btnDeleteDevice
			// 
			this.btnDeleteDevice.BackColor = System.Drawing.Color.Maroon;
			this.btnDeleteDevice.FlatAppearance.BorderSize = 0;
			this.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteDevice.Image")));
			this.btnDeleteDevice.Location = new System.Drawing.Point(1242, 79);
			this.btnDeleteDevice.Name = "btnDeleteDevice";
			this.btnDeleteDevice.Size = new System.Drawing.Size(23, 23);
			this.btnDeleteDevice.TabIndex = 14;
			this.btnDeleteDevice.UseVisualStyleBackColor = false;
			this.btnDeleteDevice.Click += new System.EventHandler(this.BtnDeleteDeviceClick);
			// 
			// btnNewDevice
			// 
			this.btnNewDevice.BackColor = System.Drawing.Color.ForestGreen;
			this.btnNewDevice.FlatAppearance.BorderSize = 0;
			this.btnNewDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnNewDevice.Image")));
			this.btnNewDevice.Location = new System.Drawing.Point(1271, 79);
			this.btnNewDevice.Name = "btnNewDevice";
			this.btnNewDevice.Size = new System.Drawing.Size(23, 23);
			this.btnNewDevice.TabIndex = 13;
			this.btnNewDevice.UseVisualStyleBackColor = false;
			this.btnNewDevice.Click += new System.EventHandler(this.BtnNewDeviceClick);
			// 
			// btnAddDevice
			// 
			this.btnAddDevice.BackColor = System.Drawing.Color.Navy;
			this.btnAddDevice.FlatAppearance.BorderSize = 0;
			this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDevice.Image")));
			this.btnAddDevice.Location = new System.Drawing.Point(57, 55);
			this.btnAddDevice.Name = "btnAddDevice";
			this.btnAddDevice.Size = new System.Drawing.Size(23, 23);
			this.btnAddDevice.TabIndex = 13;
			this.btnAddDevice.UseVisualStyleBackColor = false;
			this.btnAddDevice.Click += new System.EventHandler(this.BtnAddDeviceClick);
			// 
			// dgvDevices
			// 
			this.dgvDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDevices.BackgroundColor = System.Drawing.Color.White;
			this.dgvDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDevices.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDevices.Location = new System.Drawing.Point(7, 108);
			this.dgvDevices.Name = "dgvDevices";
			this.dgvDevices.Size = new System.Drawing.Size(1288, 150);
			this.dgvDevices.TabIndex = 12;
			this.dgvDevices.SelectionChanged += new System.EventHandler(this.DgvDevicesSelectionChanged);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(738, 27);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(113, 23);
			this.label19.TabIndex = 8;
			this.label19.Text = "Tipo de Dispositivo:*";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(566, 28);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(54, 23);
			this.label18.TabIndex = 6;
			this.label18.Text = "Marca: *";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIPDevice
			// 
			this.txtIPDevice.Location = new System.Drawing.Point(458, 29);
			this.txtIPDevice.MaxLength = 45;
			this.txtIPDevice.Name = "txtIPDevice";
			this.txtIPDevice.Size = new System.Drawing.Size(101, 20);
			this.txtIPDevice.TabIndex = 5;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(422, 27);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(34, 23);
			this.label17.TabIndex = 4;
			this.label17.Text = "IP: *";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNameDevice
			// 
			this.txtNameDevice.Location = new System.Drawing.Point(299, 29);
			this.txtNameDevice.MaxLength = 45;
			this.txtNameDevice.Name = "txtNameDevice";
			this.txtNameDevice.Size = new System.Drawing.Size(117, 20);
			this.txtNameDevice.TabIndex = 3;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(168, 27);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(127, 23);
			this.label16.TabIndex = 2;
			this.label16.Text = "Nombre del Dispositivo: *";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMACDevice
			// 
			this.txtMACDevice.Location = new System.Drawing.Point(57, 29);
			this.txtMACDevice.MaxLength = 45;
			this.txtMACDevice.Name = "txtMACDevice";
			this.txtMACDevice.Size = new System.Drawing.Size(110, 20);
			this.txtMACDevice.TabIndex = 1;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(11, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(43, 23);
			this.label15.TabIndex = 0;
			this.label15.Text = "MAC: *";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmCustomerInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(1364, 727);
			this.Controls.Add(this.gbDevices);
			this.Controls.Add(this.gbInstalations);
			this.Controls.Add(gbPersonalInformation);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCustomerInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informacion del Cliente";
			this.Load += new System.EventHandler(this.FrmAddCustomerLoad);
			gbPersonalInformation.ResumeLayout(false);
			gbPersonalInformation.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.gbInstalations.ResumeLayout(false);
			this.gbInstalations.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInstalations)).EndInit();
			this.gbDevices.ResumeLayout(false);
			this.gbDevices.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDevices)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
