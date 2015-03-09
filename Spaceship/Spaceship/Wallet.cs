using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceship
{
    class Wallet
    {
        private int amount;

        public Wallet()
        {

        }

        public Wallet(int money)
        {
            amount = money;
        }

        public int GetMoney()
        {
            return amount;
        }

        public void SetMoney(int amount)
        {
            this.amount = amount;
        }

        public void TakeMoney(int amount)
        {
            this.amount = this.amount - amount;
        }
    }
}
