namespace WinFormsApp1
{
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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.originalImageCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.KLabel = new System.Windows.Forms.Label();
            this.KNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KgNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KrNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KbNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.KbLabel = new System.Windows.Forms.Label();
            this.KgLabel = new System.Windows.Forms.Label();
            this.KrLabel = new System.Windows.Forms.Label();
            this.algorithmGroupBox = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.popularityAlgorithmRadioButton = new System.Windows.Forms.RadioButton();
            this.errorDiffusionDitheringRadioButton = new System.Windows.Forms.RadioButton();
            this.OrderedDitheringRandomRadioButton = new System.Windows.Forms.RadioButton();
            this.orderedDitheringDeterministicRadioButton = new System.Windows.Forms.RadioButton();
            this.avarageDitheringRadioButton = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImageCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KbNumericUpDown)).BeginInit();
            this.algorithmGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(379, 753);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.KLabel);
            this.splitContainer1.Panel2.Controls.Add(this.KNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.KgNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.KrNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.KbNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.loadImageButton);
            this.splitContainer1.Panel2.Controls.Add(this.KbLabel);
            this.splitContainer1.Panel2.Controls.Add(this.KgLabel);
            this.splitContainer1.Panel2.Controls.Add(this.KrLabel);
            this.splitContainer1.Panel2.Controls.Add(this.algorithmGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 753);
            this.splitContainer1.SplitterDistance = 716;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.originalImageCanvas);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Canvas);
            this.splitContainer2.Size = new System.Drawing.Size(716, 753);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.TabIndex = 1;
            // 
            // originalImageCanvas
            // 
            this.originalImageCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.originalImageCanvas.Location = new System.Drawing.Point(0, 0);
            this.originalImageCanvas.Name = "originalImageCanvas";
            this.originalImageCanvas.Size = new System.Drawing.Size(333, 753);
            this.originalImageCanvas.TabIndex = 0;
            this.originalImageCanvas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "V:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(20, 531);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(130, 56);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(24, 276);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(21, 20);
            this.KLabel.TabIndex = 13;
            this.KLabel.Text = "K:";
            // 
            // KNumericUpDown
            // 
            this.KNumericUpDown.Location = new System.Drawing.Point(24, 299);
            this.KNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.KNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KNumericUpDown.Name = "KNumericUpDown";
            this.KNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.KNumericUpDown.TabIndex = 2;
            this.KNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KNumericUpDown.ValueChanged += new System.EventHandler(this.KNumericUpDown_ValueChanged);
            // 
            // KgNumericUpDown
            // 
            this.KgNumericUpDown.Location = new System.Drawing.Point(24, 352);
            this.KgNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.KgNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KgNumericUpDown.Name = "KgNumericUpDown";
            this.KgNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.KgNumericUpDown.TabIndex = 12;
            this.KgNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KgNumericUpDown.ValueChanged += new System.EventHandler(this.KgNumericUpDown_ValueChanged);
            // 
            // KrNumericUpDown
            // 
            this.KrNumericUpDown.Location = new System.Drawing.Point(24, 299);
            this.KrNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.KrNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KrNumericUpDown.Name = "KrNumericUpDown";
            this.KrNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.KrNumericUpDown.TabIndex = 11;
            this.KrNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KrNumericUpDown.ValueChanged += new System.EventHandler(this.KrNumericUpDown_ValueChanged);
            // 
            // KbNumericUpDown
            // 
            this.KbNumericUpDown.Location = new System.Drawing.Point(24, 405);
            this.KbNumericUpDown.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.KbNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KbNumericUpDown.Name = "KbNumericUpDown";
            this.KbNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.KbNumericUpDown.TabIndex = 10;
            this.KbNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.KbNumericUpDown.ValueChanged += new System.EventHandler(this.KbNumericUpDown_ValueChanged);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(20, 234);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(174, 29);
            this.loadImageButton.TabIndex = 7;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // KbLabel
            // 
            this.KbLabel.AutoSize = true;
            this.KbLabel.Location = new System.Drawing.Point(21, 382);
            this.KbLabel.Name = "KbLabel";
            this.KbLabel.Size = new System.Drawing.Size(30, 20);
            this.KbLabel.TabIndex = 3;
            this.KbLabel.Text = "Rb:";
            // 
            // KgLabel
            // 
            this.KgLabel.AutoSize = true;
            this.KgLabel.Location = new System.Drawing.Point(20, 329);
            this.KgLabel.Name = "KgLabel";
            this.KgLabel.Size = new System.Drawing.Size(30, 20);
            this.KgLabel.TabIndex = 2;
            this.KgLabel.Text = "Kg:";
            // 
            // KrLabel
            // 
            this.KrLabel.AutoSize = true;
            this.KrLabel.Location = new System.Drawing.Point(21, 276);
            this.KrLabel.Name = "KrLabel";
            this.KrLabel.Size = new System.Drawing.Size(26, 20);
            this.KrLabel.TabIndex = 1;
            this.KrLabel.Text = "Kr:";
            // 
            // algorithmGroupBox
            // 
            this.algorithmGroupBox.Controls.Add(this.noneRadioButton);
            this.algorithmGroupBox.Controls.Add(this.popularityAlgorithmRadioButton);
            this.algorithmGroupBox.Controls.Add(this.errorDiffusionDitheringRadioButton);
            this.algorithmGroupBox.Controls.Add(this.OrderedDitheringRandomRadioButton);
            this.algorithmGroupBox.Controls.Add(this.orderedDitheringDeterministicRadioButton);
            this.algorithmGroupBox.Controls.Add(this.avarageDitheringRadioButton);
            this.algorithmGroupBox.Location = new System.Drawing.Point(2, 3);
            this.algorithmGroupBox.Name = "algorithmGroupBox";
            this.algorithmGroupBox.Size = new System.Drawing.Size(310, 225);
            this.algorithmGroupBox.TabIndex = 0;
            this.algorithmGroupBox.TabStop = false;
            this.algorithmGroupBox.Text = "Algorithm";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Checked = true;
            this.noneRadioButton.Location = new System.Drawing.Point(19, 31);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(66, 24);
            this.noneRadioButton.TabIndex = 5;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            this.noneRadioButton.CheckedChanged += new System.EventHandler(this.noneRadioButton_CheckedChanged);
            // 
            // popularityAlgorithmRadioButton
            // 
            this.popularityAlgorithmRadioButton.AutoSize = true;
            this.popularityAlgorithmRadioButton.Location = new System.Drawing.Point(19, 181);
            this.popularityAlgorithmRadioButton.Name = "popularityAlgorithmRadioButton";
            this.popularityAlgorithmRadioButton.Size = new System.Drawing.Size(167, 24);
            this.popularityAlgorithmRadioButton.TabIndex = 4;
            this.popularityAlgorithmRadioButton.Text = "Popularity Algorithm";
            this.popularityAlgorithmRadioButton.UseVisualStyleBackColor = true;
            this.popularityAlgorithmRadioButton.CheckedChanged += new System.EventHandler(this.popularityAlgorithmRadioButton_CheckedChanged);
            // 
            // errorDiffusionDitheringRadioButton
            // 
            this.errorDiffusionDitheringRadioButton.AutoSize = true;
            this.errorDiffusionDitheringRadioButton.Location = new System.Drawing.Point(19, 151);
            this.errorDiffusionDitheringRadioButton.Name = "errorDiffusionDitheringRadioButton";
            this.errorDiffusionDitheringRadioButton.Size = new System.Drawing.Size(192, 24);
            this.errorDiffusionDitheringRadioButton.TabIndex = 3;
            this.errorDiffusionDitheringRadioButton.Text = "Error Diffusion Dithering";
            this.errorDiffusionDitheringRadioButton.UseVisualStyleBackColor = true;
            this.errorDiffusionDitheringRadioButton.CheckedChanged += new System.EventHandler(this.errorDiffusionDitheringRadioButton_CheckedChanged);
            // 
            // OrderedDitheringRandomRadioButton
            // 
            this.OrderedDitheringRandomRadioButton.AutoSize = true;
            this.OrderedDitheringRandomRadioButton.Location = new System.Drawing.Point(19, 121);
            this.OrderedDitheringRandomRadioButton.Name = "OrderedDitheringRandomRadioButton";
            this.OrderedDitheringRandomRadioButton.Size = new System.Drawing.Size(211, 24);
            this.OrderedDitheringRandomRadioButton.TabIndex = 2;
            this.OrderedDitheringRandomRadioButton.Text = "Ordered Dithering Random";
            this.OrderedDitheringRandomRadioButton.UseVisualStyleBackColor = true;
            this.OrderedDitheringRandomRadioButton.CheckedChanged += new System.EventHandler(this.OrderedDitheringRandomRadioButton_CheckedChanged);
            // 
            // orderedDitheringDeterministicRadioButton
            // 
            this.orderedDitheringDeterministicRadioButton.AutoSize = true;
            this.orderedDitheringDeterministicRadioButton.Location = new System.Drawing.Point(19, 91);
            this.orderedDitheringDeterministicRadioButton.Name = "orderedDitheringDeterministicRadioButton";
            this.orderedDitheringDeterministicRadioButton.Size = new System.Drawing.Size(243, 24);
            this.orderedDitheringDeterministicRadioButton.TabIndex = 1;
            this.orderedDitheringDeterministicRadioButton.Text = "Ordered Dithering Deterministic";
            this.orderedDitheringDeterministicRadioButton.UseVisualStyleBackColor = true;
            this.orderedDitheringDeterministicRadioButton.CheckedChanged += new System.EventHandler(this.orderedDitheringDeterministicRadioButton_CheckedChanged);
            // 
            // avarageDitheringRadioButton
            // 
            this.avarageDitheringRadioButton.AutoSize = true;
            this.avarageDitheringRadioButton.Location = new System.Drawing.Point(19, 61);
            this.avarageDitheringRadioButton.Name = "avarageDitheringRadioButton";
            this.avarageDitheringRadioButton.Size = new System.Drawing.Size(151, 24);
            this.avarageDitheringRadioButton.TabIndex = 0;
            this.avarageDitheringRadioButton.Text = "Avarage Dithering";
            this.avarageDitheringRadioButton.UseVisualStyleBackColor = true;
            this.avarageDitheringRadioButton.CheckedChanged += new System.EventHandler(this.avarageDitheringRadioButton_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 753);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImageCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KgNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KrNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KbNumericUpDown)).EndInit();
            this.algorithmGroupBox.ResumeLayout(false);
            this.algorithmGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Canvas;
        private SplitContainer splitContainer1;
        private GroupBox algorithmGroupBox;
        private RadioButton popularityAlgorithmRadioButton;
        private RadioButton errorDiffusionDitheringRadioButton;
        private RadioButton OrderedDitheringRandomRadioButton;
        private RadioButton orderedDitheringDeterministicRadioButton;
        private RadioButton avarageDitheringRadioButton;
        private RadioButton noneRadioButton;
        private Label KbLabel;
        private Label KgLabel;
        private Label KrLabel;
        private SplitContainer splitContainer2;
        private PictureBox originalImageCanvas;
        private Button loadImageButton;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown KbNumericUpDown;
        private NumericUpDown KgNumericUpDown;
        private NumericUpDown KrNumericUpDown;
        private NumericUpDown KNumericUpDown;
        private Label KLabel;
        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
    }
}