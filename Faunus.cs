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
        static public int day;
        static public Being player;
        static public Location origin = new Location("Origin", 100);
        static public List<Location> allLocations = new List<Location>(49);
        static public int tabulaLevel = 1;
        static public List<int> inspectCount = new List<int>();
        static public Location currentLocation;

        static public List<int> dirtAmounts = new List<int> {
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 5000, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 0, 0,
        };

        static public List<Item> dirtItem = new List<Item> { new Item("Dirt", 5000) };
        static public Being dirt = new Being("Living Soil", "Dirt", allLocations, 0, dirtItem, dirtAmounts,
            10000, 0, 0, 10000, 10000, 10000, 0, 0, 10000, 100000, 0, 0, 0, -25, -50, 1, 1, 1, 1, 1, 1, 1, 1);

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
            endDay();
        }

        public void newGame()
        {
            day = 1;
            List<Location> playerLoc = new List<Location>();
            playerLoc.Add(origin);
            player = new Being("Player", "You", playerLoc);
            player.items = new List<Item>();
            //addItem(new Item("Goop", 1));
            //addItem(new Item("Mud", 1));
            actionTabControl.TabPages.Remove(tabulaTab);
            actionTabControl.TabPages.Remove(exploreTab);
            actionTabControl.TabPages.Remove(gatherTab);
            tabletPanel.Hide();
            hideButtons();
            displayNews("You see a stone tablet on the ground before you.");
            displayInfo("You appear to be in a large crater.\nThe walls of the crater tower above you.");
            displayDay(day);

            currentLocation = origin;
        }

        public void endDay()
        {
            day++;
            displayDay(day);
        }

        public void addItem(Item i)
        {
            player.items.Add(i);
            inventoryListBox.Items.Add(i.ToString());

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
            if (player.health < 100)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are feeling unwell.";
                }
                else
                {
                    statusText += " You are feeling unwell.";
                }
            }
            if (player.hunger < 25)
            {
                if (statusText.Equals("You are feeling neutral."))
                {
                    statusText = "You are feeling a bit peckish.";
                }
                else
                {
                    statusText += " and a bit peckish.";
                }
            }
            statusLabel.Text = "Status: " + s;
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
            addItem(new Item("Tabula™", 1));
            startPanel.Hide();
            actionTabControl.TabPages.Add(tabulaTab);
            tabletPanel.Show();
            displayNews("You pick up the tablet and see it is covered in buttons. \nIt seems to whir to life.");
            whatIsThisButton.Show();
            actionTabControl.SelectTab(tabulaTab);
            actionTabControl.TabPages.Remove(interactTab);
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
        }

        private void hidePanels()
        {

        }

        private void whatShouldIDoButton_Click(object sender, EventArgs e)
        {
            if (day == 1)
            {
                displayNews("'You should look for sources of hydration and sustenance.'");
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
            displayNews("'I'm unable to access map functions without the appropriate upgrade module. \n However, we appear to be in a crater. Perhaps you could take a look around.'");
            actionTabControl.TabPages.Add(exploreTab);
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

        private List<Being> presentBeings(Location l)
        {
            List<Being> present = new List<Being>();


            return present;
        }

        private Item gather(Being b)
        {
            Item i = new Item("No Item (Error)", 0);
            if (b.name.Equals("Dirt"))
            {
                i = b.items[0];
            }
            return i;
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }
    }
}
