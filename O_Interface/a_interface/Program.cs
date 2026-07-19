namespace a_interface;

interface IVehicle
{
    public void accelarate();
}

class Aeroplane : IVehicle
{
    public void accelarate()
    {
        Console.WriteLine("Plane flies");
    }
}

class Car : Aeroplane
{
    public void accelarate()
    {
        Console.WriteLine("Car runs");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IVehicle a1 = new Aeroplane();
        IVehicle c1 = new Car();
        /* Aeroplane a1 = new Aeroplane();
        Car c1 = new Car(); */
        a1.accelarate();
        c1.accelarate();
    }
}
