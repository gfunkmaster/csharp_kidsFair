using System;
namespace KidsFair
{
    public class Album
    {
        //Album name, artist name, and number of tracks
        private string albumName;
        private string artistName;
        private int numOfTracks;


        public void Start()
        {
            Console.WriteLine("Starting the Album Program!");

            GatheringAlbumData();
            Console.WriteLine();
            DisplayInformation();
        }

        public void GatheringAlbumData()
        {
            FavoriteAlbum();
            FavoriteArtistOrBand();
            NumberOfTracks();
        }

        public void DisplayInformation()
        {

            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of tracks: {numOfTracks}");
            Console.WriteLine("Enjoy listening");

        }

        public void FavoriteAlbum()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
        }

        public void FavoriteArtistOrBand()
        {
            Console.WriteLine($"What is the name of Artist or Band for {albumName}?");
            artistName = Console.ReadLine();
        }

        public void NumberOfTracks()
        {
            Console.WriteLine($"How many tracks does {albumName} have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

    }
}
