/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/26/2020
 * Time: 4:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmPointsOfSale
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.TextBox txtSearchPointOfSale;
		private System.Windows.Forms.Button btnSearchPointOfSale;
		private System.Windows.Forms.DataGridView dgvPointsOfSale;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRefresh;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPointsOfSale));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtSearchPointOfSale = new System.Windows.Forms.TextBox();
			this.btnSearchPointOfSale = new System.Windows.Forms.Button();
			this.dgvPointsOfSale = new System.Windows.Forms.DataGridView();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPointsOfSale)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CadetBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1191, 27);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Puntos de Venta Registrados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(1135, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 1;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1164, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// txtSearchPointOfSale
			// 
			this.txtSearchPointOfSale.Location = new System.Drawing.Point(40, 85);
			this.txtSearchPointOfSale.Name = "txtSearchPointOfSale";
			this.txtSearchPointOfSale.Size = new System.Drawing.Size(236, 20);
			this.txtSearchPointOfSale.TabIndex = 1;
			// 
			// btnSearchPointOfSale
			// 
			this.btnSearchPointOfSale.BackColor = System.Drawing.Color.CadetBlue;
			this.btnSearchPointOfSale.FlatAppearance.BorderSize = 0;
			this.btnSearchPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchPointOfSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPointOfSale.Image")));
			this.btnSearchPointOfSale.Location = new System.Drawing.Point(282, 83);
			this.btnSearchPointOfSale.Name = "btnSearchPointOfSale";
			this.btnSearchPointOfSale.Size = new System.Drawing.Size(23, 23);
			this.btnSearchPointOfSale.TabIndex = 2;
			this.btnSearchPointOfSale.UseVisualStyleBackColor = false;
			this.btnSearchPointOfSale.Click += new System.EventHandler(this.BtnSearchPointOfSaleClick);
			// 
			// dgvPointsOfSale
			// 
			this.dgvPointsOfSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPointsOfSale.BackgroundColor = System.Drawing.Color.White;
			this.dgvPointsOfSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPointsOfSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPointsOfSale.GridColor = System.Drawing.Color.White;
			this.dgvPointsOfSale.Location = new System.Drawing.Point(40, 112);
			this.dgvPointsOfSale.Name = "dgvPointsOfSale";
			this.dgvPointsOfSale.Size = new System.Drawing.Size(1118, 317);
			this.dgvPointsOfSale.TabIndex = 3;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.CadetBlue;
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
			this.btnAddNew.Location = new System.Drawing.Point(1133, 85);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(23, 23);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNewClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.Location = new System.Drawing.Point(1075, 85);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.CadetBlue;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.Location = new System.Drawing.Point(1104, 85);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(23, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.CadetBlue;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(1005, 85);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(23, 23);
			this.btnRefresh.TabIndex = 7;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.Green;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
			this.btnExportToExcel.Location = new System.Drawing.Point(555, 453);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(60, 60);
			this.btnExportToExcel.TabIndex = 9;
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcelClick);
			// 
			// FrmPointsOfSale
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkTurquoise;
			this.ClientSize = new System.Drawing.Size(1191, 542);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.dgvPointsOfSale);
			this.Controls.Add(this.btnSearchPointOfSale);
			this.Controls.Add(this.txtSearchPointOfSale);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPointsOfSale";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Puntos de Venta Registrados";
			this.Load += new System.EventHandler(this.FrmPointsOfSaleLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPointsOfSale)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
