using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootLibrary

 class LootBox   {

    //properties go here, use format public/private <type> name {get; set}

    public double Rarity { get; set; }
    public LootBox() //Constructor
    { 
        Random rnd = new Random();  
        Rarity = rnd.NextDouble();
    }

    //Methods go here

    private double ShowRarity() //This method uses a ran
    {
        return Rarity;
    }
}
