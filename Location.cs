using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faunusVB
{
    public class Location
    {
        public string name;
        public int buildableLand;

        public Location(string name, int buildableLand)
        {
            this.name = name;
            this.buildableLand = buildableLand;
        }
    }
}
