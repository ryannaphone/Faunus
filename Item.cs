using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faunusVB
{
    public class Item
    {
        public string name;
        public int amount;
        public double weight;
        public Boolean consumable;
        public Boolean combinable;
        public int healthChangeMax;
        public int hungerChangeMax;
        public int thirstChangeMax;
        public int energyChangeMax;
        public int sanityChangeMax;
        public int healthChangeMin;
        public int hungerChangeMin;
        public int thirstChangeMin;
        public int energyChangeMin;
        public int sanityChangeMin;

        public int gatherAmountMax;
        public int gatherAmountMin;

        public Item(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
            this.consumable = false;
            this.combinable = false;
            this.weight = 1;
            this.healthChangeMax = 0;
            this.hungerChangeMax = 0;
            this.thirstChangeMax = 0;
            this.energyChangeMax = 0;
            this.sanityChangeMax = 0;
            this.healthChangeMin = 0;
            this.hungerChangeMin = 0;
            this.thirstChangeMin = 0;
            this.energyChangeMin = 0;
            this.sanityChangeMin = 0;
            this.gatherAmountMax = 1;
            this.gatherAmountMin = 1;
        }

        public Item(string name, int amount, Boolean consumable, Boolean combinable, double weight, int gatherAmountMax, int gatherAmluntMin)
        {
            this.Name = name;
            this.Amount = amount;
            this.consumable = consumable;
            this.combinable = combinable;
            this.weight = weight;
            this.healthChangeMax = 0;
            this.hungerChangeMax = 0;
            this.thirstChangeMax = 0;
            this.energyChangeMax = 0;
            this.sanityChangeMax = 0;
            this.healthChangeMin = 0;
            this.hungerChangeMin = 0;
            this.thirstChangeMin = 0;
            this.energyChangeMin = 0;
            this.sanityChangeMin = 0;
            this.gatherAmountMax = gatherAmountMax;
            this.gatherAmountMin = gatherAmluntMin;
        }

        public Item(string name, int amount, Boolean consumable, Boolean combinable, double weight, int healthchangeMax, int hungerChangeMax,
            int thirstChangeMax, int energyChangeMax, int sanityChangeMax, int healthChangeMin, int hungerChangeMin, int thirstChangeMin,
            int energyChangeMin, int sanityChangeMin, int gatherAmountMax, int gatherAmountMin)
        {
            this.Name = name;
            this.Amount = amount;
            this.consumable = consumable;
            this.combinable = combinable;
            this.weight = weight;
            this.healthChangeMax = healthchangeMax;
            this.hungerChangeMax = hungerChangeMax;
            this.thirstChangeMax = thirstChangeMax;
            this.energyChangeMax = energyChangeMax;
            this.sanityChangeMax = sanityChangeMax;
            this.healthChangeMin = healthChangeMin;
            this.hungerChangeMin = hungerChangeMin;
            this.thirstChangeMin = thirstChangeMin;
            this.energyChangeMin = energyChangeMin;
            this.sanityChangeMin = sanityChangeMin;
            this.gatherAmountMax = gatherAmountMax;
            this.gatherAmountMin = gatherAmountMin;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }

        override public string ToString()
        {
            return Name + " : " + Amount;
        }
    }
}
