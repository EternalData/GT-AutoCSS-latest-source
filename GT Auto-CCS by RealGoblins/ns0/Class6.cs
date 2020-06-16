using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ns0
{
	// Token: 0x0200001E RID: 30
	internal static class Class6
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00009978 File Offset: 0x00007B78
		public static GraphicsPath smethod_0(Rectangle rectangle_0, int int_0)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = int_0 * 2;
			graphicsPath.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Y, num, num), -180f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num), -90f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 0f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 90f, 90f);
			graphicsPath.AddLine(new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y), new Point(rectangle_0.X, int_0 + rectangle_0.Y));
			return graphicsPath;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00009A84 File Offset: 0x00007C84
		public static GraphicsPath smethod_1(int int_0, int int_1, int int_2, int int_3, int int_4)
		{
			Rectangle rectangle = new Rectangle(int_0, int_1, int_2, int_3);
			GraphicsPath graphicsPath = new GraphicsPath();
			int num = int_4 * 2;
			graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Y, num, num), -180f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0f, 90f);
			graphicsPath.AddArc(new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90f, 90f);
			graphicsPath.AddLine(new Point(rectangle.X, rectangle.Height - num + rectangle.Y), new Point(rectangle.X, int_4 + rectangle.Y));
			return graphicsPath;
		}
	}
}
