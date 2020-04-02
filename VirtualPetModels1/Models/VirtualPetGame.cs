using System;
using System.Collections.Generic;
using VirtualPetModels1;

namespace Models
{
    //Least accessibilty principal
    class VirtualPetGame : Game
    { 
        Player player;
        ToyStore toyStore;
        PetStore petStore;
        
        public VirtualPetGame()
        {
            player = new Player();
            SetupGame();
        }

        //Single resposibilty principal
        /// <summary>
        /// Sets up collections for the game
        /// </summary>
        public override void SetupGame()
        {
            toyStore = new ToyStore();
            petStore = new PetStore();
            
        }

        /// <summary>
        /// Starts game 
        /// 1. Setup Player
        /// 2. Setup Pet
        /// 3. Play the game
        /// </summary>
        public override void Start()
        {
            Console.WriteLine(ShowBanner());  //fancy banner for game
            SetupPlayer();
            SetPlayerPet();
            PlayVirtualPet();
            Console.WriteLine("Bye");
            Console.ReadKey();
        }

        public void SetupPlayer()
        {
            Console.Write("What is your name?");
            player.Name = Console.ReadLine();
        }

        public void SetPlayerPet()
        {
            Console.WriteLine("Choose a pet:");
            foreach (Pet p in petStore.Pets)
            {
                Console.WriteLine($"{petStore.Pets.IndexOf(p) + 1}\t{p.ToString().Replace("ConsoleApp3DogInClass.", "")}\tNamed:{p.Name}");
            }
            string whatTheyTyped = Console.ReadLine();
            int index = 0;
            int.TryParse(whatTheyTyped, out index);
            try
            {
                player.MyPet = petStore.Pets[index - 1];
            }
            catch (Exception ex)
            {
                //Log Exception to console
                Console.WriteLine(ex.ToString());
                Console.WriteLine("that is not an option");
                SetPlayerPet();
            }
        }

        public void PlayVirtualPet()
        {
            isPlaying = true;

            while(isPlaying)
            {
                //Main user interaction loop ie Main Game Loop
                Console.WriteLine("What wood you like to do?");
                string option = Console.ReadLine();
                switch(option.ToLower())
                {
                    case "cp":
                    case "choose pet":
                        SetPlayerPet();
                        break;
                    case "np":
                    case "name pet":
                        SetPetName();
                        break;
                    case "a":
                    case "about pet":
                        AboutPet();
                        break;
                    case "pt":
                    case "play toys":
                        PlayToys();
                        break;
                    case "ct":
                    case "choose toy":
                        player.MyPet.GiveToy(GetConsoleToy());
                        break;
                    case "q":
                    case "quit":
                        isPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Sorry I didn't quite understand that!");
                        //TODO show options
                        Console.WriteLine(ShowChoiceOptions()); 
                        break;

                }
            }
        }

        /// <summary>
        /// Sorry about this method I'm out of time
        /// </summary>
        /// <returns></returns>
        public string ShowChoiceOptions()
        {
            //this should be another class of choices or some data array please fix this late JM20190225
            string options = $"(q) quit\n";
            options += $"(cp) choose pet\n";
            options += $"(ct) choose toy\n";
            options += $"(pt) play toy\n";
            return options;
        }

        private Toy GetConsoleToy()
        {
            Console.WriteLine("Please Choose a new toy:");
            foreach (Toy t in toyStore.Toys)
            {
                Console.WriteLine($"{toyStore.Toys.IndexOf(t) + 1}\t{t.ToString().Replace("ConsoleApp3DogInClass.", "")}\tNamed:{t.Name}");

            }
            string whatTheyTyped = Console.ReadLine();
            int index = 0;
            int.TryParse(whatTheyTyped, out index);
            Toy toy = new SparkelyBall() ;
            try
            {
                toy = toyStore.Toys[index - 1];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); //log error to console
                Console.WriteLine("that is not an option");
                GetConsoleToy();
            }
            return toy;
        }

        public void SetPetName()
        {
            //Set pet name
        }

        public void PlayToys()
        {
            Console.WriteLine(player.MyPet.PlayToys());

        }


        public void AboutPet()
        {
            Console.WriteLine(player.MyPet.About());
        }

        private string ShowBanner()
        {
            string s = "Wlecome to Virtual Pet 9000!!!!!!!\n";
            s += "We hope you enjoy then game.\n";
            s += "------------------------------------\n";
            return s;
        }
    }
}