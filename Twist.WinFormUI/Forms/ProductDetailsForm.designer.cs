namespace Twist.WinFormUI.Forms
{
    partial class ProductDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsForm));
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_Cable = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_FowardTour = new System.Windows.Forms.TextBox();
            this.txt_BackTour = new System.Windows.Forms.TextBox();
            this.txt_FowardSpeed = new System.Windows.Forms.TextBox();
            this.txt_BackSpeed = new System.Windows.Forms.TextBox();
            this.txt_YonBeklemeSuresi = new System.Windows.Forms.TextBox();
            this.txt_KabloBirakmaSuresi = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_CableDirection = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CompletedCount = new System.Windows.Forms.TextBox();
            this.txt_RemainCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.pictureBox_Cable.Size = new System.Drawing.Size(638, 180);
            this.pictureBox_Cable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Cable.TabIndex = 0;
            this.pictureBox_Cable.TabStop = false;
            this.pictureBox_Cable.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Cable_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İleri Tur:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İleri Hız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Geri Tur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Geri Hız:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yön Bekleme Süresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kablo Bırakma Süresi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Kablo Yönü:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Miktar:";
            // 
            // txt_FowardTour
            // 
            this.txt_FowardTour.Location = new System.Drawing.Point(95, 221);
            this.txt_FowardTour.Name = "txt_FowardTour";
            this.txt_FowardTour.ReadOnly = true;
            this.txt_FowardTour.Size = new System.Drawing.Size(80, 20);
            this.txt_FowardTour.TabIndex = 2;
            // 
            // txt_BackTour
            // 
            this.txt_BackTour.Location = new System.Drawing.Point(95, 255);
            this.txt_BackTour.Name = "txt_BackTour";
            this.txt_BackTour.ReadOnly = true;
            this.txt_BackTour.Size = new System.Drawing.Size(80, 20);
            this.txt_BackTour.TabIndex = 2;
            // 
            // txt_FowardSpeed
            // 
            this.txt_FowardSpeed.Location = new System.Drawing.Point(95, 283);
            this.txt_FowardSpeed.Name = "txt_FowardSpeed";
            this.txt_FowardSpeed.ReadOnly = true;
            this.txt_FowardSpeed.Size = new System.Drawing.Size(80, 20);
            this.txt_FowardSpeed.TabIndex = 2;
            // 
            // txt_BackSpeed
            // 
            this.txt_BackSpeed.Location = new System.Drawing.Point(95, 314);
            this.txt_BackSpeed.Name = "txt_BackSpeed";
            this.txt_BackSpeed.ReadOnly = true;
            this.txt_BackSpeed.Size = new System.Drawing.Size(80, 20);
            this.txt_BackSpeed.TabIndex = 2;
            // 
            // txt_YonBeklemeSuresi
            // 
            this.txt_YonBeklemeSuresi.Location = new System.Drawing.Point(360, 221);
            this.txt_YonBeklemeSuresi.Name = "txt_YonBeklemeSuresi";
            this.txt_YonBeklemeSuresi.ReadOnly = true;
            this.txt_YonBeklemeSuresi.Size = new System.Drawing.Size(80, 20);
            this.txt_YonBeklemeSuresi.TabIndex = 2;
            // 
            // txt_KabloBirakmaSuresi
            // 
            this.txt_KabloBirakmaSuresi.Location = new System.Drawing.Point(360, 251);
            this.txt_KabloBirakmaSuresi.Name = "txt_KabloBirakmaSuresi";
            this.txt_KabloBirakmaSuresi.ReadOnly = true;
            this.txt_KabloBirakmaSuresi.Size = new System.Drawing.Size(80, 20);
            this.txt_KabloBirakmaSuresi.TabIndex = 2;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(360, 279);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.ReadOnly = true;
            this.txt_Quantity.Size = new System.Drawing.Size(80, 20);
            this.txt_Quantity.TabIndex = 2;
            // 
            // txt_CableDirection
            // 
            this.txt_CableDirection.Location = new System.Drawing.Point(360, 310);
            this.txt_CableDirection.Name = "txt_CableDirection";
            this.txt_CableDirection.ReadOnly = true;
            this.txt_CableDirection.Size = new System.Drawing.Size(80, 20);
            this.txt_CableDirection.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(767, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 1;
            // 
            // txt_CompletedCount
            // 
            this.txt_CompletedCount.Location = new System.Drawing.Point(588, 248);
            this.txt_CompletedCount.Name = "txt_CompletedCount";
            this.txt_CompletedCount.ReadOnly = true;
            this.txt_CompletedCount.Size = new System.Drawing.Size(80, 20);
            this.txt_CompletedCount.TabIndex = 9;
            // 
            // txt_RemainCount
            // 
            this.txt_RemainCount.Location = new System.Drawing.Point(588, 218);
            this.txt_RemainCount.Name = "txt_RemainCount";
            this.txt_RemainCount.ReadOnly = true;
            this.txt_RemainCount.Size = new System.Drawing.Size(80, 20);
            this.txt_RemainCount.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(511, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tamamlanan:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kalan:";
            // 
            // ProductDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 514);
            this.Controls.Add(this.txt_CompletedCount);
            this.Controls.Add(this.txt_RemainCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_BackSpeed);
            this.Controls.Add(this.txt_FowardSpeed);
            this.Controls.Add(this.txt_BackTour);
            this.Controls.Add(this.txt_CableDirection);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_KabloBirakmaSuresi);
            this.Controls.Add(this.txt_YonBeklemeSuresi);
            this.Controls.Add(this.txt_FowardTour);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Cable);
            this.Name = "ProductDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ProductDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.PictureBox pictureBox_Cable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_FowardTour;
        private System.Windows.Forms.TextBox txt_BackTour;
        private System.Windows.Forms.TextBox txt_FowardSpeed;
        private System.Windows.Forms.TextBox txt_BackSpeed;
        private System.Windows.Forms.TextBox txt_YonBeklemeSuresi;
        private System.Windows.Forms.TextBox txt_KabloBirakmaSuresi;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_CableDirection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CompletedCount;
        private System.Windows.Forms.TextBox txt_RemainCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}