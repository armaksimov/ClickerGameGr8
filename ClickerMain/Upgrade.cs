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

        public Upgrade(string initialName, int initialCost, int initialUpgradeValue)
        {
            this.name = initialName;
            this.cost = initialCost;
            this.upgradeValue = initialUpgradeValue;
        }

        // Methods to modify upgrade stats and check their state
    }
}
