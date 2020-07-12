/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 27/01/2020
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmCustomers
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.TextBox txtSeacrhCustomer;
		private System.Windows.Forms.Button btnSearchCustomer;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnEditCustomer;
		private System.Windows.Forms.Button btnRefreshDataGridView;
		private System.Windows.Forms.Button btnGenerateExcelCustomers;
		private System.Windows.Forms.Button btnMinimize;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.txtSeacrhCustomer = new System.Windows.Forms.TextBox();
			this.btnSearchCustomer = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnEditCustomer = new System.Windows.Forms.Button();
			this.btnRefreshDataGridView = new System.Windows.Forms.Button();
			this.btnGenerateExcelCustomers = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1364, 25);
			this.panel1.TabIndex = 0;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(1310, 1);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 3;
			this.btnMinimize.UseVisualStyleBackColor = true;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(1338, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 2;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listado de Clientes";
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
			this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Location = new System.Drawing.Point(66, 134);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.Size = new System.Drawing.Size(1246, 442);
			this.dgvCustomers.TabIndex = 1;
			// 
			// txtSeacrhCustomer
			// 
			this.txtSeacrhCustomer.Location = new System.Drawing.Point(66, 108);
			this.txtSeacrhCustomer.Name = "txtSeacrhCustomer";
			this.txtSeacrhCustomer.Size = new System.Drawing.Size(274, 20);
			this.txtSeacrhCustomer.TabIndex = 2;
			// 
			// btnSearchCustomer
			// 
			this.btnSearchCustomer.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
			this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
			this.btnSearchCustomer.Location = new System.Drawing.Point(343, 108);
			this.btnSearchCustomer.Name = "btnSearchCustomer";
			this.btnSearchCustomer.Size = new System.Drawing.Size(20, 20);
			this.btnSearchCustomer.TabIndex = 3;
			this.btnSearchCustomer.UseVisualStyleBackColor = false;
			this.btnSearchCustomer.Click += new System.EventHandler(this.BtnSearchCustomerClick);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddUser.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddUser.FlatAppearance.BorderSize = 0;
			this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
			this.btnAddUser.Location = new System.Drawing.Point(1290, 110);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Size = new System.Drawing.Size(21, 21);
			this.btnAddUser.TabIndex = 4;
			this.btnAddUser.UseVisualStyleBackColor = false;
			this.btnAddUser.Click += new System.EventHandler(this.BtnAddUserClick);
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditCustomer.BackColor = System.Drawing.Color.MediumBlue;
			this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditCustomer.FlatAppearance.BorderSize = 0;
			this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCustomer.Image")));
			this.btnEditCustomer.Location = new System.Drawing.Point(1263, 110);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(21, 21);
			this.btnEditCustomer.TabIndex = 5;
			this.btnEditCustomer.UseVisualStyleBackColor = false;
			this.btnEditCustomer.Click += new System.EventHandler(this.BtnEditCustomerClick);
			// 
			// btnRefreshDataGridView
			// 
			this.btnRefreshDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefreshDataGridView.BackColor = System.Drawing.Color.Navy;
			this.btnRefreshDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefreshDataGridView.FlatAppearance.BorderSize = 0;
			this.btnRefreshDataGridView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshDataGridView.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDataGridView.Image")));
			this.btnRefreshDataGridView.Location = new System.Drawing.Point(1203, 110);
			this.btnRefreshDataGridView.Name = "btnRefreshDataGridView";
			this.btnRefreshDataGridView.Size = new System.Drawing.Size(21, 21);
			this.btnRefreshDataGridView.TabIndex = 6;
			this.btnRefreshDataGridView.UseVisualStyleBackColor = false;
			this.btnRefreshDataGridView.Click += new System.EventHandler(this.BtnRefreshDataGridViewClick);
			// 
			// btnGenerateExcelCustomers
			// 
			this.btnGenerateExcelCustomers.BackColor = System.Drawing.Color.Green;
			this.btnGenerateExcelCustomers.FlatAppearance.BorderSize = 0;
			this.btnGenerateExcelCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerateExcelCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateExcelCustomers.Image")));
			this.btnGenerateExcelCustomers.Location = new System.Drawing.Point(670, 607);
			this.btnGenerateExcelCustomers.Name = "btnGenerateExcelCustomers";
			this.btnGenerateExcelCustomers.Size = new System.Drawing.Size(60, 60);
			this.btnGenerateExcelCustomers.TabIndex = 7;
			this.btnGenerateExcelCustomers.UseVisualStyleBackColor = false;
			this.btnGenerateExcelCustomers.Click += new System.EventHandler(this.BtnGenerateExcelCustomersClick);
			// 
			// FrmCustomers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DodgerBlue;
			this.ClientSize = new System.Drawing.Size(1364, 727);
			this.Controls.Add(this.btnGenerateExcelCustomers);
			this.Controls.Add(this.btnRefreshDataGridView);
			this.Controls.Add(this.btnEditCustomer);
			this.Controls.Add(this.btnAddUser);
			this.Controls.Add(this.btnSearchCustomer);
			this.Controls.Add(this.txtSeacrhCustomer);
			this.Controls.Add(this.dgvCustomers);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCustomers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listado de Clientes Regsitrados";
			this.Load += new System.EventHandler(this.FrmCustomersLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
