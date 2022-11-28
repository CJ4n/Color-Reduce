namespace WinFormsApp1
{
    // PYTANIA:
    // 1. Czy orderedDIthering dla N=256 powinine byæ ciemniejszy?

    //TODO:
    // 4. Changed KTextBox to DomainUpDown
    // 5. Make alorithm not rerun if no params have changed
    public partial class Form1 : Form
    {
        private string _imagePath = "..\\..\\..\\..\\resources\\lena_color.png";
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
            _originalImage = GetBitampFromFile(_imagePath);
            UpdateControlsDimension();
            _algorithm.UpdateBitmap(_originalImage);
            Repaint();
        }

        private void UpdateControlsDimension()
        {
            this.ClientSize = new Size(2 * GetScaledMeasurement(_originalImage.Width)
                + this.splitContainer1.SplitterWidth + this.splitContainer2.SplitterWidth
                + this.algorithmGroupBox.Width, GetScaledMeasurement(_originalImage.Height));
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
            int Kr = int.Parse(this.KrTextBox.Text);
            int Kg = int.Parse(this.KgTextBox.Text);
            int Kb = int.Parse(this.KbTextBox.Text);

            Bitmap resultImage = _algorithm.ApplayColorReduce(Kr, Kg, Kb);
            Canvas.Image = GetDisplayableImage(resultImage);
            Canvas.Refresh();
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

        private void ValidatingKTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)sender;
                int k = int.Parse(tb.Text);
                if (k < 1 || k > 256)
                {
                    throw new Exception($"Value {k} in not in range <1,256>");
                }
            }
            catch (Exception execption)
            {
                e.Cancel = true;
                MessageBox.Show(execption.Message);
                return;
            }
            Repaint();

        }

        private void ValidatedKTextBox(object sender, EventArgs e)
        {
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
    }
}