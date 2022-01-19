using System;
namespace KidsFair
{
    public class Pet
    {
        //variable names for the pet 
       private string petName;
       private int petAge;
       private bool isFemale;


        //method for start 
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Greetings from the Pet owner application");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();
        }


        //method for pet's name 
        public void NameOfThePet()
        {
            Console.Write("What is the name of your pet? ");
            petName = Console.ReadLine();
        }
        //method for pet's age
        public void AgeOfThePet()
        {
            Console.Write($"What is {petName}'s age? ");
            petAge = int.Parse(Console.ReadLine());
        }
        //method for pet's gender
        public void GenderOfPet()
        {
            Console.Write("Is your pet a female (y/n) ?");
            string gender = Console.ReadLine();
            char response = gender[0]; //char just first charachter

            //boolean to check the response 
            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;

        }

        // saving the data and calling the later in start
        public void ReadAndSavePetData()
        {
            NameOfThePet();
            AgeOfThePet();
            GenderOfPet();
        }

        public void DisplayPetInfo ()
        {
            Console.WriteLine($"Name: {petName} Age: {petAge}");

            // if statement is the pet is girl or boy 
            if(isFemale)
            {
                Console.WriteLine($"{petName} is a good girl");
            } else
            {
                Console.WriteLine($"{petName} is a good boy");
            }
            

        }
    }
}
