using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Growtopia_macro.Properties;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000076 RID: 118
	public partial class CallbackItem : Form
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x0000449D File Offset: 0x0000269D
		public CallbackItem()
		{
			Class21.smethod_0();
			base..ctor();
			this.InitializeComponent();
			this.iTalk_RichTextBox1.Text = ">The auto clicker clicks from start pos to end pos.\r\n\r\n>Click a macro to see which/what window(s) it’s attached to.\r\n\r\n>To enable a macro; tick the checkbox to the left of the name.\r\n\r\n>When selecting positions, remember to put Growtopia in FOREGROUND. Definition of FOREGROUND: the part of a view that is nearest to the observer, especially in a picture or photograph. In front of GT-Auto-CCS.\r\n\r\n>To attach a macro to a window; tap the macro/select it and check the windows you wish to attach the macro to.\r\n\r\n>To make sure your coordinates/positions are correct; check that they are: higher than 0 but lower than the growtopia window size.\r\n";
			this.iTalk_RichTextBox2.Text = "Instructions of how to use the unbanner:\r\n\r\n1. Close all growtopia windows.\r\n\r\n2. Press 'Unban' and wait.\r\n\r\n3. Connect to a VPN to bypass the ip ban. Select a VPN in the list and click connect.\r\n\r\n4. Now you're done! Open growtopia and enjoy. Note, if you can't log-on to growtopia, try restarting your router and PC.\r\n";
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000023D9 File Offset: 0x000005D9
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003A40 File Offset: 0x00001C40
		private void iTalk_Button_21_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000023D9 File Offset: 0x000005D9
		private void mouse_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000044D0 File Offset: 0x000026D0
		protected override void WndProc(ref Message value)
		{
			base.WndProc(ref value);
			if (value.Msg == 132)
			{
				value.Result = (IntPtr)2;
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000023D9 File Offset: 0x000005D9
		private void iTalk_RichTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000023D9 File Offset: 0x000005D9
		private void iTalk_RichTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000044F2 File Offset: 0x000026F2
		public void RegisterIndexer(string init)
		{
			this.iTalk_TabControl1.SelectTab(init);
		}
	}
}
