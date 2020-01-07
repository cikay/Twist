using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.WinFormUI.Classes
{
    public class WiresColor:IEnumerable<Wire>
    {
        public Wire Wire1 { get; set; }
        public Wire Wire2 { get; set; }
        public Wire Wire3 { get; set; }

        public IEnumerator<Wire> GetEnumerator()
        {
            yield return Wire1;
            yield return Wire2;
            yield return Wire3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
