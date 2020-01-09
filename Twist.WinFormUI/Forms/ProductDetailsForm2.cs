using System;
using System.Drawing;
using System.Windows.Forms;
using Twist.WinFormUI.Classes;
using Twist.WinFormUI.Struct;

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
            int originY = 33;
            int endPointY = 80;
            
            TwistingCable twistingCable = new TwistingCable();
            twistingCable.LeftOpenLength.Left.Origin = new LinePoint(10, originY + 5);
            twistingCable.LeftOpenLength.Left.EndPoint = new LinePoint(10, 80);
            twistingCable.LeftOpenLength.Right.Origin = new LinePoint(115, originY);
            twistingCable.LeftOpenLength.Right.EndPoint = new LinePoint(115, endPointY);

            twistingCable.PitchLength.Left.Origin = new LinePoint(210, originY);
            twistingCable.PitchLength.Left.EndPoint = new LinePoint(210, endPointY);
            twistingCable.PitchLength.Right.Origin = new LinePoint(400, originY);
            twistingCable.PitchLength.Right.EndPoint = new LinePoint(400, endPointY);

            twistingCable.RightOpenLength.Left.Origin = new LinePoint(492, originY);
            twistingCable.RightOpenLength.Left.EndPoint = new LinePoint(492, endPointY);
            twistingCable.RightOpenLength.Right.Origin = new LinePoint(599, originY + 5);
            twistingCable.RightOpenLength.Right.EndPoint = new LinePoint(599, endPointY);

          

            designUI.DrawArrow(pictureBox_Cable.BackgroundImage, twistingCable);
        }


        private void pictureBox_Cable_Paint(object sender, PaintEventArgs e)
        {
            

            
        }
    }
}
