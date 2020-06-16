using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Growtopia_macro.Properties;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000078 RID: 120
	public partial class MethodMethod : Form
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x0000453E File Offset: 0x0000273E
		public MethodMethod()
		{
			Class21.smethod_0();
			this.parameterMethod = "";
			this.string_0 = "";
			this.string_1 = "";
			base..ctor();
			this.m_SpecificationMethod = new ValVisitor();
			this.method_14();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000457D File Offset: 0x0000277D
		public void NewIndexer()
		{
			base.BeginInvoke(new MethodInvoker(this.WriteMap));
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0002666C File Offset: 0x0002486C
		private void method_0(object sender, EventArgs e)
		{
			MethodMethod.<LogIn_Load>d__14 <LogIn_Load>d__;
			<LogIn_Load>d__.<>4__this = this;
			<LogIn_Load>d__.<>t__builder = MethodMethod.smethod_2();
			<LogIn_Load>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <LogIn_Load>d__.<>t__builder;
			<>t__builder.Start<MethodMethod.<LogIn_Load>d__14>(ref <LogIn_Load>d__);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000266A8 File Offset: 0x000248A8
		public static bool DisableIndexer()
		{
			bool result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					using (webClient.OpenRead("http://google.com/generate_204"))
					{
						result = true;
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000044D0 File Offset: 0x000026D0
		protected override void WndProc(ref Message def)
		{
			base.WndProc(ref def);
			if (def.Msg == 132)
			{
				def.Result = (IntPtr)2;
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00026710 File Offset: 0x00024910
		private static void smethod_0(object sender, UnhandledExceptionEventArgs e)
		{
			string path = "Crashlog.txt";
			try
			{
				if (!File.Exists(path))
				{
					using (File.Create(path))
					{
					}
				}
				using (StreamWriter streamWriter = new StreamWriter(path))
				{
					string text = "Error";
					if (e.IsTerminating)
					{
						text = "Crash";
					}
					Exception ex = (Exception)e.ExceptionObject;
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"[Login ",
						text,
						" at ",
						DateTime.Now.ToString(),
						"]"
					}));
					streamWriter.WriteLine("Message: " + ex.Message);
					streamWriter.WriteLine("Source: " + ex.Source);
					streamWriter.WriteLine("StackTrace: " + ex.StackTrace);
					TextWriter textWriter = streamWriter;
					string str = "InnerException: ";
					Exception innerException = ex.InnerException;
					textWriter.WriteLine(str + ((innerException != null) ? innerException.ToString() : null));
					TextWriter textWriter2 = streamWriter;
					string str2 = "Data: ";
					IDictionary data = ex.Data;
					textWriter2.WriteLine(str2 + ((data != null) ? data.ToString() : null));
					streamWriter.WriteLine("Error code: " + ex.HResult.ToString());
					TextWriter textWriter3 = streamWriter;
					string str3 = "Target: ";
					MethodBase targetSite = ex.TargetSite;
					textWriter3.WriteLine(str3 + ((targetSite != null) ? targetSite.ToString() : null));
					streamWriter.WriteLine("--------------------------");
					streamWriter.WriteLine(" ");
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine(ex2.ToString());
			}
			Exception ex3 = (Exception)e.ExceptionObject;
			Console.WriteLine("MyHandler caught : " + ex3.Message);
			Console.WriteLine("Runtime terminating: {0}", e.IsTerminating);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003A40 File Offset: 0x00001C40
		private void method_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00004592 File Offset: 0x00002792
		private void method_2(object object_19)
		{
			this.object_2.Enabled = true;
			this.object_3.Enabled = true;
			this.object_3.text = "Free";
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00026928 File Offset: 0x00024B28
		private void method_3(object object_19)
		{
			this.object_2.Enabled = true;
			this.object_3.Enabled = true;
			if (this.control13_1.method_0())
			{
				this.m_DefinitionMethod = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
				this.object_3.text = "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4";
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000045BC File Offset: 0x000027BC
		private void method_4(object sender, EventArgs e)
		{
			if (this.control13_0.method_0())
			{
				this.object_3.text = "Free";
				return;
			}
			this.object_3.text = this.m_DefinitionMethod;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000045ED File Offset: 0x000027ED
		public bool ResetIndexer()
		{
			return MethodMethod._AttrMethod;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000045F4 File Offset: 0x000027F4
		public string CalculateIndexer()
		{
			return MethodMethod.descriptorMethod;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00026978 File Offset: 0x00024B78
		private void method_5(object sender, EventArgs e)
		{
			this.m_SpecificationMethod = new ValVisitor();
			this.m_SpecificationMethod.Show();
			if (this.control13_0.method_0())
			{
				Settings.Default.Premium = false;
			}
			else
			{
				Settings.Default.Premium = true;
			}
			Settings.Default.Save();
			if (this.control13_1.method_0())
			{
				try
				{
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L1g1N1daWDlB");
					string @string = Encoding.UTF8.GetString(bytes);
					string[] array = this.ComputeIndexer(@string).Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					bool flag = false;
					string[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						if (array2[i].Split(new char[]
						{
							':'
						}).Last<string>() == "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4")
						{
							flag = true;
						}
					}
					if (!flag)
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
								this.object_2.text
							});
							string s = string.Concat(new string[]
							{
								"ausdh0asy",
								"8dUASY",
								this.control_0.Text,
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
							ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.CompareIndexer);
							byte[] bytes2 = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
							HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Encoding.UTF8.GetString(bytes2) + Worker.InsertList(instance, counter, consumer));
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
							text.Replace("\n", "");
							if (text.Replace(" ", "").Split(new char[]
							{
								'|'
							})[0].Contains("1"))
							{
								this.pageMethod = true;
								Settings.Default.Username = this.object_2.text;
								Settings.Default.Save();
								MethodMethod._AttrMethod = true;
								this.tokenMethod = false;
								new ParamVisitor(MethodMethod._AttrMethod, MethodMethod.descriptorMethod, this.object_2.text).Show();
								base.Hide();
							}
							else
							{
								this.pageMethod = false;
							}
						}
						catch (Exception)
						{
							MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
						}
						if (!this.pageMethod)
						{
							MessageBox.Show("The username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.tokenMethod = true;
							MethodMethod._AttrMethod = false;
						}
					}
					else
					{
						MessageBox.Show("Your device is currently blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					goto IL_48B;
				}
				catch (Exception ex)
				{
					string str = "No internet connection, or cannot access database!? \n\rError: ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					goto IL_48B;
				}
			}
			try
			{
				byte[] bytes3 = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L1g1N1daWDlB");
				string string2 = Encoding.UTF8.GetString(bytes3);
				string[] array3 = this.ComputeIndexer(string2).Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				bool flag2 = false;
				string[] array2 = array3;
				for (int i = 0; i < array2.Length; i++)
				{
					if (array2[i].Split(new char[]
					{
						':'
					}).Last<string>() == "59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4")
					{
						flag2 = true;
					}
				}
				if (!flag2)
				{
					Settings.Default.Username = this.object_2.text;
					Settings.Default.Save();
					MethodMethod._AttrMethod = false;
					new ParamVisitor(MethodMethod._AttrMethod, MethodMethod.descriptorMethod, this.object_2.text).Show();
					base.Hide();
				}
				else
				{
					MessageBox.Show("Your device is currently blacklisted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex3)
			{
				string str2 = "Cannot access pastebin! \n\r Error: ";
				Exception ex4 = ex3;
				MessageBox.Show(str2 + ((ex4 != null) ? ex4.ToString() : null), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Settings.Default.Username = this.object_2.text;
				Settings.Default.Save();
				MethodMethod._AttrMethod = false;
				new ParamVisitor(MethodMethod._AttrMethod, MethodMethod.descriptorMethod, this.object_2.text).Show();
				base.Hide();
			}
			IL_48B:
			this.m_SpecificationMethod.Close();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000045FB File Offset: 0x000027FB
		private void method_6(object sender, EventArgs e)
		{
			new SystemMethod().Show();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00004053 File Offset: 0x00002253
		public bool CompareIndexer(object v, X509Certificate cont, X509Chain template, SslPolicyErrors spec2)
		{
			return true;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_7(object sender, DragEventArgs e)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_8(object sender, DragEventArgs e)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00004607 File Offset: 0x00002807
		public static string CalcIndexer()
		{
			return "ausdh0asy";
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00026EB0 File Offset: 0x000250B0
		public void GetIndexer()
		{
			try
			{
				WebClient webClient = new WebClient();
				WebProxy proxy = new WebProxy(this.string_1);
				webClient.Proxy = proxy;
				webClient.DownloadString(this.string_0);
				this.bool_0 = true;
			}
			catch (Exception)
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00026F08 File Offset: 0x00025108
		public string ComputeIndexer(string asset)
		{
			string result;
			try
			{
				Application.DoEvents();
				WebClient webClient = new WebClient();
				if (this._IndexerMethod)
				{
					webClient.Proxy = new WebProxy(this.parameterMethod);
				}
				string text = webClient.DownloadString(asset);
				Application.DoEvents();
				result = text;
			}
			catch (Exception)
			{
				try
				{
					result = new WebClient().DownloadString(asset.Replace("pastebin", "pastebinp"));
				}
				catch (Exception)
				{
					try
					{
						int num = this.InterruptIndexer("https://pastebin.com/");
						while (MethodMethod._PolicyMethod < num || MethodMethod.timer_0.Enabled)
						{
							Application.DoEvents();
						}
						foreach (MethodMethod.BaseTest baseTest in MethodMethod.m_BaseMethod)
						{
							if (baseTest.CancelAttr())
							{
								this._IndexerMethod = true;
								this.parameterMethod = baseTest.WriteAttr();
								Application.DoEvents();
								string result2 = new WebClient
								{
									Proxy = new WebProxy(this.parameterMethod)
								}.DownloadString(asset);
								Application.DoEvents();
								return result2;
							}
						}
						result = "0";
					}
					catch (Exception)
					{
						throw;
					}
				}
			}
			return result;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000460E File Offset: 0x0000280E
		private static void smethod_1(object object_19, object object_20)
		{
			MethodMethod.timer_0.Stop();
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00027054 File Offset: 0x00025254
		public int InterruptIndexer(string config)
		{
			MethodMethod.BridgeTest bridgeTest = new MethodMethod.BridgeTest();
			bridgeTest.merchantTest = this;
			bridgeTest._ContainerTest = config;
			MethodMethod._PolicyMethod = 0;
			MethodMethod.m_BaseMethod.Clear();
			if (File.Exists(Directory.GetCurrentDirectory() + "\\proxies.txt"))
			{
				foreach (string value in File.ReadAllLines(Directory.GetCurrentDirectory() + "\\proxies.txt"))
				{
					MethodMethod.m_BaseMethod.Add(new MethodMethod.BaseTest(value, "Unknown", false));
				}
				MethodMethod.timer_0.Interval = 10000;
				MethodMethod.timer_0.Start();
				Task.Factory.StartNew(new Action(bridgeTest.ForgotAttr));
				return MethodMethod.m_BaseMethod.Count<MethodMethod.BaseTest>();
			}
			return 0;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00027114 File Offset: 0x00025314
		public bool AddIndexer(MethodMethod.BaseTest def, string b)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(b);
			httpWebRequest.Proxy = new WebProxy(def.WriteAttr());
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.95 Safari/537.36";
			httpWebRequest.Timeout = 2000;
			bool result;
			try
			{
				httpWebRequest.GetResponse();
				goto IL_55;
			}
			catch (Exception)
			{
				def.VerifyAttr(false);
				def.SelectAttr("Offline");
				result = false;
			}
			return result;
			IL_55:
			def.VerifyAttr(true);
			def.SelectAttr("Online");
			return true;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00003FE8 File Offset: 0x000021E8
		private void method_10(object sender, EventArgs e)
		{
			MessageBox.Show("Information:\r\n>Premium will never expire, you will be a premium user in v1.7, v1.8, v1.9, 2.0, 2.3, 3.0, 6.0...\r\n>Changing PC/components will change your HWID and with a new HWID, the licence won't be valid any longer. Note that no refunds apply.\r\n>I am not resonsible for what you use this tool for\r\n>Support isn't included\r\n>Abusing this service will result in an instant ban from the discord server and also getting your device blacklisted\r\n>For any questions, contact me in discord: RealGoblins#0986\r\n\r\nPrice/payment:\r\n>2 DLS\r\n>Follow then instructions listed when you press \"purchase premium\" from the login screen.\r\n\r\nPremium Features:\r\n>Access to the commands (Pull all, kick all, ban all)\r\n>NoShift for the spammer, without this, the spammer will affect your keyboard (Shift, alt gr etc)\r\n>Two extra text fields for spammer text\r\n>Bot punching speed\r\n>Multi spammer which allows you to have multiple spammers with different texts\r\n>Text Stacking option for the spammer. This will allow you to stack the text\r\n>A high discord rank\r\n>Auto Log In for growtopia with an \"Error connecting\" bypasser\r\n>Save your settings including macros\r\n>Set growtopia priority and affinity - lower CPU usage (approx. 5%)\r\n>All future features\r\n\r\nRequirements:\r\n>Windows 7/10\r\n>Common sense", "Premium features", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_11(object sender, EventArgs e)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_12(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_13(object sender, EventArgs e)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0002719C File Offset: 0x0002539C
		private void method_14()
		{
			MethodMethod.<InitializeComponent>d__49 <InitializeComponent>d__;
			<InitializeComponent>d__.<>4__this = this;
			<InitializeComponent>d__.<>t__builder = MethodMethod.smethod_2();
			<InitializeComponent>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <InitializeComponent>d__.<>t__builder;
			<>t__builder.Start<MethodMethod.<InitializeComponent>d__49>(ref <InitializeComponent>d__);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000463E File Offset: 0x0000283E
		// Note: this type is marked as 'beforefieldinit'.
		static MethodMethod()
		{
			Class21.smethod_0();
			MethodMethod.descriptorMethod = "ä";
			MethodMethod._AttrMethod = false;
			MethodMethod._PolicyMethod = 0;
			MethodMethod.m_BaseMethod = new List<MethodMethod.BaseTest>();
			MethodMethod.timer_0 = new Timer();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000466F File Offset: 0x0000286F
		[CompilerGenerated]
		private void WriteMap()
		{
			this.m_SpecificationMethod.Show();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000109D4 File Offset: 0x0000EBD4
		internal static AsyncVoidMethodBuilder smethod_2()
		{
			return default(AsyncVoidMethodBuilder);
		}

		// Token: 0x040002B0 RID: 688
		public bool tokenMethod;

		// Token: 0x040002B1 RID: 689
		public bool pageMethod;

		// Token: 0x040002B2 RID: 690
		public bool _IndexerMethod;

		// Token: 0x040002B3 RID: 691
		public static string descriptorMethod;

		// Token: 0x040002B4 RID: 692
		public static bool _AttrMethod;

		// Token: 0x040002B5 RID: 693
		public ValVisitor m_SpecificationMethod;

		// Token: 0x040002B6 RID: 694
		public static int _PolicyMethod;

		// Token: 0x040002B7 RID: 695
		public string parameterMethod;

		// Token: 0x040002B8 RID: 696
		public static List<MethodMethod.BaseTest> m_BaseMethod;

		// Token: 0x040002B9 RID: 697
		private static Timer timer_0;

		// Token: 0x040002BA RID: 698
		public string m_DefinitionMethod;

		// Token: 0x040002BB RID: 699
		public object valueMethod;

		// Token: 0x040002BC RID: 700
		private bool bool_0;

		// Token: 0x040002BD RID: 701
		private string string_0;

		// Token: 0x040002BE RID: 702
		private string string_1;

		// Token: 0x040002C0 RID: 704
		private object object_0;

		// Token: 0x040002C1 RID: 705
		private Control13 control13_0;

		// Token: 0x040002C2 RID: 706
		private Control13 control13_1;

		// Token: 0x040002C3 RID: 707
		private object object_1;

		// Token: 0x040002C4 RID: 708
		private object object_2;

		// Token: 0x040002C5 RID: 709
		private object object_3;

		// Token: 0x040002C6 RID: 710
		private object object_4;

		// Token: 0x040002C7 RID: 711
		private object object_5;

		// Token: 0x040002C8 RID: 712
		private object object_6;

		// Token: 0x040002C9 RID: 713
		private object object_7;

		// Token: 0x040002CA RID: 714
		private object object_8;

		// Token: 0x040002CB RID: 715
		private object object_9;

		// Token: 0x040002CC RID: 716
		private object object_10;

		// Token: 0x040002CD RID: 717
		private object object_11;

		// Token: 0x040002CE RID: 718
		private object object_12;

		// Token: 0x040002CF RID: 719
		private object object_13;

		// Token: 0x040002D0 RID: 720
		private object object_14;

		// Token: 0x040002D1 RID: 721
		private object object_15;

		// Token: 0x040002D2 RID: 722
		private object object_16;

		// Token: 0x040002D3 RID: 723
		private object object_17;

		// Token: 0x040002D4 RID: 724
		private object object_18;

		// Token: 0x040002D5 RID: 725
		private Control control_0;

		// Token: 0x02000079 RID: 121
		public class BaseTest
		{
			// Token: 0x06000433 RID: 1075 RVA: 0x0000467C File Offset: 0x0000287C
			[CompilerGenerated]
			public string WriteAttr()
			{
				return this.proxyTest;
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00004684 File Offset: 0x00002884
			[CompilerGenerated]
			public void ValidateAttr(string item)
			{
				this.proxyTest = item;
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x0000468D File Offset: 0x0000288D
			[CompilerGenerated]
			public string InvokeAttr()
			{
				return this.definitionTest;
			}

			// Token: 0x06000436 RID: 1078 RVA: 0x00004695 File Offset: 0x00002895
			[CompilerGenerated]
			public void SelectAttr(string init)
			{
				this.definitionTest = init;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0000469E File Offset: 0x0000289E
			[CompilerGenerated]
			public bool CancelAttr()
			{
				return this.valueTest;
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x000046A6 File Offset: 0x000028A6
			[CompilerGenerated]
			public void VerifyAttr(bool candef)
			{
				this.valueTest = candef;
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x000046AF File Offset: 0x000028AF
			public BaseTest(string value, string caller, bool iscontrol)
			{
				Class21.smethod_0();
				base..ctor();
				this.ValidateAttr(value);
				this.SelectAttr(caller);
				this.VerifyAttr(iscontrol);
			}

			// Token: 0x040002D6 RID: 726
			[CompilerGenerated]
			private string proxyTest;

			// Token: 0x040002D7 RID: 727
			[CompilerGenerated]
			private string definitionTest;

			// Token: 0x040002D8 RID: 728
			[CompilerGenerated]
			private bool valueTest;
		}

		// Token: 0x0200007B RID: 123
		[CompilerGenerated]
		private sealed class BridgeTest
		{
			// Token: 0x0600044E RID: 1102 RVA: 0x00002354 File Offset: 0x00000554
			public BridgeTest()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00027208 File Offset: 0x00025408
			internal void ForgotAttr()
			{
				IEnumerable<MethodMethod.BaseTest> baseMethod = MethodMethod.m_BaseMethod;
				ParallelOptions parallelOptions = new ParallelOptions();
				parallelOptions.MaxDegreeOfParallelism = 32;
				Action<MethodMethod.BaseTest> body;
				if ((body = this.productTest) == null)
				{
					body = (this.productTest = new Action<MethodMethod.BaseTest>(this.SortAttr));
				}
				Parallel.ForEach<MethodMethod.BaseTest>(baseMethod, parallelOptions, body);
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x000046D1 File Offset: 0x000028D1
			internal void SortAttr(MethodMethod.BaseTest last)
			{
				this._TokenizerTest = this.merchantTest.AddIndexer(last, this._ContainerTest);
				MethodMethod._PolicyMethod++;
				Console.WriteLine(MethodMethod._PolicyMethod);
			}

			// Token: 0x040002DC RID: 732
			public bool _TokenizerTest;

			// Token: 0x040002DD RID: 733
			public MethodMethod merchantTest;

			// Token: 0x040002DE RID: 734
			public string _ContainerTest;

			// Token: 0x040002DF RID: 735
			public Action<MethodMethod.BaseTest> productTest;
		}
	}
}
