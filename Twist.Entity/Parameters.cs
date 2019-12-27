using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twist.Entity
{
    public class Parameters
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int StartingAdress { get; set; }
        public int Length { get; set; }
        public bool ConvertToAsciiString { get; set; }
    }
}
