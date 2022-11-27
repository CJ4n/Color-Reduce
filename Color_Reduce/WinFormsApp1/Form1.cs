namespace WinFormsApp1
{
    // PYTANIA:
    // 1. Czy orderedDIthering dla N=256 powinine byæ ciemniejszy?

    //TODO:
    // 1. Add Error Diffusion Algorithm
    // 2. Add Popularity Algorithm
    // 3. Add option to loan new image
    // 4. Maybe changed KTextBox to something more intuitive trackbar/psuedo combobox
    // 5. Show images side by side, orignal and reduced

    public partial class Form1 : Form
    {
        private string imagePath = "..\\..\\..\\..\\resources\\lena_grayscale.bmp";
        private Bitmap _originalImage;
        private Algorithm _alorithm;
        public Form1()
        {
            InitializeComponent();

            _originalImage = GetBitampFromFile(imagePath);
            _alorithm = new None(_originalImage);
            Repaint();
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

            Bitmap resultImage = _alorithm.ApplayColorReduce(Kr, Kg, Kb);
            Canvas.Image = resultImage;
            Canvas.Refresh();
        }

        private void noneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.noneRadioButton.Checked)
            {
                _alorithm = new None(_originalImage);
                Repaint();
            }
        }

        private void avarageDitheringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.avarageDitheringRadioButton.Checked)
            {
                _alorithm = new AvarageDitheringAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void orderedDitheringDeterministicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.orderedDitheringDeterministicRadioButton.Checked)
            {
                _alorithm = new OrderedDitheringDeterministicAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void OrderedDitheringRandomRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OrderedDitheringRandomRadioButton.Checked)
            {
                _alorithm = new OrderedDitheringRandomAlgorithm(_originalImage);
                Repaint();
            }
        }

        private void errorDiffusionDitheringRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.errorDiffusionDitheringRadioButton.Checked)
            {

                Repaint();
            }
        }

        private void popularityAlgorithmRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.popularityAlgorithmRadioButton.Checked)
            {

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
        }

        private void ValidatedKTextBox(object sender, EventArgs e)
        {
            Repaint();
        }
    }
}