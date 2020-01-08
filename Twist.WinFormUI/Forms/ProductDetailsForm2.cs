using System;
using System.Drawing;
using System.Windows.Forms;
using Twist.WinFormUI.Classes;

namespace Twist.WinFormUI.Forms
{
    public partial class ProductDetailsForm2 : Form
    {
        public ProductDetailsForm2()
        {
            InitializeComponent();
        }

        private void ProductDetailsForm2_Load(object sender, EventArgs e)
        {
            WiresColor wiresColor = new WiresColor();
            wiresColor.Wire1 = new Wire() { color = Color.Yellow, LineColor = Color.Red };
            wiresColor.Wire2 = new Wire() { color = Color.Black, LineColor = Color.White };
            DesignUI designUI = new DesignUI();
            
            designUI.OverlapImages(pictureBox_Cable, wiresColor);
           
            pictureBox_Cable.BackgroundImage = designUI.DrawArrow(pictureBox_Cable.BackgroundImage);
            
        }


        private void pictureBox_Cable_Paint(object sender, PaintEventArgs e)
        {
            

            
        }
    }
}
