namespace Twist.WinFormUI.Forms
{
    partial class ProductDetailsForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm2));
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_Cable = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cable)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // pictureBox_Cable
            // 
            this.pictureBox_Cable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Cable.BackgroundImage")));
            this.pictureBox_Cable.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Cable.Image")));
            this.pictureBox_Cable.Location = new System.Drawing.Point(67, 13);
            this.pictureBox_Cable.Name = "pictureBox_Cable";
            this.pictureBox_Cable.Size = new System.Drawing.Size(638, 403);
            this.pictureBox_Cable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Cable.TabIndex = 0;
            this.pictureBox_Cable.TabStop = false;
            this.pictureBox_Cable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Cable_Paint);
            // 
            // ProductDetailsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.pictureBox_Cable);
            this.Name = "ProductDetailsForm2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ProductDetailsForm2";
            this.Load += new System.EventHandler(this.ProductDetailsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.PictureBox pictureBox_Cable;
    }
}