using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faunusVB
{
   
    internal class Being
    {
        string name; // String representing the name of the being
        Location[] loc; // Location object array, represents where the being is
        long age; // Long representing the age in days of the being
        Item[] items; // Item object array representing the inventory of the being
        int amount; // int representing amount of beings in this being (Used for bugs)

        int health; // int representing the health amount a being has
        int energy; // int representing the amount of energy a being has
        int sanity; // int representing the amount of sanity a being has
        int hunger; // int representing the amount of hunger a being has
        int thirst; // int representing the amount of thirst a being has

        int healthMax; // int representing the health amount a being has
        int energyMax; // int representing the health amount a being has
        int sanityMax; // int representing the health amount a being has
        int hungerMax; // int representing the health amount a being has
        int thirstMax; // int representing the health amount a being has

        int healthChangePerDay;
        int energyChangePerDay;
        int sanityChangePerDay;
        int hungerChangePerDay;
        int thirstChangePerDay;

        

        static Item[] defaultInventory = emptyInventory();
        static int defaultAmount = 1;
        static int defaultHealth = 100;
        static int defaultEnergy = 25;
        static int defaultSanity = 100;
        static int defaultHunger = 0;
        static int defaultThirst = 0;
        static int defaultHealthMax = defaultHealth;
        static int defaultEnergyMax = defaultEnergy;
        static int defaultSanityMax = defaultSanity;
        static int defaultHungerMax = defaultHunger;
        static int defaultThirstMax = defaultThirst;
        static int defaultHealthChangePerDay = 0;
        static int defaultEnergyChangePerDay = 0;
        static int defaultSanityChangePerDay = 0;
        static int defaultHungerChangePerDay = 0;
        static int defaultThirstChangePerDay = 0;
        
  

        public Being(string name, Location[] loc)
        {
            this(name, loc, 0, emptyInventory(), defaultInventory, defaultAmount, defaultHealth, defaultEnergy,
                defaultSanity, defaultHunger, defaultThirst, defaultHealthMax, 100, );
        }

        public Being(string name, Location[] loc, long age, Item[] items, int amount, int health, int energy,
            int sanity, int hunger, int thirst, int healthMax, int energyMax, int sanityMax, int hungerMax,
            int thirstMax, int healthChangePerDay, int energyChangePerDay, int sanityChangePerDay, int hungerChangePerDay,
            int thirstChangePerDay
            ) // All parameter constructor
        {
            this.name = name; // Set name of new being to given name
            this.loc = loc; // Set location array of new being to given location array
            this.age = age; // Set age of new being to given age
            this.items = items; // Set item array of new being to given item array
            this.amount = amount;

            this.health = health;
            this.energy = energy;
            this.sanity = sanity;
            this.hunger = hunger;
            this.thirst = thirst;

            this.healthMax = healthMax; 
            this.energyMax = energyMax;
            this.sanityMax = sanityMax;
            this.hungerMax = hungerMax;
            this.thirstMax = thirstMax;

            this.healthChangePerDay = healthChangePerDay;
            this.energyChangePerDay = energyChangePerDay;
            this.sanityChangePerDay = sanityChangePerDay;
            this.hungerChangePerDay = hungerChangePerDay;
            this.thirstChangePerDay = thirstChangePerDay;


        }


    }

    internal class Player : Being
    {
        int intelligenceLvl;
        int strengthLvl;
        int staminaLvl;
        int resilienceLvl;
        int perceptionLvl;
        int ingenuityLvl;
        int composureLvl;

    }

    Item[] emptyInventory()
    {
        return new Item[0];
    }
}
