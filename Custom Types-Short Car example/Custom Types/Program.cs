// Custom type (class) to represent a Car
class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped!");
    }
}

class Program
{
    static void Main()
    {
        // Creating instances (objects) of the custom type (Car)
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Corolla";
        myCar.Year = 2022;

        Car anotherCar = new Car();
        anotherCar.Make = "Honda";
        anotherCar.Model = "Civic";
        anotherCar.Year = 2021;

        // Using methods of the custom type (Car)
        myCar.StartEngine();
        anotherCar.StartEngine();
        myCar.StopEngine();
    }
}
