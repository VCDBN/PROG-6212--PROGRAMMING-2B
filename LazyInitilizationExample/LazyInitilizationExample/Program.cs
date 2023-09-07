using System;

public class RandomNumberGenerator
{
    // Lazy initialization using Lazy<T>
    private Lazy<int> lazyRandomNumber = new Lazy<int>(() => GenerateRandomNumber());

    public int GetRandomNumber()
    {
        // The method GenerateRandomNumber() will be executed only when lazyRandomNumber.Value is first accessed.
        return lazyRandomNumber.Value;
    }

    private static int GenerateRandomNumber()
    {
        // Simulate generating a random number.
        Random random = new Random();
        return random.Next(1, 100); // Returns a random number between 1 and 99.
    }

    public class Program
    {
        public static void Main()
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();

            // The GenerateRandomNumber() method will be executed when we access GetRandomNumber() for the first time.
            int randomNumber = generator.GetRandomNumber();
            Console.WriteLine($"Random Number: {randomNumber}");

            // Subsequent calls to GetRandomNumber() will return the cached value without re-executing the GenerateRandomNumber() method.
            randomNumber = generator.GetRandomNumber();
            Console.WriteLine($"Cached Random Number: {randomNumber}");
        }
    }
}
