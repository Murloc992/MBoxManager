using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroManager
{
    public class MBHotKey
    {
        public string HotKey { get; set; }
        public bool Disabled { get; set; }
        public bool RoundRobin { get; set; }
    }
}
