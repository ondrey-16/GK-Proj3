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
            menuStrip1 = new MenuStrip();
            addImageToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).BeginInit();
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
            splitContainer.Size = new Size(1578, 911);
            splitContainer.SplitterDistance = 944;
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
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imagePictureBox).EndInit();
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
    }
}
