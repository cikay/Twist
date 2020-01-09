using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.WinFormUI.Classes
{
    public class TwistingCable : IEnumerable<Lines>
    {
        public Lines LeftOpenLength { get; set; } = new Lines();
        public Lines RightOpenLength { get; set; } = new Lines();
        public Lines PitchLength { get; set; } = new Lines();
        

        public IEnumerator<Lines> GetEnumerator()
        {
            yield return LeftOpenLength;
            yield return RightOpenLength;
            yield return PitchLength;
          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }
    }
}
