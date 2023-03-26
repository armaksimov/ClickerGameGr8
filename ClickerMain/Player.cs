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

        public Player(int initialHealth, int initialDamage, int initialCriticalHitChance)
        {
            this.health = initialHealth;
            this.damage = initialDamage;
            this.criticalHitChance = initialCriticalHitChance;
        }

        // Methods to modify player stats and check their state
    }
}
