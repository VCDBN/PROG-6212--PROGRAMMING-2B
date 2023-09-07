using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<String> names = new List<String> { "Denzyl", "John", "Jock", "Sam", "Johnny", "Ammy", "Brock", "Mysterio", "Rodney", "Jeremy" };



            // Filtering with 'where'
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            Console.WriteLine("Even numbers:");

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Projection with 'select'
            var squaredNumbers = from num in numbers
                                 select num * num;

            Console.WriteLine("\nSquared numbers:");
            foreach (var number in squaredNumbers)
            {
                Console.WriteLine(number);
            }

            // Ordering with 'orderby'
            var sortedNumbers = from num in numbers
                                orderby num descending
                                select num;

            Console.WriteLine("\nSorted numbers (descending):");
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            var namesStartingWithA = from name in names
                                     where name.StartsWith("A")
                                     select name;
            Console.WriteLine("\nDisplay name starting with letter A");

            foreach (var name in namesStartingWithA)
            {
                Console.WriteLine(name);
            }

            var shortNames = from name in names
                             where name.Length <= 4
                             select name;


            var sortedNames = from name in names
                              orderby name
                              select name;


            var uppercaseNames = from name in names
                                 select name.ToUpper();

            var longestName = names.OrderByDescending(name => name.Length).First();


        }
    }
}
