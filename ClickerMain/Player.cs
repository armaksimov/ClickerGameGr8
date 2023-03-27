using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Player
    {
        private int health;
        private int damage;
        private int criticalHitChance;
        private int level;

        public Player(int initialHealth, int initialDamage, int initialCriticalHitChance, int level)
        {
            this.health = initialHealth;
            this.damage = initialDamage;
            this.criticalHitChance = initialCriticalHitChance;
            this.level = level;
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
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
