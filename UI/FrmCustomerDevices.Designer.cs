/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/19/2020
 * Time: 6:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmCustomerDevices
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvCustomerDevices;
		private System.Windows.Forms.TextBox txtSearchCustomerDevice;
		private System.Windows.Forms.Button btnSearchCustomerDevice;
		private System.Windows.Forms.Button btnEditCustomerDevice;
		private System.Windows.Forms.Button btnExportExcel;
		private System.Windows.Forms.Button btnRefresh;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerDevices));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtSearchCustomerDevice = new System.Windows.Forms.TextBox();
			this.btnSearchCustomerDevice = new System.Windows.Forms.Button();
			this.btnEditCustomerDevice = new System.Windows.Forms.Button();
			this.dgvCustomerDevices = new System.Windows.Forms.DataGridView();
			this.btnExportExcel = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDevices)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1157, 27);
			this.panel1.TabIndex = 0;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(1102, 3);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dispositivos Domiciliarios";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1131, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// txtSearchCustomerDevice
			// 
			this.txtSearchCustomerDevice.Location = new System.Drawing.Point(42, 72);
			this.txtSearchCustomerDevice.Name = "txtSearchCustomerDevice";
			this.txtSearchCustomerDevice.Size = new System.Drawing.Size(268, 20);
			this.txtSearchCustomerDevice.TabIndex = 2;
			this.txtSearchCustomerDevice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchCustomerDeviceKeyPress);
			// 
			// btnSearchCustomerDevice
			// 
			this.btnSearchCustomerDevice.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSearchCustomerDevice.FlatAppearance.BorderSize = 0;
			this.btnSearchCustomerDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchCustomerDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomerDevice.Image")));
			this.btnSearchCustomerDevice.Location = new System.Drawing.Point(314, 72);
			this.btnSearchCustomerDevice.Name = "btnSearchCustomerDevice";
			this.btnSearchCustomerDevice.Size = new System.Drawing.Size(21, 21);
			this.btnSearchCustomerDevice.TabIndex = 3;
			this.btnSearchCustomerDevice.UseVisualStyleBackColor = false;
			// 
			// btnEditCustomerDevice
			// 
			this.btnEditCustomerDevice.BackColor = System.Drawing.Color.DarkGreen;
			this.btnEditCustomerDevice.FlatAppearance.BorderSize = 0;
			this.btnEditCustomerDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCustomerDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomerDevice.Image")));
			this.btnEditCustomerDevice.Location = new System.Drawing.Point(1103, 72);
			this.btnEditCustomerDevice.Name = "btnEditCustomerDevice";
			this.btnEditCustomerDevice.Size = new System.Drawing.Size(21, 21);
			this.btnEditCustomerDevice.TabIndex = 5;
			this.btnEditCustomerDevice.UseVisualStyleBackColor = false;
			this.btnEditCustomerDevice.Click += new System.EventHandler(this.BtnEditCustomerDeviceClick);
			// 
			// dgvCustomerDevices
			// 
			this.dgvCustomerDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomerDevices.BackgroundColor = System.Drawing.Color.White;
			this.dgvCustomerDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomerDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerDevices.GridColor = System.Drawing.Color.White;
			this.dgvCustomerDevices.Location = new System.Drawing.Point(42, 98);
			this.dgvCustomerDevices.Name = "dgvCustomerDevices";
			this.dgvCustomerDevices.Size = new System.Drawing.Size(1083, 366);
			this.dgvCustomerDevices.TabIndex = 1;
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExcel.BackColor = System.Drawing.Color.Green;
			this.btnExportExcel.FlatAppearance.BorderSize = 0;
			this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
			this.btnExportExcel.Location = new System.Drawing.Point(563, 489);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(62, 60);
			this.btnExportExcel.TabIndex = 6;
			this.btnExportExcel.UseVisualStyleBackColor = false;
			this.btnExportExcel.Click += new System.EventHandler(this.BtnExportExcelClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.DarkGreen;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(1029, 72);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(21, 21);
			this.btnRefresh.TabIndex = 7;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// FrmCustomerDevices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumAquamarine;
			this.ClientSize = new System.Drawing.Size(1157, 568);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.btnEditCustomerDevice);
			this.Controls.Add(this.btnSearchCustomerDevice);
			this.Controls.Add(this.txtSearchCustomerDevice);
			this.Controls.Add(this.dgvCustomerDevices);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCustomerDevices";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dispositivos Domiciliarios";
			this.Load += new System.EventHandler(this.FrmCustomerDevicesLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDevices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
