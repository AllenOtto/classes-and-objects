using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basics of Objects and Classes

            // Student Class
            //Student student1 = new Student("Wendy Akinyi", 12, 3.6);
            //Student student2 = new Student("Wilder Achoki", 1, 3.0);
            //Student student3 = new Student("Kepha Moturi", 14, 2.4);

            //Console.WriteLine(student1.name);
            //Console.WriteLine(student1.HasHonors() + "\n");
            //Console.WriteLine(student2.name);
            //Console.WriteLine(student2.HasHonors() + "\n");
            //Console.WriteLine(student3.name);
            //Console.WriteLine(student3.HasHonors() + "\n");

            // Getters and Setters
            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek", "Wilder Achoki", "PG");

            //Console.WriteLine($"Shrek is rated {shrek.Rating}");
            //Console.WriteLine($"Avengers is rated {avengers.Rating}");
            //Console.WriteLine($"Movie title is {avengers.title}");
            //Console.WriteLine($"Rating for Avengers is {avengers.Rating}");
            //Console.WriteLine(avengers.Rating = "kepha");
            //Console.WriteLine(avengers.Rating);

            Song track1 = new Song("Trouble", "Cold Play", 150, "Deep");
            Song track2 = new Song("Holiday", "Green Day", 210, "Wild");

            //Console.WriteLine(track1.Comment);
            //Console.WriteLine(track2.Comment = "Kitu kali sana. Ntatoa ngoma na huyu msanii aki ya nani bruvee");
            //Console.WriteLine(track2.Comment);
            //Console.WriteLine(Song.songCount);
            //Console.WriteLine($"Tracki ngapi: {track1.GetSongCount}");


            Chef chef = new Chef();
            chef.MakeSalad();
            chef.MakeSpecialDish();

            ItalianChef chefItaliano = new ItalianChef();
            chefItaliano.MakeChicken();
            chefItaliano.MakePasta();
            chefItaliano.MakeSpecialDish();

















            Console.ReadLine();
        }
    }
}
