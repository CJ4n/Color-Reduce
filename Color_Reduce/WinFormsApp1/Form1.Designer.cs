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
            this.KTextBox = new System.Windows.Forms.TextBox();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.KbTextBox = new System.Windows.Forms.TextBox();
            this.KgTextBox = new System.Windows.Forms.TextBox();
            this.KrTextBox = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.KTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.loadImageButton);
            this.splitContainer1.Panel2.Controls.Add(this.KbTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.KgTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.KrTextBox);
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
            // KTextBox
            // 
            this.KTextBox.Location = new System.Drawing.Point(164, 299);
            this.KTextBox.Name = "KTextBox";
            this.KTextBox.Size = new System.Drawing.Size(125, 27);
            this.KTextBox.TabIndex = 8;
            this.KTextBox.Text = "32";
            this.KTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingKTextBox);
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
            // KbTextBox
            // 
            this.KbTextBox.Location = new System.Drawing.Point(21, 405);
            this.KbTextBox.Name = "KbTextBox";
            this.KbTextBox.Size = new System.Drawing.Size(125, 27);
            this.KbTextBox.TabIndex = 6;
            this.KbTextBox.Text = "4";
            this.KbTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingKrgbTextBox);
            // 
            // KgTextBox
            // 
            this.KgTextBox.Location = new System.Drawing.Point(21, 352);
            this.KgTextBox.Name = "KgTextBox";
            this.KgTextBox.Size = new System.Drawing.Size(125, 27);
            this.KgTextBox.TabIndex = 5;
            this.KgTextBox.Text = "4";
            this.KgTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingKrgbTextBox);
            // 
            // KrTextBox
            // 
            this.KrTextBox.Location = new System.Drawing.Point(21, 299);
            this.KrTextBox.Name = "KrTextBox";
            this.KrTextBox.Size = new System.Drawing.Size(125, 27);
            this.KrTextBox.TabIndex = 4;
            this.KrTextBox.Text = "4";
            this.KrTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingKrgbTextBox);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
        private TextBox KbTextBox;
        private TextBox KgTextBox;
        private TextBox KrTextBox;
        private Label KbLabel;
        private Label KgLabel;
        private Label KrLabel;
        private SplitContainer splitContainer2;
        private PictureBox originalImageCanvas;
        private Button loadImageButton;
        private OpenFileDialog openFileDialog1;
        private TextBox KTextBox;
        private Button button1;
    }
}