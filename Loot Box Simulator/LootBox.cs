using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Box_Simulator
{
    internal class LootBox
    {
        //properties go here, use format public/private <type> name {get; set}

        public double Rarity { get; set; }
        public int AmountOfLoot { get; set; }
        public LootBox() //Constructor
        {
            //Random rnd = new Random();
            Rarity = DetermineRarity();
            AmountOfLoot = DetermineAmountOfLoot(Rarity);
        }

        //Methods go here
        internal double DetermineRarity()
        {
            Random rnd = new Random();
            double rarity = rnd.NextDouble();
            return rarity;
        }

        internal int DetermineAmountOfLoot(double Rarity)
        {
            int amountofloot = 0;

            if (Rarity <= 0.50)
            {
                amountofloot = 2;
            }
            else if (Rarity >= 0.51 && Rarity <= 0.90)
            {
                amountofloot = 4;
            }
            else
            {
                amountofloot = 6;
            }
            return amountofloot;
        }

        
        public double ShowRarityInPercent() //This method uses a ran
        {
            return Rarity*100;
        }
    }
}
