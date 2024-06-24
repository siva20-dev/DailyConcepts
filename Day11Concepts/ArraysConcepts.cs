using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11Concepts.Arrays
{
    internal class Planets
    {
        public static void ArrayExample1()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            Console.WriteLine("Type the planet no. you want to see");

            Console.WriteLine("1= Mercury");
            Console.WriteLine("2= Venus");
            Console.WriteLine("3= Earth");

            var planetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(planets[planetNumber-1]);

            planets[0] = "Mercury";

            foreach (var item in planets) 
            {
                Console.WriteLine(item);
            }
        }

        public static void ArrayClassExampleMethods()
        {
            string[] months = new string[]
            {
                "January",
                "February",
                "March",
                "April"
            };

            Array.Reverse(months);   

            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            Array.Sort(months);
            Console.WriteLine("\n The sorted order of given months: \n");
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            bool isMarchExist = Array.Exists(months, x => x == "March");
            Console.WriteLine($"\n Is March Exists: {isMarchExist}");   
        }
    }
}
