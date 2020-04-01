using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Human : Mammal
    {
        public Human()
        {
            this.Name = "Jeff";
        }

        public void GetADog(Dog d)
        {
            d.Owner = this;
        }
    }
}