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
      txtParameters = new TextBox();
      label5 = new Label();
      linkLabel2 = new LinkLabel();
      statusStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // txtMessage
      // 
      txtMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtMessage.Location = new Point(114, 45);
      txtMessage.Name = "txtMessage";
      txtMessage.Size = new Size(680, 27);
      txtMessage.TabIndex = 0;
      txtMessage.Text = "Test";
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button1.Location = new Point(803, 15);
      button1.Margin = new Padding(0);
      button1.Name = "button1";
      button1.Size = new Size(91, 91);
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
      txtWindowTitle.Size = new Size(558, 27);
      txtWindowTitle.TabIndex = 2;
      txtWindowTitle.Text = "MilkDrop 3";
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
      label2.Location = new Point(41, 49);
      label2.Name = "label2";
      label2.Size = new Size(67, 20);
      label2.TabIndex = 4;
      label2.Text = "Message";
      // 
      // statusStrip1
      // 
      statusStrip1.ImageScalingSize = new Size(20, 20);
      statusStrip1.Items.AddRange(new ToolStripItem[] { statusBar });
      statusStrip1.Location = new Point(0, 418);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(906, 22);
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
      label3.Location = new Point(12, 121);
      label3.Name = "label3";
      label3.Size = new Size(885, 261);
      label3.TabIndex = 6;
      label3.Text = resources.GetString("label3.Text");
      // 
      // linkLabel1
      // 
      linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      linkLabel1.AutoSize = true;
      linkLabel1.Location = new Point(12, 391);
      linkLabel1.Name = "linkLabel1";
      linkLabel1.Size = new Size(231, 20);
      linkLabel1.TabIndex = 7;
      linkLabel1.TabStop = true;
      linkLabel1.Text = "MilkDrop Feature Documentation";
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
      // 
      // txtParameters
      // 
      txtParameters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txtParameters.Location = new Point(114, 78);
      txtParameters.Name = "txtParameters";
      txtParameters.Size = new Size(680, 27);
      txtParameters.TabIndex = 8;
      txtParameters.Text = "font=Consolas|size=32|time=3.5|x=0.5|y=0.5|bold=1|r=255|randg=100|growth=2.0";
      // 
      // label5
      // 
      label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label5.AutoSize = true;
      label5.Location = new Point(678, 15);
      label5.Name = "label5";
      label5.Size = new Size(116, 20);
      label5.TabIndex = 10;
      label5.Text = "(partitial match)";
      // 
      // linkLabel2
      // 
      linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      linkLabel2.AutoSize = true;
      linkLabel2.Location = new Point(675, 391);
      linkLabel2.Name = "linkLabel2";
      linkLabel2.Size = new Size(219, 20);
      linkLabel2.TabIndex = 11;
      linkLabel2.TabStop = true;
      linkLabel2.Text = "MilkDrop Messenger on GitHob";
      linkLabel2.LinkClicked += linkLabel2_LinkClicked;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(906, 440);
      Controls.Add(linkLabel2);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(txtParameters);
      Controls.Add(linkLabel1);
      Controls.Add(label3);
      Controls.Add(statusStrip1);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(txtWindowTitle);
      Controls.Add(button1);
      Controls.Add(txtMessage);
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
    private TextBox txtParameters;
    private Label label5;
    private LinkLabel linkLabel2;
  }
}
