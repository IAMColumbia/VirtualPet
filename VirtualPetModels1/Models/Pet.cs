using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public abstract class Pet
    {
        public int Happiness;
        public int Weight;
        protected int age;

        List<Toy> Toys;
        Toy CurrentToy;

        public string Name;

        public Pet()
        {
            this.CurrentToy = new Ball(); //Sets the deault toy
            this.Toys = new List<Toy>();    //initialize the list of toys
            this.Toys.Add(CurrentToy);  //add default to to list

        }

        public void GiveToy(Toy t)
        {
            this.CurrentToy = t; //replcedcurrent toy
            this.Toys.Add(t);   //Add the toy to the list 
        }

        public void NextToy()
        {
            //TODO
        }

        public string PlayToys()
        {
            this.Happiness += this.CurrentToy.HappyPower;

            return $"{this.Name} plays with {this.CurrentToy.Name}";
        }

        public virtual string About()
        {
            string s = string.Empty;
            s += $"Hello my name is {this.Name} I'm {this.age} and I weigh";
            s += $"{this.Weight}.";

            return s;
        }
    }
}