using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class JerseyCow : Cow
    {
        public JerseyCow(int id, double milk, string type) :base(id, milk, type)
        {
        }//end of constructor
        public override void calculateProfit()
        {
            Utilities.profit += (milk * Utilities.cowMilkPrice) - Utilities.jCowVacc;
            base.calculateProfit();
        }//end of overriden calculateProfit
    }
}
