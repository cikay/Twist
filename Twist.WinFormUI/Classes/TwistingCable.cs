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
        public Lines LeftOpenLength { get; set; } = new Lines("LeftOpenLength", "Sol Açık Boy");
        public Lines RightOpenLength { get; set; } = new Lines("RightOpenLength", "Sağ Açık Boy");
        public Lines PitchLength { get; set; } = new Lines("PitchLength", "Hatve Boyu");
        public Lines CableLengthAfterTwisting { get; set; } = new Lines("CableLengthAfterTwisting", "Burma sonrası kablo boyu");

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
