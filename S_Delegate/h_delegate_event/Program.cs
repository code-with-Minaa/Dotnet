namespace h_delegate_event;
#nullable disable

//step : define a delegate
public delegate void TrafficLightChangeHandler (string color);

public class TrafficLight
{
    //declare the event
    public event TrafficLightChangeHandler TrafficLightChanged;
    public void ChangeLight(string color)
    {
        //method that raised the event
        Console.WriteLine("The traffic light is " + color);
        TrafficLightChanged.Invoke(color);
    }
}

public class Car
{
    public void ReactToLight(string LightColor)
    {
        //event handling method
        if(LightColor == "Red")
        {
            Console.WriteLine("Car stops.");
        }
        else if(LightColor == "Green")
        {
            Console.WriteLine("Car starts moving.");
        }
    }
}
class MainProgram
{
    static void Main(string[] args)
    {
        TrafficLight light = new TrafficLight();
        Car car = new Car();
        //subscribe to the event
        light.TrafficLightChanged += car.ReactToLight;
        light.ChangeLight("Green");
        light.ChangeLight("Red");
    }
}
