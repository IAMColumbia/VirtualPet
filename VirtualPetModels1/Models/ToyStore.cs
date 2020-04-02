using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ToyStore : Store
    {

        public List<Toy> Toys;

        public ToyStore()
        {
            Toys = new List<Toy>();
            this.Initalize();
        }

        public override void Initalize()
        {
            base.Initalize();
            this.initializeToys();
        }

        private void initializeToys()
        {
            Toys = new List<Toy>()
            {
                new SparkelyBall(),
                new SqueakyBall(),
                new DeadRat()
            };
        }
    }
}