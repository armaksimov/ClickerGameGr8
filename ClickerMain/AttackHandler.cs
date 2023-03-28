using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class AttackHandler
    {
        private Player _player;
        private Weapons _weapons;

        public AttackHandler(Player player, Weapons weapons)
        {
            _player = player;
            _weapons = weapons;
        }

        public void DamageEnemy(Enemy enemy)
        {
            int damage = _player.Damage + _weapons.Attack + _weapons.Bonus;
            int criticalHitChance = _player.CriticalHitChance;
            int roll = new Random().Next(100);

            if (roll < criticalHitChance)
            {
                damage *= 2;
                Console.WriteLine("Critical hit!");
            }

            enemy.TakeDamage(damage);
        }
    }
}
