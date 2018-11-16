using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum DragonType { Red = 1, Frost, Elder, Blue, Gold}
    class Dragons
    {
        public DragonType TypeOfDragon { get; set; }
        public bool IsScary { get; set; }
        public int AmountOfGold { get; set; }
        public bool BreathesFire { get; set; }
    }
}
