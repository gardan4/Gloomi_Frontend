using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gloomi
{
    public class SerialMessage
    {
        public float Humidity { set; get; }
        public float Temperature { set; get; }
        public float Brightness { set; get; }
        public int LampCode { set; get; }
    }
}

