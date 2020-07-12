/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/10/2020
 * Time: 11:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmServicesAux
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.DataGridView dgvServices;
		private System.Windows.Forms.TextBox txtSearchPlan;
		private System.Windows.Forms.Button btnSearchService;
		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnCancel;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicesAux));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvServices = new System.Windows.Forms.DataGridView();
			this.txtSearchPlan = new System.Windows.Forms.TextBox();
			this.btnSearchService = new System.Windows.Forms.Button();
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(624, 26);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Planes de Servicio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(596, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// dgvServices
			// 
			this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvServices.BackgroundColor = System.Drawing.Color.White;
			this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServices.Location = new System.Drawing.Point(22, 116);
			this.dgvServices.Name = "dgvServices";
			this.dgvServices.Size = new System.Drawing.Size(579, 223);
			this.dgvServices.TabIndex = 1;
			// 
			// txtSearchPlan
			// 
			this.txtSearchPlan.Location = new System.Drawing.Point(22, 90);
			this.txtSearchPlan.Name = "txtSearchPlan";
			this.txtSearchPlan.Size = new System.Drawing.Size(201, 20);
			this.txtSearchPlan.TabIndex = 2;
			// 
			// btnSearchService
			// 
			this.btnSearchService.BackColor = System.Drawing.Color.SlateBlue;
			this.btnSearchService.FlatAppearance.BorderSize = 0;
			this.btnSearchService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchService.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchService.Image")));
			this.btnSearchService.Location = new System.Drawing.Point(227, 90);
			this.btnSearchService.Name = "btnSearchService";
			this.btnSearchService.Size = new System.Drawing.Size(21, 21);
			this.btnSearchService.TabIndex = 3;
			this.btnSearchService.UseVisualStyleBackColor = false;
			this.btnSearchService.Click += new System.EventHandler(this.BtnSearchServiceClick);
			// 
			// btnAccept
			// 
			this.btnAccept.FlatAppearance.BorderSize = 0;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
			this.btnAccept.Location = new System.Drawing.Point(24, 345);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(40, 40);
			this.btnAccept.TabIndex = 4;
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.BtnAcceptClick);
			// 
			// btnCancel
			// 
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(561, 345);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(40, 40);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// FrmServicesAux
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.ClientSize = new System.Drawing.Size(624, 397);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnSearchService);
			this.Controls.Add(this.txtSearchPlan);
			this.Controls.Add(this.dgvServices);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmServicesAux";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Planes de Servicio";
			this.Load += new System.EventHandler(this.FrmServicesAuxLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
