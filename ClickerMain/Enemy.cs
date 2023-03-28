using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Enemy
    {
        private int _health;
        private int _damage;
        private int _goldReward;

        public Enemy(int initialHealth, int initialDamage, int initialGoldReward)
        {
            _health = initialHealth;
            _damage = initialDamage;
            _goldReward = initialGoldReward;
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public int GoldReward
        {
            get { return _goldReward; }
            set { _goldReward = value; }
        }

        public void TakeDamage(int amount)
        {
            _health -= amount;
        }

    }
}
