using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MetroFramework.Controls;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200007E RID: 126
	public partial class SystemMethod : Form
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0000471D File Offset: 0x0000291D
		[CompilerGenerated]
		public string TestMap()
		{
			return this.m_InitializerMethod;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00004725 File Offset: 0x00002925
		[CompilerGenerated]
		public void FindMap(string instance)
		{
			this.m_InitializerMethod = instance;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000472E File Offset: 0x0000292E
		[CompilerGenerated]
		public string LogoutMap()
		{
			return this._ListenerMethod;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00004736 File Offset: 0x00002936
		[CompilerGenerated]
		public void ExcludeMap(string asset)
		{
			this._ListenerMethod = asset;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000473F File Offset: 0x0000293F
		[CompilerGenerated]
		public string ListMap()
		{
			return this._FieldMethod;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00004747 File Offset: 0x00002947
		[CompilerGenerated]
		public void CustomizeMap(string first)
		{
			this._FieldMethod = first;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0002724C File Offset: 0x0002544C
		public SystemMethod()
		{
			Class21.smethod_0();
			this.managerMethod = 1792834;
			this.objectMethod = "";
			base..ctor();
			this.InitializeComponent();
			this.webClient_0 = new WebClient();
			this.m_MessageMethod = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
			this.bunifuTextbox2.text = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000044D0 File Offset: 0x000026D0
		protected override void WndProc(ref Message var1)
		{
			base.WndProc(ref var1);
			if (var1.Msg == 132)
			{
				var1.Result = (IntPtr)2;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003A40 File Offset: 0x00001C40
		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000272A8 File Offset: 0x000254A8
		public string InvokeMap(string init)
		{
			string result;
			try
			{
				result = new WebClient().DownloadString(init);
			}
			catch (Exception)
			{
				try
				{
					result = new WebClient().DownloadString(init.Replace("pastebin", "pastebinp"));
				}
				catch (Exception)
				{
					try
					{
						WebClient webClient = new WebClient();
						WebProxy proxy = new WebProxy("80.240.17.199:3128");
						webClient.Proxy = proxy;
						result = webClient.DownloadString(init);
					}
					catch (Exception)
					{
						try
						{
							WebClient webClient2 = new WebClient();
							WebProxy proxy2 = new WebProxy("31.193.196.3:3128");
							webClient2.Proxy = proxy2;
							result = webClient2.DownloadString(init);
						}
						catch (Exception)
						{
							try
							{
								WebClient webClient3 = new WebClient();
								WebProxy proxy3 = new WebProxy("34.90.113.143:3128");
								webClient3.Proxy = proxy3;
								result = webClient3.DownloadString(init);
							}
							catch (Exception ex)
							{
								string str = "No internet? Shutting down for security reasons.  Error: ";
								Exception ex2 = ex;
								MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
								result = "0";
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000023D9 File Offset: 0x000005D9
		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00004750 File Offset: 0x00002950
		private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
		{
			this.bunifuTextbox2.text = this.m_MessageMethod;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00004763 File Offset: 0x00002963
		private void method_0(object sender, EventArgs e)
		{
			MessageBox.Show("", "Premium features and requirements", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000023D9 File Offset: 0x000005D9
		private void iTalk_RichTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000273B4 File Offset: 0x000255B4
		private void SystemMethod_Load(object sender, EventArgs e)
		{
			this.metroTabControl1.SelectedIndex = 0;
			base.Size = new Size(483, 506);
			string text = string.Empty;
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CallMap);
			byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD01JmtleT0=");
			string @string = Encoding.UTF8.GetString(bytes);
			try
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(@string);
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							text = streamReader.ReadToEnd();
						}
					}
				}
				this.metroTextBox9.Text = text.Replace("/r/n", "\r\n");
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't connect to the server. Please check your internet connection. IF ANY OF THE STATUS BOXES ARE RED (ON THE LOGIN SCREEN), THE PREMIUM PURCHASES CAN'T BE SENT. The premium form will now terminate for security reasons.");
				base.Close();
			}
			this.metroTextBox2.Text = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00004778 File Offset: 0x00002978
		private void bunifuThinButton23_Click(object sender, EventArgs e)
		{
			this.radioButton1.Checked = true;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000274E4 File Offset: 0x000256E4
		private void bunifuImageButton2_Click(object sender, EventArgs e)
		{
			this.m_StateMethod = true;
			switch (this.metroTabControl1.SelectedIndex)
			{
			case 0:
				if (!this.radioButton1.Checked)
				{
					MessageBox.Show("You must select a plan in order to continue");
					return;
				}
				break;
			case 1:
			{
				if (this.metroTextBox1.Text == "")
				{
					MessageBox.Show("You must select a username in order to continue");
					return;
				}
				string instance = string.Concat(new string[]
				{
					DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
					"|",
					"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
					"|",
					this.metroTextBox1.Text
				});
				string s = string.Concat(new string[]
				{
					"ausdh0asy",
					"8dUASY",
					this.label3.Text,
					")/",
					"ASydASDIAS"
				});
				byte[] counter = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
				byte[] consumer = new byte[]
				{
					1,
					178,
					187,
					101,
					193,
					229,
					22,
					188,
					231,
					231,
					239,
					37,
					230,
					115,
					7,
					229
				};
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CallMap);
				byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD02JmtleT0=");
				string text = Encoding.UTF8.GetString(bytes) + Worker.InsertList(instance, counter, consumer);
				string text2 = "";
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(text);
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (Stream responseStream = httpWebResponse.GetResponseStream())
					{
						using (StreamReader streamReader = new StreamReader(responseStream))
						{
							text2 = streamReader.ReadToEnd();
						}
					}
				}
				string[] array = text2.Replace("\n", "").Replace(" ", "").Split(new char[]
				{
					'|'
				});
				if (array[0] == "1")
				{
					MessageBox.Show("You already have premium, you can't purchase it again on this machine.");
					return;
				}
				if (array[1] == "1")
				{
					MessageBox.Show("That username is already taken. Please choose another one.");
					return;
				}
				if (!this.metroTextBox6.Text.Contains("@"))
				{
					MessageBox.Show("Please enter a valid email address. Your order will manually be reviewed before being accepted.");
					return;
				}
				if (this.metroTextBox3.Text == "")
				{
					MessageBox.Show("Please enter a valid email address. Your order will manually be reviewed before being accepted.");
					return;
				}
				break;
			}
			case 4:
				if (this.m_RegMethod != null && !(this.metroTextBox10.Text == ""))
				{
					if (MessageBox.Show("Are you sure you would like to submit the order? I'd recommend you to check all the fields before submitting.", "Verify", MessageBoxButtons.YesNo) == DialogResult.No)
					{
						return;
					}
					this.bunifuImageButton1.Enabled = false;
					this.bunifuImageButton2.Enabled = false;
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append(this.metroTextBox1.Text);
					stringBuilder2.Append("|" + this.metroTextBox2.Text);
					stringBuilder2.Append("|" + this.metroTextBox10.Text);
					stringBuilder2.Append("|" + this.metroTextBox6.Text);
					stringBuilder2.Append("|" + this.metroTextBox4.Text);
					stringBuilder2.Append("|" + this.metroTextBox7.Text);
					stringBuilder2.Append("|none");
					stringBuilder2.Append("|2 DLS");
					stringBuilder2.Append("|" + this.metroTextBox3.Text);
					stringBuilder2.Append("|" + this.metroTextBox8.Text);
					Console.WriteLine(stringBuilder2);
					stringBuilder.AppendLine("Your order has successfully been submitted.");
					stringBuilder.AppendLine("");
					stringBuilder.AppendLine("----------Receipt----------");
					if (this.radioButton1.Checked)
					{
						stringBuilder.AppendLine("Plan: Premium (2 DLS/4 USD)");
					}
					stringBuilder.AppendLine("Username: " + this.metroTextBox1.Text);
					stringBuilder.AppendLine("Password: " + this.metroTextBox2.Text);
					stringBuilder.AppendLine("Recovery password: " + this.metroTextBox3.Text);
					stringBuilder.AppendLine("Discord: " + this.metroTextBox7.Text);
					stringBuilder.AppendLine("Email: " + this.metroTextBox6.Text + Class18.smethod_11(28178) + this.metroTextBox4.Text);
					stringBuilder.AppendLine("Verification method: Email");
					stringBuilder.AppendLine("Payment: 2 DLS");
					stringBuilder.AppendLine("Time & date (UTC): " + DateTime.UtcNow.ToString());
					stringBuilder.AppendLine("Payment proof: ");
					this.m_RegMethod.Save("screenshot.jpg", ImageFormat.Jpeg);
					string value;
					using (Image image = Image.FromFile("screenshot.jpg"))
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							image.Save(memoryStream, image.RawFormat);
							value = Convert.ToBase64String(memoryStream.ToArray());
						}
					}
					string text2 = string.Empty;
					try
					{
						string[] array2 = new string[7];
						array2[0] = DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm");
						array2[1] = "|";
						array2[2] = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
						array2[3] = "|";
						array2[4] = this.metroTextBox4.Text;
						array2[5] = "|Premium purchase receipt|";
						int num = 6;
						StringBuilder stringBuilder3 = stringBuilder;
						array2[num] = ((stringBuilder3 != null) ? stringBuilder3.ToString() : null);
						string instance = string.Concat(array2);
						string s = string.Concat(new string[]
						{
							"ausdh0asy",
							"8dUASY",
							this.label4.Text,
							")/",
							"ASydASDIAS"
						});
						byte[] counter = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
						byte[] consumer = new byte[]
						{
							1,
							178,
							187,
							101,
							193,
							229,
							22,
							188,
							231,
							231,
							239,
							37,
							230,
							115,
							7,
							229
						};
						byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD05JmtleT0=");
						string text = Encoding.UTF8.GetString(bytes) + Worker.InsertList(instance, counter, consumer);
						using (WebClient webClient = new WebClient())
						{
							byte[] bytes2 = webClient.UploadValues(text, new NameValueCollection
							{
								{
									"imageData",
									value
								}
							});
							Console.WriteLine("Server Said: " + Encoding.Default.GetString(bytes2));
						}
					}
					catch (Exception)
					{
						MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
						return;
					}
					try
					{
						string[] array3 = new string[5];
						array3[0] = DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm");
						array3[1] = "|";
						array3[2] = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
						array3[3] = "|";
						int num2 = 4;
						StringBuilder stringBuilder4 = stringBuilder2;
						array3[num2] = ((stringBuilder4 != null) ? stringBuilder4.ToString() : null);
						string instance = string.Concat(array3);
						string s = string.Concat(new string[]
						{
							"ausdh0asy",
							"8dUASY",
							this.label4.Text,
							")/",
							"ASydASDIAS"
						});
						byte[] counter = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
						byte[] consumer = new byte[]
						{
							1,
							178,
							187,
							101,
							193,
							229,
							22,
							188,
							231,
							231,
							239,
							37,
							230,
							115,
							7,
							229
						};
						ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CallMap);
						byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMCZrZXk9");
						string text = Encoding.UTF8.GetString(bytes) + Worker.InsertList(instance, counter, consumer);
						HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(text);
						httpWebRequest2.AutomaticDecompression = DecompressionMethods.GZip;
						using (HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse())
						{
							using (Stream responseStream2 = httpWebResponse2.GetResponseStream())
							{
								using (StreamReader streamReader2 = new StreamReader(responseStream2))
								{
									text2 = streamReader2.ReadToEnd();
								}
							}
						}
						string[] array = text2.Replace("\n", "").Replace(" ", "").Split(new char[]
						{
							'|'
						});
						break;
					}
					catch (Exception)
					{
						MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
						break;
					}
				}
				MessageBox.Show("Please add a proof of that you've paid and type your GrowID in the box.");
				return;
			case 5:
			{
				bool @checked = this.radioButton3.Checked;
				break;
			}
			}
			this.metroTabControl1.SelectedIndex = this.metroTabControl1.SelectedIndex + 1;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00004786 File Offset: 0x00002986
		private void bunifuImageButton1_Click(object sender, EventArgs e)
		{
			if (this.metroTabControl1.SelectedIndex < 1)
			{
				return;
			}
			this.m_StateMethod = true;
			this.metroTabControl1.SelectedIndex = this.metroTabControl1.SelectedIndex - 1;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00004053 File Offset: 0x00002253
		public bool CallMap(object last, X509Certificate counter, X509Chain third, SslPolicyErrors last2)
		{
			return true;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000023D9 File Offset: 0x000005D9
		private void metroTile1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00013EE8 File Offset: 0x000120E8
		public string PrepareMap(string task)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] bytes = Encoding.UTF8.GetBytes(task);
			using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
			{
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				result = Convert.ToBase64String(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00013FA4 File Offset: 0x000121A4
		public static string CountMap(string ident)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] array = new byte[ident.Replace(" ", "+").Length];
			array = Convert.FromBase64String(ident.Replace(" ", "+"));
			using (DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider())
			{
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, descryptoServiceProvider.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				result = Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000047B6 File Offset: 0x000029B6
		public int RestartMap(int initmin, int indexOf_map)
		{
			return new Random().Next(initmin, indexOf_map);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000047C4 File Offset: 0x000029C4
		private void bunifuThinButton26_Click(object sender, EventArgs e)
		{
			this.radioButton3.Checked = true;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000047C4 File Offset: 0x000029C4
		private void bunifuThinButton25_Click(object sender, EventArgs e)
		{
			this.radioButton3.Checked = true;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00027E78 File Offset: 0x00026078
		private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.m_StateMethod)
			{
				this._ContextMethod = this.metroTabControl1.SelectedIndex;
				this.m_StateMethod = false;
				switch (this.metroTabControl1.SelectedIndex)
				{
				case 1:
				case 2:
				case 3:
				case 4:
				case 6:
					break;
				case 5:
				{
					bool @checked = this.radioButton3.Checked;
					break;
				}
				default:
					return;
				}
				return;
			}
			this.metroTabControl1.SelectedIndex = this._ContextMethod;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000023D9 File Offset: 0x000005D9
		private void metroTabPage4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00027EF0 File Offset: 0x000260F0
		private void metroTile5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Choose the screenshot";
			openFileDialog.Multiselect = false;
			openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.pictureBox6.Image = Image.FromFile(openFileDialog.FileName);
				this.m_RegMethod = (Bitmap)Image.FromFile(openFileDialog.FileName);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00027F58 File Offset: 0x00026158
		private void metroTile4_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
				this.pictureBox6.Image = bitmap;
				this.m_RegMethod = bitmap;
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000023D9 File Offset: 0x000005D9
		private void metroTextBox9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000023D9 File Offset: 0x000005D9
		private void metroTabControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00027FE4 File Offset: 0x000261E4
		private void metroTabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
		{
			if (this.m_StateMethod)
			{
				this._ContextMethod = this.metroTabControl1.SelectedIndex;
				return;
			}
			try
			{
				e.Cancel = true;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000047D2 File Offset: 0x000029D2
		private void metroTextBox2_TextChanged(object sender, EventArgs e)
		{
			this.metroTextBox2.Text = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00028028 File Offset: 0x00026228
		private void metroTile2_Click(object sender, EventArgs e)
		{
			if (this._RepositoryMethod > 2)
			{
				MessageBox.Show("The code has already been sent!");
				return;
			}
			Random random = new Random();
			this.managerMethod = random.Next(100000, 999999);
			if (this.metroTextBox4.Text.Contains(Class18.smethod_11(5114)))
			{
				if (this.metroTextBox4.Text.Contains("@"))
				{
					string text = string.Empty;
					try
					{
						string instance = string.Concat(new string[]
						{
							DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
							"|",
							"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
							"|",
							this.metroTextBox4.Text,
							"|Verification code|",
							this.managerMethod.ToString()
						});
						string s = string.Concat(new string[]
						{
							"ausdh0asy",
							"8dUASY",
							this.label4.Text,
							")/",
							"ASydASDIAS"
						});
						byte[] counter = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s));
						byte[] consumer = new byte[]
						{
							1,
							178,
							187,
							101,
							193,
							229,
							22,
							188,
							231,
							231,
							239,
							37,
							230,
							115,
							7,
							229
						};
						ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CallMap);
						byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD04JmtleT0=");
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Encoding.UTF8.GetString(bytes) + Worker.InsertList(instance, counter, consumer));
						httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
						using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
						{
							using (Stream responseStream = httpWebResponse.GetResponseStream())
							{
								using (StreamReader streamReader = new StreamReader(responseStream))
								{
									text = streamReader.ReadToEnd();
								}
							}
						}
						string[] array = text.Replace("\n", "").Split(new char[]
						{
							'|'
						});
						this._RepositoryMethod++;
						MessageBox.Show("Verification code sent! Check all your inboxes\r\nOutput: " + array[0]);
						return;
					}
					catch (Exception)
					{
						MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
						return;
					}
				}
				MessageBox.Show("Please enter a valid email address");
				return;
			}
			MessageBox.Show("Please enter a valid email address");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000282D4 File Offset: 0x000264D4
		private void metroTile3_Click(object sender, EventArgs e)
		{
			if (this.metroTextBox5.Text == this.managerMethod.ToString())
			{
				this.m_PredicateMethod = this.metroTextBox5.Text;
				this.bool_0 = true;
				MessageBox.Show("Verified!");
				return;
			}
			MessageBox.Show("Incorrect verification code");
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00004803 File Offset: 0x00002A03
		// Note: this type is marked as 'beforefieldinit'.
		static SystemMethod()
		{
			Class21.smethod_0();
			SystemMethod.nameValueCollection_0 = new NameValueCollection();
		}

		// Token: 0x040002E3 RID: 739
		public bool m_SerializerMethod;

		// Token: 0x040002E4 RID: 740
		public string m_MessageMethod;

		// Token: 0x040002E5 RID: 741
		private readonly WebClient webClient_0;

		// Token: 0x040002E6 RID: 742
		private static NameValueCollection nameValueCollection_0;

		// Token: 0x040002E7 RID: 743
		[CompilerGenerated]
		private string m_InitializerMethod;

		// Token: 0x040002E8 RID: 744
		public int managerMethod;

		// Token: 0x040002E9 RID: 745
		[CompilerGenerated]
		private string _ListenerMethod;

		// Token: 0x040002EA RID: 746
		[CompilerGenerated]
		private string _FieldMethod;

		// Token: 0x040002EB RID: 747
		private bool bool_0;

		// Token: 0x040002EC RID: 748
		public string m_PredicateMethod;

		// Token: 0x040002ED RID: 749
		public object _GetterMethod;

		// Token: 0x040002EE RID: 750
		public string objectMethod;

		// Token: 0x040002EF RID: 751
		public object m_RegMethod;

		// Token: 0x040002F0 RID: 752
		public int _ContextMethod;

		// Token: 0x040002F1 RID: 753
		public int _RepositoryMethod;

		// Token: 0x040002F2 RID: 754
		public bool m_StateMethod;
	}
}
