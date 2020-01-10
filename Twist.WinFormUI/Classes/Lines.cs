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
        public Lines(string Name, string Text)
        {
            this.Name = Name;
            this.Text = Text;
        }

        public Line Left { get; set; } = new Line();
        public Line Right { get; set; } = new Line();

        public string Text { get; set; }

        public string Value { get; set; }



        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }


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
