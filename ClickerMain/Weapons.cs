using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Weapons
    {
        private int _attack;
        private int _bonus;

        public Weapons(int initialAttack, int initialBonus)
        {
            _attack = initialAttack;
            _bonus = initialBonus;
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
