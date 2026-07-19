namespace b_constructor_destructor;

class Dog
{
    public Dog()
    {
        Console.WriteLine("Dog is barking.");
    }

    ~Dog ()
    {
        Console.WriteLine("Destructor called.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d1 = new Dog();
    }
}