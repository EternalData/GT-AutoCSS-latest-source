using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;
using ns1;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000012 RID: 18
	public static class Broadcaster
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000026B3 File Offset: 0x000008B3
		[CompilerGenerated]
		private static void PopWorker(string instance)
		{
			Broadcaster._Thread = instance;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000026BB File Offset: 0x000008BB
		public static void CloneList(object item)
		{
			Broadcaster.object_0 = item;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000074CC File Offset: 0x000056CC
		private static void smethod_0()
		{
			string item = "Growtopia Unbanner " + "curse" + ":->";
			Broadcaster.object_0.m_QueueTests.Items.Add(item);
			Application.DoEvents();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000026C3 File Offset: 0x000008C3
		public static string CompareList()
		{
			return "https://paste";
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000750C File Offset: 0x0000570C
		private static void smethod_1(object object_1)
		{
			Console.Title = "RAID";
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Broadcaster.object_0.m_QueueTests.Items.Add("Enter。");
			Application.DoEvents();
			Console.ForegroundColor = ConsoleColor.Red;
			string str = Console.ReadLine();
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Broadcaster.object_0.m_QueueTests.Items.Add("こんにちは " + str + "! へようこそ");
			Application.DoEvents();
			Console.ForegroundColor = ConsoleColor.Cyan;
			Broadcaster.smethod_0();
			bool flag = true;
			while (flag)
			{
				string a = Console.ReadLine();
				if (!(a == "unban"))
				{
					if (!(a == "connect"))
					{
						Broadcaster.object_0.m_QueueTests.Items.Add("<------------------------->");
						Broadcaster.object_0.m_QueueTests.Items.Add("Type ---->>>>  unban ");
						Broadcaster.object_0.m_QueueTests.Items.Add("<------------------------->");
						Application.DoEvents();
						Broadcaster.smethod_0();
					}
				}
				else
				{
					Broadcaster.CreateList();
					Broadcaster.smethod_0();
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007628 File Offset: 0x00005828
		public static void CreateList()
		{
			Broadcaster.object_0.m_QueueTests.Items.Add("unbanning...");
			Application.DoEvents();
			Application.DoEvents();
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat");
				Broadcaster.object_0.m_QueueTests.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Application.DoEvents();
				Broadcaster.object_0.m_QueueTests.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\log.txt");
				Broadcaster.object_0.m_QueueTests.Items.Add("Log.txt deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Broadcaster.object_0.m_QueueTests.Items.Add("log.txt deleted");
				Application.DoEvents();
			}
			try
			{
				Broadcaster.smethod_9();
				Broadcaster.object_0.m_QueueTests.Items.Add(Broadcaster.string_0 + "deleted");
				Application.DoEvents();
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Couldn't delete HKEY_CURRENT_USER");
				Application.DoEvents();
			}
			Console.ForegroundColor = ConsoleColor.Magenta;
			try
			{
				Broadcaster.smethod_8();
				Broadcaster.object_0.m_QueueTests.Items.Add("Deleted " + Broadcaster.string_1);
				Application.DoEvents();
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Couldn't delete HKEY_CURRENT_USER \\ Software \\ Microsoft");
				Application.DoEvents();
			}
			try
			{
				Broadcaster.smethod_12();
				Broadcaster.smethod_13();
				Broadcaster.RevertList();
				List<string> list = new List<string>();
				foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Broadcaster.ProcessToken.importerToken.FindDescriptor)).OrderByDescending(new Func<NetworkInterface, long>(Broadcaster.ProcessToken.importerToken.SetupDescriptor)))
				{
					list.Add(networkInterface.Name);
				}
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.ForegroundColor = ConsoleColor.Red;
				foreach (string string_ in list)
				{
					Broadcaster.smethod_14(false, string_);
				}
				Broadcaster.object_0.m_QueueTests.Items.Add("Restarting all active connections..." + "\r\n");
				Thread.Sleep(1000);
				foreach (string string_2 in list)
				{
					Broadcaster.smethod_14(true, string_2);
				}
				Console.ForegroundColor = ConsoleColor.Green;
				Broadcaster.object_0.m_QueueTests.Items.Add("Active connection" + "\r\n");
				try
				{
					if (File.Exists("config.txt"))
					{
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("VPN..." + "\r\n");
						Process.Start(File.ReadAllText("config.txt"));
					}
				}
				catch
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("config.txt error" + "\r\n");
				}
			}
			catch (Exception ex)
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Error: " + ex.Message);
				Application.DoEvents();
			}
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Cyan;
			Broadcaster.object_0.m_QueueTests.Items.Add("Done！");
			Application.DoEvents();
			Broadcaster.PopWorker(null);
			Broadcaster.string_1 = null;
			Broadcaster.string_0 = null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007ADC File Offset: 0x00005CDC
		public static void CalcList()
		{
			Broadcaster.object_0.m_QueueTests.Items.Add("unbanning...");
			Application.DoEvents();
			Application.DoEvents();
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\save.dat");
				Broadcaster.object_0.m_QueueTests.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Application.DoEvents();
				Broadcaster.object_0.m_QueueTests.Items.Add("save.dat deleted");
				Application.DoEvents();
			}
			try
			{
				File.Delete(Environment.ExpandEnvironmentVariables("%LOCALAPPDATA%") + "\\Growtopia\\log.txt");
				Broadcaster.object_0.m_QueueTests.Items.Add("Log.txt deleted");
				Application.DoEvents();
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Broadcaster.object_0.m_QueueTests.Items.Add("log.txt deleted");
				Application.DoEvents();
			}
			try
			{
				Broadcaster.smethod_9();
				Broadcaster.object_0.m_QueueTests.Items.Add(Broadcaster.string_0 + "deleted");
				Application.DoEvents();
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Couldn't delete HKEY_CURRENT_USER");
				Application.DoEvents();
			}
			Console.ForegroundColor = ConsoleColor.Magenta;
			try
			{
				Broadcaster.smethod_8();
				Broadcaster.object_0.m_QueueTests.Items.Add("Deleted " + Broadcaster.string_1);
				Application.DoEvents();
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Couldn't delete HKEY_CURRENT_USER \\ Software \\ Microsoft");
				Application.DoEvents();
			}
			try
			{
				Broadcaster.smethod_12();
				Broadcaster.smethod_13();
			}
			catch (Exception ex)
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Error: " + ex.Message);
				Application.DoEvents();
			}
			Thread.Sleep(1000);
			Console.ForegroundColor = ConsoleColor.Cyan;
			Broadcaster.object_0.m_QueueTests.Items.Add("Registry Done！");
			Application.DoEvents();
			Broadcaster.PopWorker(null);
			Broadcaster.string_1 = null;
			Broadcaster.string_0 = null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007D44 File Offset: 0x00005F44
		private static bool smethod_2(string string_2, bool bool_0)
		{
			bool result;
			if (string_2.Length != 12)
			{
				result = false;
			}
			else if (string_2 != string_2.ToUpper())
			{
				result = false;
			}
			else if (!Regex.IsMatch(string_2, "^[0-9A-F]*$"))
			{
				result = false;
			}
			else if (bool_0)
			{
				result = true;
			}
			else
			{
				char c = string_2[1];
				result = (c == '2' || c == '6' || c == 'A' || c == 'E');
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000026CA File Offset: 0x000008CA
		private static string smethod_3(int int_0)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", int_0).Select(new Func<string, char>(Broadcaster.ProcessToken.importerToken.LogoutDescriptor)).ToArray<char>());
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002705 File Offset: 0x00000905
		private static bool smethod_4(byte[] byte_0, bool bool_0)
		{
			return Broadcaster.smethod_2(Broadcaster.smethod_5(byte_0), bool_0);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002713 File Offset: 0x00000913
		private static string smethod_5(byte[] byte_0)
		{
			return BitConverter.ToString(byte_0).Replace("-", "").ToUpper();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007DB4 File Offset: 0x00005FB4
		private static string smethod_6()
		{
			string result;
			try
			{
				string[] subKeyNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft", true).GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						Broadcaster.string_1 = text;
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 5)
					{
						Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
						Application.DoEvents();
					}
				}
				result = Broadcaster.string_1;
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007E88 File Offset: 0x00006088
		private static string smethod_7()
		{
			string result;
			try
			{
				string[] subKeyNames = Registry.CurrentUser.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						Broadcaster.string_0 = text;
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 9)
					{
						Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER No keys found!");
						Application.DoEvents();
					}
				}
				result = Broadcaster.string_0;
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER No keys found!");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007F54 File Offset: 0x00006154
		private static void smethod_8()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser;
				registryKey = registryKey.OpenSubKey("Software\\Microsoft", true);
				string[] subKeyNames = registryKey.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						registryKey.DeleteSubKey(text);
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 5)
					{
						Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER \\ Software \\ Microsoft No keys found!");
				Application.DoEvents();
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008020 File Offset: 0x00006220
		private static void smethod_9()
		{
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				string[] subKeyNames = currentUser.GetSubKeyNames();
				int num = 0;
				if (0 < subKeyNames.Length)
				{
					string text = subKeyNames[num];
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						currentUser.DeleteSubKey(text);
					}
					else if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length != 9)
					{
						Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("HKEY_CURRENT_USER");
				Application.DoEvents();
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000080E0 File Offset: 0x000062E0
		public static void RevertList()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Broadcaster.ProcessToken.importerToken.ExcludeDescriptor)).OrderByDescending(new Func<NetworkInterface, long>(Broadcaster.ProcessToken.importerToken.FillDescriptor)))
				{
					string text = networkInterface.GetPhysicalAddress().ToString();
					string description = networkInterface.Description;
					Broadcaster.object_0.m_QueueTests.Items.Add(string.Concat(new string[]
					{
						" ",
						description,
						"\r\n",
						" Mac address： ",
						text,
						" Changing mac...",
						"\r\n"
					}));
					Application.DoEvents();
				}
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}", true);
				string[] subKeyNames = registryKey.GetSubKeyNames();
				int i = 0;
				while (i < subKeyNames.Length)
				{
					string text2 = subKeyNames[i];
					if (Regex.IsMatch(text2, "^[0-9]+$", RegexOptions.Compiled) && text2.Length == 4)
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(text2, true);
						string b = (string)registryKey2.GetValue("DriverDesc");
						if ((string)registryKey2.GetValue("AllowNonAdmin") == "0")
						{
							registryKey2.SetValue("AllowNonAdmin", "1", RegistryValueKind.String);
						}
						using (IEnumerator<NetworkInterface> enumerator = NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Broadcaster.ProcessToken.importerToken.ListDescriptor)).OrderByDescending(new Func<NetworkInterface, long>(Broadcaster.ProcessToken.importerToken.CustomizeDescriptor)).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								NetworkInterface networkInterface2 = enumerator.Current;
								networkInterface2.GetPhysicalAddress().ToString();
								string description2 = networkInterface2.Description;
								string text3 = networkInterface2.NetworkInterfaceType.ToString();
								networkInterface2.OperationalStatus.ToString();
								if (description2 == b)
								{
									try
									{
										registryKey2.DeleteValue("NetworkAddress");
										goto IL_291;
									}
									catch
									{
										goto IL_291;
									}
									goto IL_236;
									IL_261:
									bool flag;
									if (flag)
									{
										registryKey2.SetValue("NetworkAddress", "02BEF3123BD1", RegistryValueKind.String);
										continue;
									}
									registryKey2.SetValue("NetworkAddress", "02BEF3123BD1", RegistryValueKind.String);
									continue;
									IL_260:
									flag = true;
									goto IL_261;
									IL_236:
									if (!description2.Contains("WI-FI") && !description2.Contains("WIFI"))
									{
										flag = text3.Contains("Ethernet 802.3");
										goto IL_261;
									}
									goto IL_260;
									IL_291:
									if (!description2.Contains("Wireless"))
									{
										goto IL_236;
									}
									goto IL_260;
								}
							}
							goto IL_2CD;
						}
						goto IL_2AD;
					}
					goto IL_2AD;
					IL_2CD:
					i++;
					continue;
					IL_2AD:
					if (!Regex.IsMatch(text2, "^[0-9]+$", RegexOptions.Compiled))
					{
						bool flag2 = text2.Length != 4;
					}
					goto IL_2CD;
				}
			}
			catch (Exception ex)
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Couldn't change Mac: " + ex.Message);
				Application.DoEvents();
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008460 File Offset: 0x00006660
		public static string InsertWorker()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			return string.Concat(array.Select(new Func<byte, string>(Broadcaster.ProcessToken.importerToken.PostDescriptor)).ToArray<string>()).TrimEnd(new char[]
			{
				':'
			}).Replace(":", "");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000084D0 File Offset: 0x000066D0
		private static string smethod_10()
		{
			string result;
			try
			{
				List<string> list = Class1.smethod_1().Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				int index = new Random().Next(0, list.Count);
				string str = list[index].Split(new char[]
				{
					','
				})[0];
				Random random = new Random();
				byte[] array = new byte[3];
				random.NextBytes(array);
				string str2 = string.Concat(array.Select(new Func<byte, string>(Broadcaster.ProcessToken.importerToken.FlushDescriptor)).ToArray<string>());
				result = (str + ":" + str2).Replace(":", "");
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Mac-address gen failed to generate a new mac");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000085C4 File Offset: 0x000067C4
		private static string smethod_11()
		{
			string result;
			try
			{
				List<string> list = Class1.smethod_1().Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
				int index = new Random().Next(0, 12686);
				string str = list[index].Split(new char[]
				{
					','
				})[0];
				Random random = new Random();
				byte[] array = new byte[3];
				random.NextBytes(array);
				string str2 = string.Concat(array.Select(new Func<byte, string>(Broadcaster.ProcessToken.importerToken.ResolveDescriptor)).ToArray<string>());
				result = (str + ":" + str2).Replace(":", "");
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Mac-address");
				Application.DoEvents();
				result = "NULL";
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000086B4 File Offset: 0x000068B4
		private static void smethod_12()
		{
			try
			{
				bool is64BitOperatingSystem;
				if (is64BitOperatingSystem = Environment.Is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Broadcaster.object_0.m_QueueTests.Items.Add("OS is running on 64 bit!");
					Application.DoEvents();
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", true);
					if (registryKey != null)
					{
						registryKey.DeleteValue("MachineGuid");
						Process process = Process.Start(new ProcessStartInfo("regedit")
						{
							RedirectStandardError = false,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							CreateNoWindow = true,
							Verb = "run as"
						});
						Thread.Sleep(50);
						process.Kill();
						Console.ForegroundColor = ConsoleColor.Green;
						Broadcaster.object_0.m_QueueTests.Items.Add("MachineGUID successfully changed!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Broadcaster.object_0.m_QueueTests.Items.Add("Cannot be changed!");
					}
				}
				else if (!is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Broadcaster.object_0.m_QueueTests.Items.Add("OS is running on 32bit!");
					Application.DoEvents();
					Guid.NewGuid().ToString();
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
					registryKey2 = registryKey2.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", true);
					if (registryKey2 != null)
					{
						registryKey2.DeleteValue("MachineGuid");
						Process process2 = Process.Start(new ProcessStartInfo("regedit")
						{
							RedirectStandardError = false,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							CreateNoWindow = true,
							Verb = "run as"
						});
						Thread.Sleep(50);
						process2.Kill();
						Console.ForegroundColor = ConsoleColor.Green;
						Broadcaster.object_0.m_QueueTests.Items.Add("Successfully Changed MachineGUID!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Broadcaster.object_0.m_QueueTests.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Broadcaster.object_0.m_QueueTests.Items.Add("Access Denied on Modifying MachineGuid!");
				Application.DoEvents();
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008900 File Offset: 0x00006B00
		private static void smethod_13()
		{
			try
			{
				bool is64BitOperatingSystem;
				if (is64BitOperatingSystem = Environment.Is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey = registryKey.OpenSubKey("SYSTEM\\\\CurrentControlSet\\\\Services\\\\Tcpip\\\\Parameters", true);
					if (registryKey != null)
					{
						try
						{
							registryKey.DeleteValue("Hostname");
						}
						catch
						{
						}
						registryKey.SetValue("Hostname", "JqKnY47H");
						Console.ForegroundColor = ConsoleColor.Green;
						Broadcaster.object_0.m_QueueTests.Items.Add("Successfully Changed Hostname!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Broadcaster.object_0.m_QueueTests.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
				else if (!is64BitOperatingSystem)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Guid.NewGuid().ToString();
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
					registryKey2 = registryKey2.OpenSubKey("SYSTEM\\\\CurrentControlSet\\\\Services\\\\Tcpip\\\\Parameters", true);
					if (registryKey2 != null)
					{
						try
						{
							registryKey2.DeleteValue("Hostname");
						}
						catch
						{
						}
						registryKey2.SetValue("Hostname", "dwRbl7s5");
						Console.ForegroundColor = ConsoleColor.Green;
						Broadcaster.object_0.m_QueueTests.Items.Add("Successfully Changed Hostname!");
						Application.DoEvents();
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Broadcaster.object_0.m_QueueTests.Items.Add("Unable to modify!");
						Application.DoEvents();
					}
				}
			}
			catch
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Broadcaster.object_0.m_QueueTests.Items.Add("Access Denied on Modifying MachineGuid!");
				Application.DoEvents();
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008AE8 File Offset: 0x00006CE8
		private static void smethod_14(bool bool_0, string string_2)
		{
			try
			{
				string str;
				if (bool_0)
				{
					str = "enable";
				}
				else
				{
					str = "disable";
				}
				ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + string_2 + "\" " + str)
				{
					RedirectStandardError = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					CreateNoWindow = true,
					Verb = "run as"
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				process.Start();
				process.WaitForExit();
			}
			catch
			{
				Broadcaster.object_0.m_QueueTests.Items.Add("Failed to Disable/Enable the connection");
				Application.DoEvents();
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000272F File Offset: 0x0000092F
		// Note: this type is marked as 'beforefieldinit'.
		static Broadcaster()
		{
			Class21.smethod_0();
			Broadcaster.random_0 = new Random();
		}

		// Token: 0x04000046 RID: 70
		private static object object_0;

		// Token: 0x04000047 RID: 71
		[CompilerGenerated]
		private static string _Thread;

		// Token: 0x04000048 RID: 72
		private static string string_0;

		// Token: 0x04000049 RID: 73
		private static string string_1;

		// Token: 0x0400004A RID: 74
		private static Random random_0;

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		[Serializable]
		private sealed class ProcessToken
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00002740 File Offset: 0x00000940
			// Note: this type is marked as 'beforefieldinit'.
			static ProcessToken()
			{
				Class21.smethod_0();
				Broadcaster.ProcessToken.importerToken = new Broadcaster.ProcessToken();
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00002354 File Offset: 0x00000554
			public ProcessToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00002751 File Offset: 0x00000951
			internal bool FindDescriptor(NetworkInterface init)
			{
				return Broadcaster.smethod_4(init.GetPhysicalAddress().GetAddressBytes(), true);
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00002764 File Offset: 0x00000964
			internal long SetupDescriptor(NetworkInterface v)
			{
				return v.Speed;
			}

			// Token: 0x06000077 RID: 119 RVA: 0x0000276C File Offset: 0x0000096C
			internal char LogoutDescriptor(string param)
			{
				return param[Broadcaster.random_0.Next(param.Length)];
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00002751 File Offset: 0x00000951
			internal bool ExcludeDescriptor(NetworkInterface instance)
			{
				return Broadcaster.smethod_4(instance.GetPhysicalAddress().GetAddressBytes(), true);
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002764 File Offset: 0x00000964
			internal long FillDescriptor(NetworkInterface setup)
			{
				return setup.Speed;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002751 File Offset: 0x00000951
			internal bool ListDescriptor(NetworkInterface setup)
			{
				return Broadcaster.smethod_4(setup.GetPhysicalAddress().GetAddressBytes(), true);
			}

			// Token: 0x0600007B RID: 123 RVA: 0x00002764 File Offset: 0x00000964
			internal long CustomizeDescriptor(NetworkInterface var1)
			{
				return var1.Speed;
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00002784 File Offset: 0x00000984
			internal string PostDescriptor(byte init_Low)
			{
				return string.Format("{0}:", init_Low.ToString("X2"));
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00008B98 File Offset: 0x00006D98
			internal string FlushDescriptor(byte sum_config)
			{
				string format = "{0}:";
				byte b = sum_config;
				return string.Format(format, b.ToString("X2"));
			}

			// Token: 0x0600007E RID: 126 RVA: 0x00008B98 File Offset: 0x00006D98
			internal string ResolveDescriptor(byte indexOf_info)
			{
				string format = "{0}:";
				byte b = indexOf_info;
				return string.Format(format, b.ToString("X2"));
			}

			// Token: 0x0400004B RID: 75
			public static readonly Broadcaster.ProcessToken importerToken;

			// Token: 0x0400004C RID: 76
			public static Func<NetworkInterface, bool> taskToken;

			// Token: 0x0400004D RID: 77
			public static Func<NetworkInterface, long> _CollectionToken;

			// Token: 0x0400004E RID: 78
			public static Func<string, char> authenticationToken;

			// Token: 0x0400004F RID: 79
			public static Func<NetworkInterface, bool> _StatusToken;

			// Token: 0x04000050 RID: 80
			public static Func<NetworkInterface, long> _ConfigurationToken;

			// Token: 0x04000051 RID: 81
			public static Func<NetworkInterface, bool> resolverToken;

			// Token: 0x04000052 RID: 82
			public static Func<NetworkInterface, long> m_StructToken;

			// Token: 0x04000053 RID: 83
			public static Func<byte, string> connectionToken;

			// Token: 0x04000054 RID: 84
			public static Func<byte, string> m_GlobalToken;

			// Token: 0x04000055 RID: 85
			public static Func<byte, string> algoToken;
		}
	}
}
