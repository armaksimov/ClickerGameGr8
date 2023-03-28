using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Upgrade
    {
        public static void UpgradePlayerAndWeapon(Player player, Weapons weapon)
        {
            // Increase player's level by 1
            player.Level += 1;

            // Increase weapon's attack by player's level and bonus by 1
            weapon.Attack += player.Level;
            weapon.Bonus += 1;

            // Increase player's damage by weapon's attack
            player.Damage += weapon.Attack;

            Console.WriteLine("Player upgraded to level " + player.Level + " and weapon damage increased to " + player.Damage);
        }
    }
}
