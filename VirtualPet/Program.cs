﻿using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Shelter shelter = new Shelter();

            bool keepThinking = true;
            while (keepThinking)
           {

                Console.WriteLine("Hello! Welcome to Virtual Pets");

                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Take your pet to the vet");
                Console.WriteLine("3. Play with your pet");
                Console.WriteLine("4. Add a pet");
                Console.WriteLine("5. Show Pet Status");
                Console.WriteLine("6. Exit");

                string userSelection = Console.ReadLine();
                pet.Tick();
                Console.Clear();

                switch (userSelection)
                {
                    case "1":
                        pet.Feed();                        
                        break;
                    case "2":
                        pet.SeeVet();
                        break;
                    case "3":
                        pet.Play();
                        break;
                    case "4":
                        pet.CreatePet();
                        shelter.AddPetToShelter(pet);
                        break;
                    case "5":
                        pet.ShowPetStatus();
                        break;
                    case "6":                  
                        keepThinking = false;
                        break;
                }    
            }
        }
    }
}
