using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Enemy : Entity
    {
        private int _goldReward;

        public Enemy(int initialHealth, int initialDamage, int initialGoldReward)
        {
            Health = initialHealth;
            Damage = initialDamage;
            _goldReward = initialGoldReward;
        }

        public int GoldReward
        {
            get { return _goldReward; }
            set { _goldReward = value; }
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            }
        }
}
