using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class MoneyMemento
    {
        private int amount;

        public MoneyMemento(int Amount)
        {
            amount = Amount;
        }

        public int GetAmount()
        {
            return amount;
        }
    }
}
