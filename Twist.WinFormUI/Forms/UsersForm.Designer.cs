namespace Twist.WinFormUI.Forms
{
    partial class UsersForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarcodPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProtectInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.BarcodPin,
            this.Pin,
            this.Level,
            this.ProtectInfo});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(65, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 474);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Tag = "UserName";
            this.UserName.Text = "Kullanıcı Adı";
            this.UserName.Width = 150;
            // 
            // BarcodPin
            // 
            this.BarcodPin.Tag = "BarcodPin";
            this.BarcodPin.Text = "Barkod Pin";
            this.BarcodPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodPin.Width = 150;
            // 
            // Pin
            // 
            this.Pin.Tag = "Pin";
            this.Pin.Text = "Pin";
            this.Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pin.Width = 100;
            // 
            // Level
            // 
            this.Level.Tag = "Level";
            this.Level.Text = "Yetki";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Level.Width = 100;
            // 
            // ProtectInfo
            // 
            this.ProtectInfo.Tag = "ProtectInfo";
            this.ProtectInfo.Text = "Koruma Bilgisi";
            this.ProtectInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProtectInfo.Width = 100;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 596);
            this.Controls.Add(this.listView1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BarcodPin;
        private System.Windows.Forms.ColumnHeader Pin;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader ProtectInfo;
        private System.Windows.Forms.ColumnHeader UserName;
    }
}