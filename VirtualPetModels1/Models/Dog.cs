using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dog : Mammal
    {
        //Properties
       
        public string BarkSound;

        public int BarkCount;
        public int DogNum;

        //Containment
        public Human Owner;


        //Constuctor
        public Dog() : this("fido") { }//chained to constructor with one argument


        public Dog(string newDogName) : this(newDogName, 1) { }
        
        //Default constuctor
        public Dog(string newDogName, int newDogAge)
        {
            
            this.Name = newDogName;
            this.age = newDogAge;
            this.Weight = 2;
            this.BarkSound = "Woof!";
            //the default Owner is Jeff just because thats the way it is.... JM2019
            this.Owner = new Human();

            Mammal.MammalCount++;
            this.DogNum = Mammal.MammalCount;
        }


        /// <summary>
        /// Barks the dog 1 time
        /// </summary>
        /// <returns></returns>
        public virtual string Bark()
        {
            this.BarkCount++;
            return this.BarkSound + $" {this.Owner.Name} say be quiet"; //TODO make some sound
        }

        /// <summary>
        /// Bark the dog multiple times
        /// </summary>
        /// <param name="HowManyTimes">how mant times to bark the dog</param>
        /// <returns></returns>
        public string Bark(int HowManyTimes)
        {
            string barkSting = string.Empty;
            for (int i = 0; i < HowManyTimes; i++)
            {
                barkSting += this.Bark();
            }
            return barkSting;
        }

        public override string About()
        {
            string DogAbout =  base.About();
            DogAbout += $"My Bark sounds like {this.Bark()}";
            DogAbout +=$"I've Barked {this.BarkCount} times";

            return DogAbout;
        }

        public void Relieve(Hydrant h)
        {
            h.IsClean = false;
            this.BladderHydrationLevel = 0;
        }


    }
}
