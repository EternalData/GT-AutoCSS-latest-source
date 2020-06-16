using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000081 RID: 129
	public class PolicyToken : IDisposable
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x000048E9 File Offset: 0x00002AE9
		[CompilerGenerated]
		public string CompareMap()
		{
			return this._ProxyToken;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000048F1 File Offset: 0x00002AF1
		[CompilerGenerated]
		public void SearchMap(string first)
		{
			this._ProxyToken = first;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000048FA File Offset: 0x00002AFA
		[CompilerGenerated]
		public string CalcMap()
		{
			return this.m_DefinitionToken;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00004902 File Offset: 0x00002B02
		[CompilerGenerated]
		public void CheckMap(string reference)
		{
			this.m_DefinitionToken = reference;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0000490B File Offset: 0x00002B0B
		[CompilerGenerated]
		public string ComputeMap()
		{
			return this._ValueToken;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004913 File Offset: 0x00002B13
		[CompilerGenerated]
		public void RateMap(string reference)
		{
			this._ValueToken = reference;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0000491C File Offset: 0x00002B1C
		public PolicyToken()
		{
			Class21.smethod_0();
			base..ctor();
			this.webClient_0 = new WebClient();
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0002C5AC File Offset: 0x0002A7AC
		public void InitMap(string value)
		{
			PolicyToken.nameValueCollection_0.Add("username", this.CalcMap());
			PolicyToken.nameValueCollection_0.Add("avatar_url", this.ComputeMap());
			PolicyToken.nameValueCollection_0.Add("content", value);
			this.webClient_0.UploadValues(this.CompareMap(), PolicyToken.nameValueCollection_0);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00004934 File Offset: 0x00002B34
		public void Dispose()
		{
			this.webClient_0.Dispose();
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004941 File Offset: 0x00002B41
		// Note: this type is marked as 'beforefieldinit'.
		static PolicyToken()
		{
			Class21.smethod_0();
			PolicyToken.nameValueCollection_0 = new NameValueCollection();
		}

		// Token: 0x0400033E RID: 830
		private readonly WebClient webClient_0;

		// Token: 0x0400033F RID: 831
		private static NameValueCollection nameValueCollection_0;

		// Token: 0x04000340 RID: 832
		[CompilerGenerated]
		private string _ProxyToken;

		// Token: 0x04000341 RID: 833
		[CompilerGenerated]
		private string m_DefinitionToken;

		// Token: 0x04000342 RID: 834
		[CompilerGenerated]
		private string _ValueToken;
	}
}
