using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class TransactionProcess
    {
        private readonly IclickProfile _profile;

        public TransactionProcess(IclickProfile profile)
        {
            _profile = profile;
        }

        public int Valuation(int clicks)
        {
            return _profile.ComputeSellVal(clicks);
        }
        public int Click()
        {
            return _profile.ComputeClickVal();
        }
    }
}
