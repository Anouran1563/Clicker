using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class IclickProfile
    {
        public int ComputeClickVal();
        public int ComputeSellVal(int ClickCount);
        string Name { get; set; }
    }
}
