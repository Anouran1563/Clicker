using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class ClickCount
    {
        public int Count { get; set; }

        public void Increment(int amount = 1)
        {
            Count += amount;
        }

        public int Reset()
        {
            int Temp = Count;
            Count = 0;
            return Temp;
        }
    }
}
