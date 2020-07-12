/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 05/03/2020
 * Time: 5:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmEquipments
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvEquipments;
		private System.Windows.Forms.TextBox txtSearchEquipment;
		private System.Windows.Forms.Button btnSearchEquipment;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnExportToExcel;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEquipments));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvEquipments = new System.Windows.Forms.DataGridView();
			this.txtSearchEquipment = new System.Windows.Forms.TextBox();
			this.btnSearchEquipment = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1227, 25);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Equipos de Red Registrados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(1169, 1);
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
			this.btnClose.Location = new System.Drawing.Point(1200, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// dgvEquipments
			// 
			this.dgvEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEquipments.BackgroundColor = System.Drawing.Color.White;
			this.dgvEquipments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipments.GridColor = System.Drawing.Color.White;
			this.dgvEquipments.Location = new System.Drawing.Point(33, 100);
			this.dgvEquipments.Name = "dgvEquipments";
			this.dgvEquipments.Size = new System.Drawing.Size(1159, 371);
			this.dgvEquipments.TabIndex = 1;
			// 
			// txtSearchEquipment
			// 
			this.txtSearchEquipment.Location = new System.Drawing.Point(34, 74);
			this.txtSearchEquipment.Name = "txtSearchEquipment";
			this.txtSearchEquipment.Size = new System.Drawing.Size(212, 20);
			this.txtSearchEquipment.TabIndex = 2;
			this.txtSearchEquipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchEquipmentKeyPress);
			// 
			// btnSearchEquipment
			// 
			this.btnSearchEquipment.BackColor = System.Drawing.Color.DimGray;
			this.btnSearchEquipment.FlatAppearance.BorderSize = 0;
			this.btnSearchEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchEquipment.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEquipment.Image")));
			this.btnSearchEquipment.Location = new System.Drawing.Point(251, 73);
			this.btnSearchEquipment.Name = "btnSearchEquipment";
			this.btnSearchEquipment.Size = new System.Drawing.Size(23, 23);
			this.btnSearchEquipment.TabIndex = 3;
			this.btnSearchEquipment.UseVisualStyleBackColor = false;
			this.btnSearchEquipment.Click += new System.EventHandler(this.BtnSearchEquipmentClick);
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.DimGray;
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
			this.btnAddNew.Location = new System.Drawing.Point(1166, 73);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(23, 23);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNewClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.DimGray;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(1137, 73);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 23);
			this.btnEdit.TabIndex = 5;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.DimGray;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(1108, 73);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 23);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.DarkGreen;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
			this.btnExportToExcel.Location = new System.Drawing.Point(583, 489);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(64, 60);
			this.btnExportToExcel.TabIndex = 10;
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcelClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(1050, 73);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(23, 23);
			this.btnRefresh.TabIndex = 11;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// FrmEquipments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1227, 570);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnSearchEquipment);
			this.Controls.Add(this.txtSearchEquipment);
			this.Controls.Add(this.dgvEquipments);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEquipments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Equipos & Nodos";
			this.Load += new System.EventHandler(this.FrmEquipmentsLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
