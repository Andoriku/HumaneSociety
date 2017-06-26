﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeePortal
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        List<string> animalInputs = new List<string>();
        public void Run()
        {
            string choice = UserUI.GetStringInput("What would you like to do? \n Add Animal to database: '1' \n View Adopter Bio: '2' \n Update Animal Bio: '3' \n To go back: 'back' \n Exit the porgram: 'exit'"
);
            PickTheTask(choice);
        }
        public void PickTheTask(string choice)
        {
            switch (choice)
            {
                case "1":
                    EnterNewAnimal();
                    ConfirmAnimal();
                    AddAnimalToDatabase();
                    NextAdd();
                    break;
                case "2":
                    SearchAndViewBio();
                    break;
                case "3":
                    UpdateAnimal();
                    break;
                case "back":
                    MainMenu.Run();
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Run();
                    break;
            }
        }
        public void EnterNewAnimal()
        {
            animalInputs.Insert(0, UserUI.GetStringInput("What is the animal's name?"));
            animalInputs.Insert(1, UserUI.GetStringInput("What is the animal's species?"));
            animalInputs.Insert(2, UserUI.GetStringInput("What is the animal's breed?"));
            animalInputs.Insert(3, UserUI.GetStringInput("what room are they in?"));//int
            animalInputs.Insert(4, UserUI.GetStringInput("is the animal up for adoption? 'y' or 'n'"));//bool
            animalInputs.Insert(5, UserUI.GetStringInput("What is the animal's food type?"));
            animalInputs.Insert(6, UserUI.GetStringInput("How much of said food should the animal get per week?"));
            animalInputs.Insert(7, UserUI.GetStringInput("What is the animal's Personality type? 'lounge and relax','laid back','semi-active','active mover', or 'never stop moving'"));
            animalInputs.Insert(8, UserUI.GetStringInput("What is the adoption price for this animal?"));
        }
        public void ConfirmAnimal()
        {
            foreach (string a in animalInputs)
            {
                UserUI.DisplayMessage(a);
            }
            string confirmInformation = UserUI.GetStringInput("is all your information correct? if yes enter 'y', if no enter 'n'");
            switch (confirmInformation)
            {
                case "y":
                    break;
                case "n":
                    Console.Clear();
                    EnterNewAnimal();
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    ConfirmAnimal();
                    break;
            }
        }
        public void AddAnimalToDatabase()
        {
            Animal animal = new HumaneSociety.Animal();
            DataClasses1DataContext humaneSocietyDataBase = new DataClasses1DataContext();
            animal.animalID = System.Guid.NewGuid();
            animal.name = animalInputs[0];
            animal.species = animalInputs[1];
            animal.breed = animalInputs[2];
            animal.roomNumber = Convert.ToInt32(animalInputs[3]);
            bool b;
            if (animalInputs[4] == "y")
            {  
               b = true;
            }
            else if (animalInputs[4] == "n")
            {
                b = false;
            }
            else
            {
                b = true;
            }
            animal.adoptionAvailability = b;
            animal.foodType = animalInputs[5];
            animal.foodAmount = animalInputs[6];
            animal.personalityType = animalInputs[7];
            animal.price = Convert.ToDecimal(animalInputs[8]);
            humaneSocietyDataBase.Animals.InsertOnSubmit(animal);
            humaneSocietyDataBase.SubmitChanges();
        }
        public void NextAdd()
        {
            string finishInput = UserUI.GetStringInput("Would you like to add another animal? 'y' for yes and 'n' to go back to the main menu.");
            if (finishInput == "y")
            {
                EnterNewAnimal();
                ConfirmAnimal();
                AddAnimalToDatabase();
            }
            else if (finishInput == "n")
            {
                Run();
            }
            else
            {
                UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                Console.ReadLine();
                Console.Clear();
                NextAdd();
            }
        }
        public void SearchAndViewBio()
        {

        }
        public void UpdateAnimal()
        {

        }
    }
}
