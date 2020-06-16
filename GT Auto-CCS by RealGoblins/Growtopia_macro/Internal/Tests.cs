using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000006 RID: 6
	public class Tests
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00005B28 File Offset: 0x00003D28
		public static void ValidateList(Graphics param, Color map, Color tag, int meankey2, int cust3, int setup4_ID, int value5_Position)
		{
			Rectangle rect = new Rectangle(meankey2, cust3, setup4_ID, value5_Position);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, map, tag, LinearGradientMode.Vertical))
			{
				param.FillRectangle(linearGradientBrush, rect);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00005B74 File Offset: 0x00003D74
		public static void OrderList(Graphics config, Color second, Color dic, Color visitor2, float var13, int removeCONFIG4At, int column_reference5, int indexOfcol6, int indexOf_col7, int cust8_min)
		{
			ColorBlend colorBlend = new ColorBlend(3);
			colorBlend.Colors = new Color[]
			{
				second,
				dic,
				visitor2
			};
			colorBlend.Positions = new float[]
			{
				0f,
				var13,
				1f
			};
			Rectangle rect = new Rectangle(column_reference5, indexOfcol6, indexOf_col7, cust8_min);
			using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, second, second, (LinearGradientMode)removeCONFIG4At))
			{
				linearGradientBrush.InterpolationColors = colorBlend;
				config.FillRectangle(linearGradientBrush, rect);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002354 File Offset: 0x00000554
		public Tests()
		{
			Class21.smethod_0();
			base..ctor();
		}
	}
}
