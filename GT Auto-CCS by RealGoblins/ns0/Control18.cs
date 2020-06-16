using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200004E RID: 78
	internal class Control18 : Control
	{
		// Token: 0x06000250 RID: 592 RVA: 0x000103A8 File Offset: 0x0000E5A8
		public Control18()
		{
			Class21.smethod_0();
			base..ctor();
			this.ForeColor = Color.DimGray;
			this.BackColor = Color.FromArgb(246, 246, 246);
			base.Size = new Size(33, 33);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x000103FC File Offset: 0x0000E5FC
		protected override void OnPaint(PaintEventArgs asset)
		{
			asset.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			asset.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			asset.Graphics.FillEllipse(new SolidBrush(Color.Gray), new Rectangle(1, 1, 29, 29));
			asset.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(246, 246, 246)), new Rectangle(3, 3, 25, 25));
			asset.Graphics.DrawString("¡", new Font("Segoe UI", 25f, FontStyle.Bold), new SolidBrush(Color.Gray), new Rectangle(4, -14, base.Width, 43), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			});
		}
	}
}
