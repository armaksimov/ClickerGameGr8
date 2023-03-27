using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class MoneyCaretaker
    {
        private Stack<MoneyMemento> history = new Stack<MoneyMemento>();

        public void Save(MoneyMemento memento)
        {
            history.Push(memento);
        }

        public MoneyMemento Undo()
        {
            return history.Pop();
        }
    }
}
