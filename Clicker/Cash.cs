using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clicker
{
    internal class Cash
    {
        public int Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
        public void Withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
        }
    }
}
