using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twist.WinFormUI.Classes
{
    public class DesignUI
    {
        public static void ChildFormButtonsDesign(Form form)
        {
            int Left=0, Top = 40, Height = 35, Width=0;

            foreach(Control ctrl in form.Controls)
            {
                if(ctrl is Button)
                {
                    Button button = ctrl as Button;
                    button.BackColor = Color.FromArgb(3, 100, 255);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(3, 190, 255);
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 150, 255);
                    button.FlatAppearance.BorderColor = Color.FromArgb(3, 50, 255);

                    //switch (button.Name)
                    //{
                    //    case ("btn_Add"):
                    //        Left = 40; Width = 60;
                    //        break;
                    //    case ("btn_Update"):
                    //        Left = 105; Width = 90;
                    //        break;
                    //}
                    //button.Location = new Point(form.Width - Left, Top);
                    //button.Size = new Size(Width, Height);
 
                }

            }
        }
        
    }
}
