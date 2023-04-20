using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Annmarie";
            var location = "Arkansas";
            var currentDate = DateTime.Now;

            Console.WriteLine($"My name is {name}. I am from {location}.");
            Console.WriteLine($"Today is {currentDate:d}");

            DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
            TimeSpan timeUntilChristmas = christmas - DateTime.Today;
            int daysUntilChristmas = timeUntilChristmas.Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas... and I'm still broke.");


            //from textbook
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("\nWhat width do you need? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("What height do you need? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //Do not automatically terminate
            Console.ReadKey();

        }
    }
}
