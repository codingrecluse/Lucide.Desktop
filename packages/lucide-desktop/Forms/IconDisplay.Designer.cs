namespace Forms;

partial class IconDisplay
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
    colorDialog1 = new ColorDialog();
    workingImageList = new ImageList(components);
    iconListView = new ListView();
    categoryCombo = new ComboBox();
    colorPickerButton = new Button();
    iconHeightText = new TextBox();
    label1 = new Label();
    label2 = new Label();
    SuspendLayout();
    // 
    // workingImageList
    // 
    workingImageList.ColorDepth = ColorDepth.Depth32Bit;
    workingImageList.ImageSize = new Size(16, 16);
    workingImageList.TransparentColor = Color.Transparent;
    // 
    // iconListView
    // 
    iconListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    iconListView.GridLines = true;
    iconListView.LargeImageList = workingImageList;
    iconListView.Location = new Point(12, 65);
    iconListView.Name = "iconListView";
    iconListView.Size = new Size(738, 492);
    iconListView.TabIndex = 8;
    iconListView.UseCompatibleStateImageBehavior = false;
    // 
    // categoryCombo
    // 
    categoryCombo.Anchor = AnchorStyles.Top;
    categoryCombo.FormattingEnabled = true;
    categoryCombo.Location = new Point(160, 12);
    categoryCombo.Name = "categoryCombo";
    categoryCombo.Size = new Size(484, 23);
    categoryCombo.TabIndex = 11;
    categoryCombo.SelectedValueChanged += CategoryCombo_SelectionChangeCommitted;
    // 
    // colorPickerButton
    // 
    colorPickerButton.Anchor = AnchorStyles.Top;
    colorPickerButton.Location = new Point(12, 12);
    colorPickerButton.Name = "colorPickerButton";
    colorPickerButton.Size = new Size(81, 23);
    colorPickerButton.TabIndex = 12;
    colorPickerButton.UseVisualStyleBackColor = true;
    colorPickerButton.Click += ColorPickerButton_Click;
    // 
    // iconHeightText
    // 
    iconHeightText.AcceptsReturn = true;
    iconHeightText.Anchor = AnchorStyles.Top;
    iconHeightText.Location = new Point(694, 13);
    iconHeightText.Name = "iconHeightText";
    iconHeightText.Size = new Size(56, 23);
    iconHeightText.TabIndex = 15;
    iconHeightText.TextChanged += IconHeightText_TextChanged;
    // 
    // label1
    // 
    label1.Anchor = AnchorStyles.Top;
    label1.AutoSize = true;
    label1.Location = new Point(99, 16);
    label1.Name = "label1";
    label1.Size = new Size(55, 15);
    label1.TabIndex = 13;
    label1.Text = "Category";
    // 
    // label2
    // 
    label2.Anchor = AnchorStyles.Top;
    label2.AutoSize = true;
    label2.Location = new Point(650, 16);
    label2.Name = "label2";
    label2.Size = new Size(27, 15);
    label2.TabIndex = 14;
    label2.Text = "Size";
    // 
    // IconDisplay
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(762, 569);
    Controls.Add(categoryCombo);
    Controls.Add(colorPickerButton);
    Controls.Add(iconHeightText);
    Controls.Add(label1);
    Controls.Add(label2);
    Controls.Add(iconListView);
    Name = "IconDisplay";
    Text = "IconDisplay";
    Load += IconDisplay_Load;
    ResumeLayout(false);
    PerformLayout();
  }

  #endregion
  private ColorDialog colorDialog1;
  private ImageList workingImageList;
  private ListView iconListView;
  private ComboBox categoryCombo;
  private Button colorPickerButton;
  private TextBox iconHeightText;
  private Label label1;
  private Label label2;
}
