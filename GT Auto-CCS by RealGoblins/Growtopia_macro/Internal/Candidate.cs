using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000024 RID: 36
	public class Candidate
	{
		// Token: 0x06000109 RID: 265 RVA: 0x0000A86C File Offset: 0x00008A6C
		public static void VerifyVisitor(Graphics instance, Interceptor vis, Rectangle role)
		{
			Rectangle rect = default(Rectangle);
			Rectangle rect2 = default(Rectangle);
			Rectangle rectangle = new Rectangle(role.X + 1, role.Y + 1, role.Width - 1, role.Height - 1);
			rect = rectangle;
			rect.Height -= Convert.ToInt32(rect.Height / 2);
			rect2 = new Rectangle(rect.X, rect.Bottom, rect.Width, rectangle.Height - rect.Height);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, vis.CancelSpecification(), vis.VerifySpecification(), LinearGradientMode.Vertical))
			{
				instance.FillRectangle(linearGradientBrush, rect);
			}
			using (SolidBrush solidBrush = new SolidBrush(vis.PrintSpecification()))
			{
				instance.FillRectangle(solidBrush, rect2);
			}
			using (Pen pen = new Pen(vis.PopSpecification()))
			{
				Candidate.PrintVisitor(instance, pen, Convert.ToSingle(role.X), Convert.ToSingle(role.Y), Convert.ToSingle(role.Width), Convert.ToSingle(role.Height), 2f);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public static void PrintVisitor(Graphics key, Pen caller, float serv, float counter2, float cust3, float col4, float caller5)
		{
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddLine(serv + caller5, counter2, serv + cust3 - caller5 * 2f, counter2);
				graphicsPath.AddArc(serv + cust3 - caller5 * 2f, counter2, caller5 * 2f, caller5 * 2f, 270f, 90f);
				graphicsPath.AddLine(serv + cust3, counter2 + caller5, serv + cust3, counter2 + col4 - caller5 * 2f);
				graphicsPath.AddArc(serv + cust3 - caller5 * 2f, counter2 + col4 - caller5 * 2f, caller5 * 2f, caller5 * 2f, 0f, 90f);
				graphicsPath.AddLine(serv + cust3 - caller5 * 2f, counter2 + col4, serv + caller5, counter2 + col4);
				graphicsPath.AddArc(serv, counter2 + col4 - caller5 * 2f, caller5 * 2f, caller5 * 2f, 90f, 90f);
				graphicsPath.AddLine(serv, counter2 + col4 - caller5 * 2f, serv, counter2 + caller5);
				graphicsPath.AddArc(serv, counter2, caller5 * 2f, caller5 * 2f, 180f, 90f);
				graphicsPath.CloseFigure();
				key.SmoothingMode = SmoothingMode.AntiAlias;
				key.DrawPath(caller, graphicsPath);
				key.SmoothingMode = SmoothingMode.Default;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002354 File Offset: 0x00000554
		public Candidate()
		{
			Class21.smethod_0();
			base..ctor();
		}
	}
}
