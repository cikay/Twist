namespace WindowsFormsApp1.Forms
{
    partial class AddCableForm
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
            this.lb_CableName = new System.Windows.Forms.Label();
            this.lb_CableSection = new System.Windows.Forms.Label();
            this.lb_CableDirection = new System.Windows.Forms.Label();
            this.lb_CableOuterDiameter = new System.Windows.Forms.Label();
            this.lb_CableColor = new System.Windows.Forms.Label();
            this.txt_CableName = new System.Windows.Forms.TextBox();
            this.txt_CableSection = new System.Windows.Forms.TextBox();
            this.txt_OuterDiameter = new System.Windows.Forms.TextBox();
            this.txt_Direction = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_CableName
            // 
            this.lb_CableName.AutoSize = true;
            this.lb_CableName.Location = new System.Drawing.Point(76, 44);
            this.lb_CableName.Name = "lb_CableName";
            this.lb_CableName.Size = new System.Drawing.Size(55, 13);
            this.lb_CableName.TabIndex = 0;
            this.lb_CableName.Text = "Kablo Adı:";
            // 
            // lb_CableSection
            // 
            this.lb_CableSection.AutoSize = true;
            this.lb_CableSection.Location = new System.Drawing.Point(96, 73);
            this.lb_CableSection.Name = "lb_CableSection";
            this.lb_CableSection.Size = new System.Drawing.Size(35, 13);
            this.lb_CableSection.TabIndex = 0;
            this.lb_CableSection.Text = "Kesiti:";
            // 
            // lb_CableDirection
            // 
            this.lb_CableDirection.AutoSize = true;
            this.lb_CableDirection.Location = new System.Drawing.Point(102, 125);
            this.lb_CableDirection.Name = "lb_CableDirection";
            this.lb_CableDirection.Size = new System.Drawing.Size(29, 13);
            this.lb_CableDirection.TabIndex = 0;
            this.lb_CableDirection.Text = "Yön:";
            // 
            // lb_CableOuterDiameter
            // 
            this.lb_CableOuterDiameter.AutoSize = true;
            this.lb_CableOuterDiameter.Location = new System.Drawing.Point(84, 103);
            this.lb_CableOuterDiameter.Name = "lb_CableOuterDiameter";
            this.lb_CableOuterDiameter.Size = new System.Drawing.Size(47, 13);
            this.lb_CableOuterDiameter.TabIndex = 0;
            this.lb_CableOuterDiameter.Text = "Dış Çap:";
            // 
            // lb_CableColor
            // 
            this.lb_CableColor.AutoSize = true;
            this.lb_CableColor.Location = new System.Drawing.Point(95, 148);
            this.lb_CableColor.Name = "lb_CableColor";
            this.lb_CableColor.Size = new System.Drawing.Size(36, 13);
            this.lb_CableColor.TabIndex = 0;
            this.lb_CableColor.Text = "Renk:";
            // 
            // txt_CableName
            // 
            this.txt_CableName.Location = new System.Drawing.Point(137, 41);
            this.txt_CableName.Name = "txt_CableName";
            this.txt_CableName.Size = new System.Drawing.Size(100, 20);
            this.txt_CableName.TabIndex = 1;
            // 
            // txt_CableSection
            // 
            this.txt_CableSection.Location = new System.Drawing.Point(137, 70);
            this.txt_CableSection.Name = "txt_CableSection";
            this.txt_CableSection.Size = new System.Drawing.Size(100, 20);
            this.txt_CableSection.TabIndex = 1;
            // 
            // txt_OuterDiameter
            // 
            this.txt_OuterDiameter.Location = new System.Drawing.Point(137, 96);
            this.txt_OuterDiameter.Name = "txt_OuterDiameter";
            this.txt_OuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txt_OuterDiameter.TabIndex = 1;
            // 
            // txt_Direction
            // 
            this.txt_Direction.Location = new System.Drawing.Point(137, 122);
            this.txt_Direction.Name = "txt_Direction";
            this.txt_Direction.Size = new System.Drawing.Size(100, 20);
            this.txt_Direction.TabIndex = 1;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(137, 148);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(137, 187);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 29);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddCable_Click);
            // 
            // AddCableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.txt_Direction);
            this.Controls.Add(this.txt_OuterDiameter);
            this.Controls.Add(this.txt_CableSection);
            this.Controls.Add(this.txt_CableName);
            this.Controls.Add(this.lb_CableOuterDiameter);
            this.Controls.Add(this.lb_CableColor);
            this.Controls.Add(this.lb_CableDirection);
            this.Controls.Add(this.lb_CableSection);
            this.Controls.Add(this.lb_CableName);
            this.Name = "AddCableForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.AddCableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CableName;
        private System.Windows.Forms.Label lb_CableSection;
        private System.Windows.Forms.Label lb_CableDirection;
        private System.Windows.Forms.Label lb_CableOuterDiameter;
        private System.Windows.Forms.Label lb_CableColor;
        private System.Windows.Forms.TextBox txt_CableName;
        private System.Windows.Forms.TextBox txt_CableSection;
        private System.Windows.Forms.TextBox txt_OuterDiameter;
        private System.Windows.Forms.TextBox txt_Direction;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.Button btn_Add;
    }
}