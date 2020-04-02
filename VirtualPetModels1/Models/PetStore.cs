using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class PetStore : Store
    {
        public List<Pet> Pets;

        public PetStore()
        {
            Pets = new List<Pet>();
            this.Initalize();
        }

        public override void Initalize()
        {
            base.Initalize();
            this.initailzePets();
        }

        private void initailzePets()
        {
            Pets = new List<Pet>()
            {
                new Dog("fido", 3),
                new Basenji() { Name = "Cheddar"},
                new Cat() { Name="Bella"}
            };
        }
    }
}