namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string _imagePath = "..\\..\\..\\..\\resources\\web_DenmanRossninestepvalue.jpg";
        private Bitmap _originalImage;
        private Algorithm _algorithm;
        private float _imageScale = 1.5f;
        public Form1()
        {
            InitializeComponent();
            _originalImage = GetBitampFromFile(_imagePath);
            _algorithm = new None(_originalImage);
            UpdateImageFromCurrentImagePath();
        }

        private void UpdateImageFromCurrentImagePath()
        {
            _originalImage?.Dispose();
            _originalImage = GetBitampFromFile(_imagePath);
            UpdateControlsDimension();
            _algorithm.UpdateBitmap(_originalImage);
            Repaint();
        }

        private void UpdateImageFromGenertedBitmap()
        {
            _originalImage?.Dispose();
            _originalImage = Class1.DrawStrips(this.trackBar1.Value/100.0,16);
            UpdateControlsDimension();
            _algorithm.UpdateBitmap(_originalImage);
            Repaint();
        }

        private void UpdateControlsDimension()
        {
            this.ClientSize = new Size(2 * GetScaledMeasurement(_originalImage.Width)
                + this.splitContainer1.SplitterWidth + this.splitContainer2.SplitterWidth
                + this.algorithmGroupBox.Width, Math.Max(550, GetScaledMeasurement(_originalImage.Height)));
            this.splitContainer2.SplitterDistance = splitContainer2.Width / 2;
            this.splitContainer1.SplitterDistance = this.Width - this.algorithmGroupBox.Width;
            this.originalImageCanvas.Image = GetDisplayableImage(_originalImage);
        }
        private int GetScaledMeasurement(int measurement)
        {
            return (int)(_imageScale * measurement);
        }

        private Bitmap GetBitampFromFile(string path)
        {
            var cwd = Directory.GetCurrentDirectory();
            Bitmap bitmap = new Bitmap(path);
            Rectangle cloneRect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            Bitmap bmp = bitmap.Clone(cloneRect, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            bitmap.Dispose();
            return bmp;
        }

        private void Repaint()
        {
            int Kr = ((int)this.KrNumericUpDown.Value);
            int Kg = ((int)this.KgNumericUpDown.Value);
            int Kb = ((int)this.KbNumericUpDown.Value);
            int K = ((int)this.KNumericUpDown.Value);
            if (_algorithm is PopulatiryAlgorithm)
            {
                Kr = K;
            }
            UpdateUI();
            Bitmap resultImage = _algorithm.ApplayColorReduce(Kr, Kg, Kb);
            if (Canvas.Image != null)
                Canvas.Image?.Dispose();
            Canvas.Image = GetDisplayableImage(resultImage);
            Canvas.Refresh();
        }

        private void UpdateUI()
        {
            if (_algorithm is None)
            {
                this.KgLabel.Visible = false;
                this.KrLabel.Visible = false;
                this.KbLabel.Visible = false;

                this.KrNumericUpDown.Visible = false;
                this.KgNumericUpDown.Visible = false;
                this.KbNumericUpDown.Visible = false;

                this.KNumericUpDown.Visible = false;
                this.KLabel.Visible = false;


            }
            else if (_algorithm is PopulatiryAlgorithm)
            {
                this.KgLabel.Visible = false;
                this.KrLabel.Visible = false;
                this.KbLabel.Visible = false;

                this.KrNumericUpDown.Visible = false;
                this.KgNumericUpDown.Visible = false;
                this.KbNumericUpDown.Visible = false;

                this.KNumericUpDown.Visible = true;
                this.KLabel.Visible = true;

            }
            else
            {
                this.KgLabel.Visible = true;
                this.KrLabel.Visible = true;
                this.KbLabel.Visible = true;

                this.KrNumericUpDown.Visible = true;
                this.KgNumericUpDown.Visible = true;
                this.KbNumericUpDown.Visible = true;

                this.KNumericUpDown.Visible = false;
                this.KLabel.Visible = false;

            }
        }

        private Bitmap GetDisplayableImage(Bitmap image)
        {
            return new Bitmap(image, new Size((int)(image.Width * _imageScale), (int)(image.Height * _imageScale)));
        }

        private void noneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.noneRadioButton.Checked)
            {
                _algorithm = new None(_originalImage);
                Repaint();
            }
        }

        private void avarageDitheringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.avarageDitheringRadioButton.Checked)
            {
                _algorithm = new AvarageDitheringAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void orderedDitheringDeterministicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.orderedDitheringDeterministicRadioButton.Checked)
            {
                _algorithm = new OrderedDitheringDeterministicAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void OrderedDitheringRandomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OrderedDitheringRandomRadioButton.Checked)
            {
                _algorithm = new OrderedDitheringRandomAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void errorDiffusionDitheringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.errorDiffusionDitheringRadioButton.Checked)
            {
                _algorithm = new ErrorDiffusionDitheringAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void popularityAlgorithmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.popularityAlgorithmRadioButton.Checked)
            {
                _algorithm = new PopulatiryAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            var status = this.openFileDialog1.ShowDialog();
            if (status != DialogResult.OK)
            {
                return;
            }
            _imagePath = this.openFileDialog1.FileName;
            UpdateImageFromCurrentImagePath();
        }

        private void KrNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repaint();
        }

        private void KgNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repaint();
        }

        private void KbNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repaint();
        }

        private void KNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Repaint();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateImageFromGenertedBitmap();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateImageFromGenertedBitmap();
        }
    }
}