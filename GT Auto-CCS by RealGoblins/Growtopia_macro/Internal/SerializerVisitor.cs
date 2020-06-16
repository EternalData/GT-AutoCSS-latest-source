using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000050 RID: 80
	public class SerializerVisitor
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0001058C File Offset: 0x0000E78C
		public static string Value()
		{
			if (string.IsNullOrEmpty(SerializerVisitor.string_0))
			{
				SerializerVisitor.string_0 = SerializerVisitor.smethod_0(string.Concat(new string[]
				{
					"CPU >> ",
					"178BFBFF00810F81",
					"\nBIOS >> ",
					"American Megatrends Inc.2.30To be filled by O.E.M.20190917000000.000000+000ALASKA - 1072009",
					"\nBASE >> ",
					"Micro-Star International Co., Ltd.Base BoardJ916832385"
				}));
			}
			return SerializerVisitor.string_0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000105F0 File Offset: 0x0000E7F0
		private static string smethod_0(string string_1)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = new ASCIIEncoding().GetBytes(string_1);
			return SerializerVisitor.smethod_1(hashAlgorithm.ComputeHash(bytes));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001061C File Offset: 0x0000E81C
		private static string smethod_1(object object_0)
		{
			string text = string.Empty;
			for (int i = 0; i < object_0.Length; i++)
			{
				object obj = object_0[i];
				int num = obj & 15;
				int num2 = obj >> 4 & 15;
				if (num2 > 9)
				{
					text += ((char)(num2 - 10 + 65)).ToString();
				}
				else
				{
					text += num2.ToString();
				}
				if (num > 9)
				{
					text += ((char)(num - 10 + 65)).ToString();
				}
				else
				{
					text += num.ToString();
				}
				if (i + 1 != object_0.Length && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000106C8 File Offset: 0x0000E8C8
		private static string smethod_2(string string_1, string string_2, string string_3)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(string_1).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject[string_3].ToString() == "True" && text == "")
				{
					try
					{
						text = managementObject[string_2].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00010764 File Offset: 0x0000E964
		private static string smethod_3(string string_1, string string_2)
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(string_1).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					try
					{
						text = managementObject[string_2].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000107E8 File Offset: 0x0000E9E8
		private static string smethod_4()
		{
			string text = SerializerVisitor.smethod_3("Win32_Processor", "UniqueId");
			if (text == "")
			{
				text = SerializerVisitor.smethod_3("Win32_Processor", "ProcessorId");
				if (text == "")
				{
					text = SerializerVisitor.smethod_3("Win32_Processor", "Name");
					if (text == "")
					{
						text = SerializerVisitor.smethod_3("Win32_Processor", "Manufacturer");
					}
					text += SerializerVisitor.smethod_3("Win32_Processor", "MaxClockSpeed");
				}
			}
			return text;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00010874 File Offset: 0x0000EA74
		private static string smethod_5()
		{
			return string.Concat(new string[]
			{
				SerializerVisitor.smethod_3("Win32_BIOS", "Manufacturer"),
				SerializerVisitor.smethod_3("Win32_BIOS", "SMBIOSBIOSVersion"),
				SerializerVisitor.smethod_3("Win32_BIOS", "IdentificationCode"),
				SerializerVisitor.smethod_3("Win32_BIOS", "SerialNumber"),
				SerializerVisitor.smethod_3("Win32_BIOS", "ReleaseDate"),
				SerializerVisitor.smethod_3("Win32_BIOS", "Version")
			});
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000108F8 File Offset: 0x0000EAF8
		private static string smethod_6()
		{
			return SerializerVisitor.smethod_3("Win32_DiskDrive", "Model") + SerializerVisitor.smethod_3("Win32_DiskDrive", "Manufacturer") + SerializerVisitor.smethod_3("Win32_DiskDrive", "Signature") + SerializerVisitor.smethod_3("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00010948 File Offset: 0x0000EB48
		private static string smethod_7()
		{
			return SerializerVisitor.smethod_3("Win32_BaseBoard", "Model") + SerializerVisitor.smethod_3("Win32_BaseBoard", "Manufacturer") + SerializerVisitor.smethod_3("Win32_BaseBoard", "Name") + SerializerVisitor.smethod_3("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000039B9 File Offset: 0x00001BB9
		private static string smethod_8()
		{
			return SerializerVisitor.smethod_3("Win32_VideoController", "DriverVersion") + SerializerVisitor.smethod_3("Win32_VideoController", "Name");
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000039DE File Offset: 0x00001BDE
		private static string smethod_9()
		{
			return SerializerVisitor.smethod_2("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002354 File Offset: 0x00000554
		public SerializerVisitor()
		{
			Class21.smethod_0();
			base..ctor();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000039F4 File Offset: 0x00001BF4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializerVisitor()
		{
			Class21.smethod_0();
			SerializerVisitor.string_0 = string.Empty;
		}

		// Token: 0x0400011C RID: 284
		private static string string_0;
	}
}
