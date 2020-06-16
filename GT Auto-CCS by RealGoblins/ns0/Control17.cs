using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000048 RID: 72
	[DefaultEvent("ValueChanged")]
	internal class Control17 : Control
	{
		// Token: 0x06000229 RID: 553 RVA: 0x000037F3 File Offset: 0x000019F3
		public int method_0()
		{
			return this.int_1;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000037FB File Offset: 0x000019FB
		public void method_1(int int_4)
		{
			if (int_4 >= this.int_2)
			{
				int_4 = this.int_2 - 10;
			}
			if (this.int_3 < int_4)
			{
				this.int_3 = int_4;
			}
			this.int_1 = int_4;
			base.Invalidate();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000382E File Offset: 0x00001A2E
		public int method_2()
		{
			return this.int_2;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00003836 File Offset: 0x00001A36
		public void method_3(int int_4)
		{
			if (int_4 <= this.int_1)
			{
				int_4 = this.int_1 + 10;
			}
			if (this.int_3 > int_4)
			{
				this.int_3 = int_4;
			}
			this.int_2 = int_4;
			base.Invalidate();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000FF28 File Offset: 0x0000E128
		[CompilerGenerated]
		public void PopMethod(Control17.IssuerToken i)
		{
			Control17.IssuerToken issuerToken = this._FacadeVisitor;
			Control17.IssuerToken issuerToken2;
			do
			{
				issuerToken2 = issuerToken;
				Control17.IssuerToken value = (Control17.IssuerToken)Delegate.Combine(issuerToken2, i);
				issuerToken = Interlocked.CompareExchange<Control17.IssuerToken>(ref this._FacadeVisitor, value, issuerToken2);
			}
			while (issuerToken != issuerToken2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000FF60 File Offset: 0x0000E160
		[CompilerGenerated]
		public void CancelMethod(Control17.IssuerToken last)
		{
			Control17.IssuerToken issuerToken = this._FacadeVisitor;
			Control17.IssuerToken issuerToken2;
			do
			{
				issuerToken2 = issuerToken;
				Control17.IssuerToken value = (Control17.IssuerToken)Delegate.Remove(issuerToken2, last);
				issuerToken = Interlocked.CompareExchange<Control17.IssuerToken>(ref this._FacadeVisitor, value, issuerToken2);
			}
			while (issuerToken != issuerToken2);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00003869 File Offset: 0x00001A69
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000FF98 File Offset: 0x0000E198
		public int Int32_0
		{
			get
			{
				return this.int_3;
			}
			set
			{
				if (this.int_3 != value)
				{
					if (value < this.int_1)
					{
						this.int_3 = this.int_1;
					}
					else if (value > this.int_2)
					{
						this.int_3 = this.int_2;
					}
					else
					{
						this.int_3 = value;
					}
					base.Invalidate();
					if (this._FacadeVisitor != null)
					{
						this._FacadeVisitor();
					}
				}
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00003871 File Offset: 0x00001A71
		public Control17.LsBreakJust method_4()
		{
			return this.lsBreakJust_0;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00003879 File Offset: 0x00001A79
		public void method_5(Control17.LsBreakJust lsBreakJust_1)
		{
			this.lsBreakJust_0 = lsBreakJust_1;
			base.Invalidate();
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0000389A File Offset: 0x00001A9A
		[Browsable(false)]
		public float Single_0
		{
			get
			{
				return (float)((double)this.int_3 / (double)this.lsBreakJust_0);
			}
			set
			{
				this.Int32_0 = (int)Math.Round((double)(value * (float)this.lsBreakJust_0));
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000038B2 File Offset: 0x00001AB2
		public Color method_6()
		{
			return this.color_0;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000038BA File Offset: 0x00001ABA
		public void method_7(Color color_1)
		{
			this.color_0 = color_1;
			base.Invalidate();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000038C9 File Offset: 0x00001AC9
		public bool method_8()
		{
			return this.bool_1;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000038D1 File Offset: 0x00001AD1
		public void method_9(bool bool_4)
		{
			this.bool_1 = bool_4;
			base.Invalidate();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000038E0 File Offset: 0x00001AE0
		public bool method_10()
		{
			return this.bool_2;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000038E8 File Offset: 0x00001AE8
		public void method_11(bool bool_4)
		{
			this.bool_2 = bool_4;
			if (this.bool_2)
			{
				base.Height = 40;
			}
			else
			{
				base.Height = 22;
			}
			base.Invalidate();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00003911 File Offset: 0x00001B11
		public bool method_12()
		{
			return this.bool_3;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00003919 File Offset: 0x00001B19
		public void method_13(bool bool_4)
		{
			this.bool_3 = bool_4;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000FFFC File Offset: 0x0000E1FC
		protected override void OnMouseMove(MouseEventArgs v)
		{
			base.OnMouseMove(v);
			if (this.bool_0 && v.X > -1 && v.X < base.Width + 1)
			{
				this.Int32_0 = this.int_1 + (int)Math.Round((double)(this.int_2 - this.int_1) * ((double)v.X / (double)base.Width));
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00010064 File Offset: 0x0000E264
		protected override void OnMouseDown(MouseEventArgs spec)
		{
			base.OnMouseDown(spec);
			if (spec.Button == MouseButtons.Left)
			{
				this.int_0 = (int)Math.Round((double)(this.int_3 - this.int_1) / (double)(this.int_2 - this.int_1) * (double)(base.Width - 11));
				this.rectangle_0 = new Rectangle(this.int_0, 0, 10, 20);
				this.bool_0 = this.rectangle_0.Contains(spec.Location);
				if (this.bool_3)
				{
					this.Int32_0 = this.int_1 + (int)Math.Round((double)(this.int_2 - this.int_1) * ((double)spec.X / (double)base.Width));
				}
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003922 File Offset: 0x00001B22
		protected override void OnMouseUp(MouseEventArgs i)
		{
			base.OnMouseUp(i);
			this.bool_0 = false;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00010124 File Offset: 0x0000E324
		public Control17()
		{
			Class21.smethod_0();
			this.int_2 = 10;
			this.color_0 = Color.FromArgb(224, 224, 224);
			this.bool_1 = true;
			this.lsBreakJust_0 = (Control17.LsBreakJust)1;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.bool_1 = true;
			base.Size = new Size(80, 22);
			this.MinimumSize = new Size(37, 22);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003932 File Offset: 0x00001B32
		protected override void OnResize(EventArgs i)
		{
			base.OnResize(i);
			if (this.bool_2)
			{
				base.Height = 40;
				return;
			}
			base.Height = 22;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000101A0 File Offset: 0x0000E3A0
		protected override void OnPaint(PaintEventArgs config)
		{
			base.OnPaint(config);
			Graphics graphics = config.Graphics;
			HatchBrush brush = new HatchBrush(HatchStyle.WideDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
			graphics.Clear(base.Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			checked
			{
				this.graphicsPath_0 = Class6.smethod_1(1, 6, base.Width - 3, 8, 3);
				try
				{
					this.int_0 = (int)Math.Round(unchecked(checked((double)(this.int_3 - this.int_1) / (double)(this.int_2 - this.int_1)) * (double)(checked(base.Width - 11))));
				}
				catch (Exception)
				{
				}
				this.rectangle_0 = new Rectangle(this.int_0, 0, 10, 20);
				graphics.SetClip(this.graphicsPath_0);
				this.rectangle_1 = new Rectangle(1, 7, this.rectangle_0.X + this.rectangle_0.Width - 2, 7);
				this.linearGradientBrush_0 = new LinearGradientBrush(this.rectangle_1, this.color_0, this.color_0, 90f);
				graphics.FillRectangle(this.linearGradientBrush_0, this.rectangle_1);
				if (this.bool_1)
				{
					graphics.FillRectangle(brush, this.rectangle_1);
				}
				graphics.ResetClip();
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.graphicsPath_0);
				this.graphicsPath_1 = Class6.smethod_0(this.rectangle_0, 3);
				this.linearGradientBrush_1 = new LinearGradientBrush(base.ClientRectangle, SystemColors.Control, SystemColors.Control, 90f);
				graphics.FillPath(this.linearGradientBrush_1, this.graphicsPath_1);
				graphics.DrawPath(new Pen(Color.FromArgb(180, 180, 180)), this.graphicsPath_1);
				if (this.bool_2)
				{
					graphics.DrawString(Convert.ToString(this.Single_0), this.Font, Brushes.Gray, 0f, 25f);
				}
			}
		}

		// Token: 0x0400010A RID: 266
		private GraphicsPath graphicsPath_0;

		// Token: 0x0400010B RID: 267
		private GraphicsPath graphicsPath_1;

		// Token: 0x0400010C RID: 268
		private Rectangle rectangle_0;

		// Token: 0x0400010D RID: 269
		private Rectangle rectangle_1;

		// Token: 0x0400010E RID: 270
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x0400010F RID: 271
		private LinearGradientBrush linearGradientBrush_1;

		// Token: 0x04000110 RID: 272
		private bool bool_0;

		// Token: 0x04000111 RID: 273
		private int int_0;

		// Token: 0x04000112 RID: 274
		private int int_1;

		// Token: 0x04000113 RID: 275
		private int int_2;

		// Token: 0x04000114 RID: 276
		private int int_3;

		// Token: 0x04000115 RID: 277
		private Color color_0;

		// Token: 0x04000116 RID: 278
		private bool bool_1;

		// Token: 0x04000117 RID: 279
		private bool bool_2;

		// Token: 0x04000118 RID: 280
		private bool bool_3;

		// Token: 0x04000119 RID: 281
		private Control17.LsBreakJust lsBreakJust_0;

		// Token: 0x0400011A RID: 282
		[CompilerGenerated]
		private Control17.IssuerToken _FacadeVisitor;

		// Token: 0x02000049 RID: 73
		public enum LsBreakJust
		{

		}

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000244 RID: 580
		public delegate void IssuerToken();
	}
}
