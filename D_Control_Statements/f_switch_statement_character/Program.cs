namespace f_switch_statement_character;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your choice from A to F (Uppercase) to get a Nepali girl's name corresponding to that letter. : ");
        switch (Console.ReadLine())
        {
            case "A":
            Console.WriteLine("Anita");
            break;

            case "B":
            Console.WriteLine("Binita");
            break;

            case "C":
            Console.WriteLine("Chandika");
            break;

            case "D":
            Console.WriteLine("Dhan Maya");
            break;

            case "E":
            Console.WriteLine("Elisha");
            break;

            case "F":
            Console.WriteLine("Ful Maya");
            break;

            default:
            Console.WriteLine("Invalid Input");
            break;
        }
    }
}
