using System;
namespace KidsFair
{
    public class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;

        private double amountToPay;

        public void Start()
        {
            Console.WriteLine("Welcome to KID's FAIR!");
            Console.WriteLine("Children always gets a 75% discount");

            GatherAllTicketSellerData();
            DisplayTicketInformation();

            Console.WriteLine("++ Press Enter to start next part!");
            Console.Read();


        }

        //method for people name
        public void NameOfPeople()
        {
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();

        }
        //method for amount of adults
        public void NumberOfAdults()
        {
            Console.WriteLine("Number of adults: ");
            string respAdult = Console.ReadLine();
            numOfAdults = int.Parse(respAdult);
        }
        // method for amount of children
        public void NumberOfChildren()
        {
            Console.WriteLine("Number of children: ");
            string respChildren = Console.ReadLine();
            numOfChildren = int.Parse(respChildren);
        }

       public void CalcPrice()
        {
            //discount for children 
            double discount = 0.25;
            //calculate the price for children and convering it to double so we have same type
            double children = (price * discount) * Convert.ToDouble(numOfChildren);
            //calculate the price for adults and convering it to double so we have same type
            double adults = price * Convert.ToDouble(numOfAdults);

            // calc to one price 
            double priceAdultAndChildren = adults + children;
            amountToPay = priceAdultAndChildren; 
        }

     

        public void Recipe()
        {
            CalcPrice();
            Console.WriteLine("++++ Your receipt ++++");
            Console.WriteLine($"++++ Amount to pay: {amountToPay} ++++");

        }

        //method gathering data 
        public void GatherAllTicketSellerData()
        {
            NameOfPeople();
            NumberOfAdults();
            NumberOfChildren();
            CalcPrice();
        }

        //method for display information
        public void DisplayTicketInformation()
        {
            Recipe();
            Console.WriteLine($"Thank you {name} and please come back! +++");
           
        }
    }
}
