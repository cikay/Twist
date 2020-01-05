using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twist.WinFormUI.Classes
{
    public class ChildFormControls:IEnumerable<Button>
    {
        public Button btn_Add { get; set; }
        public Button btn_Update { get; set; }

        public IEnumerator<Button> GetEnumerator()
        {
            yield return btn_Add;
            yield return btn_Update;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
