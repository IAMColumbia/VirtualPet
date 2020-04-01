using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SparkelyBall : Ball
    {
        

        public SparkelyBall()
        {
            this.HappyPower = 5;
            this.Name = "sparkely " + this.Name;
        }

    }
}