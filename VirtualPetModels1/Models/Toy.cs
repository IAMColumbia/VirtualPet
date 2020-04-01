using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public abstract class Toy
    {
        public string Name;
        protected string Material;

        public int HappyPower;

        public Toy()
        {
            this.Name = "Not a real toy";
            this.Material = "Some Material";
            this.HappyPower = 1;
        }

        public virtual string About()
        {
            return $"{this.Name} is made of {this.Material} and has HP of {this.HappyPower}";
        }
    }
}