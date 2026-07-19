namespace a_break_statement;

class Program
{
    static void Main(string[] args)
    {
        for (int roll = 1; roll <= 10; roll++)
        {
            if (roll == 5)
            {
                Console.WriteLine("Student found!");
                break;
            }

            Console.WriteLine("Checking Roll: " + roll);
        }
    }
}
