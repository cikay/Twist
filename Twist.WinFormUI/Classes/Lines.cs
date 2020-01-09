using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.WinFormUI.Classes
{
    public class Lines:IEnumerable<Line>
    {
        public Line Left { get; set; } = new Line();
        public Line Right { get; set; } = new Line();


        public IEnumerator<Line> GetEnumerator()
        {
            yield return Left;
            yield return Right;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
