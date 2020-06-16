using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000046 RID: 70
	internal class Control15 : Control
	{
		// Token: 0x06000213 RID: 531 RVA: 0x000036DD File Offset: 0x000018DD
		public Color method_0()
		{
			return this.solidBrush_0.Color;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000036EA File Offset: 0x000018EA
		public void method_1(Color color_0)
		{
			this.solidBrush_0.Color = color_0;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000036F8 File Offset: 0x000018F8
		public Color method_2()
		{
			return this.solidBrush_1.Color;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003705 File Offset: 0x00001905
		public void method_3(Color color_0)
		{
			this.solidBrush_1.Color = color_0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00003713 File Offset: 0x00001913
		public int method_4()
		{
			return this.timer_0.Interval;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003720 File Offset: 0x00001920
		public void method_5(int int_1)
		{
			this.timer_0.Interval = int_1;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000372E File Offset: 0x0000192E
		protected override void OnSizeChanged(EventArgs key)
		{
			base.OnSizeChanged(key);
			this.method_6();
			this.method_8();
			this.method_7();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003749 File Offset: 0x00001949
		protected override void OnEnabledChanged(EventArgs def)
		{
			base.OnEnabledChanged(def);
			this.timer_0.Enabled = base.Enabled;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003763 File Offset: 0x00001963
		protected override void OnHandleCreated(EventArgs instance)
		{
			base.OnHandleCreated(instance);
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_0.Start();
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000378E File Offset: 0x0000198E
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.int_0.Equals(0))
			{
				this.int_0 = this.object_0.Length - 1;
			}
			else
			{
				this.int_0--;
			}
			base.Invalidate(false);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000F638 File Offset: 0x0000D838
		public Control15()
		{
			Class21.smethod_0();
			this.solidBrush_0 = new SolidBrush(Color.DarkGray);
			this.solidBrush_1 = new SolidBrush(Color.DimGray);
			this.timer_0 = new Timer();
			this.bufferedGraphicsContext_0 = BufferedGraphicsManager.Current;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.Size = new Size(80, 80);
			this.Text = string.Empty;
			this.MinimumSize = new Size(80, 80);
			this.method_7();
			this.timer_0.Interval = 100;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000F380 File Offset: 0x0000D580
		private void method_6()
		{
			int num = Math.Max(base.Width, base.Height);
			base.Size = new Size(num, num);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		private void method_7()
		{
			Stack<PointF> stack = new Stack<PointF>();
			PointF pointF_ = new PointF((float)base.Width / 2f, (float)base.Height / 2f);
			for (float num = 0f; num < 360f; num += 45f)
			{
				this.method_10(pointF_, (int)Math.Round((double)base.Width / 2.0 - 15.0), (double)num);
				PointF item = this.method_11();
				item = new PointF(item.X - 7.5f, item.Y - 7.5f);
				stack.Push(item);
			}
			this.object_0 = stack.ToArray();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000F784 File Offset: 0x0000D984
		private void method_8()
		{
			if (base.Width > 0 && base.Height > 0)
			{
				Size maximumBuffer = new Size(base.Width + 1, base.Height + 1);
				this.bufferedGraphicsContext_0.MaximumBuffer = maximumBuffer;
				this.bufferedGraphics_0 = this.bufferedGraphicsContext_0.Allocate(base.CreateGraphics(), base.ClientRectangle);
				this.bufferedGraphics_0.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		protected override void OnPaint(PaintEventArgs v)
		{
			base.OnPaint(v);
			this.bufferedGraphics_0.Graphics.Clear(this.BackColor);
			int num = this.object_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (this.int_0 == i)
				{
					this.bufferedGraphics_0.Graphics.FillEllipse(this.solidBrush_1, this.object_0[i].X, this.object_0[i].Y, 15f, 15f);
				}
				else
				{
					this.bufferedGraphics_0.Graphics.FillEllipse(this.solidBrush_0, this.object_0[i].X, this.object_0[i].Y, 15f, 15f);
				}
			}
			this.bufferedGraphics_0.Render(v.Graphics);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000037C5 File Offset: 0x000019C5
		private T method_9<T>(ref T gparam_0, T gparam_1)
		{
			gparam_0 = gparam_1;
			return gparam_1;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000F8DC File Offset: 0x0000DADC
		private void method_10(PointF pointF_1, int int_1, double double_2)
		{
			double num = 3.1415926535897931 * double_2 / 180.0;
			this.pointF_0 = pointF_1;
			this.double_0 = this.method_9<double>(ref this.double_1, (double)int_1);
			this.double_0 = Math.Sin(num) * this.double_0;
			this.double_1 = Math.Cos(num) * this.double_1;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000F940 File Offset: 0x0000DB40
		private PointF method_11()
		{
			float y = Convert.ToSingle((double)this.pointF_0.Y + this.double_0);
			return new PointF(Convert.ToSingle((double)this.pointF_0.X + this.double_1), y);
		}

		// Token: 0x04000100 RID: 256
		private readonly SolidBrush solidBrush_0;

		// Token: 0x04000101 RID: 257
		private readonly SolidBrush solidBrush_1;

		// Token: 0x04000102 RID: 258
		private readonly Timer timer_0;

		// Token: 0x04000103 RID: 259
		private object object_0;

		// Token: 0x04000104 RID: 260
		private BufferedGraphics bufferedGraphics_0;

		// Token: 0x04000105 RID: 261
		private int int_0;

		// Token: 0x04000106 RID: 262
		private readonly BufferedGraphicsContext bufferedGraphicsContext_0;

		// Token: 0x04000107 RID: 263
		private double double_0;

		// Token: 0x04000108 RID: 264
		private double double_1;

		// Token: 0x04000109 RID: 265
		private PointF pointF_0;
	}
}
