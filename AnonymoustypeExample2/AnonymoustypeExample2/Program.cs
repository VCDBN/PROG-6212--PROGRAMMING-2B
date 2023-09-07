using System;

class Program
{
    static void Main()
    {
        // Create a small array of names representing the days of the week
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        // Display the names of the days in the week
        foreach (var day in daysOfWeek)
        {
            Console.WriteLine(day);
        }
    }
}