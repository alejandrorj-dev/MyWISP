/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 03/02/2020
 * Time: 10:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmServices
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSearchPlan;
		private System.Windows.Forms.DataGridView dgvServices;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnDeleteService;
		private System.Windows.Forms.Button btnEditService;
		private System.Windows.Forms.TextBox txtSearchService;
		private System.Windows.Forms.Button btnUpdatedgv;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServices));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtSearchService = new System.Windows.Forms.TextBox();
			this.btnSearchPlan = new System.Windows.Forms.Button();
			this.dgvServices = new System.Windows.Forms.DataGridView();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnDeleteService = new System.Windows.Forms.Button();
			this.btnEditService = new System.Windows.Forms.Button();
			this.btnUpdatedgv = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(916, 24);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(2, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Planes de Servicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(893, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// txtSearchService
			// 
			this.txtSearchService.Location = new System.Drawing.Point(30, 114);
			this.txtSearchService.Name = "txtSearchService";
			this.txtSearchService.Size = new System.Drawing.Size(233, 20);
			this.txtSearchService.TabIndex = 1;
			// 
			// btnSearchPlan
			// 
			this.btnSearchPlan.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnSearchPlan.FlatAppearance.BorderSize = 0;
			this.btnSearchPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchPlan.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPlan.Image")));
			this.btnSearchPlan.Location = new System.Drawing.Point(269, 113);
			this.btnSearchPlan.Name = "btnSearchPlan";
			this.btnSearchPlan.Size = new System.Drawing.Size(23, 23);
			this.btnSearchPlan.TabIndex = 2;
			this.btnSearchPlan.UseVisualStyleBackColor = false;
			this.btnSearchPlan.Click += new System.EventHandler(this.BtnSearchPlanClick);
			// 
			// dgvServices
			// 
			this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvServices.BackgroundColor = System.Drawing.Color.White;
			this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServices.Location = new System.Drawing.Point(30, 142);
			this.dgvServices.Name = "dgvServices";
			this.dgvServices.Size = new System.Drawing.Size(853, 259);
			this.dgvServices.TabIndex = 3;
			// 
			// btnAddNew
			// 
			this.btnAddNew.BackColor = System.Drawing.Color.ForestGreen;
			this.btnAddNew.FlatAppearance.BorderSize = 0;
			this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
			this.btnAddNew.Location = new System.Drawing.Point(860, 111);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(23, 23);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.UseVisualStyleBackColor = false;
			this.btnAddNew.Click += new System.EventHandler(this.BtnAddNewClick);
			// 
			// btnDeleteService
			// 
			this.btnDeleteService.BackColor = System.Drawing.Color.Brown;
			this.btnDeleteService.FlatAppearance.BorderSize = 0;
			this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteService.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.Image")));
			this.btnDeleteService.Location = new System.Drawing.Point(831, 111);
			this.btnDeleteService.Name = "btnDeleteService";
			this.btnDeleteService.Size = new System.Drawing.Size(23, 23);
			this.btnDeleteService.TabIndex = 5;
			this.btnDeleteService.UseVisualStyleBackColor = false;
			this.btnDeleteService.Click += new System.EventHandler(this.BtnDeleteServiceClick);
			// 
			// btnEditService
			// 
			this.btnEditService.BackColor = System.Drawing.Color.Teal;
			this.btnEditService.FlatAppearance.BorderSize = 0;
			this.btnEditService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditService.Image = ((System.Drawing.Image)(resources.GetObject("btnEditService.Image")));
			this.btnEditService.Location = new System.Drawing.Point(802, 111);
			this.btnEditService.Name = "btnEditService";
			this.btnEditService.Size = new System.Drawing.Size(23, 23);
			this.btnEditService.TabIndex = 6;
			this.btnEditService.UseVisualStyleBackColor = false;
			this.btnEditService.Click += new System.EventHandler(this.BtnEditServiceClick);
			// 
			// btnUpdatedgv
			// 
			this.btnUpdatedgv.BackColor = System.Drawing.Color.Navy;
			this.btnUpdatedgv.FlatAppearance.BorderSize = 0;
			this.btnUpdatedgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdatedgv.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdatedgv.Image")));
			this.btnUpdatedgv.Location = new System.Drawing.Point(746, 111);
			this.btnUpdatedgv.Name = "btnUpdatedgv";
			this.btnUpdatedgv.Size = new System.Drawing.Size(23, 23);
			this.btnUpdatedgv.TabIndex = 7;
			this.btnUpdatedgv.UseVisualStyleBackColor = false;
			this.btnUpdatedgv.Click += new System.EventHandler(this.BtnUpdatedgvClick);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportToExcel.BackColor = System.Drawing.Color.Green;
			this.btnExportToExcel.FlatAppearance.BorderSize = 0;
			this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
			this.btnExportToExcel.Location = new System.Drawing.Point(426, 420);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(55, 55);
			this.btnExportToExcel.TabIndex = 10;
			this.btnExportToExcel.UseVisualStyleBackColor = false;
			this.btnExportToExcel.Click += new System.EventHandler(this.BtnExportToExcelClick);
			// 
			// FrmServices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(916, 516);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnUpdatedgv);
			this.Controls.Add(this.btnEditService);
			this.Controls.Add(this.btnDeleteService);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.dgvServices);
			this.Controls.Add(this.btnSearchPlan);
			this.Controls.Add(this.txtSearchService);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmServices";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Planes de Servicio";
			this.Load += new System.EventHandler(this.FrmServicesLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}

