using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Money
    {
        private int _amount;

        public Money(int amount)
        {
            _amount = amount;
        }

        public int GetAmount()
        {
            return _amount;
        }

        public void AddMoney(int amount)
        {
            _amount += amount;
        }

        public MoneyMemento Save()
        {
            return new MoneyMemento(_amount);
        }

        public void Restore(MoneyMemento memento)
        {
            if (memento != null)
            {
                _amount = memento.GetAmount();
            }
        }
    }
}
