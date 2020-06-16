using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000023 RID: 35
	public class Reader : ToolStripProfessionalRenderer
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00002A87 File Offset: 0x00000C87
		public Reader()
		{
			Class21.smethod_0();
			this..ctor(new Iterator());
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002A99 File Offset: 0x00000C99
		public Reader(Strategy item)
		{
			Class21.smethod_0();
			base..ctor();
			this.PopVisitor(item);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002AAD File Offset: 0x00000CAD
		public Strategy SelectVisitor()
		{
			if (this.iterator_0 == null)
			{
				this.iterator_0 = new Iterator();
			}
			return this.iterator_0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002AC8 File Offset: 0x00000CC8
		public void PopVisitor(Strategy i)
		{
			this.iterator_0 = i;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00009B9C File Offset: 0x00007D9C
		protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs key)
		{
			base.OnRenderToolStripBackground(key);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(key.AffectedBounds, this.SelectVisitor().CountSpecification(), this.SelectVisitor().RestartSpecification(), LinearGradientMode.Vertical))
			{
				key.Graphics.FillRectangle(linearGradientBrush, key.AffectedBounds);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00009C04 File Offset: 0x00007E04
		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs param)
		{
			if (param.ToolStrip.Parent == null)
			{
				Rectangle rect = new Rectangle(0, 0, param.ToolStrip.Width - 1, param.ToolStrip.Height - 1);
				using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().ConcatSpecification()))
				{
					param.Graphics.DrawRectangle(pen, rect);
				}
				using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().EnableSpecification()))
				{
					param.Graphics.FillRectangle(solidBrush, param.ConnectedArea);
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00009CC0 File Offset: 0x00007EC0
		protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs param)
		{
			if (param.Item.Enabled)
			{
				if (param.Item.Selected)
				{
					if (!param.Item.IsOnDropDown)
					{
						Rectangle role = new Rectangle(0, 0, param.Item.Width - 1, param.Item.Height - 1);
						Candidate.VerifyVisitor(param.Graphics, this.SelectVisitor().PrepareSpecification(), role);
					}
					else
					{
						Rectangle role2 = new Rectangle(2, 0, param.Item.Width - 4, param.Item.Height - 1);
						Candidate.VerifyVisitor(param.Graphics, this.SelectVisitor().PrepareSpecification(), role2);
					}
				}
				if (((ToolStripMenuItem)param.Item).DropDown.Visible && !param.Item.IsOnDropDown)
				{
					Rectangle rectangle = new Rectangle(0, 0, param.Item.Width - 1, param.Item.Height);
					Rectangle rect = new Rectangle(1, 1, param.Item.Width - 2, param.Item.Height + 2);
					using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().EnableSpecification()))
					{
						param.Graphics.FillRectangle(solidBrush, rect);
					}
					using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().ConcatSpecification()))
					{
						Candidate.PrintVisitor(param.Graphics, pen, Convert.ToSingle(rectangle.X), Convert.ToSingle(rectangle.Y), Convert.ToSingle(rectangle.Width), Convert.ToSingle(rectangle.Height), 2f);
					}
				}
				param.Item.ForeColor = this.SelectVisitor().PrepareSpecification().InvokeSpecification();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002AD1 File Offset: 0x00000CD1
		protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs spec)
		{
			spec.TextColor = this.SelectVisitor().PrepareSpecification().InvokeSpecification();
			base.OnRenderItemText(spec);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009EA8 File Offset: 0x000080A8
		protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs config)
		{
			base.OnRenderItemCheck(config);
			Rectangle rect = new Rectangle(3, 1, config.Item.Height - 3, config.Item.Height - 3);
			Color color = default(Color);
			if (config.Item.Selected)
			{
				color = this.SelectVisitor().PrepareSpecification().PushSpecification();
			}
			else
			{
				color = this.SelectVisitor().PrepareSpecification().SortSpecification();
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				config.Graphics.FillRectangle(solidBrush, rect);
			}
			using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().PopSpecification()))
			{
				config.Graphics.DrawRectangle(pen, rect);
			}
			config.Graphics.DrawString("ü", new Font("Wingdings", 13f, FontStyle.Regular), Brushes.Black, new Point(4, 2));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00009FB4 File Offset: 0x000081B4
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs asset)
		{
			base.OnRenderSeparator(asset);
			int x = 28;
			int x2 = Convert.ToInt32(asset.Item.Width);
			int num = 3;
			using (Pen pen = new Pen(this.SelectVisitor().VisitSpecification()))
			{
				asset.Graphics.DrawLine(pen, x, num, x2, num);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000A01C File Offset: 0x0000821C
		protected override void OnRenderImageMargin(ToolStripRenderEventArgs item)
		{
			base.OnRenderImageMargin(item);
			Rectangle rect = new Rectangle(0, -1, item.ToolStrip.Width, item.ToolStrip.Height + 1);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, this.SelectVisitor().SetSpecification(), this.SelectVisitor().CollectSpecification(), LinearGradientMode.Vertical))
			{
				item.Graphics.FillRectangle(linearGradientBrush, rect);
			}
			using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().MoveSpecification()))
			{
				item.Graphics.FillRectangle(solidBrush, item.AffectedBounds);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000A0D4 File Offset: 0x000082D4
		protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs task)
		{
			Rectangle rectangle = new Rectangle(0, 0, task.Item.Width - 1, task.Item.Height - 1);
			bool flag = Convert.ToBoolean(((ToolStripButton)task.Item).Checked);
			bool flag2 = false;
			if (flag)
			{
				flag2 = true;
				if (task.Item.Selected && !task.Item.Pressed)
				{
					using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().PrepareSpecification().PushSpecification()))
					{
						task.Graphics.FillRectangle(solidBrush, rectangle);
						goto IL_124;
					}
				}
				using (SolidBrush solidBrush2 = new SolidBrush(this.SelectVisitor().PrepareSpecification().SortSpecification()))
				{
					task.Graphics.FillRectangle(solidBrush2, rectangle);
					goto IL_124;
				}
			}
			if (task.Item.Pressed)
			{
				flag2 = true;
				using (SolidBrush solidBrush3 = new SolidBrush(this.SelectVisitor().PrepareSpecification().ForgotSpecification()))
				{
					task.Graphics.FillRectangle(solidBrush3, rectangle);
					goto IL_124;
				}
			}
			if (task.Item.Selected)
			{
				flag2 = true;
				Candidate.VerifyVisitor(task.Graphics, this.SelectVisitor().PrepareSpecification(), rectangle);
			}
			IL_124:
			if (flag2)
			{
				using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().PopSpecification()))
				{
					task.Graphics.DrawRectangle(pen, rectangle);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000A270 File Offset: 0x00008470
		protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs value)
		{
			Rectangle rectangle = new Rectangle(0, 0, value.Item.Width - 1, value.Item.Height - 1);
			bool flag = false;
			if (value.Item.Pressed)
			{
				flag = true;
				using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().PrepareSpecification().ForgotSpecification()))
				{
					value.Graphics.FillRectangle(solidBrush, rectangle);
					goto IL_89;
				}
			}
			if (value.Item.Selected)
			{
				flag = true;
				Candidate.VerifyVisitor(value.Graphics, this.SelectVisitor().PrepareSpecification(), rectangle);
			}
			IL_89:
			if (flag)
			{
				using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().PopSpecification()))
				{
					value.Graphics.DrawRectangle(pen, rectangle);
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000A354 File Offset: 0x00008554
		protected override void OnRenderSplitButtonBackground(ToolStripItemRenderEventArgs config)
		{
			base.OnRenderSplitButtonBackground(config);
			bool flag = false;
			bool flag2 = true;
			ToolStripSplitButton toolStripSplitButton = (ToolStripSplitButton)config.Item;
			checked
			{
				Rectangle rect = new Rectangle(0, 0, toolStripSplitButton.ButtonBounds.Width - 1, toolStripSplitButton.ButtonBounds.Height - 1);
				Rectangle rectangle = new Rectangle(0, 0, toolStripSplitButton.Bounds.Width - 1, toolStripSplitButton.Bounds.Height - 1);
				if (toolStripSplitButton.DropDownButtonPressed)
				{
					flag = true;
					flag2 = false;
					using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().PrepareSpecification().ForgotSpecification()))
					{
						config.Graphics.FillRectangle(solidBrush, rectangle);
						goto IL_D2;
					}
				}
				if (toolStripSplitButton.DropDownButtonSelected)
				{
					flag = true;
					Candidate.VerifyVisitor(config.Graphics, this.SelectVisitor().PrepareSpecification(), rectangle);
				}
				IL_D2:
				if (toolStripSplitButton.ButtonPressed)
				{
					using (SolidBrush solidBrush2 = new SolidBrush(this.SelectVisitor().PrepareSpecification().ForgotSpecification()))
					{
						config.Graphics.FillRectangle(solidBrush2, rect);
					}
				}
				if (flag)
				{
					using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().PopSpecification()))
					{
						config.Graphics.DrawRectangle(pen, rectangle);
						if (flag2)
						{
							config.Graphics.DrawRectangle(pen, rect);
						}
					}
					this.method_0(config.Graphics, toolStripSplitButton);
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000A4F4 File Offset: 0x000086F4
		private void method_0(Graphics graphics_0, ToolStripSplitButton toolStripSplitButton_0)
		{
			int num = Convert.ToInt32(toolStripSplitButton_0.DropDownButtonBounds.Width - 1);
			int num2 = Convert.ToInt32(toolStripSplitButton_0.DropDownButtonBounds.Height - 1);
			float num3 = (float)num / 2f + 1f;
			float x = Convert.ToSingle((float)toolStripSplitButton_0.DropDownButtonBounds.Left + ((float)num - num3) / 2f);
			float num4 = num3 / 2f;
			float y = Convert.ToSingle((float)toolStripSplitButton_0.DropDownButtonBounds.Top + ((float)num2 - num4) / 2f + 1f);
			RectangleF value = new RectangleF(x, y, num3, num4);
			this.method_1(graphics_0, toolStripSplitButton_0, Rectangle.Round(value));
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000A5AC File Offset: 0x000087AC
		private void method_1(Graphics graphics_0, ToolStripItem toolStripItem_0, Rectangle rectangle_0)
		{
			ToolStripArrowRenderEventArgs e = new ToolStripArrowRenderEventArgs(graphics_0, toolStripItem_0, rectangle_0, this.SelectVisitor().PrepareSpecification().CallSpecification(), ArrowDirection.Down);
			base.OnRenderArrow(e);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000A5DC File Offset: 0x000087DC
		protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs last)
		{
			Rectangle rectangle = default(Rectangle);
			Rectangle rectangle2 = default(Rectangle);
			rectangle = new Rectangle(0, 0, last.Item.Width - 1, last.Item.Height - 2);
			rectangle2 = new Rectangle(rectangle.X - 5, rectangle.Y, rectangle.Width - 5, rectangle.Height);
			if (last.Item.Pressed)
			{
				using (SolidBrush solidBrush = new SolidBrush(this.SelectVisitor().PrepareSpecification().ForgotSpecification()))
				{
					last.Graphics.FillRectangle(solidBrush, rectangle);
					goto IL_EB;
				}
			}
			if (last.Item.Selected)
			{
				Candidate.VerifyVisitor(last.Graphics, this.SelectVisitor().PrepareSpecification(), rectangle);
			}
			else
			{
				using (SolidBrush solidBrush2 = new SolidBrush(this.SelectVisitor().PrepareSpecification().ConnectSpecification()))
				{
					last.Graphics.FillRectangle(solidBrush2, rectangle);
				}
			}
			IL_EB:
			using (Pen pen = new Pen(this.SelectVisitor().PrepareSpecification().SelectSpecification()))
			{
				Candidate.PrintVisitor(last.Graphics, pen, Convert.ToSingle(rectangle2.X), Convert.ToSingle(rectangle2.Y), Convert.ToSingle(rectangle2.Width), Convert.ToSingle(rectangle2.Height), 3f);
			}
			int num = Convert.ToInt32(rectangle.Width - 1);
			int num2 = Convert.ToInt32(rectangle.Height - 1);
			float num3 = (float)num / 2f + 1f;
			float num4 = Convert.ToSingle((float)rectangle.Left + ((float)num - num3) / 2f + 3f);
			float num5 = num3 / 2f;
			float num6 = Convert.ToSingle((float)rectangle.Top + ((float)num2 - num5) / 2f + 7f);
			RectangleF value = new RectangleF(num4, num6, num3, num5);
			this.method_1(last.Graphics, last.Item, Rectangle.Round(value));
			using (Pen pen2 = new Pen(this.SelectVisitor().PrepareSpecification().CallSpecification()))
			{
				last.Graphics.DrawLine(pen2, num4 + 2f, num6 - 2f, num4 + num3 - 2f, num6 - 2f);
			}
		}

		// Token: 0x04000081 RID: 129
		private Iterator iterator_0;
	}
}
