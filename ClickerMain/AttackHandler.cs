using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class AttackHandler
    {
        public int DamageEnemy(Player player, Enemy enemy)
        {
            int damage = player.Damage;

            int criticalHitChance = player.CriticalHitChance;
            int roll = new Random().Next(100);

            if (roll < criticalHitChance)
            {
                damage *= 2;
            }

            enemy.TakeDamage(damage);

            return damage;  
        }
    }
}
