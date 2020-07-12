/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/21/2020
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEditCustomerDevice
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEditMAC;
		private System.Windows.Forms.TextBox txtEditNameDevice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEditIPAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEditBrand;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEditType;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEditFirmwareVersion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnEditCustomerDeviceInfo;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditCustomerDevice));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEditMAC = new System.Windows.Forms.TextBox();
			this.txtEditNameDevice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEditIPAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEditBrand = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEditType = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEditFirmwareVersion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnEditCustomerDeviceInfo = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(764, 28);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Editar Informacion de Dispositivo Domiciliario";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(737, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(505, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "MAC:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditMAC
			// 
			this.txtEditMAC.Location = new System.Drawing.Point(568, 77);
			this.txtEditMAC.Name = "txtEditMAC";
			this.txtEditMAC.Size = new System.Drawing.Size(152, 20);
			this.txtEditMAC.TabIndex = 2;
			// 
			// txtEditNameDevice
			// 
			this.txtEditNameDevice.Location = new System.Drawing.Point(568, 112);
			this.txtEditNameDevice.Name = "txtEditNameDevice";
			this.txtEditNameDevice.Size = new System.Drawing.Size(152, 20);
			this.txtEditNameDevice.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(416, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre del Dispositivo:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditIPAddress
			// 
			this.txtEditIPAddress.Location = new System.Drawing.Point(568, 148);
			this.txtEditIPAddress.Name = "txtEditIPAddress";
			this.txtEditIPAddress.Size = new System.Drawing.Size(152, 20);
			this.txtEditIPAddress.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(447, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Direccion IP:*";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditBrand
			// 
			this.txtEditBrand.Location = new System.Drawing.Point(568, 184);
			this.txtEditBrand.Name = "txtEditBrand";
			this.txtEditBrand.Size = new System.Drawing.Size(152, 20);
			this.txtEditBrand.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(438, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Marca:*";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditType
			// 
			this.txtEditType.Location = new System.Drawing.Point(568, 220);
			this.txtEditType.Name = "txtEditType";
			this.txtEditType.Size = new System.Drawing.Size(152, 20);
			this.txtEditType.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(447, 218);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 23);
			this.label6.TabIndex = 9;
			this.label6.Text = "Tipo de Dispositivo:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEditFirmwareVersion
			// 
			this.txtEditFirmwareVersion.Location = new System.Drawing.Point(568, 257);
			this.txtEditFirmwareVersion.Name = "txtEditFirmwareVersion";
			this.txtEditFirmwareVersion.Size = new System.Drawing.Size(152, 20);
			this.txtEditFirmwareVersion.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(438, 255);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(124, 23);
			this.label7.TabIndex = 11;
			this.label7.Text = "Version de Firmware:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnEditCustomerDeviceInfo
			// 
			this.btnEditCustomerDeviceInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.btnEditCustomerDeviceInfo.FlatAppearance.BorderSize = 0;
			this.btnEditCustomerDeviceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCustomerDeviceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerDeviceInfo.Image")));
			this.btnEditCustomerDeviceInfo.Location = new System.Drawing.Point(611, 322);
			this.btnEditCustomerDeviceInfo.Name = "btnEditCustomerDeviceInfo";
			this.btnEditCustomerDeviceInfo.Size = new System.Drawing.Size(60, 60);
			this.btnEditCustomerDeviceInfo.TabIndex = 13;
			this.btnEditCustomerDeviceInfo.UseVisualStyleBackColor = false;
			this.btnEditCustomerDeviceInfo.Click += new System.EventHandler(this.BtnEditCustomerDeviceInfoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(80, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(287, 254);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// FrmEditCustomerDevice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(764, 424);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEditCustomerDeviceInfo);
			this.Controls.Add(this.txtEditFirmwareVersion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtEditType);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEditBrand);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEditIPAddress);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEditNameDevice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEditMAC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEditCustomerDevice";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar Informacion de Dispositivo Domiciliario";
			this.Load += new System.EventHandler(this.FrmEditCustomerDeviceLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
