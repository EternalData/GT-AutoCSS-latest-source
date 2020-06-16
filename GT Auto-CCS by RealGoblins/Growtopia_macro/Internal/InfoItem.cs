using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000074 RID: 116
	public class InfoItem
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x000043DD File Offset: 0x000025DD
		[CompilerGenerated]
		public void RestartIndexer(string i)
		{
			this._ParserItem = i;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000043E6 File Offset: 0x000025E6
		[CompilerGenerated]
		public string CountIndexer()
		{
			return this._ParserItem;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000043EE File Offset: 0x000025EE
		[CompilerGenerated]
		public void CollectIndexer(CheckState setup)
		{
			this._RefItem = setup;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000043F7 File Offset: 0x000025F7
		[CompilerGenerated]
		public CheckState SetIndexer()
		{
			return this._RefItem;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000043FF File Offset: 0x000025FF
		public InfoItem(string value, CheckState caller)
		{
			Class21.smethod_0();
			base..ctor();
			value = value;
			this.CollectIndexer(caller);
		}

		// Token: 0x04000295 RID: 661
		[CompilerGenerated]
		private string _ParserItem;

		// Token: 0x04000296 RID: 662
		[CompilerGenerated]
		private CheckState _RefItem;
	}
}
