namespace WindowsFormsApp1.Forms
{
    partial class AddUserForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_Pin = new System.Windows.Forms.TextBox();
            this.txt_BarcodPin = new System.Windows.Forms.TextBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Pin = new System.Windows.Forms.Label();
            this.lb_BarcodPin = new System.Windows.Forms.Label();
            this.lb_Level = new System.Windows.Forms.Label();
            this.lb_ProtectionInfo = new System.Windows.Forms.Label();
            this.cb_Level = new System.Windows.Forms.ComboBox();
            this.cb_ProtecInfo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(120, 147);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(81, 29);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Hesap Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(120, 19);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(100, 20);
            this.txt_userName.TabIndex = 1;
            // 
            // txt_Pin
            // 
            this.txt_Pin.Location = new System.Drawing.Point(120, 45);
            this.txt_Pin.Name = "txt_Pin";
            this.txt_Pin.Size = new System.Drawing.Size(100, 20);
            this.txt_Pin.TabIndex = 1;
            // 
            // txt_BarcodPin
            // 
            this.txt_BarcodPin.Location = new System.Drawing.Point(120, 71);
            this.txt_BarcodPin.Name = "txt_BarcodPin";
            this.txt_BarcodPin.Size = new System.Drawing.Size(100, 20);
            this.txt_BarcodPin.TabIndex = 1;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(38, 22);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(67, 13);
            this.lb_UserName.TabIndex = 2;
            this.lb_UserName.Text = "Kullanıcı Adı:";
            // 
            // lb_Pin
            // 
            this.lb_Pin.AutoSize = true;
            this.lb_Pin.Location = new System.Drawing.Point(80, 48);
            this.lb_Pin.Name = "lb_Pin";
            this.lb_Pin.Size = new System.Drawing.Size(25, 13);
            this.lb_Pin.TabIndex = 2;
            this.lb_Pin.Text = "Pin:";
            this.lb_Pin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_BarcodPin
            // 
            this.lb_BarcodPin.AutoSize = true;
            this.lb_BarcodPin.Location = new System.Drawing.Point(38, 71);
            this.lb_BarcodPin.Name = "lb_BarcodPin";
            this.lb_BarcodPin.Size = new System.Drawing.Size(62, 13);
            this.lb_BarcodPin.TabIndex = 2;
            this.lb_BarcodPin.Text = "Barkod Pin:";
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.Location = new System.Drawing.Point(66, 97);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.Size = new System.Drawing.Size(34, 13);
            this.lb_Level.TabIndex = 2;
            this.lb_Level.Text = "Yetki:";
            this.lb_Level.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lb_ProtectionInfo
            // 
            this.lb_ProtectionInfo.AutoSize = true;
            this.lb_ProtectionInfo.Location = new System.Drawing.Point(31, 123);
            this.lb_ProtectionInfo.Name = "lb_ProtectionInfo";
            this.lb_ProtectionInfo.Size = new System.Drawing.Size(74, 13);
            this.lb_ProtectionInfo.TabIndex = 2;
            this.lb_ProtectionInfo.Text = "Koruma bilgisi:";
            this.lb_ProtectionInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cb_Level
            // 
            this.cb_Level.FormattingEnabled = true;
            this.cb_Level.Location = new System.Drawing.Point(120, 97);
            this.cb_Level.Name = "cb_Level";
            this.cb_Level.Size = new System.Drawing.Size(100, 21);
            this.cb_Level.TabIndex = 3;
            // 
            // cb_ProtecInfo
            // 
            this.cb_ProtecInfo.FormattingEnabled = true;
            this.cb_ProtecInfo.Location = new System.Drawing.Point(120, 120);
            this.cb_ProtecInfo.Name = "cb_ProtecInfo";
            this.cb_ProtecInfo.Size = new System.Drawing.Size(100, 21);
            this.cb_ProtecInfo.TabIndex = 3;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 254);
            this.Controls.Add(this.cb_ProtecInfo);
            this.Controls.Add(this.cb_Level);
            this.Controls.Add(this.lb_ProtectionInfo);
            this.Controls.Add(this.lb_Level);
            this.Controls.Add(this.lb_BarcodPin);
            this.Controls.Add(this.lb_Pin);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.txt_BarcodPin);
            this.Controls.Add(this.txt_Pin);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.btn_Add);
            this.Name = "AddUserForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_Pin;
        private System.Windows.Forms.TextBox txt_BarcodPin;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Pin;
        private System.Windows.Forms.Label lb_BarcodPin;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_ProtectionInfo;
        private System.Windows.Forms.ComboBox cb_Level;
        private System.Windows.Forms.ComboBox cb_ProtecInfo;
    }
}