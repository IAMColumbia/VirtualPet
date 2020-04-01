using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class DeadRat : Toy
    {
        bool isDead;

        public DeadRat()
        {
            this.Name = "Rat";
            this.HappyPower = 2;
            this.isDead = true ;
        }

        public string getDeadString()
        {
            if(this.isDead)
            {
                return "dead";
            }
            return "not dead";
        }

        public override string About()
        {
            return base.About() + " and is " + this.getDeadString();
        }
    }
}