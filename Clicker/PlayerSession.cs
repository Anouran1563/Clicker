using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class PlayerSession
    {
        public ClickCount ClickCount { get; }
        public Cash Cash { get; }
        public TransactionProcess process { get; }

        public PlayerSession(IclickProfile profile)
        {
            ClickCount = new ClickCount();
            Cash = new Cash();
            process = new TransactionProcess(profile);
        }

        public void ExeClick()
        {
            int gain = process.Click();
            ClickCount.Increment(gain);
        }

        public void Sell()
        {
            int clicks = ClickCount.Reset();
            int value = process.Valuation(clicks);
            Cash.Deposit(value);
        }
    }
}
