using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SqueakyBall : Ball
    {
        public SqueakyBall()
        {
            this.HappyPower = 15;
            this.Name = "squeaky " + this.Name;
        }
    }
}