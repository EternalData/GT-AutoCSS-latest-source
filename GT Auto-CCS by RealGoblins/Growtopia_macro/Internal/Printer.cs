using System;
using System.Drawing;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000011 RID: 17
	public class Printer : Control
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000267F File Offset: 0x0000087F
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002687 File Offset: 0x00000887
		public int Value
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002696 File Offset: 0x00000896
		public int ManageList()
		{
			return this.int_1;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000269E File Offset: 0x0000089E
		public void ResetList(int def_start)
		{
			if (def_start == 0)
			{
				def_start = 1;
			}
			this.int_1 = def_start;
			base.Invalidate();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000023D9 File Offset: 0x000005D9
		protected override void OnPaintBackground(PaintEventArgs spec)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007340 File Offset: 0x00005540
		protected override void OnPaint(PaintEventArgs asset)
		{
			int num = base.Width * this.int_0 / this.int_1;
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					Tests.ValidateList(graphics, this.color_1, this.color_2, 1, 1, base.Width - 2, base.Height - 2);
					graphics.DrawRectangle(new Pen(this.color_1), 1, 1, num - 3, base.Height - 3);
					Tests.ValidateList(graphics, this.color_2, this.color_1, 2, 2, num - 4, base.Height - 4);
					graphics.DrawRectangle(new Pen(this.color_0), 0, 0, base.Width - 1, base.Height - 1);
					asset.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000744C File Offset: 0x0000564C
		public Printer()
		{
			Class21.smethod_0();
			this.int_1 = 100;
			this.color_0 = Color.FromArgb(31, 31, 31);
			this.color_1 = Color.FromArgb(41, 41, 41);
			this.color_2 = Color.FromArgb(51, 51, 51);
			this.color_3 = Color.FromArgb(0, 0, 0, 0);
			this.color_4 = Color.FromArgb(25, 255, 255, 255);
			base..ctor();
		}

		// Token: 0x0400003F RID: 63
		private int int_0;

		// Token: 0x04000040 RID: 64
		private int int_1;

		// Token: 0x04000041 RID: 65
		private Color color_0;

		// Token: 0x04000042 RID: 66
		private Color color_1;

		// Token: 0x04000043 RID: 67
		private Color color_2;

		// Token: 0x04000044 RID: 68
		private Color color_3;

		// Token: 0x04000045 RID: 69
		private Color color_4;
	}
}
