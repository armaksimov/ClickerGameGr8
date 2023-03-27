using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerMain
{
    public class Upgrade
    {
        private string name;
        private int cost;
        private int upgradeValue;

        public static void UpgradePlayerDamage(Player player)
        {
            int level = player.Level; // Assuming that Player has a GetLevel() method that returns the player's level
            int newDamage = level + 10;
            player.Damage = newDamage;
        }
    }
}
