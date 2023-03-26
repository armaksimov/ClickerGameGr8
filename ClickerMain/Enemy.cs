using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Enemy
    {
        private int health;
        private int damage;
        private int goldReward;

        public GruntEnemy(int initialHealth, int initialDamage, int initialGoldReward)
        {
            this.health = initialHealth;
            this.damage = initialDamage;
            this.goldReward = initialGoldReward;
        }

        // Methods to modify enemy stats and check their state
    }
}
