using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000003 RID: 3
	public static class Worker
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000059A0 File Offset: 0x00003BA0
		public static string InsertList(string instance, Array counter, byte[] consumer)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(counter, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = consumer;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(instance);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array2, 0, array2.Length);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00005A30 File Offset: 0x00003C30
		public static string StopList(string def, Array selection, byte[] control)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[32];
			Array.Copy(selection, 0, array, 0, 32);
			aes.Key = array;
			aes.IV = control;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array2 = Convert.FromBase64String(def);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array3 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array3, 0, array3.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}
	}
}
