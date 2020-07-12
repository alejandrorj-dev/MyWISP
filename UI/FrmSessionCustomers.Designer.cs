/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/21/2020
 * Time: 6:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmSessionCustomers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.TextBox txtSearchSessionCustomer;
		private System.Windows.Forms.Button btnSearchSessionCustomer;
		private System.Windows.Forms.DataGridView dgvSessionCustomers;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnRefreshDgv;
		private System.Windows.Forms.Button btnExportToExcel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSessionCustomers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearchSessionCustomer = new System.Windows.Forms.TextBox();
			this.btnSearchSessionCustomer = new System.Windows.Forms.Button();
			this.dgvSessionCustomers = new System.Windows.Forms.DataGridView();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnRefreshDgv = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSessionCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1150, 27);
			this.panel1.TabIndex = 1;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(1095, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1124, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clientes de Sesion Registrados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSearchSessionCustomer
			// 
			this.txtSearchSessionCustomer.Location = new System.Drawing.Point(37, 83);
			this.txtSearchSessionCustomer.Name = "txtSearchSessionCustomer";
			this.txtSearchSessionCustomer.Size = new System.Drawing.Size(230, 20);
			this.txtSearchSessionCustomer.TabIndex = 2;
			// 
			// btnSearchSessionCustomer
			// 
			this.btnSearchSessionCustomer.BackColor = System.Drawing.Color.Teal;
			this.btnSearchSessionCustomer.FlatAppearance.BorderSize = 0;
			this.btnSearchSessionCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchSessionCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSessionCustomer.Image")));
			this.btnSearchSessionCustomer.Location = new System.Drawing.Point(272, 82);
			this.btnSearchSessionCustomer.Name = "btnSearchSessionCustomer";
			this.btnSearchSessionCustomer.Size = new System.Drawing.Size(23, 23);
			this.btnSearchSessionCustomer.TabIndex = 3;
			this.btnSearchSessionCustomer.UseVisualStyleBackColor = false;
			this.btnSearchSessionCustomer.Click += new System.EventHandler(this.BtnSearchSessionCustomerClick);
			// 
			// dgvSessionCustomers
			// 
			this.dgvSessionCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSessionCustomers.BackgroundColor = System.Drawing.Color.White;
			this.dgvSessionCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvSessionCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSessionCustomers.GridColor = System.Drawing.Color.White;
			this.dgvSessionCustomers.Location = new System.Drawing.Point(37, 110);
			this.dgvSessionCustomers.Name = "dgvSessionCustomers";
			this.dgvSessionCustomers.Size = new System.Drawing.Size(1081, 315);
			this.dgvSessionCustomers.TabIndex = 4;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.Teal;
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
			this.btnAddNew.Location = new System.Drawing.Point(1095, 81);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(23, 23);
			this.btnAddNew.TabIndex = 5;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNewClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Teal;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(1066, 81);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Teal;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(1037, 81);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnRefreshDgv
			// 
			this.btnRefreshDgv.BackColor = System.Drawing.Color.Teal;
			this.btnRefreshDgv.FlatAppearance.BorderSize = 0;
			this.btnRefreshDgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshDgv.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDgv.Image")));
			this.btnRefreshDgv.Location = new System.Drawing.Point(978, 81);
			this.btnRefreshDgv.Name = "btnRefreshDgv";
			this.btnRefreshDgv.Size = new System.Drawing.Size(23, 23);
			this.btnRefreshDgv.TabIndex = 8;
			this.btnRefreshDgv.UseVisualStyleBackColor = false;
			this.btnRefreshDgv.Click += new System.EventHandler(this.BtnRefreshDgvClick);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.Green;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
			this.btnExportToExcel.Location = new System.Drawing.Point(509, 447);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(60, 60);
			this.btnExportToExcel.TabIndex = 9;
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcelClick);
			// 
			// FrmSessionCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(1150, 542);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnRefreshDgv);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.dgvSessionCustomers);
			this.Controls.Add(this.btnSearchSessionCustomer);
			this.Controls.Add(this.txtSearchSessionCustomer);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmSessionCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listado de Clientes de Sesion Registrados";
			this.Load += new System.EventHandler(this.FrmSessionCustomersLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvSessionCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
