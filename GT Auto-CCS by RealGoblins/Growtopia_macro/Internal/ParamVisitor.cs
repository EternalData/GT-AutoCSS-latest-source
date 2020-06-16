using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DotRas;
using Growtopia_macro.Properties;
using IWshRuntimeLibrary;
using Memory;
using Microsoft.CSharp.RuntimeBinder;
using ns0;
using Tesseract;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000057 RID: 87
	public partial class ParamVisitor : Form
	{
		// Token: 0x060002B4 RID: 692
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_6, int int_7);

		// Token: 0x060002B5 RID: 693
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(ParamVisitor.ConstKind res, bool explicitcounter, int ID_temp);

		// Token: 0x060002B6 RID: 694
		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtectEx(int v_offset, IntPtr result, int idxconsumer, uint task2_min, out uint vis3);

		// Token: 0x060002B7 RID: 695
		[DllImport("kernel32.dll")]
		private static extern uint GetLastError();

		// Token: 0x060002B8 RID: 696
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		public static extern bool ReadProcessMemory_1(int keyPosition, IntPtr vis, byte[] control, int sum_attr2, ref int last3);

		// Token: 0x060002B9 RID: 697
		[DllImport("user32.dll", SetLastError = true)]
		private static extern void keybd_event(byte byte_0, byte byte_1, int int_6, int int_7);

		// Token: 0x060002BA RID: 698
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

		// Token: 0x060002BB RID: 699
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern short VkKeyScan(char char_0);

		// Token: 0x060002BC RID: 700
		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr intptr_0, int int_6);

		// Token: 0x060002BD RID: 701
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr intptr_0, out Rectangle rectangle_5);

		// Token: 0x060002BE RID: 702
		[DllImport("user32.dll")]
		private static extern int SendMessageA(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x060002BF RID: 703
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

		// Token: 0x060002C0 RID: 704
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		private static extern int SendMessage_1(IntPtr intptr_0, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_1);

		// Token: 0x060002C1 RID: 705
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PostMessage(IntPtr ident, uint size_ord, IntPtr consumer, IntPtr pol2);

		// Token: 0x060002C2 RID: 706
		[DllImport("user32.dll")]
		public static extern bool PostMessageA(IntPtr first, uint start_caller, int idxrole, int indexOf_attr2);

		// Token: 0x060002C3 RID: 707
		[DllImport("user32.dll")]
		private static extern int SetWindowText(IntPtr intptr_0, string string_5);

		// Token: 0x060002C4 RID: 708
		[DllImport("user32.dll")]
		public static extern bool SetForegroundWindow(IntPtr ident);

		// Token: 0x060002C5 RID: 709
		[DllImport("user32.dll")]
		private static extern bool AllowSetForegroundWindow(IntPtr intptr_0);

		// Token: 0x060002C6 RID: 710
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr task);

		// Token: 0x060002C7 RID: 711
		[DllImport("user32.dll")]
		public static extern void ReleaseDC(IntPtr param, IntPtr attr);

		// Token: 0x060002C8 RID: 712
		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();

		// Token: 0x060002C9 RID: 713
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x060002CA RID: 714
		[DllImport("ntdll.dll")]
		private static extern uint NtQuerySystemInformation(uint uint_0, IntPtr intptr_0, int int_6, ref int int_7);

		// Token: 0x060002CB RID: 715
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		public static extern IntPtr OpenProcess_1(uint indexOf_setup, [MarshalAs(UnmanagedType.Bool)] bool isb, int next_util);

		// Token: 0x060002CC RID: 716
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x060002CD RID: 717
		[DllImport("kernel32.dll")]
		public static extern int CloseHandle(IntPtr init);

		// Token: 0x060002CE RID: 718
		[DllImport("ntdll.dll")]
		public static extern int NtQueryObject(IntPtr param, int attr_counter, IntPtr field, int offset_config2, ref int token3);

		// Token: 0x060002CF RID: 719
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool DuplicateHandle(IntPtr intptr_0, ushort ushort_0, IntPtr intptr_1, out IntPtr intptr_2, uint uint_0, [MarshalAs(UnmanagedType.Bool)] bool bool_8, uint uint_1);

		// Token: 0x060002D0 RID: 720
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(int int_6, bool bool_8, uint uint_0);

		// Token: 0x060002D1 RID: 721
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr intptr_0);

		// Token: 0x060002D2 RID: 722
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_0);

		// Token: 0x060002D3 RID: 723
		[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
		private static extern bool GetWindowRect_1(IntPtr intptr_0, ref ParamVisitor.Struct1 struct1_0);

		// Token: 0x060002D4 RID: 724
		[DllImport("user32.dll")]
		private static extern int GetWindowThreadProcessId(IntPtr intptr_0, out uint uint_0);

		// Token: 0x060002D5 RID: 725
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool FlashWindowEx(ref ParamVisitor.Struct2 struct2_0);

		// Token: 0x060002D6 RID: 726
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern IntPtr FindWindow(string config, string pol);

		// Token: 0x060002D7 RID: 727 RVA: 0x000116EC File Offset: 0x0000F8EC
		private static ParamVisitor.Struct2 smethod_0(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
		{
			ParamVisitor.Struct2 @struct = default(ParamVisitor.Struct2);
			@struct.uint_0 = Convert.ToUInt32(Marshal.SizeOf<ParamVisitor.Struct2>(@struct));
			@struct.intptr_0 = intptr_0;
			@struct.uint_1 = uint_0;
			@struct.uint_2 = uint_1;
			@struct.uint_3 = uint_2;
			return @struct;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00003AAA File Offset: 0x00001CAA
		private string method_0()
		{
			return this.string_0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003AB2 File Offset: 0x00001CB2
		private void method_1(string string_5)
		{
			if (File.Exists(string_5))
			{
				this.string_0 = string_5;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00011734 File Offset: 0x0000F934
		public ParamVisitor(bool removekey, string reg, string field)
		{
			Class21.smethod_0();
			this.list_0 = new List<Process>();
			this.string_0 = "";
			this.string_1 = "";
			this._RuleVisitor = 100;
			this._PoolVisitor = new List<DispatcherVisitor>();
			this.modelVisitor = new SortedList<string, ProccesorItem>();
			this._MappingVisitor = new SortedList<string, InvocationItem>();
			this.mockVisitor = new SortedList<string, InfoItem>();
			this.bool_7 = true;
			base..ctor();
			this.InitializeComponent();
			ParamVisitor.string_2 = reg;
			ParamVisitor.bool_2 = removekey;
			ParamVisitor.roleVisitor = field;
			if (removekey)
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
						field
					});
					string s = string.Concat(new string[]
					{
						"ausdh0asy",
						"8dUASY",
						this.label44.Text,
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
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
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
					text.Replace("\n", "");
					if (text.Replace(" ", "").Split(new char[]
					{
						'|'
					})[0].Contains("1"))
					{
						this.label19.Text = ParamVisitor.SetToken("7XOMzliAticAYpnb4sB2Vgn+HU/Tlxb7");
						this.label19.ForeColor = Color.GreenYellow;
					}
					else
					{
						this.label19.Text = "Account type: Free";
					}
					goto IL_28D;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
					string str = "Can access the internet. Your account type will be set Free. Try to re-log in when you have a stable internet connection and/or VPN.\n\rException: ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
					this.label19.Text = "Account type: Free";
					goto IL_28D;
				}
			}
			this.label19.Text = "Account type: Free";
			IL_28D:
			this.label20.Text = "User: " + field;
			this.UpdateTest(1000);
			if (ParamVisitor.string_2 != reg)
			{
				base.Close();
			}
			if (ParamVisitor.bool_2 != removekey)
			{
				base.Close();
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00003AC3 File Offset: 0x00001CC3
		private void Macros_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkBox2.Checked = false;
			this.method_2();
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00011A74 File Offset: 0x0000FC74
		private void method_2()
		{
			ParamVisitor.AnnotationToken annotationToken = new ParamVisitor.AnnotationToken();
			annotationToken._DicToken = this;
			if (this.Macros.SelectedItem != null)
			{
				this.maskedTextBox1.Text = this._MappingVisitor[this.Macros.SelectedItem.ToString()].MoveIndexer();
				this.numericUpDown1.Value = this._MappingVisitor[this.Macros.SelectedItem.ToString()].ReflectIndexer();
				this.numericUpDown2.Value = this._MappingVisitor[this.Macros.SelectedItem.ToString()].DestroyIndexer();
				this.numericUpDown4.Value = this._MappingVisitor[this.Macros.SelectedItem.ToString()].TestIndexer();
				this.numericUpDown3.Value = this._MappingVisitor[this.Macros.SelectedItem.ToString()].LogoutIndexer();
				for (int i = 0; i < this.Windows.Items.Count; i++)
				{
					this.Windows.SetItemChecked(i, false);
					if (this.modelVisitor.ContainsKey(this.Windows.Items[i].ToString()) && this.modelVisitor[this.Windows.Items[i].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString())
					{
						this.Windows.SetItemChecked(i, true);
					}
				}
				if (this.Macros.GetItemCheckState(this.Macros.SelectedIndex) == CheckState.Checked)
				{
					annotationToken.m_FilterToken = 0;
					while (annotationToken.m_FilterToken < this.Windows.Items.Count)
					{
						if (this.modelVisitor[this.Windows.Items[annotationToken.m_FilterToken].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString() && !this.modelVisitor[this.Windows.Items[annotationToken.m_FilterToken].ToString()].SelectIndexer())
						{
							this.modelVisitor[this.Windows.Items[annotationToken.m_FilterToken].ToString()].PopIndexer(true);
							this.modelVisitor[this.Windows.Items[annotationToken.m_FilterToken].ToString()].PrintIndexer(false);
							ThreadStart start;
							if ((start = annotationToken._ServiceToken) == null)
							{
								start = (annotationToken._ServiceToken = new ThreadStart(annotationToken.CalculateDescriptor));
							}
							new Thread(start).Start();
							Thread.Sleep(250);
						}
						int filterToken = annotationToken.m_FilterToken;
						annotationToken.m_FilterToken = filterToken + 1;
					}
					return;
				}
				for (int j = 0; j < this.Windows.Items.Count; j++)
				{
					if (this.modelVisitor[this.Windows.Items[j].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString() && this.modelVisitor[this.Windows.Items[j].ToString()].SelectIndexer())
					{
						this.modelVisitor[this.Windows.Items[j].ToString()].PopIndexer(false);
						this.modelVisitor[this.Windows.Items[j].ToString()].PrintIndexer(false);
					}
				}
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000023D9 File Offset: 0x000005D9
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00011E4C File Offset: 0x0001004C
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.Windows.Items.Count; i++)
			{
				if (this.checkBox2.Checked)
				{
					this.Windows.SetItemChecked(i, true);
				}
				else
				{
					this.Windows.SetItemChecked(i, false);
				}
			}
			this.method_5();
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00003AD7 File Offset: 0x00001CD7
		private void button1_Click(object sender, EventArgs e)
		{
			this.int_5 = 1;
			this.dic_2.MoveWorker();
			MessageBox.Show("Put the window in foreground, hover the cursor over the position you'd like to select and press Space");
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00011EA4 File Offset: 0x000100A4
		private void button2_Click(object sender, EventArgs e)
		{
			if (!this._MappingVisitor.ContainsKey(this.maskedTextBox1.Text))
			{
				this._MappingVisitor.Add(this.maskedTextBox1.Text, new InvocationItem(this.maskedTextBox1.Text, (int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value, (int)this.numericUpDown4.Value, (int)this.numericUpDown3.Value));
				this.method_8();
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00011F38 File Offset: 0x00010138
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.Macros.Items.Count; i++)
			{
				if (this.checkBox1.Checked)
				{
					this.Macros.ClearSelected();
					this.Macros.SetSelected(i, true);
					this.Macros.SetItemChecked(i, true);
					this.method_2();
				}
				else
				{
					this.Macros.ClearSelected();
					this.Macros.SetSelected(i, true);
					this.Macros.SetItemChecked(i, false);
					this.method_2();
				}
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003AF6 File Offset: 0x00001CF6
		private void button6_Click(object sender, EventArgs e)
		{
			this.int_5 = 2;
			this.dic_2.MoveWorker();
			MessageBox.Show("Put the window in foreground, hover the cursor over the position you'd like to select and press Space");
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00011FC8 File Offset: 0x000101C8
		private void ParamVisitor_Load(object sender, EventArgs e)
		{
			this.checkBox9.Checked = false;
			this.method_31();
			this.method_30();
			this.method_1(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Local\\Growtopia\\Growtopia.exe");
			this.button12.Visible = false;
			this.dic_0 = new Dic();
			this.dic_0.TestWorker(new MouseEventHandler(this.RunToken));
			this.dic_0.LogoutWorker(new MouseEventHandler(this.StartToken));
			this.dic_0.DeleteWorker(new MouseEventHandler(this.ManageToken));
			this.dic_2 = new Dic();
			this.dic_2.AwakeWorker(new KeyEventHandler(this.ResetToken));
			this.dic_3 = new Dic();
			this.dic_3.AwakeWorker(new KeyEventHandler(this.CompareToken));
			this.dic_1 = new Dic();
			this.dic_1.ListWorker(new MouseEventHandler(this.ChangeToken));
			this.dic_1.FlushWorker(new MouseEventHandler(this.AssetToken));
			this.dic_1.DeleteWorker(new MouseEventHandler(this.IncludeToken));
			this.dic_1.AssetWorker(new MouseEventHandler(this.NewToken));
			this.dic_1.AwakeWorker(new KeyEventHandler(this.CalculateToken));
			this.dic_1.CloneWorker(new KeyEventHandler(this.CloneToken));
			ParamVisitor.timer_0.Tick += new EventHandler(ParamVisitor.smethod_2);
			this.dic_0.QueryWorker();
			this.dic_1.QueryWorker();
			this.dic_2.QueryWorker();
			this.dic_3.QueryWorker();
			ParamVisitor.timer_0.Stop();
			AppDomain.CurrentDomain.UnhandledException += ParamVisitor.smethod_1;
			this.int_4 = 0;
			this.bool_3 = false;
			this.bool_4 = false;
			this.bool_5 = false;
			this.form_0 = new Form();
			this.form_0.BackColor = Color.LightBlue;
			this.form_0.TransparencyKey = Color.Black;
			this.form_0.Opacity = 0.5;
			this.form_0.FormBorderStyle = FormBorderStyle.None;
			this.form_0.Bounds = new Rectangle(0, 0, 0, 0);
			this.form_0.TopMost = true;
			this.form_0.Hide();
			this.m_ProducerVisitor = this.method_18();
			ParamVisitor.AllowSetForegroundWindow(ParamVisitor.GetCurrentProcess());
			this.method_12();
			this.checkedListBox4.Items.Clear();
			for (int i = 1; i < Environment.ProcessorCount + 1; i++)
			{
				this.checkedListBox4.Items.Add("Thread: " + i.ToString(), true);
			}
			this.comboBox4.SelectedIndex = 1;
			this.comboBox3.SelectedIndex = 3;
			this.listView1.View = View.Details;
			this.textBox1.Visible = false;
			this.comboBox1.SelectedItem = "/pull";
			this.GT_version_cmd.SelectedIndex = this.GT_version_cmd.Items.Count - 1;
			for (int j = 0; j < this.listView1.Columns.Count; j++)
			{
				this.listView1.Columns[j].Width = -2;
			}
			Broadcaster.CloneList(this);
			this._BroadcasterVisitor = new Thread(new ThreadStart(this.PrepareToken))
			{
				IsBackground = true
			};
			this.serverVisitor = new Thread(new ThreadStart(this.CallToken))
			{
				IsBackground = true
			};
			this._BroadcasterVisitor.Start();
			this.propertyVisitor = new Thread(new ThreadStart(this.ConcatToken))
			{
				IsBackground = true
			};
			this.propertyVisitor.Start();
			this.button28.Hide();
			this.button27.Show();
			this.button29.Enabled = true;
			this.button28.Enabled = false;
			this.button27.Enabled = false;
			this.button26.Enabled = false;
			this.SpammerText2.Enabled = false;
			this.SpammerText3.Enabled = false;
			this.SpammerText4.Enabled = false;
			if (Settings.Default.RunFirst.ToString() == "true")
			{
				this.method_32();
				Settings.Default.RunFirst = "false";
				Settings.Default.Save();
			}
			if (ParamVisitor.bool_2)
			{
				try
				{
					string text = string.Empty;
					string instance = string.Concat(new string[]
					{
						DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
						"|",
						"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
						"|",
						ParamVisitor.roleVisitor
					});
					string s = string.Concat(new string[]
					{
						"ausdh0asy",
						"8dUASY",
						this.label44.Text,
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
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
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
					text.Replace("\n", "");
					if (text.Replace(" ", "").Split(new char[]
					{
						'|'
					})[0].Contains("1"))
					{
						this.label19.Text = ParamVisitor.SetToken("7XOMzliAticAYpnb4sB2Vgn+HU/Tlxb7");
						this.panel3.Enabled = true;
						this.iTalk_HeaderLabel1.Visible = false;
					}
					else
					{
						this.label19.Text = "Account type: Free";
						this.Execute.Enabled = false;
						this.SpamTxt3.Enabled = false;
						this.SpamTxt3.Checked = false;
						this.SpamTxt4.Enabled = false;
						this.SpamTxt4.Checked = false;
						this.checkBox6.Checked = false;
						this.checkBox7.Checked = false;
						this.panel3.Enabled = false;
					}
					goto IL_7B0;
				}
				catch (Exception ex)
				{
					this.label19.Text = "Account type: Free";
					this.Execute.Enabled = false;
					this.SpamTxt3.Enabled = false;
					this.SpamTxt3.Checked = false;
					this.SpamTxt4.Enabled = false;
					this.SpamTxt4.Checked = false;
					this.checkBox6.Checked = false;
					this.checkBox7.Checked = false;
					MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
					string str = "Can access the internet. Your account type will be set Free. Try to re-log in when you have a stable internet connection and/or VPN.\n\rException: ";
					Exception ex2 = ex;
					MessageBox.Show(str + ((ex2 != null) ? ex2.ToString() : null));
					this.label19.Text = "Account type: Free";
					goto IL_7B0;
				}
			}
			this.label19.Text = "Account type: Free";
			this.SpamTxt3.Enabled = false;
			this.SpamTxt3.Checked = false;
			this.SpamTxt4.Enabled = false;
			this.SpamTxt4.Checked = false;
			this.checkBox6.Checked = false;
			this.checkBox7.Checked = false;
			this.Execute.Enabled = false;
			IL_7B0:
			try
			{
				byte[] bytes2 = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L0oxNEV1c1ZB");
				string @string = Encoding.UTF8.GetString(bytes2);
				string[] array = this.ListToken(@string).Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.None);
				this.GT_version_cmd.Items.Add(array[0]);
				this.GT_version_cmd.SelectedIndex = this.GT_version_cmd.Items.Count - 1;
			}
			catch (Exception)
			{
			}
			this.checkedListBox3.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int k = 0; k < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); k++)
				{
					this.checkedListBox3.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[k]));
				}
			}
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox10.Checked = false;
			}
			else
			{
				if (Settings.Default.SL)
				{
					this.checkBox10.Checked = true;
				}
				if (this.checkBox10.Checked)
				{
					this.ForgotToken();
				}
			}
			Settings.Default.Save();
			string text2 = string.Empty;
			try
			{
				string instance2 = string.Concat(new string[]
				{
					DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
					"|",
					"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
					"|",
					ParamVisitor.roleVisitor
				});
				string s2 = string.Concat(new string[]
				{
					"ausdh0asy",
					"8dUASY",
					this.label43.Text,
					")/",
					"ASydASDIAS"
				});
				byte[] counter2 = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(s2));
				byte[] consumer2 = new byte[]
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
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
				byte[] bytes3 = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0zJmtleT0=");
				HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(Encoding.UTF8.GetString(bytes3) + Worker.InsertList(instance2, counter2, consumer2));
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
				string[] array2 = text2.Replace("\n", "").Replace(" ", "").Split(new char[]
				{
					'|'
				});
				Console.WriteLine("Total users: " + array2[0]);
				Console.WriteLine("Active users: " + array2[1]);
				this.label31.Text = "Total users: " + array2[0];
				this.label28.Text = "Active users: " + array2[1];
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
			}
			ParamVisitor.string_4 = ParamVisitor.roleVisitor;
			Timer timer = new Timer();
			timer.Elapsed += this.method_3;
			timer.Interval = 300000.0;
			timer.Enabled = true;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00012BC0 File Offset: 0x00010DC0
		private void method_3(object sender, ElapsedEventArgs e)
		{
			string instance = string.Concat(new string[]
			{
				DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
				"|",
				"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
				"|",
				ParamVisitor.string_4
			});
			string s = string.Concat(new string[]
			{
				"ausdh0asy",
				"8dUASY",
				this.label43.Text,
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
			string text = string.Empty;
			ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
			byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0zJmtleT0=");
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
			string[] array = text.Replace("\n", "").Replace(" ", "").Split(new char[]
			{
				'|'
			});
			Console.WriteLine("Total users: " + array[0]);
			Console.WriteLine("Active users: " + array[1]);
			this.label31.Text = "Total users: " + array[0];
			this.label28.Text = "Active users: " + array[1];
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00012DC0 File Offset: 0x00010FC0
		public void ForgotToken()
		{
			this.no_GT_windows.Value = Settings.Default.no_GT_windows;
			this.iTalk_NumericUpDown1.Value = Settings.Default.iTalk_NumericUpDown1;
			this.checkBox8.Checked = Settings.Default.checkBox8;
			this.checkBox9.Checked = Settings.Default.checkBox9;
			if (Settings.Default.maskedTextBox2 != "")
			{
				this.maskedTextBox2.Text = Settings.Default.maskedTextBox2;
			}
			this.comboBox1.SelectedIndex = Settings.Default.comboBox1;
			this.textBox1.Text = Settings.Default.textBox1;
			this.numericUpDown5.Value = Settings.Default.numericUpDown5;
			this.SpammerText1.Text = Settings.Default.SpammerText1;
			this.SpammerText2.Text = Settings.Default.SpammerText2;
			this.SpammerText3.Text = Settings.Default.SpammerText3;
			this.SpammerText4.Text = Settings.Default.SpammerText4;
			this.SpamTxt1.Checked = Settings.Default.SpamTxt1;
			this.SpamTxt2.Checked = Settings.Default.SpamTxt2;
			this.SpamTxt3.Checked = Settings.Default.SpamTxt3;
			this.SpamTxt4.Checked = Settings.Default.SpamTxt4;
			this.AddInFrontCheckBox.Checked = Settings.Default.AddInFrontCheckBox;
			this.MsgSpamCheckBox.Checked = Settings.Default.MsgSpamCheckBox;
			this.checkBox6.Checked = Settings.Default.checkBox6;
			this.checkBox7.Checked = Settings.Default.checkBox7;
			this.MsgSpamTo.Text = Settings.Default.MsgSpamTo;
			this.addInFront.Text = Settings.Default.addInFront;
			this.SpamDelay.Value = Settings.Default.SpamDelay / 1000m;
			this.trackBar2.Value = Settings.Default.trackBar2;
			this._MappingVisitor.Clear();
			for (int i = 0; i < Settings.Default.SavedMacros.Count; i += 5)
			{
				string text = Settings.Default.SavedMacros[i];
				int visY = int.Parse(Settings.Default.SavedMacros[i + 1]);
				int util_high = int.Parse(Settings.Default.SavedMacros[i + 2]);
				int connection2size = int.Parse(Settings.Default.SavedMacros[i + 3]);
				int indexcounter = int.Parse(Settings.Default.SavedMacros[i + 4]);
				this._MappingVisitor.Add(text, new InvocationItem(text, visY, util_high, connection2size, indexcounter));
			}
			this.method_8();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000130AC File Offset: 0x000112AC
		public void SortToken()
		{
			Settings.Default.no_GT_windows = (int)this.no_GT_windows.Value;
			Settings.Default.Save();
			Settings.Default.checkBox8 = this.checkBox8.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox9 = this.checkBox8.Checked;
			Settings.Default.Save();
			Settings.Default.iTalk_NumericUpDown1 = this.iTalk_NumericUpDown1.Value;
			Settings.Default.Save();
			Settings.Default.maskedTextBox2 = this.maskedTextBox2.Text;
			Settings.Default.Save();
			Settings.Default.comboBox1 = this.comboBox1.SelectedIndex;
			Settings.Default.Save();
			Settings.Default.textBox1 = this.textBox1.Text;
			Settings.Default.Save();
			Settings.Default.numericUpDown5 = this.numericUpDown5.Value;
			Settings.Default.Save();
			Settings.Default.SpammerText1 = this.SpammerText1.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText2 = this.SpammerText1.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText3 = this.SpammerText1.Text;
			Settings.Default.Save();
			Settings.Default.SpammerText4 = this.SpammerText1.Text;
			Settings.Default.SpamTxt1 = this.SpamTxt1.Checked;
			Settings.Default.SpamTxt2 = this.SpamTxt2.Checked;
			Settings.Default.SpamTxt3 = this.SpamTxt3.Checked;
			Settings.Default.SpamTxt4 = this.SpamTxt4.Checked;
			Settings.Default.Save();
			Settings.Default.AddInFrontCheckBox = this.AddInFrontCheckBox.Checked;
			Settings.Default.Save();
			Settings.Default.MsgSpamCheckBox = this.MsgSpamCheckBox.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox6 = this.checkBox6.Checked;
			Settings.Default.Save();
			Settings.Default.checkBox7 = this.checkBox7.Checked;
			Settings.Default.Save();
			Settings.Default.addInFront = this.addInFront.Text;
			Settings.Default.Save();
			Settings.Default.MsgSpamTo = this.MsgSpamTo.Text;
			Settings.Default.Save();
			Settings.Default.SpamDelay = this.SpamDelay.Value;
			Settings.Default.Save();
			Settings.Default.trackBar2 = this.trackBar2.Value;
			Settings.Default.Save();
			StringCollection stringCollection = new StringCollection();
			foreach (InvocationItem invocationItem in this._MappingVisitor.Values)
			{
				stringCollection.Add(invocationItem.MoveIndexer());
				stringCollection.Add(invocationItem.ReflectIndexer().ToString());
				stringCollection.Add(invocationItem.DestroyIndexer().ToString());
				stringCollection.Add(invocationItem.TestIndexer().ToString());
				stringCollection.Add(invocationItem.LogoutIndexer().ToString());
			}
			Settings.Default.SavedMacros = stringCollection;
			Settings.Default.Save();
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001343C File Offset: 0x0001163C
		private static void smethod_1(object sender, UnhandledExceptionEventArgs e)
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
						"[",
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

		// Token: 0x060002E8 RID: 744 RVA: 0x00013654 File Offset: 0x00011854
		public void ConcatToken()
		{
			Thread.Sleep(1200);
			for (;;)
			{
				try
				{
					if (!this.propertyVisitor.IsAlive)
					{
						Application.Exit();
					}
				}
				catch (Exception)
				{
				}
				Thread.Sleep(120000);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000136A0 File Offset: 0x000118A0
		public void CallToken()
		{
			for (;;)
			{
				try
				{
					if (!this._BroadcasterVisitor.IsAlive)
					{
						Application.Exit();
					}
					if (!this.propertyVisitor.IsAlive)
					{
						Application.Exit();
					}
					goto IL_33D;
				}
				catch (ThreadInterruptedException value)
				{
					Console.WriteLine(value);
					Application.Exit();
					goto IL_33D;
				}
				goto IL_3A;
				IL_32E:
				Thread.Sleep(10000);
				continue;
				IL_3A:
				try
				{
					string text = string.Empty;
					string instance = string.Concat(new string[]
					{
						DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
						"|",
						"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
						"|",
						ParamVisitor.roleVisitor
					});
					string s = string.Concat(new string[]
					{
						"ausdh0asy",
						"8dUASY",
						this.label44.Text,
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
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
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
					text.Replace("\n", "");
					if (text.Replace(" ", "").Split(new char[]
					{
						'|'
					})[0].Contains("1"))
					{
						this.label19.Text = ParamVisitor.SetToken("7XOMzliAticAYpnb4sB2Vgn+HU/Tlxb7");
						this.panel3.Enabled = true;
						this.iTalk_HeaderLabel1.Visible = false;
					}
					else
					{
						this.label19.Text = "Account type: Free";
						this.Execute.Enabled = false;
						this.SpamTxt3.Enabled = false;
						this.SpamTxt3.Checked = false;
						this.SpamTxt4.Enabled = false;
						this.SpamTxt4.Checked = false;
						this.checkBox6.Checked = false;
						this.checkBox7.Checked = false;
						this.panel3.Enabled = false;
					}
					goto IL_32E;
				}
				catch (Exception)
				{
					this.label19.Text = "Account type: Free";
					this.Execute.Enabled = false;
					this.SpamTxt3.Enabled = false;
					this.SpamTxt3.Checked = false;
					this.SpamTxt4.Enabled = false;
					this.SpamTxt4.Checked = false;
					this.checkBox6.Checked = false;
					this.checkBox7.Checked = false;
					goto IL_32E;
				}
				IL_2CA:
				this.label19.Text = "Account type: Free";
				this.Execute.Enabled = false;
				this.SpamTxt3.Enabled = false;
				this.SpamTxt3.Checked = false;
				this.SpamTxt4.Enabled = false;
				this.SpamTxt4.Checked = false;
				this.checkBox6.Checked = false;
				this.checkBox7.Checked = false;
				goto IL_32E;
				IL_33D:
				if (ParamVisitor.bool_2)
				{
					goto IL_3A;
				}
				goto IL_2CA;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00013A74 File Offset: 0x00011C74
		public string ConnectToken(string key)
		{
			string @string;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(key))
				{
					@string = Encoding.Default.GetString(md.ComputeHash(fileStream));
				}
			}
			return @string;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00013AD4 File Offset: 0x00011CD4
		public void PrepareToken()
		{
			this.serverVisitor.Start();
			while (!this.serverVisitor.IsAlive)
			{
				Thread.Sleep(500);
			}
			for (;;)
			{
				try
				{
					if (ParamVisitor.bool_2)
					{
						try
						{
							string text = string.Empty;
							string instance = string.Concat(new string[]
							{
								DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
								"|",
								"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
								"|",
								ParamVisitor.roleVisitor
							});
							string s = string.Concat(new string[]
							{
								"ausdh0asy",
								"8dUASY",
								this.label44.Text,
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
							ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
							byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
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
							text.Replace("\n", "");
							if (text.Replace(" ", "").Split(new char[]
							{
								'|'
							})[0].Contains("1"))
							{
								base.BeginInvoke(new MethodInvoker(this.SearchPage));
							}
							else
							{
								base.BeginInvoke(new MethodInvoker(this.CreatePage));
							}
							goto IL_206;
						}
						catch (Exception)
						{
							base.BeginInvoke(new MethodInvoker(this.CalcPage));
							goto IL_206;
						}
					}
					base.BeginInvoke(new MethodInvoker(this.CheckPage));
					IL_206:
					if (this.Text != "GT Auto-CCS by RealGoblins")
					{
						Console.WriteLine("error1");
						Application.Exit();
					}
					string fileName = Path.GetFileName(Application.ExecutablePath);
					if (fileName != "GT Auto-CCS by RealGoblins.exe")
					{
						File.Move(fileName, "GT Auto-CCS by RealGoblins.exe");
					}
					if (this.pictureBox5.Width != 585 | this.pictureBox5.Height != 31)
					{
						Console.WriteLine("error2");
						Application.Exit();
					}
					if (this.label17.Text != "By RealGoblins" | this.label17.Size.Width != 121 | this.label17.Size.Height != 23 | !this.label17.Visible | this.label17.Font.Size != 12f)
					{
						Console.WriteLine("error3");
						Application.Exit();
					}
					if (!this.serverVisitor.IsAlive)
					{
						Application.Exit();
					}
				}
				catch (ThreadInterruptedException value)
				{
					Console.WriteLine(value);
					Application.Exit();
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00013E9C File Offset: 0x0001209C
		private void ParamVisitor_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.MinimumSize = new Size(5, 5);
			while (base.Size.Height > 40)
			{
				base.Height -= 5;
				Application.DoEvents();
				Thread.Sleep(5);
			}
			Application.Exit();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00013EE8 File Offset: 0x000120E8
		public string EnableToken(string last)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] bytes = Encoding.UTF8.GetBytes(last);
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

		// Token: 0x060002EF RID: 751 RVA: 0x00013FA4 File Offset: 0x000121A4
		public static string SetToken(string def)
		{
			string result = "";
			string text = "joaDSKds";
			string text2 = "joaDSKds";
			byte[] rgbIV = new byte[0];
			rgbIV = Encoding.UTF8.GetBytes(text2.Substring(0, 8));
			byte[] rgbKey = new byte[0];
			rgbKey = Encoding.UTF8.GetBytes(text.Substring(0, 8));
			byte[] array = new byte[def.Replace(" ", "+").Length];
			array = Convert.FromBase64String(def.Replace(" ", "+"));
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

		// Token: 0x060002F0 RID: 752 RVA: 0x00003B15 File Offset: 0x00001D15
		private void button5_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00014094 File Offset: 0x00012294
		private void button4_Click(object sender, EventArgs e)
		{
			if (this.Windows.SelectedItem != null)
			{
				foreach (Process process in Process.GetProcessesByName("Growtopia"))
				{
					IntPtr mainWindowHandle = process.MainWindowHandle;
					if (process.MainWindowTitle == this.Windows.SelectedItem.ToString())
					{
						ParamVisitor.SetForegroundWindow(process.MainWindowHandle);
					}
				}
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000140FC File Offset: 0x000122FC
		private void Windows_SelectedIndexChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.Windows.Items.Count; i++)
			{
				if (this.Windows.GetItemCheckState(i) == CheckState.Unchecked)
				{
					this.checkBox2.Checked = false;
				}
			}
			this.method_5();
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00014144 File Offset: 0x00012344
		private void method_5()
		{
			if (this.Macros.SelectedItem != null)
			{
				for (int i = 0; i < this.Windows.Items.Count; i++)
				{
					if (this.Windows.GetItemCheckState(i) == CheckState.Checked)
					{
						if (this.modelVisitor.ContainsKey(this.Windows.Items[i].ToString()))
						{
							this.modelVisitor[this.Windows.Items[i].ToString()].OrderIndexer(this.Macros.SelectedItem.ToString());
							this.modelVisitor[this.Windows.Items[i].ToString()].PopIndexer(false);
							this.modelVisitor[this.Windows.Items[i].ToString()].PrintIndexer(false);
						}
						else
						{
							this.modelVisitor.Add(this.Windows.Items[i].ToString(), new ProccesorItem(this.Windows.Items[i].ToString(), this.Macros.SelectedItem.ToString(), false, false, false, false));
						}
					}
					else if (this.modelVisitor.ContainsKey(this.Windows.Items[i].ToString()) && this.modelVisitor[this.Windows.Items[i].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString())
					{
						this.modelVisitor[this.Windows.Items[i].ToString()].OrderIndexer("");
						this.modelVisitor[this.Windows.Items[i].ToString()].PopIndexer(false);
						this.modelVisitor[this.Windows.Items[i].ToString()].PrintIndexer(false);
					}
				}
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00014374 File Offset: 0x00012574
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.Macros.SelectedItem != null)
			{
				if (this.Macros.GetItemCheckState(this.Macros.SelectedIndex) != CheckState.Checked)
				{
					if (this._MappingVisitor.ContainsKey(this.Macros.SelectedItem.ToString()))
					{
						for (int i = 0; i < this.Windows.Items.Count; i++)
						{
							if (this.modelVisitor.ContainsKey(this.Windows.Items[i].ToString()) && this.modelVisitor[this.Windows.Items[i].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString())
							{
								this.modelVisitor[this.Windows.Items[i].ToString()].OrderIndexer("");
								this.modelVisitor[this.Windows.Items[i].ToString()].PopIndexer(false);
								this.modelVisitor[this.Windows.Items[i].ToString()].PrintIndexer(false);
							}
						}
						this._MappingVisitor.Remove(this.Macros.SelectedItem.ToString());
						this.method_8();
						return;
					}
				}
				else
				{
					MessageBox.Show("Can't remove an active macro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00014500 File Offset: 0x00012700
		private void method_6()
		{
			this.listView1.Clear();
			for (int i = 0; i < this.string_3.Length; i++)
			{
				string[] array = this.string_3[i].Split(new char[]
				{
					'|'
				});
				if (i == 0)
				{
					for (int j = 0; j < array.Length; j++)
					{
						this.listView1.Columns.Add(array[j]);
					}
				}
				else if (this.string_3[i].ToLower().Contains(this.maskedTextBox2.Text.ToLower()))
				{
					ListViewItem value = new ListViewItem(array);
					this.listView1.Items.Add(value);
					if (i % 1000 == 0)
					{
						Application.DoEvents();
					}
				}
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000145BC File Offset: 0x000127BC
		private void method_7()
		{
			this.Windows.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.Windows.Items.Add(process.MainWindowTitle, false);
				if (!this.modelVisitor.ContainsKey(process.MainWindowTitle))
				{
					this.modelVisitor.Add(process.MainWindowTitle, new ProccesorItem(process.MainWindowTitle, "", false, false, false, false));
				}
			}
			if (this.Macros.SelectedItem != null)
			{
				for (int j = 0; j < this.Windows.Items.Count; j++)
				{
					this.Windows.SetItemChecked(j, false);
					if (this.modelVisitor.ContainsKey(this.Windows.Items[j].ToString()) && this.modelVisitor[this.Windows.Items[j].ToString()].ValidateIndexer() == this.Macros.SelectedItem.ToString())
					{
						this.Windows.SetItemChecked(j, true);
					}
				}
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000146F8 File Offset: 0x000128F8
		private void method_8()
		{
			int num = 0;
			this.Macros.Items.Clear();
			foreach (KeyValuePair<string, InvocationItem> keyValuePair in this._MappingVisitor)
			{
				this.Macros.Items.Add(keyValuePair.Key.ToString());
				num++;
				for (int i = 0; i < this.Windows.Items.Count; i++)
				{
					this.Windows.SetItemChecked(i, false);
					if (this.modelVisitor.ContainsKey(this.Windows.Items[i].ToString()) && this.modelVisitor[this.Windows.Items[i].ToString()].ValidateIndexer() == keyValuePair.Key.ToString() && this.modelVisitor[this.Windows.Items[i].ToString()].SelectIndexer())
					{
						this.Macros.SetItemChecked(num - 1, true);
					}
				}
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00003B1D File Offset: 0x00001D1D
		public int DestroyToken()
		{
			return this.trackBar2.Value;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001483C File Offset: 0x00012A3C
		private void method_9()
		{
			this.checkedListBox1.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.checkedListBox1.Items.Add(process.MainWindowTitle, false);
			}
			this.Select_all.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000148A4 File Offset: 0x00012AA4
		private void method_10()
		{
			this.ProcessesSpam.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.ProcessesSpam.Items.Add(process.MainWindowTitle, false);
			}
			this.SelectAllSpam.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001490C File Offset: 0x00012B0C
		private void method_11()
		{
			this.listBox1.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				IntPtr mainWindowHandle = process.MainWindowHandle;
				this.listBox1.Items.Add(process.MainWindowTitle);
			}
			this.checkBox3.CheckState = CheckState.Unchecked;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003B2A File Offset: 0x00001D2A
		private void method_12()
		{
			this.method_11();
			this.method_9();
			this.method_10();
			this.method_7();
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00014970 File Offset: 0x00012B70
		private void method_13(ProccesorItem proccesorItem_0)
		{
			Process process = null;
			IntPtr intptr_ = IntPtr.Zero;
			Console.WriteLine(proccesorItem_0.ValidateIndexer() + "->" + proccesorItem_0.InsertIndexer() + " running");
			foreach (Process process2 in Process.GetProcessesByName("Growtopia"))
			{
				if (proccesorItem_0.InsertIndexer() == process2.MainWindowTitle)
				{
					intptr_ = process2.MainWindowHandle;
					process = process2;
					IL_67:
					if (process != null)
					{
						double num = (double)this._MappingVisitor[proccesorItem_0.ValidateIndexer()].ReflectIndexer();
						double num2 = (double)this._MappingVisitor[proccesorItem_0.ValidateIndexer()].DestroyIndexer();
						double num3 = (double)this._MappingVisitor[proccesorItem_0.ValidateIndexer()].TestIndexer();
						double num4 = (double)this._MappingVisitor[proccesorItem_0.ValidateIndexer()].LogoutIndexer();
						double num5 = Math.Sqrt((num3 - num) * (num3 - num) + (num4 - num2) * (num4 - num2)) / 30.0;
						double num6 = (double)(this._MappingVisitor[proccesorItem_0.ValidateIndexer()].TestIndexer() - this._MappingVisitor[proccesorItem_0.ValidateIndexer()].ReflectIndexer()) / num5;
						double num7 = (double)(this._MappingVisitor[proccesorItem_0.ValidateIndexer()].LogoutIndexer() - this._MappingVisitor[proccesorItem_0.ValidateIndexer()].DestroyIndexer()) / num5;
						IntPtr zero = IntPtr.Zero;
						while (this.modelVisitor[proccesorItem_0.InsertIndexer()].SelectIndexer())
						{
							if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].VerifyIndexer())
							{
								double num8 = num;
								double num9 = num2;
								int num10 = (int)num8;
								IntPtr intptr_2 = (IntPtr)((int)num9 << 16 | num10);
								zero = IntPtr.Zero;
								ParamVisitor.SendMessage(intptr_, 513U, zero, intptr_2);
								Thread.Sleep(100);
								int num11 = 0;
								while ((double)num11 < num5)
								{
									num8 += num6;
									num9 += num7;
									num10 = (int)num8;
									intptr_2 = (IntPtr)((int)num9 << 16 | num10);
									zero = IntPtr.Zero;
									ParamVisitor.SendMessage(intptr_, 512U, zero, intptr_2);
									Thread.Sleep(this._RuleVisitor);
									num11++;
								}
								ParamVisitor.SendMessage(intptr_, 514U, zero, intptr_2);
							}
							Thread.Sleep(200);
						}
					}
					return;
				}
			}
			goto IL_67;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00014BCC File Offset: 0x00012DCC
		private void method_14(ProccesorItem proccesorItem_0)
		{
			Process process = null;
			IntPtr key = IntPtr.Zero;
			int num = 1;
			string text = this.SpammerText1.Text;
			int num2 = (int)(this.SpamDelay.Value * 10m);
			string str = "";
			string str2 = "";
			if (this.AddInFrontCheckBox.CheckState == CheckState.Checked)
			{
				str = this.addInFront.Text;
			}
			if (this.MsgSpamCheckBox.CheckState == CheckState.Checked)
			{
				str2 = "/msg " + this.MsgSpamTo.Text + " ";
			}
			str2 + str + text;
			Console.WriteLine("Spammer -> " + proccesorItem_0.InsertIndexer() + " running");
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				Process process2 = processesByName[i];
				if (proccesorItem_0.InsertIndexer() == process2.MainWindowTitle)
				{
					key = process2.MainWindowHandle;
					process = process2;
					IL_F3:
					if (process != null)
					{
						while (this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
						{
							if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].CallIndexer())
							{
								switch (num)
								{
								case 1:
									text = this.SpammerText1.Text;
									if (this.SpamTxt2.Checked)
									{
										num = 2;
									}
									else if (this.SpamTxt3.Checked)
									{
										num = 3;
									}
									else if (this.SpamTxt4.Checked)
									{
										num = 4;
									}
									else if (this.SpamTxt1.Checked)
									{
										num = 1;
									}
									break;
								case 2:
									text = this.SpammerText2.Text;
									if (this.SpamTxt3.Checked)
									{
										num = 3;
									}
									else if (this.SpamTxt4.Checked)
									{
										num = 4;
									}
									else if (this.SpamTxt1.Checked)
									{
										num = 1;
									}
									else if (this.SpamTxt2.Checked)
									{
										num = 2;
									}
									break;
								case 3:
									text = this.SpammerText3.Text;
									if (this.SpamTxt4.Checked)
									{
										num = 4;
									}
									else if (this.SpamTxt1.Checked)
									{
										num = 1;
									}
									else if (this.SpamTxt2.Checked)
									{
										num = 2;
									}
									else if (this.SpamTxt3.Checked)
									{
										num = 3;
									}
									break;
								case 4:
									text = this.SpammerText4.Text;
									if (this.SpamTxt1.Checked)
									{
										num = 1;
									}
									else if (this.SpamTxt2.Checked)
									{
										num = 2;
									}
									else if (this.SpamTxt3.Checked)
									{
										num = 3;
									}
									else if (this.SpamTxt4.Checked)
									{
										num = 4;
									}
									break;
								default:
									text = this.SpammerText1.Text;
									num = 1;
									break;
								}
								string text2 = str2 + str + text;
								ParamVisitor.AwakePage(key, 13, false);
								Thread.Sleep(50);
								string text3 = text2;
								i = 0;
								while (i < text3.Length)
								{
									char c = text3[i];
									char c2 = c;
									bool flag = false;
									if (this.checkBox6.Checked)
									{
										try
										{
											short num3 = ParamVisitor.VkKeyScan(c2);
											bool flag2 = (num3 & 256) > 0;
											bool flag3 = (num3 & 512) > 0;
											bool flag4 = (num3 & 1024) > 0;
											if (flag2)
											{
												flag = true;
											}
											if (flag4 && flag3)
											{
												flag = true;
											}
											if (char.IsLetter(c2))
											{
												c2 = c.ToString().ToLower().ToCharArray()[0];
												flag = false;
											}
											goto IL_34B;
										}
										catch (Exception)
										{
											flag = true;
											throw;
										}
										goto IL_347;
									}
									goto IL_347;
									IL_34B:
									if (!flag)
									{
										short num4 = ParamVisitor.VkKeyScan(c2);
										int num5 = (int)(num4 & 255);
										bool flag5 = (num4 & 256) > 0;
										bool flag6 = (num4 & 512) > 0;
										bool flag7 = (num4 & 1024) > 0;
										if (flag5 && !this.checkBox6.Checked)
										{
											ParamVisitor.keybd_event(160, 42, 0, 0);
											Thread.Sleep(50);
										}
										if (flag7 && flag6 && !this.checkBox6.Checked)
										{
											ParamVisitor.keybd_event(164, 56, 0, 0);
											ParamVisitor.keybd_event(162, 29, 0, 0);
											Thread.Sleep(50);
										}
										ParamVisitor.AwakePage(key, (byte)num5, false);
										Thread.Sleep(50);
										if (flag5 && !this.checkBox6.Checked)
										{
											ParamVisitor.keybd_event(160, 170, 2, 0);
											Thread.Sleep(50);
										}
										if (flag7 && flag6 && !this.checkBox6.Checked)
										{
											ParamVisitor.keybd_event(164, 184, 2, 0);
											ParamVisitor.keybd_event(162, 157, 2, 0);
											Thread.Sleep(50);
										}
									}
									i++;
									continue;
									IL_347:
									c2 = c;
									goto IL_34B;
								}
								ParamVisitor.AwakePage(key, 13, false);
							}
							if (this.checkBox7.Checked)
							{
								if (!this.SpamTxt2.Checked & !this.SpamTxt3.Checked & !this.SpamTxt4.Checked)
								{
									for (int j = 0; j < num2; j++)
									{
										Thread.Sleep(100);
										if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
										{
											break;
										}
									}
								}
								else
								{
									switch (num)
									{
									case 1:
										for (int k = 0; k < num2; k++)
										{
											Thread.Sleep(100);
											if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
											{
												break;
											}
										}
										break;
									case 2:
										for (int l = 0; l < 20; l++)
										{
											Thread.Sleep(100);
											if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
											{
												break;
											}
										}
										break;
									case 3:
										if (this.SpamTxt3.Checked)
										{
											for (int m = 0; m < 20; m++)
											{
												Thread.Sleep(100);
												if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
												{
													break;
												}
											}
										}
										else
										{
											for (int n = 0; n < num2; n++)
											{
												Thread.Sleep(100);
												if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
												{
													break;
												}
											}
										}
										break;
									case 4:
										if (this.SpamTxt4.Checked)
										{
											for (int num6 = 0; num6 < 20; num6++)
											{
												Thread.Sleep(100);
												if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
												{
													break;
												}
											}
										}
										else
										{
											for (int num7 = 0; num7 < num2; num7++)
											{
												Thread.Sleep(100);
												if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
												{
													break;
												}
											}
										}
										break;
									}
								}
							}
							else
							{
								for (int num8 = 0; num8 < num2; num8++)
								{
									Thread.Sleep(100);
									if (!this.modelVisitor[proccesorItem_0.InsertIndexer()].SortIndexer())
									{
										break;
									}
								}
							}
						}
					}
					return;
				}
			}
			goto IL_F3;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00015298 File Offset: 0x00013498
		private void method_15()
		{
			IntPtr zero = IntPtr.Zero;
			TesseractEngine tesseractEngine = new TesseractEngine("tessdata", "eng+equ", 3);
			while (this.bool_4)
			{
				foreach (Process process in Process.GetProcessesByName("Growtopia"))
				{
					ParamVisitor.SetForegroundWindow(process.MainWindowHandle);
					Thread.Sleep(250);
					Rectangle rectangle;
					ParamVisitor.GetWindowRect(process.MainWindowHandle, out rectangle);
					this.rectangle_1 = this.rectangle_2;
					Bitmap bitmap = new Bitmap(this.rectangle_1.Width, this.rectangle_1.Height, PixelFormat.Format32bppArgb);
					Graphics.FromImage(bitmap).CopyFromScreen(this.rectangle_1.Left, this.rectangle_1.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
					bitmap = this.ComputeToken(bitmap, 2 * this.rectangle_1.Width, 2 * this.rectangle_1.Height);
					tesseractEngine.SetVariable("tessedit_char_whitelist", "AreyouHuman?");
					Page page = tesseractEngine.Process(bitmap, null);
					string text = page.GetText();
					if (text.Contains("Are you Human"))
					{
						if (this.modelVisitor[process.MainWindowTitle].SelectIndexer())
						{
							this.modelVisitor[process.MainWindowTitle].PrintIndexer(true);
							Thread.Sleep(500);
						}
						if (this.modelVisitor[process.MainWindowTitle].SortIndexer())
						{
							this.modelVisitor[process.MainWindowTitle].ConnectIndexer(true);
							Thread.Sleep(500);
						}
						page.Dispose();
						this.rectangle_1 = this.rectangle_3;
						bitmap = new Bitmap(this.rectangle_1.Width, this.rectangle_1.Height, PixelFormat.Format32bppArgb);
						Graphics.FromImage(bitmap).CopyFromScreen(this.rectangle_1.Left, this.rectangle_1.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
						bitmap = this.ComputeToken(bitmap, 2 * this.rectangle_1.Width, 2 * this.rectangle_1.Height);
						tesseractEngine.SetVariable("tessedit_char_whitelist", "0123456789+");
						page = tesseractEngine.Process(bitmap, null);
						text = page.GetText();
						if (text.Contains("+"))
						{
							this.rectangle_1 = this.rectangle_4;
							this.rectangle_1.X = this.rectangle_1.X + this.rectangle_1.Width / 2 - rectangle.X;
							this.rectangle_1.Y = this.rectangle_1.Y + this.rectangle_1.Height / 2 - rectangle.Y - 30;
							this.rectangle_1.X = (int)((float)this.rectangle_1.X / this.m_ProducerVisitor);
							this.rectangle_1.Y = (int)((float)this.rectangle_1.Y / this.m_ProducerVisitor);
							IntPtr intptr_ = (IntPtr)(this.rectangle_1.Y << 16 | this.rectangle_1.X);
							zero = IntPtr.Zero;
							text.Replace(" ", "");
							string[] array = text.Split(new char[]
							{
								char.Parse("+")
							});
							if (array.Length == 2)
							{
								int num;
								int num2;
								if (int.TryParse(array[0], out num) && int.TryParse(array[1], out num2))
								{
									int num3 = num + num2;
									Console.WriteLine(page.GetText() + " = " + num3.ToString());
									SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
									SendKeys.SendWait(num3.ToString());
									Thread.Sleep(100);
									ParamVisitor.SendMessage(process.MainWindowHandle, 513U, zero, intptr_);
									Thread.Sleep(100);
									ParamVisitor.SendMessage(process.MainWindowHandle, 514U, zero, intptr_);
								}
								else
								{
									SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
									ParamVisitor.SendMessage(process.MainWindowHandle, 513U, zero, intptr_);
									Thread.Sleep(100);
									ParamVisitor.SendMessage(process.MainWindowHandle, 514U, zero, intptr_);
								}
							}
							else
							{
								SendKeys.SendWait("{BS}{BS}{BS}{BS}{BS}{BS}");
								ParamVisitor.SendMessage(process.MainWindowHandle, 513U, zero, intptr_);
								Thread.Sleep(100);
								ParamVisitor.SendMessage(process.MainWindowHandle, 514U, zero, intptr_);
							}
						}
						else
						{
							Console.WriteLine(page.GetText());
						}
						if (this.modelVisitor[process.MainWindowTitle].SelectIndexer())
						{
							Thread.Sleep(500);
							this.modelVisitor[process.MainWindowTitle].PrintIndexer(false);
						}
						if (this.modelVisitor[process.MainWindowTitle].SortIndexer())
						{
							Thread.Sleep(500);
							this.modelVisitor[process.MainWindowTitle].ConnectIndexer(false);
						}
					}
					page.Dispose();
					Thread.Sleep(500);
				}
				if (this.bool_5)
				{
					this.bool_4 = false;
					this.bool_5 = false;
				}
				else
				{
					Thread.Sleep(5000);
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000157CC File Offset: 0x000139CC
		private void button12_Click(object sender, EventArgs e)
		{
			this.button12.Visible = false;
			this.button11.Visible = true;
			this.button7.Enabled = true;
			this.button8.Enabled = true;
			this.button9.Enabled = true;
			this.button10.Enabled = true;
			this.bool_4 = false;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00015828 File Offset: 0x00013A28
		public string ListToken(string instance)
		{
			string result;
			try
			{
				result = new WebClient().DownloadString(instance);
			}
			catch (Exception)
			{
				try
				{
					result = new WebClient().DownloadString(instance.Replace("pastebin", "pastebinp"));
				}
				catch (Exception)
				{
					try
					{
						WebClient webClient = new WebClient();
						WebProxy proxy = new WebProxy("80.240.17.199:3128");
						webClient.Proxy = proxy;
						result = webClient.DownloadString(instance);
					}
					catch (Exception)
					{
						try
						{
							WebClient webClient2 = new WebClient();
							WebProxy proxy2 = new WebProxy("31.193.196.3:3128");
							webClient2.Proxy = proxy2;
							result = webClient2.DownloadString(instance);
						}
						catch (Exception)
						{
							try
							{
								WebClient webClient3 = new WebClient();
								WebProxy proxy3 = new WebProxy("34.90.113.143:3128");
								webClient3.Proxy = proxy3;
								result = webClient3.DownloadString(instance);
							}
							catch (Exception ex)
							{
								string str = "No internet connection? Shutting down. Error: ";
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

		// Token: 0x06000302 RID: 770 RVA: 0x00015934 File Offset: 0x00013B34
		private void button11_Click(object sender, EventArgs e)
		{
			this.button12.Visible = true;
			this.button11.Visible = false;
			this.button7.Enabled = false;
			this.button8.Enabled = false;
			this.button9.Enabled = false;
			this.button10.Enabled = false;
			this.bool_4 = true;
			this.bool_5 = false;
			new Thread(new ThreadStart(this.GetPage)).Start();
			Thread.Sleep(250);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003B44 File Offset: 0x00001D44
		private void method_16(object sender, EventArgs e)
		{
			this.int_4 = 1;
			this.dic_0.MoveWorker();
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003B58 File Offset: 0x00001D58
		private void button10_Click(object sender, EventArgs e)
		{
			this.bool_4 = true;
			this.bool_5 = true;
			new Thread(new ThreadStart(this.ComputePage)).Start();
			Thread.Sleep(250);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003B88 File Offset: 0x00001D88
		private void button9_Click(object sender, EventArgs e)
		{
			this.int_4 = 3;
			this.dic_0.MoveWorker();
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003B9C File Offset: 0x00001D9C
		private void button8_Click(object sender, EventArgs e)
		{
			this.int_4 = 2;
			this.dic_0.MoveWorker();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000023D9 File Offset: 0x000005D9
		public void DeleteToken(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000159B8 File Offset: 0x00013BB8
		public void RunToken(object sender, MouseEventArgs e)
		{
			this.dic_0.QueryWorker();
			this.bool_3 = false;
			this.form_0.Hide();
			Bitmap bitmap = new Bitmap(this.rectangle_1.Width, this.rectangle_1.Height, PixelFormat.Format32bppArgb);
			Graphics.FromImage(bitmap).CopyFromScreen(this.rectangle_1.Left, this.rectangle_1.Top, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
			switch (this.int_4)
			{
			case 1:
				this.int_4 = 0;
				this.rectangle_2 = this.rectangle_1;
				this.pictureBox1.Image = bitmap;
				return;
			case 2:
				this.int_4 = 0;
				this.rectangle_3 = this.rectangle_1;
				this.pictureBox2.Image = bitmap;
				return;
			case 3:
				this.int_4 = 0;
				this.rectangle_4 = this.rectangle_1;
				this.pictureBox3.Image = bitmap;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public void ChangeToken(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.DisableToken(e, 514U);
			}
			if (e.Button == MouseButtons.Right)
			{
				this.DisableToken(e, 517U);
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003BE4 File Offset: 0x00001DE4
		public void AssetToken(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.DisableToken(e, 513U);
			}
			if (e.Button == MouseButtons.Right)
			{
				this.DisableToken(e, 516U);
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003C18 File Offset: 0x00001E18
		public void IncludeToken(object sender, MouseEventArgs e)
		{
			if (!ParamVisitor.timer_0.Enabled)
			{
				this.DisableToken(e, 512U);
				ParamVisitor.timer_0.Interval = 500;
				ParamVisitor.timer_0.Start();
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003C4B File Offset: 0x00001E4B
		public void NewToken(object sender, MouseEventArgs e)
		{
			this.DisableToken(e, 522U);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00003C59 File Offset: 0x00001E59
		private static void smethod_2(object object_0, object object_1)
		{
			ParamVisitor.timer_0.Stop();
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00015AAC File Offset: 0x00013CAC
		public void DisableToken(MouseEventArgs var1, uint max_col)
		{
			bool flag = false;
			IntPtr foregroundWindow = ParamVisitor.GetForegroundWindow();
			IntPtr intPtr = IntPtr.Zero;
			Process[] array = this.process_0;
			for (int i = 0; i < array.Length; i++)
			{
				intPtr = array[i].MainWindowHandle;
				if (intPtr == foregroundWindow)
				{
					flag = true;
					IL_3E:
					if (flag)
					{
						Rectangle rectangle;
						ParamVisitor.GetWindowRect(foregroundWindow, out rectangle);
						array = this.process_0;
						for (i = 0; i < array.Length; i++)
						{
							intPtr = array[i].MainWindowHandle;
							if (intPtr != foregroundWindow)
							{
								IntPtr intptr_ = IntPtr.Zero;
								int num = (int)((float)var1.X / this.m_ProducerVisitor) - rectangle.X;
								IntPtr intptr_2 = (IntPtr)((int)((float)var1.Y / this.m_ProducerVisitor) - rectangle.Y - 30 << 16 | num);
								intptr_ = IntPtr.Zero;
								if (max_col == 522U)
								{
									intptr_ = (IntPtr)(var1.Delta << 16);
								}
								ParamVisitor.SendMessage(intPtr, max_col, intptr_, intptr_2);
							}
						}
					}
					return;
				}
			}
			goto IL_3E;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003B44 File Offset: 0x00001D44
		private void button7_Click(object sender, EventArgs e)
		{
			this.int_4 = 1;
			this.dic_0.MoveWorker();
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003C65 File Offset: 0x00001E65
		private void discordLogo_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/aCWG8R9");
			Process.Start("https://discord.gg/8ytpE44");
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003C7D File Offset: 0x00001E7D
		private void YTlogo_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCY_VhfecGXDZQ3A_fQg6DCQ/videos");
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00015BAC File Offset: 0x00013DAC
		public void StartToken(object sender, MouseEventArgs e)
		{
			this.bool_3 = true;
			this.int_0 = e.X;
			this.int_1 = e.Y;
			this.form_0.Show();
			this.form_0.Bounds = new Rectangle((int)((float)e.X / this.m_ProducerVisitor), (int)((float)e.Y / this.m_ProducerVisitor), 0, 0);
			this.Refresh();
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00015C1C File Offset: 0x00013E1C
		public void ManageToken(object sender, MouseEventArgs e)
		{
			if (!this.bool_3)
			{
				return;
			}
			int num = Math.Min(this.int_0, e.X);
			int num2 = Math.Min(this.int_1, e.Y);
			int num3 = Math.Max(this.int_0, e.X) - Math.Min(this.int_0, e.X);
			int num4 = Math.Max(this.int_1, e.Y) - Math.Min(this.int_1, e.Y);
			this.rectangle_1 = new Rectangle(num, num2, num3, num4);
			this.rectangle_0 = new Rectangle((int)((float)num / this.m_ProducerVisitor), (int)((float)num2 / this.m_ProducerVisitor), (int)((float)num3 / this.m_ProducerVisitor), (int)((float)num4 / this.m_ProducerVisitor));
			this.form_0.Bounds = this.rectangle_0;
			this.Refresh();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public void ResetToken(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Space)
			{
				this.dic_2.QueryWorker();
				Rectangle rectangle;
				ParamVisitor.GetWindowRect(ParamVisitor.GetForegroundWindow(), out rectangle);
				Point position = Cursor.Position;
				switch (this.int_5)
				{
				case 1:
					this.numericUpDown1.Value = position.X - rectangle.X;
					this.numericUpDown2.Value = position.Y - rectangle.Y - 30;
					break;
				case 2:
					this.numericUpDown4.Value = position.X - rectangle.X;
					this.numericUpDown3.Value = position.Y - rectangle.Y - 30;
					break;
				case 3:
					this.int_2 = position.X - rectangle.X;
					this.int_3 = position.Y - rectangle.Y - 30;
					this.button28.Enabled = true;
					this.button27.Enabled = true;
					this.button26.Enabled = true;
					break;
				}
				this.int_5 = 0;
				e.Handled = true;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003C8A File Offset: 0x00001E8A
		public void CalculateToken(object sender, KeyEventArgs e)
		{
			this.InitToken(e, 256U);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00003C98 File Offset: 0x00001E98
		public void CloneToken(object sender, KeyEventArgs e)
		{
			this.InitToken(e, 257U);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00015E38 File Offset: 0x00014038
		public void InitToken(KeyEventArgs item, uint pred)
		{
			bool flag = false;
			IntPtr foregroundWindow = ParamVisitor.GetForegroundWindow();
			IntPtr intPtr = IntPtr.Zero;
			Process[] array = this.process_0;
			for (int i = 0; i < array.Length; i++)
			{
				intPtr = array[i].MainWindowHandle;
				if (intPtr == foregroundWindow)
				{
					flag = true;
					IL_3E:
					if (flag)
					{
						array = this.process_0;
						for (i = 0; i < array.Length; i++)
						{
							intPtr = array[i].MainWindowHandle;
							if (intPtr != foregroundWindow)
							{
								bool flag2 = false;
								uint keyCode = (uint)item.KeyCode;
								uint num = ParamVisitor.MapVirtualKey(keyCode, 0U);
								if (pred == 256U)
								{
									uint num2 = 1U | num << 16;
									if (flag2)
									{
										num2 |= 16777216U;
									}
									ParamVisitor.PostMessageA(intPtr, 256U, (int)keyCode, (int)num2);
								}
								if (pred == 257U)
								{
									uint num2 = 1U | num << 16;
									num2 |= 3221225472U;
									ParamVisitor.PostMessageA(intPtr, 257U, (int)keyCode, (int)num2);
								}
							}
						}
					}
					return;
				}
			}
			goto IL_3E;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00003CA6 File Offset: 0x00001EA6
		public void CompareToken(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.F5)
			{
				this.dic_3.QueryWorker();
				this.bool_6 = true;
				e.Handled = true;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000023D9 File Offset: 0x000005D9
		public void SearchToken(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000023D9 File Offset: 0x000005D9
		public void CreateToken(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003CCB File Offset: 0x00001ECB
		private void method_17(string string_5)
		{
			Console.WriteLine(string_5 + "\r\n");
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00015F2C File Offset: 0x0001412C
		private float method_18()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			int deviceCaps = ParamVisitor.GetDeviceCaps(hdc, 10);
			return (float)ParamVisitor.GetDeviceCaps(hdc, 117) / (float)deviceCaps;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00015F5C File Offset: 0x0001415C
		public static Bitmap GetToken(Image key)
		{
			Bitmap bitmap = new Bitmap(key.Width, key.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			float[][] array = new float[5][];
			array[0] = new float[]
			{
				0.3f,
				0.3f,
				0.3f,
				0f,
				0f
			};
			array[1] = new float[]
			{
				0.59f,
				0.59f,
				0.59f,
				0f,
				0f
			};
			array[2] = new float[]
			{
				0.11f,
				0.11f,
				0.11f,
				0f,
				0f
			};
			int num = 3;
			float[] array2 = new float[5];
			array2[3] = 1f;
			array[num] = array2;
			array[4] = new float[]
			{
				0f,
				0f,
				0f,
				0f,
				1f
			};
			ColorMatrix colorMatrix = new ColorMatrix(array);
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix);
			graphics.DrawImage(key, new Rectangle(0, 0, key.Width, key.Height), 0, 0, key.Width, key.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0001602C File Offset: 0x0001422C
		public Bitmap ComputeToken(Bitmap value, int lengthcont, int consumer_min)
		{
			Bitmap bitmap = new Bitmap(lengthcont, consumer_min, value.PixelFormat);
			double num = (double)value.Width / (double)lengthcont;
			double num2 = (double)value.Height / (double)consumer_min;
			Color color = default(Color);
			Color color2 = default(Color);
			Color color3 = default(Color);
			Color color4 = default(Color);
			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					int num3 = (int)Math.Floor((double)i * num);
					int num4 = (int)Math.Floor((double)j * num2);
					int num5 = num3 + 1;
					if (num5 >= value.Width)
					{
						num5 = num3;
					}
					int num6 = num4 + 1;
					if (num6 >= value.Height)
					{
						num6 = num4;
					}
					double num7 = (double)i * num - (double)num3;
					double num8 = (double)j * num2 - (double)num4;
					double num9 = 1.0 - num7;
					double num10 = 1.0 - num8;
					color = value.GetPixel(num3, num4);
					color2 = value.GetPixel(num5, num4);
					color3 = value.GetPixel(num3, num6);
					color4 = value.GetPixel(num5, num6);
					byte b = (byte)(num9 * (double)color.B + num7 * (double)color2.B);
					byte b2 = (byte)(num9 * (double)color3.B + num7 * (double)color4.B);
					byte blue = (byte)(num10 * (double)b + num8 * (double)b2);
					b = (byte)(num9 * (double)color.G + num7 * (double)color2.G);
					b2 = (byte)(num9 * (double)color3.G + num7 * (double)color4.G);
					byte green = (byte)(num10 * (double)b + num8 * (double)b2);
					b = (byte)(num9 * (double)color.R + num7 * (double)color2.R);
					b2 = (byte)(num9 * (double)color3.R + num7 * (double)color4.R);
					byte red = (byte)(num10 * (double)b + num8 * (double)b2);
					bitmap.SetPixel(i, j, Color.FromArgb(255, (int)red, (int)green, (int)blue));
				}
			}
			bitmap = this.RateToken(bitmap);
			return this.AddToken(bitmap);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00016248 File Offset: 0x00014448
		public Bitmap RateToken(Bitmap ident)
		{
			Bitmap bitmap = (Bitmap)ident.Clone();
			for (int i = 0; i < bitmap.Width; i++)
			{
				for (int j = 0; j < bitmap.Height; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					byte b = (byte)(0.299 * (double)pixel.R + 0.587 * (double)pixel.G + 0.114 * (double)pixel.B);
					bitmap.SetPixel(i, j, Color.FromArgb((int)b, (int)b, (int)b));
				}
			}
			return (Bitmap)bitmap.Clone();
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000162E8 File Offset: 0x000144E8
		private void startGTwindows_Click(object sender, EventArgs e)
		{
			if (this.checkBox8.Checked && (int)this.no_GT_windows.Value > this.checkedListBox3.Items.Count)
			{
				MessageBox.Show("You are opening more windows than accounts you have added. Please uncheck the checkbox 'Auto Log In' to disable auto log in. \n\rWindows to open: " + ((int)this.no_GT_windows.Value).ToString() + "\n\rAccounts added:" + this.checkedListBox3.Items.Count.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			CultureInfo culture = InputLanguage.CurrentInputLanguage.Culture;
			InputLanguage currentInputLanguage = InputLanguage.CurrentInputLanguage;
			if (culture.Name == "en-US")
			{
				culture = InputLanguage.DefaultInputLanguage.Culture;
				InputLanguage defaultInputLanguage = InputLanguage.DefaultInputLanguage;
			}
			new ParamVisitor.Class14().method_2(CultureInfo.GetCultureInfo(1033));
			Thread.Sleep(500);
			this.method_19((int)this.no_GT_windows.Value);
			this.method_12();
			Thread.Sleep(1000);
			new ParamVisitor.Class14().method_2(culture);
			Thread.Sleep(500);
			ParamVisitor.keybd_event(164, 56, 0, 0);
			Thread.Sleep(50);
			ParamVisitor.keybd_event(160, 42, 0, 0);
			Thread.Sleep(50);
			ParamVisitor.keybd_event(160, 170, 2, 0);
			Thread.Sleep(50);
			for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
			{
				if (InputLanguage.InstalledInputLanguages[i].LayoutName == culture.Name)
				{
					SendKeys.Send(i.ToString());
					IL_18D:
					Thread.Sleep(50);
					ParamVisitor.keybd_event(164, 184, 2, 0);
					Thread.Sleep(50);
					return;
				}
			}
			goto IL_18D;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000164A4 File Offset: 0x000146A4
		public Bitmap AddToken(Bitmap param)
		{
			int num = 145;
			for (int i = 0; i < param.Width; i++)
			{
				for (int j = 0; j < param.Height; j++)
				{
					Color pixel = param.GetPixel(i, j);
					if ((int)pixel.R <= num && (int)pixel.G <= num && (int)pixel.B <= num)
					{
						param.SetPixel(i, j, Color.White);
					}
					else if ((int)pixel.R > num && (int)pixel.G > num && (int)pixel.B > num)
					{
						param.SetPixel(i, j, Color.Black);
					}
				}
			}
			return param;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00003B15 File Offset: 0x00001D15
		private void Refresh_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001653C File Offset: 0x0001473C
		private void Select_all_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
			{
				if (this.Select_all.Checked)
				{
					this.checkedListBox1.SetItemChecked(i, true);
				}
				else
				{
					this.checkedListBox1.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00016590 File Offset: 0x00014790
		private void close_gt_windows_Click(object sender, EventArgs e)
		{
			int num = 0;
			foreach (Process process in this.list_0)
			{
				if (ParamVisitor.DisablePage(process.MainWindowTitle))
				{
					for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
					{
						if (this.checkedListBox1.GetItemCheckState(i) == CheckState.Checked && process.MainWindowTitle == this.checkedListBox1.Items[i].ToString())
						{
							if (num != this.list_0.Count - 1)
							{
								process.Kill();
								Thread.Sleep(200);
							}
							else if (ParamVisitor.PatchPage() == 1)
							{
								process.Kill();
							}
						}
					}
				}
				num++;
			}
			Thread.Sleep(500);
			this.method_12();
			if (ParamVisitor.PatchPage() == 0)
			{
				this.list_0.Clear();
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000023D9 File Offset: 0x000005D9
		private void label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00016698 File Offset: 0x00014898
		private void method_19(int int_6)
		{
			if (this.method_0() != "")
			{
				List<Process> list = new List<Process>();
				if (this.list_0.Count > 0)
				{
					foreach (Process process in this.list_0)
					{
						if (ParamVisitor.DisablePage(process.MainWindowTitle))
						{
							this.method_23(process);
							list.Add(process);
						}
					}
					Thread.Sleep(1000);
				}
				for (int i = 0; i < int_6; i++)
				{
					if (this.checkBox8.Checked && i + 1 <= this.checkedListBox3.Items.Count)
					{
						if (File.Exists(this.method_0().Replace("Growtopia.exe", "save.dat")))
						{
							File.Delete(this.method_0().Replace("Growtopia.exe", "save.dat"));
						}
						string currentDirectory = Directory.GetCurrentDirectory();
						string str = "/Accounts/";
						object obj = this.checkedListBox3.Items[i];
						File.Copy(currentDirectory + str + ((obj != null) ? obj.ToString() : null), this.method_0().Replace("Growtopia.exe", "save.dat"));
					}
					if (i != 0)
					{
						this.method_23(this.list_0[this.list_0.Count - 1]);
						list.Add(this.list_0[this.list_0.Count - 1]);
						Thread.Sleep(1000);
					}
					if (this.list_0.Count > 0)
					{
						this.method_22(this.list_0[this.list_0.Count - 1]);
					}
					Process process2 = new Process();
					process2.StartInfo.FileName = this.method_0();
					this.list_0.Add(process2);
					process2.Start();
					Thread.Sleep(1500);
					process2.WaitForInputIdle();
					ParamVisitor.SetWindowText(process2.MainWindowHandle, "Growtopia " + this.list_0.Count.ToString());
					Process process3 = process2;
					switch (this.comboBox3.SelectedIndex)
					{
					case 0:
						process3.PriorityClass = ProcessPriorityClass.RealTime;
						break;
					case 1:
						process3.PriorityClass = ProcessPriorityClass.High;
						break;
					case 2:
						process3.PriorityClass = ProcessPriorityClass.AboveNormal;
						break;
					case 3:
						process3.PriorityClass = ProcessPriorityClass.Normal;
						break;
					case 4:
						process3.PriorityClass = ProcessPriorityClass.BelowNormal;
						break;
					case 5:
						process3.PriorityClass = ProcessPriorityClass.Idle;
						break;
					}
					(long)process3.ProcessorAffinity;
					double num = 0.0;
					for (int j = 0; j < this.checkedListBox4.Items.Count; j++)
					{
						if (this.checkedListBox4.GetItemChecked(j))
						{
							num += Math.Pow(2.0, (double)j);
						}
					}
					int value = (int)num;
					Console.WriteLine("0");
					process3.ProcessorAffinity = (IntPtr)value;
					SendKeys.Send("{Enter}");
					if (this.checkBox8.Checked && i + 1 <= this.checkedListBox3.Items.Count)
					{
						if (this.checkBox9.Checked)
						{
							Thread.Sleep(100);
							SendKeys.Send("{Enter}");
							Thread.Sleep(100);
							SendKeys.Send("{Enter}");
							Thread.Sleep((int)this.iTalk_NumericUpDown1.Value);
						}
						else
						{
							SendKeys.Send("{Enter}");
							Thread.Sleep(100);
						}
					}
				}
				using (List<Process>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Process process_ = enumerator.Current;
						this.method_24(process_);
					}
					return;
				}
			}
			MessageBox.Show("Please set a file path for Growtopia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "exe |*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show(openFileDialog.FileName);
				this.method_1(openFileDialog.FileName);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000023D9 File Offset: 0x000005D9
		private void SpammerText1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000023D9 File Offset: 0x000005D9
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00003B15 File Offset: 0x00001D15
		private void RefreshSpam_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00016AD0 File Offset: 0x00014CD0
		private void SelectAllSpam_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.ProcessesSpam.Items.Count; i++)
			{
				if (this.SelectAllSpam.Checked)
				{
					this.ProcessesSpam.SetItemChecked(i, true);
				}
				else
				{
					this.ProcessesSpam.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00016B24 File Offset: 0x00014D24
		private void EnableSpammer_CheckedChanged(object sender, EventArgs e)
		{
			ParamVisitor.ProccesorToken proccesorToken = new ParamVisitor.ProccesorToken();
			proccesorToken.m_RuleToken = this;
			if (this.EnableSpammer.CheckState == CheckState.Checked)
			{
				proccesorToken.m_PoolToken = 0;
				while (proccesorToken.m_PoolToken < this.ProcessesSpam.Items.Count)
				{
					if (this.ProcessesSpam.GetItemCheckState(proccesorToken.m_PoolToken) == CheckState.Checked && !this.modelVisitor[this.ProcessesSpam.Items[proccesorToken.m_PoolToken].ToString()].SortIndexer())
					{
						this.modelVisitor[this.ProcessesSpam.Items[proccesorToken.m_PoolToken].ToString()].PushIndexer(true);
						this.modelVisitor[this.ProcessesSpam.Items[proccesorToken.m_PoolToken].ToString()].ConnectIndexer(false);
						ThreadStart start;
						if ((start = proccesorToken.modelToken) == null)
						{
							start = (proccesorToken.modelToken = new ThreadStart(proccesorToken.CloneDescriptor));
						}
						new Thread(start).Start();
						Thread.Sleep(250);
					}
					int poolToken = proccesorToken.m_PoolToken;
					proccesorToken.m_PoolToken = poolToken + 1;
				}
				return;
			}
			for (int i = 0; i < this.ProcessesSpam.Items.Count; i++)
			{
				if (this.modelVisitor[this.ProcessesSpam.Items[i].ToString()].SortIndexer())
				{
					this.modelVisitor[this.ProcessesSpam.Items[i].ToString()].PushIndexer(false);
					this.modelVisitor[this.ProcessesSpam.Items[i].ToString()].ConnectIndexer(false);
				}
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00003CDD File Offset: 0x00001EDD
		private void button13_Click(object sender, EventArgs e)
		{
			this.string_3 = File.ReadAllLines("ItemData.txt");
			this.method_6();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00003CF5 File Offset: 0x00001EF5
		private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.string_3 != null)
			{
				this.method_6();
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000023D9 File Offset: 0x000005D9
		private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_20(object sender, EventArgs e)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000023D9 File Offset: 0x000005D9
		private void ProcessesSpam_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003D05 File Offset: 0x00001F05
		private static bool smethod_3()
		{
			return Marshal.SizeOf(typeof(IntPtr)) == 8;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_21(object sender, EventArgs e)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00016CF0 File Offset: 0x00014EF0
		private static string smethod_4(ParamVisitor.Class12.ExceptionTest exceptionTest_0, Process process_1)
		{
			IntPtr intptr_ = ParamVisitor.OpenProcess_1(2035711U, false, process_1.Id);
			IntPtr zero = IntPtr.Zero;
			if (!ParamVisitor.DuplicateHandle(intptr_, exceptionTest_0.collectionTest, ParamVisitor.GetCurrentProcess(), out zero, 0U, false, 2U))
			{
				return null;
			}
			IntPtr intPtr = IntPtr.Zero;
			ParamVisitor.Class12.ConfigurationTest configurationTest = default(ParamVisitor.Class12.ConfigurationTest);
			ParamVisitor.Class12.ExpressionTest expressionTest = default(ParamVisitor.Class12.ExpressionTest);
			intPtr = Marshal.AllocHGlobal(Marshal.SizeOf<ParamVisitor.Class12.ConfigurationTest>(configurationTest));
			int num = 0;
			ParamVisitor.NtQueryObject(zero, 0, intPtr, Marshal.SizeOf<ParamVisitor.Class12.ConfigurationTest>(configurationTest), ref num);
			configurationTest = (ParamVisitor.Class12.ConfigurationTest)Marshal.PtrToStructure(intPtr, configurationTest.GetType());
			Marshal.FreeHGlobal(intPtr);
			num = configurationTest.m_FacadeTest;
			IntPtr intPtr2 = Marshal.AllocHGlobal(num);
			while (ParamVisitor.NtQueryObject(zero, 1, intPtr2, num, ref num) == -1073741820)
			{
				Marshal.FreeHGlobal(intPtr2);
				intPtr2 = Marshal.AllocHGlobal(num);
			}
			expressionTest = (ParamVisitor.Class12.ExpressionTest)Marshal.PtrToStructure(intPtr2, expressionTest.GetType());
			IntPtr intPtr3;
			if (ParamVisitor.smethod_3())
			{
				intPtr3 = (IntPtr)((long)((ulong)((long)expressionTest.m_SystemTest.m_FactoryTest) >> 32));
			}
			else
			{
				intPtr3 = expressionTest.m_SystemTest.m_FactoryTest;
			}
			if (intPtr3 != IntPtr.Zero)
			{
				if (ParamVisitor.smethod_3())
				{
					intPtr3 = intPtr2 + 16;
				}
				byte[] destination = new byte[num];
				string result;
				try
				{
					Marshal.Copy(intPtr3, destination, 0, num);
					result = Marshal.PtrToStringUni(ParamVisitor.smethod_3() ? new IntPtr(intPtr3.ToInt64()) : new IntPtr(intPtr3.ToInt32()));
				}
				catch (AccessViolationException)
				{
					result = null;
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr2);
					ParamVisitor.CloseHandle(zero);
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00016E94 File Offset: 0x00015094
		private void method_22(Process process_1)
		{
			Console.WriteLine("Starting handle magic...");
			int num = 0;
			IntPtr zero = IntPtr.Zero;
			int int_ = 65536;
			IntPtr intPtr = Marshal.AllocHGlobal(65536);
			while (ParamVisitor.NtQuerySystemInformation(16U, intPtr, int_, ref num) == 3221225476U)
			{
				int_ = num;
				Marshal.FreeHGlobal(intPtr);
				intPtr = Marshal.AllocHGlobal(num);
			}
			byte[] destination = new byte[num];
			Marshal.Copy(intPtr, destination, 0, num);
			long num2;
			if (ParamVisitor.smethod_3())
			{
				num2 = Marshal.ReadInt64(intPtr);
				zero = new IntPtr(intPtr.ToInt64() + 8L);
			}
			else
			{
				num2 = (long)Marshal.ReadInt32(intPtr);
				zero = new IntPtr(intPtr.ToInt32() + 4);
			}
			List<ParamVisitor.Class12.ExceptionTest> list = new List<ParamVisitor.Class12.ExceptionTest>();
			for (long num3 = 0L; num3 < num2; num3 += 1L)
			{
				ParamVisitor.Class12.ExceptionTest exceptionTest = default(ParamVisitor.Class12.ExceptionTest);
				if (ParamVisitor.smethod_3())
				{
					exceptionTest = (ParamVisitor.Class12.ExceptionTest)Marshal.PtrToStructure(zero, exceptionTest.GetType());
					zero = new IntPtr(zero.ToInt64() + (long)Marshal.SizeOf<ParamVisitor.Class12.ExceptionTest>(exceptionTest) + 8L);
				}
				else
				{
					exceptionTest = (ParamVisitor.Class12.ExceptionTest)Marshal.PtrToStructure(zero, exceptionTest.GetType());
					zero = new IntPtr(zero.ToInt64() + (long)Marshal.SizeOf<ParamVisitor.Class12.ExceptionTest>(exceptionTest));
				}
				if (exceptionTest._ProcessTest == process_1.Id)
				{
					string text = ParamVisitor.smethod_4(exceptionTest, process_1);
					if (text != null && text.StartsWith("\\Sessions\\") && text.EndsWith("\\BaseNamedObjects\\Growtopia"))
					{
						list.Add(exceptionTest);
						Console.WriteLine("PID {0,7} Pointer {1,12} Type {2,4} Name {3}", new object[]
						{
							exceptionTest._ProcessTest.ToString(),
							exceptionTest.authenticationTest.ToString(),
							exceptionTest._ImporterTest.ToString(),
							text
						});
					}
				}
			}
			Console.WriteLine("Closing mutexes?");
			foreach (ParamVisitor.Class12.ExceptionTest exceptionTest_ in list)
			{
				this.method_42(exceptionTest_);
			}
			Console.WriteLine("Handle closed.");
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000170D0 File Offset: 0x000152D0
		private void method_23(Process process_1)
		{
			foreach (object obj in process_1.Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = ParamVisitor.OpenThread(2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					ParamVisitor.SuspendThread(intPtr);
					ParamVisitor.CloseHandle(intPtr);
				}
			}
			Console.WriteLine("SUSPENDED");
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00017158 File Offset: 0x00015358
		private void method_24(Process process_1)
		{
			foreach (object obj in process_1.Threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				IntPtr intPtr = ParamVisitor.OpenThread(2, false, (uint)processThread.Id);
				if (!(intPtr == IntPtr.Zero))
				{
					int num;
					do
					{
						num = ParamVisitor.ResumeThread(intPtr);
					}
					while (num > 0);
					ParamVisitor.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000171E0 File Offset: 0x000153E0
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox1.Text == "/msg")
			{
				this.textBox1.Visible = true;
				this.label13.Visible = true;
				this.numericUpDown5.Visible = true;
				return;
			}
			this.textBox1.Visible = false;
			this.label13.Visible = false;
			this.numericUpDown5.Visible = false;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_25(object sender, EventArgs e)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00017250 File Offset: 0x00015450
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < this.checkedListBox2.Items.Count; i++)
			{
				if (this.checkBox3.Checked)
				{
					this.checkedListBox2.SetItemChecked(i, true);
				}
				else
				{
					this.checkedListBox2.SetItemChecked(i, false);
				}
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000023D9 File Offset: 0x000005D9
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000172A4 File Offset: 0x000154A4
		private void button15_Click(object sender, EventArgs e)
		{
			if (this.listBox1.SelectedItem != null)
			{
				this.checkBox3.CheckState = CheckState.Unchecked;
				this.label10.Text = "GT:" + this.listBox1.Text;
				this.checkedListBox2.Items.Clear();
				List<string> list = this.method_43(this.modelVisitor[this.listBox1.Text], this.GT_version_cmd.SelectedIndex);
				for (int i = 0; i < list.Count; i++)
				{
					this.checkedListBox2.Items.Add(list[i]);
				}
				this.checkBox3.Text = "Select all (" + this.checkedListBox2.Items.Count.ToString() + ")";
				return;
			}
			MessageBox.Show("Please select a window under 'Attatch to:'");
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00003B15 File Offset: 0x00001D15
		private void button14_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001738C File Offset: 0x0001558C
		private void Execute_Click(object sender, EventArgs e)
		{
			this.bool_6 = false;
			this.dic_3.MoveWorker();
			int num = 0;
			IL_2A6:
			while (num < this.numericUpDown6.Value)
			{
				if (this.listBox1.SelectedItem != null)
				{
					foreach (Process process in Process.GetProcessesByName("Growtopia"))
					{
						IntPtr mainWindowHandle = process.MainWindowHandle;
						if (process.MainWindowTitle == this.listBox1.SelectedItem.ToString())
						{
							ParamVisitor.SetForegroundWindow(process.MainWindowHandle);
						}
					}
				}
				else
				{
					MessageBox.Show("Please select a target window under the section 'Attach to:'");
				}
				int j = 0;
				while (j < this.checkedListBox2.Items.Count)
				{
					if (!this.bool_6)
					{
						if (this.checkedListBox2.GetItemCheckState(j) == CheckState.Checked)
						{
							string text = this.comboBox1.Text;
							string keys;
							if (text != null && text == "/msg")
							{
								int num2 = new Random().Next(1, 10);
								string text2 = "";
								for (int k = 0; k < num2; k++)
								{
									text2 += " ";
								}
								string text3;
								if (j % 2 == 0)
								{
									text3 = "'";
								}
								else
								{
									text3 = "''";
								}
								keys = string.Concat(new string[]
								{
									this.comboBox1.Text,
									" ",
									this.checkedListBox2.Items[j].ToString(),
									" ",
									this.textBox1.Text,
									text2,
									text3
								});
							}
							else
							{
								keys = this.comboBox1.Text + " " + this.checkedListBox2.Items[j].ToString();
							}
							SendKeys.SendWait("{ENTER}");
							Thread.Sleep(50);
							SendKeys.SendWait(keys);
							Thread.Sleep(50);
							if (this.comboBox1.Text == "/msg")
							{
								Thread.Sleep(250);
							}
							SendKeys.SendWait("{ENTER}");
							Thread.Sleep(50);
							if (this.comboBox1.Text == "/msg")
							{
								this.UpdateTest((int)this.numericUpDown5.Value);
							}
						}
						j++;
					}
					else
					{
						ParamVisitor.SetForegroundWindow(base.Handle);
						MessageBox.Show("Operation aborted!");
						IL_26D:
						if (this.numericUpDown6.Value > 1m)
						{
							this.QueryTest((int)this.numericUpDown7.Value);
						}
						if (!this.bool_6)
						{
							num++;
							goto IL_2A6;
						}
						ParamVisitor.SetForegroundWindow(base.Handle);
						MessageBox.Show("Operation aborted!");
						goto IL_2DA;
					}
				}
				goto IL_26D;
				IL_2DA:
				this.dic_3.QueryWorker();
				ParamVisitor.SetForegroundWindow(base.Handle);
				return;
			}
			goto IL_2DA;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001768C File Offset: 0x0001588C
		public void UpdateTest(int flags_param)
		{
			ParamVisitor.MappingToken mappingToken = new ParamVisitor.MappingToken();
			mappingToken.m_MockToken = new Timer();
			if (flags_param != 0 && flags_param >= 0)
			{
				mappingToken.m_MockToken.Interval = flags_param;
				mappingToken.m_MockToken.Enabled = true;
				mappingToken.m_MockToken.Start();
				mappingToken.m_MockToken.Tick += mappingToken.InitDescriptor;
				while (mappingToken.m_MockToken.Enabled)
				{
					Application.DoEvents();
				}
				return;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00017700 File Offset: 0x00015900
		public void QueryTest(int param_Ptr)
		{
			ParamVisitor.WriterToken writerToken = new ParamVisitor.WriterToken();
			writerToken.infoToken = new Timer();
			if (param_Ptr != 0 && param_Ptr >= 0)
			{
				writerToken.infoToken.Interval = param_Ptr;
				writerToken.infoToken.Enabled = true;
				writerToken.infoToken.Start();
				writerToken.infoToken.Tick += writerToken.CompareDescriptor;
				while (writerToken.infoToken.Enabled)
				{
					Application.DoEvents();
					if (this.bool_6)
					{
						writerToken.infoToken.Enabled = false;
						writerToken.infoToken.Stop();
					}
				}
				return;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_26(object sender, EventArgs e)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003D1C File Offset: 0x00001F1C
		private void UnbanButton_Click(object sender, EventArgs e)
		{
			Broadcaster.CalcList();
			this.method_27();
			this.m_QueueTests.Items.Add("MAC Addresses Done！");
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00017794 File Offset: 0x00015994
		private void method_27()
		{
			foreach (NetworkInterface var in NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(ParamVisitor.ParserToken.m_RefToken.SearchDescriptor)).OrderByDescending(new Func<NetworkInterface, long>(ParamVisitor.ParserToken.m_RefToken.CreateDescriptor)))
			{
				Client client = new Client(var);
				string text = "163A21F7D938";
				if (!Client.CalcWorker(text, false))
				{
					MessageBox.Show("Entered MAC-address is not valid; will not update.", "Invalid MAC-address specified", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				}
				if (client.SearchWorker(text))
				{
					Thread.Sleep(100);
					MessageBox.Show("Done!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00017870 File Offset: 0x00015A70
		private void button16_Click(object sender, EventArgs e)
		{
			this.pictureBox6.Width = 549;
			this.pictureBox6.Height = 235;
			this.pictureBox6.Location = new Point(-4, 75);
			this.pictureBox6.Image = null;
			WebClient webClient = new WebClient();
			try
			{
				if (this.checkBox4.Checked)
				{
					if (!Directory.Exists("Saved Worlds"))
					{
						Directory.CreateDirectory("Saved Worlds");
					}
					webClient.DownloadFile("https://s3.amazonaws.com/world.growtopiagame.com/" + this.maskedTextBox3.Text + ".png", "Saved Worlds\\" + this.maskedTextBox3.Text + ".png");
					MemoryStream memoryStream = new MemoryStream(webClient.DownloadData("https://s3.amazonaws.com/world.growtopiagame.com/" + this.maskedTextBox3.Text + ".png"));
					this.composerVisitor = Image.FromStream(memoryStream);
					memoryStream.Close();
					this.pictureBox6.Image = this.composerVisitor;
				}
				else
				{
					MemoryStream memoryStream2 = new MemoryStream(webClient.DownloadData("https://s3.amazonaws.com/world.growtopiagame.com/" + this.maskedTextBox3.Text + ".png"));
					this.composerVisitor = Image.FromStream(memoryStream2);
					memoryStream2.Close();
					this.pictureBox6.Image = this.composerVisitor;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("That world can't be rendered");
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000179D8 File Offset: 0x00015BD8
		private void method_28()
		{
			this.pictureBox6.Width = 549 * this.trackBar1.Value / 2;
			this.pictureBox6.Height = 235 * this.trackBar1.Value / 2;
			Application.DoEvents();
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00003D3F File Offset: 0x00001F3F
		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			this.method_28();
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000023D9 File Offset: 0x000005D9
		private void pictureBox6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_29(object sender, EventArgs e)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00017A28 File Offset: 0x00015C28
		private void button17_Click(object sender, EventArgs e)
		{
			this.pictureBox6.Location = new Point(this.pictureBox6.Location.X, this.pictureBox6.Location.Y + 25);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00017A70 File Offset: 0x00015C70
		private void button18_Click(object sender, EventArgs e)
		{
			this.pictureBox6.Location = new Point(this.pictureBox6.Location.X, this.pictureBox6.Location.Y - 25);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00017AB8 File Offset: 0x00015CB8
		private void button20_Click(object sender, EventArgs e)
		{
			this.pictureBox6.Location = new Point(this.pictureBox6.Location.X - 25, this.pictureBox6.Location.Y);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00017B00 File Offset: 0x00015D00
		private void button19_Click(object sender, EventArgs e)
		{
			this.pictureBox6.Location = new Point(this.pictureBox6.Location.X + 25, this.pictureBox6.Location.Y);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00003D47 File Offset: 0x00001F47
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start(Directory.GetCurrentDirectory() + "\\Saved Worlds\\");
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00017B48 File Offset: 0x00015D48
		private void method_30()
		{
			this.comboBox2.Items.Clear();
			string[] array = "[United_Kingdom_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn453327113.opengw.net\r\n\r\n[United_States_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn984160303.opengw.net\r\n\r\n[United_States_2_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=exia-001-anti-ddos.opengw.net\r\n\r\n[United_Kingdom_2_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn429494865.opengw.net\r\n\r\n[Colombia_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn597817389.opengw.net\r\n\r\n[Suriname_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=atv-ddns.opengw.net\r\n\r\n[Singapore_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn901642793.opengw.net\r\n\r\n[Japan_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=rspnet-jp1.opengw.net\r\n\r\n[Malaysia_VPN]\r\nMEDIA=rastapi\r\nPort=VPN2-0\r\nDevice=WAN Miniport (IKEv2)\r\nDEVICE=vpn\r\nPhoneNumber=vpn230750292.opengw.net".Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains("["))
				{
					array[i] = array[i].Replace("[", "").Replace("]", "");
					array[i] = array[i].Remove(array[i].Length - 1, 1);
					this.comboBox2.Items.Add(array[i]);
				}
			}
			this.comboBox2.SelectedIndex = 0;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_31()
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00017BF4 File Offset: 0x00015DF4
		private void method_32()
		{
			object obj = "Desktop";
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			if (ParamVisitor.CreatorToken._ClientToken == null)
			{
				ParamVisitor.CreatorToken._ClientToken = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(ParamVisitor)));
			}
			string pathLink = ParamVisitor.CreatorToken._ClientToken.Target(ParamVisitor.CreatorToken._ClientToken, wshShell.SpecialFolders.Item(ref obj)) + "\\GT Auto-CCS by RealGoblins.lnk";
			if (ParamVisitor.CreatorToken.prototypeToken == null)
			{
				ParamVisitor.CreatorToken.prototypeToken = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(ParamVisitor)));
			}
			IWshShortcut wshShortcut = ParamVisitor.CreatorToken.prototypeToken.Target(ParamVisitor.CreatorToken.prototypeToken, wshShell.CreateShortcut(pathLink));
			wshShortcut.Description = "GT Auto-CCS by RealGoblins";
			wshShortcut.Hotkey = "";
			wshShortcut.TargetPath = Environment.CurrentDirectory + "\\GT Auto-CCS by RealGoblins.exe";
			wshShortcut.Save();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00017CF0 File Offset: 0x00015EF0
		private void method_33(object sender, StateChangedEventArgs e)
		{
			ParamVisitor.CallbackToken callbackToken = new ParamVisitor.CallbackToken();
			callbackToken.decoratorToken = e;
			callbackToken._RulesToken = this;
			Console.WriteLine(string.Format("State: {0}", callbackToken.decoratorToken.State));
			base.BeginInvoke(new MethodInvoker(callbackToken.CheckDescriptor));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00017D44 File Offset: 0x00015F44
		private void method_34(object sender, ErrorEventArgs e)
		{
			ParamVisitor.DatabaseToken databaseToken = new ParamVisitor.DatabaseToken();
			databaseToken.m_StubToken = this;
			databaseToken.m_InterceptorToken = e;
			Console.WriteLine(string.Format("Error: {0}", databaseToken.m_InterceptorToken.GetException()));
			base.BeginInvoke(new MethodInvoker(databaseToken.GetDescriptor));
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00017D94 File Offset: 0x00015F94
		private void button22_Click(object sender, EventArgs e)
		{
			ParamVisitor.StrategyToken strategyToken = new ParamVisitor.StrategyToken();
			strategyToken._IteratorToken = this;
			this.m_QueueTests.Items.Add("Connecting...");
			this.comboBox2.Enabled = false;
			this.button22.Enabled = false;
			this.button23.Enabled = true;
			strategyToken.eventToken = this.comboBox2.SelectedItem.ToString();
			new Thread(new ThreadStart(strategyToken.ComputeDescriptor)).Start();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00017E14 File Offset: 0x00016014
		private void method_35(string string_5, string string_6, string string_7)
		{
			this.m_RequestVisitor = new RasDialer();
			this.m_RequestVisitor.StateChanged += this.method_33;
			this.m_RequestVisitor.Error += this.method_34;
			File.WriteAllBytes(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk", TestsToken.ChangeMap());
			this.m_RequestVisitor.PhoneBookPath = Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk";
			this.m_RequestVisitor.EntryName = string_5;
			this.m_RequestVisitor.Credentials = new NetworkCredential(string_6, string_7);
			try
			{
				this.watcherVisitor = this.m_RequestVisitor.Connect();
				base.BeginInvoke(new MethodInvoker(this.RatePage));
				File.Delete(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
			}
			catch (Exception ex)
			{
				ParamVisitor.ObserverToken observerToken = new ParamVisitor.ObserverToken();
				observerToken.m_RegistryToken = this;
				Exception readerToken = ex;
				observerToken.readerToken = readerToken;
				base.BeginInvoke(new MethodInvoker(observerToken.RateDescriptor));
				File.Delete(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
			}
			File.Exists(Directory.GetCurrentDirectory() + "\\VPN phonebook\\VPN servers.pbk");
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00017F48 File Offset: 0x00016148
		private void button23_Click(object sender, EventArgs e)
		{
			this.comboBox2.Enabled = true;
			this.button22.Enabled = true;
			if (this.watcherVisitor != null)
			{
				this.watcherVisitor.Disconnect();
				this.m_QueueTests.Items.Add("Connection disconnected!");
				this.m_QueueTests.Items.Add(" ");
				Application.DoEvents();
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00017FB8 File Offset: 0x000161B8
		private void button24_Click(object sender, EventArgs e)
		{
			Process process = new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "rasdial.exe",
					Arguments = "",
					UseShellExecute = false,
					RedirectStandardOutput = true,
					CreateNoWindow = true
				}
			};
			process.Start();
			while (!process.StandardOutput.EndOfStream)
			{
				string item = process.StandardOutput.ReadLine();
				this.m_QueueTests.Items.Add(item);
				Application.DoEvents();
			}
			this.m_QueueTests.Items.Add(" ");
			Application.DoEvents();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000023D9 File Offset: 0x000005D9
		private void m_QueueTests_ControlAdded(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000023D9 File Offset: 0x000005D9
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000023D9 File Offset: 0x000005D9
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00003D5E File Offset: 0x00001F5E
		private void method_36(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000023D9 File Offset: 0x000005D9
		private void label17_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_37(object sender, EventArgs e)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003D6A File Offset: 0x00001F6A
		private void MB_enable_CheckedChanged(object sender, EventArgs e)
		{
			if (this.MB_enable.CheckState == CheckState.Checked)
			{
				this.process_0 = Process.GetProcessesByName("Growtopia");
				this.dic_1.MoveWorker();
				return;
			}
			this.dic_1.QueryWorker();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00003DA1 File Offset: 0x00001FA1
		private void button25_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "MAC Address Tool",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00018058 File Offset: 0x00016258
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			int num = (int)Math.Max(400.0 - (double)this.textBox1.Text.Length / 5.0 * 50.0, 75.0);
			this.numericUpDown5.Value = this.textBox1.Text.Length * num;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000023D9 File Offset: 0x000005D9
		private void pictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000180C8 File Offset: 0x000162C8
		public void CalculateTest(bool includekey, Process cust)
		{
			ParamVisitor.CandidateToken candidateToken = new ParamVisitor.CandidateToken();
			candidateToken._ProducerToken = this;
			candidateToken._RoleToken = cust;
			List<string> list = new List<string>();
			base.BeginInvoke(new MethodInvoker(candidateToken.InterruptDescriptor));
			bool flag = true;
			Mem mem = new Mem();
			mem.OpenProcess(candidateToken._RoleToken.Id);
			while (flag & this.bool_1)
			{
				Task<IEnumerable<long>> task = mem.AoBScan("57 68 61 74 20 77 69 6C 6C 20 62 65 20 74 68 65 20 73 75 6D 20 6F 66 20 74 68 65 20 66 6F 6C 6C 6F 77 69 6E 67 20 6E 75 6D 62 65 72 73 7C 6C 65 66 74 7C 0A 61 64 64 5F 74 65 78 74 62 6F 78 7C", true, false, "");
				task.Result.Count<long>();
				foreach (long num in task.Result)
				{
					ParamVisitor.SingletonToken singletonToken = new ParamVisitor.SingletonToken();
					singletonToken.procToken = candidateToken;
					this.long_0 = num;
					singletonToken.m_MapperToken = mem.readString(this.long_0.ToString("x"), "", 75, false);
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Substring(60);
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("|", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("b", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("o", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("x", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace(" ", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("l", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("e", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("f", "");
					singletonToken.m_MapperToken = singletonToken.m_MapperToken.Replace("t", "");
					Console.WriteLine(singletonToken.m_MapperToken);
					if (!list.Contains(singletonToken.m_MapperToken))
					{
						ParamVisitor.WorkerTest workerTest = new ParamVisitor.WorkerTest();
						workerTest.itemTest = singletonToken;
						if (this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].SelectIndexer())
						{
							this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].PrintIndexer(true);
							Thread.Sleep(500);
						}
						if (this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].SortIndexer())
						{
							this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].ConnectIndexer(true);
							Thread.Sleep(500);
						}
						this.string_1 = workerTest.itemTest.m_MapperToken;
						list.Add(workerTest.itemTest.m_MapperToken);
						base.BeginInvoke(new MethodInvoker(workerTest.itemTest.MapDescriptor));
						string[] source = workerTest.itemTest.m_MapperToken.Split(new char[]
						{
							'+'
						});
						if (int.TryParse(source.First<string>(), out workerTest._VisitorTest) & int.TryParse(source.Last<string>(), out workerTest.m_TestsTest))
						{
							int value = workerTest._VisitorTest + workerTest.m_TestsTest;
							Console.WriteLine(value);
							string text = value.ToString();
							text = "\b\b\b\b\b\b\b\b\b" + text;
							string text2 = text;
							int i;
							for (i = 0; i < text2.Length; i++)
							{
								short num2 = ParamVisitor.VkKeyScan(text2[i]);
								int num3 = (int)(num2 & 255);
								bool flag2 = (num2 & 256) > 0;
								bool flag3 = (num2 & 512) > 0;
								bool flag4 = (num2 & 1024) > 0;
								if (flag2)
								{
									ParamVisitor.keybd_event(160, 42, 0, 0);
									Thread.Sleep(50);
								}
								if (flag4 && flag3)
								{
									ParamVisitor.keybd_event(164, 56, 0, 0);
									ParamVisitor.keybd_event(162, 29, 0, 0);
									Thread.Sleep(50);
								}
								ParamVisitor.AwakePage(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, (byte)num3, false);
								Thread.Sleep(50);
								if (flag2)
								{
									ParamVisitor.keybd_event(160, 170, 2, 0);
									Thread.Sleep(50);
								}
								if (flag4 && flag3)
								{
									ParamVisitor.keybd_event(164, 184, 2, 0);
									ParamVisitor.keybd_event(162, 157, 2, 0);
									Thread.Sleep(50);
								}
							}
							Rectangle rectangle;
							ParamVisitor.GetWindowRect(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, out rectangle);
							double num4 = (double)rectangle.Width;
							int height = rectangle.Height;
							i = rectangle.Width;
							if (i <= 1280)
							{
								if (i != 1024)
								{
									if (i != 1280)
									{
									}
								}
							}
							else if (i != 1366)
							{
								if (i != 1536)
								{
									if (i != 1920)
									{
									}
								}
							}
							IL_538:
							num4 = (double)this.int_2;
							int num5 = (int)((double)this.int_3);
							int num6 = (int)num4;
							int num7 = num5;
							IntPtr zero = IntPtr.Zero;
							IntPtr intptr_ = (IntPtr)(num7 << 16 | num6);
							zero = IntPtr.Zero;
							ParamVisitor.SendMessage(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, 513U, zero, intptr_);
							Thread.Sleep(100);
							ParamVisitor.SendMessage(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, 514U, zero, intptr_);
							Thread.Sleep(100);
							ParamVisitor.SendMessage(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, 513U, zero, intptr_);
							Thread.Sleep(100);
							ParamVisitor.SendMessage(workerTest.itemTest.procToken._RoleToken.MainWindowHandle, 514U, zero, intptr_);
							base.BeginInvoke(new MethodInvoker(workerTest.RemoveDescriptor));
							if (this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].SelectIndexer())
							{
								Thread.Sleep(500);
								this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].PrintIndexer(false);
							}
							if (this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].SortIndexer())
							{
								Thread.Sleep(500);
								this.modelVisitor[workerTest.itemTest.procToken._RoleToken.MainWindowTitle].ConnectIndexer(false);
								continue;
							}
							continue;
							goto IL_538;
						}
					}
				}
				if (!includekey)
				{
					flag = false;
				}
				Thread.Sleep(10000);
			}
			base.BeginInvoke(new MethodInvoker(candidateToken.AddDescriptor));
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00018814 File Offset: 0x00016A14
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBox5.Checked)
			{
				this.bool_0 = false;
				return;
			}
			if (this.listBox1.SelectedItem != null)
			{
				this.bool_0 = true;
				new Thread(new ThreadStart(this.InitTest)).Start();
				return;
			}
			MessageBox.Show("Please select a window under 'Attatch to:'");
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003DCE File Offset: 0x00001FCE
		public void InitTest()
		{
			while (this.bool_0)
			{
				base.Invoke(new Action(this.InterruptPage));
				this.UpdateTest(2000);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0001886C File Offset: 0x00016A6C
		protected virtual bool CloneSpecification(FileInfo res)
		{
			bool result;
			try
			{
				using (FileStream fileStream = res.Open(FileMode.Open, FileAccess.Read, FileShare.None))
				{
					fileStream.Close();
				}
				return false;
			}
			catch (IOException)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000188BC File Offset: 0x00016ABC
		private void button26_Click(object sender, EventArgs e)
		{
			if (File.Exists("memory.dll"))
			{
				FileInfo res = new FileInfo("memory.dll");
				if (this.CloneSpecification(res))
				{
					MessageBox.Show("Memory.dll seems to exist but is unaccessable, most likely by anti-virus.");
				}
			}
			else
			{
				MessageBox.Show("Memory.dll doesn't seem to exist. Please download a new version of the application. The DLL might be removed by your anti-virus");
			}
			this.method_12();
			this.bool_1 = true;
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				ParamVisitor.MethodTest methodTest = new ParamVisitor.MethodTest();
				methodTest.m_PageTest = this;
				methodTest._TokenTest = processesByName[i];
				Thread thread = new Thread(new ThreadStart(methodTest.RevertDescriptor));
				thread.Start();
				thread.Priority = ThreadPriority.Lowest;
				Thread.Sleep(250);
			}
			Application.DoEvents();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00003DF9 File Offset: 0x00001FF9
		private void button28_Click(object sender, EventArgs e)
		{
			this.button28.Hide();
			this.button27.Show();
			this.bool_1 = false;
			Application.DoEvents();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_38(object sender, EventArgs e)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000023D9 File Offset: 0x000005D9
		private void GT_version_cmd_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000023D9 File Offset: 0x000005D9
		private void SpamTxt1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003E1D File Offset: 0x0000201D
		private void SpamTxt2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.SpamTxt2.Checked)
			{
				this.SpammerText2.Enabled = true;
				return;
			}
			this.SpammerText2.Enabled = false;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00003E45 File Offset: 0x00002045
		private void SpamTxt3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.SpamTxt3.Checked)
			{
				this.SpammerText3.Enabled = true;
				return;
			}
			this.SpammerText3.Enabled = false;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00003E6D File Offset: 0x0000206D
		private void SpamTxt4_CheckedChanged(object sender, EventArgs e)
		{
			if (this.SpamTxt4.Checked)
			{
				this.SpammerText4.Enabled = true;
				return;
			}
			this.SpammerText4.Enabled = false;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000023D9 File Offset: 0x000005D9
		private void pictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00003E95 File Offset: 0x00002095
		private void button30_Click(object sender, EventArgs e)
		{
			ParamVisitor.dicVisitor = new CallbackItem();
			ParamVisitor.dicVisitor.RegisterIndexer("mouse");
			ParamVisitor.dicVisitor.Show();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00003EBA File Offset: 0x000020BA
		private void method_39(object sender, EventArgs e)
		{
			this.button30.BackColor = Color.Transparent;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003EBA File Offset: 0x000020BA
		private void method_40(object sender, EventArgs e)
		{
			this.button30.BackColor = Color.Transparent;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00003EBA File Offset: 0x000020BA
		private void button30_MouseHover(object sender, EventArgs e)
		{
			this.button30.BackColor = Color.Transparent;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003EBA File Offset: 0x000020BA
		private void button30_MouseLeave(object sender, EventArgs e)
		{
			this.button30.BackColor = Color.Transparent;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00003ECC File Offset: 0x000020CC
		private void button31_Click(object sender, EventArgs e)
		{
			ParamVisitor.dicVisitor = new CallbackItem();
			ParamVisitor.dicVisitor.RegisterIndexer("unbanner");
			ParamVisitor.dicVisitor.Show();
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000023D9 File Offset: 0x000005D9
		private void Windows_box_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000023D9 File Offset: 0x000005D9
		private void ParamVisitor_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00018968 File Offset: 0x00016B68
		private void ParamVisitor_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (DateTime.Now.Minute % 2 == 0)
			{
				try
				{
					if (ParamVisitor.bool_2)
					{
						string text = string.Empty;
						string instance = string.Concat(new string[]
						{
							DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
							"|",
							"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
							"|",
							ParamVisitor.roleVisitor
						});
						string s = string.Concat(new string[]
						{
							"ausdh0asy",
							"8dUASY",
							this.label44.Text,
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
						ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
						byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0xMSZrZXk9");
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
						text.Replace("\n", "");
						if (text.Replace(" ", "").Split(new char[]
						{
							'|'
						})[0].Contains("1"))
						{
							this.label19.Text = ParamVisitor.SetToken("7XOMzliAticAYpnb4sB2Vgn+HU/Tlxb7");
							this.panel3.Enabled = true;
							this.iTalk_HeaderLabel1.Visible = false;
						}
						else
						{
							this.label19.Text = "Account type: Free";
							this.Execute.Enabled = false;
							this.SpamTxt3.Enabled = false;
							this.SpamTxt3.Checked = false;
							this.SpamTxt4.Enabled = false;
							this.SpamTxt4.Checked = false;
							this.checkBox6.Checked = false;
							this.checkBox7.Checked = false;
							this.panel3.Enabled = false;
						}
					}
					else
					{
						this.label19.Text = "Account type: Free";
						this.Execute.Enabled = false;
						this.SpamTxt3.Enabled = false;
						this.SpamTxt3.Checked = false;
						this.SpamTxt4.Enabled = false;
						this.SpamTxt4.Checked = false;
						this.checkBox6.Checked = false;
						this.checkBox7.Checked = false;
						this.panel3.Enabled = false;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000023D9 File Offset: 0x000005D9
		private void ParamVisitor_Move(object sender, EventArgs e)
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000023D9 File Offset: 0x000005D9
		private void ParamVisitor_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003EF1 File Offset: 0x000020F1
		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox7.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003F21 File Offset: 0x00002121
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox6.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00018C98 File Offset: 0x00016E98
		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.trackBar2.Value = 100;
				this._RuleVisitor = 100;
				MessageBox.Show("[Premium users only]");
				return;
			}
			this._RuleVisitor = this.trackBar2.Value;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000023D9 File Offset: 0x000005D9
		private void label20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000023D9 File Offset: 0x000005D9
		private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00018CF0 File Offset: 0x00016EF0
		private void bunifuTileButton1_DragDrop(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			if (data != null)
			{
				string[] array = data as string[];
				if (array.Length != 0)
				{
					this.checkedListBox3.Items.Add(array[0]);
				}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003F51 File Offset: 0x00002151
		private void bunifuTileButton1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.All;
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00018D30 File Offset: 0x00016F30
		private void bunifuTileButton1_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0 = new OpenFileDialog
			{
				FileName = "save.dat",
				Filter = "Data files (*.dat)|*.dat",
				Title = "Select the save.dat",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Appdata\\Local\\Growtopia\\",
				Multiselect = false
			};
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.iTalk_Label2.Text = this.openFileDialog_0.SafeFileName;
				}
				catch (SecurityException ex)
				{
					MessageBox.Show("Security error.\n\nError message: " + ex.Message + "\n\nDetails:\n\n" + ex.StackTrace);
				}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00018DE4 File Offset: 0x00016FE4
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			this.checkedListBox3.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
				{
					this.checkedListBox3.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
				}
				return;
			}
			MessageBox.Show("No accounts available!");
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00018E74 File Offset: 0x00017074
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			if (this.iTalk_Label2.Text == "Select a file")
			{
				MessageBox.Show("Please select a file containing the username and password first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (!Directory.Exists("Accounts"))
			{
				Directory.CreateDirectory("Accounts");
			}
			File.Copy(this.openFileDialog_0.FileName, this.EnablePage(Directory.GetCurrentDirectory() + "\\Accounts\\save (" + this.iTalk_RichTextBox1.Text + ").dat"));
			this.checkedListBox3.Items.Clear();
			for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
			{
				this.checkedListBox3.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
			}
			this.iTalk_Label2.Text = "Select a file";
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00018F68 File Offset: 0x00017168
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.checkedListBox3.CheckedItems)
			{
				File.Delete(Directory.GetCurrentDirectory() + "\\Accounts\\" + ((obj != null) ? obj.ToString() : null));
			}
			this.checkedListBox3.Items.Clear();
			if (Directory.Exists(Directory.GetCurrentDirectory() + "\\Accounts\\"))
			{
				for (int i = 0; i < Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\").Count<string>(); i++)
				{
					this.checkedListBox3.Items.Add(Path.GetFileName(Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Accounts\\")[i]));
				}
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00003F78 File Offset: 0x00002178
		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox8.Checked = false;
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00003F9D File Offset: 0x0000219D
		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBox8.Checked)
			{
				this.checkBox9.Checked = false;
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00019054 File Offset: 0x00017254
		public string EnablePage(string spec)
		{
			string directoryName = Path.GetDirectoryName(spec);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(spec);
			string extension = Path.GetExtension(spec);
			int num = 1;
			while (File.Exists(spec))
			{
				spec = Path.Combine(directoryName, string.Concat(new string[]
				{
					fileNameWithoutExtension,
					" (",
					num.ToString(),
					")",
					extension
				}));
				num++;
			}
			return spec;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00003FB8 File Offset: 0x000021B8
		private void checkBox8_Click(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox8.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000023D9 File Offset: 0x000005D9
		private void no_GT_windows_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003FE8 File Offset: 0x000021E8
		private void bunifuThinButton24_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Information:\r\n>Premium will never expire, you will be a premium user in v1.7, v1.8, v1.9, 2.0, 2.3, 3.0, 6.0...\r\n>Changing PC/components will change your HWID and with a new HWID, the licence won't be valid any longer. Note that no refunds apply.\r\n>I am not resonsible for what you use this tool for\r\n>Support isn't included\r\n>Abusing this service will result in an instant ban from the discord server and also getting your device blacklisted\r\n>For any questions, contact me in discord: RealGoblins#0986\r\n\r\nPrice/payment:\r\n>2 DLS\r\n>Follow then instructions listed when you press \"purchase premium\" from the login screen.\r\n\r\nPremium Features:\r\n>Access to the commands (Pull all, kick all, ban all)\r\n>NoShift for the spammer, without this, the spammer will affect your keyboard (Shift, alt gr etc)\r\n>Two extra text fields for spammer text\r\n>Bot punching speed\r\n>Multi spammer which allows you to have multiple spammers with different texts\r\n>Text Stacking option for the spammer. This will allow you to stack the text\r\n>A high discord rank\r\n>Auto Log In for growtopia with an \"Error connecting\" bypasser\r\n>Save your settings including macros\r\n>Set growtopia priority and affinity - lower CPU usage (approx. 5%)\r\n>All future features\r\n\r\nRequirements:\r\n>Windows 7/10\r\n>Common sense", "Premium features", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003FFD File Offset: 0x000021FD
		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				MessageBox.Show("[Premium users only]");
				return;
			}
			this.SortToken();
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00004028 File Offset: 0x00002228
		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				MessageBox.Show("[Premium users only]");
				return;
			}
			this.ForgotToken();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000190BC File Offset: 0x000172BC
		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Free")
			{
				this.checkBox10.Checked = false;
				MessageBox.Show("[Premium users only]");
			}
			else if (this.checkBox10.Checked)
			{
				Settings.Default.SL = true;
			}
			else
			{
				Settings.Default.SL = false;
			}
			Settings.Default.Save();
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00019128 File Offset: 0x00017328
		private void button33_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.ShowDialog();
			this.textBox3.Text = openFileDialog.FileName;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0001915C File Offset: 0x0001735C
		private void button32_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();
			Process process = new Process();
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.FileName = "Save Decrypter by RealGoblins.exe";
			process.StartInfo.RedirectStandardOutput = true;
			if (this.textBox3.Text != "")
			{
				string str = "-path=" + this.textBox3.Text;
				process.StartInfo.Arguments = "RG " + str;
			}
			else
			{
				process.StartInfo.Arguments = "RG";
			}
			if (!File.Exists(process.StartInfo.FileName))
			{
				MessageBox.Show("The save decrypter plug-in is inaccessable or not found. Please download it before trying again. The file name is Save decrypter by RealGoblins.exe. After downloading it, place it in the same folder as Auto-CCS");
				Process.Start("https://mega.nz/file/tEQUCKSL#2rrRwT2pj5uTrU-i2NoqSjqEb94KBnV6BNK26gGgUf4");
				return;
			}
			process.Start();
			foreach (string text in process.StandardOutput.ReadToEnd().Split(new string[]
			{
				"\r\n",
				"\r",
				"\n"
			}, StringSplitOptions.None))
			{
				if (text != "")
				{
					try
					{
						if (text.ToCharArray().Count(new Func<char, bool>(ParamVisitor.ParserToken.m_RefToken.CalcDescriptor)) > 1)
						{
							string[] array2 = new string[]
							{
								"Mac",
								text
							};
							DataGridViewRowCollection rows = this.dataGridView1.Rows;
							object[] values = array2;
							rows.Add(values);
						}
						else
						{
							string text2 = text.Split(new char[]
							{
								':'
							}).First<string>();
							string text3 = text.Split(new char[]
							{
								':'
							}).Last<string>().Substring(1, text.Split(new char[]
							{
								':'
							}).Last<string>().Length - 1);
							string[] array3 = new string[]
							{
								text2,
								text3
							};
							DataGridViewRowCollection rows2 = this.dataGridView1.Rows;
							object[] values = array3;
							rows2.Add(values);
							if (text2 == "tankid_password")
							{
								this.label29.Text = "Pass: " + text3;
							}
							if (text2 == "tankid_name")
							{
								this.label30.Text = "GrowID: " + text3;
							}
						}
					}
					catch (Exception)
					{
						string[] array4 = new string[]
						{
							text
						};
						DataGridViewRowCollection rows3 = this.dataGridView1.Rows;
						object[] values = array4;
						rows3.Add(values);
					}
				}
			}
			process.WaitForExit();
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000023D9 File Offset: 0x000005D9
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00019408 File Offset: 0x00017608
		private void bunifuThinButton23_Click(object sender, EventArgs e)
		{
			try
			{
				string instance = string.Concat(new string[]
				{
					DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm"),
					"|",
					"59DC-816E-BE7D-8EDC-340E-E11E-5E5A-04E4",
					"|",
					ParamVisitor.roleVisitor
				});
				string s = string.Concat(new string[]
				{
					"ausdh0asy",
					"8dUASY",
					this.label43.Text,
					")/",
					"ASydASDIAS"
				});
				string text = "";
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
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
				byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9yZWFsZ29ibGlucy5kdWNrZG5zLm9yZzozNjgwMC9hcGkucGhwP2NtZD0zJmtleT0=");
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Encoding.UTF8.GetString(bytes) + Worker.InsertList(instance, counter, consumer));
				httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.PublishPage);
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
				string[] array = text.Replace("\n", "").Replace(" ", "").Split(new char[]
				{
					'|'
				});
				Console.WriteLine("Total users: " + array[0]);
				Console.WriteLine("Active users: " + array[1]);
				this.label31.Text = "Total users: " + array[0];
				this.label28.Text = "Active users: " + array[1];
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't establish a connection to the server. Either the server is down, or you don't have any intrnet connection. Using a VPN might solve this issue.");
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00004053 File Offset: 0x00002253
		public bool PublishPage(object key, X509Certificate visitor, X509Chain dir, SslPolicyErrors map2)
		{
			return true;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_41(object sender, EventArgs e)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000023D9 File Offset: 0x000005D9
		private void iTalk_NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001966C File Offset: 0x0001786C
		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.label19.Text == "Account type: Premium")
			{
				switch (this.comboBox4.SelectedIndex)
				{
				case 0:
					for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
					{
						this.checkedListBox4.SetItemCheckState(i, CheckState.Unchecked);
					}
					this.checkedListBox4.SetItemCheckState(this.checkedListBox4.Items.Count - 1, CheckState.Checked);
					this.comboBox3.SelectedIndex = 5;
					break;
				case 1:
					for (int j = 0; j < this.checkedListBox4.Items.Count; j++)
					{
						this.checkedListBox4.SetItemCheckState(j, CheckState.Unchecked);
					}
					for (int k = this.checkedListBox4.Items.Count - 1; k >= this.checkedListBox4.Items.Count / 2; k--)
					{
						this.checkedListBox4.SetItemCheckState(k, CheckState.Checked);
					}
					this.comboBox3.SelectedIndex = 3;
					break;
				case 2:
					for (int l = 0; l < this.checkedListBox4.Items.Count; l++)
					{
						this.checkedListBox4.SetItemCheckState(l, CheckState.Checked);
					}
					this.comboBox3.SelectedIndex = 0;
					break;
				}
			}
			else
			{
				for (int m = 0; m < this.checkedListBox4.Items.Count; m++)
				{
					this.checkedListBox4.SetItemCheckState(m, CheckState.Checked);
				}
				if (this.comboBox4.SelectedIndex != 1)
				{
					this.comboBox4.SelectedIndex = 1;
					MessageBox.Show("[Premium users only]");
				}
			}
			this.bool_7 = false;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00019814 File Offset: 0x00017A14
		private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!(this.label19.Text == "Account type: Premium") && this.checkedListBox4.CheckedItems.Count != this.checkedListBox4.Items.Count)
			{
				for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
				{
					this.checkedListBox4.SetItemCheckState(i, CheckState.Checked);
				}
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00004056 File Offset: 0x00002256
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!(this.label19.Text == "Account type: Premium") && this.comboBox3.SelectedIndex != 3)
			{
				this.comboBox3.SelectedIndex = 3;
				MessageBox.Show("[Premium users only]");
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00019890 File Offset: 0x00017A90
		private void checkedListBox4_MouseClick(object sender, MouseEventArgs e)
		{
			if (!(this.label19.Text == "Account type: Premium"))
			{
				if (this.checkedListBox4.CheckedItems.Count != this.checkedListBox4.Items.Count)
				{
					for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
					{
						this.checkedListBox4.SetItemCheckState(i, CheckState.Checked);
					}
					MessageBox.Show("[Premium users only]");
					return;
				}
				for (int j = 0; j < this.checkedListBox4.Items.Count; j++)
				{
					this.checkedListBox4.SetItemCheckState(j, CheckState.Checked);
				}
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000023D9 File Offset: 0x000005D9
		private void checkedListBox4_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000023D9 File Offset: 0x000005D9
		private void checkedListBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00019934 File Offset: 0x00017B34
		private void checkedListBox4_MouseUp(object sender, MouseEventArgs e)
		{
			if (!(this.label19.Text == "Account type: Premium"))
			{
				if (this.checkedListBox4.CheckedItems.Count != this.checkedListBox4.Items.Count)
				{
					for (int i = 0; i < this.checkedListBox4.Items.Count; i++)
					{
						this.checkedListBox4.SetItemCheckState(i, CheckState.Checked);
					}
					MessageBox.Show("[Premium users only]");
					return;
				}
				for (int j = 0; j < this.checkedListBox4.Items.Count; j++)
				{
					this.checkedListBox4.SetItemCheckState(j, CheckState.Checked);
				}
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000199D8 File Offset: 0x00017BD8
		private void button34_Click(object sender, EventArgs e)
		{
			this.m_ProcVisitor = "";
			this._PoolVisitor.Add(new DispatcherVisitor());
			this._PoolVisitor.Last<DispatcherVisitor>()._IssuerVisitor = false;
			this._PoolVisitor.Last<DispatcherVisitor>().m_PublisherVisitor = this.bunifuCheckbox1.Checked;
			foreach (string item in this.textBox4.Text.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None))
			{
				this._PoolVisitor.Last<DispatcherVisitor>()._ParamsVisitor.Add(item);
			}
			this._PoolVisitor.Last<DispatcherVisitor>().m_AdvisorVisitor = this.bunifuCheckbox2.Checked;
			this._PoolVisitor.Last<DispatcherVisitor>()._UtilsVisitor = (int)this.numericUpDown8.Value * 1000;
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				foreach (object obj in this.checkedListBox5.CheckedItems)
				{
					string b = (string)obj;
					if (process.MainWindowTitle == b)
					{
						this._PoolVisitor.Last<DispatcherVisitor>().tagVisitor.Add(process.Id);
					}
				}
			}
			if (this._PoolVisitor.Last<DispatcherVisitor>()._ParamsVisitor.First<string>().Length > 20)
			{
				this.m_ProcVisitor = this.m_ProcVisitor + this._PoolVisitor.Last<DispatcherVisitor>()._ParamsVisitor.First<string>().Substring(0, 17) + Class18.smethod_11(12974);
			}
			else
			{
				this.m_ProcVisitor += this._PoolVisitor.Last<DispatcherVisitor>()._ParamsVisitor.First<string>();
			}
			this.m_ProcVisitor = "[DISABLED] " + this.m_ProcVisitor;
			this.listBox2.Items.Add(this.m_ProcVisitor);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00019BFC File Offset: 0x00017DFC
		private void button35_Click(object sender, EventArgs e)
		{
			if (this.listBox2.SelectedItem != null)
			{
				this._PoolVisitor[this.listBox2.SelectedIndex]._IssuerVisitor = false;
				this._PoolVisitor.RemoveAt(this.listBox2.SelectedIndex);
				this.listBox2.Items.RemoveAt(this.listBox2.SelectedIndex);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00019C64 File Offset: 0x00017E64
		private void button37_Click(object sender, EventArgs e)
		{
			if (this.listBox2.SelectedItem != null)
			{
				if (this.listBox2.SelectedItem.ToString().StartsWith("[DISABLED]"))
				{
					this._PoolVisitor[this.listBox2.SelectedIndex]._IssuerVisitor = true;
					new Thread(new ThreadStart(this._PoolVisitor[this.listBox2.SelectedIndex].FillMethod)).Start();
					this.listBox2.Items[this.listBox2.SelectedIndex] = this.listBox2.SelectedItem.ToString().Replace("[DISABLED]", "[ENABLED]");
					return;
				}
				this._PoolVisitor[this.listBox2.SelectedIndex]._IssuerVisitor = false;
				this.listBox2.Items[this.listBox2.SelectedIndex] = this.listBox2.SelectedItem.ToString().Replace("[ENABLED]", "[DISABLED]");
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000023D9 File Offset: 0x000005D9
		private void checkedListBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00019D78 File Offset: 0x00017F78
		private void iTalk_TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.checkedListBox5.Items.Clear();
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				this.checkedListBox5.Items.Add(process.MainWindowTitle);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00019DCC File Offset: 0x00017FCC
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<string> list = new List<string>();
			List<int> list2 = new List<int>();
			if (this.listBox2.SelectedItem == null)
			{
				return;
			}
			int selectedIndex = this.listBox2.SelectedIndex;
			this.textBox4.Text = "";
			int num = 0;
			foreach (string text in this._PoolVisitor[selectedIndex]._ParamsVisitor)
			{
				if (num == 0)
				{
					TextBox textBox = this.textBox4;
					textBox.Text += text;
				}
				else
				{
					TextBox textBox2 = this.textBox4;
					textBox2.Text = textBox2.Text + "\r\n" + text;
				}
				num++;
			}
			for (int i = 0; i < this.checkedListBox5.Items.Count; i++)
			{
				this.checkedListBox5.SetItemChecked(i, false);
			}
			foreach (Process process in Process.GetProcessesByName("Growtopia"))
			{
				list.Add(process.MainWindowTitle);
				list2.Add(process.Id);
			}
			foreach (int item in this._PoolVisitor[selectedIndex].tagVisitor)
			{
				if (list2.Contains(item))
				{
					string b = list[list2.IndexOf(item)];
					for (int k = 0; k < this.checkedListBox5.Items.Count; k++)
					{
						if (this.checkedListBox5.Items[k].ToString() == b)
						{
							this.checkedListBox5.SetItemChecked(k, true);
						}
					}
				}
			}
			this.numericUpDown8.Value = this._PoolVisitor[selectedIndex]._UtilsVisitor / 1000;
			this.bunifuCheckbox1.Checked = this._PoolVisitor[selectedIndex].m_PublisherVisitor;
			this.bunifuCheckbox2.Checked = this._PoolVisitor[selectedIndex].m_AdvisorVisitor;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001A01C File Offset: 0x0001821C
		private void button27_Click(object sender, EventArgs e)
		{
			this.button27.Hide();
			this.button28.Show();
			if (File.Exists("memory.dll"))
			{
				FileInfo res = new FileInfo("memory.dll");
				if (this.CloneSpecification(res))
				{
					MessageBox.Show("Memory.dll seems to exist but is unaccessable, most likely by anti-virus.");
				}
			}
			else
			{
				MessageBox.Show("Memory.dll doesn't seem to exist. Please download a new version of the application. The DLL might be removed by your anti-virus");
			}
			this.bool_1 = true;
			this.method_12();
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				ParamVisitor.IndexerTest indexerTest = new ParamVisitor.IndexerTest();
				indexerTest.m_AttrTest = this;
				indexerTest.descriptorTest = processesByName[i];
				new Thread(new ThreadStart(indexerTest.InsertAttr))
				{
					Priority = ThreadPriority.Lowest
				}.Start();
				Thread.Sleep(250);
			}
			Application.DoEvents();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00004094 File Offset: 0x00002294
		private void button29_Click(object sender, EventArgs e)
		{
			this.int_5 = 3;
			this.dic_2.MoveWorker();
			MessageBox.Show("Put the window in foreground, hover the cursor over the Submit button and press Space");
			Application.DoEvents();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001A0E0 File Offset: 0x000182E0
		public IntPtr IncludePage(Process spec, byte[] cfg)
		{
			ProcessModule mainModule = spec.MainModule;
			long num = (long)mainModule.BaseAddress;
			long num2 = (long)mainModule.ModuleMemorySize;
			for (long num3 = 0L; num3 < num2; num3 += 1L)
			{
				byte[] array = new byte[cfg.Length];
				ParamVisitor.ReadProcessMemory(spec.Handle, (IntPtr)(num + num3), array, cfg.Length, 0);
				if (this.NewPage(array, cfg))
				{
					return (IntPtr)(num + num3);
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001A15C File Offset: 0x0001835C
		public bool NewPage(byte[] setup, byte[] connection)
		{
			if (setup.Length != connection.Length)
			{
				return false;
			}
			if (setup == connection)
			{
				return true;
			}
			for (int i = 0; i < setup.Length; i++)
			{
				if (setup[i] != connection[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001A194 File Offset: 0x00018394
		private void method_42(ParamVisitor.Class12.ExceptionTest exceptionTest_0)
		{
			IntPtr intPtr;
			if (!ParamVisitor.DuplicateHandle(Process.GetProcessById(exceptionTest_0._ProcessTest).Handle, exceptionTest_0.collectionTest, IntPtr.Zero, out intPtr, 0U, false, 1U))
			{
				MessageBox.Show("Failed to close mutex: " + Marshal.GetLastWin32Error().ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			Console.WriteLine("Mutex was killed");
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001A1F8 File Offset: 0x000183F8
		public static bool DisablePage(string param)
		{
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				if (processesByName[i].MainWindowTitle == param)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001A234 File Offset: 0x00018434
		public static int PatchPage()
		{
			int num = 0;
			Process[] processesByName = Process.GetProcessesByName("Growtopia");
			for (int i = 0; i < processesByName.Length; i++)
			{
				num++;
			}
			return num;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001A264 File Offset: 0x00018464
		public static void AwakePage(IntPtr key, byte start_pol, bool excludetemp)
		{
			uint num = ParamVisitor.MapVirtualKey((uint)start_pol, 0U);
			uint num2 = 1U | num << 16;
			if (excludetemp)
			{
				num2 |= 16777216U;
			}
			ParamVisitor.PostMessageA(key, 256U, (int)start_pol, (int)num2);
			num2 |= 3221225472U;
			ParamVisitor.PostMessageA(key, 257U, (int)start_pol, (int)num2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001A2B0 File Offset: 0x000184B0
		private List<string> method_43(ProccesorItem proccesorItem_0, int int_6)
		{
			Process process = null;
			int num = 100;
			List<string> list = new List<string>();
			foreach (Process process2 in Process.GetProcessesByName("Growtopia"))
			{
				if (proccesorItem_0.InsertIndexer() == process2.MainWindowTitle)
				{
					IntPtr mainWindowHandle = process2.MainWindowHandle;
					process = process2;
					IL_4F:
					byte[] bytes = Convert.FromBase64String("aHR0cHM6Ly9wYXN0ZWJpbi5jb20vcmF3L0oxNEV1c1ZB");
					string @string = Encoding.UTF8.GetString(bytes);
					string[] array = this.ListToken(@string).Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.None);
					if (process != null)
					{
						IntPtr value = ParamVisitor.OpenProcess_1(16U, false, process.Id);
						IntPtr intPtr = process.MainModule.BaseAddress;
						if (int_6 == 0)
						{
							intPtr += 4253488;
						}
						if (int_6 == 1)
						{
							intPtr += 5328072;
							int[] util = new int[]
							{
								64,
								280,
								32,
								32,
								0
							};
							intPtr = ParamVisitor.ManagePage((int)value, intPtr, util) + 5672 - 3048;
						}
						if (int_6 == 2)
						{
							intPtr += 5406608;
						}
						if (int_6 == 3)
						{
							intPtr += 5542224;
						}
						if (int_6 == 4)
						{
							int.Parse(array[1], NumberStyles.HexNumber);
							intPtr += int.Parse(array[1], NumberStyles.HexNumber);
						}
						for (int j = 0; j < num + 1; j++)
						{
							int[] array2 = null;
							if (int_6 == 0)
							{
								array2 = new int[j + 5];
								array2[0] = 2832;
								array2[1] = 360;
								array2[2] = 0;
								for (int k = 0; k < j; k++)
								{
									array2[k + 3] = 0;
								}
								array2[j + 3] = 16;
								array2[j + 4] = 0;
							}
							if (int_6 == 1)
							{
								array2 = new int[j + 5];
								array2[0] = 544;
								array2[1] = 360;
								array2[2] = 0;
								for (int l = 0; l < j; l++)
								{
									array2[l + 3] = 0;
								}
								array2[j + 3] = 16;
								array2[j + 4] = 0;
							}
							if (int_6 == 2)
							{
								array2 = new int[j + 9];
								array2[0] = 64;
								array2[1] = 280;
								array2[2] = 32;
								array2[3] = 32;
								array2[4] = 760;
								array2[5] = 376;
								array2[6] = 0;
								for (int m = 0; m < j; m++)
								{
									array2[m + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							if (int_6 == 3)
							{
								array2 = new int[j + 9];
								array2[0] = 64;
								array2[1] = 280;
								array2[2] = 32;
								array2[3] = 32;
								array2[4] = 760;
								array2[5] = 360;
								array2[6] = 0;
								for (int n = 0; n < j; n++)
								{
									array2[n + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							if (int_6 == 4)
							{
								array2 = new int[j + 9];
								array2[0] = int.Parse(array[2], NumberStyles.HexNumber);
								array2[1] = int.Parse(array[3], NumberStyles.HexNumber);
								array2[2] = int.Parse(array[4], NumberStyles.HexNumber);
								array2[3] = int.Parse(array[5], NumberStyles.HexNumber);
								array2[4] = int.Parse(array[6], NumberStyles.HexNumber);
								array2[5] = int.Parse(array[7], NumberStyles.HexNumber);
								array2[6] = int.Parse(array[8], NumberStyles.HexNumber);
								for (int num2 = 0; num2 < j; num2++)
								{
									array2[num2 + 7] = 0;
								}
								array2[j + 7] = 16;
								array2[j + 8] = 0;
							}
							IntPtr intPtr2 = ParamVisitor.ManagePage((int)value, intPtr, array2);
							if (intPtr2 == IntPtr.Zero)
							{
								break;
							}
							IntPtr intPtr3 = intPtr2 + 40;
							int[] util2 = new int[]
							{
								0
							};
							IntPtr intptr_ = ParamVisitor.ManagePage((int)value, intPtr3, util2);
							string text;
							if (this.method_45((int)value, intptr_) == 0)
							{
								text = this.method_44((int)value, intPtr3);
								if (!text.StartsWith("`"))
								{
									break;
								}
							}
							else
							{
								text = this.method_44((int)value, intptr_);
								if (!text.StartsWith("`"))
								{
									break;
								}
							}
							text = text.Replace("`", "");
							text = text.Substring(1, text.Length - 1);
							list.Add(text);
						}
					}
					return list;
				}
			}
			goto IL_4F;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001A72C File Offset: 0x0001892C
		private string method_44(int int_6, IntPtr intptr_0)
		{
			int num = 0;
			byte[] array = new byte[40];
			ParamVisitor.ReadProcessMemory_1(int_6, intptr_0, array, array.Length, ref num);
			int count = array.Length;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == 0)
				{
					count = i;
					IL_35:
					return Encoding.Default.GetString(array, 0, count);
				}
			}
			goto IL_35;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001A77C File Offset: 0x0001897C
		public static IntPtr ManagePage(int indexOf_config, IntPtr map, int[] util)
		{
			int num = 0;
			byte[] array = new byte[IntPtr.Size];
			foreach (int offset in util)
			{
				if (ParamVisitor.ReadProcessMemory_1(indexOf_config, map, array, array.Length, ref num))
				{
					map = ((IntPtr.Size == 4) ? IntPtr.Add(new IntPtr(BitConverter.ToInt32(array, 0)), offset) : (map = IntPtr.Add(new IntPtr(BitConverter.ToInt64(array, 0)), offset)));
				}
			}
			return map;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001A7F0 File Offset: 0x000189F0
		private int method_45(int int_6, IntPtr intptr_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			ParamVisitor.ReadProcessMemory_1(int_6, intptr_0, array, array.Length, ref num);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x060003AC RID: 940
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = false)]
		private static extern uint LoadKeyboardLayout(StringBuilder stringBuilder_0, uint uint_0);

		// Token: 0x060003AD RID: 941
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = false)]
		private static extern uint GetKeyboardLayout(uint uint_0);

		// Token: 0x060003AE RID: 942
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true, ThrowOnUnmappableChar = false)]
		private static extern uint ActivateKeyboardLayout(uint uint_0, uint uint_1);

		// Token: 0x060003B1 RID: 945 RVA: 0x000040B8 File Offset: 0x000022B8
		// Note: this type is marked as 'beforefieldinit'.
		static ParamVisitor()
		{
			Class21.smethod_0();
			ParamVisitor.timer_0 = new Timer();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000040C9 File Offset: 0x000022C9
		[CompilerGenerated]
		private void SearchPage()
		{
			this.label19.Text = ParamVisitor.SetToken("7XOMzliAticAYpnb4sB2Vgn+HU/Tlxb7");
			this.panel3.Enabled = true;
			this.iTalk_HeaderLabel1.Visible = false;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00025408 File Offset: 0x00023608
		[CompilerGenerated]
		private void CreatePage()
		{
			this.label19.Text = "Account type: Free";
			this.Execute.Enabled = false;
			this.SpamTxt3.Enabled = false;
			this.SpamTxt3.Checked = false;
			this.SpamTxt4.Enabled = false;
			this.SpamTxt4.Checked = false;
			this.checkBox6.Checked = false;
			this.checkBox7.Checked = false;
			this.panel3.Enabled = false;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00025488 File Offset: 0x00023688
		[CompilerGenerated]
		private void CalcPage()
		{
			this.label19.Text = "Account type: Free";
			this.Execute.Enabled = false;
			this.SpamTxt3.Enabled = false;
			this.SpamTxt3.Checked = false;
			this.SpamTxt4.Enabled = false;
			this.SpamTxt4.Checked = false;
			this.checkBox6.Checked = false;
			this.checkBox7.Checked = false;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00025488 File Offset: 0x00023688
		[CompilerGenerated]
		private void CheckPage()
		{
			this.label19.Text = "Account type: Free";
			this.Execute.Enabled = false;
			this.SpamTxt3.Enabled = false;
			this.SpamTxt3.Checked = false;
			this.SpamTxt4.Enabled = false;
			this.SpamTxt4.Checked = false;
			this.checkBox6.Checked = false;
			this.checkBox7.Checked = false;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000040F8 File Offset: 0x000022F8
		[CompilerGenerated]
		private void GetPage()
		{
			this.method_15();
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000040F8 File Offset: 0x000022F8
		[CompilerGenerated]
		private void ComputePage()
		{
			this.method_15();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00004100 File Offset: 0x00002300
		[CompilerGenerated]
		private void RatePage()
		{
			this.m_QueueTests.Items.Add("Connection succeded!");
			this.m_QueueTests.Items.Add(" ");
			Application.DoEvents();
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000254FC File Offset: 0x000236FC
		[CompilerGenerated]
		private void InterruptPage()
		{
			int topIndex = this.checkedListBox2.TopIndex;
			this.label10.Text = "GT:" + this.listBox1.Text;
			this.mockVisitor.Clear();
			for (int i = 0; i < this.checkedListBox2.Items.Count; i++)
			{
				this.mockVisitor.Add(this.checkedListBox2.Items[i].ToString(), new InfoItem(this.checkedListBox2.Items[i].ToString(), this.checkedListBox2.GetItemCheckState(i)));
			}
			List<string> list = this.method_43(this.modelVisitor[this.listBox1.Text], this.GT_version_cmd.SelectedIndex);
			this.checkedListBox2.Items.Clear();
			for (int j = 0; j < list.Count; j++)
			{
				if (this.checkBox3.Checked)
				{
					this.checkedListBox2.Items.Add(list[j], this.checkBox3.Checked);
					this.checkedListBox2.TopIndex = topIndex;
				}
				else if (this.mockVisitor.ContainsKey(list[j]))
				{
					this.checkedListBox2.Items.Add(list[j], this.mockVisitor[list[j]].SetIndexer());
					this.checkedListBox2.TopIndex = topIndex;
				}
				else
				{
					this.checkedListBox2.Items.Add(list[j]);
					this.checkedListBox2.TopIndex = topIndex;
				}
			}
			this.checkBox3.Text = "Select all (" + this.checkedListBox2.Items.Count.ToString() + ")";
			this.checkedListBox2.TopIndex = topIndex;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00004133 File Offset: 0x00002333
		[DebuggerHidden]
		[CompilerGenerated]
		private void AddPage(bool iskey)
		{
			base.Dispose(iskey);
		}

		// Token: 0x0400013A RID: 314
		public object _ReponseVisitor;

		// Token: 0x0400013B RID: 315
		private List<Process> list_0;

		// Token: 0x0400013C RID: 316
		private string string_0;

		// Token: 0x0400013D RID: 317
		public Image composerVisitor;

		// Token: 0x0400013E RID: 318
		public RasConnection watcherVisitor;

		// Token: 0x0400013F RID: 319
		public RasDialer m_RequestVisitor;

		// Token: 0x04000140 RID: 320
		public Thread _BroadcasterVisitor;

		// Token: 0x04000141 RID: 321
		public Thread serverVisitor;

		// Token: 0x04000142 RID: 322
		public object threadVisitor;

		// Token: 0x04000143 RID: 323
		public Thread propertyVisitor;

		// Token: 0x04000144 RID: 324
		private bool bool_0;

		// Token: 0x04000145 RID: 325
		private long long_0;

		// Token: 0x04000146 RID: 326
		private string string_1;

		// Token: 0x04000147 RID: 327
		private bool bool_1;

		// Token: 0x04000148 RID: 328
		public static CallbackItem dicVisitor;

		// Token: 0x04000149 RID: 329
		public static object _FilterVisitor;

		// Token: 0x0400014A RID: 330
		private static bool bool_2;

		// Token: 0x0400014B RID: 331
		private static string string_2;

		// Token: 0x0400014C RID: 332
		public int _RuleVisitor;

		// Token: 0x0400014D RID: 333
		public List<DispatcherVisitor> _PoolVisitor;

		// Token: 0x0400014E RID: 334
		public SortedList<string, ProccesorItem> modelVisitor;

		// Token: 0x0400014F RID: 335
		public SortedList<string, InvocationItem> _MappingVisitor;

		// Token: 0x04000150 RID: 336
		public SortedList<string, InfoItem> mockVisitor;

		// Token: 0x04000151 RID: 337
		private string[] string_3;

		// Token: 0x04000152 RID: 338
		private static Timer timer_0;

		// Token: 0x04000153 RID: 339
		private Dic dic_0;

		// Token: 0x04000154 RID: 340
		private Dic dic_1;

		// Token: 0x04000155 RID: 341
		private Dic dic_2;

		// Token: 0x04000156 RID: 342
		private Dic dic_3;

		// Token: 0x04000157 RID: 343
		private Process[] process_0;

		// Token: 0x04000158 RID: 344
		private Rectangle rectangle_0;

		// Token: 0x04000159 RID: 345
		private Rectangle rectangle_1;

		// Token: 0x0400015A RID: 346
		private Rectangle rectangle_2;

		// Token: 0x0400015B RID: 347
		private Rectangle rectangle_3;

		// Token: 0x0400015C RID: 348
		private Rectangle rectangle_4;

		// Token: 0x0400015D RID: 349
		private bool bool_3;

		// Token: 0x0400015E RID: 350
		private int int_0;

		// Token: 0x0400015F RID: 351
		private int int_1;

		// Token: 0x04000160 RID: 352
		private int int_2;

		// Token: 0x04000161 RID: 353
		private int int_3;

		// Token: 0x04000162 RID: 354
		private Form form_0;

		// Token: 0x04000163 RID: 355
		private int int_4;

		// Token: 0x04000164 RID: 356
		private int int_5;

		// Token: 0x04000165 RID: 357
		private bool bool_4;

		// Token: 0x04000166 RID: 358
		private bool bool_5;

		// Token: 0x04000167 RID: 359
		private bool bool_6;

		// Token: 0x04000168 RID: 360
		public float m_ProducerVisitor;

		// Token: 0x04000169 RID: 361
		public static string roleVisitor;

		// Token: 0x0400016A RID: 362
		private static string string_4;

		// Token: 0x0400016B RID: 363
		private bool bool_7;

		// Token: 0x0400016C RID: 364
		public string m_ProcVisitor;

		// Token: 0x02000058 RID: 88
		private struct Struct1
		{
			// Token: 0x04000249 RID: 585
			public int int_0;

			// Token: 0x0400024A RID: 586
			public int int_1;

			// Token: 0x0400024B RID: 587
			public int int_2;

			// Token: 0x0400024C RID: 588
			public int int_3;
		}

		// Token: 0x02000059 RID: 89
		private struct Struct2
		{
			// Token: 0x0400024D RID: 589
			public uint uint_0;

			// Token: 0x0400024E RID: 590
			public IntPtr intptr_0;

			// Token: 0x0400024F RID: 591
			public uint uint_1;

			// Token: 0x04000250 RID: 592
			public uint uint_2;

			// Token: 0x04000251 RID: 593
			public uint uint_3;
		}

		// Token: 0x0200005A RID: 90
		private class Class12
		{
			// Token: 0x060003BB RID: 955 RVA: 0x00002354 File Offset: 0x00000554
			public Class12()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x0200005B RID: 91
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct ExceptionTest
			{
				// Token: 0x04000252 RID: 594
				public int _ProcessTest;

				// Token: 0x04000253 RID: 595
				public byte _ImporterTest;

				// Token: 0x04000254 RID: 596
				public byte m_TaskTest;

				// Token: 0x04000255 RID: 597
				public ushort collectionTest;

				// Token: 0x04000256 RID: 598
				public int authenticationTest;

				// Token: 0x04000257 RID: 599
				public uint _StatusTest;
			}

			// Token: 0x0200005C RID: 92
			public struct ConfigurationTest
			{
				// Token: 0x04000258 RID: 600
				public int resolverTest;

				// Token: 0x04000259 RID: 601
				public int _StructTest;

				// Token: 0x0400025A RID: 602
				public int _ConnectionTest;

				// Token: 0x0400025B RID: 603
				public int m_GlobalTest;

				// Token: 0x0400025C RID: 604
				public int m_AlgoTest;

				// Token: 0x0400025D RID: 605
				public int m_CustomerTest;

				// Token: 0x0400025E RID: 606
				public int _RecordTest;

				// Token: 0x0400025F RID: 607
				public int comparatorTest;

				// Token: 0x04000260 RID: 608
				public int _InterpreterTest;

				// Token: 0x04000261 RID: 609
				public int m_FacadeTest;

				// Token: 0x04000262 RID: 610
				public int _AccountTest;

				// Token: 0x04000263 RID: 611
				public int m_WrapperTest;

				// Token: 0x04000264 RID: 612
				public FILETIME _SetterTest;
			}

			// Token: 0x0200005D RID: 93
			public struct ExpressionTest
			{
				// Token: 0x04000265 RID: 613
				public ParamVisitor.Class12.SerializerTest m_SystemTest;
			}

			// Token: 0x0200005E RID: 94
			[StructLayout(LayoutKind.Sequential, Pack = 1)]
			public struct SerializerTest
			{
				// Token: 0x04000266 RID: 614
				public ushort _MessageTest;

				// Token: 0x04000267 RID: 615
				public ushort m_ValTest;

				// Token: 0x04000268 RID: 616
				public IntPtr m_FactoryTest;
			}
		}

		// Token: 0x0200005F RID: 95
		public enum NameOptions
		{

		}

		// Token: 0x02000060 RID: 96
		[Flags]
		public enum ConstKind : uint
		{

		}

		// Token: 0x02000061 RID: 97
		private static class Class13
		{
		}

		// Token: 0x02000062 RID: 98
		internal sealed class Class14
		{
			// Token: 0x060003BC RID: 956 RVA: 0x00002354 File Offset: 0x00000554
			public Class14()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003BD RID: 957 RVA: 0x000256E4 File Offset: 0x000238E4
			private Class14(CultureInfo spec)
			{
				Class21.smethod_0();
				base..ctor();
				StringBuilder stringBuilder_ = new StringBuilder(spec.LCID.ToString("x8"));
				this.uint_0 = ParamVisitor.LoadKeyboardLayout(stringBuilder_, 1U);
			}

			// Token: 0x060003BE RID: 958 RVA: 0x0000413C File Offset: 0x0000233C
			private Class14(uint no__setup)
			{
				Class21.smethod_0();
				base..ctor();
				this.uint_0 = no__setup;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00004150 File Offset: 0x00002350
			public uint method_0()
			{
				return this.uint_0;
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00004158 File Offset: 0x00002358
			public ParamVisitor.Class14 method_1()
			{
				return new ParamVisitor.Class14(ParamVisitor.GetKeyboardLayout((uint)Thread.CurrentThread.ManagedThreadId));
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000416E File Offset: 0x0000236E
			public ParamVisitor.Class14 method_2(CultureInfo cultureInfo_0)
			{
				return new ParamVisitor.Class14(cultureInfo_0);
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00004176 File Offset: 0x00002376
			public void method_3()
			{
				ParamVisitor.ActivateKeyboardLayout(this.uint_0, 256U);
			}

			// Token: 0x0400026B RID: 619
			public readonly uint uint_0;
		}

		// Token: 0x02000063 RID: 99
		[CompilerGenerated]
		private sealed class AnnotationToken
		{
			// Token: 0x060003C3 RID: 963 RVA: 0x00002354 File Offset: 0x00000554
			public AnnotationToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00004189 File Offset: 0x00002389
			internal void CalculateDescriptor()
			{
				this._DicToken.method_13(this._DicToken.modelVisitor[this._DicToken.Windows.Items[this.m_FilterToken].ToString()]);
			}

			// Token: 0x0400026C RID: 620
			public ParamVisitor _DicToken;

			// Token: 0x0400026D RID: 621
			public int m_FilterToken;

			// Token: 0x0400026E RID: 622
			public ThreadStart _ServiceToken;
		}

		// Token: 0x02000064 RID: 100
		[CompilerGenerated]
		private sealed class ProccesorToken
		{
			// Token: 0x060003C5 RID: 965 RVA: 0x00002354 File Offset: 0x00000554
			public ProccesorToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x000041C6 File Offset: 0x000023C6
			internal void CloneDescriptor()
			{
				this.m_RuleToken.method_14(this.m_RuleToken.modelVisitor[this.m_RuleToken.ProcessesSpam.Items[this.m_PoolToken].ToString()]);
			}

			// Token: 0x0400026F RID: 623
			public ParamVisitor m_RuleToken;

			// Token: 0x04000270 RID: 624
			public int m_PoolToken;

			// Token: 0x04000271 RID: 625
			public ThreadStart modelToken;
		}

		// Token: 0x02000065 RID: 101
		[CompilerGenerated]
		private sealed class MappingToken
		{
			// Token: 0x060003C7 RID: 967 RVA: 0x00002354 File Offset: 0x00000554
			public MappingToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00004203 File Offset: 0x00002403
			internal void InitDescriptor(object sender, EventArgs e)
			{
				this.m_MockToken.Enabled = false;
				this.m_MockToken.Stop();
			}

			// Token: 0x04000272 RID: 626
			public Timer m_MockToken;
		}

		// Token: 0x02000066 RID: 102
		[CompilerGenerated]
		private sealed class WriterToken
		{
			// Token: 0x060003C9 RID: 969 RVA: 0x00002354 File Offset: 0x00000554
			public WriterToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000421C File Offset: 0x0000241C
			internal void CompareDescriptor(object sender, EventArgs e)
			{
				this.infoToken.Enabled = false;
				this.infoToken.Stop();
			}

			// Token: 0x04000273 RID: 627
			public Timer infoToken;
		}

		// Token: 0x02000067 RID: 103
		[CompilerGenerated]
		[Serializable]
		private sealed class ParserToken
		{
			// Token: 0x060003CB RID: 971 RVA: 0x00004235 File Offset: 0x00002435
			// Note: this type is marked as 'beforefieldinit'.
			static ParserToken()
			{
				Class21.smethod_0();
				ParamVisitor.ParserToken.m_RefToken = new ParamVisitor.ParserToken();
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00002354 File Offset: 0x00000554
			public ParserToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00004246 File Offset: 0x00002446
			internal bool SearchDescriptor(NetworkInterface value)
			{
				return Client.CheckWorker(value.GetPhysicalAddress().GetAddressBytes(), true);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00002764 File Offset: 0x00000964
			internal long CreateDescriptor(NetworkInterface asset)
			{
				return asset.Speed;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00004259 File Offset: 0x00002459
			internal bool CalcDescriptor(char reference)
			{
				return reference == ':';
			}

			// Token: 0x04000274 RID: 628
			public static readonly ParamVisitor.ParserToken m_RefToken;

			// Token: 0x04000275 RID: 629
			public static Func<NetworkInterface, bool> _InvocationToken;

			// Token: 0x04000276 RID: 630
			public static Func<NetworkInterface, long> m_ClassToken;

			// Token: 0x04000277 RID: 631
			public static Func<char, bool> helperToken;
		}

		// Token: 0x02000068 RID: 104
		[CompilerGenerated]
		private static class CreatorToken
		{
			// Token: 0x04000278 RID: 632
			public static CallSite<Func<CallSite, object, string>> _ClientToken;

			// Token: 0x04000279 RID: 633
			public static CallSite<Func<CallSite, object, IWshShortcut>> prototypeToken;
		}

		// Token: 0x02000069 RID: 105
		[CompilerGenerated]
		private sealed class CallbackToken
		{
			// Token: 0x060003D0 RID: 976 RVA: 0x00002354 File Offset: 0x00000554
			public CallbackToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00025724 File Offset: 0x00023924
			internal void CheckDescriptor()
			{
				string item = string.Format("State: {0}", this.decoratorToken.State);
				Application.DoEvents();
				this._RulesToken.m_QueueTests.Items.Add(item);
				this._RulesToken.m_QueueTests.Refresh();
				Application.DoEvents();
			}

			// Token: 0x0400027A RID: 634
			public StateChangedEventArgs decoratorToken;

			// Token: 0x0400027B RID: 635
			public ParamVisitor _RulesToken;
		}

		// Token: 0x0200006A RID: 106
		[CompilerGenerated]
		private sealed class DatabaseToken
		{
			// Token: 0x060003D2 RID: 978 RVA: 0x00002354 File Offset: 0x00000554
			public DatabaseToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00004260 File Offset: 0x00002460
			internal void GetDescriptor()
			{
				this.m_StubToken.m_QueueTests.Items.Add(string.Format("Error: {0}", this.m_InterceptorToken.GetException()));
				Application.DoEvents();
			}

			// Token: 0x0400027C RID: 636
			public ParamVisitor m_StubToken;

			// Token: 0x0400027D RID: 637
			public ErrorEventArgs m_InterceptorToken;
		}

		// Token: 0x0200006B RID: 107
		[CompilerGenerated]
		private sealed class StrategyToken
		{
			// Token: 0x060003D4 RID: 980 RVA: 0x00002354 File Offset: 0x00000554
			public StrategyToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x00004292 File Offset: 0x00002492
			internal void ComputeDescriptor()
			{
				this._IteratorToken.method_35(this.eventToken, "vpn", "vpn");
			}

			// Token: 0x0400027E RID: 638
			public ParamVisitor _IteratorToken;

			// Token: 0x0400027F RID: 639
			public string eventToken;
		}

		// Token: 0x0200006C RID: 108
		[CompilerGenerated]
		private sealed class ObserverToken
		{
			// Token: 0x060003D6 RID: 982 RVA: 0x00002354 File Offset: 0x00000554
			public ObserverToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00025780 File Offset: 0x00023980
			internal void RateDescriptor()
			{
				this.m_RegistryToken.m_QueueTests.Items.Add("Connection failed!");
				this.m_RegistryToken.m_QueueTests.Items.Add(this.readerToken);
				this.m_RegistryToken.m_QueueTests.Items.Add(" ");
				this.m_RegistryToken.comboBox2.Enabled = true;
				this.m_RegistryToken.button22.Enabled = true;
				Application.DoEvents();
			}

			// Token: 0x04000280 RID: 640
			public Exception readerToken;

			// Token: 0x04000281 RID: 641
			public ParamVisitor m_RegistryToken;
		}

		// Token: 0x0200006D RID: 109
		[CompilerGenerated]
		private sealed class CandidateToken
		{
			// Token: 0x060003D8 RID: 984 RVA: 0x00002354 File Offset: 0x00000554
			public CandidateToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x000042AF File Offset: 0x000024AF
			internal void InterruptDescriptor()
			{
				this._ProducerToken.textBox2.AppendText(this._RoleToken.MainWindowTitle + " -> Captcha Solver Started! \r\n");
				Application.DoEvents();
			}

			// Token: 0x060003DA RID: 986 RVA: 0x000042DB File Offset: 0x000024DB
			internal void AddDescriptor()
			{
				this._ProducerToken.textBox2.AppendText(this._RoleToken.MainWindowTitle + " -> Captcha Solver Exited! \r\n");
			}

			// Token: 0x04000282 RID: 642
			public ParamVisitor _ProducerToken;

			// Token: 0x04000283 RID: 643
			public Process _RoleToken;
		}

		// Token: 0x0200006E RID: 110
		[CompilerGenerated]
		private sealed class SingletonToken
		{
			// Token: 0x060003DB RID: 987 RVA: 0x00002354 File Offset: 0x00000554
			public SingletonToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00025808 File Offset: 0x00023A08
			internal void MapDescriptor()
			{
				this.procToken._ProducerToken.textBox2.AppendText(this.procToken._RoleToken.MainWindowTitle + " -> Captcha found: " + this.m_MapperToken + "\r\n");
				Application.DoEvents();
			}

			// Token: 0x04000284 RID: 644
			public string m_MapperToken;

			// Token: 0x04000285 RID: 645
			public ParamVisitor.CandidateToken procToken;
		}

		// Token: 0x0200006F RID: 111
		[CompilerGenerated]
		private sealed class WorkerTest
		{
			// Token: 0x060003DD RID: 989 RVA: 0x00002354 File Offset: 0x00000554
			public WorkerTest()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00025854 File Offset: 0x00023A54
			internal void RemoveDescriptor()
			{
				int num = this._VisitorTest + this.m_TestsTest;
				this.itemTest.procToken._ProducerToken.textBox2.AppendText(string.Concat(new string[]
				{
					this.itemTest.procToken._RoleToken.MainWindowTitle,
					" -> Captcha Solved: ",
					this.itemTest.m_MapperToken,
					" = ",
					num.ToString(),
					"\r\n"
				}));
			}

			// Token: 0x04000286 RID: 646
			public int _VisitorTest;

			// Token: 0x04000287 RID: 647
			public int m_TestsTest;

			// Token: 0x04000288 RID: 648
			public ParamVisitor.SingletonToken itemTest;
		}

		// Token: 0x02000070 RID: 112
		[CompilerGenerated]
		private sealed class MethodTest
		{
			// Token: 0x060003DF RID: 991 RVA: 0x00002354 File Offset: 0x00000554
			public MethodTest()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00004302 File Offset: 0x00002502
			internal void RevertDescriptor()
			{
				this.m_PageTest.CalculateTest(false, this._TokenTest);
			}

			// Token: 0x04000289 RID: 649
			public Process _TokenTest;

			// Token: 0x0400028A RID: 650
			public ParamVisitor m_PageTest;
		}

		// Token: 0x02000071 RID: 113
		[CompilerGenerated]
		private sealed class IndexerTest
		{
			// Token: 0x060003E1 RID: 993 RVA: 0x00002354 File Offset: 0x00000554
			public IndexerTest()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00004316 File Offset: 0x00002516
			internal void InsertAttr()
			{
				this.m_AttrTest.CalculateTest(true, this.descriptorTest);
			}

			// Token: 0x0400028B RID: 651
			public Process descriptorTest;

			// Token: 0x0400028C RID: 652
			public ParamVisitor m_AttrTest;
		}

		// Token: 0x02000072 RID: 114
		[CompilerGenerated]
		private sealed class SpecificationTest
		{
			// Token: 0x060003E3 RID: 995 RVA: 0x00002354 File Offset: 0x00000554
			public SpecificationTest()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x0000432A File Offset: 0x0000252A
			internal void StopAttr()
			{
				this._PolicyTest.AddPage(this._ParameterTest);
			}

			// Token: 0x0400028D RID: 653
			public ParamVisitor _PolicyTest;

			// Token: 0x0400028E RID: 654
			public bool _ParameterTest;
		}
	}
}
