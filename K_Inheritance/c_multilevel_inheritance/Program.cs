namespace c_multilevel_inheritance;

class Animal
{
    public void sound()
    {
        Console.WriteLine("Animal is making sound.");
    }
}
class DomesticAnimal : Animal
{
    public void eating()
    {
        Console.WriteLine("Domestic Animals are eating meal.");
    }
}
class Dog : DomesticAnimal
{
    public void barking()
    {
        Console.WriteLine("Dog is barking.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dog d = new Dog();
        d.sound();
        d.eating();
        d.barking();
    }
}