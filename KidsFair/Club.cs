using System;
namespace KidsFair
{
    public class Club
    {
        string playerName;
        int playerAge;
        double playerSalary;
        bool isNewPlayer;

        //Get the current DateTime 
        DateTime newSigning = DateTime.Now;



        public void Start()
        {

            GatherClubData();
            DisplayPlayerClubInformation();

        }

        public void GatherClubData()
        {
            PlayerName();
            PlayerAge();
            PlayerSalary();
        }


        //method for display information about player
        public void DisplayPlayerClubInformation()
        {
            if(isNewPlayer)
            {
                Console.WriteLine("++++++ The Club presents ++++++");
                Console.WriteLine();
                Console.WriteLine($"Welcome to your new Club, {playerName} ");
                Console.WriteLine();
                Console.WriteLine($"Short presentation of {playerName}");
                Console.WriteLine($"{playerName} was presented {newSigning}");
                Console.WriteLine($"Age: {playerAge}");
                Console.WriteLine($"Salary: {playerSalary}");

            } else
            {
                Console.WriteLine($"Welcome back!, {playerName}");
                Console.WriteLine("Short presentation");
                Console.WriteLine($"Age: {playerAge}");
                Console.WriteLine($"Salary: {playerSalary}");
            }

        }

        //method for playerName
        public void PlayerName()
        {
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            NewPlayerSigning();

            if(isNewPlayer)
            {
                Console.WriteLine( );
                Console.WriteLine($"Welcome to your new Club, {playerName}");
                
                Console.WriteLine();
            } else
            {
                Console.WriteLine();
                Console.WriteLine($"Welcome back from vacation and to the new season, {playerName}");
            }

        }

        //methos for age
        public void PlayerAge()
        {
            Console.WriteLine($"{playerName} how old are you?)");
            playerAge = int.Parse(Console.ReadLine());
        }
       
        //method for salary
        public void PlayerSalary()
        {
            Console.WriteLine($"{playerName} how much do you earn every month?(Sek)");
            string salaryPlayer = Console.ReadLine();

            //with tryParse, taking in the string and converitng to double 
            double.TryParse(salaryPlayer, out playerSalary);

        }

        //method for new signing 
        public void NewPlayerSigning()
        {
            Console.WriteLine("Are you a new player (y/n) ?");
            string player = Console.ReadLine();
            char response = player[0]; //char just first charachter

            //boolean to check the response 
            if ((response == 'y') || (response == 'Y'))
                isNewPlayer = true;
            else
                isNewPlayer = false;
        }
    }
}
