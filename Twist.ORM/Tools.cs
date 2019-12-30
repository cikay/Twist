using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Twist.ORM
{
    public class Tools
    {

        public static IEnumerable<Control> GetAllChildControl(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllChildControl(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public static IEnumerable<Control> GetAllControl(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControl(ctrl)).Concat(controls);
        }
    }
}
