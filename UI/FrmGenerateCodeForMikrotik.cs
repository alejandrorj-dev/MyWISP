/*
 * Created in SharpDevelop by Alejandro Rodríguez Jiménez.
 * User: HP
 * Date: 2/28/2020
 * Time: 2:28 PM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Excel= Microsoft.Office.Interop.Excel;
using EL;
using BL;

namespace UI
{
	/// <summary>
	/// This class it allows to generate codes for mikrotik.
	/// </summary>
	public partial class FrmGenerateCodeForMikrotik : Form
	{
		public FrmGenerateCodeForMikrotik()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private	List<VoucherCode> MyListVoucherCode {get;set;}
		private	List<LoginTicket> MyListLoginTicket {get;set;}
		
		
		int GenerateNumberRandom(int min, int max)
		{
			Random MyRandomNumber = new Random();
			return MyRandomNumber.Next(min, max);
		}
		
		String GenerateRandomString(int size, bool lowerCase)
		{
			StringBuilder builder = new StringBuilder(); 
			Random MyRandom = new Random();
		    char MyChar;  
		    
		    for (int i = 0; i < size; i++)  
		    {
		    	var MyGuid = Guid.NewGuid();
		        var OnlyNumbers = new String(MyGuid.ToString().Where(Char.IsDigit).ToArray());
		        var seed = int.Parse(OnlyNumbers.Substring(0, 4));
		
		        var random = new Random(seed);
		        var value = random.Next(0, 5);
		        builder.Append(value);
		        
				MyChar = Convert.ToChar(Convert.ToInt32(Math.Floor( 26 * MyRandom.NextDouble() + 65)));
		        builder.Append(MyChar);  		    
		    }  
		    
		    if (lowerCase)  
		        return builder.ToString().ToLower();  
		    return builder.ToString();			
			
		}
		
		String GeneratePasswordRandom()
		{
			StringBuilder BuilderPassword = new StringBuilder();
			BuilderPassword.Append(GenerateRandomString(1, false));
			BuilderPassword.Append(GenerateNumberRandom(10, 99));
			BuilderPassword.Append(GenerateRandomString(1, false));
			
			return BuilderPassword.ToString();
		}
		
		void BtnGenerateCodeClick(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtAmount.Text))
			{
				MessageBox.Show("Debe ingresar la cantidad de pines a generar.", "Ingrese Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				
				int Amount;
				int Counter = 0;
				List<VoucherCode> ListVoucherCode = new List<VoucherCode>();
				List<LoginTicket> ListLoginTicket = new List<LoginTicket>();
				
				if(Int32.TryParse(txtAmount.Text, out Amount))
				{					
					
						if(!(rbVoucherCodeOnly.Checked) && !(rbUserAndPassword.Checked))
						{
							MessageBox.Show("Por favor, seleccione una opcion entre generar codigo de ticket unicamente o generar usuario y password.", "Seleccione Tipo de Codigo", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						
						if(Amount > 5000)
						{
							MessageBox.Show("La cantidad de pines a generar debe ser igual o inferior a 5000.", "Cantidad de Pines Superada", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							if(rbVoucherCodeOnly.Checked)
							{
								rtbCode.Text = "/ip hotspot user \n";
								
								   if(cboLimitTraffic.Text == "Sin Limite")
									{
									   	if(!(string.IsNullOrEmpty(txtProfileName.Text)))
									   	{
									   		
									   		while(Counter < Amount)
											{
									   			VoucherCode MyVoucherCode = new VoucherCode();
									   			MyVoucherCode.Prefix = txtPrefix.Text;
									   			MyVoucherCode.Time = cboTime.Text;
									   			MyVoucherCode.Profile = txtProfileName.Text;
									   			MyVoucherCode.Code = GenerateRandomString(2, false)+Convert.ToString(Counter)+GeneratePasswordRandom();
										
									   			
									   			rtbCode.AppendText("add name="+MyVoucherCode.Prefix+MyVoucherCode.Code+" limit-uptime="+MyVoucherCode.Time+" disabled=no profile="+"\""+MyVoucherCode.Profile+"\""+" \n");
									   			ListVoucherCode.Add(MyVoucherCode);
												Counter++;
											}
									   		
									   		this.MyListVoucherCode = ListVoucherCode;
									   		
									   	}
									   	else
									   	{
									   		while(Counter < Amount)
											{
									   			VoucherCode MyVoucherCode = new VoucherCode();
									   			MyVoucherCode.Prefix = txtPrefix.Text;
									   			MyVoucherCode.Code = GenerateRandomString(3, false)+Convert.ToString(Counter)+GenerateRandomString(3, false);
									   			MyVoucherCode.Time = cboTime.Text;
									   			
									   			rtbCode.AppendText("add name="+MyVoucherCode.Prefix+MyVoucherCode.Code+" limit-uptime="+MyVoucherCode.Time+" disabled=no"+" \n");
									   			ListVoucherCode.Add(MyVoucherCode);
												Counter++;
											}
									   		
									   		this.MyListVoucherCode = ListVoucherCode;
									   	}
										
									}
									else
									{
										if(!(string.IsNullOrEmpty(txtProfileName.Text)))
										{
											while(Counter < Amount)
											{
												VoucherCode MyVoucerCode = new VoucherCode();
												MyVoucerCode.Prefix = txtPrefix.Text;
												MyVoucerCode.Code = GenerateRandomString(2, false)+Convert.ToString(Counter)+GenerateRandomString(3, false);
												MyVoucerCode.Time = cboTime.Text;
												MyVoucerCode.Profile = txtProfileName.Text;
												MyVoucerCode.TrafficLimit = cboLimitTraffic.Text;
												
												rtbCode.AppendText("add name="+MyVoucerCode.Prefix+MyVoucerCode.Code+" limit-update="+MyVoucerCode.Time+" disabled=no profile="+"\""+MyVoucerCode.Profile+"\""+" limit-bytes-total="+"\""+MyVoucerCode.TrafficLimit+"\""+" \n");
												ListVoucherCode.Add(MyVoucerCode);
												Counter++;
											}
											
										this.MyListVoucherCode = ListVoucherCode;
										}
										else
										{
											while(Counter < Amount)
											{
												VoucherCode MyVoucherCode = new VoucherCode();
												MyVoucherCode.Prefix = txtPrefix.Text;
												MyVoucherCode.Code = GenerateRandomString(3, false)+Convert.ToString(Counter)+GenerateRandomString(2, false);
												MyVoucherCode.Time = cboTime.Text;
												MyVoucherCode.TrafficLimit = cboLimitTraffic.Text;
												
												rtbCode.AppendText("add name="+MyVoucherCode.Prefix+MyVoucherCode.Code+" limit-update="+MyVoucherCode.Time+" disabled=no limit-bytes-total="+"\""+MyVoucherCode.TrafficLimit+"\""+" \n");
												ListVoucherCode.Add(MyVoucherCode);
												Counter++;
											}
											
											this.MyListVoucherCode = ListVoucherCode;
										}
										
										
									}
									
							}
							else if(rbUserAndPassword.Checked)
							{
								rtbCode.Text = "/ip hotspot user \n";
								
								if(cboLimitTraffic.Text == "Sin Limite")
								{
									
									if(!(string.IsNullOrEmpty(txtProfileName.Text)))
									{
										while(Counter < Amount)
										{
											LoginTicket MyLoginTicket = new LoginTicket();
											MyLoginTicket.Prefix = txtPrefix.Text;
											MyLoginTicket.User = GenerateRandomString(2, false)+Convert.ToString(Counter)+GenerateRandomString(3, false);
											MyLoginTicket.Password = GeneratePasswordRandom()+Convert.ToString(Counter)+GenerateRandomString(4, false);
											MyLoginTicket.Time = cboTime.Text;
											MyLoginTicket.Profile = txtProfileName.Text;
											
											rtbCode.AppendText("add name="+MyLoginTicket.Prefix+MyLoginTicket.User+" password="+MyLoginTicket.Password+" limit-uptime="+MyLoginTicket.Time+" disabled=no profile="+"\""+MyLoginTicket.Profile+"\""+" \n");
											ListLoginTicket.Add(MyLoginTicket);
											Counter++;
										}
		
										this.MyListLoginTicket = ListLoginTicket;
									}
									else
									{
										while(Counter < Amount)
										{
											LoginTicket MyLoginTicket = new LoginTicket();
											MyLoginTicket.Prefix = txtPrefix.Text;
											MyLoginTicket.User = GenerateRandomString(1, false)+Convert.ToString(Counter)+GenerateRandomString(4, false);
											MyLoginTicket.Password = Convert.ToString(Counter)+GeneratePasswordRandom()+GenerateRandomString(4, false);
											MyLoginTicket.Time = cboTime.Text;
											
											rtbCode.AppendText("add name="+MyLoginTicket.Prefix+MyLoginTicket.User+" password="+MyLoginTicket.Password+" limit-uptime="+MyLoginTicket.Time+" disabled=no"+" \n");
											ListLoginTicket.Add(MyLoginTicket);
											Counter++;
										}
										
										this.MyListLoginTicket = ListLoginTicket;
									}
									
								}
								else
								{ 
									if(!(string.IsNullOrEmpty(txtProfileName.Text)))
									{
										while(Counter < Amount)
										{
											LoginTicket MyLoginTicket = new LoginTicket();
											MyLoginTicket.Prefix = txtPrefix.Text;
											MyLoginTicket.User = Convert.ToString(Counter)+GenerateRandomString(3, false)+GenerateRandomString(3, false);
											MyLoginTicket.Password = GenerateRandomString(3, false)+GeneratePasswordRandom()+Convert.ToString(Counter)+GenerateRandomString(3, false);
											MyLoginTicket.Time = cboTime.Text;
											MyLoginTicket.Profile = txtProfileName.Text;
											MyLoginTicket.TrafficLimit = cboLimitTraffic.Text;
											
											rtbCode.AppendText("add name="+MyLoginTicket.Prefix+MyLoginTicket.User+" password="+MyLoginTicket.Password+" limit-uptime="+MyLoginTicket.Time+" disabled=no profile="+"\""+MyLoginTicket.Profile+"\""+" limit-bytes-total="+"\""+MyLoginTicket.TrafficLimit+"\""+" \n");
											ListLoginTicket.Add(MyLoginTicket);
											Counter++;
										}
										
										this.MyListLoginTicket = ListLoginTicket;
									}
									else
									{
										while(Counter < Amount)
										{
											LoginTicket MyLoginTicket = new LoginTicket();
											MyLoginTicket.Prefix = txtPrefix.Text;
											MyLoginTicket.User = GenerateRandomString(3, true)+Convert.ToString(Counter)+GenerateRandomString(3, false);
											MyLoginTicket.Password = GenerateRandomString(3, false)+GeneratePasswordRandom()+Convert.ToString(Counter)+GenerateRandomString(3, false);
											MyLoginTicket.Time = cboTime.Text;
											MyLoginTicket.TrafficLimit = cboLimitTraffic.Text;
											
											rtbCode.AppendText("add name="+MyLoginTicket.Prefix+MyLoginTicket.User+" password="+MyLoginTicket.Password+" limit-uptime="+MyLoginTicket.Time+" disabled=no limit-bytes-total="+"\""+MyLoginTicket.TrafficLimit+"\""+" \n");
											ListLoginTicket.Add(MyLoginTicket);
											Counter++;
										}
										
										this.MyListLoginTicket = ListLoginTicket;
									}
									
				
								}
							}
													
						}					
					
				
				}
				else
				{
					MessageBox.Show("Solo se acepta números enteros en la cantidad", "Ingrese Solo Números Enteros en la Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}			
				
				
			}
			
			btnGenerateExcel.Enabled = true;
		}
		
		void FrmGenerateCodeForMikrotikLoad(object sender, EventArgs e)
		{
			LoadTimes();
			LoadTrafficLimits();
			
			cboTime.SelectedIndex = 1;
			cboLimitTraffic.SelectedIndex = 0;
			
			btnGenerateExcel.Enabled = false;
		}
		
		
		
		void LoadTimes()
		{
			cboTime.Items.Insert(0, "00:00:00");
			cboTime.Items.Insert(1, "00:15:00");
			cboTime.Items.Insert(2, "00:30:00");
			cboTime.Items.Insert(3, "00:45:00");
			cboTime.Items.Insert(4, "01:00:00");
			cboTime.Items.Insert(5, "02:00:00");
			cboTime.Items.Insert(6, "03:00:00");
			cboTime.Items.Insert(7, "04:00:00");
			cboTime.Items.Insert(8, "05:00:00");
			cboTime.Items.Insert(9, "06:00:00");
			cboTime.Items.Insert(10, "07:00:00");
			cboTime.Items.Insert(11, "08:00:00");
			cboTime.Items.Insert(12, "09:00:00");
			cboTime.Items.Insert(13, "10:00:00");
			cboTime.Items.Insert(14, "11:00:00");
			cboTime.Items.Insert(15, "12:00:00");
			cboTime.Items.Insert(16, "13:00:00");
			cboTime.Items.Insert(17, "14:00:00");
			cboTime.Items.Insert(18, "15:00:00");
			cboTime.Items.Insert(19, "16:00:00");
			cboTime.Items.Insert(20, "17:00:00");
			cboTime.Items.Insert(21, "18:00:00");
			cboTime.Items.Insert(22, "19:00:00");
			cboTime.Items.Insert(23, "20:00:00");
			cboTime.Items.Insert(24, "21:00:00");
			cboTime.Items.Insert(25, "22:00:00");
			cboTime.Items.Insert(26, "23:00:00");
			cboTime.Items.Insert(27, "24:00:00");
			
		}
		
		void LoadTrafficLimits()
		{
			cboLimitTraffic.Items.Insert(0, "Sin Limite");
			cboLimitTraffic.Items.Insert(1, "1M");
			cboLimitTraffic.Items.Insert(2, "2M");
			cboLimitTraffic.Items.Insert(3, "3M");
			cboLimitTraffic.Items.Insert(4, "4M");
			cboLimitTraffic.Items.Insert(5, "5M");
			cboLimitTraffic.Items.Insert(6, "6M");
			cboLimitTraffic.Items.Insert(7, "7M");
			cboLimitTraffic.Items.Insert(8, "8M");
			cboLimitTraffic.Items.Insert(9, "9M");
			cboLimitTraffic.Items.Insert(10, "10M");
			cboLimitTraffic.Items.Insert(11, "15M");
			cboLimitTraffic.Items.Insert(12, "20M");
			cboLimitTraffic.Items.Insert(13, "25M");
			cboLimitTraffic.Items.Insert(14, "30M");
			cboLimitTraffic.Items.Insert(15, "35M");
			cboLimitTraffic.Items.Insert(16, "40M");
			cboLimitTraffic.Items.Insert(17, "45M");
			cboLimitTraffic.Items.Insert(18, "50M");
			cboLimitTraffic.Items.Insert(19, "60M");
			cboLimitTraffic.Items.Insert(20, "70M");
			cboLimitTraffic.Items.Insert(21, "80M");
			cboLimitTraffic.Items.Insert(22, "90M");
			cboLimitTraffic.Items.Insert(23, "100M");
			cboLimitTraffic.Items.Insert(24, "200M");
			cboLimitTraffic.Items.Insert(25, "300M");
			cboLimitTraffic.Items.Insert(26, "400M");
			cboLimitTraffic.Items.Insert(27, "1000M");
			cboLimitTraffic.Items.Insert(28, "2000M");
			cboLimitTraffic.Items.Insert(29, "3000M");
			cboLimitTraffic.Items.Insert(30, "4000M");
			cboLimitTraffic.Items.Insert(31, "5000M");
			cboLimitTraffic.Items.Insert(32, "6000M");
			cboLimitTraffic.Items.Insert(33, "7000M");
			cboLimitTraffic.Items.Insert(34, "8000M");
			cboLimitTraffic.Items.Insert(35, "9000M");
			cboLimitTraffic.Items.Insert(36, "10000M");
			cboLimitTraffic.Items.Insert(37, "20000M");
			cboLimitTraffic.Items.Insert(38, "30000M");
			cboLimitTraffic.Items.Insert(39, "40000M");
			cboLimitTraffic.Items.Insert(40, "50000M");
			
		}
		
		void ShowNoLimit()
		{
			if(cboTime.Text == "00:00:00")
			{
				lblAdvertisement.Text = "Sin Limite";
			}
			else
			{
				lblAdvertisement.Text = "";
			}
		}
		
		
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void CboTimeSelectionChangeCommitted(object sender, EventArgs e)
		{
			ShowNoLimit();
		}
		void BtnGenerateExcelClick(object sender, EventArgs e)
		{
			if(MyListVoucherCode != null)
			{
				ExcelReport.GenerateVoucherCodesForExcel(MyListVoucherCode, txtProfileName.Text, txtPrefix.Text);
			}
			else if(MyListLoginTicket != null)
			{
				ExcelReport.GenerateLoginTicketForExcel(MyListLoginTicket, txtProfileName.Text, txtPrefix.Text);
			}
		}
	}
}
