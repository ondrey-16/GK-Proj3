namespace GK_Proj3
{
    public enum FilterType
    {
        Identicality,
        Blur,
        Sharpening,
        BasRelief,
        EdgeDetection,
        Custom
    }
    public partial class Form1 : Form
    {
        private Bitmap? imageBitmap;
        private Bitmap? oryginalImageBitmap;
        private Color[,]? imageColors;
        private Filter? filter;
        private FilterType filterType;
        private byte shift;
        private readonly float[,] m;
        private float? divider;
        public Form1()
        {
            InitializeComponent();
            changeMatrixEnabledState(false);
            fullImageButton.Checked = true;
            identicalityFilterButton.Checked = true;
            shift = 0;
            m = new float[3, 3];
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageBitmap = new(Image.FromFile(fileDialog.FileName));
                    oryginalImageBitmap = new(Image.FromFile(fileDialog.FileName));
                    imagePictureBox.Image = oryginalImageBitmap;
                    imageColors = new Color[oryginalImageBitmap.Width, oryginalImageBitmap.Height];
                    for (int i = 0; i < oryginalImageBitmap.Width; i++)
                    {
                        for (int j = 0; j < oryginalImageBitmap.Height; j++)
                        {
                            imageColors[i, j] = oryginalImageBitmap.GetPixel(i, j);
                        }
                    }
                }
            }
        }

        private void circleBrushRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            radiusLabel.Text = $"{circleBrushRadiusTrackBar.Value}";
        }

        private void setBitmapPixels()
        {
            if (imageColors is null)
            {
                return;
            }
            imageBitmap = new Bitmap(imageColors.GetLength(0), imageColors.GetLength(1));
            for (int i = 0; i < imageColors.GetLength(0); i++)
            {
                for (int j = 0; j < imageColors.GetLength(1); j++)
                {
                    imageBitmap.SetPixel(i, j, imageColors[i, j]);
                }
            }
            imagePictureBox.Image = imageBitmap;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filter = filterType switch
            {
                FilterType.Identicality => new IdenticalityFilter(shift, divider),
                FilterType.Blur => new BlurFilter(shift, divider),
                FilterType.Sharpening => new SharpeningFilter(shift, divider),
                FilterType.BasRelief => new BasReliefFilter(shift, divider),
                FilterType.EdgeDetection => new EdgeDetectionFilter(shift, divider),
                FilterType.Custom => new CustomFilter(shift, divider, m),
                _ => null
            };
            filter?.FilterImage(imageColors);
            setBitmapPixels();
            imagePictureBox.Invalidate();
        }

        private void changeMatrixEnabledState(bool enabled)
        {
            numericUpDown1.Enabled = enabled;
            numericUpDown2.Enabled = enabled;
            numericUpDown3.Enabled = enabled;
            numericUpDown4.Enabled = enabled;
            numericUpDown5.Enabled = enabled;
            numericUpDown6.Enabled = enabled;
            numericUpDown7.Enabled = enabled;
            numericUpDown8.Enabled = enabled;
            numericUpDown9.Enabled = enabled;
        }

        private void identicalityFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.Identicality;
            changeMatrixEnabledState(false);
        }

        private void blurFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.Blur;
            changeMatrixEnabledState(false);
        }

        private void sharpeningFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.Sharpening;
            changeMatrixEnabledState(false);
        }

        private void basReliefFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.BasRelief;
            changeMatrixEnabledState(false);
        }

        private void edgeDetectionFilterChoice_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.EdgeDetection;
            changeMatrixEnabledState(false);
        }

        private void customFilter_CheckedChanged(object sender, EventArgs e)
        {
            filterType = FilterType.Custom;
            changeMatrixEnabledState(true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m[0, 0] = (float)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            m[1, 0] = (float)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            m[2, 0] = (float)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            m[1, 0] = (float)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            m[1, 1] = (float)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            m[1, 2] = (float)numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            m[2, 0] = (float)numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            m[2, 1] = (float)numericUpDown8.Value;
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            m[2, 2] = (float)numericUpDown9.Value;
        }

        private void shiftNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            shift = (byte)shiftNumericUpDown.Value;
        }

        private void dividerNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!automaticDividerCheckBox.Checked)
            {
                divider = (float)dividerNumericUpDown.Value;
            }
        }

        private void automaticDividerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            divider = (automaticDividerCheckBox.Checked) ? null : (float)dividerNumericUpDown.Value;
            dividerNumericUpDown.Enabled = !automaticDividerCheckBox.Checked;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            imageBitmap = oryginalImageBitmap;
            imagePictureBox.Image = oryginalImageBitmap;
            if (oryginalImageBitmap is not null)
            {
                imageColors = new Color[oryginalImageBitmap.Width, oryginalImageBitmap.Height];
                for (int i = 0; i < oryginalImageBitmap.Width; i++)
                {
                    for (int j = 0; j < oryginalImageBitmap.Height; j++)
                    {
                        imageColors[i, j] = oryginalImageBitmap.GetPixel(i, j);
                    }
                }
            }
            imagePictureBox.Invalidate();
        }
    }
}
