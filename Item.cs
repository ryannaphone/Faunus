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

        public Item(string name, int amount)
        {
            this.Name = name;
            this.Amount = amount;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }

        override public string ToString()
        {
            return Name + " : " + Amount;
        }
    }
}
