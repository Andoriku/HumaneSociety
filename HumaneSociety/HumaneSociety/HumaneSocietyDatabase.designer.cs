﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumaneSociety
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSocietyDataBase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdopter(Adopter instance);
    partial void UpdateAdopter(Adopter instance);
    partial void DeleteAdopter(Adopter instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.HumaneSocietyDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Adopter> Adopters
		{
			get
			{
				return this.GetTable<Adopter>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adopter")]
	public partial class Adopter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _adopterID;
		
		private string _adopterFirstName;
		
		private string _adopterLastName;
		
		private System.Nullable<int> _age;
		
		private string _personallityType;
		
		private string _animalSpeciesPref;
		
		private string _animalBreedPref;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnadopterIDChanging(System.Guid value);
    partial void OnadopterIDChanged();
    partial void OnadopterFirstNameChanging(string value);
    partial void OnadopterFirstNameChanged();
    partial void OnadopterLastNameChanging(string value);
    partial void OnadopterLastNameChanged();
    partial void OnageChanging(System.Nullable<int> value);
    partial void OnageChanged();
    partial void OnpersonallityTypeChanging(string value);
    partial void OnpersonallityTypeChanged();
    partial void OnanimalSpeciesPrefChanging(string value);
    partial void OnanimalSpeciesPrefChanged();
    partial void OnanimalBreedPrefChanging(string value);
    partial void OnanimalBreedPrefChanged();
    #endregion
		
		public Adopter()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adopterID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid adopterID
		{
			get
			{
				return this._adopterID;
			}
			set
			{
				if ((this._adopterID != value))
				{
					this.OnadopterIDChanging(value);
					this.SendPropertyChanging();
					this._adopterID = value;
					this.SendPropertyChanged("adopterID");
					this.OnadopterIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adopterFirstName", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string adopterFirstName
		{
			get
			{
				return this._adopterFirstName;
			}
			set
			{
				if ((this._adopterFirstName != value))
				{
					this.OnadopterFirstNameChanging(value);
					this.SendPropertyChanging();
					this._adopterFirstName = value;
					this.SendPropertyChanged("adopterFirstName");
					this.OnadopterFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adopterLastName", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string adopterLastName
		{
			get
			{
				return this._adopterLastName;
			}
			set
			{
				if ((this._adopterLastName != value))
				{
					this.OnadopterLastNameChanging(value);
					this.SendPropertyChanging();
					this._adopterLastName = value;
					this.SendPropertyChanged("adopterLastName");
					this.OnadopterLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_age", DbType="Int")]
		public System.Nullable<int> age
		{
			get
			{
				return this._age;
			}
			set
			{
				if ((this._age != value))
				{
					this.OnageChanging(value);
					this.SendPropertyChanging();
					this._age = value;
					this.SendPropertyChanged("age");
					this.OnageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personallityType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string personallityType
		{
			get
			{
				return this._personallityType;
			}
			set
			{
				if ((this._personallityType != value))
				{
					this.OnpersonallityTypeChanging(value);
					this.SendPropertyChanging();
					this._personallityType = value;
					this.SendPropertyChanged("personallityType");
					this.OnpersonallityTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_animalSpeciesPref", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string animalSpeciesPref
		{
			get
			{
				return this._animalSpeciesPref;
			}
			set
			{
				if ((this._animalSpeciesPref != value))
				{
					this.OnanimalSpeciesPrefChanging(value);
					this.SendPropertyChanging();
					this._animalSpeciesPref = value;
					this.SendPropertyChanged("animalSpeciesPref");
					this.OnanimalSpeciesPrefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_animalBreedPref", DbType="VarChar(50)")]
		public string animalBreedPref
		{
			get
			{
				return this._animalBreedPref;
			}
			set
			{
				if ((this._animalBreedPref != value))
				{
					this.OnanimalBreedPrefChanging(value);
					this.SendPropertyChanging();
					this._animalBreedPref = value;
					this.SendPropertyChanged("animalBreedPref");
					this.OnanimalBreedPrefChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
        public void Run()
        {
            string choice = UserUI.GetStringInput("what would you like to do? \n Enter a bio: '1' \n Search for an animal: '2' \n To go back: 'back' \n Exit the porgram: 'exit'");
            PickTheTask(choice);
        }
        private void PickTheTask(string choice)
        {
            switch (choice)
            {
                case "1":
                    EnterBio();
                    ConfirmBio();
                    AddBioToDatabase();
                    break;
                case "2":
                    WhichSearchToExicute();
                    break;
                case "back":
                    MainMenu.Run();
                    break;
                case "exit":
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    Run();
                    break;
            }
        }
        List<string> bioInputs = new List<string>();
        DataClasses1DataContext humaneSocietyDataBase = new DataClasses1DataContext();
        private IQueryable<object> select;

        public void EnterBio()
        {
            UserUI.DisplayMessage("We here at the Humane Society Like to match our perspective Adopters with the animals we think would be a good fit for them. This is a Short Bio for you to fill out so that our Caretakers can match you with the right animal. We will ask you some questions and gather you animal preferance so we can better decide which animal is right for you.");
            Console.Clear();
            bioInputs.Insert(0,UserUI.GetStringInput("What is your first name?"));
            bioInputs.Insert(1, UserUI.GetStringInput("What is your last name?"));
            bioInputs.Insert(2, UserUI.GetStringInput("How old are you? Enter a number"));
            bioInputs.Insert(3, UserUI.GetStringInput("What is your personality type? 'lounge and relax','laid back','semi-active','active mover', or 'never stop moving'")); 
            bioInputs.Insert(4, UserUI.GetStringInput("What kind of animal are you intreseted in(eg dog, cat, bird, ferret, bunny, etc.)?"));
            bioInputs.Insert(5, UserUI.GetStringInput("What breed are you most interested in? you can write 'n/a' or 'none' if you're not sure"));
        }
        public void ConfirmBio()
        {
            foreach (string a in bioInputs)
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
                    EnterBio();
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    ConfirmBio();
                    break;
            }
        }
        public void AddBioToDatabase()
        {
            Adopter adopter = new Adopter();
            adopter.adopterID = System.Guid.NewGuid();
            adopter._adopterFirstName = bioInputs[0];
            adopter._adopterLastName = bioInputs[1];
            adopter._age = Convert.ToInt32(bioInputs[2]);
            adopter._personallityType = bioInputs[3];
            adopter._animalSpeciesPref = bioInputs[4];
            adopter._animalBreedPref = bioInputs[5];
            humaneSocietyDataBase.Adopters.InsertOnSubmit(adopter);
            humaneSocietyDataBase.SubmitChanges();
            UserUI.DisplayMessage("Thank you for your interest in our animals here at the Humane Society.");
            Console.ReadLine();
            Console.Clear();
            Run();
        }
        public void WhichSearchToExicute()
        {
            string input = UserUI.GetStringInput("what would you like to search by? 'animal name','species','breed','personality','price', or 'all available'");
            switch (input)
            {
                case "animal name":
                   string name = UserUI.GetStringInput("What is the name of the animal you are looking for?");
                    SearchByName(name);
                    break;
                case "species":
                    string species = UserUI.GetStringInput("What species of animal are you are looking for?");
                    SearchBySpecies(species);
                    break;
                case "breed":
                    string breed = UserUI.GetStringInput("What breed of animal you are looking for?");
                    SearchByBreed(breed);
                    break;
                case "personality":
                    string personality = UserUI.GetStringInput("What is the name of the animal you are lookiing for?");
                    SearchByPersonality(personality);
                    break;
                case "price":
                    decimal priceChoice = UserUI.GetDecimalInput("What is the name of the animal you are lookiing for?");
                    SearchByPrice(priceChoice);
                    break;
                case "all available":
                    ShowAllAvailable();
                    break;
                default:
                    UserUI.DisplayMessage("Oops! You entered a wrong message! try again.");
                    Console.ReadLine();
                    Console.Clear();
                    WhichSearchToExicute();
                    break;
            }
        }
        public void SearchByName(string name)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.name == name
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                Console.WriteLine("____________________________________________");
            }
                       Console.ReadLine();
        }
        public void SearchBySpecies(string species)
        {
            var Query = from Animal in humaneSocietyDataBase.Animals
                        where Animal.species == species
                        select Animal;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByBreed(string breed)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.breed == breed
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByPersonality(string personality)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.personalityType == personality
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void SearchByPrice(decimal price)
        {
            var Query = from search in humaneSocietyDataBase.Animals
                        where search.price == price
                        select search;
            Console.WriteLine("\n Search Results \n");
            foreach (var item in Query)
            {
                Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                Console.WriteLine("____________________________________________");
            }
            Console.ReadLine();
        }
        public void ShowAllAvailable()
        {
            var Query = from row in humaneSocietyDataBase.Animals
                        select row;

            Console.WriteLine("\n All Animals \n");
            foreach (var item in Query)
            {
                if (item.adoptionAvailability == true)
                {
                    Console.WriteLine(String.Format("Name: {0} \nSpecies: {1} \nBreed(if Aplicable): {2} \nPersonality: {3} \nRecommended Food Type: {4} \nRecommended Amount Of Food A Week:  {5} \nAdoption Cost: ${6}", item.name, item.species, item.breed, item.personalityType, item.foodType, item.foodAmount, item.price));
                    Console.WriteLine("____________________________________________");
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animal")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _animalID;
		
		private string _name;
		
		private string _species;
		
		private string _breed;
		
		private System.Nullable<int> _roomNumber;
		
		private bool _adoptionAvailability;
		
		private string _foodType;
		
		private string _foodAmount;
		
		private string _personalityType;
		
		private decimal _price;

        private bool _Shots;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnanimalIDChanging(System.Guid value);
    partial void OnanimalIDChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnspeciesChanging(string value);
    partial void OnspeciesChanged();
    partial void OnbreedChanging(string value);
    partial void OnbreedChanged();
    partial void OnroomNumberChanging(System.Nullable<int> value);
    partial void OnroomNumberChanged();
    partial void OnadoptionAvailabilityChanging(bool value);
    partial void OnadoptionAvailabilityChanged();
        partial void OnShotsChanging(bool value);
        partial void OnShotsChanged();
        partial void OnfoodTypeChanging(string value);
    partial void OnfoodTypeChanged();
    partial void OnfoodAmountChanging(string value);
    partial void OnfoodAmountChanged();
    partial void OnpersonalityTypeChanging(string value);
    partial void OnpersonalityTypeChanged();
    partial void OnpriceChanging(decimal value);
    partial void OnpriceChanged();
    #endregion
		
		public Animal()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_animalID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid animalID
		{
			get
			{
				return this._animalID;
			}
			set
			{
				if ((this._animalID != value))
				{
					this.OnanimalIDChanging(value);
					this.SendPropertyChanging();
					this._animalID = value;
					this.SendPropertyChanged("animalID");
					this.OnanimalIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(60) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_species", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string species
		{
			get
			{
				return this._species;
			}
			set
			{
				if ((this._species != value))
				{
					this.OnspeciesChanging(value);
					this.SendPropertyChanging();
					this._species = value;
					this.SendPropertyChanged("species");
					this.OnspeciesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_breed", DbType="VarChar(50)")]
		public string breed
		{
			get
			{
				return this._breed;
			}
			set
			{
				if ((this._breed != value))
				{
					this.OnbreedChanging(value);
					this.SendPropertyChanging();
					this._breed = value;
					this.SendPropertyChanged("breed");
					this.OnbreedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roomNumber", DbType="Int")]
		public System.Nullable<int> roomNumber
		{
			get
			{
				return this._roomNumber;
			}
			set
			{
				if ((this._roomNumber != value))
				{
					this.OnroomNumberChanging(value);
					this.SendPropertyChanging();
					this._roomNumber = value;
					this.SendPropertyChanged("roomNumber");
					this.OnroomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adoptionAvailability", DbType="Bit NOT NULL")]
		public bool adoptionAvailability
		{
			get
			{
				return this._adoptionAvailability;
			}
			set
			{
				if ((this._adoptionAvailability != value))
				{
					this.OnadoptionAvailabilityChanging(value);
					this.SendPropertyChanging();
					this._adoptionAvailability = value;
					this.SendPropertyChanged("adoptionAvailability");
					this.OnadoptionAvailabilityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string foodType
		{
			get
			{
				return this._foodType;
			}
			set
			{
				if ((this._foodType != value))
				{
					this.OnfoodTypeChanging(value);
					this.SendPropertyChanging();
					this._foodType = value;
					this.SendPropertyChanged("foodType");
					this.OnfoodTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_foodAmount", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string foodAmount
		{
			get
			{
				return this._foodAmount;
			}
			set
			{
				if ((this._foodAmount != value))
				{
					this.OnfoodAmountChanging(value);
					this.SendPropertyChanging();
					this._foodAmount = value;
					this.SendPropertyChanged("foodAmount");
					this.OnfoodAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_personalityType", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string personalityType
		{
			get
			{
				return this._personalityType;
			}
			set
			{
				if ((this._personalityType != value))
				{
					this.OnpersonalityTypeChanging(value);
					this.SendPropertyChanging();
					this._personalityType = value;
					this.SendPropertyChanged("personalityType");
					this.OnpersonalityTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="Decimal(18,0) NOT NULL")]
		public decimal price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
        public bool Shots
        {
            get
            {
                return this._Shots;
            }
            set
            {
                if ((this._Shots != value))
                {
                    this.OnShotsChanging(value);
                    this.SendPropertyChanging();
                    this._Shots = value;
                    this.SendPropertyChanged("adoptionAvailability");
                    this.OnShotsChanged();
                }
            }
        }
    }
}
#pragma warning restore 1591
