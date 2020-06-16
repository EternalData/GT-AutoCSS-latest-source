namespace Growtopia_macro.Internal
{
	// Token: 0x02000078 RID: 120
	public partial class MethodMethod : global::System.Windows.Forms.Form
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x0000461A File Offset: 0x0000281A
		protected override void Dispose(bool isitem)
		{
			if (isitem && this.idisposable_0 != null)
			{
				this.idisposable_0.Dispose();
			}
			base.Dispose(isitem);
			global::System.Windows.Forms.Application.DoEvents();
		}

		// Token: 0x040002BF RID: 703
		private global::System.IDisposable idisposable_0;
	}
}
