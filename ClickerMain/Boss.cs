using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Boss
    {
        private int _health;
        private int _damage;
        private int _goldReward;
        private int _xpReward;

        public Boss(int initialHealth, int initialDamage, int initialGoldReward, int initialXpReward)
        {
            _health = initialHealth;
            _damage = initialDamage;
            _goldReward = initialGoldReward;
            _xpReward = initialXpReward;
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

        public int XpReward
        {
            get { return _xpReward; }
            set { _xpReward = value; }
        }

        public int LeftHP()
        {
            return _health;
        }

        // Methods to modify boss stats and check their state
    }
}
