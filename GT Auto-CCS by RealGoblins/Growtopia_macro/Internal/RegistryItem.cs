using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000077 RID: 119
	public class RegistryItem : UserControl
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0002601C File Offset: 0x0002421C
		public RegistryItem()
		{
			Class21.smethod_0();
			this.list_0 = new List<Color>();
			this.int_1 = 1;
			base..ctor();
			this.InitializeComponent();
			this.list_0.Add(Color.FromArgb(0, 150, 136));
			this.list_0.Add(Color.FromArgb(0, 188, 212));
			this.list_0.Add(Color.FromArgb(63, 81, 181));
			this.list_0.Add(Color.FromArgb(156, 39, 176));
			this.bunifuCircleProgressbar1.ProgressColor = this.list_0[this.int_0];
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000260D4 File Offset: 0x000242D4
		private void method_0(object sender, EventArgs e)
		{
			if (this.bunifuCircleProgressbar1.Value == 90)
			{
				this.int_1 = -1;
				this.bunifuCircleProgressbar1.animationIterval = 4;
				this.method_1();
			}
			else if (this.bunifuCircleProgressbar1.Value == 10)
			{
				this.int_1 = 1;
				this.bunifuCircleProgressbar1.animationIterval = 2;
				this.method_1();
			}
			this.bunifuCircleProgressbar1.Value += this.int_1;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0002614C File Offset: 0x0002434C
		private void method_1()
		{
			this.bunifuColorTransition_0.Color1 = this.list_0[this.int_0];
			if (this.int_0 < this.list_0.Count - 1)
			{
				this.int_0++;
			}
			else
			{
				this.int_0 = 0;
			}
			this.bunifuColorTransition_0.Color2 = this.list_0[this.int_0];
			this.timer_0.Start();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000261C8 File Offset: 0x000243C8
		private void method_2(object sender, EventArgs e)
		{
			if (this.bunifuColorTransition_0.ProgessValue < 100)
			{
				BunifuColorTransition bunifuColorTransition = this.bunifuColorTransition_0;
				int progessValue = bunifuColorTransition.ProgessValue;
				bunifuColorTransition.ProgessValue = progessValue + 1;
				this.bunifuCircleProgressbar1.ProgressColor = this.bunifuColorTransition_0.Value;
				return;
			}
			this.timer_0.Stop();
			this.bunifuColorTransition_0.Color1 = this.bunifuColorTransition_0.Color2;
			this.bunifuColorTransition_0.ProgessValue = 0;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000451F File Offset: 0x0000271F
		protected override void Dispose(bool isdef)
		{
			if (isdef && this.container_0 != null)
			{
				((IDisposable)this.container_0).Dispose();
			}
			base.Dispose(isdef);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00026240 File Offset: 0x00024440
		private void InitializeComponent()
		{
			this.container_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RegistryItem));
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.bunifuProgressBar1 = new BunifuProgressBar();
			this.bunifuCircleProgressbar1 = new BunifuCircleProgressbar();
			this.bunifuColorTransition_0 = new BunifuColorTransition(this.container_0);
			this.timer_0 = new Timer(this.container_0);
			base.SuspendLayout();
			this.panel1.BackColor = Color.Black;
			this.panel1.BackgroundImage = (Image)componentResourceManager.GetObject("panel1.BackgroundImage");
			this.panel1.BackgroundImageLayout = ImageLayout.Zoom;
			this.panel1.Location = new Point(257, -12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(231, 157);
			this.panel1.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans", 18f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(15, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(304, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "GT Auto-CCS by RealGoblins";
			this.bunifuProgressBar1.BackColor = Color.Silver;
			this.bunifuProgressBar1.BorderRadius = 5;
			this.bunifuProgressBar1.Location = new Point(42, 245);
			this.bunifuProgressBar1.MaximumValue = 100;
			this.bunifuProgressBar1.Name = "bunifuProgressBar1";
			this.bunifuProgressBar1.ProgressColor = Color.Teal;
			this.bunifuProgressBar1.Size = new Size(372, 27);
			this.bunifuProgressBar1.TabIndex = 0;
			this.bunifuProgressBar1.Value = 0;
			this.bunifuCircleProgressbar1.animated = true;
			this.bunifuCircleProgressbar1.animationIterval = 5;
			this.bunifuCircleProgressbar1.animationSpeed = 300;
			this.bunifuCircleProgressbar1.BackColor = Color.Black;
			this.bunifuCircleProgressbar1.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuCircleProgressbar1.BackgroundImage");
			this.bunifuCircleProgressbar1.Font = new Font("Microsoft Sans Serif", 26.25f);
			this.bunifuCircleProgressbar1.ForeColor = Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = true;
			this.bunifuCircleProgressbar1.LineProgressThickness = 8;
			this.bunifuCircleProgressbar1.LineThickness = 5;
			this.bunifuCircleProgressbar1.Location = new Point(98, 47);
			this.bunifuCircleProgressbar1.Margin = new Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = Color.Black;
			this.bunifuCircleProgressbar1.ProgressColor = Color.SeaGreen;
			this.bunifuCircleProgressbar1.Size = new Size(169, 169);
			this.bunifuCircleProgressbar1.TabIndex = 3;
			this.bunifuCircleProgressbar1.Value = 30;
			this.bunifuColorTransition_0.Color1 = Color.White;
			this.bunifuColorTransition_0.Color2 = Color.White;
			this.bunifuColorTransition_0.ProgessValue = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.bunifuCircleProgressbar1);
			base.Controls.Add(this.bunifuProgressBar1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			this.ForeColor = Color.White;
			base.Name = "Loading";
			base.Size = new Size(453, 305);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002A6 RID: 678
		private List<Color> list_0;

		// Token: 0x040002A7 RID: 679
		private int int_0;

		// Token: 0x040002A8 RID: 680
		private int int_1;

		// Token: 0x040002A9 RID: 681
		private Container container_0;

		// Token: 0x040002AA RID: 682
		private Panel panel1;

		// Token: 0x040002AB RID: 683
		private Label label1;

		// Token: 0x040002AC RID: 684
		private BunifuProgressBar bunifuProgressBar1;

		// Token: 0x040002AD RID: 685
		private BunifuCircleProgressbar bunifuCircleProgressbar1;

		// Token: 0x040002AE RID: 686
		private BunifuColorTransition bunifuColorTransition_0;

		// Token: 0x040002AF RID: 687
		private Timer timer_0;
	}
}
