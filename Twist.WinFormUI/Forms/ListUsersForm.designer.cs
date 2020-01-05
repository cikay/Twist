namespace WindowsFormsApp1.Forms
{
    partial class ListUsersForm
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
            this.lV_Users = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BarcodPin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProtectionInfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_Users
            // 
            this.lV_Users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName,
            this.BarcodPin,
            this.Pin,
            this.Level,
            this.ProtectionInfo});
            this.lV_Users.HideSelection = false;
            this.lV_Users.Location = new System.Drawing.Point(40, 40);
            this.lV_Users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lV_Users.Name = "lV_Users";
            this.lV_Users.Size = new System.Drawing.Size(526, 493);
            this.lV_Users.TabIndex = 0;
            this.lV_Users.UseCompatibleStateImageBehavior = false;
            this.lV_Users.View = System.Windows.Forms.View.Details;
            // 
            // UserName
            // 
            this.UserName.Tag = "UserName";
            this.UserName.Text = "Kullanıcı Adı";
            this.UserName.Width = 116;
            // 
            // BarcodPin
            // 
            this.BarcodPin.Tag = "BarcodPin";
            this.BarcodPin.Text = "Barkod Pin";
            this.BarcodPin.Width = 120;
            // 
            // Pin
            // 
            this.Pin.Tag = "Pin";
            this.Pin.Text = "Pin";
            this.Pin.Width = 70;
            // 
            // Level
            // 
            this.Level.Tag = "Level";
            this.Level.Text = "Yetki";
            this.Level.Width = 73;
            // 
            // ProtectionInfo
            // 
            this.ProtectionInfo.Tag = "ProtectionInfo";
            this.ProtectionInfo.Text = "Koruma Bilgisi";
            this.ProtectionInfo.Width = 119;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(635, 40);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 35);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(730, 40);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 35);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // ListUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 720);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lV_Users);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListUsersForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AccountsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_Users;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ColumnHeader BarcodPin;
        private System.Windows.Forms.ColumnHeader Pin;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader ProtectionInfo;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
    }
}