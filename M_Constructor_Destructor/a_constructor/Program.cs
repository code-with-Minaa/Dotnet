namespace a_constructor;

class Dog
{
    public Dog()
    {
        Console.WriteLine("Dog is barking.");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog();
    }
}
