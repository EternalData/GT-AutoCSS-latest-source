using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200003E RID: 62
	[DefaultEvent("CheckedChanged")]
	internal class Control13 : Control
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x0000EB90 File Offset: 0x0000CD90
		[CompilerGenerated]
		public void PopItem(Control13.AdvisorToken i)
		{
			Control13.AdvisorToken advisorToken = this._RoleWorker;
			Control13.AdvisorToken advisorToken2;
			do
			{
				advisorToken2 = advisorToken;
				Control13.AdvisorToken value = (Control13.AdvisorToken)Delegate.Combine(advisorToken2, i);
				advisorToken = Interlocked.CompareExchange<Control13.AdvisorToken>(ref this._RoleWorker, value, advisorToken2);
			}
			while (advisorToken != advisorToken2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[CompilerGenerated]
		public void CancelItem(Control13.AdvisorToken asset)
		{
			Control13.AdvisorToken advisorToken = this._RoleWorker;
			Control13.AdvisorToken advisorToken2;
			do
			{
				advisorToken2 = advisorToken;
				Control13.AdvisorToken value = (Control13.AdvisorToken)Delegate.Remove(advisorToken2, asset);
				advisorToken = Interlocked.CompareExchange<Control13.AdvisorToken>(ref this._RoleWorker, value, advisorToken2);
			}
			while (advisorToken != advisorToken2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00003470 File Offset: 0x00001670
		public bool method_0()
		{
			return this.bool_0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00003478 File Offset: 0x00001678
		public void method_1(bool bool_1)
		{
			this.bool_0 = bool_1;
			this.method_2();
			if (this._RoleWorker != null)
			{
				this._RoleWorker(this);
			}
			base.Invalidate();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002D63 File Offset: 0x00000F63
		protected override void OnTextChanged(EventArgs reference)
		{
			base.Invalidate();
			base.OnTextChanged(reference);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000034A1 File Offset: 0x000016A1
		protected override void OnResize(EventArgs v)
		{
			base.OnResize(v);
			base.Height = 15;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000034B2 File Offset: 0x000016B2
		protected override void OnMouseDown(MouseEventArgs ident)
		{
			if (!this.bool_0)
			{
				this.method_1(true);
			}
			base.OnMouseDown(ident);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000EC00 File Offset: 0x0000CE00
		public Control13()
		{
			Class21.smethod_0();
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.Font = new Font("Segoe UI", 10f);
			base.Width = 132;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000EC50 File Offset: 0x0000CE50
		private void method_2()
		{
			if (base.IsHandleCreated && this.bool_0)
			{
				foreach (object obj in base.Parent.Controls)
				{
					Control control = (Control)obj;
					if (control != this && control is Control13)
					{
						((Control13)control).method_1(false);
					}
				}
				return;
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		protected override void OnPaint(PaintEventArgs setup)
		{
			base.OnPaint(setup);
			Graphics graphics = setup.Graphics;
			graphics.Clear(Color.FromArgb(0, 0, 0));
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(14, 14)), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 0, 0), 90f);
			graphics.FillEllipse(brush, new Rectangle(new Point(0, 0), new Size(14, 14)));
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddEllipse(new Rectangle(0, 0, 14, 14));
			graphics.SetClip(graphicsPath);
			graphics.ResetClip();
			graphics.DrawEllipse(new Pen(Color.FromArgb(255, 255, 255)), new Rectangle(new Point(0, 0), new Size(14, 14)));
			if (this.bool_0)
			{
				SolidBrush brush2 = new SolidBrush(Color.FromArgb(255, 255, 255));
				graphics.FillEllipse(brush2, new Rectangle(new Point(4, 4), new Size(6, 6)));
			}
			graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(255, 255, 255)), 16f, 8f, new StringFormat
			{
				LineAlignment = StringAlignment.Center
			});
			setup.Dispose();
		}

		// Token: 0x040000F3 RID: 243
		private bool bool_0;

		// Token: 0x040000F4 RID: 244
		[CompilerGenerated]
		private Control13.AdvisorToken _RoleWorker;

		// Token: 0x0200003F RID: 63
		public enum RecycleBinItemType : byte
		{

		}

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001EB RID: 491
		public delegate void AdvisorToken(object sender);
	}
}
