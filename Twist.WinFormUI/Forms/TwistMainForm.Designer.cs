namespace Twist.WinFormUI.Forms
{
    partial class TwistMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwistMainForm));
            this.Panel_TopMenu = new System.Windows.Forms.Panel();
            this.combo_Languages = new System.Windows.Forms.ComboBox();
            this.label_ConnectionStatus = new System.Windows.Forms.Label();
            this.label_AccessSystem = new System.Windows.Forms.Label();
            this.label_DataRequest = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_DisConnect = new System.Windows.Forms.Button();
            this.pictureB_MiniBtn = new System.Windows.Forms.PictureBox();
            this.pictureB_FullScreenBtn = new System.Windows.Forms.PictureBox();
            this.pictureB_XBtn = new System.Windows.Forms.PictureBox();
            this.Panel_LeftMenu = new System.Windows.Forms.Panel();
            this.pictureBox_EksonLogo = new System.Windows.Forms.PictureBox();
            this.btn_Users = new System.Windows.Forms.Button();
            this.btn_Cables = new System.Windows.Forms.Button();
            this.btn_Products = new System.Windows.Forms.Button();
            this.Panel_TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_MiniBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_FullScreenBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_XBtn)).BeginInit();
            this.Panel_LeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EksonLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_TopMenu
            // 
            this.Panel_TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Panel_TopMenu.Controls.Add(this.combo_Languages);
            this.Panel_TopMenu.Controls.Add(this.label_ConnectionStatus);
            this.Panel_TopMenu.Controls.Add(this.label_AccessSystem);
            this.Panel_TopMenu.Controls.Add(this.label_DataRequest);
            this.Panel_TopMenu.Controls.Add(this.btn_Connect);
            this.Panel_TopMenu.Controls.Add(this.btn_DisConnect);
            this.Panel_TopMenu.Controls.Add(this.pictureB_MiniBtn);
            this.Panel_TopMenu.Controls.Add(this.pictureB_FullScreenBtn);
            this.Panel_TopMenu.Controls.Add(this.pictureB_XBtn);
            this.Panel_TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_TopMenu.Location = new System.Drawing.Point(0, 0);
            this.Panel_TopMenu.Name = "Panel_TopMenu";
            this.Panel_TopMenu.Size = new System.Drawing.Size(807, 60);
            this.Panel_TopMenu.TabIndex = 0;
            // 
            // combo_Languages
            // 
            this.combo_Languages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_Languages.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Languages.FormattingEnabled = true;
            this.combo_Languages.Location = new System.Drawing.Point(665, 30);
            this.combo_Languages.Name = "combo_Languages";
            this.combo_Languages.Size = new System.Drawing.Size(131, 23);
            this.combo_Languages.TabIndex = 5;
            this.combo_Languages.SelectedIndexChanged += new System.EventHandler(this.combo_Languages_SelectedIndexChanged);
            // 
            // label_ConnectionStatus
            // 
            this.label_ConnectionStatus.AutoSize = true;
            this.label_ConnectionStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ConnectionStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ConnectionStatus.ForeColor = System.Drawing.Color.White;
            this.label_ConnectionStatus.Location = new System.Drawing.Point(210, 25);
            this.label_ConnectionStatus.Name = "label_ConnectionStatus";
            this.label_ConnectionStatus.Size = new System.Drawing.Size(96, 15);
            this.label_ConnectionStatus.TabIndex = 4;
            this.label_ConnectionStatus.Text = "Bağlantı Durumu";
            // 
            // label_AccessSystem
            // 
            this.label_AccessSystem.AutoSize = true;
            this.label_AccessSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_AccessSystem.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_AccessSystem.ForeColor = System.Drawing.Color.White;
            this.label_AccessSystem.Location = new System.Drawing.Point(331, 25);
            this.label_AccessSystem.Name = "label_AccessSystem";
            this.label_AccessSystem.Size = new System.Drawing.Size(76, 15);
            this.label_AccessSystem.TabIndex = 4;
            this.label_AccessSystem.Text = "Sistem Erişimi";
            // 
            // label_DataRequest
            // 
            this.label_DataRequest.AutoSize = true;
            this.label_DataRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_DataRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_DataRequest.ForeColor = System.Drawing.Color.White;
            this.label_DataRequest.Location = new System.Drawing.Point(465, 25);
            this.label_DataRequest.Name = "label_DataRequest";
            this.label_DataRequest.Size = new System.Drawing.Size(64, 15);
            this.label_DataRequest.TabIndex = 4;
            this.label_DataRequest.Text = "Veri Talebi";
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(192)))));
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(110, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(87, 39);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Bağlan";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_DisConnect
            // 
            this.btn_DisConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_DisConnect.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_DisConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisConnect.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DisConnect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DisConnect.Location = new System.Drawing.Point(6, 12);
            this.btn_DisConnect.Name = "btn_DisConnect";
            this.btn_DisConnect.Size = new System.Drawing.Size(101, 39);
            this.btn_DisConnect.TabIndex = 3;
            this.btn_DisConnect.Text = "Bağlantıyı Kes";
            this.btn_DisConnect.UseVisualStyleBackColor = false;
            this.btn_DisConnect.Click += new System.EventHandler(this.btn_DisConnect_Click);
            // 
            // pictureB_MiniBtn
            // 
            this.pictureB_MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureB_MiniBtn.Image")));
            this.pictureB_MiniBtn.Location = new System.Drawing.Point(734, 3);
            this.pictureB_MiniBtn.Name = "pictureB_MiniBtn";
            this.pictureB_MiniBtn.Size = new System.Drawing.Size(14, 14);
            this.pictureB_MiniBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_MiniBtn.TabIndex = 2;
            this.pictureB_MiniBtn.TabStop = false;
            this.pictureB_MiniBtn.Click += new System.EventHandler(this.pictureB_MiniBtn_Click);
            // 
            // pictureB_FullScreenBtn
            // 
            this.pictureB_FullScreenBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureB_FullScreenBtn.Image")));
            this.pictureB_FullScreenBtn.Location = new System.Drawing.Point(754, 3);
            this.pictureB_FullScreenBtn.Name = "pictureB_FullScreenBtn";
            this.pictureB_FullScreenBtn.Size = new System.Drawing.Size(14, 14);
            this.pictureB_FullScreenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_FullScreenBtn.TabIndex = 2;
            this.pictureB_FullScreenBtn.TabStop = false;
            this.pictureB_FullScreenBtn.Click += new System.EventHandler(this.pictureB_FullScreenBtn_Click);
            // 
            // pictureB_XBtn
            // 
            this.pictureB_XBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureB_XBtn.Image")));
            this.pictureB_XBtn.Location = new System.Drawing.Point(774, 3);
            this.pictureB_XBtn.Name = "pictureB_XBtn";
            this.pictureB_XBtn.Size = new System.Drawing.Size(14, 14);
            this.pictureB_XBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB_XBtn.TabIndex = 2;
            this.pictureB_XBtn.TabStop = false;
            this.pictureB_XBtn.Click += new System.EventHandler(this.pictureB_XBtn_Click);
            // 
            // Panel_LeftMenu
            // 
            this.Panel_LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Panel_LeftMenu.Controls.Add(this.pictureBox_EksonLogo);
            this.Panel_LeftMenu.Controls.Add(this.btn_Users);
            this.Panel_LeftMenu.Controls.Add(this.btn_Cables);
            this.Panel_LeftMenu.Controls.Add(this.btn_Products);
            this.Panel_LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_LeftMenu.Location = new System.Drawing.Point(0, 60);
            this.Panel_LeftMenu.Name = "Panel_LeftMenu";
            this.Panel_LeftMenu.Size = new System.Drawing.Size(133, 468);
            this.Panel_LeftMenu.TabIndex = 1;
            // 
            // pictureBox_EksonLogo
            // 
            this.pictureBox_EksonLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_EksonLogo.Image")));
            this.pictureBox_EksonLogo.Location = new System.Drawing.Point(3, 425);
            this.pictureBox_EksonLogo.Name = "pictureBox_EksonLogo";
            this.pictureBox_EksonLogo.Size = new System.Drawing.Size(130, 31);
            this.pictureBox_EksonLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_EksonLogo.TabIndex = 1;
            this.pictureBox_EksonLogo.TabStop = false;
            this.pictureBox_EksonLogo.Click += new System.EventHandler(this.pictureBox_EksonLogo_Click);
            this.pictureBox_EksonLogo.MouseHover += new System.EventHandler(this.pictureBox_EksonLogo_MouseHover);
            // 
            // btn_Users
            // 
            this.btn_Users.FlatAppearance.BorderSize = 0;
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Users.ForeColor = System.Drawing.Color.White;
            this.btn_Users.Location = new System.Drawing.Point(6, 83);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Size = new System.Drawing.Size(124, 34);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "Kullanıcılar";
            this.btn_Users.UseVisualStyleBackColor = true;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // btn_Cables
            // 
            this.btn_Cables.FlatAppearance.BorderSize = 0;
            this.btn_Cables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cables.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cables.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cables.Location = new System.Drawing.Point(6, 43);
            this.btn_Cables.Name = "btn_Cables";
            this.btn_Cables.Size = new System.Drawing.Size(124, 34);
            this.btn_Cables.TabIndex = 0;
            this.btn_Cables.Text = "Kablolar";
            this.btn_Cables.UseVisualStyleBackColor = true;
            this.btn_Cables.Click += new System.EventHandler(this.btn_Cables_Click);
            // 
            // btn_Products
            // 
            this.btn_Products.FlatAppearance.BorderSize = 0;
            this.btn_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Products.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Products.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Products.Location = new System.Drawing.Point(6, 3);
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.Size = new System.Drawing.Size(124, 34);
            this.btn_Products.TabIndex = 0;
            this.btn_Products.Text = "Ürünler";
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // TwistMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(807, 528);
            this.Controls.Add(this.Panel_LeftMenu);
            this.Controls.Add(this.Panel_TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "TwistMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TwistMainForm_Load);
            this.Panel_TopMenu.ResumeLayout(false);
            this.Panel_TopMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_MiniBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_FullScreenBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB_XBtn)).EndInit();
            this.Panel_LeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_EksonLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_TopMenu;
        private System.Windows.Forms.PictureBox pictureB_FullScreenBtn;
        private System.Windows.Forms.PictureBox pictureB_XBtn;
        private System.Windows.Forms.Panel Panel_LeftMenu;
        private System.Windows.Forms.PictureBox pictureB_MiniBtn;
        private System.Windows.Forms.Label label_ConnectionStatus;
        private System.Windows.Forms.Label label_AccessSystem;
        private System.Windows.Forms.Label label_DataRequest;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_DisConnect;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.Button btn_Cables;
        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.ComboBox combo_Languages;
        private System.Windows.Forms.PictureBox pictureBox_EksonLogo;
    }
}