namespace c_overloading;

class MyClass
{
    public void displayDetails(int roll, string name)
    {
        Console.WriteLine("Roll = {0} , Name = {1}", roll, name);
    }
    public void displayDetails(string name, int roll)
    {
        Console.WriteLine("Name = {0} , Roll = {1}", name, roll);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.displayDetails(11,"Mina");
        obj.displayDetails("Ram", 77);
    }
}
