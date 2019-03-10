using System;

namespace Profit
{
    class Animal
    {
        private int _id;
        private double _milk;
        private string _type;
        //end of variable declaration

        public int id
        {
            get { return _id;}
            set { _id = value;}
        }

        public double milk
        {
            get {return _milk;}
            set {_milk = value;}
        }

        public string type
        {
            get {return _type;}
            set {_type = value;}
        }//end of getter setter

        public Animal()
        {
            this.id = 0;
            this.milk = 0;
            this.type = "Unknown type";
            
        }//end of default constructor

        public Animal(int id)
        {
            this.id = id;
            this.milk = 0;
            this.type = "Unknown type";
        }//end of partial constructor

        public Animal(int id,string type)
        {
            this.id = id;
            this.milk = 0;
            this.type = type;
        }//end of partial constructor

        public Animal(int id,double milk,string type)
        {
            this.id = id;
            this.milk = milk;
            this.type = type;
        }//end of full constructor
        //end of constructors
    }
}
//Still need to asses which fields belong to which class and how to implement adding each to an array as its allocated datatype
//Fields: id,milk,type,vaccine and maybe profit?