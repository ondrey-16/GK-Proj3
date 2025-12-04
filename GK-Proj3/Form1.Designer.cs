namespace GK_Proj3
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
            splitContainer = new SplitContainer();
            imagePictureBox = new PictureBox();
            matrixFilterChoiceGroupBox = new GroupBox();
            automaticDividerCheckBox = new CheckBox();
            dividerNumericUpDown = new NumericUpDown();
            shiftNumericUpDown = new NumericUpDown();
            dividerLabel = new Label();
            shiftLabel = new Label();
            numericUpDown9 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            blurFilterButton = new RadioButton();
            sharpeningFilterButton = new RadioButton();
            basReliefFilterButton = new RadioButton();
            identicalityFilterButton = new RadioButton();
            edgeDetectionFilterChoice = new RadioButton();
            customFilter = new RadioButton();
            filterUsageGroupBox = new GroupBox();
            radiusLabel = new Label();
            clearButton = new Button();
            circleBrushRadiusTrackBar = new TrackBar();
            circleBrushButton = new RadioButton();
            fullImageButton = new RadioButton();
            menuStrip1 = new MenuStrip();
            addImageToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
            matrixFilterChoiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dividerNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            filterUsageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)circleBrushRadiusTrackBar).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 33);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.AutoScroll = true;
            splitContainer.Panel1.Controls.Add(imagePictureBox);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(matrixFilterChoiceGroupBox);
            splitContainer.Panel2.Controls.Add(filterUsageGroupBox);
            splitContainer.Size = new Size(1578, 911);
            splitContainer.SplitterDistance = 900;
            splitContainer.TabIndex = 0;
            // 
            // imagePictureBox
            // 
            imagePictureBox.Location = new Point(-13, -30);
            imagePictureBox.Name = "imagePictureBox";
            imagePictureBox.Size = new Size(944, 944);
            imagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            imagePictureBox.TabIndex = 1;
            imagePictureBox.TabStop = false;
            // 
            // matrixFilterChoiceGroupBox
            // 
            matrixFilterChoiceGroupBox.Controls.Add(automaticDividerCheckBox);
            matrixFilterChoiceGroupBox.Controls.Add(dividerNumericUpDown);
            matrixFilterChoiceGroupBox.Controls.Add(shiftNumericUpDown);
            matrixFilterChoiceGroupBox.Controls.Add(dividerLabel);
            matrixFilterChoiceGroupBox.Controls.Add(shiftLabel);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown9);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown8);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown7);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown6);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown5);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown4);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown3);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown2);
            matrixFilterChoiceGroupBox.Controls.Add(numericUpDown1);
            matrixFilterChoiceGroupBox.Controls.Add(blurFilterButton);
            matrixFilterChoiceGroupBox.Controls.Add(sharpeningFilterButton);
            matrixFilterChoiceGroupBox.Controls.Add(basReliefFilterButton);
            matrixFilterChoiceGroupBox.Controls.Add(identicalityFilterButton);
            matrixFilterChoiceGroupBox.Controls.Add(edgeDetectionFilterChoice);
            matrixFilterChoiceGroupBox.Controls.Add(customFilter);
            matrixFilterChoiceGroupBox.Location = new Point(332, 213);
            matrixFilterChoiceGroupBox.Name = "matrixFilterChoiceGroupBox";
            matrixFilterChoiceGroupBox.Size = new Size(342, 537);
            matrixFilterChoiceGroupBox.TabIndex = 1;
            matrixFilterChoiceGroupBox.TabStop = false;
            matrixFilterChoiceGroupBox.Text = "Matrix filter choice";
            // 
            // automaticDividerCheckBox
            // 
            automaticDividerCheckBox.AutoSize = true;
            automaticDividerCheckBox.Location = new Point(16, 489);
            automaticDividerCheckBox.Name = "automaticDividerCheckBox";
            automaticDividerCheckBox.Size = new Size(271, 29);
            automaticDividerCheckBox.TabIndex = 20;
            automaticDividerCheckBox.Text = "Automatic divider computing";
            automaticDividerCheckBox.UseVisualStyleBackColor = true;
            // 
            // dividerNumericUpDown
            // 
            dividerNumericUpDown.DecimalPlaces = 7;
            dividerNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            dividerNumericUpDown.Location = new Point(123, 441);
            dividerNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            dividerNumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            dividerNumericUpDown.Name = "dividerNumericUpDown";
            dividerNumericUpDown.Size = new Size(192, 31);
            dividerNumericUpDown.TabIndex = 19;
            dividerNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // shiftNumericUpDown
            // 
            shiftNumericUpDown.Location = new Point(123, 396);
            shiftNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            shiftNumericUpDown.Name = "shiftNumericUpDown";
            shiftNumericUpDown.Size = new Size(192, 31);
            shiftNumericUpDown.TabIndex = 18;
            // 
            // dividerLabel
            // 
            dividerLabel.AutoSize = true;
            dividerLabel.Location = new Point(16, 447);
            dividerLabel.Name = "dividerLabel";
            dividerLabel.Size = new Size(68, 25);
            dividerLabel.TabIndex = 17;
            dividerLabel.Text = "Divider";
            // 
            // shiftLabel
            // 
            shiftLabel.AutoSize = true;
            shiftLabel.Location = new Point(16, 398);
            shiftLabel.Name = "shiftLabel";
            shiftLabel.Size = new Size(48, 25);
            shiftLabel.TabIndex = 16;
            shiftLabel.Text = "Shift";
            // 
            // numericUpDown9
            // 
            numericUpDown9.DecimalPlaces = 3;
            numericUpDown9.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown9.Location = new Point(231, 352);
            numericUpDown9.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown9.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(84, 31);
            numericUpDown9.TabIndex = 15;
            numericUpDown9.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown8
            // 
            numericUpDown8.DecimalPlaces = 3;
            numericUpDown8.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown8.Location = new Point(123, 352);
            numericUpDown8.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown8.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(84, 31);
            numericUpDown8.TabIndex = 14;
            numericUpDown8.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown7
            // 
            numericUpDown7.DecimalPlaces = 3;
            numericUpDown7.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown7.Location = new Point(16, 352);
            numericUpDown7.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown7.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(84, 31);
            numericUpDown7.TabIndex = 13;
            numericUpDown7.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 3;
            numericUpDown6.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown6.Location = new Point(231, 302);
            numericUpDown6.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown6.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(84, 31);
            numericUpDown6.TabIndex = 12;
            numericUpDown6.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 3;
            numericUpDown5.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown5.Location = new Point(123, 302);
            numericUpDown5.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(84, 31);
            numericUpDown5.TabIndex = 11;
            numericUpDown5.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 3;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown4.Location = new Point(16, 302);
            numericUpDown4.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(84, 31);
            numericUpDown4.TabIndex = 10;
            numericUpDown4.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 3;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown3.Location = new Point(231, 255);
            numericUpDown3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(84, 31);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 3;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown2.Location = new Point(123, 255);
            numericUpDown2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(84, 31);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 3;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 196608 });
            numericUpDown1.Location = new Point(16, 255);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 31);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // blurFilterButton
            // 
            blurFilterButton.AutoSize = true;
            blurFilterButton.Location = new Point(16, 65);
            blurFilterButton.Name = "blurFilterButton";
            blurFilterButton.Size = new Size(67, 29);
            blurFilterButton.TabIndex = 6;
            blurFilterButton.TabStop = true;
            blurFilterButton.Text = "Blur";
            blurFilterButton.UseVisualStyleBackColor = true;
            // 
            // sharpeningFilterButton
            // 
            sharpeningFilterButton.AutoSize = true;
            sharpeningFilterButton.Location = new Point(16, 100);
            sharpeningFilterButton.Name = "sharpeningFilterButton";
            sharpeningFilterButton.Size = new Size(127, 29);
            sharpeningFilterButton.TabIndex = 5;
            sharpeningFilterButton.TabStop = true;
            sharpeningFilterButton.Text = "Sharpening";
            sharpeningFilterButton.UseVisualStyleBackColor = true;
            // 
            // basReliefFilterButton
            // 
            basReliefFilterButton.AutoSize = true;
            basReliefFilterButton.Location = new Point(16, 135);
            basReliefFilterButton.Name = "basReliefFilterButton";
            basReliefFilterButton.Size = new Size(109, 29);
            basReliefFilterButton.TabIndex = 4;
            basReliefFilterButton.TabStop = true;
            basReliefFilterButton.Text = "Bas-relief";
            basReliefFilterButton.UseVisualStyleBackColor = true;
            // 
            // identicalityFilterButton
            // 
            identicalityFilterButton.AutoSize = true;
            identicalityFilterButton.Location = new Point(16, 30);
            identicalityFilterButton.Name = "identicalityFilterButton";
            identicalityFilterButton.Size = new Size(122, 29);
            identicalityFilterButton.TabIndex = 3;
            identicalityFilterButton.TabStop = true;
            identicalityFilterButton.Text = "Identicality";
            identicalityFilterButton.UseVisualStyleBackColor = true;
            // 
            // edgeDetectionFilterChoice
            // 
            edgeDetectionFilterChoice.AutoSize = true;
            edgeDetectionFilterChoice.Location = new Point(16, 170);
            edgeDetectionFilterChoice.Name = "edgeDetectionFilterChoice";
            edgeDetectionFilterChoice.Size = new Size(158, 29);
            edgeDetectionFilterChoice.TabIndex = 2;
            edgeDetectionFilterChoice.TabStop = true;
            edgeDetectionFilterChoice.Text = "Edge Detection";
            edgeDetectionFilterChoice.UseVisualStyleBackColor = true;
            // 
            // customFilter
            // 
            customFilter.AutoSize = true;
            customFilter.Location = new Point(16, 205);
            customFilter.Name = "customFilter";
            customFilter.Size = new Size(99, 29);
            customFilter.TabIndex = 1;
            customFilter.TabStop = true;
            customFilter.Text = "Custom";
            customFilter.UseVisualStyleBackColor = true;
            // 
            // filterUsageGroupBox
            // 
            filterUsageGroupBox.Controls.Add(radiusLabel);
            filterUsageGroupBox.Controls.Add(clearButton);
            filterUsageGroupBox.Controls.Add(circleBrushRadiusTrackBar);
            filterUsageGroupBox.Controls.Add(circleBrushButton);
            filterUsageGroupBox.Controls.Add(fullImageButton);
            filterUsageGroupBox.Location = new Point(332, 3);
            filterUsageGroupBox.Name = "filterUsageGroupBox";
            filterUsageGroupBox.Size = new Size(342, 204);
            filterUsageGroupBox.TabIndex = 0;
            filterUsageGroupBox.TabStop = false;
            filterUsageGroupBox.Text = "Filter usage area";
            // 
            // radiusLabel
            // 
            radiusLabel.AutoSize = true;
            radiusLabel.Location = new Point(283, 110);
            radiusLabel.Name = "radiusLabel";
            radiusLabel.Size = new Size(32, 25);
            radiusLabel.TabIndex = 1;
            radiusLabel.Text = "50";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(200, 154);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(77, 34);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // circleBrushRadiusTrackBar
            // 
            circleBrushRadiusTrackBar.Location = new Point(16, 100);
            circleBrushRadiusTrackBar.Maximum = 500;
            circleBrushRadiusTrackBar.Minimum = 10;
            circleBrushRadiusTrackBar.Name = "circleBrushRadiusTrackBar";
            circleBrushRadiusTrackBar.Size = new Size(261, 69);
            circleBrushRadiusTrackBar.TabIndex = 2;
            circleBrushRadiusTrackBar.Value = 50;
            circleBrushRadiusTrackBar.Scroll += circleBrushRadiusTrackBar_Scroll;
            // 
            // circleBrushButton
            // 
            circleBrushButton.AutoSize = true;
            circleBrushButton.Location = new Point(16, 65);
            circleBrushButton.Name = "circleBrushButton";
            circleBrushButton.Size = new Size(129, 29);
            circleBrushButton.TabIndex = 1;
            circleBrushButton.TabStop = true;
            circleBrushButton.Text = "Circle brush";
            circleBrushButton.UseVisualStyleBackColor = true;
            // 
            // fullImageButton
            // 
            fullImageButton.AutoSize = true;
            fullImageButton.Location = new Point(16, 30);
            fullImageButton.Name = "fullImageButton";
            fullImageButton.Size = new Size(118, 29);
            fullImageButton.TabIndex = 0;
            fullImageButton.TabStop = true;
            fullImageButton.Text = "Full image";
            fullImageButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addImageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1578, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addImageToolStripMenuItem
            // 
            addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            addImageToolStripMenuItem.Size = new Size(198, 29);
            addImageToolStripMenuItem.Text = "Add image to edition";
            addImageToolStripMenuItem.Click += addImageToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 944);
            Controls.Add(splitContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "GK-Proj3";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
            matrixFilterChoiceGroupBox.ResumeLayout(false);
            matrixFilterChoiceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dividerNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)shiftNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            filterUsageGroupBox.ResumeLayout(false);
            filterUsageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)circleBrushRadiusTrackBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private PictureBox imagePictureBox;
        private GroupBox filterUsageGroupBox;
        private TrackBar circleBrushRadiusTrackBar;
        private RadioButton circleBrushButton;
        private RadioButton fullImageButton;
        private GroupBox matrixFilterChoiceGroupBox;
        private RadioButton blurFilterButton;
        private RadioButton sharpeningFilterButton;
        private RadioButton basReliefFilterButton;
        private RadioButton identicalityFilterButton;
        private RadioButton edgeDetectionFilterChoice;
        private RadioButton customFilter;
        private Label radiusLabel;
        private Button clearButton;
        private NumericUpDown numericUpDown9;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label dividerLabel;
        private Label shiftLabel;
        private CheckBox automaticDividerCheckBox;
        private NumericUpDown dividerNumericUpDown;
        private NumericUpDown shiftNumericUpDown;
    }
}
