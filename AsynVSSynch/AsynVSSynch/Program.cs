using System;
using System.Threading;
class Program{
    static void Main()    {
        Console.WriteLine("Start of synchronous program.");
        DoTask1();
        DoTask2();
        Console.WriteLine("End of synchronous program.");
    }
    static void DoTask1()    {
        Console.WriteLine("Task 1 started.");
        Thread.Sleep(2000); 
        Console.WriteLine("Task 1 completed.");
    }
    static void DoTask2()    {
        Console.WriteLine("Task 2 started.");
        Thread.Sleep(2000); 
        Console.WriteLine("Task 2 completed.");
    }
}
