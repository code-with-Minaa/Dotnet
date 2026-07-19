namespace b_array_char;

class Program
{
    static void Main(string[] args)
    {
        char[] myArray = { 'N', 'A', 'M', 'A', 'S', 'T', 'E' };

        foreach (var item in myArray)
        {
            Console.Write("\t{0}", item);
        }
    }
}
