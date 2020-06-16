using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200002B RID: 43
	[DefaultEvent("ToggledChanged")]
	internal class Control7 : Control
	{
		// Token: 0x06000154 RID: 340 RVA: 0x0000C590 File Offset: 0x0000A790
		public GraphicsPath method_0(Rectangle rectangle_1, Control7.DispatcherToken dispatcherToken_0)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			if (dispatcherToken_0.m_ParamsToken)
			{
				graphicsPath.AddArc(new Rectangle(rectangle_1.X, rectangle_1.Y, rectangle_1.Height, rectangle_1.Height), -270f, 180f);
			}
			else
			{
				graphicsPath.AddLine(rectangle_1.X, rectangle_1.Y + rectangle_1.Height, rectangle_1.X, rectangle_1.Y);
			}
			if (dispatcherToken_0._UtilsToken)
			{
				graphicsPath.AddArc(new Rectangle(rectangle_1.X + rectangle_1.Width - rectangle_1.Height, rectangle_1.Y, rectangle_1.Height, rectangle_1.Height), -90f, 180f);
			}
			else
			{
				graphicsPath.AddLine(rectangle_1.X + rectangle_1.Width, rectangle_1.Y, rectangle_1.X + rectangle_1.Width, rectangle_1.Y + rectangle_1.Height);
			}
			graphicsPath.CloseAllFigures();
			return graphicsPath;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002E1D File Offset: 0x0000101D
		public object method_1(int int_1, int int_2, int int_3, int int_4, Control7.DispatcherToken dispatcherToken_0)
		{
			return this.method_0(new Rectangle(int_1, int_2, int_3, int_4), dispatcherToken_0);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000C698 File Offset: 0x0000A898
		[CompilerGenerated]
		public void GetVisitor(Control7.TagToken var1)
		{
			Control7.TagToken tagToken = this._InstanceWorker;
			Control7.TagToken tagToken2;
			do
			{
				tagToken2 = tagToken;
				Control7.TagToken value = (Control7.TagToken)Delegate.Combine(tagToken2, var1);
				tagToken = Interlocked.CompareExchange<Control7.TagToken>(ref this._InstanceWorker, value, tagToken2);
			}
			while (tagToken != tagToken2);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		[CompilerGenerated]
		public void ComputeVisitor(Control7.TagToken def)
		{
			Control7.TagToken tagToken = this._InstanceWorker;
			Control7.TagToken tagToken2;
			do
			{
				tagToken2 = tagToken;
				Control7.TagToken value = (Control7.TagToken)Delegate.Remove(tagToken2, def);
				tagToken = Interlocked.CompareExchange<Control7.TagToken>(ref this._InstanceWorker, value, tagToken2);
			}
			while (tagToken != tagToken2);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002E31 File Offset: 0x00001031
		public bool method_2()
		{
			return this.bool_0;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002E39 File Offset: 0x00001039
		public void method_3(bool bool_1)
		{
			this.bool_0 = bool_1;
			base.Invalidate();
			if (this._InstanceWorker != null)
			{
				this._InstanceWorker();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00002E5B File Offset: 0x0000105B
		// (set) Token: 0x0600015B RID: 347 RVA: 0x00002E63 File Offset: 0x00001063
		public Control7.BrushTypes BrushTypes_0
		{
			get
			{
				return this.brushTypes_0;
			}
			set
			{
				this.brushTypes_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002E72 File Offset: 0x00001072
		protected override void OnResize(EventArgs param)
		{
			base.OnResize(param);
			base.Width = 41;
			base.Height = 23;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002E8B File Offset: 0x0000108B
		protected override void OnMouseUp(MouseEventArgs i)
		{
			base.OnMouseUp(i);
			this.method_3(!this.method_2());
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000C708 File Offset: 0x0000A908
		public Control7()
		{
			Class21.smethod_0();
			this.timer_0 = new Timer
			{
				Interval = 1
			};
			this.size_0 = new Size(15, 20);
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.timer_0.Tick += this.timer_0_Tick;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002EA3 File Offset: 0x000010A3
		protected override void OnHandleCreated(EventArgs item)
		{
			base.OnHandleCreated(item);
			this.timer_0.Start();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000C764 File Offset: 0x0000A964
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.bool_0)
			{
				if (this.int_0 < 100)
				{
					this.int_0 += 10;
					base.Invalidate(false);
					return;
				}
			}
			else if (this.int_0 > 0)
			{
				this.int_0 -= 10;
				base.Invalidate(false);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		protected override void OnPaint(PaintEventArgs v)
		{
			base.OnPaint(v);
			Graphics graphics = v.Graphics;
			graphics.Clear(base.Parent.BackColor);
			checked
			{
				Point point = new Point(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.size_0.Height / 2.0)));
				Point point2 = new Point(0, (int)Math.Round(unchecked((double)base.Height / 2.0 + (double)this.size_0.Height / 2.0)));
				LinearGradientBrush linearGradientBrush = new LinearGradientBrush(point, point2, Color.FromArgb(250, 250, 250), Color.FromArgb(240, 240, 240));
				this.rectangle_0 = new Rectangle(8, 10, base.Width - 21, base.Height - 21);
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.FillPath(linearGradientBrush, (GraphicsPath)this.method_1(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.size_0.Height / 2.0)), base.Width - 1, this.size_0.Height - 5, new Control7.DispatcherToken
				{
					m_ParamsToken = true,
					_UtilsToken = true
				}));
				graphics.DrawPath(new Pen(Color.FromArgb(177, 177, 176)), (GraphicsPath)this.method_1(0, (int)Math.Round(unchecked((double)base.Height / 2.0 - (double)this.size_0.Height / 2.0)), base.Width - 1, this.size_0.Height - 5, new Control7.DispatcherToken
				{
					m_ParamsToken = true,
					_UtilsToken = true
				}));
				linearGradientBrush.Dispose();
				switch (this.brushTypes_0)
				{
				case (Control7.BrushTypes)0:
					if (this.method_2())
					{
						graphics.DrawString("Yes", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 7), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("No", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 18), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				case (Control7.BrushTypes)1:
					if (this.method_2())
					{
						graphics.DrawString("On", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 7), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("Off", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 18), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				case (Control7.BrushTypes)2:
					if (this.method_2())
					{
						graphics.DrawString("I", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 7), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					else
					{
						graphics.DrawString("O", new Font("Segoe UI", 7f, FontStyle.Regular), Brushes.Gray, (float)(this.rectangle_0.X + 18), (float)this.rectangle_0.Y, new StringFormat
						{
							Alignment = StringAlignment.Center,
							LineAlignment = StringAlignment.Center
						});
					}
					break;
				}
				graphics.FillEllipse(new SolidBrush(Color.FromArgb(249, 249, 249)), this.rectangle_0.X + (int)Math.Round(unchecked((double)this.rectangle_0.Width * ((double)this.int_0 / 80.0))) - (int)Math.Round((double)this.size_0.Width / 2.0), this.rectangle_0.Y + (int)Math.Round((double)this.rectangle_0.Height / 2.0) - (int)Math.Round(unchecked((double)this.size_0.Height / 2.0 - 1.0)), this.size_0.Width, this.size_0.Height - 5);
				graphics.DrawEllipse(new Pen(Color.FromArgb(177, 177, 176)), this.rectangle_0.X + (int)Math.Round(unchecked((double)this.rectangle_0.Width * ((double)this.int_0 / 80.0) - (double)(checked((int)Math.Round((double)this.size_0.Width / 2.0))))), this.rectangle_0.Y + (int)Math.Round((double)this.rectangle_0.Height / 2.0) - (int)Math.Round(unchecked((double)this.size_0.Height / 2.0 - 1.0)), this.size_0.Width, this.size_0.Height - 5);
			}
		}

		// Token: 0x040000B6 RID: 182
		private Timer timer_0;

		// Token: 0x040000B7 RID: 183
		private int int_0;

		// Token: 0x040000B8 RID: 184
		[CompilerGenerated]
		private Control7.TagToken _InstanceWorker;

		// Token: 0x040000B9 RID: 185
		private bool bool_0;

		// Token: 0x040000BA RID: 186
		private Control7.BrushTypes brushTypes_0;

		// Token: 0x040000BB RID: 187
		private Rectangle rectangle_0;

		// Token: 0x040000BC RID: 188
		private Size size_0;

		// Token: 0x0200002C RID: 44
		public class DispatcherToken
		{
			// Token: 0x06000162 RID: 354 RVA: 0x00002354 File Offset: 0x00000554
			public DispatcherToken()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x040000BD RID: 189
			public bool m_ParamsToken;

			// Token: 0x040000BE RID: 190
			public bool _UtilsToken;
		}

		// Token: 0x0200002D RID: 45
		public enum BrushTypes
		{

		}

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000164 RID: 356
		public delegate void TagToken();
	}
}
