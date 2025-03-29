namespace MilkDropMessenger
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      statusStrip1 = new StatusStrip();
      statusBar = new ToolStripStatusLabel();
      toolTip1 = new ToolTip(components);
      pnlColor = new Panel();
      bnAppendColor = new Button();
      label9 = new Label();
      btnFontAppend = new Button();
      label8 = new Label();
      cboFonts = new ComboBox();
      txtWait = new TextBox();
      label7 = new Label();
      label6 = new Label();
      chkAutoplay = new CheckBox();
      txtAutoplay = new TextBox();
      btnSaveParam = new Button();
      label4 = new Label();
      txtParameters = new ComboBox();
      txtWindowTitle = new TextBox();
      colorDialog1 = new ColorDialog();
      btnF4 = new Button();
      groupBox1 = new GroupBox();
      label5 = new Label();
      label2 = new Label();
      label1 = new Label();
      button1 = new Button();
      txtMessage = new TextBox();
      groupBox2 = new GroupBox();
      tableLayoutPanel1 = new TableLayoutPanel();
      btn77 = new Button();
      btn66 = new Button();
      btn55 = new Button();
      btn44 = new Button();
      btn33 = new Button();
      btnm22 = new Button();
      btnC = new Button();
      btnF8 = new Button();
      btnN = new Button();
      btnAltEnter = new Button();
      btnDelete = new Button();
      btn11 = new Button();
      btnTilde = new Button();
      btn00 = new Button();
      btnSpace = new Button();
      btnF7 = new Button();
      btnF3 = new Button();
      btnBackspace = new Button();
      btnShiftK = new Button();
      panel1 = new Panel();
      linkLabel2 = new LinkLabel();
      linkLabel1 = new LinkLabel();
      statusStrip1.SuspendLayout();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // statusStrip1
      // 
      statusStrip1.ImageScalingSize = new Size(20, 20);
      statusStrip1.Items.AddRange(new ToolStripItem[] { statusBar });
      statusStrip1.Location = new Point(0, 518);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(869, 22);
      statusStrip1.TabIndex = 5;
      statusStrip1.Text = "statusStrip1";
      // 
      // statusBar
      // 
      statusBar.Name = "statusBar";
      statusBar.Size = new Size(0, 16);
      // 
      // pnlColor
      // 
      pnlColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      pnlColor.BorderStyle = BorderStyle.FixedSingle;
      pnlColor.Location = new Point(585, 128);
      pnlColor.Name = "pnlColor";
      pnlColor.Size = new Size(56, 27);
      pnlColor.TabIndex = 7;
      toolTip1.SetToolTip(pnlColor, "Only used if no r, g, b parameters supplied");
      pnlColor.Click += pnlColor_Click;
      // 
      // bnAppendColor
      // 
      bnAppendColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      bnAppendColor.Location = new Point(650, 125);
      bnAppendColor.Margin = new Padding(0);
      bnAppendColor.Name = "bnAppendColor";
      bnAppendColor.Size = new Size(84, 30);
      bnAppendColor.TabIndex = 8;
      bnAppendColor.Text = "Append";
      toolTip1.SetToolTip(bnAppendColor, "Append to parameters string above if no color already defined");
      bnAppendColor.UseVisualStyleBackColor = true;
      bnAppendColor.Click += btnAppendColor_Click;
      // 
      // label9
      // 
      label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label9.AutoSize = true;
      label9.Location = new Point(537, 130);
      label9.Name = "label9";
      label9.Size = new Size(45, 20);
      label9.TabIndex = 62;
      label9.Text = "Color";
      toolTip1.SetToolTip(label9, "Only used if no r, g, b parameters supplied");
      // 
      // btnFontAppend
      // 
      btnFontAppend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnFontAppend.Location = new Point(436, 125);
      btnFontAppend.Margin = new Padding(0);
      btnFontAppend.Name = "btnFontAppend";
      btnFontAppend.Size = new Size(84, 30);
      btnFontAppend.TabIndex = 6;
      btnFontAppend.Text = "Append";
      toolTip1.SetToolTip(btnFontAppend, "Append to parameters string above if no font already defined");
      btnFontAppend.UseVisualStyleBackColor = true;
      btnFontAppend.Click += btnFontAppend_Click;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(64, 130);
      label8.Name = "label8";
      label8.Size = new Size(38, 20);
      label8.TabIndex = 60;
      label8.Text = "Font";
      toolTip1.SetToolTip(label8, "Only used if no font parameter supplied");
      // 
      // cboFonts
      // 
      cboFonts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      cboFonts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      cboFonts.AutoCompleteSource = AutoCompleteSource.ListItems;
      cboFonts.FormattingEnabled = true;
      cboFonts.Location = new Point(108, 127);
      cboFonts.Name = "cboFonts";
      cboFonts.Size = new Size(325, 28);
      cboFonts.TabIndex = 5;
      toolTip1.SetToolTip(cboFonts, "Only used if no font parameter supplied");
      // 
      // txtWait
      // 
      txtWait.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtWait.Location = new Point(690, 161);
      txtWait.Name = "txtWait";
      txtWait.Size = new Size(44, 27);
      txtWait.TabIndex = 10;
      txtWait.Text = "10";
      txtWait.TextAlign = HorizontalAlignment.Center;
      toolTip1.SetToolTip(txtWait, "Wait time between lines in seconds");
      // 
      // label7
      // 
      label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label7.AutoSize = true;
      label7.Location = new Point(649, 164);
      label7.Name = "label7";
      label7.Size = new Size(39, 20);
      label7.TabIndex = 57;
      label7.Text = "Wait";
      toolTip1.SetToolTip(label7, "Wait time between lines in seconds");
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(33, 163);
      label6.Name = "label6";
      label6.Size = new Size(69, 20);
      label6.TabIndex = 56;
      label6.Text = "Autoplay";
      toolTip1.SetToolTip(label6, "Double-click to reload file MilkDropMessenger.txt");
      label6.DoubleClick += label6_DoubleClick;
      // 
      // chkAutoplay
      // 
      chkAutoplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      chkAutoplay.Appearance = Appearance.Button;
      chkAutoplay.FlatStyle = FlatStyle.System;
      chkAutoplay.Location = new Point(745, 159);
      chkAutoplay.Name = "chkAutoplay";
      chkAutoplay.Size = new Size(88, 30);
      chkAutoplay.TabIndex = 11;
      chkAutoplay.Text = "Autoplay";
      chkAutoplay.TextAlign = ContentAlignment.MiddleCenter;
      chkAutoplay.TextImageRelation = TextImageRelation.ImageAboveText;
      toolTip1.SetToolTip(chkAutoplay, "Automatically send messages from file");
      chkAutoplay.UseVisualStyleBackColor = true;
      chkAutoplay.CheckedChanged += chkAutoplay_CheckedChanged;
      // 
      // txtAutoplay
      // 
      txtAutoplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtAutoplay.Enabled = false;
      txtAutoplay.Location = new Point(108, 161);
      txtAutoplay.Name = "txtAutoplay";
      txtAutoplay.Size = new Size(533, 27);
      txtAutoplay.TabIndex = 9;
      toolTip1.SetToolTip(txtAutoplay, "Autoplay lines from file MilkDropMessenger.txt");
      // 
      // btnSaveParam
      // 
      btnSaveParam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnSaveParam.FlatStyle = FlatStyle.System;
      btnSaveParam.Location = new Point(745, 91);
      btnSaveParam.Margin = new Padding(0);
      btnSaveParam.Name = "btnSaveParam";
      btnSaveParam.Size = new Size(88, 30);
      btnSaveParam.TabIndex = 4;
      btnSaveParam.Text = "Save";
      toolTip1.SetToolTip(btnSaveParam, "Save up to 10 entries, double-click \"Parameters\" label to clear");
      btnSaveParam.UseVisualStyleBackColor = true;
      btnSaveParam.Click += btnSaveParam_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(20, 95);
      label4.Name = "label4";
      label4.Size = new Size(82, 20);
      label4.TabIndex = 51;
      label4.Text = "Parameters";
      toolTip1.SetToolTip(label4, "Double-click to clear saved parameters");
      // 
      // txtParameters
      // 
      txtParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtParameters.DropDownStyle = ComboBoxStyle.DropDownList;
      txtParameters.Location = new Point(108, 92);
      txtParameters.Name = "txtParameters";
      txtParameters.Size = new Size(626, 28);
      txtParameters.TabIndex = 3;
      toolTip1.SetToolTip(txtParameters, resources.GetString("txtParameters.ToolTip"));
      // 
      // txtWindowTitle
      // 
      txtWindowTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtWindowTitle.Location = new Point(108, 59);
      txtWindowTitle.Name = "txtWindowTitle";
      txtWindowTitle.Size = new Size(505, 27);
      txtWindowTitle.TabIndex = 2;
      txtWindowTitle.Text = "MilkDrop 3";
      toolTip1.SetToolTip(txtWindowTitle, "Partitial window title of MilkDrop window");
      // 
      // colorDialog1
      // 
      colorDialog1.AnyColor = true;
      colorDialog1.Color = Color.White;
      colorDialog1.FullOpen = true;
      colorDialog1.SolidColorOnly = true;
      // 
      // btnF4
      // 
      tableLayoutPanel1.SetColumnSpan(btnF4, 2);
      btnF4.Dock = DockStyle.Fill;
      btnF4.Location = new Point(214, 66);
      btnF4.Name = "btnF4";
      btnF4.Size = new Size(200, 52);
      btnF4.TabIndex = 5;
      btnF4.Text = "Toggle Preset Name\r\n(F4)";
      btnF4.UseVisualStyleBackColor = true;
      btnF4.Click += btnF4_Click;
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.Controls.Add(pnlColor);
      groupBox1.Controls.Add(bnAppendColor);
      groupBox1.Controls.Add(label9);
      groupBox1.Controls.Add(btnFontAppend);
      groupBox1.Controls.Add(label8);
      groupBox1.Controls.Add(cboFonts);
      groupBox1.Controls.Add(txtWait);
      groupBox1.Controls.Add(label7);
      groupBox1.Controls.Add(label6);
      groupBox1.Controls.Add(chkAutoplay);
      groupBox1.Controls.Add(txtAutoplay);
      groupBox1.Controls.Add(btnSaveParam);
      groupBox1.Controls.Add(label5);
      groupBox1.Controls.Add(label4);
      groupBox1.Controls.Add(txtParameters);
      groupBox1.Controls.Add(label2);
      groupBox1.Controls.Add(label1);
      groupBox1.Controls.Add(txtWindowTitle);
      groupBox1.Controls.Add(button1);
      groupBox1.Controls.Add(txtMessage);
      groupBox1.Location = new Point(12, 12);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(844, 203);
      groupBox1.TabIndex = 26;
      groupBox1.TabStop = false;
      groupBox1.Text = "Send Messages";
      // 
      // label5
      // 
      label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label5.AutoSize = true;
      label5.Location = new Point(618, 62);
      label5.Name = "label5";
      label5.Size = new Size(116, 20);
      label5.TabIndex = 52;
      label5.Text = "(partitial match)";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(35, 30);
      label2.Name = "label2";
      label2.Size = new Size(67, 20);
      label2.TabIndex = 49;
      label2.Text = "Message";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(38, 62);
      label1.Name = "label1";
      label1.Size = new Size(64, 20);
      label1.TabIndex = 48;
      label1.Text = "Window";
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button1.FlatStyle = FlatStyle.System;
      button1.Location = new Point(745, 26);
      button1.Margin = new Padding(0);
      button1.Name = "button1";
      button1.Size = new Size(88, 58);
      button1.TabIndex = 1;
      button1.Text = "Send";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // txtMessage
      // 
      txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtMessage.Location = new Point(108, 27);
      txtMessage.Name = "txtMessage";
      txtMessage.Size = new Size(626, 27);
      txtMessage.TabIndex = 0;
      txtMessage.Text = "Hi from MilkDrop Messenger!";
      // 
      // groupBox2
      // 
      groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      groupBox2.Controls.Add(tableLayoutPanel1);
      groupBox2.Location = new Point(12, 221);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(844, 270);
      groupBox2.TabIndex = 27;
      groupBox2.TabStop = false;
      groupBox2.Text = "Send Keys";
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 8;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
      tableLayoutPanel1.Controls.Add(btn77, 7, 3);
      tableLayoutPanel1.Controls.Add(btn66, 6, 3);
      tableLayoutPanel1.Controls.Add(btn55, 5, 3);
      tableLayoutPanel1.Controls.Add(btn44, 4, 3);
      tableLayoutPanel1.Controls.Add(btn33, 3, 3);
      tableLayoutPanel1.Controls.Add(btnm22, 2, 3);
      tableLayoutPanel1.Controls.Add(btnC, 4, 2);
      tableLayoutPanel1.Controls.Add(btnF8, 6, 1);
      tableLayoutPanel1.Controls.Add(btnN, 2, 2);
      tableLayoutPanel1.Controls.Add(btnAltEnter, 0, 2);
      tableLayoutPanel1.Controls.Add(btnDelete, 6, 2);
      tableLayoutPanel1.Controls.Add(btn11, 1, 3);
      tableLayoutPanel1.Controls.Add(btnTilde, 6, 0);
      tableLayoutPanel1.Controls.Add(btn00, 0, 3);
      tableLayoutPanel1.Controls.Add(btnSpace, 0, 0);
      tableLayoutPanel1.Controls.Add(btnF7, 4, 1);
      tableLayoutPanel1.Controls.Add(btnF4, 2, 1);
      tableLayoutPanel1.Controls.Add(btnF3, 0, 1);
      tableLayoutPanel1.Controls.Add(btnBackspace, 2, 0);
      tableLayoutPanel1.Controls.Add(btnShiftK, 4, 0);
      tableLayoutPanel1.Dock = DockStyle.Fill;
      tableLayoutPanel1.Location = new Point(3, 23);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.Padding = new Padding(5);
      tableLayoutPanel1.RowCount = 4;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
      tableLayoutPanel1.Size = new Size(838, 244);
      tableLayoutPanel1.TabIndex = 33;
      // 
      // btn77
      // 
      btn77.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn77.Location = new Point(729, 182);
      btn77.Name = "btn77";
      btn77.Size = new Size(101, 54);
      btn77.TabIndex = 19;
      btn77.Text = "77";
      btn77.UseVisualStyleBackColor = true;
      btn77.Click += btn77_Click;
      // 
      // btn66
      // 
      btn66.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn66.Location = new Point(626, 182);
      btn66.Name = "btn66";
      btn66.Size = new Size(97, 54);
      btn66.TabIndex = 18;
      btn66.Text = "66";
      btn66.UseVisualStyleBackColor = true;
      btn66.Click += btn66_Click;
      // 
      // btn55
      // 
      btn55.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn55.Location = new Point(523, 182);
      btn55.Name = "btn55";
      btn55.Size = new Size(97, 54);
      btn55.TabIndex = 17;
      btn55.Text = "55";
      btn55.UseVisualStyleBackColor = true;
      btn55.Click += btn55_Click;
      // 
      // btn44
      // 
      btn44.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn44.Location = new Point(420, 182);
      btn44.Name = "btn44";
      btn44.Size = new Size(97, 54);
      btn44.TabIndex = 16;
      btn44.Text = "44";
      btn44.UseVisualStyleBackColor = true;
      btn44.Click += btn44_Click;
      // 
      // btn33
      // 
      btn33.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn33.Location = new Point(317, 182);
      btn33.Name = "btn33";
      btn33.Size = new Size(97, 54);
      btn33.TabIndex = 15;
      btn33.Text = "33";
      btn33.UseVisualStyleBackColor = true;
      btn33.Click += btn33_Click;
      // 
      // btnm22
      // 
      btnm22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btnm22.Location = new Point(214, 182);
      btnm22.Name = "btnm22";
      btnm22.Size = new Size(97, 54);
      btnm22.TabIndex = 14;
      btnm22.Text = "22";
      btnm22.UseVisualStyleBackColor = true;
      btnm22.Click += btnm22_Click;
      // 
      // btnC
      // 
      tableLayoutPanel1.SetColumnSpan(btnC, 2);
      btnC.Dock = DockStyle.Fill;
      btnC.Location = new Point(420, 124);
      btnC.Name = "btnC";
      btnC.Size = new Size(200, 52);
      btnC.TabIndex = 10;
      btnC.Text = "Randomize Color\r\n(C)";
      btnC.UseVisualStyleBackColor = true;
      btnC.Click += btnC_Click;
      // 
      // btnF8
      // 
      tableLayoutPanel1.SetColumnSpan(btnF8, 2);
      btnF8.Dock = DockStyle.Fill;
      btnF8.Location = new Point(626, 66);
      btnF8.Name = "btnF8";
      btnF8.Size = new Size(204, 52);
      btnF8.TabIndex = 7;
      btnF8.Text = "Change Hardcut \r\n(F8)";
      btnF8.UseVisualStyleBackColor = true;
      btnF8.Click += btnF8_Click;
      // 
      // btnN
      // 
      tableLayoutPanel1.SetColumnSpan(btnN, 2);
      btnN.Dock = DockStyle.Fill;
      btnN.Location = new Point(214, 124);
      btnN.Name = "btnN";
      btnN.Size = new Size(200, 52);
      btnN.TabIndex = 9;
      btnN.Text = "Toggle Info\r\n(N)";
      btnN.UseVisualStyleBackColor = true;
      btnN.Click += btnN_Click;
      // 
      // btnAltEnter
      // 
      tableLayoutPanel1.SetColumnSpan(btnAltEnter, 2);
      btnAltEnter.Dock = DockStyle.Fill;
      btnAltEnter.Location = new Point(8, 124);
      btnAltEnter.Name = "btnAltEnter";
      btnAltEnter.Size = new Size(200, 52);
      btnAltEnter.TabIndex = 8;
      btnAltEnter.Text = "Toggle Fullscreen\r\n(Alt+Enter)";
      btnAltEnter.UseVisualStyleBackColor = true;
      btnAltEnter.Click += btnAltEnter_Click;
      // 
      // btnDelete
      // 
      tableLayoutPanel1.SetColumnSpan(btnDelete, 2);
      btnDelete.Dock = DockStyle.Fill;
      btnDelete.Location = new Point(626, 124);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new Size(204, 52);
      btnDelete.TabIndex = 11;
      btnDelete.Text = "Clear Latest Sprite\r\n(Delete)";
      btnDelete.UseVisualStyleBackColor = true;
      btnDelete.Click += btnDelete_Click;
      // 
      // btn11
      // 
      btn11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn11.Location = new Point(111, 182);
      btn11.Name = "btn11";
      btn11.Size = new Size(97, 54);
      btn11.TabIndex = 13;
      btn11.Text = "11";
      btn11.UseVisualStyleBackColor = true;
      btn11.Click += btn11_Click;
      // 
      // btnTilde
      // 
      tableLayoutPanel1.SetColumnSpan(btnTilde, 2);
      btnTilde.Dock = DockStyle.Fill;
      btnTilde.Location = new Point(626, 8);
      btnTilde.Name = "btnTilde";
      btnTilde.Size = new Size(204, 52);
      btnTilde.TabIndex = 3;
      btnTilde.Text = "Toggle Preset Lock \r\n(~)";
      btnTilde.UseVisualStyleBackColor = true;
      btnTilde.Click += btnTilde_Click;
      // 
      // btn00
      // 
      btn00.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      btn00.Location = new Point(8, 182);
      btn00.Name = "btn00";
      btn00.Size = new Size(97, 54);
      btn00.TabIndex = 12;
      btn00.Text = "00";
      btn00.UseVisualStyleBackColor = true;
      btn00.Click += btn00_Click;
      // 
      // btnSpace
      // 
      tableLayoutPanel1.SetColumnSpan(btnSpace, 2);
      btnSpace.Dock = DockStyle.Fill;
      btnSpace.Location = new Point(8, 8);
      btnSpace.Name = "btnSpace";
      btnSpace.Size = new Size(200, 52);
      btnSpace.TabIndex = 0;
      btnSpace.Text = "Next Preset\r\n(Space)";
      btnSpace.UseVisualStyleBackColor = true;
      btnSpace.Click += btnSpace_Click;
      // 
      // btnF7
      // 
      tableLayoutPanel1.SetColumnSpan(btnF7, 2);
      btnF7.Dock = DockStyle.Fill;
      btnF7.Location = new Point(420, 66);
      btnF7.Name = "btnF7";
      btnF7.Size = new Size(200, 52);
      btnF7.TabIndex = 6;
      btnF7.Text = "On Top/Borderless\r\n(F7)";
      btnF7.UseVisualStyleBackColor = true;
      btnF7.Click += btnF7_Click;
      // 
      // btnF3
      // 
      tableLayoutPanel1.SetColumnSpan(btnF3, 2);
      btnF3.Dock = DockStyle.Fill;
      btnF3.Location = new Point(8, 66);
      btnF3.Name = "btnF3";
      btnF3.Size = new Size(200, 52);
      btnF3.TabIndex = 4;
      btnF3.Text = "Change Time\r\n(F3)";
      btnF3.UseVisualStyleBackColor = true;
      btnF3.Click += btnF3_Click;
      // 
      // btnBackspace
      // 
      tableLayoutPanel1.SetColumnSpan(btnBackspace, 2);
      btnBackspace.Dock = DockStyle.Fill;
      btnBackspace.Location = new Point(214, 8);
      btnBackspace.Name = "btnBackspace";
      btnBackspace.Size = new Size(200, 52);
      btnBackspace.TabIndex = 1;
      btnBackspace.Text = "Previous Preset\r\n(Backspace)";
      btnBackspace.UseVisualStyleBackColor = true;
      btnBackspace.Click += btnBackspace_Click;
      // 
      // btnShiftK
      // 
      tableLayoutPanel1.SetColumnSpan(btnShiftK, 2);
      btnShiftK.Dock = DockStyle.Fill;
      btnShiftK.Location = new Point(420, 8);
      btnShiftK.Name = "btnShiftK";
      btnShiftK.Size = new Size(200, 52);
      btnShiftK.TabIndex = 2;
      btnShiftK.Text = "Sprite/Message Mode\r\n(Shift+K)";
      btnShiftK.UseVisualStyleBackColor = true;
      btnShiftK.Click += btnShiftK_Click;
      // 
      // panel1
      // 
      panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      panel1.Controls.Add(linkLabel2);
      panel1.Controls.Add(linkLabel1);
      panel1.Location = new Point(15, 493);
      panel1.Name = "panel1";
      panel1.Size = new Size(838, 30);
      panel1.TabIndex = 28;
      // 
      // linkLabel2
      // 
      linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      linkLabel2.AutoSize = true;
      linkLabel2.Location = new Point(617, 3);
      linkLabel2.Name = "linkLabel2";
      linkLabel2.Size = new Size(218, 20);
      linkLabel2.TabIndex = 1;
      linkLabel2.TabStop = true;
      linkLabel2.Text = "MilkDrop Messenger on GitHub";
      linkLabel2.LinkClicked += linkLabel2_LinkClicked;
      // 
      // linkLabel1
      // 
      linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      linkLabel1.AutoSize = true;
      linkLabel1.Location = new Point(-3, 3);
      linkLabel1.Name = "linkLabel1";
      linkLabel1.Size = new Size(197, 20);
      linkLabel1.TabIndex = 0;
      linkLabel1.TabStop = true;
      linkLabel1.Text = "MilkDrop Feature Discussion";
      linkLabel1.LinkClicked += linkLabel1_LinkClicked;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(869, 540);
      Controls.Add(statusStrip1);
      Controls.Add(panel1);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      Text = "MilkDrop Messenger";
      Shown += MainForm_Shown;
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      tableLayoutPanel1.ResumeLayout(false);
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel statusBar;
    private ToolTip toolTip1;
    private ColorDialog colorDialog1;
    private Button btnF4;
    private GroupBox groupBox1;
    private Panel pnlColor;
    private Button bnAppendColor;
    private Label label9;
    private Button btnFontAppend;
    private Label label8;
    private ComboBox cboFonts;
    private TextBox txtWait;
    private Label label7;
    private Label label6;
    private CheckBox chkAutoplay;
    private TextBox txtAutoplay;
    private Button btnSaveParam;
    private Label label5;
    private Label label4;
    private ComboBox txtParameters;
    private Label label2;
    private Label label1;
    private TextBox txtWindowTitle;
    private Button button1;
    private TextBox txtMessage;
    private GroupBox groupBox2;
    private Button btnShiftK;
    private Button btnF3;
    private Button btnF7;
    private Button btnSpace;
    private Button btnBackspace;
    private TableLayoutPanel tableLayoutPanel1;
    private Button btnTilde;
    private Button btn11;
    private Button btn00;
    private Button btnDelete;
    private Button btnAltEnter;
    private Button btnN;
    private Button btnF8;
    private Button btnC;
    private Button btn77;
    private Button btn66;
    private Button btn55;
    private Button btn44;
    private Button btn33;
    private Button btnm22;
    private Panel panel1;
    private LinkLabel linkLabel1;
    private LinkLabel linkLabel2;
  }
}
