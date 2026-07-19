namespace e_hierarchical_inheritance;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Console.WriteLine();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}
