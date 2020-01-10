using System;
using System.Drawing;
using System.Windows.Forms;
using Twist.Entity;
using Twist.WinFormUI.Classes;

namespace Twist.WinFormUI.Forms
{
    public partial class ProductDetailsForm : Form
    {
      
        public ProductDetailsForm(Product productData)
        {
            InitializeComponent();
           
            TwistingCable twistingCable = new TwistingCable();
            WiresColor wiresColor = new WiresColor();
            wiresColor.Wire1 = new Wire() { color = Color.Yellow, LineColor = Color.Red };
            wiresColor.Wire2 = new Wire() { color = Color.Black, LineColor = Color.White };
            DesignUI designUI = new DesignUI();

            designUI.OverlapImages(pictureBox_Cable, wiresColor);
            int originY = 33;
            int endPointY = 80;
            string gage = " mm";

            twistingCable.LeftOpenLength.Value = productData.SolAcikBoy.Value + gage;
            twistingCable.LeftOpenLength.Left.Origin = new Point(10, originY + 5);
            twistingCable.LeftOpenLength.Left.EndPoint = new Point(10, 80);
            twistingCable.LeftOpenLength.Right.Origin = new Point(115, originY);
            twistingCable.LeftOpenLength.Right.EndPoint = new Point(115, endPointY);

            twistingCable.PitchLength.Value = productData.PitchDimension.Value + gage;
            twistingCable.PitchLength.Left.Origin = new Point(210, originY);
            twistingCable.PitchLength.Left.EndPoint = new Point(210, endPointY);
            twistingCable.PitchLength.Right.Origin = new Point(400, originY);
            twistingCable.PitchLength.Right.EndPoint = new Point(400, endPointY);

            twistingCable.RightOpenLength.Value = productData.SagAcikBoy.Value + gage;
            twistingCable.RightOpenLength.Left.Origin = new Point(492, originY);
            twistingCable.RightOpenLength.Left.EndPoint = new Point(492, endPointY);
            twistingCable.RightOpenLength.Right.Origin = new Point(599, originY + 5);
            twistingCable.RightOpenLength.Right.EndPoint = new Point(599, 80);

            designUI.DrawArrow(pictureBox_Cable.BackgroundImage, twistingCable);
            pictureBox_Cable.Size = new Size(pictureBox_Cable.Size.Width, 180);

            txt_FowardSpeed.Text = productData.FowardSpeed.Value;
            txt_BackSpeed.Text = productData.BackSpeed.Value;
            txt_FowardTour.Text = productData.FowardCircuit.Value;
            txt_BackTour.Text = productData.BackCircuit.Value;
            txt_KabloBirakmaSuresi.Text = productData.KabloBirakmaSuresi.Value;
            txt_Quantity.Text = productData.Quantity.Value;
            txt_CableDirection.Text = productData.CableDirection.Value;
            
        }


        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Cable_Paint(object sender, PaintEventArgs e)
        {
            

            
        }

        
    }
}
