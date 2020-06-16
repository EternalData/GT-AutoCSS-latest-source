using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000044 RID: 68
	public class MethodVisitor : Control
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000035F6 File Offset: 0x000017F6
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000035FE File Offset: 0x000017FE
		public long Value
		{
			get
			{
				return this.long_0;
			}
			set
			{
				if (value > this.long_1)
				{
					value = this.long_1;
				}
				this.long_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000361E File Offset: 0x0000181E
		public long ReflectItem()
		{
			return this.long_1;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00003626 File Offset: 0x00001826
		public void ReadItem(long min_key)
		{
			if (min_key < 1L)
			{
				min_key = 1L;
			}
			this.long_1 = min_key;
			base.Invalidate();
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000364C File Offset: 0x0000184C
		public Color DestroyItem()
		{
			return this.color_0;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003654 File Offset: 0x00001854
		public void PublishItem(Color param)
		{
			this.color_0 = param;
			base.Invalidate();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003663 File Offset: 0x00001863
		public Color TestItem()
		{
			return this.color_1;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000366B File Offset: 0x0000186B
		public void FindItem(Color i)
		{
			this.color_1 = i;
			base.Invalidate();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000367A File Offset: 0x0000187A
		public MethodVisitor.RequestTargetKind LogoutItem()
		{
			return this.requestTargetKind_0;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00003682 File Offset: 0x00001882
		public void ExcludeItem(MethodVisitor.RequestTargetKind last)
		{
			this.requestTargetKind_0 = last;
			base.Invalidate();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003691 File Offset: 0x00001891
		protected override void OnResize(EventArgs ident)
		{
			base.OnResize(ident);
			this.method_0();
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000036A0 File Offset: 0x000018A0
		protected override void OnSizeChanged(EventArgs config)
		{
			base.OnSizeChanged(config);
			this.method_0();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00003007 File Offset: 0x00001207
		protected override void OnPaintBackground(PaintEventArgs init)
		{
			base.OnPaintBackground(init);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public MethodVisitor()
		{
			Class21.smethod_0();
			this.long_1 = 100L;
			this.color_0 = Color.FromArgb(92, 92, 92);
			this.color_1 = Color.FromArgb(92, 92, 92);
			base..ctor();
			base.Size = new Size(130, 130);
			this.Font = new Font("Segoe UI", 15f);
			this.MinimumSize = new Size(100, 100);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000F380 File Offset: 0x0000D580
		private void method_0()
		{
			int num = Math.Max(base.Width, base.Height);
			base.Size = new Size(num, num);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000036AF File Offset: 0x000018AF
		public void VisitItem(int first_High)
		{
			this.long_0 += (long)first_High;
			base.Invalidate();
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000036C6 File Offset: 0x000018C6
		public void MoveItem(int indexOfparam)
		{
			this.long_0 -= (long)indexOfparam;
			base.Invalidate();
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		protected override void OnPaint(PaintEventArgs v)
		{
			base.OnPaint(v);
			using (Bitmap bitmap = new Bitmap(base.Width, base.Height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.Clear(this.BackColor);
					using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, this.color_0, this.color_1, LinearGradientMode.ForwardDiagonal))
					{
						using (Pen pen = new Pen(linearGradientBrush, 14f))
						{
							MethodVisitor.RequestTargetKind requestTargetKind = this.requestTargetKind_0;
							if (requestTargetKind != (MethodVisitor.RequestTargetKind)0)
							{
								if (requestTargetKind == (MethodVisitor.RequestTargetKind)1)
								{
									pen.StartCap = LineCap.Flat;
									pen.EndCap = LineCap.Flat;
								}
							}
							else
							{
								pen.StartCap = LineCap.Round;
								pen.EndCap = LineCap.Round;
							}
							graphics.DrawArc(pen, 18, 18, base.Width - 35 - 2, base.Height - 35 - 2, -90, (int)Math.Round(360.0 / (double)this.long_1 * (double)this.long_0));
						}
					}
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(52, 52, 52), Color.FromArgb(52, 52, 52), LinearGradientMode.Vertical))
					{
						graphics.FillEllipse(linearGradientBrush2, 24, 24, base.Width - 48 - 1, base.Height - 48 - 1);
					}
					SizeF sizeF = graphics.MeasureString(Convert.ToString(Convert.ToInt32(100L / this.long_1 * this.long_0)), this.Font);
					graphics.DrawString(Convert.ToString(Convert.ToInt32(100L / this.long_1 * this.long_0)), this.Font, Brushes.White, (float)Convert.ToInt32((float)(base.Width / 2) - sizeF.Width / 2f), (float)Convert.ToInt32((float)(base.Height / 2) - sizeF.Height / 2f));
					v.Graphics.DrawImage(bitmap, 0, 0);
					graphics.Dispose();
					bitmap.Dispose();
				}
			}
		}

		// Token: 0x040000FA RID: 250
		private long long_0;

		// Token: 0x040000FB RID: 251
		private long long_1;

		// Token: 0x040000FC RID: 252
		private Color color_0;

		// Token: 0x040000FD RID: 253
		private Color color_1;

		// Token: 0x040000FE RID: 254
		private MethodVisitor.RequestTargetKind requestTargetKind_0;

		// Token: 0x02000045 RID: 69
		public enum RequestTargetKind
		{

		}
	}
}
