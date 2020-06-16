using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200004F RID: 79
	internal class Control19 : Control
	{
		// Token: 0x06000252 RID: 594 RVA: 0x000103A8 File Offset: 0x0000E5A8
		public Control19()
		{
			Class21.smethod_0();
			base..ctor();
			this.ForeColor = Color.DimGray;
			this.BackColor = Color.FromArgb(246, 246, 246);
			base.Size = new Size(33, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000104C4 File Offset: 0x0000E6C4
		protected override void OnPaint(PaintEventArgs first)
		{
			first.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			first.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			first.Graphics.FillEllipse(new SolidBrush(Color.Gray), new Rectangle(1, 1, 29, 29));
			first.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(246, 246, 246)), new Rectangle(3, 3, 25, 25));
			first.Graphics.DrawString("ü", new Font("Wingdings", 25f, FontStyle.Bold), new SolidBrush(Color.Gray), new Rectangle(0, -3, base.Width, 43), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			});
		}
	}
}
