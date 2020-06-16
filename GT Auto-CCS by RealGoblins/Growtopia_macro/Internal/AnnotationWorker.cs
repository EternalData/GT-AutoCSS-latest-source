using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000035 RID: 53
	public class AnnotationWorker : Control
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00003243 File Offset: 0x00001443
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000324B File Offset: 0x0000144B
		public long Value
		{
			get
			{
				return this.long_0;
			}
			set
			{
				if (value <= this.long_2 & value >= this.long_1)
				{
					this.long_0 = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00003275 File Offset: 0x00001475
		public long DefineTests()
		{
			return this.long_1;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000327D File Offset: 0x0000147D
		public void DisableTests(long iamount)
		{
			if (iamount < this.long_2)
			{
				this.long_1 = iamount;
			}
			if (this.long_0 < this.long_1)
			{
				this.long_0 = this.DefineTests();
			}
			base.Invalidate();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000032AF File Offset: 0x000014AF
		public long AwakeTests()
		{
			return this.long_2;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000032B7 File Offset: 0x000014B7
		public void ViewTests(long spec)
		{
			if (spec > this.long_1)
			{
				this.long_2 = spec;
			}
			if (this.long_0 > this.long_2)
			{
				this.long_0 = this.long_2;
			}
			base.Invalidate();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000032E9 File Offset: 0x000014E9
		public AnnotationWorker.PipeTransmissionMode ManageTests()
		{
			return this.pipeTransmissionMode_0;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000032F1 File Offset: 0x000014F1
		public void ResetTests(AnnotationWorker.PipeTransmissionMode item)
		{
			this.pipeTransmissionMode_0 = item;
			base.Invalidate();
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000D894 File Offset: 0x0000BA94
		protected override void OnResize(EventArgs reference)
		{
			base.OnResize(reference);
			base.Height = 28;
			this.graphicsPath_0 = new GraphicsPath();
			this.graphicsPath_0.AddArc(0, 0, 10, 10, 180f, 90f);
			this.graphicsPath_0.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			this.graphicsPath_0.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			this.graphicsPath_0.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			this.graphicsPath_0.CloseAllFigures();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000D954 File Offset: 0x0000BB54
		protected override void OnMouseMove(MouseEventArgs init)
		{
			base.OnMouseMove(init);
			this.int_0 = init.Location.X;
			this.int_1 = init.Location.Y;
			base.Invalidate();
			if (init.X < base.Width - 24)
			{
				this.Cursor = Cursors.IBeam;
				return;
			}
			this.Cursor = Cursors.Default;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000D9C0 File Offset: 0x0000BBC0
		protected override void OnMouseDown(MouseEventArgs item)
		{
			base.OnMouseClick(item);
			if (this.int_0 > base.Width - 23 && this.int_0 < base.Width - 3)
			{
				if (this.int_1 < 15)
				{
					if (this.Value + 1L <= this.long_2)
					{
						this.long_0 += 1L;
					}
				}
				else if (this.Value - 1L >= this.long_1)
				{
					this.long_0 -= 1L;
				}
			}
			else
			{
				this.bool_0 = !this.bool_0;
				base.Focus();
			}
			base.Invalidate();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		protected override void OnKeyPress(KeyPressEventArgs config)
		{
			base.OnKeyPress(config);
			try
			{
				if (this.bool_0)
				{
					this.long_0 = long.Parse(this.long_0.ToString() + config.KeyChar.ToString().ToString());
				}
				if (this.long_0 > this.long_2)
				{
					this.long_0 = this.long_2;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		protected override void OnKeyUp(KeyEventArgs instance)
		{
			base.OnKeyUp(instance);
			if (instance.KeyCode == Keys.Back)
			{
				string text = this.long_0.ToString();
				text = text.Remove(Convert.ToInt32(text.Length - 1));
				if (text.Length == 0)
				{
					text = "0";
				}
				this.long_0 = (long)Convert.ToInt32(text);
			}
			base.Invalidate();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000DB58 File Offset: 0x0000BD58
		protected override void OnMouseWheel(MouseEventArgs res)
		{
			base.OnMouseWheel(res);
			if (res.Delta > 0)
			{
				if (this.Value + 1L <= this.long_2)
				{
					this.long_0 += 1L;
				}
				base.Invalidate();
				return;
			}
			if (this.Value - 1L >= this.long_1)
			{
				this.long_0 -= 1L;
			}
			base.Invalidate();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		public AnnotationWorker()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.pen_0 = new Pen(Color.FromArgb(180, 180, 180));
			this.solidBrush_0 = new SolidBrush(Color.White);
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.DimGray;
			this.long_1 = 0L;
			this.long_2 = 100L;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(70, 28);
			this.MinimumSize = new Size(62, 28);
			this.DoubleBuffered = true;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00003300 File Offset: 0x00001500
		public void ChangeTests(int i_end)
		{
			this.long_0 += (long)i_end;
			base.Invalidate();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00003317 File Offset: 0x00001517
		public void AssetTests(int firstcounter)
		{
			this.long_0 -= (long)firstcounter;
			base.Invalidate();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		protected override void OnPaint(PaintEventArgs config)
		{
			base.OnPaint(config);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(this.solidBrush_0, this.graphicsPath_0);
			graphics.DrawPath(this.pen_0, this.graphicsPath_0);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(base.Width - 23, 4, 19, 19), Color.FromArgb(241, 241, 241), Color.FromArgb(241, 241, 241), 90f);
			graphics.FillRectangle(linearGradientBrush, linearGradientBrush.Rectangle);
			graphics.DrawRectangle(new Pen(Color.FromArgb(252, 252, 252)), new Rectangle(base.Width - 22, 5, 17, 17));
			graphics.DrawRectangle(new Pen(Color.FromArgb(180, 180, 180)), new Rectangle(base.Width - 23, 4, 19, 19));
			graphics.DrawLine(new Pen(Color.FromArgb(250, 252, 250)), new Point(base.Width - 22, base.Height - 16), new Point(base.Width - 5, base.Height - 16));
			graphics.DrawLine(new Pen(Color.FromArgb(180, 180, 180)), new Point(base.Width - 22, base.Height - 15), new Point(base.Width - 5, base.Height - 15));
			graphics.DrawLine(new Pen(Color.FromArgb(250, 250, 250)), new Point(base.Width - 22, base.Height - 14), new Point(base.Width - 5, base.Height - 14));
			graphics.DrawString("+", new Font("Tahoma", 8f), Brushes.Gray, (float)(base.Width - 19), (float)(base.Height - 26));
			graphics.DrawString("-", new Font("Tahoma", 12f), Brushes.Gray, (float)(base.Width - 19), (float)(base.Height - 20));
			AnnotationWorker.PipeTransmissionMode pipeTransmissionMode = this.pipeTransmissionMode_0;
			if (pipeTransmissionMode != (AnnotationWorker.PipeTransmissionMode)0)
			{
				if (pipeTransmissionMode == (AnnotationWorker.PipeTransmissionMode)1)
				{
					graphics.DrawString(Convert.ToString(this.Value), this.Font, new SolidBrush(this.ForeColor), new Rectangle(0, 0, base.Width - 1, base.Height - 1), new StringFormat
					{
						Alignment = StringAlignment.Center,
						LineAlignment = StringAlignment.Center
					});
				}
			}
			else
			{
				graphics.DrawString(Convert.ToString(this.Value), this.Font, new SolidBrush(this.ForeColor), new Rectangle(5, 0, base.Width - 1, base.Height - 1), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Center
				});
			}
			config.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x040000D9 RID: 217
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000DA RID: 218
		private Pen pen_0;

		// Token: 0x040000DB RID: 219
		private SolidBrush solidBrush_0;

		// Token: 0x040000DC RID: 220
		private long long_0;

		// Token: 0x040000DD RID: 221
		private long long_1;

		// Token: 0x040000DE RID: 222
		private long long_2;

		// Token: 0x040000DF RID: 223
		private int int_0;

		// Token: 0x040000E0 RID: 224
		private int int_1;

		// Token: 0x040000E1 RID: 225
		private bool bool_0;

		// Token: 0x040000E2 RID: 226
		private AnnotationWorker.PipeTransmissionMode pipeTransmissionMode_0;

		// Token: 0x02000036 RID: 54
		public enum PipeTransmissionMode
		{

		}
	}
}
