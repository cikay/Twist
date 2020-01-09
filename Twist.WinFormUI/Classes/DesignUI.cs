using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twist.WinFormUI.Classes
{
    public class DesignUI
    {
        public static void ChildFormButtonsDesign(Form form)
        {
            
            foreach(Control ctrl in form.Controls)
            {
                if(ctrl is Button)
                {
                    Button button = ctrl as Button;
                    button.BackColor = Color.FromArgb(3, 100, 255);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 190, 255);
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 150, 255);
                    button.FlatAppearance.BorderColor = Color.FromArgb(3, 50, 255);

                }

            }
        }

       
        public void OverlapImages(PictureBox picImage, WiresColor wiresColor)
        {
           
            try
            {
                
                Bitmap WireBitmap = new Bitmap("E:/Yazılım projeleri/Twist/hmi/ikonlar/kablolar/siyah_a_kablo.png"); //Wire image
                picImage.Image = WireBitmap;

                picImage.BackColor = Color.Transparent;
                WireBitmap = ReplaceColor(WireBitmap, Color.Green);
                picImage.Visible = true;

                if (wiresColor.Wire1.LineColor != null)
                {
                    Bitmap WireLineBitmap = new Bitmap("E:/Yazılım projeleri/Twist/hmi/ikonlar/kablolar/beyaz_a_cizgi.png");
                    WireLineBitmap = ReplaceColor(WireLineBitmap, wiresColor.Wire1.LineColor);

                    if (WireLineBitmap != null && WireBitmap != null)
                    {
                        int wire1linePosY = WireBitmap.Height / 2 - WireLineBitmap.Height / 2;

                        using (Graphics gr = Graphics.FromImage(WireBitmap))
                        {
                            gr.DrawImage(WireLineBitmap, 50, wire1linePosY, picImage.Width - 100, WireLineBitmap.Height);
                            
                        }
                    }
                }


                Bitmap CombinedWiresBitmap = new Bitmap(WireBitmap); //current CombinedWiresBitmap image


                Bitmap Wire2Bitmap = new Bitmap("E:/Yazılım projeleri/Twist/hmi/ikonlar/kablolar/siyah_b_kablo.png"); //overlay image
                Wire2Bitmap = ReplaceColor(Wire2Bitmap, Color.Black);

                if (wiresColor.Wire2.LineColor != null)
                {
                    Bitmap Wire2LineBitmap = new Bitmap("E:/Yazılım projeleri/Twist/hmi/ikonlar/kablolar/beyaz_b_cizgi.png");
                    Wire2LineBitmap = ReplaceColor(Wire2LineBitmap, wiresColor.Wire2.LineColor);
                    if (Wire2LineBitmap != null && Wire2Bitmap != null)
                    {
                        int wire2linePosY = Wire2Bitmap.Height / 2 - Wire2LineBitmap.Height / 2;
                        using (Graphics gr = Graphics.FromImage(Wire2Bitmap))
                        {

                            gr.DrawImage(Wire2LineBitmap, 50, wire2linePosY, picImage.Width - 100, Wire2LineBitmap.Height);

                        }
                    }
                }

                if (Wire2Bitmap != null)
                {
                    using (Graphics gr = Graphics.FromImage(CombinedWiresBitmap))
                    {
                        gr.DrawImage(Wire2Bitmap, 0, 0, picImage.Width, picImage.Height);
                    }
                }


                picImage.Image = CombinedWiresBitmap;
                picImage.Padding = new Padding(10, 10, 10, 0);
                picImage.Height = 300;
                
                //DrawArrow(picImage.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file.\n" + ex.Message,
                    "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        internal void DrawWire(PictureBox pictureBox1, byte WireCount)
        {
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            Pen pen = new Pen(Brushes.Yellow, 7.0F);

            float x1 = 0;
            float y1 = 0;
            float y2 = 0;
            float yEx = 50; //spacing from the top
            float eF = 35; //size multipler 
            const int width = 100;


            for (float x = 0; x < width; x += 0.0005F)// 0.1f is more precise
            {
                y2 = (float)Math.Sin(x);

                float a = x1 * eF;
                float b = y1 * eF + yEx;
                float c = x * eF;
                float d = y2 * eF + yEx;

                g.DrawLine(pen, a, b, c, d);

                x1 = x;
                y1 = y2;

            }

            //g.DrawImage(pictureBox1.Image, new Point(0, 0));
        }

        public Bitmap ReplaceColor(Image _image, Color _colorNew)
        {
            Bitmap bmap = (Bitmap)_image.Clone();

            Color c;

            for (int x = 0; x < bmap.Width; x++)
            {
                for (int y = 0; y < bmap.Height; y++)
                {
                    c = bmap.GetPixel(x, y);

                    //Determinig Color Match
                    string a = c.ToString();
                    //if (c.ToArgb().CompareTo(Color.FromArgb(0,0,0,0))==0)
                    //{
                       
                    //}

                    if (_colorNew == Color.Transparent) bmap.SetPixel(x, y, Color.FromArgb(0, _colorNew.R, _colorNew.G, _colorNew.B));
                    else bmap.SetPixel(x, y, Color.FromArgb(c.A, _colorNew.R, _colorNew.G, _colorNew.B));

                }
            }
            return (Bitmap)bmap.Clone();
        }

        public Image DrawArrow(Image image, TwistingCable twistingCable)
        {
           

            foreach (Lines lines in twistingCable)
            {

                if (string.Equals(lines.Left.ToString(), "LeftOpenLength"))
                {
                    int a = lines.Left.EndPoint.X;
                }

                using (Pen LeftLinePen = new Pen(Brushes.Black))
                {
                    Graphics g = Graphics.FromImage(image);
                    g.DrawLine(LeftLinePen, new Point(lines.Left.Origin.X, lines.Left.Origin.Y), new Point(lines.Left.EndPoint.X, lines.Left.EndPoint.Y));
                }

                using (Pen RightLinePen = new Pen(Brushes.Black))
                {
                    Graphics g = Graphics.FromImage(image);
                    g.DrawLine(RightLinePen, new Point(lines.Right.Origin.X, lines.Right.Origin.Y), new Point(lines.Right.EndPoint.X, lines.Right.EndPoint.Y));

                }

                
                Point ArrowOrigin = new Point(lines.Left.EndPoint.X, lines.Left.EndPoint.Y + 5);
                Point ArrowEndPoint = new Point(lines.Right.EndPoint.X, lines.Right.EndPoint.Y + 5);
                using (Pen arrowPen = new Pen(Brushes.Black))
                {
                    
                    using (AdjustableArrowCap arrowCap = new AdjustableArrowCap(2, 2))
                    {
                        Graphics g = Graphics.FromImage(image);
                        arrowCap.WidthScale = 5;
                        arrowCap.BaseCap = LineCap.Square;
                        arrowCap.Height = 2;
                        arrowPen.CustomEndCap = arrowCap;
                        g.DrawLine(arrowPen, ArrowOrigin, ArrowEndPoint);

                    }

                }

                

            }


            return image;
        }

     
    }
}
