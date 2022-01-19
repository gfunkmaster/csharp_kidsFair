using System;

namespace KidsFair
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creating an object fro the created classses in the main method
            Pet pet = new Pet();
            TicketSeller ticketSeller = new TicketSeller();
            Album album = new Album();
            Club club = new Club();

            //calling the methods
            pet.Start();
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadKey();

            ticketSeller.Start();
            album.Start();
            Console.WriteLine();
            Console.WriteLine("Additional program, The Club");
            Console.WriteLine("Press Enter to start next part!");
            Console.ReadKey();
            club.Start();

        }
    }
}
