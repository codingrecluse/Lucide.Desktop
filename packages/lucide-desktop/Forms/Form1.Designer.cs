namespace Forms;

partial class Form1
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
  private void InitializeComponent()
  {
    components = new System.ComponentModel.Container();
    comboBox1 = new ComboBox();
    colorDialog1 = new ColorDialog();
    button1 = new Button();
    label1 = new Label();
    label2 = new Label();
    textBox1 = new TextBox();
    textBox2 = new TextBox();
    label3 = new Label();
    imageList1 = new ImageList(components);
    listView1 = new ListView();
    SuspendLayout();
    // 
    // comboBox1
    // 
    comboBox1.FormattingEnabled = true;
    comboBox1.Location = new Point(137, 12);
    comboBox1.Name = "comboBox1";
    comboBox1.Size = new Size(351, 23);
    comboBox1.TabIndex = 1;
    comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
    // 
    // button1
    // 
    button1.Location = new Point(12, 12);
    button1.Name = "button1";
    button1.Size = new Size(75, 23);
    button1.TabIndex = 2;
    button1.Text = "button1";
    button1.UseVisualStyleBackColor = true;
    button1.Click += button1_Click;
    // 
    // label1
    // 
    label1.AutoSize = true;
    label1.Location = new Point(93, 16);
    label1.Name = "label1";
    label1.Size = new Size(38, 15);
    label1.TabIndex = 3;
    label1.Text = "label1";
    // 
    // label2
    // 
    label2.AutoSize = true;
    label2.Location = new Point(494, 17);
    label2.Name = "label2";
    label2.Size = new Size(38, 15);
    label2.TabIndex = 4;
    label2.Text = "label2";
    // 
    // textBox1
    // 
    textBox1.Location = new Point(538, 14);
    textBox1.Name = "textBox1";
    textBox1.Size = new Size(100, 23);
    textBox1.TabIndex = 5;
    // 
    // textBox2
    // 
    textBox2.Location = new Point(688, 13);
    textBox2.Name = "textBox2";
    textBox2.Size = new Size(100, 23);
    textBox2.TabIndex = 7;
    // 
    // label3
    // 
    label3.AutoSize = true;
    label3.Location = new Point(644, 16);
    label3.Name = "label3";
    label3.Size = new Size(38, 15);
    label3.TabIndex = 6;
    label3.Text = "label3";
    // 
    // imageList1
    // 
    imageList1.ColorDepth = ColorDepth.Depth32Bit;
    imageList1.ImageSize = new Size(16, 16);
    imageList1.TransparentColor = Color.Transparent;
    // 
    // listView1
    // 
    listView1.GridLines = true;
    listView1.LargeImageList = imageList1;
    listView1.Location = new Point(12, 50);
    listView1.Name = "listView1";
    listView1.Size = new Size(776, 388);
    listView1.TabIndex = 8;
    listView1.UseCompatibleStateImageBehavior = false;
    // 
    // Form1
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(800, 450);
    Controls.Add(listView1);
    Controls.Add(textBox2);
    Controls.Add(label3);
    Controls.Add(textBox1);
    Controls.Add(label2);
    Controls.Add(label1);
    Controls.Add(button1);
    Controls.Add(comboBox1);
    Name = "Form1";
    Text = "Form1";
    Load += Form1_Load;
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion
  private ComboBox comboBox1;
  private ColorDialog colorDialog1;
  private Button button1;
  private Label label1;
  private Label label2;
  private TextBox textBox1;
  private TextBox textBox2;
  private Label label3;
  private ImageList imageList1;
  private ListView listView1;
}
