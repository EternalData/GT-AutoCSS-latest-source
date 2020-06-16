using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000054 RID: 84
	public class GetterVisitor : UserControl
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00010A04 File Offset: 0x0000EC04
		public GetterVisitor()
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

		// Token: 0x060002AB RID: 683 RVA: 0x00010ABC File Offset: 0x0000ECBC
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (this.bunifuCircleProgressbar1.Value == 90)
			{
				this.int_1 = -1;
				this.bunifuCircleProgressbar1.animationIterval = 4;
				this.method_0();
			}
			else if (this.bunifuCircleProgressbar1.Value == 10)
			{
				this.int_1 = 1;
				this.bunifuCircleProgressbar1.animationIterval = 2;
				this.method_0();
			}
			this.bunifuCircleProgressbar1.Value += this.int_1;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00010B34 File Offset: 0x0000ED34
		private void method_0()
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
			this.timer_1.Start();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		private void timer_1_Tick(object sender, EventArgs e)
		{
			if (this.bunifuColorTransition_0.ProgessValue < 100)
			{
				BunifuColorTransition bunifuColorTransition = this.bunifuColorTransition_0;
				int progessValue = bunifuColorTransition.ProgessValue;
				bunifuColorTransition.ProgessValue = progessValue + 1;
				this.bunifuCircleProgressbar1.ProgressColor = this.bunifuColorTransition_0.Value;
				return;
			}
			this.timer_1.Stop();
			this.bunifuColorTransition_0.Color1 = this.bunifuColorTransition_0.Color2;
			this.bunifuColorTransition_0.ProgessValue = 0;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003A84 File Offset: 0x00001C84
		protected override void Dispose(bool readtask)
		{
			if (readtask && this.container_0 != null)
			{
				((IDisposable)this.container_0).Dispose();
			}
			base.Dispose(readtask);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00010C28 File Offset: 0x0000EE28
		private void InitializeComponent()
		{
			this.container_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GetterVisitor));
			this.bunifuCircleProgressbar1 = new BunifuCircleProgressbar();
			this.timer_0 = new Timer(this.container_0);
			this.timer_1 = new Timer(this.container_0);
			this.bunifuColorTransition_0 = new BunifuColorTransition(this.container_0);
			base.SuspendLayout();
			this.bunifuCircleProgressbar1.animated = true;
			this.bunifuCircleProgressbar1.animationIterval = 2;
			this.bunifuCircleProgressbar1.animationSpeed = 1;
			this.bunifuCircleProgressbar1.BackColor = Color.Black;
			this.bunifuCircleProgressbar1.BackgroundImage = (Image)componentResourceManager.GetObject("bunifuCircleProgressbar1.BackgroundImage");
			this.bunifuCircleProgressbar1.Dock = DockStyle.Fill;
			this.bunifuCircleProgressbar1.Font = new Font("Microsoft Sans Serif", 26.25f);
			this.bunifuCircleProgressbar1.ForeColor = Color.SeaGreen;
			this.bunifuCircleProgressbar1.LabelVisible = false;
			this.bunifuCircleProgressbar1.LineProgressThickness = 8;
			this.bunifuCircleProgressbar1.LineThickness = 5;
			this.bunifuCircleProgressbar1.Location = new Point(0, 0);
			this.bunifuCircleProgressbar1.Margin = new Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar1.MaxValue = 100;
			this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
			this.bunifuCircleProgressbar1.ProgressBackColor = SystemColors.ActiveCaptionText;
			this.bunifuCircleProgressbar1.ProgressColor = Color.SeaGreen;
			this.bunifuCircleProgressbar1.Size = new Size(260, 260);
			this.bunifuCircleProgressbar1.TabIndex = 0;
			this.bunifuCircleProgressbar1.Value = 30;
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 30;
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_1.Interval = 10;
			this.timer_1.Tick += this.timer_1_Tick;
			this.bunifuColorTransition_0.Color1 = Color.White;
			this.bunifuColorTransition_0.Color2 = Color.White;
			this.bunifuColorTransition_0.ProgessValue = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.Controls.Add(this.bunifuCircleProgressbar1);
			base.Name = "MyPreloader";
			base.Size = new Size(288, 260);
			base.ResumeLayout(false);
		}

		// Token: 0x04000129 RID: 297
		private List<Color> list_0;

		// Token: 0x0400012A RID: 298
		private int int_0;

		// Token: 0x0400012B RID: 299
		private int int_1;

		// Token: 0x0400012C RID: 300
		private Container container_0;

		// Token: 0x0400012D RID: 301
		private BunifuCircleProgressbar bunifuCircleProgressbar1;

		// Token: 0x0400012E RID: 302
		private Timer timer_0;

		// Token: 0x0400012F RID: 303
		private Timer timer_1;

		// Token: 0x04000130 RID: 304
		private BunifuColorTransition bunifuColorTransition_0;
	}
}
