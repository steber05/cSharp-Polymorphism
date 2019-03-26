using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class Goat : LiveStock
    {
        double milk { get; set; }
        string type { get; set; }
        //end of getter setters
        public Goat(int id, double milk, string type) : base(id)
        {
            this.milk = milk;
            this.type = type;
        }//end of constructor

        public override void calculateProfit()
        {
            Utilities.profit += (milk * Utilities.goatMilkPrice) - (Utilities.goatVacc / 365);
        }//end of overviden calculateProfit
    }
}
