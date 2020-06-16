using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000080 RID: 128
	public class TokenToken : IDisposable
	{
		// Token: 0x060004BF RID: 1215 RVA: 0x00004880 File Offset: 0x00002A80
		[CompilerGenerated]
		public string DisableMap()
		{
			return this.m_DescriptorToken;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004888 File Offset: 0x00002A88
		[CompilerGenerated]
		public void PatchMap(string asset)
		{
			this.m_DescriptorToken = asset;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00004891 File Offset: 0x00002A91
		[CompilerGenerated]
		public string ViewMap()
		{
			return this._AttrToken;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00004899 File Offset: 0x00002A99
		[CompilerGenerated]
		public void StartMap(string instance)
		{
			this._AttrToken = instance;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000048A2 File Offset: 0x00002AA2
		[CompilerGenerated]
		public string ResetMap()
		{
			return this._SpecificationToken;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000048AA File Offset: 0x00002AAA
		[CompilerGenerated]
		public void CalculateMap(string asset)
		{
			this._SpecificationToken = asset;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000048B3 File Offset: 0x00002AB3
		public TokenToken()
		{
			Class21.smethod_0();
			base..ctor();
			this.webClient_0 = new WebClient();
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0002C54C File Offset: 0x0002A74C
		public void DefineMap(string setup)
		{
			TokenToken.nameValueCollection_0.Add("username", this.ViewMap());
			TokenToken.nameValueCollection_0.Add("avatar_url", this.ResetMap());
			TokenToken.nameValueCollection_0.Add("content", setup);
			this.webClient_0.UploadValues(this.DisableMap(), TokenToken.nameValueCollection_0);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000048CB File Offset: 0x00002ACB
		public void Dispose()
		{
			this.webClient_0.Dispose();
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000048D8 File Offset: 0x00002AD8
		// Note: this type is marked as 'beforefieldinit'.
		static TokenToken()
		{
			Class21.smethod_0();
			TokenToken.nameValueCollection_0 = new NameValueCollection();
		}

		// Token: 0x04000339 RID: 825
		private readonly WebClient webClient_0;

		// Token: 0x0400033A RID: 826
		private static NameValueCollection nameValueCollection_0;

		// Token: 0x0400033B RID: 827
		[CompilerGenerated]
		private string m_DescriptorToken;

		// Token: 0x0400033C RID: 828
		[CompilerGenerated]
		private string _AttrToken;

		// Token: 0x0400033D RID: 829
		[CompilerGenerated]
		private string _SpecificationToken;
	}
}
