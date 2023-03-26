using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Boss
    {
        private int health;
        private int damage;
        private int goldReward;

        public BossEnemy(int initialHealth, int initialDamage, int initialGoldReward)
        {
            this.health = initialHealth;
            this.damage = initialDamage;
            this.goldReward = initialGoldReward;
        }

        // Methods to modify boss stats and handle unique mechanics
    }
}
