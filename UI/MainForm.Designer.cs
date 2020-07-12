/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/01/2020
 * Time: 17:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnCustomerAntennas;
		private System.Windows.Forms.Button btnSessionCustomer;
		private System.Windows.Forms.Button btnServicePlan;
		private System.Windows.Forms.Button btnEquipments;
		private System.Windows.Forms.Label lblNameUser;
		private System.Windows.Forms.Button btnUsers;
		private System.Windows.Forms.Button txtPinGenerate;
		private System.Windows.Forms.Button btnMinimize;
		private System.Windows.Forms.Button btnPointOfSale;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.Button btnDate;
		private System.Windows.Forms.Label lblDayOfDate;
		private System.Windows.Forms.Label lblDayOfWeek;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMinimize = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnCustomerAntennas = new System.Windows.Forms.Button();
			this.btnSessionCustomer = new System.Windows.Forms.Button();
			this.btnServicePlan = new System.Windows.Forms.Button();
			this.btnEquipments = new System.Windows.Forms.Button();
			this.lblNameUser = new System.Windows.Forms.Label();
			this.btnUsers = new System.Windows.Forms.Button();
			this.txtPinGenerate = new System.Windows.Forms.Button();
			this.btnPointOfSale = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnDate = new System.Windows.Forms.Button();
			this.lblDayOfDate = new System.Windows.Forms.Label();
			this.lblDayOfWeek = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnMinimize);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(988, 28);
			this.panel1.TabIndex = 0;
			// 
			// btnMinimize
			// 
			this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimize.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
			this.btnMinimize.Location = new System.Drawing.Point(939, 2);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new System.Drawing.Size(23, 23);
			this.btnMinimize.TabIndex = 2;
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new System.EventHandler(this.BtnMinimizeClick);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(963, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(62, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(545, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "My WISP Sistema de Informacion v1.0";
			// 
			// btnCustomers
			// 
			this.btnCustomers.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomers.FlatAppearance.BorderSize = 0;
			this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomers.ForeColor = System.Drawing.Color.White;
			this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
			this.btnCustomers.Location = new System.Drawing.Point(318, 197);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(150, 150);
			this.btnCustomers.TabIndex = 2;
			this.btnCustomers.Text = "Clientes";
			this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnCustomers.UseVisualStyleBackColor = false;
			this.btnCustomers.Click += new System.EventHandler(this.BtnCustomersClick);
			// 
			// btnCustomerAntennas
			// 
			this.btnCustomerAntennas.BackColor = System.Drawing.Color.ForestGreen;
			this.btnCustomerAntennas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerAntennas.FlatAppearance.BorderSize = 0;
			this.btnCustomerAntennas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerAntennas.ForeColor = System.Drawing.Color.White;
			this.btnCustomerAntennas.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerAntennas.Image")));
			this.btnCustomerAntennas.Location = new System.Drawing.Point(474, 197);
			this.btnCustomerAntennas.Name = "btnCustomerAntennas";
			this.btnCustomerAntennas.Size = new System.Drawing.Size(150, 150);
			this.btnCustomerAntennas.TabIndex = 3;
			this.btnCustomerAntennas.Text = "Equipos Domiciliarios";
			this.btnCustomerAntennas.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnCustomerAntennas.UseVisualStyleBackColor = false;
			this.btnCustomerAntennas.Click += new System.EventHandler(this.BtnCustomerAntennasClick);
			// 
			// btnSessionCustomer
			// 
			this.btnSessionCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnSessionCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSessionCustomer.FlatAppearance.BorderSize = 0;
			this.btnSessionCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSessionCustomer.ForeColor = System.Drawing.Color.White;
			this.btnSessionCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSessionCustomer.Image")));
			this.btnSessionCustomer.Location = new System.Drawing.Point(318, 353);
			this.btnSessionCustomer.Name = "btnSessionCustomer";
			this.btnSessionCustomer.Size = new System.Drawing.Size(150, 150);
			this.btnSessionCustomer.TabIndex = 4;
			this.btnSessionCustomer.Text = "Clientes de Sesion";
			this.btnSessionCustomer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnSessionCustomer.UseVisualStyleBackColor = false;
			this.btnSessionCustomer.Click += new System.EventHandler(this.BtnSessionCustomerClick);
			// 
			// btnServicePlan
			// 
			this.btnServicePlan.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnServicePlan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnServicePlan.FlatAppearance.BorderSize = 0;
			this.btnServicePlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnServicePlan.ForeColor = System.Drawing.Color.White;
			this.btnServicePlan.Image = ((System.Drawing.Image)(resources.GetObject("btnServicePlan.Image")));
			this.btnServicePlan.Location = new System.Drawing.Point(630, 197);
			this.btnServicePlan.Name = "btnServicePlan";
			this.btnServicePlan.Size = new System.Drawing.Size(150, 150);
			this.btnServicePlan.TabIndex = 5;
			this.btnServicePlan.Text = "Planes de Servicio";
			this.btnServicePlan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnServicePlan.UseVisualStyleBackColor = false;
			this.btnServicePlan.Click += new System.EventHandler(this.BtnServicePlanClick);
			// 
			// btnEquipments
			// 
			this.btnEquipments.BackColor = System.Drawing.Color.Gray;
			this.btnEquipments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEquipments.FlatAppearance.BorderSize = 0;
			this.btnEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEquipments.ForeColor = System.Drawing.Color.White;
			this.btnEquipments.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipments.Image")));
			this.btnEquipments.Location = new System.Drawing.Point(786, 353);
			this.btnEquipments.Name = "btnEquipments";
			this.btnEquipments.Size = new System.Drawing.Size(150, 150);
			this.btnEquipments.TabIndex = 6;
			this.btnEquipments.Text = "Equipos y Nodos";
			this.btnEquipments.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnEquipments.UseVisualStyleBackColor = false;
			this.btnEquipments.Click += new System.EventHandler(this.BtnEquipmentsClick);
			// 
			// lblNameUser
			// 
			this.lblNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNameUser.ForeColor = System.Drawing.Color.White;
			this.lblNameUser.Location = new System.Drawing.Point(600, 532);
			this.lblNameUser.Name = "lblNameUser";
			this.lblNameUser.Size = new System.Drawing.Size(353, 18);
			this.lblNameUser.TabIndex = 0;
			this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnUsers
			// 
			this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUsers.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnUsers.FlatAppearance.BorderSize = 0;
			this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
			this.btnUsers.Location = new System.Drawing.Point(956, 531);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(20, 20);
			this.btnUsers.TabIndex = 8;
			this.btnUsers.UseVisualStyleBackColor = false;
			this.btnUsers.Click += new System.EventHandler(this.BtnNewUserClick);
			// 
			// txtPinGenerate
			// 
			this.txtPinGenerate.BackColor = System.Drawing.Color.DarkCyan;
			this.txtPinGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtPinGenerate.FlatAppearance.BorderSize = 0;
			this.txtPinGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.txtPinGenerate.ForeColor = System.Drawing.Color.White;
			this.txtPinGenerate.Image = ((System.Drawing.Image)(resources.GetObject("txtPinGenerate.Image")));
			this.txtPinGenerate.Location = new System.Drawing.Point(630, 353);
			this.txtPinGenerate.Name = "txtPinGenerate";
			this.txtPinGenerate.Size = new System.Drawing.Size(150, 150);
			this.txtPinGenerate.TabIndex = 9;
			this.txtPinGenerate.Text = "Generador de Pines";
			this.txtPinGenerate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.txtPinGenerate.UseVisualStyleBackColor = false;
			this.txtPinGenerate.Click += new System.EventHandler(this.TxtPinGenerateClick);
			// 
			// btnPointOfSale
			// 
			this.btnPointOfSale.BackColor = System.Drawing.Color.DarkTurquoise;
			this.btnPointOfSale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPointOfSale.FlatAppearance.BorderSize = 0;
			this.btnPointOfSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPointOfSale.ForeColor = System.Drawing.Color.White;
			this.btnPointOfSale.Image = ((System.Drawing.Image)(resources.GetObject("btnPointOfSale.Image")));
			this.btnPointOfSale.Location = new System.Drawing.Point(474, 353);
			this.btnPointOfSale.Name = "btnPointOfSale";
			this.btnPointOfSale.Size = new System.Drawing.Size(150, 150);
			this.btnPointOfSale.TabIndex = 10;
			this.btnPointOfSale.Text = "Puntos de Venta";
			this.btnPointOfSale.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnPointOfSale.UseVisualStyleBackColor = false;
			this.btnPointOfSale.Click += new System.EventHandler(this.BtnPointOfSaleClick);
			// 
			// btnAbout
			// 
			this.btnAbout.BackColor = System.Drawing.Color.Navy;
			this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAbout.FlatAppearance.BorderSize = 0;
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.ForeColor = System.Drawing.Color.White;
			this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
			this.btnAbout.Location = new System.Drawing.Point(786, 197);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(150, 150);
			this.btnAbout.TabIndex = 11;
			this.btnAbout.Text = "Acerca de";
			this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
			// 
			// btnDate
			// 
			this.btnDate.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnDate.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnDate.FlatAppearance.BorderSize = 0;
			this.btnDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
			this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDate.ForeColor = System.Drawing.Color.White;
			this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
			this.btnDate.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.btnDate.Location = new System.Drawing.Point(162, 197);
			this.btnDate.Name = "btnDate";
			this.btnDate.Size = new System.Drawing.Size(150, 306);
			this.btnDate.TabIndex = 12;
			this.btnDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDate.UseVisualStyleBackColor = false;
			// 
			// lblDayOfDate
			// 
			this.lblDayOfDate.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.lblDayOfDate.Font = new System.Drawing.Font("Arial", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDayOfDate.ForeColor = System.Drawing.Color.White;
			this.lblDayOfDate.Location = new System.Drawing.Point(162, 257);
			this.lblDayOfDate.Name = "lblDayOfDate";
			this.lblDayOfDate.Size = new System.Drawing.Size(150, 68);
			this.lblDayOfDate.TabIndex = 13;
			this.lblDayOfDate.Text = "11";
			this.lblDayOfDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblDayOfWeek
			// 
			this.lblDayOfWeek.BackColor = System.Drawing.Color.DarkSlateBlue;
			this.lblDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDayOfWeek.ForeColor = System.Drawing.Color.White;
			this.lblDayOfWeek.Location = new System.Drawing.Point(162, 325);
			this.lblDayOfWeek.Name = "lblDayOfWeek";
			this.lblDayOfWeek.Size = new System.Drawing.Size(150, 17);
			this.lblDayOfWeek.TabIndex = 14;
			this.lblDayOfWeek.Text = "Miércoles";
			this.lblDayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(988, 563);
			this.Controls.Add(this.lblDayOfWeek);
			this.Controls.Add(this.lblDayOfDate);
			this.Controls.Add(this.btnDate);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnPointOfSale);
			this.Controls.Add(this.txtPinGenerate);
			this.Controls.Add(this.lblNameUser);
			this.Controls.Add(this.btnUsers);
			this.Controls.Add(this.btnEquipments);
			this.Controls.Add(this.btnServicePlan);
			this.Controls.Add(this.btnSessionCustomer);
			this.Controls.Add(this.btnCustomerAntennas);
			this.Controls.Add(this.btnCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "My WISP S. I.  - Inicio";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
