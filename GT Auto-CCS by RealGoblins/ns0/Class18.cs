using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0
{
	// Token: 0x02000090 RID: 144
	internal class Class18
	{
		// Token: 0x06000544 RID: 1348 RVA: 0x0002C6B0 File Offset: 0x0002A8B0
		static Class18()
		{
			Class18.assembly_0 = typeof(Class18).Assembly;
			Class18.uint_0 = new uint[]
			{
				3614090360U,
				3905402710U,
				606105819U,
				3250441966U,
				4118548399U,
				1200080426U,
				2821735955U,
				4249261313U,
				1770035416U,
				2336552879U,
				4294925233U,
				2304563134U,
				1804603682U,
				4254626195U,
				2792965006U,
				1236535329U,
				4129170786U,
				3225465664U,
				643717713U,
				3921069994U,
				3593408605U,
				38016083U,
				3634488961U,
				3889429448U,
				568446438U,
				3275163606U,
				4107603335U,
				1163531501U,
				2850285829U,
				4243563512U,
				1735328473U,
				2368359562U,
				4294588738U,
				2272392833U,
				1839030562U,
				4259657740U,
				2763975236U,
				1272893353U,
				4139469664U,
				3200236656U,
				681279174U,
				3936430074U,
				3572445317U,
				76029189U,
				3654602809U,
				3873151461U,
				530742520U,
				3299628645U,
				4096336452U,
				1126891415U,
				2878612391U,
				4237533241U,
				1700485571U,
				2399980690U,
				4293915773U,
				2240044497U,
				1873313359U,
				4264355552U,
				2734768916U,
				1309151649U,
				4149444226U,
				3174756917U,
				718787259U,
				3951481745U
			};
			Class18.bool_1 = false;
			Class18.bool_6 = false;
			Class18.byte_0 = new byte[0];
			Class18.byte_2 = new byte[0];
			Class18.byte_1 = new byte[0];
			Class18.byte_3 = new byte[0];
			Class18.intptr_2 = IntPtr.Zero;
			Class18.intptr_0 = IntPtr.Zero;
			Class18.string_0 = new string[0];
			Class18.int_4 = new int[0];
			Class18.int_0 = 1;
			Class18.bool_0 = false;
			Class18.sortedList_0 = new SortedList();
			Class18.int_1 = 0;
			Class18.long_0 = 0L;
			Class18.object_0 = null;
			Class18.object_1 = null;
			Class18.long_1 = 0L;
			Class18.int_2 = 0;
			Class18.bool_4 = false;
			Class18.bool_2 = false;
			Class18.int_3 = 0;
			Class18.intptr_1 = IntPtr.Zero;
			Class18.bool_3 = false;
			Class18.hashtable_0 = new Hashtable();
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_0()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0002C7E4 File Offset: 0x0002A9E4
		internal static byte[] smethod_0(object object_2)
		{
			uint[] array = new uint[16];
			int num = 448 - object_2.Length * 8 % 512;
			uint num2 = (uint)((num + 512) % 512);
			if (num2 == 0U)
			{
				num2 = 512U;
			}
			uint num3 = (uint)((long)object_2.Length + (long)((ulong)(num2 / 8U)) + 8L);
			ulong num4 = (ulong)((long)object_2.Length * 8L);
			byte[] array2 = new byte[num3];
			for (int i = 0; i < object_2.Length; i++)
			{
				array2[i] = object_2[i];
			}
			byte[] array3 = array2;
			int num5 = object_2.Length;
			array3[num5] |= 128;
			for (int j = 8; j > 0; j--)
			{
				array2[(int)(checked((IntPtr)(unchecked((ulong)num3 - (ulong)((long)j)))))] = (byte)(num4 >> (8 - j) * 8 & 255UL);
			}
			uint num6 = (uint)(array2.Length * 8 / 32);
			uint num7 = 1732584193U;
			uint num8 = 4023233417U;
			uint num9 = 2562383102U;
			uint num10 = 271733878U;
			for (uint num11 = 0U; num11 < num6 / 16U; num11 += 1U)
			{
				uint num12 = num11 << 6;
				for (uint num13 = 0U; num13 < 61U; num13 += 4U)
				{
					array[(int)((UIntPtr)(num13 >> 2))] = (uint)((int)array2[(int)((UIntPtr)(num12 + (num13 + 3U)))] << 24 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 2U)))] << 16 | (int)array2[(int)((UIntPtr)(num12 + (num13 + 1U)))] << 8 | (int)array2[(int)((UIntPtr)(num12 + num13))]);
				}
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				uint num17 = num10;
				Class18.smethod_1(ref num7, num8, num9, num10, 0U, 7, 1U, array);
				Class18.smethod_1(ref num10, num7, num8, num9, 1U, 12, 2U, array);
				Class18.smethod_1(ref num9, num10, num7, num8, 2U, 17, 3U, array);
				Class18.smethod_1(ref num8, num9, num10, num7, 3U, 22, 4U, array);
				Class18.smethod_1(ref num7, num8, num9, num10, 4U, 7, 5U, array);
				Class18.smethod_1(ref num10, num7, num8, num9, 5U, 12, 6U, array);
				Class18.smethod_1(ref num9, num10, num7, num8, 6U, 17, 7U, array);
				Class18.smethod_1(ref num8, num9, num10, num7, 7U, 22, 8U, array);
				Class18.smethod_1(ref num7, num8, num9, num10, 8U, 7, 9U, array);
				Class18.smethod_1(ref num10, num7, num8, num9, 9U, 12, 10U, array);
				Class18.smethod_1(ref num9, num10, num7, num8, 10U, 17, 11U, array);
				Class18.smethod_1(ref num8, num9, num10, num7, 11U, 22, 12U, array);
				Class18.smethod_1(ref num7, num8, num9, num10, 12U, 7, 13U, array);
				Class18.smethod_1(ref num10, num7, num8, num9, 13U, 12, 14U, array);
				Class18.smethod_1(ref num9, num10, num7, num8, 14U, 17, 15U, array);
				Class18.smethod_1(ref num8, num9, num10, num7, 15U, 22, 16U, array);
				Class18.smethod_2(ref num7, num8, num9, num10, 1U, 5, 17U, array);
				Class18.smethod_2(ref num10, num7, num8, num9, 6U, 9, 18U, array);
				Class18.smethod_2(ref num9, num10, num7, num8, 11U, 14, 19U, array);
				Class18.smethod_2(ref num8, num9, num10, num7, 0U, 20, 20U, array);
				Class18.smethod_2(ref num7, num8, num9, num10, 5U, 5, 21U, array);
				Class18.smethod_2(ref num10, num7, num8, num9, 10U, 9, 22U, array);
				Class18.smethod_2(ref num9, num10, num7, num8, 15U, 14, 23U, array);
				Class18.smethod_2(ref num8, num9, num10, num7, 4U, 20, 24U, array);
				Class18.smethod_2(ref num7, num8, num9, num10, 9U, 5, 25U, array);
				Class18.smethod_2(ref num10, num7, num8, num9, 14U, 9, 26U, array);
				Class18.smethod_2(ref num9, num10, num7, num8, 3U, 14, 27U, array);
				Class18.smethod_2(ref num8, num9, num10, num7, 8U, 20, 28U, array);
				Class18.smethod_2(ref num7, num8, num9, num10, 13U, 5, 29U, array);
				Class18.smethod_2(ref num10, num7, num8, num9, 2U, 9, 30U, array);
				Class18.smethod_2(ref num9, num10, num7, num8, 7U, 14, 31U, array);
				Class18.smethod_2(ref num8, num9, num10, num7, 12U, 20, 32U, array);
				Class18.smethod_3(ref num7, num8, num9, num10, 5U, 4, 33U, array);
				Class18.smethod_3(ref num10, num7, num8, num9, 8U, 11, 34U, array);
				Class18.smethod_3(ref num9, num10, num7, num8, 11U, 16, 35U, array);
				Class18.smethod_3(ref num8, num9, num10, num7, 14U, 23, 36U, array);
				Class18.smethod_3(ref num7, num8, num9, num10, 1U, 4, 37U, array);
				Class18.smethod_3(ref num10, num7, num8, num9, 4U, 11, 38U, array);
				Class18.smethod_3(ref num9, num10, num7, num8, 7U, 16, 39U, array);
				Class18.smethod_3(ref num8, num9, num10, num7, 10U, 23, 40U, array);
				Class18.smethod_3(ref num7, num8, num9, num10, 13U, 4, 41U, array);
				Class18.smethod_3(ref num10, num7, num8, num9, 0U, 11, 42U, array);
				Class18.smethod_3(ref num9, num10, num7, num8, 3U, 16, 43U, array);
				Class18.smethod_3(ref num8, num9, num10, num7, 6U, 23, 44U, array);
				Class18.smethod_3(ref num7, num8, num9, num10, 9U, 4, 45U, array);
				Class18.smethod_3(ref num10, num7, num8, num9, 12U, 11, 46U, array);
				Class18.smethod_3(ref num9, num10, num7, num8, 15U, 16, 47U, array);
				Class18.smethod_3(ref num8, num9, num10, num7, 2U, 23, 48U, array);
				Class18.smethod_4(ref num7, num8, num9, num10, 0U, 6, 49U, array);
				Class18.smethod_4(ref num10, num7, num8, num9, 7U, 10, 50U, array);
				Class18.smethod_4(ref num9, num10, num7, num8, 14U, 15, 51U, array);
				Class18.smethod_4(ref num8, num9, num10, num7, 5U, 21, 52U, array);
				Class18.smethod_4(ref num7, num8, num9, num10, 12U, 6, 53U, array);
				Class18.smethod_4(ref num10, num7, num8, num9, 3U, 10, 54U, array);
				Class18.smethod_4(ref num9, num10, num7, num8, 10U, 15, 55U, array);
				Class18.smethod_4(ref num8, num9, num10, num7, 1U, 21, 56U, array);
				Class18.smethod_4(ref num7, num8, num9, num10, 8U, 6, 57U, array);
				Class18.smethod_4(ref num10, num7, num8, num9, 15U, 10, 58U, array);
				Class18.smethod_4(ref num9, num10, num7, num8, 6U, 15, 59U, array);
				Class18.smethod_4(ref num8, num9, num10, num7, 13U, 21, 60U, array);
				Class18.smethod_4(ref num7, num8, num9, num10, 4U, 6, 61U, array);
				Class18.smethod_4(ref num10, num7, num8, num9, 11U, 10, 62U, array);
				Class18.smethod_4(ref num9, num10, num7, num8, 2U, 15, 63U, array);
				Class18.smethod_4(ref num8, num9, num10, num7, 9U, 21, 64U, array);
				num7 += num14;
				num8 += num15;
				num9 += num16;
				num10 += num17;
			}
			byte[] array4 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num7), 0, array4, 0, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array4, 4, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array4, 8, 4);
			Array.Copy(BitConverter.GetBytes(num10), 0, array4, 12, 4);
			return array4;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00004FE3 File Offset: 0x000031E3
		private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
		{
			uint_1 = uint_2 + Class18.smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + object_2[(int)((UIntPtr)uint_5)] + Class18.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000500E File Offset: 0x0000320E
		private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
		{
			uint_1 = uint_2 + Class18.smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + object_2[(int)((UIntPtr)uint_5)] + Class18.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00005039 File Offset: 0x00003239
		private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
		{
			uint_1 = uint_2 + Class18.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + object_2[(int)((UIntPtr)uint_5)] + Class18.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00005061 File Offset: 0x00003261
		private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_2)
		{
			uint_1 = uint_2 + Class18.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + object_2[(int)((UIntPtr)uint_5)] + Class18.uint_0[(int)((UIntPtr)(uint_6 - 1U))], ushort_0);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000508A File Offset: 0x0000328A
		private static uint smethod_5(uint uint_1, ushort ushort_0)
		{
			return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000509C File Offset: 0x0000329C
		internal static bool smethod_6()
		{
			if (!Class18.bool_1)
			{
				Class18.smethod_8();
				Class18.bool_1 = true;
			}
			return Class18.bool_6;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002CE8C File Offset: 0x0002B08C
		internal static SymmetricAlgorithm smethod_7()
		{
			SymmetricAlgorithm result = null;
			if (Class18.smethod_6())
			{
				result = new AesCryptoServiceProvider();
			}
			else
			{
				try
				{
					result = new RijndaelManaged();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
			return result;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		internal static void smethod_8()
		{
			try
			{
				Class18.bool_6 = CryptoConfig.AllowOnlyFipsAlgorithms;
			}
			catch
			{
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000050B5 File Offset: 0x000032B5
		internal static byte[] smethod_9(byte[] byte_4)
		{
			if (!Class18.smethod_6())
			{
				return new MD5CryptoServiceProvider().ComputeHash(byte_4);
			}
			return Class18.smethod_0(byte_4);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000050D0 File Offset: 0x000032D0
		private static uint smethod_10(uint uint_1)
		{
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002CF10 File Offset: 0x0002B110
		[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
		internal static string smethod_11(int int_5)
		{
			if (Class18.byte_1.Length == 0)
			{
				BinaryReader binaryReader = new BinaryReader(Class18.assembly_0.GetManifestResourceStream("System.Proxy"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				binaryReader.Close();
				byte[] array2 = new byte[32];
				array2[0] = 102;
				array2[0] = 97;
				array2[0] = 212;
				array2[1] = 134;
				array2[1] = 89;
				array2[1] = 57;
				array2[2] = 123;
				array2[2] = 143;
				array2[2] = 172;
				array2[2] = 150;
				array2[2] = 122;
				array2[3] = 180;
				array2[3] = 164;
				array2[3] = 248;
				array2[4] = 130;
				array2[4] = 66;
				array2[4] = 167;
				array2[4] = 80;
				array2[5] = 36;
				array2[5] = 95;
				array2[5] = 182;
				array2[6] = 126;
				array2[6] = 151;
				array2[6] = 148;
				array2[6] = 238;
				array2[7] = 144;
				array2[7] = 142;
				array2[7] = 99;
				array2[7] = 148;
				array2[7] = 133;
				array2[7] = 148;
				array2[8] = 90;
				array2[8] = 104;
				array2[8] = 152;
				array2[8] = 1;
				array2[9] = 128;
				array2[9] = 234;
				array2[9] = 132;
				array2[9] = 125;
				array2[9] = 110;
				array2[9] = 168;
				array2[10] = 142;
				array2[10] = 134;
				array2[10] = 53;
				array2[10] = 82;
				array2[11] = 87;
				array2[11] = 52;
				array2[11] = 133;
				array2[11] = 216;
				array2[12] = 111;
				array2[12] = 108;
				array2[12] = 84;
				array2[12] = 152;
				array2[12] = 91;
				array2[12] = 24;
				array2[13] = 179;
				array2[13] = 109;
				array2[13] = 155;
				array2[13] = 111;
				array2[14] = 31;
				array2[14] = 94;
				array2[14] = 124;
				array2[15] = 114;
				array2[15] = 136;
				array2[15] = 143;
				array2[15] = 96;
				array2[15] = 89;
				array2[15] = 67;
				array2[16] = 138;
				array2[16] = 200;
				array2[16] = 110;
				array2[16] = 78;
				array2[16] = 13;
				array2[17] = 94;
				array2[17] = 174;
				array2[17] = 118;
				array2[17] = 140;
				array2[18] = 121;
				array2[18] = 150;
				array2[18] = 128;
				array2[18] = 164;
				array2[18] = 136;
				array2[18] = 32;
				array2[19] = 156;
				array2[19] = 132;
				array2[19] = 109;
				array2[19] = 201;
				array2[20] = 98;
				array2[20] = 173;
				array2[20] = 91;
				array2[20] = 164;
				array2[20] = 98;
				array2[21] = 136;
				array2[21] = 136;
				array2[21] = 232;
				array2[21] = 93;
				array2[21] = 11;
				array2[22] = 130;
				array2[22] = 17;
				array2[22] = 98;
				array2[22] = 98;
				array2[23] = 150;
				array2[23] = 152;
				array2[23] = 112;
				array2[23] = 84;
				array2[23] = 63;
				array2[23] = 127;
				array2[24] = 140;
				array2[24] = 90;
				array2[24] = 227;
				array2[24] = 50;
				array2[25] = 170;
				array2[25] = 143;
				array2[25] = 161;
				array2[26] = 118;
				array2[26] = 149;
				array2[26] = 131;
				array2[26] = 125;
				array2[26] = 147;
				array2[27] = 40;
				array2[27] = 73;
				array2[27] = 89;
				array2[27] = 162;
				array2[27] = 232;
				array2[28] = 24;
				array2[28] = 98;
				array2[28] = 122;
				array2[28] = 155;
				array2[28] = 74;
				array2[29] = 124;
				array2[29] = 96;
				array2[29] = 163;
				array2[29] = 91;
				array2[29] = 105;
				array2[29] = 220;
				array2[30] = 151;
				array2[30] = 117;
				array2[30] = 190;
				array2[30] = 166;
				array2[30] = 205;
				array2[31] = 148;
				array2[31] = 97;
				array2[31] = 63;
				array2[31] = 81;
				array2[31] = 132;
				array2[31] = 181;
				byte[] array3 = array2;
				byte[] array4 = new byte[16];
				array4[0] = 142;
				array4[0] = 88;
				array4[0] = 176;
				array4[0] = 10;
				array4[1] = 92;
				array4[1] = 123;
				array4[1] = 162;
				array4[1] = 134;
				array4[1] = 128;
				array4[1] = 239;
				array4[2] = 161;
				array4[2] = 180;
				array4[2] = 32;
				array4[3] = 228;
				array4[3] = 181;
				array4[3] = 108;
				array4[3] = 142;
				array4[3] = 105;
				array4[4] = 140;
				array4[4] = 22;
				array4[4] = 126;
				array4[4] = 228;
				array4[5] = 152;
				array4[5] = 111;
				array4[5] = 45;
				array4[6] = 93;
				array4[6] = 99;
				array4[6] = 152;
				array4[6] = 148;
				array4[6] = 133;
				array4[6] = 46;
				array4[7] = 33;
				array4[7] = 175;
				array4[7] = 116;
				array4[7] = 120;
				array4[7] = 125;
				array4[7] = 149;
				array4[8] = 128;
				array4[8] = 125;
				array4[8] = 110;
				array4[8] = 179;
				array4[9] = 109;
				array4[9] = 43;
				array4[9] = 81;
				array4[9] = 143;
				array4[9] = 169;
				array4[10] = 118;
				array4[10] = 48;
				array4[10] = 182;
				array4[10] = 143;
				array4[10] = 86;
				array4[10] = 20;
				array4[11] = 143;
				array4[11] = 80;
				array4[11] = 132;
				array4[11] = 173;
				array4[12] = 96;
				array4[12] = 46;
				array4[12] = 108;
				array4[13] = 31;
				array4[13] = 143;
				array4[13] = 206;
				array4[14] = 91;
				array4[14] = 159;
				array4[14] = 144;
				array4[14] = 20;
				array4[15] = 89;
				array4[15] = 128;
				array4[15] = 162;
				array4[15] = 131;
				array4[15] = 248;
				byte[] array5 = array4;
				Array.Reverse(array5);
				byte[] publicKeyToken = Class18.assembly_0.GetName().GetPublicKeyToken();
				if (publicKeyToken != null && publicKeyToken.Length > 0)
				{
					array5[1] = publicKeyToken[0];
					array5[3] = publicKeyToken[1];
					array5[5] = publicKeyToken[2];
					array5[7] = publicKeyToken[3];
					array5[9] = publicKeyToken[4];
					array5[11] = publicKeyToken[5];
					array5[13] = publicKeyToken[6];
					array5[15] = publicKeyToken[7];
				}
				for (int i = 0; i < array5.Length; i++)
				{
					array3[i] ^= array5[i];
				}
				if (int_5 == -1)
				{
					SymmetricAlgorithm symmetricAlgorithm = Class18.smethod_7();
					symmetricAlgorithm.Mode = CipherMode.CBC;
					ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(array, 0, array.Length);
					cryptoStream.FlushFinalBlock();
					Class18.byte_1 = memoryStream.ToArray();
					memoryStream.Close();
					cryptoStream.Close();
					array = Class18.byte_1;
				}
				int num = array.Length % 4;
				int num2 = array.Length / 4;
				byte[] array6 = new byte[array.Length];
				int num3 = array3.Length / 4;
				uint num4 = 0U;
				if (num > 0)
				{
					num2++;
				}
				for (int j = 0; j < num2; j++)
				{
					int num5 = j % num3;
					int num6 = j * 4;
					uint num7 = (uint)(num5 * 4);
					uint num8 = (uint)((int)array3[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array3[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array3[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array3[(int)((UIntPtr)num7)]);
					uint num9 = 255U;
					int num10 = 0;
					uint num11;
					if (j == num2 - 1 && num > 0)
					{
						num11 = 0U;
						num4 += num8;
						for (int k = 0; k < num; k++)
						{
							if (k > 0)
							{
								num11 <<= 8;
							}
							num11 |= (uint)array[array.Length - (1 + k)];
						}
					}
					else
					{
						num4 += num8;
						num7 = (uint)num6;
						num11 = (uint)((int)array[(int)((UIntPtr)(num7 + 3U))] << 24 | (int)array[(int)((UIntPtr)(num7 + 2U))] << 16 | (int)array[(int)((UIntPtr)(num7 + 1U))] << 8 | (int)array[(int)((UIntPtr)num7)]);
					}
					uint num12 = num4;
					uint num13 = num12;
					uint num14 = num12;
					num14 ^= num14 >> 2;
					num14 += 3001545299U;
					num14 ^= num14 << 9;
					num14 += 1968981981U;
					num14 ^= num14 >> 15;
					num14 += 2780929904U;
					num14 = 3991453694U - num14;
					num12 = num13 + (uint)num14;
					num4 = num12;
					if (j == num2 - 1 && num > 0)
					{
						uint num15 = num4 ^ num11;
						for (int l = 0; l < num; l++)
						{
							if (l > 0)
							{
								num9 <<= 8;
								num10 += 8;
							}
							array6[num6 + l] = (byte)((num15 & num9) >> num10);
						}
					}
					else
					{
						uint num16 = num4 ^ num11;
						array6[num6] = (byte)(num16 & 255U);
						array6[num6 + 1] = (byte)((num16 & 65280U) >> 8);
						array6[num6 + 2] = (byte)((num16 & 16711680U) >> 16);
						array6[num6 + 3] = (byte)((num16 & 4278190080U) >> 24);
					}
				}
				Class18.byte_1 = array6;
			}
			int count = BitConverter.ToInt32(Class18.byte_1, int_5);
			try
			{
				return Encoding.Unicode.GetString(Class18.byte_1, int_5 + 4, count);
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002DC70 File Offset: 0x0002BE70
		[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
		internal static string smethod_12(string string_1)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(string_1);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002DCA0 File Offset: 0x0002BEA0
		private static void smethod_13()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002DCCC File Offset: 0x0002BECC
		private static Delegate smethod_14(IntPtr intptr_3, Type type_0)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[]
			{
				intptr_3,
				type_0
			});
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002DD30 File Offset: 0x0002BF30
		internal static object smethod_15(Assembly assembly_1)
		{
			try
			{
				if (File.Exists(((Assembly)assembly_1).Location))
				{
					return ((Assembly)assembly_1).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
				{
					return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
		private static byte[] smethod_16(string string_1)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				long length = fileStream.Length;
				int i = (int)length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002DEA8 File Offset: 0x0002C0A8
		[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
		private static byte[] smethod_17(byte[] byte_4)
		{
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class18.smethod_7();
			symmetricAlgorithm.Key = new byte[]
			{
				210,
				196,
				97,
				252,
				145,
				129,
				227,
				169,
				172,
				252,
				43,
				253,
				149,
				224,
				69,
				161,
				72,
				106,
				10,
				51,
				150,
				6,
				14,
				50,
				89,
				31,
				136,
				16,
				140,
				40,
				95,
				160
			};
			symmetricAlgorithm.IV = new byte[]
			{
				237,
				242,
				160,
				42,
				144,
				73,
				30,
				234,
				158,
				35,
				11,
				20,
				74,
				32,
				183,
				182
			};
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_4, 0, byte_4.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000050DC File Offset: 0x000032DC
		private byte[] method_1()
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000050DC File Offset: 0x000032DC
		private byte[] method_2()
		{
			return null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002DF18 File Offset: 0x0002C118
		private byte[] method_3()
		{
			string text = "{11111-22222-20001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002DF58 File Offset: 0x0002C158
		private byte[] method_4()
		{
			string text = "{11111-22222-20001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002DF98 File Offset: 0x0002C198
		private byte[] method_5()
		{
			string text = "{11111-22222-30001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		private byte[] method_6()
		{
			string text = "{11111-22222-30001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0002E018 File Offset: 0x0002C218
		internal byte[] method_7()
		{
			string text = "{11111-22222-40001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0002E058 File Offset: 0x0002C258
		internal byte[] method_8()
		{
			string text = "{11111-22222-40001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000050DC File Offset: 0x000032DC
		internal byte[] method_9()
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000050DC File Offset: 0x000032DC
		internal byte[] method_10()
		{
			return null;
		}

		// Token: 0x04000350 RID: 848
		private static Assembly assembly_0;

		// Token: 0x04000351 RID: 849
		private static uint[] uint_0;

		// Token: 0x04000352 RID: 850
		private static IntPtr intptr_0;

		// Token: 0x04000353 RID: 851
		private static int int_0;

		// Token: 0x04000354 RID: 852
		private static bool bool_0;

		// Token: 0x04000355 RID: 853
		private static int int_1;

		// Token: 0x04000356 RID: 854
		private static int int_2;

		// Token: 0x04000357 RID: 855
		private static int int_3;

		// Token: 0x04000358 RID: 856
		private static bool bool_1;

		// Token: 0x04000359 RID: 857
		private static bool bool_2;

		// Token: 0x0400035A RID: 858
		[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
		private static bool bool_3;

		// Token: 0x0400035B RID: 859
		private static int[] int_4;

		// Token: 0x0400035C RID: 860
		private static string[] string_0;

		// Token: 0x0400035D RID: 861
		private static byte[] byte_0;

		// Token: 0x0400035E RID: 862
		private static bool bool_4;

		// Token: 0x0400035F RID: 863
		private static bool bool_5 = false;

		// Token: 0x04000360 RID: 864
		private static IntPtr intptr_1;

		// Token: 0x04000361 RID: 865
		private static SortedList sortedList_0;

		// Token: 0x04000362 RID: 866
		private static long long_0;

		// Token: 0x04000363 RID: 867
		private static byte[] byte_1;

		// Token: 0x04000364 RID: 868
		private static bool bool_6;

		// Token: 0x04000365 RID: 869
		private static byte[] byte_2;

		// Token: 0x04000366 RID: 870
		internal static object object_0;

		// Token: 0x04000367 RID: 871
		internal static Hashtable hashtable_0;

		// Token: 0x04000368 RID: 872
		private static IntPtr intptr_2;

		// Token: 0x04000369 RID: 873
		private static byte[] byte_3;

		// Token: 0x0400036A RID: 874
		private static long long_1;

		// Token: 0x0400036B RID: 875
		internal static object object_1;

		// Token: 0x02000091 RID: 145
		internal class Attribute0 : Attribute
		{
			// Token: 0x06000563 RID: 1379 RVA: 0x000050E7 File Offset: 0x000032E7
			[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
			public Attribute0(object res)
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x02000092 RID: 146
			internal class Class19<T>
			{
				// Token: 0x06000564 RID: 1380 RVA: 0x00002354 File Offset: 0x00000554
				public Class19()
				{
					Class21.smethod_0();
					base..ctor();
				}
			}
		}

		// Token: 0x02000093 RID: 147
		internal class Class20
		{
			// Token: 0x06000565 RID: 1381 RVA: 0x0002E098 File Offset: 0x0002C298
			[Class18.Attribute0(typeof(BroadcasterTest<object>[]))]
			internal static string smethod_0(string string_0, string string_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(string_0);
				byte[] array = bytes;
				byte[] key = new byte[]
				{
					82,
					102,
					104,
					110,
					32,
					77,
					24,
					34,
					118,
					181,
					51,
					17,
					18,
					51,
					12,
					109,
					10,
					32,
					77,
					24,
					34,
					158,
					161,
					41,
					97,
					28,
					118,
					181,
					5,
					25,
					1,
					88
				};
				byte[] iv = Class18.smethod_9(Encoding.Unicode.GetBytes(string_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = Class18.smethod_7();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iv;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00002354 File Offset: 0x00000554
			public Class20()
			{
				Class21.smethod_0();
				base..ctor();
			}
		}

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000568 RID: 1384
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint Delegate3(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600056C RID: 1388
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr Delegate4();

		// Token: 0x02000096 RID: 150
		internal struct Struct5
		{
			// Token: 0x0400036C RID: 876
			internal bool bool_0;

			// Token: 0x0400036D RID: 877
			internal byte[] byte_0;
		}

		// Token: 0x02000097 RID: 151
		[Flags]
		private enum Enum0
		{

		}
	}
}
