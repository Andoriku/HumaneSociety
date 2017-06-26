using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeePortal
    {
        DataClasses1DataContext humaneSocietyDataBase = new DataClasses1DataContext();
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
                    WhichSearchToExicute();
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
            animalInputs.Insert(9, UserUI.GetStringInput("Does the animal have its Shots?"));
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
            bool s;
            if (animalInputs[9] == "y")
            {
                s = true;
            }
            else if (animalInputs[9] == "n")
            {
                s = false;
            }
            else
            {
                s = true;
            }
            animal.Shots = s;
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
        public void WhichSearchToExicute()
        {
            string input = UserUI.GetStringInput("what would you like to search by? 'adopter ID','first name','last name','first and last name','age','personality','species','breed'");
            switch (input)
            {
                case "adopter ID":
                    string idInput = UserUI.GetStringInput("Type in a UserID with dashes:");
                   Guid Guid = new Guid(idInput);
                    SearchByID(Guid);
                    break;
                case "first name":
                    string firstNameInput = UserUI.GetStringInput("Type in a user's first name:");
                    SearchByFirstName(firstNameInput);
                    break;
                case "last name":
                    string lastNameInput = UserUI.GetStringInput("Type in a user's Last name:");
                    SearchByLastName(lastNameInput);
                    break;
                case "first and last name":
                    string firstName = UserUI.GetStringInput("Type in the user's first name:");
                    string lastName = UserUI.GetStringInput("Type in the user's first name:");
                    SearchByFullName(firstName,lastName);
                    break;
                case "age":
                    int ageInput = Convert.ToInt32(UserUI.GetStringInput("Type in a user's age:"));
                    SearchByAge(ageInput);
                    break;
                case "personality":
                    string personalityInput = UserUI.GetStringInput("Type in a user's personality preference:");
                    SearchByPersonality(personalityInput);
                    break;
                case "species":
                    string speciesInput = UserUI.GetStringInput("Type in a user's speices preference:");
                    SearchBySpecies(speciesInput);
                    break;
                case "breed":
                    string breedInput = UserUI.GetStringInput("Type in a user's speices preference:");
                    SearchByBreed(breedInput);
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    WhichSearchToExicute();
                    break;
            }
        }
        public void SearchByID(Guid IDInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.adopterID == IDInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID,item.adopterFirstName,item.adopterLastName,item.age,item.personallityType,item.animalSpeciesPref,item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByFirstName(string firstNameInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.adopterFirstName == firstNameInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByLastName(string LastNameInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.adopterLastName == LastNameInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByFullName(string firstNameInput,string lastNameInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.adopterFirstName == firstNameInput && search.adopterLastName == lastNameInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByAge(int ageInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.age == ageInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByPersonality(string personalityInput)
        {
 
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.personallityType == personalityInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchBySpecies(string speciesInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.animalSpeciesPref == speciesInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByBreed(string breedInput)
        {
            var Query = from search in humaneSocietyDataBase.Adopters
                        where search.animalBreedPref == breedInput
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", item.adopterID, item.adopterFirstName, item.adopterLastName, item.age, item.personallityType, item.animalSpeciesPref, item.animalBreedPref));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }

        public void UpdateAnimal()
        {
            UserUI.DisplayMessage("You can search for an animal to update its adoption status, change it's name or update it's shots.");
            string idInput = UserUI.GetStringInput("Type in a animalID with dashes:");
            Guid guid = new Guid(idInput);
         
            string choice = UserUI.GetStringInput("What would you like to update? 'adoption','name', or 'shots'");
            switch (choice)
            {
                case "adoption":
                    ChageAdoptionStatus(guid);
                    break;
                case "name":
                    ChangeAnimalName(guid);
                    break;
                case "shots":
                    ChangeShotStatus(guid);
                    break;
                    default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    UpdateAnimal();
                    break;
            }
            
        }
        public void ChageAdoptionStatus(Guid input)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.animalID == input
                        select search;
        }
        public void ChangeAnimalName(Guid input)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.animalID == input
                        select search;
            foreach(Animal item in Query)
            {
                string newName = UserUI.GetStringInput("What would you like to change " + item.name + "'s name to? Enter new name:");
                item.name = newName;
                humaneSocietyDataBase.SubmitChanges();
            }
        }
        public void ChangeShotStatus(Guid input)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.animalID == input
                        select search;
            foreach (Animal item in Query)
            {
                string newShotStatus = UserUI.GetStringInput("What would you like to change " + item.name + "'s Shot Status to? Enter 'true' or 'false'");
                item.name = newShotStatus;
                humaneSocietyDataBase.SubmitChanges();
            }
        }
    }
}
