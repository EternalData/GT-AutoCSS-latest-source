using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200003C RID: 60
	[DefaultEvent("CheckedChanged")]
	internal class Control12 : Control
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0000E890 File Offset: 0x0000CA90
		[CompilerGenerated]
		public void InsertItem(Control12.PublisherToken value)
		{
			Control12.PublisherToken publisherToken = this.m_RegistryWorker;
			Control12.PublisherToken publisherToken2;
			do
			{
				publisherToken2 = publisherToken;
				Control12.PublisherToken value2 = (Control12.PublisherToken)Delegate.Combine(publisherToken2, value);
				publisherToken = Interlocked.CompareExchange<Control12.PublisherToken>(ref this.m_RegistryWorker, value2, publisherToken2);
			}
			while (publisherToken != publisherToken2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[CompilerGenerated]
		public void StopItem(Control12.PublisherToken i)
		{
			Control12.PublisherToken publisherToken = this.m_RegistryWorker;
			Control12.PublisherToken publisherToken2;
			do
			{
				publisherToken2 = publisherToken;
				Control12.PublisherToken value = (Control12.PublisherToken)Delegate.Remove(publisherToken2, i);
				publisherToken = Interlocked.CompareExchange<Control12.PublisherToken>(ref this.m_RegistryWorker, value, publisherToken2);
			}
			while (publisherToken != publisherToken2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00003413 File Offset: 0x00001613
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000341B File Offset: 0x0000161B
		public void method_1(bool bool_1)
		{
			this.bool_0 = bool_1;
			if (this.m_RegistryWorker != null)
			{
				this.m_RegistryWorker(this);
			}
			base.Invalidate();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000E900 File Offset: 0x0000CB00
		public Control12()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 10f);
			base.Size = new Size(120, 26);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000343E File Offset: 0x0000163E
		protected override void OnClick(EventArgs asset)
		{
			this.bool_0 = !this.bool_0;
			if (this.m_RegistryWorker != null)
			{
				this.m_RegistryWorker(this);
			}
			base.Invalidate();
			base.OnClick(asset);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002D63 File Offset: 0x00000F63
		protected override void OnTextChanged(EventArgs v)
		{
			base.Invalidate();
			base.OnTextChanged(v);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000E95C File Offset: 0x0000CB5C
		protected override void OnResize(EventArgs v)
		{
			if (base.Width > 0 && base.Height > 0)
			{
				this.graphicsPath_0 = new GraphicsPath();
				this.rectangle_0 = new Rectangle(17, 0, base.Width, base.Height + 1);
				this.rectangle_1 = new Rectangle(0, 0, base.Width, base.Height);
				this.linearGradientBrush_0 = new LinearGradientBrush(new Rectangle(0, 0, 25, 25), Color.FromArgb(250, 250, 250), Color.FromArgb(240, 240, 240), 90f);
				GraphicsPath graphicsPath = this.graphicsPath_0;
				graphicsPath.AddArc(0, 0, 7, 7, 180f, 90f);
				graphicsPath.AddArc(7, 0, 7, 7, -90f, 90f);
				graphicsPath.AddArc(7, 7, 7, 7, 0f, 90f);
				graphicsPath.AddArc(0, 7, 7, 7, 90f, 90f);
				graphicsPath.CloseAllFigures();
				base.Height = 15;
			}
			base.Invalidate();
			base.OnResize(v);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000EA74 File Offset: 0x0000CC74
		protected override void OnPaint(PaintEventArgs instance)
		{
			base.OnPaint(instance);
			Graphics graphics = instance.Graphics;
			graphics.Clear(Color.FromArgb(246, 246, 246));
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			graphics.FillPath(this.linearGradientBrush_0, this.graphicsPath_0);
			graphics.DrawPath(new Pen(Color.FromArgb(160, 160, 160)), this.graphicsPath_0);
			graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(142, 142, 142)), this.rectangle_0, new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			if (this.method_0())
			{
				graphics.DrawString("ü", new Font("Wingdings", 14f), new SolidBrush(Color.FromArgb(142, 142, 142)), new Rectangle(-2, 1, base.Width, base.Height), new StringFormat
				{
					LineAlignment = StringAlignment.Center
				});
			}
			instance.Dispose();
		}

		// Token: 0x040000ED RID: 237
		private GraphicsPath graphicsPath_0;

		// Token: 0x040000EE RID: 238
		private LinearGradientBrush linearGradientBrush_0;

		// Token: 0x040000EF RID: 239
		private Rectangle rectangle_0;

		// Token: 0x040000F0 RID: 240
		private Rectangle rectangle_1;

		// Token: 0x040000F1 RID: 241
		private bool bool_0;

		// Token: 0x040000F2 RID: 242
		[CompilerGenerated]
		private Control12.PublisherToken m_RegistryWorker;

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001DD RID: 477
		public delegate void PublisherToken(object sender);
	}
}
