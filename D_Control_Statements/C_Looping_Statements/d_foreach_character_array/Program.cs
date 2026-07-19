namespace d_foreach_character_array;

class Program
{
    static void Main(string[] args)
    {
        char[] myarray = { 'M', 'I', 'N', 'A' };

        foreach (var item in myarray)
        {
            Console.WriteLine(item);
        }
    }
}