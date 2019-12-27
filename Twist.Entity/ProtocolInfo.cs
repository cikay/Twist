using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twist.Entity.Enums;

namespace Twist.Entity
{
    public class ProtocolInfo
    {
        public WriteOrRead comType { get; set; }
        public RequestDataType requestDataType { get; set; }
    }
}
