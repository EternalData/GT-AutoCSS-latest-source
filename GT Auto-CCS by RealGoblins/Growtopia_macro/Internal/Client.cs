using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x0200001C RID: 28
	public class Client
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00002896 File Offset: 0x00000A96
		public Client(ManagementObject reference, string cust, string template, int row_res2)
		{
			Class21.smethod_0();
			base..ctor();
			this.m_Prototype = reference;
			this.decorator = cust;
			this.rules = template;
			this.database = row_res2;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000028C0 File Offset: 0x00000AC0
		public Client(NetworkInterface var1)
		{
			Class21.smethod_0();
			this..ctor(var1.Description);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000959C File Offset: 0x0000779C
		public Client(string def)
		{
			Class21.smethod_0();
			base..ctor();
			this.decorator = def;
			ManagementObjectCollection source = new ManagementObjectSearcher("select * from win32_networkadapter where Name='" + this.decorator + "'").Get();
			this.m_Prototype = source.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
			try
			{
				Match match = Regex.Match(this.m_Prototype.Path.RelativePath, "\\\"(\\d+)\\\"$");
				this.database = int.Parse(match.Groups[1].Value);
			}
			catch
			{
				return;
			}
			this.rules = NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(this.ComputeWorker)).Select(new Func<NetworkInterface, string>(Client.StateToken._SchemaToken.PatchDescriptor)).FirstOrDefault<string>();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000028D3 File Offset: 0x00000AD3
		public NetworkInterface InterruptWorker()
		{
			return NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(this.RateWorker)).FirstOrDefault<NetworkInterface>();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00009680 File Offset: 0x00007880
		public string Mac
		{
			get
			{
				string result;
				try
				{
					result = BitConverter.ToString(this.InterruptWorker().GetPhysicalAddress().GetAddressBytes()).Replace("-", "").ToUpper();
				}
				catch
				{
					result = null;
				}
				return result;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000028F0 File Offset: 0x00000AF0
		public string RemoveWorker()
		{
			return string.Format("SYSTEM\\ControlSet001\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{0:D4}", this.database);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000096D0 File Offset: 0x000078D0
		public string InsertVisitor()
		{
			string result;
			try
			{
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RemoveWorker(), false))
				{
					result = registryKey.GetValue("NetworkAddress").ToString();
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00009730 File Offset: 0x00007930
		public bool SearchWorker(string item)
		{
			bool flag = false;
			bool result;
			try
			{
				if (item.Length > 0 && !Client.CalcWorker(item, false))
				{
					throw new Exception(item + " is not a valid mac address");
				}
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.RemoveWorker(), true))
				{
					if (registryKey == null)
					{
						throw new Exception("Failed to open the registry key");
					}
					if (registryKey.GetValue("AdapterModel") as string != this.decorator && registryKey.GetValue("DriverDesc") as string != this.decorator)
					{
						throw new Exception("Adapter not found in registry");
					}
					if (MessageBox.Show(string.Format((item.Length > 0) ? "Changing MAC-adress of adapter {0} from {1} to {2}. Proceed?" : "Clearing custom MAC-address of adapter {0}. Proceed?", this.ToString(), this.Mac, item), "Change MAC-address?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						result = false;
					}
					else
					{
						if ((uint)this.m_Prototype.InvokeMethod("Disable", null) != 0U)
						{
							throw new Exception("Failed to disable network adapter.");
						}
						flag = true;
						if (item.Length > 0)
						{
							registryKey.SetValue("NetworkAddress", item, RegistryValueKind.String);
						}
						else
						{
							registryKey.DeleteValue("NetworkAddress");
						}
						result = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				result = false;
			}
			finally
			{
				if (flag && (uint)this.m_Prototype.InvokeMethod("Enable", null) != 0U)
				{
					MessageBox.Show("Failed to re-enable network adapter.");
				}
			}
			return result;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002907 File Offset: 0x00000B07
		public override string ToString()
		{
			return this.decorator + this.rules;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000098E0 File Offset: 0x00007AE0
		public static string CreateWorker()
		{
			Random random = new Random();
			byte[] array = new byte[6];
			random.NextBytes(array);
			array[0] = (array[0] | 2);
			array[0] = (array[0] & 254);
			return Client.GetWorker(array);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000991C File Offset: 0x00007B1C
		public static bool CalcWorker(string init, bool excludecfg)
		{
			if (init.Length != 12)
			{
				return false;
			}
			if (init != init.ToUpper())
			{
				return false;
			}
			if (!Regex.IsMatch(init, "^[0-9A-F]*$"))
			{
				return false;
			}
			if (excludecfg)
			{
				return true;
			}
			char c = init[1];
			return c == '2' || c == '6' || c == 'A' || c == 'E';
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000291A File Offset: 0x00000B1A
		public static bool CheckWorker(byte[] init, bool novis)
		{
			return Client.CalcWorker(Client.GetWorker(init), novis);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002713 File Offset: 0x00000913
		public static string GetWorker(byte[] i)
		{
			return BitConverter.ToString(i).Replace("-", "").ToUpper();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002928 File Offset: 0x00000B28
		[CompilerGenerated]
		private bool ComputeWorker(NetworkInterface last)
		{
			return last.Description == this.decorator;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002928 File Offset: 0x00000B28
		[CompilerGenerated]
		private bool RateWorker(NetworkInterface first)
		{
			return first.Description == this.decorator;
		}

		// Token: 0x0400007A RID: 122
		public ManagementObject m_Prototype;

		// Token: 0x0400007B RID: 123
		public string decorator;

		// Token: 0x0400007C RID: 124
		public string rules;

		// Token: 0x0400007D RID: 125
		public int database;

		// Token: 0x0200001D RID: 29
		[CompilerGenerated]
		[Serializable]
		private sealed class StateToken
		{
			// Token: 0x060000C7 RID: 199 RVA: 0x0000293B File Offset: 0x00000B3B
			// Note: this type is marked as 'beforefieldinit'.
			static StateToken()
			{
				Class21.smethod_0();
				Client.StateToken._SchemaToken = new Client.StateToken();
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x00002354 File Offset: 0x00000554
			public StateToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x0000294C File Offset: 0x00000B4C
			internal string PatchDescriptor(NetworkInterface key)
			{
				return " (" + key.Name + ")";
			}

			// Token: 0x0400007E RID: 126
			public static readonly Client.StateToken _SchemaToken;

			// Token: 0x0400007F RID: 127
			public static Func<NetworkInterface, string> m_ErrorToken;
		}
	}
}
