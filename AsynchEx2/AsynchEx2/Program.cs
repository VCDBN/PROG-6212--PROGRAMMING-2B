using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Calculating Prime Numbers");

        Console.Write("Enter the range for prime numbers  ");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers up to {limit}:");

        
        for (int num = 2; num <= limit; num++)
        {
            if (await IsPrimeAsync(num))
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine("\nDone!");
    }

    static async Task<bool> IsPrimeAsync(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
            await Task.Delay(5000); // Simulate some asynchronous work
        }

        return true;
    }
}
