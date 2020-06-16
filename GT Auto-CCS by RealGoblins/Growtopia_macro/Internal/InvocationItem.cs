using System;
using System.Runtime.CompilerServices;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000075 RID: 117
	public class InvocationItem
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00004416 File Offset: 0x00002616
		[CompilerGenerated]
		public void UpdateIndexer(string value)
		{
			this.classItem = value;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000441F File Offset: 0x0000261F
		[CompilerGenerated]
		public string MoveIndexer()
		{
			return this.classItem;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00004427 File Offset: 0x00002627
		[CompilerGenerated]
		public void ReadIndexer(int var1high)
		{
			this.helperItem = var1high;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00004430 File Offset: 0x00002630
		[CompilerGenerated]
		public int ReflectIndexer()
		{
			return this.helperItem;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00004438 File Offset: 0x00002638
		[CompilerGenerated]
		public void PublishIndexer(int ID_info)
		{
			this.creatorItem = ID_info;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00004441 File Offset: 0x00002641
		[CompilerGenerated]
		public int DestroyIndexer()
		{
			return this.creatorItem;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004449 File Offset: 0x00002649
		[CompilerGenerated]
		public void FindIndexer(int num_def)
		{
			this.clientItem = num_def;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00004452 File Offset: 0x00002652
		[CompilerGenerated]
		public int TestIndexer()
		{
			return this.clientItem;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000445A File Offset: 0x0000265A
		[CompilerGenerated]
		public void ExcludeIndexer(int idx_param)
		{
			this._PrototypeItem = idx_param;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00004463 File Offset: 0x00002663
		[CompilerGenerated]
		public int LogoutIndexer()
		{
			return this._PrototypeItem;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000446B File Offset: 0x0000266B
		public InvocationItem(string init, int visY, int util_high, int connection2size, int indexcounter3)
		{
			Class21.smethod_0();
			base..ctor();
			this.UpdateIndexer(init);
			this.ReadIndexer(visY);
			this.PublishIndexer(util_high);
			this.FindIndexer(connection2size);
			this.ExcludeIndexer(indexcounter3);
		}

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		private string classItem;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		private int helperItem;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		private int creatorItem;

		// Token: 0x0400029A RID: 666
		[CompilerGenerated]
		private int clientItem;

		// Token: 0x0400029B RID: 667
		[CompilerGenerated]
		private int _PrototypeItem;
	}
}
