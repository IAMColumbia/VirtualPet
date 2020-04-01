using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Cat : Mammal
    {

        
        
        //Constuctor
        public Cat() : this("fido") //chained to constructor with one argument
        {

        }

        public Cat(string newCatName) : this(newCatName, 1)
        {

        }
        //Default constuctor
        public Cat(string newCatName, int newCatAge)
        {
            this.Name = newCatName;
            this.age = newCatAge;
            this.Weight = 2;

            
            Mammal.MammalCount++;
            //this.CatNum = Mammal.MammalCount;
        }

        

    }
}