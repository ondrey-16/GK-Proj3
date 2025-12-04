namespace GK_Proj3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fullImageButton.Checked = true;
            identicalityFilterButton.Checked = true;
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePictureBox.Image = Image.FromFile(fileDialog.FileName);
                }
            }
        }

        private void circleBrushRadiusTrackBar_Scroll(object sender, EventArgs e)
        {
            radiusLabel.Text = $"{circleBrushRadiusTrackBar.Value}";
        }
    }
}
