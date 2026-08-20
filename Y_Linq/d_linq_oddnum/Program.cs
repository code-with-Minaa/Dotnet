namespace d_linq_oddnum;

class Program
{
    static void Main(string[] args)
    {
        int [] nums = new int[] {12,59,36,40,42,86,91,75};
        int oddNum = nums.Count(n => n%2 ==1);
        Console.WriteLine("Total number of odd numbers : " + oddNum);
    }
}
