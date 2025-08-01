using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class Profile
    {
        public int Cash { get; set; }
        public int Clicks { get; set; }
        public int MaxClicks { get; set; }
        public int MaxCash { get; set; }
        public int Multiplier { get; set; } = 1;
        public int Rank { get; set; } = 1;
    }
}
