// Written by Jay Gunderson
// 08/18/2024

namespace Interfaces_Chapter_27_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Sample data to see if this works

            AudioBook grapesOfWrath = new AudioBook("GrapedOfWrath", "John Steinbeck", 1939, 360);
            Book theGreatGatsby = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925, "Fiction");
            Magazine wsj = new Magazine("WallStreet Journal", "WSJ editorial", 2024, 2000);
            Book theOldManAndTheSea = new Book("The Old Man and the Sea", "Ernest Hemingway", 1952, "Fiction");
            List<ILibraryItem> checkouts = new List<ILibraryItem>();


            // Will verify that you can add each object as a type of LibraryItem (Interface)
            checkouts.Add(grapesOfWrath);
            grapesOfWrath.CheckOut();
            checkouts.Add(theGreatGatsby);
            theGreatGatsby.CheckOut();
            checkouts.Add(wsj);
            wsj.CheckOut();

            // Will verify that they will all be printed as an object of the LibraryItem
            foreach (var c in checkouts)
            {
                Console.WriteLine(c.GetInfo());
                Console.WriteLine("Available: "+c.IsAvailable + "\n\n");

                
            }

            
            Console.WriteLine(theOldManAndTheSea.GetInfo());
            Console.WriteLine("Available: " + theOldManAndTheSea.IsAvailable);

        }
    }
}
