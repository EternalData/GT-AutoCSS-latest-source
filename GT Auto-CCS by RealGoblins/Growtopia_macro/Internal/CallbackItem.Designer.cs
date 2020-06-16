namespace Growtopia_macro.Internal
{
	// Token: 0x02000076 RID: 118
	public partial class CallbackItem : global::System.Windows.Forms.Form
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x00004500 File Offset: 0x00002700
		protected override void Dispose(bool appendconfig)
		{
			if (appendconfig && this.idisposable_0 != null)
			{
				this.idisposable_0.Dispose();
			}
			base.Dispose(appendconfig);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000258DC File Offset: 0x00023ADC
		private void InitializeComponent()
		{
			this.iTalk_Button_21 = new global::ns0.Control6();
			this.iTalk_TabControl1 = new global::ns0.Control16();
			this.mouse = new global::System.Windows.Forms.TabPage();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.iTalk_RichTextBox1 = new global::ns0.Control10();
			this.unbanner = new global::System.Windows.Forms.TabPage();
			this.iTalk_RichTextBox2 = new global::ns0.Control10();
			this.iTalk_TabControl1.SuspendLayout();
			this.mouse.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.unbanner.SuspendLayout();
			base.SuspendLayout();
			this.iTalk_Button_21.BackColor = global::System.Drawing.Color.Black;
			this.iTalk_Button_21.Font = new global::System.Drawing.Font("Segoe UI", 14f);
			this.iTalk_Button_21.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_Button_21.method_2(null);
			this.iTalk_Button_21.method_7(global::System.Drawing.ContentAlignment.MiddleLeft);
			this.iTalk_Button_21.Location = new global::System.Drawing.Point(12, 393);
			this.iTalk_Button_21.Name = "iTalk_Button_21";
			this.iTalk_Button_21.Size = new global::System.Drawing.Size(113, 29);
			this.iTalk_Button_21.TabIndex = 0;
			this.iTalk_Button_21.Text = "Close help";
			this.iTalk_Button_21.method_4(global::System.Drawing.StringAlignment.Center);
			this.iTalk_Button_21.Click += new global::System.EventHandler(this.iTalk_Button_21_Click);
			this.iTalk_TabControl1.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.iTalk_TabControl1.Controls.Add(this.mouse);
			this.iTalk_TabControl1.Controls.Add(this.unbanner);
			this.iTalk_TabControl1.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.iTalk_TabControl1.ItemSize = new global::System.Drawing.Size(44, 135);
			this.iTalk_TabControl1.Location = new global::System.Drawing.Point(3, 2);
			this.iTalk_TabControl1.Multiline = true;
			this.iTalk_TabControl1.Name = "iTalk_TabControl1";
			this.iTalk_TabControl1.SelectedIndex = 0;
			this.iTalk_TabControl1.Size = new global::System.Drawing.Size(781, 432);
			this.iTalk_TabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.iTalk_TabControl1.TabIndex = 1;
			this.mouse.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.mouse.Controls.Add(this.label2);
			this.mouse.Controls.Add(this.label1);
			this.mouse.Controls.Add(this.pictureBox1);
			this.mouse.Controls.Add(this.iTalk_RichTextBox1);
			this.mouse.Location = new global::System.Drawing.Point(139, 4);
			this.mouse.Name = "mouse";
			this.mouse.Padding = new global::System.Windows.Forms.Padding(3);
			this.mouse.Size = new global::System.Drawing.Size(638, 424);
			this.mouse.TabIndex = 0;
			this.mouse.Text = "Help - Mouse";
			this.mouse.Click += new global::System.EventHandler(this.mouse_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(377, 313);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "End pos";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(206, 313);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(49, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Start pos";
			this.pictureBox1.Image = global::Growtopia_macro.Properties.Resources.InvokeDescriptor();
			this.pictureBox1.Location = new global::System.Drawing.Point(167, 289);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(297, 128);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.iTalk_RichTextBox1.method_5(false);
			this.iTalk_RichTextBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.iTalk_RichTextBox1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.iTalk_RichTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_RichTextBox1.Location = new global::System.Drawing.Point(6, 6);
			this.iTalk_RichTextBox1.Name = "iTalk_RichTextBox1";
			this.iTalk_RichTextBox1.method_1(true);
			this.iTalk_RichTextBox1.Size = new global::System.Drawing.Size(627, 280);
			this.iTalk_RichTextBox1.TabIndex = 0;
			this.iTalk_RichTextBox1.method_3(true);
			this.iTalk_RichTextBox1.TextChanged += new global::System.EventHandler(this.iTalk_RichTextBox1_TextChanged);
			this.unbanner.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.unbanner.Controls.Add(this.iTalk_RichTextBox2);
			this.unbanner.Location = new global::System.Drawing.Point(139, 4);
			this.unbanner.Name = "unbanner";
			this.unbanner.Padding = new global::System.Windows.Forms.Padding(3);
			this.unbanner.Size = new global::System.Drawing.Size(638, 424);
			this.unbanner.TabIndex = 1;
			this.unbanner.Text = "Help - Unbanner";
			this.iTalk_RichTextBox2.method_5(false);
			this.iTalk_RichTextBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.iTalk_RichTextBox2.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.iTalk_RichTextBox2.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_RichTextBox2.Location = new global::System.Drawing.Point(5, 6);
			this.iTalk_RichTextBox2.Name = "iTalk_RichTextBox2";
			this.iTalk_RichTextBox2.method_1(true);
			this.iTalk_RichTextBox2.Size = new global::System.Drawing.Size(627, 410);
			this.iTalk_RichTextBox2.TabIndex = 1;
			this.iTalk_RichTextBox2.method_3(true);
			this.iTalk_RichTextBox2.TextChanged += new global::System.EventHandler(this.iTalk_RichTextBox2_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.ClientSize = new global::System.Drawing.Size(787, 435);
			base.Controls.Add(this.iTalk_Button_21);
			base.Controls.Add(this.iTalk_TabControl1);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Help";
			this.Text = "Help";
			this.iTalk_TabControl1.ResumeLayout(false);
			this.mouse.ResumeLayout(false);
			this.mouse.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.unbanner.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400029C RID: 668
		private global::System.IDisposable idisposable_0;

		// Token: 0x0400029D RID: 669
		private global::ns0.Control6 iTalk_Button_21;

		// Token: 0x0400029E RID: 670
		private global::ns0.Control16 iTalk_TabControl1;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.TabPage mouse;

		// Token: 0x040002A0 RID: 672
		private global::ns0.Control10 iTalk_RichTextBox1;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002A4 RID: 676
		private global::System.Windows.Forms.TabPage unbanner;

		// Token: 0x040002A5 RID: 677
		private global::ns0.Control10 iTalk_RichTextBox2;
	}
}
