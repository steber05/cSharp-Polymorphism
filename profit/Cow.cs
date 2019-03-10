using System;

namespace Profit
{
    class Cow : Animal
    {
        private double _vaccine = 28.5;
        //End of variable declaration

        public double vaccine
        {
            get { return _vaccine;}
            set { _vaccine = value;}
        }//end of getter setters

        public Cow(int id, string type) : base(id)
        {      
            this.type = "cow";
        }//end of partial constructor

        public Cow(int id, double milk, string type) : base(id, milk, type)  
        {  
            this.type = "cow";
        }//End of full constructor
        //end of constuctors

        public void vaccineInfo()
        {
            double profit = milk-vaccine;
        }//End of vaccineInfo
    }
}