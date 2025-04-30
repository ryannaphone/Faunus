using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faunusVB
{
   
    public class Being
    {
        public string type;
        public string name; // String representing the name of the being
        public List<Location> loc; // Location object array, represents where the being is
        public long age; // Long representing the age in days of the being
        public List<Item> items; // Item object array representing the inventory of the being
        public List<int> amount; // int representing amount of beings in this being (Used for bugs, plants, etc.)

        public int health; // int representing the health amount a being has
        public int energy; // int representing the amount of energy a being has
        public int sanity; // int representing the amount of sanity a being has
        public int hunger; // int representing the amount of hunger a being has
        public int thirst; // int representing the amount of thirst a being has
        public int radtiation; // int representing how irradiated a being is
        public float pH; // float representing the pH of a being

        public int healthMax; // int representing the health amount a being has
        public int energyMax; // int representing the health amount a being has
        public int sanityMax; // int representing the health amount a being has
        public int hungerMax; // int representing the health amount a being has
        public int thirstMax; // int representing the health amount a being has

        public int healthChangePerDay; // int representing how much health stat will change at end of day
        public int energyChangePerDay; // int representing how much energy stat will change at end of day
        public int sanityChangePerDay; // int representing how much sanity stat will change at end of day
        public int hungerChangePerDay; // int representing how much hunger stat will change at end of day
        public int thirstChangePerDay; // int representing how much thirst stat will change at end of day



        public static List<Item> defaultInventory = emptyInventory(); // create an empty item array to serve as default inventory
        public static int defaultAge = 0;
        public static List<int> defaultAmount = new List<int> {1}; // create an int to serve as default amount value
        public static int defaultHealth = 100; // create an int to serve as default health value
        public static int defaultEnergy = 25;
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

        public int level;
        public int intelligenceLvl;
        public int strengthLvl;
        public int staminaLvl;
        public int resilienceLvl;
        public int perceptionLvl;
        public int ingenuityLvl;
        public int composureLvl;

        public int defaultLevel = 1;
        public int defaultIntelligenceLvl = 1;
        public int defaultStrengthLvl = 1;
        public int defaultStaminaLvl = 1;
        public int defaultResilienceLvl = 1;
        public int defaultPerceptionLvl = 1;
        public int defaultIngenuityLvl = 1;
        public int defaultComposureLvl = 1;

        public Being(string type, string name, List<Location> loc)
        {
            this.type = type;
            this.name = name; // Set name of new being to given name
            this.loc = loc; // Set location array of new being to given location array
            this.age = defaultAge; // Set age of new being to given age
            this.items = emptyInventory(); ; // Set item array of new being to given item array
            this.amount = defaultAmount;

            this.health = defaultHealth;
            this.energy = defaultEnergy;
            this.sanity = defaultSanity;
            this.hunger = defaultHunger;
            this.thirst = defaultThirst;

            this.healthMax = defaultHealthMax;
            this.energyMax = defaultEnergyMax;
            this.sanityMax = defaultSanityMax;
            this.hungerMax = defaultHungerMax;
            this.thirstMax = defaultThirstMax;

            this.healthChangePerDay = defaultHealthChangePerDay;
            this.energyChangePerDay = defaultEnergyChangePerDay;
            this.sanityChangePerDay = defaultSanityChangePerDay;
            this.hungerChangePerDay = defaultHungerChangePerDay;
            this.thirstChangePerDay = defaultThirstChangePerDay;

            this.level = defaultLevel;
            this.intelligenceLvl = defaultIntelligenceLvl;
            this.strengthLvl = defaultStrengthLvl;
            this.staminaLvl = defaultStaminaLvl;
            this.resilienceLvl = defaultResilienceLvl;
            this.perceptionLvl = defaultPerceptionLvl;
            this.ingenuityLvl = defaultIngenuityLvl;
            this.composureLvl = defaultComposureLvl;
        }

        public Being(string type, string name, List<Location> loc, long age, List<Item> items, List<int> amount, int health, int energy,
            int sanity, int hunger, int thirst, int healthMax, int energyMax, int sanityMax, int hungerMax,
            int thirstMax, int healthChangePerDay, int energyChangePerDay, int sanityChangePerDay, int hungerChangePerDay,
            int thirstChangePerDay, int level, int intelligenceLvl, int strengthLvl, int staminaLvl, int resilienceLvl,
            int perceptionLvl, int ingenuityLvl, int composureLvl
            ) // All parameter constructor
        {
            this.type = type;
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

            this.level = defaultLevel;
            this.intelligenceLvl = defaultIntelligenceLvl;
            this.strengthLvl = defaultStrengthLvl;
            this.staminaLvl = defaultStaminaLvl;
            this.resilienceLvl = defaultResilienceLvl;
            this.perceptionLvl = defaultPerceptionLvl;
            this.ingenuityLvl = defaultIngenuityLvl;
            this.composureLvl = defaultComposureLvl;

        }

       

        public static List<Item> emptyInventory()
        {
            return new List<Item>() ;
        }

    }
    
    
}
