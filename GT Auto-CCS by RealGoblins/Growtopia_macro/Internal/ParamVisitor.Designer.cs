namespace Growtopia_macro.Internal
{
	// Token: 0x02000057 RID: 87
	public partial class ParamVisitor : global::System.Windows.Forms.Form
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0001A81C File Offset: 0x00018A1C
		protected override void Dispose(bool readinfo)
		{
			global::Growtopia_macro.Internal.ParamVisitor.SpecificationTest specificationTest = new global::Growtopia_macro.Internal.ParamVisitor.SpecificationTest();
			specificationTest._PolicyTest = this;
			specificationTest._ParameterTest = readinfo;
			if (specificationTest._ParameterTest && this.container_0 != null)
			{
				((global::System.IDisposable)this.container_0).Dispose();
			}
			base.BeginInvoke(new global::System.Windows.Forms.MethodInvoker(specificationTest.StopAttr));
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0001A86C File Offset: 0x00018A6C
		private void InitializeComponent()
		{
			this.container_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Growtopia_macro.Internal.ParamVisitor));
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.pictureBox5 = new global::System.Windows.Forms.PictureBox();
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.label17 = new global::System.Windows.Forms.Label();
			this.pictureBox9 = new global::System.Windows.Forms.PictureBox();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.container_0);
			this.Macros_box = new global::System.Windows.Forms.GroupBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.label23 = new global::System.Windows.Forms.Label();
			this.label22 = new global::System.Windows.Forms.Label();
			this.Macros = new global::System.Windows.Forms.CheckedListBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.trackBar2 = new global::System.Windows.Forms.TrackBar();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button30 = new global::System.Windows.Forms.Button();
			this.numericUpDown3 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown4 = new global::System.Windows.Forms.NumericUpDown();
			this.button6 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.maskedTextBox1 = new global::System.Windows.Forms.MaskedTextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBox7 = new global::System.Windows.Forms.CheckBox();
			this.RefreshSpam = new global::System.Windows.Forms.Button();
			this.button14 = new global::System.Windows.Forms.Button();
			this.Refresh = new global::System.Windows.Forms.Button();
			this.no_GT_windows = new global::System.Windows.Forms.NumericUpDown();
			this.button31 = new global::System.Windows.Forms.Button();
			this.button34 = new global::System.Windows.Forms.Button();
			this.button35 = new global::System.Windows.Forms.Button();
			this.button37 = new global::System.Windows.Forms.Button();
			this.label19 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label31 = new global::System.Windows.Forms.Label();
			this.iTalk_TabControl1 = new global::ns0.Control16();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.Windows_box = new global::System.Windows.Forms.GroupBox();
			this.label44 = new global::System.Windows.Forms.Label();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.Windows = new global::System.Windows.Forms.CheckedListBox();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.tabControl3 = new global::System.Windows.Forms.TabControl();
			this.tabPage15 = new global::System.Windows.Forms.TabPage();
			this.EnableSpammer = new global::System.Windows.Forms.CheckBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.checkBox6 = new global::System.Windows.Forms.CheckBox();
			this.MsgSpamTo = new global::System.Windows.Forms.MaskedTextBox();
			this.addInFront = new global::System.Windows.Forms.MaskedTextBox();
			this.AddInFrontCheckBox = new global::System.Windows.Forms.CheckBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.SpamDelay = new global::System.Windows.Forms.NumericUpDown();
			this.MsgSpamCheckBox = new global::System.Windows.Forms.CheckBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.Attach = new global::System.Windows.Forms.GroupBox();
			this.ProcessesSpam = new global::System.Windows.Forms.CheckedListBox();
			this.SelectAllSpam = new global::System.Windows.Forms.CheckBox();
			this.spammertextgroup = new global::System.Windows.Forms.GroupBox();
			this.SpamTxt4 = new global::System.Windows.Forms.CheckBox();
			this.SpamTxt3 = new global::System.Windows.Forms.CheckBox();
			this.SpamTxt2 = new global::System.Windows.Forms.CheckBox();
			this.SpammerText4 = new global::System.Windows.Forms.MaskedTextBox();
			this.SpammerText3 = new global::System.Windows.Forms.MaskedTextBox();
			this.SpammerText2 = new global::System.Windows.Forms.MaskedTextBox();
			this.SpammerText1 = new global::System.Windows.Forms.MaskedTextBox();
			this.SpamTxt1 = new global::System.Windows.Forms.CheckBox();
			this.tabPage16 = new global::System.Windows.Forms.TabPage();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.groupBox9 = new global::System.Windows.Forms.GroupBox();
			this.numericUpDown8 = new global::System.Windows.Forms.NumericUpDown();
			this.checkedListBox5 = new global::System.Windows.Forms.CheckedListBox();
			this.label41 = new global::System.Windows.Forms.Label();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.bunifuCheckbox2 = new global::Bunifu.Framework.UI.BunifuCheckbox();
			this.label37 = new global::System.Windows.Forms.Label();
			this.label40 = new global::System.Windows.Forms.Label();
			this.label38 = new global::System.Windows.Forms.Label();
			this.bunifuCheckbox1 = new global::Bunifu.Framework.UI.BunifuCheckbox();
			this.label39 = new global::System.Windows.Forms.Label();
			this.iTalk_HeaderLabel1 = new global::ns0.Class9();
			this.listBox2 = new global::System.Windows.Forms.ListBox();
			this.label42 = new global::System.Windows.Forms.Label();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.label15 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.numericUpDown7 = new global::System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.numericUpDown5 = new global::System.Windows.Forms.NumericUpDown();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.checkBox5 = new global::System.Windows.Forms.CheckBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.GT_version_cmd = new global::System.Windows.Forms.ComboBox();
			this.button15 = new global::System.Windows.Forms.Button();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.checkedListBox2 = new global::System.Windows.Forms.CheckedListBox();
			this.numericUpDown6 = new global::System.Windows.Forms.NumericUpDown();
			this.Execute = new global::System.Windows.Forms.Button();
			this.tabPage14 = new global::System.Windows.Forms.TabPage();
			this.label30 = new global::System.Windows.Forms.Label();
			this.label29 = new global::System.Windows.Forms.Label();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.Variable = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Value = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label27 = new global::System.Windows.Forms.Label();
			this.label26 = new global::System.Windows.Forms.Label();
			this.button33 = new global::System.Windows.Forms.Button();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.button32 = new global::System.Windows.Forms.Button();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.button29 = new global::System.Windows.Forms.Button();
			this.button28 = new global::System.Windows.Forms.Button();
			this.button27 = new global::System.Windows.Forms.Button();
			this.button26 = new global::System.Windows.Forms.Button();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button12 = new global::System.Windows.Forms.Button();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.tabPage7 = new global::System.Windows.Forms.TabPage();
			this.SearchGroup = new global::System.Windows.Forms.GroupBox();
			this.maskedTextBox2 = new global::System.Windows.Forms.MaskedTextBox();
			this.button13 = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.tabPage8 = new global::System.Windows.Forms.TabPage();
			this.tabControl2 = new global::System.Windows.Forms.TabControl();
			this.tabPage12 = new global::System.Windows.Forms.TabPage();
			this.panel5 = new global::System.Windows.Forms.Panel();
			this.label36 = new global::System.Windows.Forms.Label();
			this.label35 = new global::System.Windows.Forms.Label();
			this.comboBox4 = new global::System.Windows.Forms.ComboBox();
			this.label34 = new global::System.Windows.Forms.Label();
			this.label32 = new global::System.Windows.Forms.Label();
			this.MB_enable = new global::System.Windows.Forms.CheckBox();
			this.checkBox8 = new global::System.Windows.Forms.CheckBox();
			this.checkBox9 = new global::System.Windows.Forms.CheckBox();
			this.label25 = new global::System.Windows.Forms.Label();
			this.iTalk_NumericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.checkedListBox4 = new global::System.Windows.Forms.CheckedListBox();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label33 = new global::System.Windows.Forms.Label();
			this.startGTwindows = new global::System.Windows.Forms.Button();
			this.close_gt_windows = new global::System.Windows.Forms.Button();
			this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			this.Select_all = new global::System.Windows.Forms.CheckBox();
			this.tabPage13 = new global::System.Windows.Forms.TabPage();
			this.groupBox8 = new global::System.Windows.Forms.GroupBox();
			this.bunifuFlatButton3 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.checkedListBox3 = new global::System.Windows.Forms.CheckedListBox();
			this.bunifuFlatButton2 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.iTalk_Label2 = new global::ns0.Class7();
			this.bunifuFlatButton1 = new global::Bunifu.Framework.UI.BunifuFlatButton();
			this.iTalk_Label1 = new global::ns0.Class7();
			this.iTalk_RichTextBox1 = new global::ns0.Control10();
			this.bunifuTileButton1 = new global::Bunifu.Framework.UI.BunifuTileButton();
			this.tabPage9 = new global::System.Windows.Forms.TabPage();
			this.button25 = new global::System.Windows.Forms.Button();
			this.m_QueueTests = new global::System.Windows.Forms.ListBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.UnbanButton = new global::System.Windows.Forms.Button();
			this.button24 = new global::System.Windows.Forms.Button();
			this.button22 = new global::System.Windows.Forms.Button();
			this.button23 = new global::System.Windows.Forms.Button();
			this.tabPage10 = new global::System.Windows.Forms.TabPage();
			this.button21 = new global::System.Windows.Forms.Button();
			this.label16 = new global::System.Windows.Forms.Label();
			this.button20 = new global::System.Windows.Forms.Button();
			this.button19 = new global::System.Windows.Forms.Button();
			this.button18 = new global::System.Windows.Forms.Button();
			this.button17 = new global::System.Windows.Forms.Button();
			this.button16 = new global::System.Windows.Forms.Button();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.maskedTextBox3 = new global::System.Windows.Forms.MaskedTextBox();
			this.checkBox4 = new global::System.Windows.Forms.CheckBox();
			this.pictureBox8 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox7 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox6 = new global::System.Windows.Forms.PictureBox();
			this.tabPage11 = new global::System.Windows.Forms.TabPage();
			this.label43 = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.checkBox10 = new global::System.Windows.Forms.CheckBox();
			this.bunifuThinButton22 = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuThinButton21 = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuThinButton23 = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.bunifuThinButton24 = new global::Bunifu.Framework.UI.BunifuThinButton2();
			this.label21 = new global::System.Windows.Forms.Label();
			this.dsugugdHGHSDGid730hjd = new global::System.Windows.Forms.PictureBox();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.discordLogo = new global::System.Windows.Forms.PictureBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.YTlogo = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox9).BeginInit();
			this.Macros_box.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.no_GT_windows).BeginInit();
			this.iTalk_TabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.Windows_box.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage15.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SpamDelay).BeginInit();
			this.Attach.SuspendLayout();
			this.spammertextgroup.SuspendLayout();
			this.tabPage16.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox9.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown8).BeginInit();
			this.tabPage5.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown7).BeginInit();
			this.groupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).BeginInit();
			this.groupBox5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown6).BeginInit();
			this.tabPage14.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.tabPage6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.tabPage7.SuspendLayout();
			this.SearchGroup.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.panel5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iTalk_NumericUpDown1).BeginInit();
			this.panel2.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox8).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).BeginInit();
			this.tabPage11.SuspendLayout();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dsugugdHGHSDGid730hjd).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.discordLogo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.YTlogo).BeginInit();
			base.SuspendLayout();
			this.openFileDialog_0.FileName = "openFileDialog1";
			this.pictureBox5.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.pictureBox5.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.pictureBox5.Image = global::Growtopia_macro.Properties.Resources.CountDescriptor();
			this.pictureBox5.Location = new global::System.Drawing.Point(1, 406);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new global::System.Drawing.Size(585, 31);
			this.pictureBox5.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 1;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new global::System.EventHandler(this.pictureBox5_Click);
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.label17.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label17.AutoSize = true;
			this.label17.BackColor = global::System.Drawing.Color.Transparent;
			this.label17.Font = new global::System.Drawing.Font("Comic Sans MS", 12f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.Lime;
			this.label17.Location = new global::System.Drawing.Point(12, 409);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(121, 23);
			this.label17.TabIndex = 2;
			this.label17.Text = "By RealGoblins";
			this.label17.Click += new global::System.EventHandler(this.label17_Click);
			this.pictureBox9.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox9.BackColor = global::System.Drawing.Color.White;
			this.pictureBox9.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox9.Location = new global::System.Drawing.Point(15, 406);
			this.pictureBox9.Margin = new global::System.Windows.Forms.Padding(0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new global::System.Drawing.Size(692, 1);
			this.pictureBox9.TabIndex = 7;
			this.pictureBox9.TabStop = false;
			this.Macros_box.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Macros_box.BackColor = global::System.Drawing.Color.Black;
			this.Macros_box.Controls.Add(this.label24);
			this.Macros_box.Controls.Add(this.label23);
			this.Macros_box.Controls.Add(this.label22);
			this.Macros_box.Controls.Add(this.Macros);
			this.Macros_box.Controls.Add(this.checkBox1);
			this.Macros_box.Controls.Add(this.button3);
			this.Macros_box.Controls.Add(this.trackBar2);
			this.Macros_box.ForeColor = global::System.Drawing.Color.White;
			this.Macros_box.Location = new global::System.Drawing.Point(211, 7);
			this.Macros_box.Name = "Macros_box";
			this.Macros_box.Size = new global::System.Drawing.Size(160, 387);
			this.Macros_box.TabIndex = 9;
			this.Macros_box.TabStop = false;
			this.Macros_box.Text = "Macros";
			this.toolTip_0.SetToolTip(this.Macros_box, "A list of macros. Select a macro to view its properties and attach it to a window or two");
			this.label24.AutoSize = true;
			this.label24.Location = new global::System.Drawing.Point(8, 309);
			this.label24.Name = "label24";
			this.label24.Size = new global::System.Drawing.Size(54, 18);
			this.label24.TabIndex = 6;
			this.label24.Text = "Speed:";
			this.label23.AutoSize = true;
			this.label23.Location = new global::System.Drawing.Point(115, 360);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(41, 18);
			this.label23.TabIndex = 5;
			this.label23.Text = "Slow";
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(4, 360);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(37, 18);
			this.label22.TabIndex = 4;
			this.label22.Text = "Fast";
			this.Macros.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Macros.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.Macros.ForeColor = global::System.Drawing.Color.White;
			this.Macros.FormattingEnabled = true;
			this.Macros.Location = new global::System.Drawing.Point(9, 53);
			this.Macros.Name = "Macros";
			this.Macros.Size = new global::System.Drawing.Size(142, 194);
			this.Macros.Sorted = true;
			this.Macros.TabIndex = 0;
			this.toolTip_0.SetToolTip(this.Macros, "Select a macro to view its properties and attach it to a window or two");
			this.Macros.SelectedIndexChanged += new global::System.EventHandler(this.Macros_SelectedIndexChanged);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(10, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(90, 22);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Enable all";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.button3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.AutoSize = true;
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(36, 253);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(91, 35);
			this.button3.TabIndex = 1;
			this.button3.Text = "Remove";
			this.toolTip_0.SetToolTip(this.button3, "Remove the selected macro from the list");
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.trackBar2.AutoSize = false;
			this.trackBar2.LargeChange = 20;
			this.trackBar2.Location = new global::System.Drawing.Point(10, 329);
			this.trackBar2.Maximum = 400;
			this.trackBar2.Minimum = 20;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new global::System.Drawing.Size(142, 34);
			this.trackBar2.SmallChange = 20;
			this.trackBar2.TabIndex = 20;
			this.trackBar2.TickFrequency = 20;
			this.trackBar2.Value = 100;
			this.trackBar2.Scroll += new global::System.EventHandler(this.trackBar2_Scroll);
			this.button5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button5.ForeColor = global::System.Drawing.Color.White;
			this.button5.Location = new global::System.Drawing.Point(4, 346);
			this.button5.Margin = new global::System.Windows.Forms.Padding(1, 3, 1, 3);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(82, 35);
			this.button5.TabIndex = 3;
			this.button5.Text = "Refresh";
			this.toolTip_0.SetToolTip(this.button5, "Refresh the list of open windows");
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button4.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button4.ForeColor = global::System.Drawing.Color.White;
			this.button4.Location = new global::System.Drawing.Point(91, 346);
			this.button4.Margin = new global::System.Windows.Forms.Padding(1, 3, 1, 3);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(103, 35);
			this.button4.TabIndex = 2;
			this.button4.Text = "Bring to front";
			this.toolTip_0.SetToolTip(this.button4, "Bring the selected window to front");
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.groupBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.groupBox1.BackColor = global::System.Drawing.Color.Black;
			this.groupBox1.Controls.Add(this.button30);
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown4);
			this.groupBox1.Controls.Add(this.button6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(0, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(205, 387);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add";
			this.toolTip_0.SetToolTip(this.groupBox1, "Add a macro to the macro list");
			this.button30.BackColor = global::System.Drawing.Color.Transparent;
			this.button30.FlatAppearance.BorderSize = 0;
			this.button30.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button30.ForeColor = global::System.Drawing.Color.Transparent;
			this.button30.Image = global::Growtopia_macro.Properties.Resources.CancelDescriptor();
			this.button30.Location = new global::System.Drawing.Point(167, 23);
			this.button30.Name = "button30";
			this.button30.Size = new global::System.Drawing.Size(34, 30);
			this.button30.TabIndex = 17;
			this.toolTip_0.SetToolTip(this.button30, "Help");
			this.button30.UseVisualStyleBackColor = false;
			this.button30.Click += new global::System.EventHandler(this.button30_Click);
			this.button30.MouseLeave += new global::System.EventHandler(this.button30_MouseLeave);
			this.button30.MouseHover += new global::System.EventHandler(this.button30_MouseHover);
			this.numericUpDown3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown3.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown3.Location = new global::System.Drawing.Point(45, 248);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown3;
			int[] array = new int[4];
			array[0] = -727379968;
			array[1] = 232;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown3.Minimum = new decimal(new int[]
			{
				1215752192,
				23,
				0,
				int.MinValue
			});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new global::System.Drawing.Size(85, 24);
			this.numericUpDown3.TabIndex = 16;
			this.numericUpDown3.ThousandsSeparator = true;
			this.numericUpDown4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown4.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown4.Location = new global::System.Drawing.Point(45, 204);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown4;
			int[] array2 = new int[4];
			array2[0] = 1215752192;
			array2[1] = 23;
			numericUpDown2.Maximum = new decimal(array2);
			this.numericUpDown4.Minimum = new decimal(new int[]
			{
				-727379968,
				232,
				0,
				int.MinValue
			});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new global::System.Drawing.Size(85, 24);
			this.numericUpDown4.TabIndex = 15;
			this.button6.AutoSize = true;
			this.button6.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = global::System.Drawing.Color.White;
			this.button6.Location = new global::System.Drawing.Point(136, 224);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(61, 30);
			this.button6.TabIndex = 14;
			this.button6.Text = "Select";
			this.toolTip_0.SetToolTip(this.button6, "Select the end position for the macro");
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(11, 250);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(17, 18);
			this.label5.TabIndex = 13;
			this.label5.Text = "Y";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(11, 206);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(18, 18);
			this.label6.TabIndex = 12;
			this.label6.Text = "X";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(6, 176);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(67, 18);
			this.label7.TabIndex = 11;
			this.label7.Text = "End pos:";
			this.numericUpDown2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown2.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown2.Location = new global::System.Drawing.Point(46, 135);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = -727379968;
			array3[1] = 232;
			numericUpDown3.Maximum = new decimal(array3);
			this.numericUpDown2.Minimum = new decimal(new int[]
			{
				1215752192,
				23,
				0,
				int.MinValue
			});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(84, 24);
			this.numericUpDown2.TabIndex = 10;
			this.numericUpDown2.ThousandsSeparator = true;
			this.numericUpDown1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown1.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown1.Location = new global::System.Drawing.Point(46, 91);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown1;
			int[] array4 = new int[4];
			array4[0] = 1215752192;
			array4[1] = 23;
			numericUpDown4.Maximum = new decimal(array4);
			this.numericUpDown1.Minimum = new decimal(new int[]
			{
				-727379968,
				232,
				0,
				int.MinValue
			});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(84, 24);
			this.numericUpDown1.TabIndex = 9;
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.button2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.button2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(46, 308);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(100, 35);
			this.button2.TabIndex = 8;
			this.button2.Text = "Add";
			this.toolTip_0.SetToolTip(this.button2, "Add a macro with the properties above");
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(136, 114);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(61, 30);
			this.button1.TabIndex = 7;
			this.button1.Text = "Select";
			this.toolTip_0.SetToolTip(this.button1, "Select the start position for the macro");
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(11, 141);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(17, 18);
			this.label4.TabIndex = 4;
			this.label4.Text = "Y";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(11, 97);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(18, 18);
			this.label3.TabIndex = 3;
			this.label3.Text = "X";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(7, 63);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(72, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Start pos:";
			this.maskedTextBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.maskedTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.maskedTextBox1.Location = new global::System.Drawing.Point(65, 28);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new global::System.Drawing.Size(100, 24);
			this.maskedTextBox1.TabIndex = 1;
			this.toolTip_0.SetToolTip(this.maskedTextBox1, "The name of the macro, can be anything");
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(7, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(52, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			this.checkBox7.AutoSize = true;
			this.checkBox7.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBox7.Location = new global::System.Drawing.Point(13, 138);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new global::System.Drawing.Size(190, 22);
			this.checkBox7.TabIndex = 13;
			this.checkBox7.Text = "Stack the text (Premium)";
			this.toolTip_0.SetToolTip(this.checkBox7, "[Premium only]");
			this.checkBox7.UseVisualStyleBackColor = false;
			this.checkBox7.CheckedChanged += new global::System.EventHandler(this.checkBox7_CheckedChanged);
			this.RefreshSpam.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.RefreshSpam.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.RefreshSpam.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.RefreshSpam.ForeColor = global::System.Drawing.Color.White;
			this.RefreshSpam.Location = new global::System.Drawing.Point(173, 123);
			this.RefreshSpam.Name = "RefreshSpam";
			this.RefreshSpam.Size = new global::System.Drawing.Size(72, 31);
			this.RefreshSpam.TabIndex = 7;
			this.RefreshSpam.Text = "Refresh";
			this.toolTip_0.SetToolTip(this.RefreshSpam, "Refresh the list of open windows");
			this.RefreshSpam.UseVisualStyleBackColor = false;
			this.RefreshSpam.Click += new global::System.EventHandler(this.RefreshSpam_Click);
			this.button14.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button14.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button14.ForeColor = global::System.Drawing.Color.White;
			this.button14.Location = new global::System.Drawing.Point(6, 330);
			this.button14.Name = "button14";
			this.button14.Size = new global::System.Drawing.Size(150, 37);
			this.button14.TabIndex = 2;
			this.button14.Text = "Refresh";
			this.toolTip_0.SetToolTip(this.button14, "Refresh the list of open windows");
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new global::System.EventHandler(this.button14_Click);
			this.Refresh.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.Refresh.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Refresh.ForeColor = global::System.Drawing.Color.White;
			this.Refresh.Location = new global::System.Drawing.Point(21, 268);
			this.Refresh.Name = "Refresh";
			this.Refresh.Size = new global::System.Drawing.Size(90, 35);
			this.Refresh.TabIndex = 3;
			this.Refresh.Text = "Refresh";
			this.toolTip_0.SetToolTip(this.Refresh, "Refresh the list of open windows");
			this.Refresh.UseVisualStyleBackColor = false;
			this.Refresh.Click += new global::System.EventHandler(this.Refresh_Click);
			this.no_GT_windows.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.no_GT_windows.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.no_GT_windows.Location = new global::System.Drawing.Point(150, 25);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.no_GT_windows;
			int[] array5 = new int[4];
			array5[0] = 1874919423;
			array5[1] = 2328306;
			numericUpDown5.Maximum = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.no_GT_windows;
			int[] array6 = new int[4];
			array6[0] = 1;
			numericUpDown6.Minimum = new decimal(array6);
			this.no_GT_windows.Name = "no_GT_windows";
			this.no_GT_windows.Size = new global::System.Drawing.Size(72, 24);
			this.no_GT_windows.TabIndex = 1;
			this.toolTip_0.SetToolTip(this.no_GT_windows, "Number of windows to open");
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.no_GT_windows;
			int[] array7 = new int[4];
			array7[0] = 1;
			numericUpDown7.Value = new decimal(array7);
			this.no_GT_windows.ValueChanged += new global::System.EventHandler(this.no_GT_windows_ValueChanged);
			this.button31.BackColor = global::System.Drawing.Color.Transparent;
			this.button31.FlatAppearance.BorderSize = 0;
			this.button31.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button31.ForeColor = global::System.Drawing.Color.Transparent;
			this.button31.Image = global::Growtopia_macro.Properties.Resources.CancelDescriptor();
			this.button31.Location = new global::System.Drawing.Point(546, 7);
			this.button31.Name = "button31";
			this.button31.Size = new global::System.Drawing.Size(34, 30);
			this.button31.TabIndex = 18;
			this.toolTip_0.SetToolTip(this.button31, "Help");
			this.button31.UseVisualStyleBackColor = false;
			this.button31.Click += new global::System.EventHandler(this.button31_Click);
			this.button34.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button34.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button34.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.button34.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button34.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button34.ForeColor = global::System.Drawing.Color.White;
			this.button34.Location = new global::System.Drawing.Point(451, 138);
			this.button34.Name = "button34";
			this.button34.Size = new global::System.Drawing.Size(93, 59);
			this.button34.TabIndex = 9;
			this.button34.Text = "Add";
			this.toolTip_0.SetToolTip(this.button34, "Add a spammer instannce with the properties above");
			this.button34.UseVisualStyleBackColor = false;
			this.button34.Click += new global::System.EventHandler(this.button34_Click);
			this.button35.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button35.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button35.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.button35.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button35.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button35.ForeColor = global::System.Drawing.Color.White;
			this.button35.Location = new global::System.Drawing.Point(451, 203);
			this.button35.Name = "button35";
			this.button35.Size = new global::System.Drawing.Size(93, 59);
			this.button35.TabIndex = 10;
			this.button35.Text = "Remove";
			this.toolTip_0.SetToolTip(this.button35, "Remove the selected spammer instance");
			this.button35.UseVisualStyleBackColor = false;
			this.button35.Click += new global::System.EventHandler(this.button35_Click);
			this.button37.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button37.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button37.FlatAppearance.BorderColor = global::System.Drawing.Color.White;
			this.button37.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button37.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button37.ForeColor = global::System.Drawing.Color.White;
			this.button37.Location = new global::System.Drawing.Point(451, 268);
			this.button37.Name = "button37";
			this.button37.Size = new global::System.Drawing.Size(93, 59);
			this.button37.TabIndex = 12;
			this.button37.Text = "Enable\r\nDisable";
			this.toolTip_0.SetToolTip(this.button37, "Enable/disable the selected spammer instance");
			this.button37.UseVisualStyleBackColor = false;
			this.button37.Click += new global::System.EventHandler(this.button37_Click);
			this.label19.AutoSize = true;
			this.label19.Location = new global::System.Drawing.Point(451, 424);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(41, 13);
			this.label19.TabIndex = 12;
			this.label19.Text = "label19";
			this.label20.AutoSize = true;
			this.label20.Location = new global::System.Drawing.Point(451, 409);
			this.label20.Name = "label20";
			this.label20.Size = new global::System.Drawing.Size(41, 13);
			this.label20.TabIndex = 13;
			this.label20.Text = "label20";
			this.label20.Click += new global::System.EventHandler(this.label20_Click);
			this.label28.AutoSize = true;
			this.label28.Location = new global::System.Drawing.Point(594, 423);
			this.label28.Name = "label28";
			this.label28.Size = new global::System.Drawing.Size(110, 13);
			this.label28.TabIndex = 14;
			this.label28.Text = "Server might be down";
			this.label31.AutoSize = true;
			this.label31.Location = new global::System.Drawing.Point(594, 409);
			this.label31.Name = "label31";
			this.label31.Size = new global::System.Drawing.Size(78, 13);
			this.label31.TabIndex = 15;
			this.label31.Text = "Not connected";
			this.iTalk_TabControl1.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.iTalk_TabControl1.Controls.Add(this.tabPage3);
			this.iTalk_TabControl1.Controls.Add(this.tabPage4);
			this.iTalk_TabControl1.Controls.Add(this.tabPage5);
			this.iTalk_TabControl1.Controls.Add(this.tabPage14);
			this.iTalk_TabControl1.Controls.Add(this.tabPage6);
			this.iTalk_TabControl1.Controls.Add(this.tabPage7);
			this.iTalk_TabControl1.Controls.Add(this.tabPage8);
			this.iTalk_TabControl1.Controls.Add(this.tabPage9);
			this.iTalk_TabControl1.Controls.Add(this.tabPage10);
			this.iTalk_TabControl1.Controls.Add(this.tabPage11);
			this.iTalk_TabControl1.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.iTalk_TabControl1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f);
			this.iTalk_TabControl1.ItemSize = new global::System.Drawing.Size(39, 135);
			this.iTalk_TabControl1.Location = new global::System.Drawing.Point(1, 1);
			this.iTalk_TabControl1.Multiline = true;
			this.iTalk_TabControl1.Name = "iTalk_TabControl1";
			this.iTalk_TabControl1.SelectedIndex = 0;
			this.iTalk_TabControl1.Size = new global::System.Drawing.Size(768, 402);
			this.iTalk_TabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.iTalk_TabControl1.TabIndex = 11;
			this.iTalk_TabControl1.SelectedIndexChanged += new global::System.EventHandler(this.iTalk_TabControl1_SelectedIndexChanged);
			this.tabPage3.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage3.Controls.Add(this.Macros_box);
			this.tabPage3.Controls.Add(this.Windows_box);
			this.tabPage3.Controls.Add(this.groupBox1);
			this.tabPage3.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Mouse";
			this.Windows_box.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.Windows_box.BackColor = global::System.Drawing.Color.Black;
			this.Windows_box.Controls.Add(this.label44);
			this.Windows_box.Controls.Add(this.checkBox2);
			this.Windows_box.Controls.Add(this.button5);
			this.Windows_box.Controls.Add(this.button4);
			this.Windows_box.Controls.Add(this.Windows);
			this.Windows_box.ForeColor = global::System.Drawing.Color.White;
			this.Windows_box.Location = new global::System.Drawing.Point(377, 7);
			this.Windows_box.Name = "Windows_box";
			this.Windows_box.Size = new global::System.Drawing.Size(198, 387);
			this.Windows_box.TabIndex = 10;
			this.Windows_box.TabStop = false;
			this.Windows_box.Text = "Windows";
			this.Windows_box.Enter += new global::System.EventHandler(this.Windows_box_Enter);
			this.label44.AutoSize = true;
			this.label44.Location = new global::System.Drawing.Point(299, 24);
			this.label44.Name = "label44";
			this.label44.Size = new global::System.Drawing.Size(62, 18);
			this.label44.TabIndex = 4;
			this.label44.Text = "Dhjasdh";
			this.checkBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new global::System.Drawing.Point(7, 27);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(86, 22);
			this.checkBox2.TabIndex = 3;
			this.checkBox2.Text = "Select all";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.Windows.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.Windows.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.Windows.CheckOnClick = true;
			this.Windows.ForeColor = global::System.Drawing.Color.White;
			this.Windows.FormattingEnabled = true;
			this.Windows.Location = new global::System.Drawing.Point(6, 53);
			this.Windows.Name = "Windows";
			this.Windows.Size = new global::System.Drawing.Size(184, 251);
			this.Windows.Sorted = true;
			this.Windows.TabIndex = 2;
			this.Windows.SelectedIndexChanged += new global::System.EventHandler(this.Windows_SelectedIndexChanged);
			this.tabPage4.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage4.Controls.Add(this.tabControl3);
			this.tabPage4.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Spammer";
			this.tabControl3.Controls.Add(this.tabPage15);
			this.tabControl3.Controls.Add(this.tabPage16);
			this.tabControl3.Location = new global::System.Drawing.Point(6, 7);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new global::System.Drawing.Size(561, 381);
			this.tabControl3.TabIndex = 7;
			this.tabPage15.BackColor = global::System.Drawing.Color.Black;
			this.tabPage15.Controls.Add(this.EnableSpammer);
			this.tabPage15.Controls.Add(this.groupBox2);
			this.tabPage15.Controls.Add(this.Attach);
			this.tabPage15.Controls.Add(this.spammertextgroup);
			this.tabPage15.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage15.Name = "tabPage15";
			this.tabPage15.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage15.Size = new global::System.Drawing.Size(553, 350);
			this.tabPage15.TabIndex = 0;
			this.tabPage15.Text = "Single spam instance";
			this.EnableSpammer.AutoSize = true;
			this.EnableSpammer.Location = new global::System.Drawing.Point(5, 5);
			this.EnableSpammer.Name = "EnableSpammer";
			this.EnableSpammer.Size = new global::System.Drawing.Size(72, 22);
			this.EnableSpammer.TabIndex = 1;
			this.EnableSpammer.Text = "Enable";
			this.EnableSpammer.UseVisualStyleBackColor = true;
			this.EnableSpammer.CheckedChanged += new global::System.EventHandler(this.EnableSpammer_CheckedChanged);
			this.groupBox2.Controls.Add(this.checkBox7);
			this.groupBox2.Controls.Add(this.checkBox6);
			this.groupBox2.Controls.Add(this.MsgSpamTo);
			this.groupBox2.Controls.Add(this.addInFront);
			this.groupBox2.Controls.Add(this.AddInFrontCheckBox);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.SpamDelay);
			this.groupBox2.Controls.Add(this.MsgSpamCheckBox);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.ForeColor = global::System.Drawing.Color.White;
			this.groupBox2.Location = new global::System.Drawing.Point(3, 184);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(272, 160);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new global::System.Drawing.Point(13, 111);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new global::System.Drawing.Size(150, 22);
			this.checkBox6.TabIndex = 11;
			this.checkBox6.Text = "NoShift (Premium)";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new global::System.EventHandler(this.checkBox6_CheckedChanged);
			this.MsgSpamTo.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.MsgSpamTo.ForeColor = global::System.Drawing.Color.White;
			this.MsgSpamTo.Location = new global::System.Drawing.Point(166, 82);
			this.MsgSpamTo.Name = "MsgSpamTo";
			this.MsgSpamTo.Size = new global::System.Drawing.Size(100, 24);
			this.MsgSpamTo.TabIndex = 11;
			this.addInFront.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.addInFront.ForeColor = global::System.Drawing.Color.White;
			this.addInFront.Location = new global::System.Drawing.Point(61, 49);
			this.addInFront.Name = "addInFront";
			this.addInFront.Size = new global::System.Drawing.Size(65, 24);
			this.addInFront.TabIndex = 8;
			this.addInFront.Text = "`#";
			this.AddInFrontCheckBox.AutoSize = true;
			this.AddInFrontCheckBox.ForeColor = global::System.Drawing.Color.White;
			this.AddInFrontCheckBox.Location = new global::System.Drawing.Point(13, 51);
			this.AddInFrontCheckBox.Name = "AddInFrontCheckBox";
			this.AddInFrontCheckBox.Size = new global::System.Drawing.Size(173, 22);
			this.AddInFrontCheckBox.TabIndex = 12;
			this.AddInFrontCheckBox.Text = "Add                   in front";
			this.AddInFrontCheckBox.UseVisualStyleBackColor = true;
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(128, 85);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(30, 18);
			this.label11.TabIndex = 10;
			this.label11.Text = "To:";
			this.SpamDelay.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.SpamDelay.DecimalPlaces = 1;
			this.SpamDelay.ForeColor = global::System.Drawing.Color.White;
			this.SpamDelay.Location = new global::System.Drawing.Point(63, 20);
			this.SpamDelay.Maximum = new decimal(new int[]
			{
				-1304428543,
				434162106,
				542,
				1245184
			});
			this.SpamDelay.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				1114112
			});
			this.SpamDelay.Name = "SpamDelay";
			this.SpamDelay.Size = new global::System.Drawing.Size(65, 24);
			this.SpamDelay.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown spamDelay = this.SpamDelay;
			int[] array8 = new int[4];
			array8[0] = 5;
			spamDelay.Value = new decimal(array8);
			this.MsgSpamCheckBox.AutoSize = true;
			this.MsgSpamCheckBox.Location = new global::System.Drawing.Point(13, 82);
			this.MsgSpamCheckBox.Name = "MsgSpamCheckBox";
			this.MsgSpamCheckBox.Size = new global::System.Drawing.Size(97, 22);
			this.MsgSpamCheckBox.TabIndex = 9;
			this.MsgSpamCheckBox.Text = "Msg spam";
			this.MsgSpamCheckBox.UseVisualStyleBackColor = true;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(11, 23);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(157, 18);
			this.label9.TabIndex = 6;
			this.label9.Text = "Delay                      sec";
			this.label9.Click += new global::System.EventHandler(this.label9_Click);
			this.Attach.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Attach.Controls.Add(this.ProcessesSpam);
			this.Attach.Controls.Add(this.RefreshSpam);
			this.Attach.Controls.Add(this.SelectAllSpam);
			this.Attach.ForeColor = global::System.Drawing.Color.White;
			this.Attach.Location = new global::System.Drawing.Point(290, 184);
			this.Attach.Name = "Attach";
			this.Attach.Size = new global::System.Drawing.Size(251, 160);
			this.Attach.TabIndex = 2;
			this.Attach.TabStop = false;
			this.Attach.Text = "Attach";
			this.ProcessesSpam.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.ProcessesSpam.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.ProcessesSpam.CheckOnClick = true;
			this.ProcessesSpam.ForeColor = global::System.Drawing.Color.White;
			this.ProcessesSpam.FormattingEnabled = true;
			this.ProcessesSpam.Location = new global::System.Drawing.Point(7, 42);
			this.ProcessesSpam.Name = "ProcessesSpam";
			this.ProcessesSpam.Size = new global::System.Drawing.Size(161, 99);
			this.ProcessesSpam.TabIndex = 0;
			this.ProcessesSpam.SelectedIndexChanged += new global::System.EventHandler(this.ProcessesSpam_SelectedIndexChanged);
			this.SelectAllSpam.AutoSize = true;
			this.SelectAllSpam.BackColor = global::System.Drawing.Color.Transparent;
			this.SelectAllSpam.Location = new global::System.Drawing.Point(8, 19);
			this.SelectAllSpam.Name = "SelectAllSpam";
			this.SelectAllSpam.Size = new global::System.Drawing.Size(86, 22);
			this.SelectAllSpam.TabIndex = 8;
			this.SelectAllSpam.Text = "Select all";
			this.SelectAllSpam.UseVisualStyleBackColor = false;
			this.SelectAllSpam.CheckedChanged += new global::System.EventHandler(this.SelectAllSpam_CheckedChanged);
			this.spammertextgroup.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.spammertextgroup.Controls.Add(this.SpamTxt4);
			this.spammertextgroup.Controls.Add(this.SpamTxt3);
			this.spammertextgroup.Controls.Add(this.SpamTxt2);
			this.spammertextgroup.Controls.Add(this.SpammerText4);
			this.spammertextgroup.Controls.Add(this.SpammerText3);
			this.spammertextgroup.Controls.Add(this.SpammerText2);
			this.spammertextgroup.Controls.Add(this.SpammerText1);
			this.spammertextgroup.Controls.Add(this.SpamTxt1);
			this.spammertextgroup.ForeColor = global::System.Drawing.Color.White;
			this.spammertextgroup.Location = new global::System.Drawing.Point(3, 26);
			this.spammertextgroup.Name = "spammertextgroup";
			this.spammertextgroup.Size = new global::System.Drawing.Size(544, 152);
			this.spammertextgroup.TabIndex = 4;
			this.spammertextgroup.TabStop = false;
			this.spammertextgroup.Text = "Spammer Text";
			this.SpamTxt4.AutoSize = true;
			this.SpamTxt4.BackColor = global::System.Drawing.Color.Transparent;
			this.SpamTxt4.Location = new global::System.Drawing.Point(15, 122);
			this.SpamTxt4.Name = "SpamTxt4";
			this.SpamTxt4.Size = new global::System.Drawing.Size(15, 14);
			this.SpamTxt4.TabIndex = 10;
			this.SpamTxt4.UseVisualStyleBackColor = false;
			this.SpamTxt4.CheckedChanged += new global::System.EventHandler(this.SpamTxt4_CheckedChanged);
			this.SpamTxt3.AutoSize = true;
			this.SpamTxt3.BackColor = global::System.Drawing.Color.Transparent;
			this.SpamTxt3.Location = new global::System.Drawing.Point(15, 92);
			this.SpamTxt3.Name = "SpamTxt3";
			this.SpamTxt3.Size = new global::System.Drawing.Size(15, 14);
			this.SpamTxt3.TabIndex = 9;
			this.SpamTxt3.UseVisualStyleBackColor = false;
			this.SpamTxt3.CheckedChanged += new global::System.EventHandler(this.SpamTxt3_CheckedChanged);
			this.SpamTxt2.AutoSize = true;
			this.SpamTxt2.BackColor = global::System.Drawing.Color.Transparent;
			this.SpamTxt2.Location = new global::System.Drawing.Point(15, 62);
			this.SpamTxt2.Name = "SpamTxt2";
			this.SpamTxt2.Size = new global::System.Drawing.Size(15, 14);
			this.SpamTxt2.TabIndex = 8;
			this.SpamTxt2.UseVisualStyleBackColor = false;
			this.SpamTxt2.CheckedChanged += new global::System.EventHandler(this.SpamTxt2_CheckedChanged);
			this.SpammerText4.AllowDrop = true;
			this.SpammerText4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.SpammerText4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.SpammerText4.ForeColor = global::System.Drawing.Color.White;
			this.SpammerText4.Location = new global::System.Drawing.Point(36, 116);
			this.SpammerText4.Name = "SpammerText4";
			this.SpammerText4.Size = new global::System.Drawing.Size(502, 24);
			this.SpammerText4.TabIndex = 6;
			this.SpammerText4.Text = "Text #4 (Premium)";
			this.SpammerText3.AllowDrop = true;
			this.SpammerText3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.SpammerText3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.SpammerText3.ForeColor = global::System.Drawing.Color.White;
			this.SpammerText3.Location = new global::System.Drawing.Point(36, 86);
			this.SpammerText3.Name = "SpammerText3";
			this.SpammerText3.Size = new global::System.Drawing.Size(502, 24);
			this.SpammerText3.TabIndex = 5;
			this.SpammerText3.Text = "Text #3 (Premium)";
			this.SpammerText2.AllowDrop = true;
			this.SpammerText2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.SpammerText2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.SpammerText2.ForeColor = global::System.Drawing.Color.White;
			this.SpammerText2.Location = new global::System.Drawing.Point(36, 56);
			this.SpammerText2.Name = "SpammerText2";
			this.SpammerText2.Size = new global::System.Drawing.Size(502, 24);
			this.SpammerText2.TabIndex = 4;
			this.SpammerText2.Text = "Text #2";
			this.SpammerText1.AllowDrop = true;
			this.SpammerText1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.SpammerText1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.SpammerText1.ForeColor = global::System.Drawing.Color.White;
			this.SpammerText1.Location = new global::System.Drawing.Point(36, 26);
			this.SpammerText1.Name = "SpammerText1";
			this.SpammerText1.Size = new global::System.Drawing.Size(502, 24);
			this.SpammerText1.TabIndex = 3;
			this.SpammerText1.Text = "Text #1";
			this.SpammerText1.MaskInputRejected += new global::System.Windows.Forms.MaskInputRejectedEventHandler(this.SpammerText1_MaskInputRejected);
			this.SpamTxt1.AutoSize = true;
			this.SpamTxt1.BackColor = global::System.Drawing.Color.Transparent;
			this.SpamTxt1.Checked = true;
			this.SpamTxt1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.SpamTxt1.Enabled = false;
			this.SpamTxt1.Location = new global::System.Drawing.Point(15, 32);
			this.SpamTxt1.Name = "SpamTxt1";
			this.SpamTxt1.Size = new global::System.Drawing.Size(15, 14);
			this.SpamTxt1.TabIndex = 7;
			this.SpamTxt1.UseVisualStyleBackColor = false;
			this.SpamTxt1.CheckedChanged += new global::System.EventHandler(this.SpamTxt1_CheckedChanged);
			this.tabPage16.BackColor = global::System.Drawing.Color.Black;
			this.tabPage16.Controls.Add(this.panel3);
			this.tabPage16.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage16.Name = "tabPage16";
			this.tabPage16.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage16.Size = new global::System.Drawing.Size(553, 350);
			this.tabPage16.TabIndex = 1;
			this.tabPage16.Text = "Multi spammer";
			this.panel3.Controls.Add(this.groupBox9);
			this.panel3.Controls.Add(this.iTalk_HeaderLabel1);
			this.panel3.Controls.Add(this.listBox2);
			this.panel3.Controls.Add(this.label42);
			this.panel3.Controls.Add(this.button34);
			this.panel3.Controls.Add(this.button37);
			this.panel3.Controls.Add(this.button35);
			this.panel3.Location = new global::System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(550, 350);
			this.panel3.TabIndex = 22;
			this.groupBox9.BackColor = global::System.Drawing.Color.Black;
			this.groupBox9.Controls.Add(this.numericUpDown8);
			this.groupBox9.Controls.Add(this.checkedListBox5);
			this.groupBox9.Controls.Add(this.label41);
			this.groupBox9.Controls.Add(this.textBox4);
			this.groupBox9.Controls.Add(this.bunifuCheckbox2);
			this.groupBox9.Controls.Add(this.label37);
			this.groupBox9.Controls.Add(this.label40);
			this.groupBox9.Controls.Add(this.label38);
			this.groupBox9.Controls.Add(this.bunifuCheckbox1);
			this.groupBox9.Controls.Add(this.label39);
			this.groupBox9.ForeColor = global::System.Drawing.Color.White;
			this.groupBox9.Location = new global::System.Drawing.Point(3, -1);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new global::System.Drawing.Size(541, 130);
			this.groupBox9.TabIndex = 19;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Add spammers";
			this.numericUpDown8.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown8.DecimalPlaces = 1;
			this.numericUpDown8.ForeColor = global::System.Drawing.SystemColors.Info;
			this.numericUpDown8.Location = new global::System.Drawing.Point(484, 42);
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new global::System.Drawing.Size(53, 24);
			this.numericUpDown8.TabIndex = 19;
			this.numericUpDown8.Value = new decimal(new int[]
			{
				50,
				0,
				0,
				65536
			});
			this.checkedListBox5.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.checkedListBox5.ForeColor = global::System.Drawing.SystemColors.Info;
			this.checkedListBox5.FormattingEnabled = true;
			this.checkedListBox5.Location = new global::System.Drawing.Point(316, 42);
			this.checkedListBox5.Name = "checkedListBox5";
			this.checkedListBox5.Size = new global::System.Drawing.Size(120, 80);
			this.checkedListBox5.TabIndex = 5;
			this.checkedListBox5.SelectedIndexChanged += new global::System.EventHandler(this.checkedListBox5_SelectedIndexChanged);
			this.label41.AutoSize = true;
			this.label41.Location = new global::System.Drawing.Point(464, 104);
			this.label41.Name = "label41";
			this.label41.Size = new global::System.Drawing.Size(73, 18);
			this.label41.TabIndex = 18;
			this.label41.Text = "Stack text";
			this.textBox4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.textBox4.ForeColor = global::System.Drawing.Color.White;
			this.textBox4.Location = new global::System.Drawing.Point(6, 42);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(304, 80);
			this.textBox4.TabIndex = 1;
			this.bunifuCheckbox2.BackColor = global::System.Drawing.Color.FromArgb(51, 205, 117);
			this.bunifuCheckbox2.ChechedOffColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.bunifuCheckbox2.Checked = true;
			this.bunifuCheckbox2.CheckedOnColor = global::System.Drawing.Color.FromArgb(51, 205, 117);
			this.bunifuCheckbox2.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCheckbox2.Location = new global::System.Drawing.Point(439, 102);
			this.bunifuCheckbox2.Margin = new global::System.Windows.Forms.Padding(6);
			this.bunifuCheckbox2.Name = "bunifuCheckbox2";
			this.bunifuCheckbox2.Size = new global::System.Drawing.Size(20, 20);
			this.bunifuCheckbox2.TabIndex = 17;
			this.label37.AutoSize = true;
			this.label37.Location = new global::System.Drawing.Point(6, 21);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(144, 18);
			this.label37.TabIndex = 2;
			this.label37.Text = "Text(s) (one per line)";
			this.label40.AutoSize = true;
			this.label40.Location = new global::System.Drawing.Point(464, 74);
			this.label40.Name = "label40";
			this.label40.Size = new global::System.Drawing.Size(68, 18);
			this.label40.TabIndex = 16;
			this.label40.Text = "RGB text";
			this.label38.AutoSize = true;
			this.label38.Location = new global::System.Drawing.Point(313, 21);
			this.label38.Name = "label38";
			this.label38.Size = new global::System.Drawing.Size(66, 18);
			this.label38.TabIndex = 3;
			this.label38.Text = "Attach to";
			this.bunifuCheckbox1.BackColor = global::System.Drawing.Color.FromArgb(51, 205, 117);
			this.bunifuCheckbox1.ChechedOffColor = global::System.Drawing.Color.FromArgb(132, 135, 140);
			this.bunifuCheckbox1.Checked = true;
			this.bunifuCheckbox1.CheckedOnColor = global::System.Drawing.Color.FromArgb(51, 205, 117);
			this.bunifuCheckbox1.ForeColor = global::System.Drawing.Color.White;
			this.bunifuCheckbox1.Location = new global::System.Drawing.Point(439, 73);
			this.bunifuCheckbox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.bunifuCheckbox1.Name = "bunifuCheckbox1";
			this.bunifuCheckbox1.Size = new global::System.Drawing.Size(20, 20);
			this.bunifuCheckbox1.TabIndex = 15;
			this.label39.AutoSize = true;
			this.label39.Location = new global::System.Drawing.Point(439, 44);
			this.label39.Name = "label39";
			this.label39.Size = new global::System.Drawing.Size(45, 18);
			this.label39.TabIndex = 14;
			this.label39.Text = "Delay";
			this.iTalk_HeaderLabel1.AutoSize = true;
			this.iTalk_HeaderLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.iTalk_HeaderLabel1.Font = new global::System.Drawing.Font("Segoe UI", 25f);
			this.iTalk_HeaderLabel1.ForeColor = global::System.Drawing.Color.FromArgb(100, 100, 100);
			this.iTalk_HeaderLabel1.Location = new global::System.Drawing.Point(168, 144);
			this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
			this.iTalk_HeaderLabel1.Size = new global::System.Drawing.Size(174, 46);
			this.iTalk_HeaderLabel1.TabIndex = 21;
			this.iTalk_HeaderLabel1.Text = "[Premium]";
			this.listBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.listBox2.ForeColor = global::System.Drawing.SystemColors.Window;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 18;
			this.listBox2.Location = new global::System.Drawing.Point(9, 138);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new global::System.Drawing.Size(430, 184);
			this.listBox2.TabIndex = 0;
			this.listBox2.SelectedIndexChanged += new global::System.EventHandler(this.listBox2_SelectedIndexChanged);
			this.label42.AutoSize = true;
			this.label42.Location = new global::System.Drawing.Point(7, 324);
			this.label42.Name = "label42";
			this.label42.Size = new global::System.Drawing.Size(315, 18);
			this.label42.TabIndex = 20;
			this.label42.Text = "Use caps lock for UPPERCASE spammer text";
			this.tabPage5.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage5.Controls.Add(this.label15);
			this.tabPage5.Controls.Add(this.groupBox3);
			this.tabPage5.Controls.Add(this.numericUpDown7);
			this.tabPage5.Controls.Add(this.groupBox4);
			this.tabPage5.Controls.Add(this.label14);
			this.tabPage5.Controls.Add(this.groupBox5);
			this.tabPage5.Controls.Add(this.numericUpDown6);
			this.tabPage5.Controls.Add(this.Execute);
			this.tabPage5.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "Commands";
			this.label15.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label15.AutoSize = true;
			this.label15.Location = new global::System.Drawing.Point(485, 337);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(84, 18);
			this.label15.TabIndex = 8;
			this.label15.Text = "Delay (ms):";
			this.groupBox3.Controls.Add(this.button14);
			this.groupBox3.Controls.Add(this.listBox1);
			this.groupBox3.ForeColor = global::System.Drawing.Color.White;
			this.groupBox3.Location = new global::System.Drawing.Point(3, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(163, 383);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Attach to:";
			this.listBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.listBox1.ForeColor = global::System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 18;
			this.listBox1.Location = new global::System.Drawing.Point(6, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(150, 274);
			this.listBox1.Sorted = true;
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.numericUpDown7.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numericUpDown7.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown7.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown7.Location = new global::System.Drawing.Point(486, 358);
			this.numericUpDown7.Maximum = new decimal(new int[]
			{
				1241513983,
				370409800,
				542101,
				0
			});
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new global::System.Drawing.Size(87, 24);
			this.numericUpDown7.TabIndex = 7;
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.numericUpDown5);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Controls.Add(this.comboBox1);
			this.groupBox4.ForeColor = global::System.Drawing.Color.White;
			this.groupBox4.Location = new global::System.Drawing.Point(171, 7);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(145, 383);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Command";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(7, 258);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(84, 18);
			this.label13.TabIndex = 4;
			this.label13.Text = "Delay (ms):";
			this.label12.AllowDrop = true;
			this.label12.Location = new global::System.Drawing.Point(7, 326);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(133, 37);
			this.label12.TabIndex = 3;
			this.label12.Text = "Press F5 to cancel the operation";
			this.numericUpDown5.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown5.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown5.Location = new global::System.Drawing.Point(10, 284);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numericUpDown5;
			int[] array9 = new int[4];
			array9[0] = 100000;
			numericUpDown8.Maximum = new decimal(array9);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new global::System.Drawing.Size(120, 24);
			this.numericUpDown5.TabIndex = 2;
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numericUpDown5;
			int[] array10 = new int[4];
			array10[0] = 2000;
			numericUpDown9.Value = new decimal(array10);
			this.textBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.textBox1.ForeColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(6, 75);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(134, 167);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "message";
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.comboBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ForeColor = global::System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"/pull",
				"/kick",
				"/ban",
				"/msg"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(6, 35);
			this.comboBox1.MaxDropDownItems = 100;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(133, 26);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label14.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(485, 287);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(59, 18);
			this.label14.TabIndex = 6;
			this.label14.Text = "Repeat:";
			this.groupBox5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox5.Controls.Add(this.checkBox5);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Controls.Add(this.GT_version_cmd);
			this.groupBox5.Controls.Add(this.button15);
			this.groupBox5.Controls.Add(this.checkBox3);
			this.groupBox5.Controls.Add(this.checkedListBox2);
			this.groupBox5.ForeColor = global::System.Drawing.Color.White;
			this.groupBox5.Location = new global::System.Drawing.Point(323, 7);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(159, 383);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Apply to (players):";
			this.checkBox5.AllowDrop = true;
			this.checkBox5.Location = new global::System.Drawing.Point(6, 289);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new global::System.Drawing.Size(141, 49);
			this.checkBox5.TabIndex = 6;
			this.checkBox5.Text = "Auto refresh player list";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new global::System.EventHandler(this.checkBox5_CheckedChanged);
			this.label18.AutoSize = true;
			this.label18.Location = new global::System.Drawing.Point(10, 227);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(57, 18);
			this.label18.TabIndex = 5;
			this.label18.Text = "GT ver:";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(4, 344);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(64, 18);
			this.label10.TabIndex = 4;
			this.label10.Text = "GT wnd:";
			this.GT_version_cmd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.GT_version_cmd.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.GT_version_cmd.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GT_version_cmd.ForeColor = global::System.Drawing.Color.White;
			this.GT_version_cmd.FormattingEnabled = true;
			this.GT_version_cmd.Items.AddRange(new object[]
			{
				"Fixed GT",
				"3.000",
				"3.011",
				"3.021"
			});
			this.GT_version_cmd.Location = new global::System.Drawing.Point(70, 222);
			this.GT_version_cmd.Name = "GT_version_cmd";
			this.GT_version_cmd.Size = new global::System.Drawing.Size(80, 26);
			this.GT_version_cmd.TabIndex = 5;
			this.GT_version_cmd.SelectedIndexChanged += new global::System.EventHandler(this.GT_version_cmd_SelectedIndexChanged);
			this.button15.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.button15.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button15.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button15.ForeColor = global::System.Drawing.Color.White;
			this.button15.Location = new global::System.Drawing.Point(12, 255);
			this.button15.Name = "button15";
			this.button15.Size = new global::System.Drawing.Size(136, 31);
			this.button15.TabIndex = 3;
			this.button15.Text = "Refresh player list";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new global::System.EventHandler(this.button15_Click);
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new global::System.Drawing.Point(8, 19);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new global::System.Drawing.Size(86, 22);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "Select all";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.checkedListBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkedListBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.checkedListBox2.CheckOnClick = true;
			this.checkedListBox2.ForeColor = global::System.Drawing.Color.White;
			this.checkedListBox2.FormattingEnabled = true;
			this.checkedListBox2.Location = new global::System.Drawing.Point(6, 43);
			this.checkedListBox2.Name = "checkedListBox2";
			this.checkedListBox2.Size = new global::System.Drawing.Size(147, 156);
			this.checkedListBox2.TabIndex = 0;
			this.checkedListBox2.SelectedIndexChanged += new global::System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
			this.numericUpDown6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.numericUpDown6.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.numericUpDown6.ForeColor = global::System.Drawing.Color.White;
			this.numericUpDown6.Location = new global::System.Drawing.Point(486, 308);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numericUpDown6;
			int[] array11 = new int[4];
			array11[0] = 1;
			numericUpDown10.Minimum = new decimal(array11);
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new global::System.Drawing.Size(87, 24);
			this.numericUpDown6.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numericUpDown6;
			int[] array12 = new int[4];
			array12[0] = 1;
			numericUpDown11.Value = new decimal(array12);
			this.Execute.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.Execute.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.Execute.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Execute.ForeColor = global::System.Drawing.Color.White;
			this.Execute.Location = new global::System.Drawing.Point(488, 7);
			this.Execute.Name = "Execute";
			this.Execute.Size = new global::System.Drawing.Size(92, 276);
			this.Execute.TabIndex = 4;
			this.Execute.Text = "Execute (Premium)";
			this.Execute.UseVisualStyleBackColor = false;
			this.Execute.Click += new global::System.EventHandler(this.Execute_Click);
			this.tabPage14.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage14.Controls.Add(this.label30);
			this.tabPage14.Controls.Add(this.label29);
			this.tabPage14.Controls.Add(this.dataGridView1);
			this.tabPage14.Controls.Add(this.label27);
			this.tabPage14.Controls.Add(this.label26);
			this.tabPage14.Controls.Add(this.button33);
			this.tabPage14.Controls.Add(this.textBox3);
			this.tabPage14.Controls.Add(this.button32);
			this.tabPage14.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage14.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage14.TabIndex = 9;
			this.tabPage14.Text = "Decoder";
			this.label30.AutoSize = true;
			this.label30.Location = new global::System.Drawing.Point(127, 62);
			this.label30.Name = "label30";
			this.label30.Size = new global::System.Drawing.Size(63, 18);
			this.label30.TabIndex = 19;
			this.label30.Text = "GrowID:";
			this.label29.AutoSize = true;
			this.label29.Location = new global::System.Drawing.Point(127, 85);
			this.label29.Name = "label29";
			this.label29.Size = new global::System.Drawing.Size(46, 18);
			this.label29.TabIndex = 18;
			this.label29.Text = "Pass:";
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.BackgroundColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Variable,
				this.Value
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.GridColor = global::System.Drawing.Color.White;
			this.dataGridView1.Location = new global::System.Drawing.Point(16, 123);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new global::System.Drawing.Size(551, 265);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.Variable.HeaderText = "Variable";
			this.Variable.Name = "Variable";
			this.Variable.Width = 300;
			this.Value.HeaderText = "Value";
			this.Value.Name = "Value";
			this.Value.Width = 245;
			this.label27.AutoSize = true;
			this.label27.Location = new global::System.Drawing.Point(13, 102);
			this.label27.Name = "label27";
			this.label27.Size = new global::System.Drawing.Size(95, 18);
			this.label27.TabIndex = 15;
			this.label27.Text = "General Data";
			this.label26.AutoSize = true;
			this.label26.Location = new global::System.Drawing.Point(13, 8);
			this.label26.Name = "label26";
			this.label26.Size = new global::System.Drawing.Size(31, 18);
			this.label26.TabIndex = 14;
			this.label26.Text = "File";
			this.button33.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button33.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button33.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button33.Location = new global::System.Drawing.Point(386, 25);
			this.button33.Name = "button33";
			this.button33.Size = new global::System.Drawing.Size(64, 33);
			this.button33.TabIndex = 5;
			this.button33.Text = "Select";
			this.button33.UseVisualStyleBackColor = false;
			this.button33.Click += new global::System.EventHandler(this.button33_Click);
			this.textBox3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.textBox3.ForeColor = global::System.Drawing.Color.White;
			this.textBox3.Location = new global::System.Drawing.Point(16, 29);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(364, 24);
			this.textBox3.TabIndex = 3;
			this.button32.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button32.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button32.Location = new global::System.Drawing.Point(473, 25);
			this.button32.Name = "button32";
			this.button32.Size = new global::System.Drawing.Size(94, 33);
			this.button32.TabIndex = 2;
			this.button32.Text = "Decode";
			this.button32.UseVisualStyleBackColor = false;
			this.button32.Click += new global::System.EventHandler(this.button32_Click);
			this.tabPage6.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage6.Controls.Add(this.tabControl1);
			this.tabPage6.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage6.TabIndex = 3;
			this.tabPage6.Text = "Captcha";
			this.tabControl1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(3, 7);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(580, 383);
			this.tabControl1.TabIndex = 10;
			this.tabPage2.BackColor = global::System.Drawing.Color.Black;
			this.tabPage2.Controls.Add(this.button29);
			this.tabPage2.Controls.Add(this.button28);
			this.tabPage2.Controls.Add(this.button27);
			this.tabPage2.Controls.Add(this.button26);
			this.tabPage2.Controls.Add(this.groupBox6);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(572, 352);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Background Captcha Solver";
			this.button29.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button29.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button29.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button29.Location = new global::System.Drawing.Point(433, 29);
			this.button29.Name = "button29";
			this.button29.Size = new global::System.Drawing.Size(136, 77);
			this.button29.TabIndex = 5;
			this.button29.Text = "Select Submit button (position)";
			this.button29.UseVisualStyleBackColor = false;
			this.button29.Click += new global::System.EventHandler(this.button29_Click);
			this.button28.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button28.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button28.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button28.Location = new global::System.Drawing.Point(430, 265);
			this.button28.Name = "button28";
			this.button28.Size = new global::System.Drawing.Size(136, 75);
			this.button28.TabIndex = 4;
			this.button28.Text = "Stop auto-solver";
			this.button28.UseVisualStyleBackColor = false;
			this.button28.Click += new global::System.EventHandler(this.button28_Click);
			this.button27.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button27.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button27.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button27.Location = new global::System.Drawing.Point(430, 265);
			this.button27.Name = "button27";
			this.button27.Size = new global::System.Drawing.Size(136, 75);
			this.button27.TabIndex = 3;
			this.button27.Text = "Start auto-solver";
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += new global::System.EventHandler(this.button27_Click);
			this.button26.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button26.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button26.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button26.Location = new global::System.Drawing.Point(430, 150);
			this.button26.Name = "button26";
			this.button26.Size = new global::System.Drawing.Size(136, 77);
			this.button26.TabIndex = 2;
			this.button26.Text = "Solve captcha(s)";
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += new global::System.EventHandler(this.button26_Click);
			this.groupBox6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.groupBox6.Controls.Add(this.textBox2);
			this.groupBox6.ForeColor = global::System.Drawing.Color.White;
			this.groupBox6.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(421, 334);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Output";
			this.textBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.textBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.textBox2.ForeColor = global::System.Drawing.Color.White;
			this.textBox2.Location = new global::System.Drawing.Point(6, 23);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ShortcutsEnabled = false;
			this.textBox2.Size = new global::System.Drawing.Size(409, 305);
			this.textBox2.TabIndex = 0;
			this.tabPage1.BackColor = global::System.Drawing.Color.Black;
			this.tabPage1.Controls.Add(this.button7);
			this.tabPage1.Controls.Add(this.button12);
			this.tabPage1.Controls.Add(this.button11);
			this.tabPage1.Controls.Add(this.button8);
			this.tabPage1.Controls.Add(this.button10);
			this.tabPage1.Controls.Add(this.button9);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.pictureBox3);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(572, 357);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Foreground Captcha Solver";
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Location = new global::System.Drawing.Point(14, 36);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(140, 39);
			this.button7.TabIndex = 9;
			this.button7.Text = "Are you human?";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button12.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button12.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button12.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button12.ForeColor = global::System.Drawing.Color.White;
			this.button12.Location = new global::System.Drawing.Point(426, 290);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(140, 39);
			this.button12.TabIndex = 5;
			this.button12.Text = "Stop auto solver";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new global::System.EventHandler(this.button12_Click);
			this.button11.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button11.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button11.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button11.Location = new global::System.Drawing.Point(426, 290);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(140, 39);
			this.button11.TabIndex = 4;
			this.button11.Text = "Start auto solver";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new global::System.EventHandler(this.button11_Click);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Location = new global::System.Drawing.Point(14, 123);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(140, 39);
			this.button8.TabIndex = 1;
			this.button8.Text = "Math question";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button10.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button10.Location = new global::System.Drawing.Point(426, 234);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(140, 39);
			this.button10.TabIndex = 3;
			this.button10.Text = "Solve captcha";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button9.Location = new global::System.Drawing.Point(14, 208);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(140, 39);
			this.button9.TabIndex = 2;
			this.button9.Text = "Submit button";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.pictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new global::System.Drawing.Point(160, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(235, 83);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.pictureBox3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new global::System.Drawing.Point(160, 221);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(235, 74);
			this.pictureBox3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			this.pictureBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.pictureBox2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new global::System.Drawing.Point(160, 124);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(235, 80);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			this.tabPage7.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage7.Controls.Add(this.SearchGroup);
			this.tabPage7.Controls.Add(this.button13);
			this.tabPage7.Controls.Add(this.listView1);
			this.tabPage7.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage7.TabIndex = 4;
			this.tabPage7.Text = "Item info";
			this.SearchGroup.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.SearchGroup.Controls.Add(this.maskedTextBox2);
			this.SearchGroup.ForeColor = global::System.Drawing.Color.White;
			this.SearchGroup.Location = new global::System.Drawing.Point(3, 0);
			this.SearchGroup.Name = "SearchGroup";
			this.SearchGroup.Size = new global::System.Drawing.Size(482, 52);
			this.SearchGroup.TabIndex = 3;
			this.SearchGroup.TabStop = false;
			this.SearchGroup.Text = "Search";
			this.maskedTextBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.maskedTextBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.maskedTextBox2.ForeColor = global::System.Drawing.Color.White;
			this.maskedTextBox2.Location = new global::System.Drawing.Point(6, 20);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new global::System.Drawing.Size(470, 24);
			this.maskedTextBox2.TabIndex = 2;
			this.maskedTextBox2.MaskInputRejected += new global::System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
			this.maskedTextBox2.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.maskedTextBox2_KeyUp);
			this.button13.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button13.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button13.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button13.ForeColor = global::System.Drawing.Color.White;
			this.button13.Location = new global::System.Drawing.Point(491, 5);
			this.button13.Name = "button13";
			this.button13.Size = new global::System.Drawing.Size(75, 47);
			this.button13.TabIndex = 1;
			this.button13.Text = "Load";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new global::System.EventHandler(this.button13_Click);
			this.listView1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.listView1.ForeColor = global::System.Drawing.Color.White;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(3, 58);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(563, 334);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.tabPage8.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage8.Controls.Add(this.tabControl2);
			this.tabPage8.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage8.TabIndex = 5;
			this.tabPage8.Text = "Multiboxing";
			this.tabControl2.Controls.Add(this.tabPage12);
			this.tabControl2.Controls.Add(this.tabPage13);
			this.tabControl2.Location = new global::System.Drawing.Point(0, -4);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new global::System.Drawing.Size(586, 395);
			this.tabControl2.TabIndex = 9;
			this.tabPage12.BackColor = global::System.Drawing.Color.Black;
			this.tabPage12.Controls.Add(this.panel5);
			this.tabPage12.Controls.Add(this.panel2);
			this.tabPage12.Location = new global::System.Drawing.Point(4, 27);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage12.Size = new global::System.Drawing.Size(578, 364);
			this.tabPage12.TabIndex = 0;
			this.tabPage12.Text = "Multiboxing";
			this.panel5.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.panel5.Controls.Add(this.label36);
			this.panel5.Controls.Add(this.label35);
			this.panel5.Controls.Add(this.comboBox4);
			this.panel5.Controls.Add(this.label34);
			this.panel5.Controls.Add(this.label32);
			this.panel5.Controls.Add(this.MB_enable);
			this.panel5.Controls.Add(this.checkBox8);
			this.panel5.Controls.Add(this.checkBox9);
			this.panel5.Controls.Add(this.label25);
			this.panel5.Controls.Add(this.iTalk_NumericUpDown1);
			this.panel5.Controls.Add(this.checkedListBox4);
			this.panel5.Controls.Add(this.comboBox3);
			this.panel5.Location = new global::System.Drawing.Point(267, 23);
			this.panel5.Name = "panel5";
			this.panel5.Size = new global::System.Drawing.Size(299, 317);
			this.panel5.TabIndex = 24;
			this.label36.AutoSize = true;
			this.label36.Location = new global::System.Drawing.Point(12, 136);
			this.label36.Name = "label36";
			this.label36.Size = new global::System.Drawing.Size(131, 18);
			this.label36.TabIndex = 25;
			this.label36.Text = "CPU usage tuning:";
			this.label35.AutoSize = true;
			this.label35.Location = new global::System.Drawing.Point(12, 168);
			this.label35.Name = "label35";
			this.label35.Size = new global::System.Drawing.Size(62, 18);
			this.label35.TabIndex = 24;
			this.label35.Text = "Profiles:";
			this.comboBox4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Items.AddRange(new object[]
			{
				"Xtreme - GT@4% CPU",
				"Default - GT@25% CPU",
				"High FPS - GT@30%+ CPU"
			});
			this.comboBox4.Location = new global::System.Drawing.Point(14, 194);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new global::System.Drawing.Size(161, 26);
			this.comboBox4.TabIndex = 23;
			this.comboBox4.SelectedIndexChanged += new global::System.EventHandler(this.comboBox4_SelectedIndexChanged);
			this.label34.AutoSize = true;
			this.label34.Location = new global::System.Drawing.Point(11, 242);
			this.label34.Name = "label34";
			this.label34.Size = new global::System.Drawing.Size(116, 18);
			this.label34.TabIndex = 22;
			this.label34.Text = "Process priority:";
			this.label32.AutoSize = true;
			this.label32.Location = new global::System.Drawing.Point(166, 136);
			this.label32.Name = "label32";
			this.label32.Size = new global::System.Drawing.Size(133, 18);
			this.label32.TabIndex = 21;
			this.label32.Text = "Run on: (thread(s))";
			this.MB_enable.AutoSize = true;
			this.MB_enable.Location = new global::System.Drawing.Point(14, 6);
			this.MB_enable.Name = "MB_enable";
			this.MB_enable.Size = new global::System.Drawing.Size(150, 22);
			this.MB_enable.TabIndex = 8;
			this.MB_enable.Text = "Enable Multiboxing";
			this.MB_enable.UseVisualStyleBackColor = true;
			this.MB_enable.CheckedChanged += new global::System.EventHandler(this.MB_enable_CheckedChanged);
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new global::System.Drawing.Point(14, 36);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new global::System.Drawing.Size(96, 22);
			this.checkBox8.TabIndex = 9;
			this.checkBox8.Text = "Auto log in";
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new global::System.EventHandler(this.checkBox8_CheckedChanged);
			this.checkBox8.Click += new global::System.EventHandler(this.checkBox8_Click);
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new global::System.Drawing.Point(14, 65);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new global::System.Drawing.Size(200, 22);
			this.checkBox9.TabIndex = 10;
			this.checkBox9.Text = "Bypass \"Error connecting\"";
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new global::System.EventHandler(this.checkBox9_CheckedChanged);
			this.label25.AutoSize = true;
			this.label25.Location = new global::System.Drawing.Point(31, 94);
			this.label25.Name = "label25";
			this.label25.Size = new global::System.Drawing.Size(144, 18);
			this.label25.TabIndex = 15;
			this.label25.Text = "With a delay of: (ms)";
			this.iTalk_NumericUpDown1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.iTalk_NumericUpDown1.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_NumericUpDown1.Location = new global::System.Drawing.Point(187, 90);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.iTalk_NumericUpDown1;
			int[] array13 = new int[4];
			array13[0] = 1215752192;
			array13[1] = 23;
			numericUpDown12.Maximum = new decimal(array13);
			this.iTalk_NumericUpDown1.Name = "iTalk_NumericUpDown1";
			this.iTalk_NumericUpDown1.Size = new global::System.Drawing.Size(65, 24);
			this.iTalk_NumericUpDown1.TabIndex = 18;
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.iTalk_NumericUpDown1;
			int[] array14 = new int[4];
			array14[0] = 8000;
			numericUpDown13.Value = new decimal(array14);
			this.iTalk_NumericUpDown1.ValueChanged += new global::System.EventHandler(this.iTalk_NumericUpDown1_ValueChanged);
			this.checkedListBox4.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.checkedListBox4.ForeColor = global::System.Drawing.Color.White;
			this.checkedListBox4.FormattingEnabled = true;
			this.checkedListBox4.Location = new global::System.Drawing.Point(179, 166);
			this.checkedListBox4.Name = "checkedListBox4";
			this.checkedListBox4.Size = new global::System.Drawing.Size(113, 137);
			this.checkedListBox4.TabIndex = 20;
			this.checkedListBox4.Click += new global::System.EventHandler(this.checkedListBox4_Click);
			this.checkedListBox4.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.checkedListBox4_MouseClick);
			this.checkedListBox4.SelectedIndexChanged += new global::System.EventHandler(this.checkedListBox4_SelectedIndexChanged);
			this.checkedListBox4.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.checkedListBox4_MouseDown);
			this.checkedListBox4.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.checkedListBox4_MouseUp);
			this.comboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[]
			{
				"Realtime - highest",
				"High - high",
				"Above normal - above normal",
				"Normal - default",
				"Below normal - below normal",
				"Idle - lowest"
			});
			this.comboBox3.Location = new global::System.Drawing.Point(14, 270);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(161, 26);
			this.comboBox3.TabIndex = 19;
			this.comboBox3.SelectedIndexChanged += new global::System.EventHandler(this.comboBox3_SelectedIndexChanged);
			this.panel2.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.panel2.Controls.Add(this.label33);
			this.panel2.Controls.Add(this.startGTwindows);
			this.panel2.Controls.Add(this.Refresh);
			this.panel2.Controls.Add(this.no_GT_windows);
			this.panel2.Controls.Add(this.close_gt_windows);
			this.panel2.Controls.Add(this.checkedListBox1);
			this.panel2.Controls.Add(this.Select_all);
			this.panel2.Location = new global::System.Drawing.Point(21, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(234, 320);
			this.panel2.TabIndex = 21;
			this.label33.AutoSize = true;
			this.label33.Location = new global::System.Drawing.Point(122, 28);
			this.label33.Name = "label33";
			this.label33.Size = new global::System.Drawing.Size(22, 18);
			this.label33.TabIndex = 22;
			this.label33.Text = "->";
			this.startGTwindows.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.startGTwindows.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.startGTwindows.ForeColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.startGTwindows.Location = new global::System.Drawing.Point(27, 20);
			this.startGTwindows.Name = "startGTwindows";
			this.startGTwindows.Size = new global::System.Drawing.Size(89, 33);
			this.startGTwindows.TabIndex = 0;
			this.startGTwindows.Text = "Start GT";
			this.startGTwindows.UseVisualStyleBackColor = false;
			this.startGTwindows.Click += new global::System.EventHandler(this.startGTwindows_Click);
			this.close_gt_windows.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.close_gt_windows.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.close_gt_windows.ForeColor = global::System.Drawing.Color.White;
			this.close_gt_windows.Location = new global::System.Drawing.Point(131, 268);
			this.close_gt_windows.Name = "close_gt_windows";
			this.close_gt_windows.Size = new global::System.Drawing.Size(91, 35);
			this.close_gt_windows.TabIndex = 5;
			this.close_gt_windows.Text = "Close";
			this.close_gt_windows.UseVisualStyleBackColor = false;
			this.close_gt_windows.Click += new global::System.EventHandler(this.close_gt_windows_Click);
			this.checkedListBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkedListBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.ForeColor = global::System.Drawing.Color.White;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new global::System.Drawing.Point(21, 96);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new global::System.Drawing.Size(201, 156);
			this.checkedListBox1.Sorted = true;
			this.checkedListBox1.TabIndex = 2;
			this.Select_all.AutoSize = true;
			this.Select_all.Location = new global::System.Drawing.Point(24, 68);
			this.Select_all.Name = "Select_all";
			this.Select_all.Size = new global::System.Drawing.Size(86, 22);
			this.Select_all.TabIndex = 4;
			this.Select_all.Text = "Select all";
			this.Select_all.UseVisualStyleBackColor = true;
			this.Select_all.CheckedChanged += new global::System.EventHandler(this.Select_all_CheckedChanged);
			this.tabPage13.BackColor = global::System.Drawing.Color.Black;
			this.tabPage13.Controls.Add(this.groupBox8);
			this.tabPage13.Controls.Add(this.groupBox7);
			this.tabPage13.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new global::System.Drawing.Size(578, 369);
			this.tabPage13.TabIndex = 1;
			this.tabPage13.Text = "Auto Log In";
			this.groupBox8.Controls.Add(this.bunifuFlatButton3);
			this.groupBox8.Controls.Add(this.checkedListBox3);
			this.groupBox8.Controls.Add(this.bunifuFlatButton2);
			this.groupBox8.ForeColor = global::System.Drawing.Color.White;
			this.groupBox8.Location = new global::System.Drawing.Point(306, 6);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new global::System.Drawing.Size(263, 352);
			this.groupBox8.TabIndex = 5;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "2. View your accounts";
			this.bunifuFlatButton3.Activecolor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton3.BorderRadius = 0;
			this.bunifuFlatButton3.ButtonText = "                Refresh";
			this.bunifuFlatButton3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton3.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton3.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton3.Iconimage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuFlatButton3.Iconimage");
			this.bunifuFlatButton3.Iconimage_right = null;
			this.bunifuFlatButton3.Iconimage_right_Selected = null;
			this.bunifuFlatButton3.Iconimage_Selected = null;
			this.bunifuFlatButton3.IconMarginLeft = 0;
			this.bunifuFlatButton3.IconMarginRight = 0;
			this.bunifuFlatButton3.IconRightVisible = false;
			this.bunifuFlatButton3.IconRightZoom = 0.0;
			this.bunifuFlatButton3.IconVisible = false;
			this.bunifuFlatButton3.IconZoom = 100.0;
			this.bunifuFlatButton3.IsTab = false;
			this.bunifuFlatButton3.Location = new global::System.Drawing.Point(12, 216);
			this.bunifuFlatButton3.Margin = new global::System.Windows.Forms.Padding(6);
			this.bunifuFlatButton3.Name = "bunifuFlatButton3";
			this.bunifuFlatButton3.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton3.OnHovercolor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.bunifuFlatButton3.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton3.selected = false;
			this.bunifuFlatButton3.Size = new global::System.Drawing.Size(244, 48);
			this.bunifuFlatButton3.TabIndex = 7;
			this.bunifuFlatButton3.Text = "                Refresh";
			this.bunifuFlatButton3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton3.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton3.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton3.Click += new global::System.EventHandler(this.bunifuFlatButton3_Click);
			this.checkedListBox3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.checkedListBox3.CheckOnClick = true;
			this.checkedListBox3.ForeColor = global::System.Drawing.Color.White;
			this.checkedListBox3.FormattingEnabled = true;
			this.checkedListBox3.Location = new global::System.Drawing.Point(12, 34);
			this.checkedListBox3.Name = "checkedListBox3";
			this.checkedListBox3.Size = new global::System.Drawing.Size(244, 156);
			this.checkedListBox3.TabIndex = 6;
			this.bunifuFlatButton2.Activecolor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton2.BorderRadius = 0;
			this.bunifuFlatButton2.ButtonText = "               Remove account(s)";
			this.bunifuFlatButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton2.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton2.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton2.Iconimage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuFlatButton2.Iconimage");
			this.bunifuFlatButton2.Iconimage_right = null;
			this.bunifuFlatButton2.Iconimage_right_Selected = null;
			this.bunifuFlatButton2.Iconimage_Selected = null;
			this.bunifuFlatButton2.IconMarginLeft = 0;
			this.bunifuFlatButton2.IconMarginRight = 0;
			this.bunifuFlatButton2.IconRightVisible = false;
			this.bunifuFlatButton2.IconRightZoom = 0.0;
			this.bunifuFlatButton2.IconVisible = false;
			this.bunifuFlatButton2.IconZoom = 60.0;
			this.bunifuFlatButton2.IsTab = false;
			this.bunifuFlatButton2.Location = new global::System.Drawing.Point(12, 287);
			this.bunifuFlatButton2.Margin = new global::System.Windows.Forms.Padding(4);
			this.bunifuFlatButton2.Name = "bunifuFlatButton2";
			this.bunifuFlatButton2.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton2.OnHovercolor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.bunifuFlatButton2.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.selected = false;
			this.bunifuFlatButton2.Size = new global::System.Drawing.Size(244, 48);
			this.bunifuFlatButton2.TabIndex = 3;
			this.bunifuFlatButton2.Text = "               Remove account(s)";
			this.bunifuFlatButton2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton2.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton2.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton2.Click += new global::System.EventHandler(this.bunifuFlatButton2_Click);
			this.groupBox7.Controls.Add(this.iTalk_Label2);
			this.groupBox7.Controls.Add(this.bunifuFlatButton1);
			this.groupBox7.Controls.Add(this.iTalk_Label1);
			this.groupBox7.Controls.Add(this.iTalk_RichTextBox1);
			this.groupBox7.Controls.Add(this.bunifuTileButton1);
			this.groupBox7.ForeColor = global::System.Drawing.Color.White;
			this.groupBox7.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(294, 352);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "1. Add accounts";
			this.iTalk_Label2.AutoSize = true;
			this.iTalk_Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.iTalk_Label2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.iTalk_Label2.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_Label2.Location = new global::System.Drawing.Point(28, 177);
			this.iTalk_Label2.Name = "iTalk_Label2";
			this.iTalk_Label2.Size = new global::System.Drawing.Size(65, 13);
			this.iTalk_Label2.TabIndex = 4;
			this.iTalk_Label2.Text = "Select a file";
			this.bunifuFlatButton1.Activecolor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.bunifuFlatButton1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.bunifuFlatButton1.BorderRadius = 0;
			this.bunifuFlatButton1.ButtonText = "               Add account";
			this.bunifuFlatButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuFlatButton1.DisabledColor = global::System.Drawing.Color.Gray;
			this.bunifuFlatButton1.Iconcolor = global::System.Drawing.Color.Transparent;
			this.bunifuFlatButton1.Iconimage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuFlatButton1.Iconimage");
			this.bunifuFlatButton1.Iconimage_right = null;
			this.bunifuFlatButton1.Iconimage_right_Selected = null;
			this.bunifuFlatButton1.Iconimage_Selected = null;
			this.bunifuFlatButton1.IconMarginLeft = 0;
			this.bunifuFlatButton1.IconMarginRight = 0;
			this.bunifuFlatButton1.IconRightVisible = false;
			this.bunifuFlatButton1.IconRightZoom = 0.0;
			this.bunifuFlatButton1.IconVisible = false;
			this.bunifuFlatButton1.IconZoom = 90.0;
			this.bunifuFlatButton1.IsTab = false;
			this.bunifuFlatButton1.Location = new global::System.Drawing.Point(12, 287);
			this.bunifuFlatButton1.Margin = new global::System.Windows.Forms.Padding(4);
			this.bunifuFlatButton1.Name = "bunifuFlatButton1";
			this.bunifuFlatButton1.Normalcolor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuFlatButton1.OnHovercolor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.bunifuFlatButton1.OnHoverTextColor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.selected = false;
			this.bunifuFlatButton1.Size = new global::System.Drawing.Size(275, 48);
			this.bunifuFlatButton1.TabIndex = 3;
			this.bunifuFlatButton1.Text = "               Add account";
			this.bunifuFlatButton1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.bunifuFlatButton1.Textcolor = global::System.Drawing.Color.White;
			this.bunifuFlatButton1.TextFont = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuFlatButton1.Click += new global::System.EventHandler(this.bunifuFlatButton1_Click);
			this.iTalk_Label1.AutoSize = true;
			this.iTalk_Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.iTalk_Label1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.iTalk_Label1.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_Label1.Location = new global::System.Drawing.Point(28, 209);
			this.iTalk_Label1.Name = "iTalk_Label1";
			this.iTalk_Label1.Size = new global::System.Drawing.Size(146, 13);
			this.iTalk_Label1.TabIndex = 2;
			this.iTalk_Label1.Text = "Description/Account name:";
			this.iTalk_RichTextBox1.AllowDrop = true;
			this.iTalk_RichTextBox1.method_5(false);
			this.iTalk_RichTextBox1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.iTalk_RichTextBox1.Font = new global::System.Drawing.Font("Tahoma", 10f);
			this.iTalk_RichTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.iTalk_RichTextBox1.Location = new global::System.Drawing.Point(31, 235);
			this.iTalk_RichTextBox1.Name = "iTalk_RichTextBox1";
			this.iTalk_RichTextBox1.method_1(false);
			this.iTalk_RichTextBox1.Size = new global::System.Drawing.Size(237, 29);
			this.iTalk_RichTextBox1.TabIndex = 1;
			this.iTalk_RichTextBox1.Text = "Account";
			this.iTalk_RichTextBox1.method_3(true);
			this.bunifuTileButton1.AllowDrop = true;
			this.bunifuTileButton1.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuTileButton1.color = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuTileButton1.colorActive = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.bunifuTileButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuTileButton1.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuTileButton1.ForeColor = global::System.Drawing.Color.White;
			this.bunifuTileButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuTileButton1.Image");
			this.bunifuTileButton1.ImagePosition = 10;
			this.bunifuTileButton1.ImageZoom = 30;
			this.bunifuTileButton1.LabelPosition = 30;
			this.bunifuTileButton1.LabelText = "Tap to add a save.dat";
			this.bunifuTileButton1.Location = new global::System.Drawing.Point(31, 25);
			this.bunifuTileButton1.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			this.bunifuTileButton1.Name = "bunifuTileButton1";
			this.bunifuTileButton1.Size = new global::System.Drawing.Size(237, 121);
			this.bunifuTileButton1.TabIndex = 0;
			this.bunifuTileButton1.Click += new global::System.EventHandler(this.bunifuTileButton1_Click);
			this.bunifuTileButton1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.bunifuTileButton1_DragDrop);
			this.bunifuTileButton1.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.bunifuTileButton1_DragEnter);
			this.tabPage9.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage9.Controls.Add(this.button31);
			this.tabPage9.Controls.Add(this.button25);
			this.tabPage9.Controls.Add(this.m_QueueTests);
			this.tabPage9.Controls.Add(this.comboBox2);
			this.tabPage9.Controls.Add(this.UnbanButton);
			this.tabPage9.Controls.Add(this.button24);
			this.tabPage9.Controls.Add(this.button22);
			this.tabPage9.Controls.Add(this.button23);
			this.tabPage9.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage9.TabIndex = 6;
			this.tabPage9.Text = "Unbanner";
			this.button25.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button25.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button25.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button25.ForeColor = global::System.Drawing.Color.White;
			this.button25.Location = new global::System.Drawing.Point(5, 351);
			this.button25.Name = "button25";
			this.button25.Size = new global::System.Drawing.Size(165, 33);
			this.button25.TabIndex = 7;
			this.button25.Text = "Manually change MAC";
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += new global::System.EventHandler(this.button25_Click);
			this.m_QueueTests.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.m_QueueTests.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.m_QueueTests.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.m_QueueTests.ForeColor = global::System.Drawing.Color.White;
			this.m_QueueTests.FormattingEnabled = true;
			this.m_QueueTests.HorizontalScrollbar = true;
			this.m_QueueTests.ItemHeight = 15;
			this.m_QueueTests.Location = new global::System.Drawing.Point(3, 6);
			this.m_QueueTests.Name = "UnbanLog";
			this.m_QueueTests.Size = new global::System.Drawing.Size(540, 274);
			this.m_QueueTests.TabIndex = 2;
			this.m_QueueTests.ControlAdded += new global::System.Windows.Forms.ControlEventHandler(this.m_QueueTests_ControlAdded);
			this.comboBox2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.comboBox2.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.ForeColor = global::System.Drawing.Color.White;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[]
			{
				"q",
				"q"
			});
			this.comboBox2.Location = new global::System.Drawing.Point(370, 308);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(210, 26);
			this.comboBox2.TabIndex = 6;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.UnbanButton.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.UnbanButton.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.UnbanButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.UnbanButton.ForeColor = global::System.Drawing.Color.White;
			this.UnbanButton.Location = new global::System.Drawing.Point(5, 308);
			this.UnbanButton.Name = "UnbanButton";
			this.UnbanButton.Size = new global::System.Drawing.Size(165, 33);
			this.UnbanButton.TabIndex = 1;
			this.UnbanButton.Text = "Unban";
			this.UnbanButton.UseVisualStyleBackColor = false;
			this.UnbanButton.Click += new global::System.EventHandler(this.UnbanButton_Click);
			this.button24.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button24.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button24.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button24.ForeColor = global::System.Drawing.Color.White;
			this.button24.Location = new global::System.Drawing.Point(411, 351);
			this.button24.Name = "button24";
			this.button24.Size = new global::System.Drawing.Size(169, 33);
			this.button24.TabIndex = 5;
			this.button24.Text = "Check VPN status";
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += new global::System.EventHandler(this.button24_Click);
			this.button22.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button22.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button22.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button22.ForeColor = global::System.Drawing.Color.White;
			this.button22.Location = new global::System.Drawing.Point(192, 308);
			this.button22.Name = "button22";
			this.button22.Size = new global::System.Drawing.Size(168, 33);
			this.button22.TabIndex = 3;
			this.button22.Text = "Connect to VPN";
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += new global::System.EventHandler(this.button22_Click);
			this.button23.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button23.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button23.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button23.ForeColor = global::System.Drawing.Color.White;
			this.button23.Location = new global::System.Drawing.Point(192, 351);
			this.button23.Name = "button23";
			this.button23.Size = new global::System.Drawing.Size(209, 33);
			this.button23.TabIndex = 4;
			this.button23.Text = "Disconnect from VPN";
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += new global::System.EventHandler(this.button23_Click);
			this.tabPage10.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage10.Controls.Add(this.button21);
			this.tabPage10.Controls.Add(this.label16);
			this.tabPage10.Controls.Add(this.button20);
			this.tabPage10.Controls.Add(this.button19);
			this.tabPage10.Controls.Add(this.button18);
			this.tabPage10.Controls.Add(this.button17);
			this.tabPage10.Controls.Add(this.button16);
			this.tabPage10.Controls.Add(this.trackBar1);
			this.tabPage10.Controls.Add(this.maskedTextBox3);
			this.tabPage10.Controls.Add(this.checkBox4);
			this.tabPage10.Controls.Add(this.pictureBox8);
			this.tabPage10.Controls.Add(this.pictureBox7);
			this.tabPage10.Controls.Add(this.pictureBox6);
			this.tabPage10.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage10.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage10.TabIndex = 7;
			this.tabPage10.Text = "W-Render";
			this.button21.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button21.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button21.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button21.ForeColor = global::System.Drawing.Color.White;
			this.button21.Location = new global::System.Drawing.Point(308, 67);
			this.button21.Name = "button21";
			this.button21.Size = new global::System.Drawing.Size(152, 28);
			this.button21.TabIndex = 11;
			this.button21.Text = "Open output folder";
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += new global::System.EventHandler(this.button21_Click);
			this.label16.AutoSize = true;
			this.label16.Location = new global::System.Drawing.Point(16, 41);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(96, 18);
			this.label16.TabIndex = 2;
			this.label16.Text = "World Name:";
			this.button20.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button20.AutoSize = true;
			this.button20.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button20.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button20.Location = new global::System.Drawing.Point(539, 264);
			this.button20.Name = "button20";
			this.button20.Size = new global::System.Drawing.Size(41, 36);
			this.button20.TabIndex = 8;
			this.button20.Text = "→";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += new global::System.EventHandler(this.button20_Click);
			this.button19.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button19.AutoSize = true;
			this.button19.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button19.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button19.Location = new global::System.Drawing.Point(539, 300);
			this.button19.Name = "button19";
			this.button19.Size = new global::System.Drawing.Size(41, 36);
			this.button19.TabIndex = 7;
			this.button19.Text = "←";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += new global::System.EventHandler(this.button19_Click);
			this.button18.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button18.AutoSize = true;
			this.button18.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button18.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button18.Location = new global::System.Drawing.Point(539, 186);
			this.button18.Name = "button18";
			this.button18.Size = new global::System.Drawing.Size(36, 36);
			this.button18.TabIndex = 6;
			this.button18.Text = "↓";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new global::System.EventHandler(this.button18_Click);
			this.button17.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.button17.AutoSize = true;
			this.button17.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button17.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button17.Location = new global::System.Drawing.Point(539, 148);
			this.button17.Name = "button17";
			this.button17.Size = new global::System.Drawing.Size(36, 36);
			this.button17.TabIndex = 5;
			this.button17.Text = "↑";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new global::System.EventHandler(this.button17_Click);
			this.button16.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button16.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.button16.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button16.ForeColor = global::System.Drawing.Color.White;
			this.button16.Location = new global::System.Drawing.Point(493, 35);
			this.button16.Name = "button16";
			this.button16.Size = new global::System.Drawing.Size(86, 31);
			this.button16.TabIndex = 0;
			this.button16.Text = "Render!";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new global::System.EventHandler(this.button16_Click);
			this.trackBar1.AutoSize = false;
			this.trackBar1.LargeChange = 1;
			this.trackBar1.Location = new global::System.Drawing.Point(16, 71);
			this.trackBar1.Minimum = 2;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(225, 22);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickFrequency = 100;
			this.trackBar1.TickStyle = global::System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 2;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_ValueChanged);
			this.trackBar1.ValueChanged += new global::System.EventHandler(this.trackBar1_ValueChanged);
			this.maskedTextBox3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.maskedTextBox3.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.maskedTextBox3.ForeColor = global::System.Drawing.Color.White;
			this.maskedTextBox3.Location = new global::System.Drawing.Point(118, 38);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new global::System.Drawing.Size(366, 24);
			this.maskedTextBox3.TabIndex = 1;
			this.checkBox4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkBox4.AutoSize = true;
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBox4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.checkBox4.Location = new global::System.Drawing.Point(471, 71);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new global::System.Drawing.Size(105, 22);
			this.checkBox4.TabIndex = 4;
			this.checkBox4.Text = "Save as png";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.pictureBox8.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox8.Location = new global::System.Drawing.Point(3, -4);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new global::System.Drawing.Size(618, 106);
			this.pictureBox8.TabIndex = 10;
			this.pictureBox8.TabStop = false;
			this.pictureBox7.Anchor = global::System.Windows.Forms.AnchorStyles.Right;
			this.pictureBox7.Location = new global::System.Drawing.Point(531, 99);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new global::System.Drawing.Size(53, 295);
			this.pictureBox7.TabIndex = 9;
			this.pictureBox7.TabStop = false;
			this.pictureBox6.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox6.BackColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.pictureBox6.Location = new global::System.Drawing.Point(8, 102);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new global::System.Drawing.Size(525, 276);
			this.pictureBox6.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 3;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new global::System.EventHandler(this.pictureBox6_Click);
			this.tabPage11.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.tabPage11.Controls.Add(this.label43);
			this.tabPage11.Controls.Add(this.panel1);
			this.tabPage11.Controls.Add(this.bunifuThinButton23);
			this.tabPage11.Controls.Add(this.bunifuThinButton24);
			this.tabPage11.Controls.Add(this.label21);
			this.tabPage11.Controls.Add(this.dsugugdHGHSDGid730hjd);
			this.tabPage11.Controls.Add(this.pictureBox4);
			this.tabPage11.Controls.Add(this.discordLogo);
			this.tabPage11.Controls.Add(this.label8);
			this.tabPage11.Controls.Add(this.YTlogo);
			this.tabPage11.Location = new global::System.Drawing.Point(139, 4);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage11.Size = new global::System.Drawing.Size(625, 394);
			this.tabPage11.TabIndex = 8;
			this.tabPage11.Text = "Info/settings";
			this.label43.AutoSize = true;
			this.label43.Location = new global::System.Drawing.Point(1264, 122);
			this.label43.Name = "label43";
			this.label43.Size = new global::System.Drawing.Size(62, 18);
			this.label43.TabIndex = 29;
			this.label43.Text = "Dhjasdh";
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.panel1.Controls.Add(this.checkBox10);
			this.panel1.Controls.Add(this.bunifuThinButton22);
			this.panel1.Controls.Add(this.bunifuThinButton21);
			this.panel1.Location = new global::System.Drawing.Point(309, 141);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(264, 240);
			this.panel1.TabIndex = 28;
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new global::System.Drawing.Point(12, 175);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new global::System.Drawing.Size(225, 22);
			this.checkBox10.TabIndex = 29;
			this.checkBox10.Text = "Always load settings at startup";
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.CheckedChanged += new global::System.EventHandler(this.checkBox10_CheckedChanged);
			this.bunifuThinButton22.ActiveBorderThickness = 1;
			this.bunifuThinButton22.ActiveCornerRadius = 20;
			this.bunifuThinButton22.ActiveFillColor = global::System.Drawing.Color.FromArgb(56, 56, 56);
			this.bunifuThinButton22.ActiveForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton22.ActiveLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton22.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.bunifuThinButton22.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuThinButton22.BackgroundImage");
			this.bunifuThinButton22.ButtonText = "Save settings";
			this.bunifuThinButton22.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton22.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuThinButton22.ForeColor = global::System.Drawing.Color.White;
			this.bunifuThinButton22.IdleBorderThickness = 1;
			this.bunifuThinButton22.IdleCornerRadius = 20;
			this.bunifuThinButton22.IdleFillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuThinButton22.IdleForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton22.IdleLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton22.Location = new global::System.Drawing.Point(12, 25);
			this.bunifuThinButton22.Margin = new global::System.Windows.Forms.Padding(5);
			this.bunifuThinButton22.Name = "bunifuThinButton22";
			this.bunifuThinButton22.Size = new global::System.Drawing.Size(239, 38);
			this.bunifuThinButton22.TabIndex = 28;
			this.bunifuThinButton22.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton22.Click += new global::System.EventHandler(this.bunifuThinButton22_Click);
			this.bunifuThinButton21.ActiveBorderThickness = 1;
			this.bunifuThinButton21.ActiveCornerRadius = 20;
			this.bunifuThinButton21.ActiveFillColor = global::System.Drawing.Color.FromArgb(56, 56, 56);
			this.bunifuThinButton21.ActiveForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton21.ActiveLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton21.BackColor = global::System.Drawing.Color.FromArgb(26, 26, 26);
			this.bunifuThinButton21.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuThinButton21.BackgroundImage");
			this.bunifuThinButton21.ButtonText = "Load settings";
			this.bunifuThinButton21.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton21.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuThinButton21.ForeColor = global::System.Drawing.Color.White;
			this.bunifuThinButton21.IdleBorderThickness = 1;
			this.bunifuThinButton21.IdleCornerRadius = 20;
			this.bunifuThinButton21.IdleFillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuThinButton21.IdleForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton21.IdleLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton21.Location = new global::System.Drawing.Point(12, 102);
			this.bunifuThinButton21.Margin = new global::System.Windows.Forms.Padding(5);
			this.bunifuThinButton21.Name = "bunifuThinButton21";
			this.bunifuThinButton21.Size = new global::System.Drawing.Size(239, 39);
			this.bunifuThinButton21.TabIndex = 27;
			this.bunifuThinButton21.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton21.Click += new global::System.EventHandler(this.bunifuThinButton21_Click);
			this.bunifuThinButton23.ActiveBorderThickness = 1;
			this.bunifuThinButton23.ActiveCornerRadius = 20;
			this.bunifuThinButton23.ActiveFillColor = global::System.Drawing.Color.FromArgb(56, 56, 56);
			this.bunifuThinButton23.ActiveForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton23.ActiveLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton23.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.bunifuThinButton23.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuThinButton23.BackgroundImage");
			this.bunifuThinButton23.ButtonText = "Check online user count";
			this.bunifuThinButton23.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton23.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuThinButton23.ForeColor = global::System.Drawing.Color.White;
			this.bunifuThinButton23.IdleBorderThickness = 1;
			this.bunifuThinButton23.IdleCornerRadius = 20;
			this.bunifuThinButton23.IdleFillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuThinButton23.IdleForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton23.IdleLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton23.Location = new global::System.Drawing.Point(9, 316);
			this.bunifuThinButton23.Margin = new global::System.Windows.Forms.Padding(5);
			this.bunifuThinButton23.Name = "bunifuThinButton23";
			this.bunifuThinButton23.Size = new global::System.Drawing.Size(213, 42);
			this.bunifuThinButton23.TabIndex = 27;
			this.bunifuThinButton23.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton23.Click += new global::System.EventHandler(this.bunifuThinButton23_Click);
			this.bunifuThinButton24.ActiveBorderThickness = 1;
			this.bunifuThinButton24.ActiveCornerRadius = 20;
			this.bunifuThinButton24.ActiveFillColor = global::System.Drawing.Color.FromArgb(56, 56, 56);
			this.bunifuThinButton24.ActiveForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton24.ActiveLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton24.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 0);
			this.bunifuThinButton24.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("bunifuThinButton24.BackgroundImage");
			this.bunifuThinButton24.ButtonText = "Show premium features";
			this.bunifuThinButton24.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton24.Font = new global::System.Drawing.Font("Century Gothic", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bunifuThinButton24.ForeColor = global::System.Drawing.Color.White;
			this.bunifuThinButton24.IdleBorderThickness = 1;
			this.bunifuThinButton24.IdleCornerRadius = 20;
			this.bunifuThinButton24.IdleFillColor = global::System.Drawing.Color.FromArgb(36, 36, 36);
			this.bunifuThinButton24.IdleForecolor = global::System.Drawing.Color.White;
			this.bunifuThinButton24.IdleLineColor = global::System.Drawing.Color.White;
			this.bunifuThinButton24.Location = new global::System.Drawing.Point(8, 278);
			this.bunifuThinButton24.Margin = new global::System.Windows.Forms.Padding(5);
			this.bunifuThinButton24.Name = "bunifuThinButton24";
			this.bunifuThinButton24.Size = new global::System.Drawing.Size(213, 42);
			this.bunifuThinButton24.TabIndex = 26;
			this.bunifuThinButton24.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton24.Click += new global::System.EventHandler(this.bunifuThinButton24_Click);
			this.label21.AutoSize = true;
			this.label21.Location = new global::System.Drawing.Point(74, 363);
			this.label21.Name = "label21";
			this.label21.Size = new global::System.Drawing.Size(28, 18);
			this.label21.TabIndex = 9;
			this.label21.Text = "2.0";
			this.dsugugdHGHSDGid730hjd.ErrorImage = (global::System.Drawing.Image)componentResourceManager.GetObject("dsugugdHGHSDGid730hjd.ErrorImage");
			this.dsugugdHGHSDGid730hjd.Image = global::Growtopia_macro.Properties.Resources.EnableDescriptor();
			this.dsugugdHGHSDGid730hjd.Location = new global::System.Drawing.Point(3, 6);
			this.dsugugdHGHSDGid730hjd.Name = "dsugugdHGHSDGid730hjd";
			this.dsugugdHGHSDGid730hjd.Size = new global::System.Drawing.Size(328, 78);
			this.dsugugdHGHSDGid730hjd.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.dsugugdHGHSDGid730hjd.TabIndex = 8;
			this.dsugugdHGHSDGid730hjd.TabStop = false;
			this.pictureBox4.Image = global::Growtopia_macro.Properties.Resources.ValidateDescriptor();
			this.pictureBox4.Location = new global::System.Drawing.Point(8, 90);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(259, 174);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 7;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new global::System.EventHandler(this.pictureBox4_Click);
			this.discordLogo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.discordLogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.discordLogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("discordLogo.Image");
			this.discordLogo.InitialImage = null;
			this.discordLogo.Location = new global::System.Drawing.Point(321, 7);
			this.discordLogo.Name = "discordLogo";
			this.discordLogo.Size = new global::System.Drawing.Size(126, 91);
			this.discordLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.discordLogo.TabIndex = 4;
			this.discordLogo.TabStop = false;
			this.discordLogo.Click += new global::System.EventHandler(this.discordLogo_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(6, 363);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(62, 18);
			this.label8.TabIndex = 6;
			this.label8.Text = "Version:";
			this.label8.Click += new global::System.EventHandler(this.label8_Click);
			this.YTlogo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.YTlogo.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.YTlogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("YTlogo.Image");
			this.YTlogo.InitialImage = null;
			this.YTlogo.Location = new global::System.Drawing.Point(453, 11);
			this.YTlogo.Name = "YTlogo";
			this.YTlogo.Size = new global::System.Drawing.Size(123, 87);
			this.YTlogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.YTlogo.TabIndex = 5;
			this.YTlogo.TabStop = false;
			this.YTlogo.Click += new global::System.EventHandler(this.YTlogo_Click);
			this.AllowDrop = true;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(725, 441);
			base.Controls.Add(this.label31);
			base.Controls.Add(this.label28);
			base.Controls.Add(this.label20);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.pictureBox9);
			base.Controls.Add(this.iTalk_TabControl1);
			base.Controls.Add(this.label17);
			base.Controls.Add(this.pictureBox5);
			this.ForeColor = global::System.Drawing.Color.White;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(741, 600);
			this.MinimumSize = new global::System.Drawing.Size(624, 435);
			base.Name = "Form1";
			base.Opacity = 0.98;
			this.Text = "GT Auto-CCS by RealGoblins";
			this.toolTip_0.SetToolTip(this, "Made by RealGoblins");
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ParamVisitor_FormClosing);
			base.Load += new global::System.EventHandler(this.ParamVisitor_Load);
			base.Click += new global::System.EventHandler(this.ParamVisitor_Click);
			base.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.ParamVisitor_KeyPress);
			base.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.ParamVisitor_MouseClick);
			base.Move += new global::System.EventHandler(this.ParamVisitor_Move);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox5).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox9).EndInit();
			this.Macros_box.ResumeLayout(false);
			this.Macros_box.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.no_GT_windows).EndInit();
			this.iTalk_TabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.Windows_box.ResumeLayout(false);
			this.Windows_box.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabControl3.ResumeLayout(false);
			this.tabPage15.ResumeLayout(false);
			this.tabPage15.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SpamDelay).EndInit();
			this.Attach.ResumeLayout(false);
			this.Attach.PerformLayout();
			this.spammertextgroup.ResumeLayout(false);
			this.spammertextgroup.PerformLayout();
			this.tabPage16.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown8).EndInit();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown7).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown5).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown6).EndInit();
			this.tabPage14.ResumeLayout(false);
			this.tabPage14.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.tabPage6.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.tabPage7.ResumeLayout(false);
			this.SearchGroup.ResumeLayout(false);
			this.SearchGroup.PerformLayout();
			this.tabPage8.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage12.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.iTalk_NumericUpDown1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPage13.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabPage10.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox8).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox7).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox6).EndInit();
			this.tabPage11.ResumeLayout(false);
			this.tabPage11.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dsugugdHGHSDGid730hjd).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.discordLogo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.YTlogo).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400016D RID: 365
		private global::System.ComponentModel.Container container_0;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.GroupBox Macros_box;

		// Token: 0x0400016F RID: 367
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000170 RID: 368
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000171 RID: 369
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000172 RID: 370
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000173 RID: 371
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.MaskedTextBox maskedTextBox1;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.GroupBox Windows_box;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.CheckedListBox Macros;

		// Token: 0x04000179 RID: 377
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400017A RID: 378
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x0400017B RID: 379
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400017C RID: 380
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.CheckedListBox Windows;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.NumericUpDown numericUpDown3;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.NumericUpDown numericUpDown4;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000185 RID: 389
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000186 RID: 390
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000187 RID: 391
		private global::System.Windows.Forms.Button button12;

		// Token: 0x04000188 RID: 392
		private global::System.Windows.Forms.Button button11;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400018B RID: 395
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400018C RID: 396
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400018D RID: 397
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400018E RID: 398
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.PictureBox YTlogo;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.PictureBox discordLogo;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.NumericUpDown no_GT_windows;

		// Token: 0x04000194 RID: 404
		private global::System.Windows.Forms.Button startGTwindows;

		// Token: 0x04000195 RID: 405
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;

		// Token: 0x04000196 RID: 406
		private new global::System.Windows.Forms.Button Refresh;

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.CheckBox Select_all;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.Button close_gt_windows;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x0400019A RID: 410
		private global::System.Windows.Forms.MaskedTextBox SpammerText1;

		// Token: 0x0400019B RID: 411
		private global::System.Windows.Forms.GroupBox Attach;

		// Token: 0x0400019C RID: 412
		private global::System.Windows.Forms.CheckedListBox ProcessesSpam;

		// Token: 0x0400019D RID: 413
		private global::System.Windows.Forms.CheckBox EnableSpammer;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.Forms.GroupBox spammertextgroup;

		// Token: 0x0400019F RID: 415
		private global::System.Windows.Forms.NumericUpDown SpamDelay;

		// Token: 0x040001A0 RID: 416
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040001A1 RID: 417
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040001A2 RID: 418
		private global::System.Windows.Forms.MaskedTextBox MsgSpamTo;

		// Token: 0x040001A3 RID: 419
		private global::System.Windows.Forms.Label label11;

		// Token: 0x040001A4 RID: 420
		private global::System.Windows.Forms.CheckBox MsgSpamCheckBox;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.MaskedTextBox addInFront;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.Button RefreshSpam;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Forms.CheckBox SelectAllSpam;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.CheckBox AddInFrontCheckBox;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.Button button13;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.GroupBox SearchGroup;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.MaskedTextBox maskedTextBox2;

		// Token: 0x040001AD RID: 429
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040001AF RID: 431
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x040001B0 RID: 432
		private global::System.Windows.Forms.Button Execute;

		// Token: 0x040001B1 RID: 433
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040001B3 RID: 435
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Forms.CheckedListBox checkedListBox2;

		// Token: 0x040001B7 RID: 439
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040001B8 RID: 440
		private global::System.Windows.Forms.Button button15;

		// Token: 0x040001B9 RID: 441
		private global::System.Windows.Forms.Button button14;

		// Token: 0x040001BA RID: 442
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040001BB RID: 443
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040001BC RID: 444
		private global::System.Windows.Forms.NumericUpDown numericUpDown5;

		// Token: 0x040001BD RID: 445
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040001BE RID: 446
		private global::System.Windows.Forms.NumericUpDown numericUpDown6;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Forms.NumericUpDown numericUpDown7;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Forms.PictureBox dsugugdHGHSDGid730hjd;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Forms.PictureBox pictureBox5;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Forms.Button UnbanButton;

		// Token: 0x040001C4 RID: 452
		public global::System.Windows.Forms.ListBox m_QueueTests;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Forms.PictureBox pictureBox6;

		// Token: 0x040001C6 RID: 454
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040001C7 RID: 455
		private global::System.Windows.Forms.MaskedTextBox maskedTextBox3;

		// Token: 0x040001C8 RID: 456
		private global::System.Windows.Forms.Button button16;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Forms.CheckBox checkBox4;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Forms.Button button17;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Forms.Button button20;

		// Token: 0x040001CD RID: 461
		private global::System.Windows.Forms.Button button19;

		// Token: 0x040001CE RID: 462
		private global::System.Windows.Forms.Button button18;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Forms.PictureBox pictureBox7;

		// Token: 0x040001D0 RID: 464
		private global::System.Windows.Forms.PictureBox pictureBox8;

		// Token: 0x040001D1 RID: 465
		private global::System.Windows.Forms.Button button21;

		// Token: 0x040001D2 RID: 466
		private global::System.Windows.Forms.Button button22;

		// Token: 0x040001D3 RID: 467
		private global::System.Windows.Forms.Button button23;

		// Token: 0x040001D4 RID: 468
		private global::System.Windows.Forms.Button button24;

		// Token: 0x040001D5 RID: 469
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x040001D6 RID: 470
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x040001D7 RID: 471
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040001D8 RID: 472
		private global::System.Windows.Forms.Button button25;

		// Token: 0x040001D9 RID: 473
		private global::System.Windows.Forms.CheckBox MB_enable;

		// Token: 0x040001DA RID: 474
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040001DB RID: 475
		private global::System.Windows.Forms.ComboBox GT_version_cmd;

		// Token: 0x040001DC RID: 476
		private global::System.Windows.Forms.CheckBox checkBox5;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040001DE RID: 478
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040001DF RID: 479
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040001E0 RID: 480
		private global::System.Windows.Forms.Button button28;

		// Token: 0x040001E1 RID: 481
		private global::System.Windows.Forms.Button button27;

		// Token: 0x040001E2 RID: 482
		private global::System.Windows.Forms.Button button26;

		// Token: 0x040001E3 RID: 483
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x040001E4 RID: 484
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040001E5 RID: 485
		private global::System.Windows.Forms.PictureBox pictureBox9;

		// Token: 0x040001E6 RID: 486
		private global::System.Windows.Forms.Button button29;

		// Token: 0x040001E7 RID: 487
		private global::ns0.Control16 iTalk_TabControl1;

		// Token: 0x040001E8 RID: 488
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040001E9 RID: 489
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x040001EA RID: 490
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x040001EB RID: 491
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x040001EC RID: 492
		private global::System.Windows.Forms.TabPage tabPage7;

		// Token: 0x040001ED RID: 493
		private global::System.Windows.Forms.TabPage tabPage8;

		// Token: 0x040001EE RID: 494
		private global::System.Windows.Forms.TabPage tabPage9;

		// Token: 0x040001EF RID: 495
		private global::System.Windows.Forms.TabPage tabPage10;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Forms.TabPage tabPage11;

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Forms.MaskedTextBox SpammerText4;

		// Token: 0x040001F2 RID: 498
		private global::System.Windows.Forms.MaskedTextBox SpammerText3;

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Forms.MaskedTextBox SpammerText2;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Forms.CheckBox SpamTxt4;

		// Token: 0x040001F5 RID: 501
		private global::System.Windows.Forms.CheckBox SpamTxt3;

		// Token: 0x040001F6 RID: 502
		private global::System.Windows.Forms.CheckBox SpamTxt2;

		// Token: 0x040001F7 RID: 503
		private global::System.Windows.Forms.CheckBox SpamTxt1;

		// Token: 0x040001F8 RID: 504
		private global::System.Windows.Forms.CheckBox checkBox7;

		// Token: 0x040001F9 RID: 505
		private global::System.Windows.Forms.CheckBox checkBox6;

		// Token: 0x040001FA RID: 506
		private global::System.Windows.Forms.Button button30;

		// Token: 0x040001FB RID: 507
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x040001FC RID: 508
		private global::System.Windows.Forms.Button button31;

		// Token: 0x040001FD RID: 509
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040001FE RID: 510
		private global::System.Windows.Forms.Label label20;

		// Token: 0x040001FF RID: 511
		private global::System.Windows.Forms.Label label21;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.Forms.Label label24;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Forms.TrackBar trackBar2;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Forms.TabControl tabControl2;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Forms.TabPage tabPage12;

		// Token: 0x04000206 RID: 518
		private global::System.Windows.Forms.TabPage tabPage13;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000208 RID: 520
		private global::Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;

		// Token: 0x04000209 RID: 521
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;

		// Token: 0x0400020A RID: 522
		private global::ns0.Class7 iTalk_Label1;

		// Token: 0x0400020B RID: 523
		private global::ns0.Control10 iTalk_RichTextBox1;

		// Token: 0x0400020C RID: 524
		private global::System.Windows.Forms.GroupBox groupBox8;

		// Token: 0x0400020D RID: 525
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;

		// Token: 0x0400020E RID: 526
		private global::ns0.Class7 iTalk_Label2;

		// Token: 0x0400020F RID: 527
		private global::System.Windows.Forms.CheckedListBox checkedListBox3;

		// Token: 0x04000210 RID: 528
		private global::System.Windows.Forms.CheckBox checkBox8;

		// Token: 0x04000211 RID: 529
		private global::Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Forms.CheckBox checkBox9;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Forms.Label label25;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Forms.NumericUpDown iTalk_NumericUpDown1;

		// Token: 0x04000215 RID: 533
		private global::Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;

		// Token: 0x04000216 RID: 534
		private global::System.Windows.Forms.CheckBox checkBox10;

		// Token: 0x04000217 RID: 535
		private global::Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;

		// Token: 0x04000218 RID: 536
		private global::Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.TabPage tabPage14;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.Button button33;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.Button button32;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.Label label30;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Variable;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.DataGridViewTextBoxColumn Value;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.Label label28;

		// Token: 0x04000225 RID: 549
		private global::Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.Label label31;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.CheckedListBox checkedListBox4;

		// Token: 0x04000229 RID: 553
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400022A RID: 554
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Forms.Panel panel5;

		// Token: 0x0400022C RID: 556
		private global::System.Windows.Forms.Label label32;

		// Token: 0x0400022D RID: 557
		private global::System.Windows.Forms.Label label34;

		// Token: 0x0400022E RID: 558
		private global::System.Windows.Forms.Label label33;

		// Token: 0x0400022F RID: 559
		private global::System.Windows.Forms.Label label35;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.ComboBox comboBox4;

		// Token: 0x04000231 RID: 561
		private global::System.Windows.Forms.Label label36;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.TabControl tabControl3;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.TabPage tabPage15;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Forms.TabPage tabPage16;

		// Token: 0x04000235 RID: 565
		private global::System.Windows.Forms.Label label40;

		// Token: 0x04000236 RID: 566
		private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Label label39;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.Button button37;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.Button button35;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.Button button34;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.CheckedListBox checkedListBox5;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.Label label38;

		// Token: 0x0400023D RID: 573
		private global::System.Windows.Forms.Label label37;

		// Token: 0x0400023E RID: 574
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.GroupBox groupBox9;

		// Token: 0x04000241 RID: 577
		private global::System.Windows.Forms.Label label41;

		// Token: 0x04000242 RID: 578
		private global::Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;

		// Token: 0x04000243 RID: 579
		private global::System.Windows.Forms.NumericUpDown numericUpDown8;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.Label label42;

		// Token: 0x04000245 RID: 581
		private global::ns0.Class9 iTalk_HeaderLabel1;

		// Token: 0x04000246 RID: 582
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000247 RID: 583
		private global::System.Windows.Forms.Label label43;

		// Token: 0x04000248 RID: 584
		private global::System.Windows.Forms.Label label44;
	}
}
