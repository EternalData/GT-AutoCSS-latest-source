using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000042 RID: 66
	internal class Class10 : ListView
	{
		// Token: 0x060001F5 RID: 501
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

		// Token: 0x060001F6 RID: 502 RVA: 0x00003573 File Offset: 0x00001773
		public Class10()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			base.BorderStyle = BorderStyle.None;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000035A1 File Offset: 0x000017A1
		protected override void OnHandleCreated(EventArgs item)
		{
			Class10.SetWindowTheme(base.Handle, "explorer", null);
			base.OnHandleCreated(item);
		}
	}
}
