using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Player : Entity
    {
        private int criticalHitChance;
        private int level;

        public Player(int initialHealth, int initialDamage, int initialCriticalHitChance, int level)
        {
            Health = initialHealth;
            Damage = initialDamage;
            criticalHitChance = initialCriticalHitChance;
            level = level;
        }

        public int Damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public int CriticalHitChance
        {
            get { return criticalHitChance; }
            set { criticalHitChance = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }

    }
}
