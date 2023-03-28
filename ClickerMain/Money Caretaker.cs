using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class MoneyCaretaker
    {
        private MoneyMemento memento;

        public void Save(Money money)
        {
            memento = money.Save();
        }

        public void Restore(Money money)
        {
            money.Restore(memento);
        }
    }
}
