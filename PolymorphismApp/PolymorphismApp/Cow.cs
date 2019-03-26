using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Cow : LiveStock
    {
        public double milk { get; set; }
        string type { get; set; }
        //end of getter setters
        public Cow(int id, double milk, string type) :base(id)
        {
            this.milk = milk;
            this.type = type;
        }//end of constructor

        public override void calculateProfit()
        {
            Utilities.profit += (milk * Utilities.cowMilkPrice) - (Utilities.cowVacc / 365);
        }//end of overriden calculateProfit
    }
}
