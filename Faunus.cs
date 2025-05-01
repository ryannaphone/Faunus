using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace faunusVB


{

    public partial class Faunus : Form
    {
        Random rand = new Random();
        static public int day;
        static public Being player;
        static public Location origin = new Location("Origin", 100);
        static public List<Location> allLocations = new List<Location>(49);
        static public int tabulaLevel = 1;
        static public List<int> inspectCount = new List<int>();
        static public Location currentLocation;
        static public int locationIndex;
        static public int inventoryMax;

        static public int whatCanIEatCounter = 0;
        static public int whereAmICounter = 0;

        static public Boolean ableToLeaveCrater;

        static public List<Being> corpses = new List<Being>();

        static public Item[] tabulaUpgradeModules = { new Item("Tabula™ GPS Module", 1) };

        static public List<int> dirtAmounts = new List<int> {
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
        };

        static public List<Item> dirtItems = new List<Item> {
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
            new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1), new Item("Dirt", 5000, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1),
        };

        static public Being dirt = new Being("Living Soil", "Dirt", allLocations, 0, dirtItems, dirtAmounts,
            10000, 0, 0, 10000, 10000, 10000, 0, 0, 10000, 100000, 0, 0, 0, -25, -50, 1, 1, 1, 1, 1, 1, 1, 1);


        static public List<int> grubAmounts = new List<int> {
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
            5000, 5000, 5000, 5000, 5000, 5000, 5000,
        };

        static public List<Item> grubItems = new List<Item> {
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
            new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0), new Item("Grubs", 5000, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0),
        };
        static public Being grub = new Being("Insect", "Grubs", allLocations, 0, grubItems, grubAmounts,
            8500, 1500, 0, 5000, 5000, 8500, 1500, 0, 5000, 5000, 0, 500, 0, -250, -300, 1, 1, 1, 1, 1, 1, 1, 1);


        public Faunus()
        {
            InitializeComponent();
        }

        public void Faunus_Load(object sender, EventArgs e)
        {
            newGame();
        }

        public void Faunus_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void label4_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (player.energy > 2)
            {
                //int promptValue = Prompt.ShowDialog("Test", "123");
            }
            endDay();
        }

        public void newGame()
        {
            day = 1;
            List<Location> playerLoc = new List<Location>();
            playerLoc.Add(origin);
            player = new Being("Player", "You", playerLoc, 0, new List<Item>(), new List<int> { 1 }, 100, 25, 100, 25, 25, 100,
                25, 100, 25, 25, 0, 15, -1, -5, -7, 1, 1, 1, 1, 1, 1, 1, 1);
            player.items = new List<Item>();
            inventoryMax = 50;
            //addItem(new Item("Goop", 1));
            //addItem(new Item("Mud", 1));
            actionTabControl.TabPages.Remove(tabulaTab);
            actionTabControl.TabPages.Remove(exploreTab);
            actionTabControl.TabPages.Remove(gatherTab);
            actionTabControl.TabPages.Remove(itemsTab);

            hideButtons();
            hidePanels();
            displayNews("You see a stone tablet on the ground before you.");
            displayInfo("You appear to be in a large crater.\nThe walls of the crater tower above you.");
            displayDay(day);
            displayInventoryCapacity();
            displayInventory();
            displayStatus(" You are confused.");

            currentLocation = origin;
            locationIndex = 24;


        }

        public void endDay()
        {
            day++;
            displayDay(day);
        }

        public void addItem(Item i)
        {
            if (totalInventoryAmount() == 0)
            {
                actionTabControl.TabPages.Add(itemsTab);
                dropPanel.Show();
            }

            if (totalConsumableItems(player.items) == 0 && i.consumable)
            {
                consumePanel.Show();
            }

            player.items.Add(i);
            inventoryListBox.Items.Add(i.ToString());



            updateItemsTab();

        }

        public void removeItem(Item i)
        {
            player.items.Remove(i);
            if (i.name.Equals("Tabula™"))
            {
                removeTabula();
            }
            if (player.items.Count == 0)
            {
                actionTabControl.TabPages.Remove(itemsTab);
            }
        }

        public void displayNews(string s)
        {
            newsLabel.Text = "News: " + s;
        }

        public void displayInfo(string s)
        {
            infoLabel.Text = "Info: " + s;
        }

        public void displayStatus(string s)
        {
            string statusText = "You are feeling neutral.";
            if (player.health == player.healthMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are feeling healthy.";
                }
                else
                {
                    statusText += " And you are feeling healthy.";
                }
            }
            else if (player.health < player.healthMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are feeling a bit unwell.";
                }
                else
                {
                    statusText += " And you are feeling a bit unwell.";
                }
            }
            else if (player.health < player.healthMax / 2)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel very unwell.";
                }
                else
                {
                    statusText += " And you feel very unwell.";
                }
            }
            else if (player.health < 15)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel lifeless.";
                }
                else
                {
                    statusText += " And you feel lifeless.";
                }
            }
            if (player.hunger == player.hungerMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel full.";
                }
                else
                {
                    statusText += " You feel full.";
                }
            }
            else if (player.hunger < player.hungerMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel a bit peckish.";
                }
                else
                {
                    statusText += " You feel peckish.";
                }
            }
            else if (player.hunger < player.hungerMax / 2)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are very hungry.";
                }
                else
                {
                    statusText += " You are very hungry.";
                }
            }
            else if (player.hunger < 10)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are famished.";
                }
                else
                {
                    statusText += " And you are famished.";
                }
            }
            else if (player.hunger == 0)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are starving.";
                }
                else
                {
                    statusText += " You are starving.";
                }
            }
            if (player.energy == player.energyMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel rested.";
                }
                else
                {
                    statusText += " You feel rested.";
                }
            }

            else if (player.energy < player.energyMax / 2)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are a bit tired.";
                }
                else
                {
                    statusText += " You are a bit tired.";
                }
            }
            else if (player.energy < 10)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are fatigued";
                }
                else
                {
                    statusText += " You are fatigued.";
                }
            }
            else if (player.energy == 0)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are exhausted";
                }
                else
                {
                    statusText += " You are exhausted.";
                }
            }
            statusText += "\n";
            if (player.thirst == player.thirstMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are fully hydrated.";
                }
                else
                {
                    statusText += " You are fully hydrated.";
                }
            }
            else if (player.thirst < player.thirstMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel a bit thirsty.";
                }
                else
                {
                    statusText += " You feel a bit thirsty.";
                }
            }
            else if (player.thirst < player.thirstMax / 2)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel parched.";
                }
                else
                {
                    statusText += " You feel parched.";
                }
            }
            else if (player.thirst < 10)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are very thirsty.";
                }
                else
                {
                    statusText += " You are very thirsty.";
                }
            }
            else if (player.thirst == 0)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are dehydrated.";
                }
                else
                {
                    statusText += " You are dehydrated.";
                }
            }
            if (player.sanity == player.sanityMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel confident";
                }
                else
                {
                    statusText += " You feel confident.";
                }
            }
            else if (player.sanity < player.sanityMax)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel a bit uneasy.";
                }
                else
                {
                    statusText += " You feel a bit uneasy.";
                }
            }
            else if (player.sanity < player.sanityMax / 2)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel anxious.";
                }
                else
                {
                    statusText += " You feel nxious.";
                }
            }
            else if (player.sanity < 10)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You feel despair.";
                }
                else
                {
                    statusText += " You feel despair.";
                }
            }
            else if (player.sanity == 0)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are at the breaking point.";
                }
                else
                {
                    statusText += " You are at the breaking point.";
                }
            }
            statusLabel.Text = "Status: " + statusText + s;
        }

        public void displayDay(int i)
        {
            dayLabel.Text = "Day #" + i;
        }

        public void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            Console.Write(inventoryListBox.SelectedIndex);
            int i = inventoryListBox.SelectedIndex;
            string nme = player.items[i].name;
            int amnt = player.items[i].amount;
            string s = "You have " + amnt + " " + nme + ".";
            if (nme.Equals("Goop"))
            {
                s += "\n'A multipurpose black syrup. \n" +
                    "Mixing it with other materials may increase its utility.\n" +
                    "Can be consumed, though it is likely toxic.'";

            }
            else if (nme.Equals("Dirt"))
            {

            }
            else if (nme.Equals("Tabula™"))
            {
                s = "'My name is Tabula™ and I am here to guide you.\nPress my buttons to ask me questions.'";
            }
            displayInfo(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actionTabControl.TabPages.Add(tabulaTab);
            addItem(new Item("Tabula™", 1, false, false, 2, 0, 0));
            startPanel.Hide();

            tabletPanel.Show();
            displayNews("You pick up the tablet and see it is covered in buttons. \nIt seems to whir to life.");
            whatIsThisButton.Show();
            actionTabControl.SelectTab(tabulaTab);
            actionTabControl.TabPages.Remove(interactTab);
            dropPanel.Show();

            displayInventory();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void whatIsThisButton_Click(object sender, EventArgs e)
        {
            displayNews("'My name is Tabula™ and I am here to guide you.\nPress my buttons to ask me questions.'");
            whatCanYouDoButton.Show();
            whatShouldIDoButton.Show();
            whereAmIButton.Show();
        }

        private void hideButtons()
        {
            whatCanYouDoButton.Hide();
            whatIsThisButton.Hide();
            whereShouldIGoButton.Hide();
            whereAmIButton.Hide();
            whereIsTheNearestStoreButton.Hide();
            howCanIUpgradeYouButton.Hide();
            whatShouldIDoButton.Hide();
            whatCanIEatButton.Hide();


            gatherGrubButton.Hide();
            gatherDirtButton.Hide();

            combineAmountComboBox3.Hide();
            combineComboBox3.Hide();
            combineAndLabel.Hide();
        }

        private void hidePanels()
        {
            dropPanel.Hide();
            consumePanel.Hide();
            combinePanel.Hide();
            tabletPanel.Hide();
        }

        private void whatShouldIDoButton_Click(object sender, EventArgs e)
        {
            if (day == 1)
            {
                displayNews("'You should look for sources of hydration and sustenance.'");
                whatCanIEatButton.Show();
            }
        }

        private void whatCanYouDoButton_Click(object sender, EventArgs e)
        {
            if (tabulaLevel == 1)
            {
                displayNews("'Without any upgrades, I am only capable of giving advice.\nWith upgrades, I could give you more detailed information.'");
                howCanIUpgradeYouButton.Show();
            }
        }

        private void howCanIUpgradeYouButton_Click(object sender, EventArgs e)
        {
            displayNews("'You will need to obtain Tabula™ upgrade modules.\nThese can be purchased from any certified Tabula™ retailer.'");
        }

        private void whereAmIButton_Click(object sender, EventArgs e)
        {
            whereAmICounter++;
            displayNews("'I'm unable to access map functions without the appropriate upgrade module. \n However, we appear to be in a crater. Perhaps you could take a look around.'");
            if (whereAmICounter == 1) actionTabControl.TabPages.Add(exploreTab);
        }

        private void inspectNearby_Click(object sender, EventArgs e)
        {
            if (currentLocation.name.Equals("Origin"))
            {
                if (player.energy > 2)
                {
                    if (inspectCount.Count == 0)
                    {
                        inspectCount.Add(1);
                    }
                    else
                    {
                        inspectCount[0] = inspectCount[0] + 1;
                    }
                    player.energy = player.energy - 3;

                    displayStatus("");
                }
                else
                {
                    displayNews("You do not have enough energy to explore nearby.");
                }
            }
        }



        private void gather(Being b)
        {
            if (totalInventoryAmount() < inventoryMax)
            {
                int gatherAmount = 0;


                Item i = new Item("No Item (Error)", 0);
                if (b.name.Equals("Dirt"))
                {
                    if (itemsContains(player.items, dirtItems[locationIndex]) != -1)
                    {
                        gatherAmount = 1;
                        player.items[itemsContains(player.items, dirtItems[locationIndex])].amount = player.items[itemsContains(player.items, dirtItems[locationIndex])].amount + 1;
                        dirtItems[locationIndex].amount = dirtItems[locationIndex].amount - gatherAmount;
                        i = dirtItems[locationIndex];
                    }
                    else
                    {
                        gatherAmount = 1;
                        addItem(new Item("Dirt", gatherAmount, true, true, 1.2, 0, 1, -1, 1, 0, -2, 0, -3, -1, -2, 2, 1));
                        dirtItems[0].amount = dirtItems[locationIndex].amount - gatherAmount;
                        i = dirtItems[locationIndex];
                    }
                }
                else if (b.name.Equals("Grubs"))
                {
                    if (itemsContains(player.items, grubItems[locationIndex]) != -1)
                    {
                        gatherAmount = 1;
                        player.items[itemsContains(player.items, grubItems[locationIndex])].amount = player.items[itemsContains(player.items, grubItems[locationIndex])].amount + 1;
                        grubItems[locationIndex].amount = grubItems[locationIndex].amount - gatherAmount;
                        i = grubItems[locationIndex];
                    }
                    else
                    {
                        gatherAmount = 1;
                        addItem(new Item("Grubs", gatherAmount, true, true, 0.2, 1, 2, 1, 1, 0, 0, 0, 0, 0, -2, 2, 0));
                        grubItems[0].amount = grubItems[locationIndex].amount - gatherAmount;
                        i = grubItems[locationIndex];
                    }
                }
                displayNews("You gathered " + gatherAmount + " " + i.name);
            }
            else
            {
                displayNews("You cannot carry any more.");
            }
            displayInventory();
            checkInventoryWeight();

        }

        private void gatherDirtButton_Click(object sender, EventArgs e)
        {
            gather(dirt);
            if (rand.NextInt64(1, 50) == 25)
            {
                displayNews("'Those look like grub there, you can eat those.");
                gatherGrubButton.Show();
            }
        }

        private void whereIsTheNearestStoreButton_Click(object sender, EventArgs e)
        {
            if (itemsContains(player.items, tabulaUpgradeModules[0]) != -1)
            {
                displayNews("'");
            }
            else
            {

            }
        }



        private void whatCanIEatButton_Click(object sender, EventArgs e)
        {
            whatCanIEatCounter++;
            displayNews("'Perhaps digging around for some bugs may be a good option.'");

            if (whatCanIEatCounter == 1)
            {
                actionTabControl.TabPages.Add(gatherTab);
                gatherDirtButton.Show();
            }
        }

        private void discardNumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Item combine2Items(Item i1, int amount1, Item i2, int amount2)
        {
            Item returnItem = new Item("No item resulted.", 0);

            return returnItem;
        }

        private Item combine3Items(Item i1, int amount1, Item i2, int amount2, Item i3, int amount3)
        {
            Item returnItem = new Item("No item resulted.", 0);

            return returnItem;
        }

        private void consumeAnItem(Item i, int amount)
        {
            if (itemsContains(player.items, i) != -1)
            {
                if (player.items[itemsContains(player.items, i)].amount > amount)
                {
                    int healthAmount = (int)rand.NextInt64(i.healthChangeMin, i.healthChangeMax);
                    if (player.health + healthAmount > player.healthMax) healthAmount = player.healthMax - player.health;
                    player.health = player.health + healthAmount;
                    int hungerAmount = (int)rand.NextInt64(i.hungerChangeMin, i.hungerChangeMax);
                    if (player.hunger + hungerAmount > player.hungerMax) hungerAmount = player.hungerMax - player.hunger;
                    if (player.health - healthAmount < 0 && amount < 0) healthAmount = player.health;
                    player.hunger = player.hunger + hungerAmount;
                    int thirstAmount = (int)rand.NextInt64(i.thirstChangeMin, i.thirstChangeMax);
                    if (player.thirst + thirstAmount > player.thirstMax) thirstAmount = player.thirstMax - player.thirst;
                    if (player.thirst - thirstAmount < 0 && amount < 0) thirstAmount = player.thirst;
                    player.thirst = player.thirst + thirstAmount;
                    int energyAmount = (int)rand.NextInt64(i.energyChangeMin, i.energyChangeMax);
                    if (player.energy + energyAmount > player.energyMax) energyAmount = player.energyMax - player.energy;
                    if (player.energy - energyAmount < 0 && amount < 0) energyAmount = player.energy;
                    player.energy = player.energy + energyAmount;
                    int sanityAmount = (int)rand.NextInt64(i.sanityChangeMin, i.sanityChangeMax);
                    if (player.sanity + sanityAmount > player.sanityMax && amount > 0) sanityAmount = player.sanityMax - player.sanity;
                    if (player.sanity - sanityAmount < 0 && amount < 0) sanityAmount = player.sanity;
                    player.sanity = player.sanity + sanityAmount;

                    player.items[itemsContains(player.items, i)].amount -= amount;

                    displayNews("You consumed " + amount + " " + i.name + ".");

                }
                else if (player.items[itemsContains(player.items, i)].amount == amount)
                {
                    int healthAmount = (int)rand.NextInt64(i.healthChangeMin, i.healthChangeMax);
                    player.health = player.health + healthAmount;
                    int hungerAmount = (int)rand.NextInt64(i.hungerChangeMin, i.hungerChangeMax);
                    player.hunger = player.hunger + hungerAmount;
                    int thirstAmount = (int)rand.NextInt64(i.thirstChangeMin, i.thirstChangeMax);
                    player.thirst = player.thirst + thirstAmount;
                    int energyAmount = (int)rand.NextInt64(i.energyChangeMin, i.energyChangeMax);
                    player.energy = player.energy + energyAmount;
                    int sanityAmount = (int)rand.NextInt64(i.sanityChangeMin, i.sanityChangeMax);
                    player.sanity = player.sanity + sanityAmount;

                    removeItem(player.items[itemsContains(player.items, i)]);

                    displayNews("You consumed " + amount + " " + i.name + ".");
                }
                else
                {
                    displayNews("You do not have enough " + i.name + " to consume " + amount);
                }
            }
            else
            {
                displayNews("You do not have enough " + i.name + " to consume " + amount);
            }
            displayStatus("");
            displayInventory();
        }

        private void dropAnItem(Item i, int amount)
        {
            int itemIndex = -1;
            if (itemsContains(player.items, i) != -1)
            {
                for (int index = 0; index < player.items.Count; index++)
                {
                    if (player.items[index].name.Equals(i.name))
                    {
                        itemIndex = index;
                    }
                }
                if (amount < player.items[itemIndex].amount && itemIndex != -1)
                {
                    player.items[itemIndex].amount = player.items[itemIndex].amount - amount;
                }
                else if (amount == player.items[itemIndex].amount && itemIndex != -1)
                {
                    removeItem(player.items[itemIndex]);
                }
                else
                {
                    displayNews("You do not have enough " + i.name + " to drop " + amount + ".");
                }

                displayInventory();

                if (i.name.Equals("Dirt"))
                {
                    dirtItems[locationIndex].amount += amount;
                }
            }
            else
            {
                displayNews("'You do not have this item.");
            }


        }

        private void updateItemsTab()
        {
            discardItemComboBox.Items.Clear();
            consumeItemComboBox.Items.Clear();
            combineComboBox1.Items.Clear();
            combineComboBox2.Items.Clear();
            combineComboBox3.Items.Clear();

            for (int i = 0; i < player.items.Count; i++)
            {

                discardItemComboBox.Items.Add(player.items[i].name);
                if (player.items[i].consumable) consumeItemComboBox.Items.Add(player.items[i].name);
                if (player.items[i].combinable) combineComboBox1.Items.Add(player.items[i].name);
                if (player.items[i].combinable) combineComboBox2.Items.Add(player.items[i].name);
                if (player.items[i].combinable) combineComboBox3.Items.Add(player.items[i].name);
            }



        }

        private void threeItemsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (threeItemsCheckBox.Checked)
            {
                combineAmountComboBox3.Show();
                combineComboBox3.Show();
                combineAndLabel.Show();
                twoItemsCheckBox.Checked = false;
            }
            else
            {
                combineAmountComboBox3.Hide();
                combineComboBox3.Hide();
                combineAndLabel.Hide();
            }

        }

        private void twoItemsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (twoItemsCheckBox.Checked)
            {

                combineAmountComboBox3.Hide();
                combineComboBox3.Hide();
                combineAndLabel.Hide();
                threeItemsCheckBox.Checked = false;
            }
            else
            {
                combineAmountComboBox3.Show();
                combineComboBox3.Show();
                combineAndLabel.Show();
            }
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < player.items.Count; i++)
            {
                if (player.items[i].name.Equals(discardItemComboBox.Text))
                {
                    if (discardNumComboBox.Text.Equals(null))
                    {

                    }
                    else
                    {
                        index = i;
                        int discardNum = -1;
                        bool f = Int32.TryParse(discardNumComboBox.Text, out discardNum);
                        dropAnItem(player.items[i], discardNum);
                    }
                }
            }
            if (index == -1)
            {
                displayNews("You have no " + discardItemComboBox.Text + " to drop.");
            }
        }

        private void removeTabula()
        {
            actionTabControl.TabPages.Remove(tabulaTab);
            actionTabControl.TabPages.Add(interactTab);
            actionTabControl.TabPages.Remove(exploreTab);
            startPanel.Show();
            tabletPanel.Hide();
            pickUpTabulaButton.Text = "Pick up Tabula™";
            pickUpTabulaButton.Refresh();
        }

        private void addTabula()
        {

        }

        private void displayInventory()
        {
            inventoryListBox.Items.Clear();
            for (int it = 0; it < player.items.Count; it++)
            {
                inventoryListBox.Items.Add(player.items[it].ToString());

            }
            inventoryListBox.Update();
            displayInventoryCapacity();
        }






        private void displayInventoryCapacity()
        {
            inventoryLabel.Text = "Inventory ----- Capacity " + totalInventoryWeight() + "/" + inventoryMax;
        }

        private void gatherGrubButton_Click(object sender, EventArgs e)
        {
            gather(grub);
        }



        private void consumeButton_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < player.items.Count; i++)
            {
                if (player.items[i].name.Equals(consumeItemComboBox.Text))
                {
                    index = i; break;
                }
            }
            if (index != -1)
            {
                int consumeNum = -1;
                if (Int32.TryParse(consumeNumComboBox.Text, out consumeNum))
                {
                    consumeAnItem(player.items[index], consumeNum);
                }
            } else
            {
                displayNews("You have no " + consumeItemComboBox.Text + " to consume.");
            }
        }

        // Utilty methods
        private int itemsContains(List<Item> items, Item itemToFind) // Returns the index of a given item in a given item list as an int
        {
            for (int i = 0; i < items.Count; i++) // go through each of the items in the list
            {
                if (items[i].name.Equals(itemToFind.name)) // if this item (items[i]) has the same name as the item we are looking for
                {
                    return i; // return the index of this item
                }
            }
            return -1; // return -1 if the item is not found
        }

        private int totalConsumableItems(List<Item> items) // Returns an int representing the total consumable items in a given item list
        {
            int amount = 0; // set starting total amount to 0
            for (int i = 0; i < items.Count; ++i) // go through each item in the list
            {
                if (items[i].consumable) // if this item (items[i]) is consumable
                {
                    amount += items[i].amount; // add the amount of this item to our total amount
                }
            }
            return amount; // return the total amount
        }

        private int totalInventoryAmount()
        {
            int amount = 0;
            for (int i = 0; i < player.items.Count; i++)
            {
                amount = amount + player.items[i].amount;
            }

            return amount;
        }

        private int totalInventoryWeight()
        {
            double amount = 0;
            for (int i = 0; i < player.items.Count; i++)
            {
                amount = amount + (player.items[i].amount * player.items[i].weight);
            }
            int amnt;
            amnt = (int)Convert.ToInt64(amount);
            return amnt;
        }

        private void checkInventoryWeight() // method to evaulate player total weight
        {
            if (totalInventoryWeight() > inventoryMax / 2) // if total weight is over half of the max
            {
                player.energyChangePerDay -= 5; // lose five more energy per day
                displayStatus("You are carrying a lot."); // add to status regarding encumberance
            }
            else if (totalInventoryWeight() > inventoryMax - 10) // if total weight is less than 10 from full
            {
                player.energyChangePerDay -= 10; // lose 10 more energy per day
                displayStatus("You are feeling overencumbered."); // add to status regarding encumberance
            }
        }

        private List<Being> presentBeings(Location l)
        {
            List<Being> present = new List<Being>();


            return present;
        }

        private void consumeItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
