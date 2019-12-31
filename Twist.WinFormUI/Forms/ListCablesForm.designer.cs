﻿namespace WindowsFormsApp1.Forms
{
    partial class ListCablesForm
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
            this.lV_Cables = new System.Windows.Forms.ListView();
            this.CableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CableSection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OuterDiameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lV_Cables
            // 
            this.lV_Cables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CableName,
            this.CableSection,
            this.OuterDiameter,
            this.Direction,
            this.Color});
            this.lV_Cables.HideSelection = false;
            this.lV_Cables.Location = new System.Drawing.Point(30, 30);
            this.lV_Cables.Name = "lV_Cables";
            this.lV_Cables.Size = new System.Drawing.Size(398, 487);
            this.lV_Cables.TabIndex = 0;
            this.lV_Cables.UseCompatibleStateImageBehavior = false;
            this.lV_Cables.View = System.Windows.Forms.View.Details;
            // 
            // CableName
            // 
            this.CableName.Tag = "CableName";
            this.CableName.Text = "Kablo Adı";
            this.CableName.Width = 86;
            // 
            // CableSection
            // 
            this.CableSection.Tag = "CableSection";
            this.CableSection.Text = "Kablo Kesiti";
            this.CableSection.Width = 75;
            // 
            // OuterDiameter
            // 
            this.OuterDiameter.Tag = "OuterDiameter";
            this.OuterDiameter.Text = "Kablo Dış Çapı";
            this.OuterDiameter.Width = 89;
            // 
            // Direction
            // 
            this.Direction.Tag = "Direction";
            this.Direction.Text = "Kablo Yönü";
            this.Direction.Width = 78;
            // 
            // Color
            // 
            this.Color.Tag = "Color";
            this.Color.Text = "Renk";
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(800, 20);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(60, 35);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Güncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(866, 20);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(60, 35);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_AddCable_Click);
            // 
            // ListCablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.lV_Cables);
            this.Name = "ListCablesForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ListCablesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lV_Cables;
        private System.Windows.Forms.ColumnHeader CableName;
        private System.Windows.Forms.ColumnHeader CableSection;
        private System.Windows.Forms.ColumnHeader OuterDiameter;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
    }
}