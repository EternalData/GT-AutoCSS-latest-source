using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000043 RID: 67
	internal class Class11 : ComboBox
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x000035BC File Offset: 0x000017BC
		public int method_0()
		{
			return this.int_0;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000EF50 File Offset: 0x0000D150
		public void method_1(int int_1)
		{
			this.int_0 = int_1;
			try
			{
				base.SelectedIndex = int_1;
			}
			catch
			{
			}
			base.Invalidate();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000035C4 File Offset: 0x000017C4
		public Color method_2()
		{
			return this.color_0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000035CC File Offset: 0x000017CC
		public void method_3(Color color_1)
		{
			this.color_0 = color_1;
			base.Invalidate();
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000EF88 File Offset: 0x0000D188
		protected override void OnDrawItem(DrawItemEventArgs spec)
		{
			if ((spec.State & DrawItemState.Selected) == DrawItemState.Selected)
			{
				spec.Graphics.FillRectangle(new SolidBrush(this.color_0), spec.Bounds);
			}
			else
			{
				spec.Graphics.FillRectangle(Brushes.White, spec.Bounds);
			}
			if (spec.Index != -1)
			{
				spec.Graphics.DrawString(base.GetItemText(base.Items[spec.Index]), spec.Font, Brushes.DimGray, spec.Bounds);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000035DB File Offset: 0x000017DB
		protected override void OnLostFocus(EventArgs instance)
		{
			base.OnLostFocus(instance);
			base.SuspendLayout();
			base.Update();
			base.ResumeLayout();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003007 File Offset: 0x00001207
		protected override void OnPaintBackground(PaintEventArgs v)
		{
			base.OnPaintBackground(v);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000F018 File Offset: 0x0000D218
		public Class11()
		{
			Class21.smethod_0();
			this.color_0 = Color.FromArgb(241, 241, 241);
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(ControlStyles.Selectable, false);
			base.DrawMode = DrawMode.OwnerDrawFixed;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			this.BackColor = Color.FromArgb(246, 246, 246);
			this.ForeColor = Color.FromArgb(142, 142, 142);
			base.Size = new Size(135, 26);
			base.ItemHeight = 20;
			base.DropDownHeight = 100;
			this.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		protected override void OnPaint(PaintEventArgs item)
		{
			base.OnPaint(item);
			item.Graphics.Clear(this.BackColor);
			item.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			GraphicsPath graphicsPath = Class6.smethod_1(0, 0, base.Width - 1, base.Height - 1, 5);
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(base.ClientRectangle, Color.FromArgb(241, 241, 241), Color.FromArgb(241, 241, 241), 90f);
			item.Graphics.SetClip(graphicsPath);
			item.Graphics.FillRectangle(linearGradientBrush, base.ClientRectangle);
			item.Graphics.ResetClip();
			item.Graphics.DrawPath(new Pen(Color.FromArgb(204, 204, 204)), graphicsPath);
			item.Graphics.DrawString(this.Text, this.Font, new SolidBrush(Color.FromArgb(142, 142, 142)), new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
			{
				LineAlignment = StringAlignment.Center,
				Alignment = StringAlignment.Near
			});
			item.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2f), new Point(base.Width - 18, 10), new Point(base.Width - 14, 14));
			item.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160), 2f), new Point(base.Width - 14, 14), new Point(base.Width - 10, 10));
			item.Graphics.DrawLine(new Pen(Color.FromArgb(160, 160, 160)), new Point(base.Width - 14, 15), new Point(base.Width - 14, 14));
			graphicsPath.Dispose();
			linearGradientBrush.Dispose();
		}

		// Token: 0x040000F8 RID: 248
		private int int_0;

		// Token: 0x040000F9 RID: 249
		private Color color_0;
	}
}
