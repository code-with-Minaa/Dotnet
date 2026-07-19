namespace b_enum;

class Program
{
    enum TrafficLight { Red, Yellow, Green };

    static void Main(string[] args)
    {
        var signal = TrafficLight.Red;

        if (signal == TrafficLight.Red)
        {
            Console.WriteLine("Stop");
        }
        else if (signal == TrafficLight.Yellow)
        {
            Console.WriteLine("Get Ready");
        }
        else
        {
            Console.WriteLine("Go");
        }
    }
}