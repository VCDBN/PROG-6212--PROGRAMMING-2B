using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
        // the async keyword uses the await keyword to wait for tasks to complete
    {// Task indicates that this is part of a asynchronous operation
        Console.WriteLine("Start of asynchronous program.");

        //Task creation and assigned to a method
        Task task1 = DoTask1Async();
        Task task2 = DoTask2Async();
        Task task3 = DoTask3Async();

        //Awaiting task completion
        //Waits for all three tasks before moving on
        //The program will not process to the next line until all three tasks have finished their operations
        await Task.WhenAll(task1, task2,task3);

        Console.WriteLine("End of asynchronous program.");
    }
        static async Task DoTask1Async()
    {
        Console.WriteLine("Task 1 started.");
        await Task.Delay(3000); // Simulate some asynchronous work for 3 seconds
        Console.WriteLine("Task 1 completed.");
    }

    static async Task DoTask2Async()
    {
        Console.WriteLine("Task 2 started.");
        await Task.Delay(4000); // Simulate some asynchronous work for 2 seconds
        Console.WriteLine("Task 2 completed.");
    }

    static async Task DoTask3Async()
    {
        Console.WriteLine("Task 3 started.");
        await Task.Delay(2000); // Simulate some asynchronous work for 2 seconds
        Console.WriteLine("Task 3 completed.");
    }
}
