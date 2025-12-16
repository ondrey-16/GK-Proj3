using System.Drawing;

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
        private Color[,]? oryginalImageColors;
        private Filter? filter;
        private FilterType filterType;
        private byte shift;
        private readonly float[,] m;
        private float? divider;

        private readonly int[] redCounts;
        private readonly int[] greenCounts;
        private readonly int[] blueCounts;

        private Point? brushPoint;
        private int brushRadius;
        private bool brushPainting;
        public Form1()
        {
            InitializeComponent();
            redChart.Series[0].Points.Clear();
            greenChart.Series[0].Points.Clear();
            blueChart.Series[0].Points.Clear();
            changeMatrixEnabledState(false);
            fullImageButton.Checked = true;
            identicalityFilterButton.Checked = true;
            shift = 0;
            m = new float[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] = 1.0f;
                }
            }

            redCounts = new int[256];
            greenCounts = new int[256];
            blueCounts = new int[256];
            updateCharts();
            brushRadius = circleBrushRadiusTrackBar.Value;
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageBitmap = new(Image.FromFile(fileDialog.FileName));
                    imagePictureBox.Image = imageBitmap;
                    oryginalImageColors = new Color[imageBitmap.Width, imageBitmap.Height];
                    zeroColorCounts();
                    for (int y = 0; y < imageBitmap.Height; y++)
                    {
                        for (int x = 0; x < imageBitmap.Width; x++)
                        {
                            oryginalImageColors[x, y] = imageBitmap.GetPixel(x, y);
                            redCounts[oryginalImageColors[x, y].R]++;
                            greenCounts[oryginalImageColors[x, y].G]++;
                            blueCounts[oryginalImageColors[x, y].B]++;
                        }
                    }
                    updateCharts();
                }
            }
        }

        private void circleBrushRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            radiusLabel.Text = $"{circleBrushRadiusTrackBar.Value}";
            brushRadius = circleBrushRadiusTrackBar.Value;
        }

        private void zeroColorCounts()
        {
            for (int i = 0; i < 256; i++)
            {
                redCounts[i] = 0;
                greenCounts[i] = 0;
                blueCounts[i] = 0;
            }
        }

        private void updateCharts()
        {
            redChart.Series[0].Points.Clear();
            greenChart.Series[0].Points.Clear();
            blueChart.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                redChart.Series[0].Points.AddXY(i, redCounts[i]);
                greenChart.Series[0].Points.AddXY(i, greenCounts[i]);
                blueChart.Series[0].Points.AddXY(i, blueCounts[i]);
            }

            redChart.Invalidate();
            greenChart.Invalidate();
            blueChart.Invalidate();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (fullImageButton.Checked)
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
                filter?.FilterImage(oryginalImageColors, imageBitmap, redCounts, greenCounts, blueCounts);

                updateCharts();
                imagePictureBox.Invalidate();
            }
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
            m[0, 1] = (float)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            m[1, 1] = (float)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            m[2, 1] = (float)numericUpDown6.Value;
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            m[0, 2] = (float)numericUpDown7.Value;
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            m[1, 2] = (float)numericUpDown8.Value;
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
            zeroColorCounts();

            if (imageBitmap is not null && oryginalImageColors is not null)
            {
                for (int y = 0; y < imageBitmap.Height; y++)
                {
                    for (int x = 0; x < imageBitmap.Width; x++)
                    {
                        imageBitmap.SetPixel(x, y, oryginalImageColors[x, y]);
                        redCounts[oryginalImageColors[x, y].R]++;
                        greenCounts[oryginalImageColors[x, y].G]++;
                        blueCounts[oryginalImageColors[x, y].B]++;
                    }
                }
            }

            updateCharts();
            imagePictureBox.Invalidate();
        }

        private void imagePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            brushPainting = false;

            updateCharts();
            imagePictureBox.Invalidate();
        }

        private void imagePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            brushPoint = e.Location;
            if (brushPainting)
            {
                filter?.FilterImageWithBrush(oryginalImageColors, imageBitmap, e.Location, brushRadius, redCounts, greenCounts, blueCounts);
            }

            imagePictureBox.Invalidate();
        }

        private void imagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            brushPainting = false;
            brushPoint = null;
            imagePictureBox.Invalidate();
        }

        private void imagePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (circleBrushButton.Checked && e.Button == MouseButtons.Left)
            {
                brushPainting = true;
            }
            brushPoint = e.Location;
            if (brushPainting)
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
                filter?.FilterImageWithBrush(oryginalImageColors, imageBitmap, e.Location, brushRadius, redCounts, greenCounts, blueCounts);
            }
            imagePictureBox.Invalidate();
        }

        private void imagePictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (brushPoint is null || !circleBrushButton.Checked)
            {
                return;
            }

            using Pen p = new Pen(Color.Gray);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            e.Graphics.DrawEllipse(p, brushPoint.Value.X - brushRadius,
                                    brushPoint.Value.Y - brushRadius, brushRadius * 2, brushRadius * 2);
        }
    }
}
