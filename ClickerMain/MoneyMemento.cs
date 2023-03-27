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

        public MoneyMemento(int currentAmount)
        {
            this.amount = currentAmount;
        }

        public int GetSavedAmount()
        {
            return amount;
        }
    }
}
