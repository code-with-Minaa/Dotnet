namespace i_linq_number_of_vowels;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence :"); 
        var sentence = Console.ReadLine();

        var vowels = new char [] {'A', 'E', 'I', 'O', 'U'};
        var query = from letter in sentence.ToUpper() where vowels.Contains(letter) select letter;
        var count = query.Count();
        Console.WriteLine("The number of vowels = {0}", count);
    }
}
