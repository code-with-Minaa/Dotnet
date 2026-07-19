namespace c_interface_inheriting_interface;

interface IAnimal
{
    public void sound();
}

interface IDog : IAnimal
{
    public void bark();
}

class Puppy : IDog
{
    public void sound()
    {
        Console.WriteLine("Animal is making sound");
    }

    public void bark ()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Puppy p = new Puppy();
        p.sound();
        p.bark();
    }
}
