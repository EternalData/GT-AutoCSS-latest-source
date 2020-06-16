using System;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000073 RID: 115
	public class ProccesorItem
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x0000433D File Offset: 0x0000253D
		[CompilerGenerated]
		public void StopIndexer(string task)
		{
			this._RuleItem = task;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00004346 File Offset: 0x00002546
		[CompilerGenerated]
		public string InsertIndexer()
		{
			return this._RuleItem;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000434E File Offset: 0x0000254E
		[CompilerGenerated]
		public void OrderIndexer(string info)
		{
			this.poolItem = info;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00004357 File Offset: 0x00002557
		[CompilerGenerated]
		public string ValidateIndexer()
		{
			return this.poolItem;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000435F File Offset: 0x0000255F
		[CompilerGenerated]
		public void PopIndexer(bool doinit)
		{
			this.modelItem = doinit;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00004368 File Offset: 0x00002568
		[CompilerGenerated]
		public bool SelectIndexer()
		{
			return this.modelItem;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00004370 File Offset: 0x00002570
		[CompilerGenerated]
		public void PrintIndexer(bool lastopen)
		{
			this.m_MappingItem = lastopen;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00004379 File Offset: 0x00002579
		[CompilerGenerated]
		public bool VerifyIndexer()
		{
			return this.m_MappingItem;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00004381 File Offset: 0x00002581
		[CompilerGenerated]
		public void PushIndexer(bool isinstance)
		{
			this.m_MockItem = isinstance;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000438A File Offset: 0x0000258A
		[CompilerGenerated]
		public bool SortIndexer()
		{
			return this.m_MockItem;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00004392 File Offset: 0x00002592
		[CompilerGenerated]
		public void ConnectIndexer(bool extractvar1)
		{
			this._WriterItem = extractvar1;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000439B File Offset: 0x0000259B
		[CompilerGenerated]
		public bool CallIndexer()
		{
			return this._WriterItem;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000043A3 File Offset: 0x000025A3
		public ProccesorItem(string setup, string visitor, bool doserv, bool isv2, bool isres3, bool loadinit4)
		{
			Class21.smethod_0();
			base..ctor();
			this.StopIndexer(setup);
			this.OrderIndexer(visitor);
			this.PopIndexer(doserv);
			this.PrintIndexer(isv2);
			this.PushIndexer(isres3);
			this.ConnectIndexer(loadinit4);
		}

		// Token: 0x0400028F RID: 655
		[CompilerGenerated]
		private string _RuleItem;

		// Token: 0x04000290 RID: 656
		[CompilerGenerated]
		private string poolItem;

		// Token: 0x04000291 RID: 657
		[CompilerGenerated]
		private bool modelItem;

		// Token: 0x04000292 RID: 658
		[CompilerGenerated]
		private bool m_MappingItem;

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		private bool m_MockItem;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private bool _WriterItem;
	}
}
