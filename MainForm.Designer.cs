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
      txtMessage = new TextBox();
      button1 = new Button();
      txtWindowTitle = new TextBox();
      label1 = new Label();
      label2 = new Label();
      statusStrip1 = new StatusStrip();
      statusBar = new ToolStripStatusLabel();
      label3 = new Label();
      linkLabel1 = new LinkLabel();
      label4 = new Label();
      txtParameters = new ComboBox();
      label5 = new Label();
      linkLabel2 = new LinkLabel();
      btnSaveParam = new Button();
      toolTip1 = new ToolTip(components);
      label6 = new Label();
      label7 = new Label();
      label8 = new Label();
      btnFontAppend = new Button();
      chkAutoplay = new CheckBox();
      label9 = new Label();
      bnAppendColor = new Button();
      pnlColor = new Panel();
      txtAutoplay = new TextBox();
      txtWait = new TextBox();
      cboFonts = new ComboBox();
      colorDialog1 = new ColorDialog();
      statusStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // txtMessage
      // 
      txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtMessage.Location = new Point(114, 45);
      txtMessage.Name = "txtMessage";
      txtMessage.Size = new Size(643, 27);
      txtMessage.TabIndex = 0;
      txtMessage.Text = "Hi from MilkDrop Messenger!";
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button1.Location = new Point(766, 15);
      button1.Margin = new Padding(0);
      button1.Name = "button1";
      button1.Size = new Size(91, 57);
      button1.TabIndex = 1;
      button1.Text = "Send";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // txtWindowTitle
      // 
      txtWindowTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtWindowTitle.Location = new Point(114, 12);
      txtWindowTitle.Name = "txtWindowTitle";
      txtWindowTitle.Size = new Size(521, 27);
      txtWindowTitle.TabIndex = 2;
      txtWindowTitle.Text = "MilkDrop 3";
      toolTip1.SetToolTip(txtWindowTitle, "Partitial window title of MilkDrop window");
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 15);
      label1.Name = "label1";
      label1.Size = new Size(96, 20);
      label1.TabIndex = 3;
      label1.Text = "Find Window";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(41, 48);
      label2.Name = "label2";
      label2.Size = new Size(67, 20);
      label2.TabIndex = 4;
      label2.Text = "Message";
      // 
      // statusStrip1
      // 
      statusStrip1.ImageScalingSize = new Size(20, 20);
      statusStrip1.Items.AddRange(new ToolStripItem[] { statusBar });
      statusStrip1.Location = new Point(0, 481);
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
      // label3
      // 
      label3.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label3.Location = new Point(12, 189);
      label3.Name = "label3";
      label3.Size = new Size(845, 265);
      label3.TabIndex = 6;
      label3.Text = resources.GetString("label3.Text");
      // 
      // linkLabel1
      // 
      linkLabel1.AutoSize = true;
      linkLabel1.Location = new Point(12, 454);
      linkLabel1.Name = "linkLabel1";
      linkLabel1.Size = new Size(197, 20);
      linkLabel1.TabIndex = 7;
      linkLabel1.TabStop = true;
      linkLabel1.Text = "MilkDrop Feature Discussion";
      linkLabel1.LinkClicked += linkLabel1_LinkClicked;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(26, 81);
      label4.Name = "label4";
      label4.Size = new Size(82, 20);
      label4.TabIndex = 9;
      label4.Text = "Parameters";
      toolTip1.SetToolTip(label4, "Double-click to clear saved parameters");
      label4.DoubleClick += label4_DoubleClick;
      // 
      // txtParameters
      // 
      txtParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtParameters.DropDownStyle = ComboBoxStyle.DropDownList;
      txtParameters.Location = new Point(114, 78);
      txtParameters.Name = "txtParameters";
      txtParameters.Size = new Size(643, 28);
      txtParameters.TabIndex = 8;
      // 
      // label5
      // 
      label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label5.AutoSize = true;
      label5.Location = new Point(641, 15);
      label5.Name = "label5";
      label5.Size = new Size(116, 20);
      label5.TabIndex = 10;
      label5.Text = "(partitial match)";
      // 
      // linkLabel2
      // 
      linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      linkLabel2.AutoSize = true;
      linkLabel2.Location = new Point(638, 454);
      linkLabel2.Name = "linkLabel2";
      linkLabel2.Size = new Size(218, 20);
      linkLabel2.TabIndex = 11;
      linkLabel2.TabStop = true;
      linkLabel2.Text = "MilkDrop Messenger on GitHub";
      linkLabel2.LinkClicked += linkLabel2_LinkClicked;
      // 
      // btnSaveParam
      // 
      btnSaveParam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btnSaveParam.Location = new Point(766, 77);
      btnSaveParam.Margin = new Padding(0);
      btnSaveParam.Name = "btnSaveParam";
      btnSaveParam.Size = new Size(91, 30);
      btnSaveParam.TabIndex = 12;
      btnSaveParam.Text = "Save";
      toolTip1.SetToolTip(btnSaveParam, "Save up to 10 entries, double-click \"Parameters\" label to clear");
      btnSaveParam.UseVisualStyleBackColor = true;
      btnSaveParam.Click += btnSaveParam_Click;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(39, 114);
      label6.Name = "label6";
      label6.Size = new Size(69, 20);
      label6.TabIndex = 15;
      label6.Text = "Autoplay";
      toolTip1.SetToolTip(label6, "Double-click to reload file MilkDropMessenger.txt");
      label6.DoubleClick += label6_DoubleClick;
      // 
      // label7
      // 
      label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label7.AutoSize = true;
      label7.Location = new Point(649, 115);
      label7.Name = "label7";
      label7.Size = new Size(39, 20);
      label7.TabIndex = 16;
      label7.Text = "Wait";
      toolTip1.SetToolTip(label7, "Wait time between lines in seconds");
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Location = new Point(70, 148);
      label8.Name = "label8";
      label8.Size = new Size(38, 20);
      label8.TabIndex = 19;
      label8.Text = "Font";
      toolTip1.SetToolTip(label8, "Only used if no font parameter supplied");
      // 
      // btnFontAppend
      // 
      btnFontAppend.Location = new Point(351, 144);
      btnFontAppend.Margin = new Padding(0);
      btnFontAppend.Name = "btnFontAppend";
      btnFontAppend.Size = new Size(84, 30);
      btnFontAppend.TabIndex = 20;
      btnFontAppend.Text = "Append";
      toolTip1.SetToolTip(btnFontAppend, "Append to parameters string above if no font already defined");
      btnFontAppend.UseVisualStyleBackColor = true;
      btnFontAppend.Click += btnFontAppend_Click;
      // 
      // chkAutoplay
      // 
      chkAutoplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      chkAutoplay.AutoSize = true;
      chkAutoplay.Location = new Point(767, 114);
      chkAutoplay.Name = "chkAutoplay";
      chkAutoplay.Size = new Size(91, 24);
      chkAutoplay.TabIndex = 14;
      chkAutoplay.Text = "Autoplay";
      toolTip1.SetToolTip(chkAutoplay, "Automatically send messages from file");
      chkAutoplay.UseVisualStyleBackColor = true;
      chkAutoplay.CheckedChanged += chkAutoplay_CheckedChanged;
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Location = new Point(449, 148);
      label9.Name = "label9";
      label9.Size = new Size(45, 20);
      label9.TabIndex = 21;
      label9.Text = "Color";
      toolTip1.SetToolTip(label9, "Only used if no r, g, b parameters supplied");
      // 
      // bnAppendColor
      // 
      bnAppendColor.Location = new Point(559, 144);
      bnAppendColor.Margin = new Padding(0);
      bnAppendColor.Name = "bnAppendColor";
      bnAppendColor.Size = new Size(84, 30);
      bnAppendColor.TabIndex = 23;
      bnAppendColor.Text = "Append";
      toolTip1.SetToolTip(bnAppendColor, "Append to parameters string above if no font already defined");
      bnAppendColor.UseVisualStyleBackColor = true;
      bnAppendColor.Click += btnAppendColor_Click;
      // 
      // pnlColor
      // 
      pnlColor.BorderStyle = BorderStyle.FixedSingle;
      pnlColor.Location = new Point(497, 146);
      pnlColor.Name = "pnlColor";
      pnlColor.Size = new Size(56, 27);
      pnlColor.TabIndex = 24;
      toolTip1.SetToolTip(pnlColor, "Only used if no r, g, b parameters supplied");
      pnlColor.Click += pnlColor_Click;
      // 
      // txtAutoplay
      // 
      txtAutoplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtAutoplay.Enabled = false;
      txtAutoplay.Location = new Point(114, 112);
      txtAutoplay.Name = "txtAutoplay";
      txtAutoplay.Size = new Size(529, 27);
      txtAutoplay.TabIndex = 13;
      toolTip1.SetToolTip(txtAutoplay, "Autoplay lines from file MilkDropMessenger.txt");
      // 
      // txtWait
      // 
      txtWait.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      txtWait.Location = new Point(694, 112);
      txtWait.Name = "txtWait";
      txtWait.Size = new Size(63, 27);
      txtWait.TabIndex = 17;
      txtWait.Text = "10";
      toolTip1.SetToolTip(txtWait, "Wait time between lines in seconds");
      // 
      // cboFonts
      // 
      cboFonts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
      cboFonts.AutoCompleteSource = AutoCompleteSource.ListItems;
      cboFonts.FormattingEnabled = true;
      cboFonts.Location = new Point(114, 145);
      cboFonts.Name = "cboFonts";
      cboFonts.Size = new Size(230, 28);
      cboFonts.TabIndex = 18;
      toolTip1.SetToolTip(cboFonts, "Only used if no font parameter supplied");
      // 
      // colorDialog1
      // 
      colorDialog1.AnyColor = true;
      colorDialog1.Color = Color.White;
      colorDialog1.FullOpen = true;
      colorDialog1.SolidColorOnly = true;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(869, 503);
      Controls.Add(statusStrip1);
      Controls.Add(pnlColor);
      Controls.Add(bnAppendColor);
      Controls.Add(label9);
      Controls.Add(btnFontAppend);
      Controls.Add(label8);
      Controls.Add(cboFonts);
      Controls.Add(txtWait);
      Controls.Add(label7);
      Controls.Add(label6);
      Controls.Add(chkAutoplay);
      Controls.Add(txtAutoplay);
      Controls.Add(btnSaveParam);
      Controls.Add(linkLabel2);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(txtParameters);
      Controls.Add(linkLabel1);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(txtWindowTitle);
      Controls.Add(button1);
      Controls.Add(txtMessage);
      Controls.Add(label3);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "MainForm";
      Text = "MilkDrop Messenger";
      Shown += MainForm_Shown;
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private TextBox txtMessage;
    private TextBox txtWindowTitle;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel statusBar;
    private Label label3;
    private LinkLabel linkLabel1;
    private Label label4;
    private ComboBox txtParameters;
    private Label label5;
    private LinkLabel linkLabel2;
    private Button btnSaveParam;
    private ToolTip toolTip1;
    private TextBox txtAutoplay;
    private CheckBox chkAutoplay;
    private Label label6;
    private Label label7;
    private TextBox txtWait;
    private ComboBox cboFonts;
    private Label label8;
    private Button btnFontAppend;
    private Label label9;
    private Button bnAppendColor;
    private ColorDialog colorDialog1;
    private Panel pnlColor;
  }
}
