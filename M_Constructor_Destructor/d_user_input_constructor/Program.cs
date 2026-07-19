namespace a_user_input_constructor
#nullable disable

{
    class Student
    {
        int roll;
        string name;
        string address;
        public Student()
        {
            Console.Write("Enter your roll: ");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your address: ");
            address = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Roll = " + roll);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Address = " + address);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.display();
        }
    }
}