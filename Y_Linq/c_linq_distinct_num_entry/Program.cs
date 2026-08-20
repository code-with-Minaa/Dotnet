namespace c_linq_distinct_num_entry;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int [] {45,65,98,12,36,20,77,44,65};
        int uniNum = nums.Distinct().Count();
        Console.WriteLine("Number of unique elements : " + uniNum);
    }
}
