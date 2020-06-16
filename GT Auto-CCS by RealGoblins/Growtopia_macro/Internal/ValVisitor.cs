using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000051 RID: 81
	public partial class ValVisitor : Form
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00003A05 File Offset: 0x00001C05
		public ValVisitor()
		{
			Class21.smethod_0();
			base..ctor();
			this.method_2();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00003A18 File Offset: 0x00001C18
		public void InstantiateMethod()
		{
			base.BeginInvoke(new MethodInvoker(ValVisitor.CodeToken.configToken.AwakeDescriptor));
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00003A40 File Offset: 0x00001C40
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00010998 File Offset: 0x0000EB98
		private void method_2()
		{
			ValVisitor.<InitializeComponent>d__6 <InitializeComponent>d__;
			<InitializeComponent>d__.<>4__this = this;
			<InitializeComponent>d__.<>t__builder = ValVisitor.smethod_0();
			<InitializeComponent>d__.<>1__state = -1;
			AsyncVoidMethodBuilder <>t__builder = <InitializeComponent>d__.<>t__builder;
			<>t__builder.Start<ValVisitor.<InitializeComponent>d__6>(ref <InitializeComponent>d__);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000109D4 File Offset: 0x0000EBD4
		internal static AsyncVoidMethodBuilder smethod_0()
		{
			return default(AsyncVoidMethodBuilder);
		}

		// Token: 0x0400011E RID: 286
		private object object_0;

		// Token: 0x0400011F RID: 287
		private object object_1;

		// Token: 0x04000120 RID: 288
		private object object_2;

		// Token: 0x04000121 RID: 289
		private object object_3;

		// Token: 0x04000122 RID: 290
		private object object_4;

		// Token: 0x04000123 RID: 291
		private object object_5;

		// Token: 0x02000052 RID: 82
		[CompilerGenerated]
		[Serializable]
		private sealed class CodeToken
		{
			// Token: 0x06000268 RID: 616 RVA: 0x00003A67 File Offset: 0x00001C67
			// Note: this type is marked as 'beforefieldinit'.
			static CodeToken()
			{
				Class21.smethod_0();
				ValVisitor.CodeToken.configToken = new ValVisitor.CodeToken();
			}

			// Token: 0x06000269 RID: 617 RVA: 0x00002354 File Offset: 0x00000554
			public CodeToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x0600026A RID: 618 RVA: 0x00003A78 File Offset: 0x00001C78
			internal void AwakeDescriptor()
			{
				new MethodMethod().Show();
			}

			// Token: 0x04000124 RID: 292
			public static readonly ValVisitor.CodeToken configToken;

			// Token: 0x04000125 RID: 293
			public static MethodInvoker printerToken;
		}
	}
}
