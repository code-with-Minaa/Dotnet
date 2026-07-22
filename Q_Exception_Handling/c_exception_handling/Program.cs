namespace c_exception_handling;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] nums = new int[4];
            /* nums[4] = 22;
            Console.WriteLine(nums[3]); */
            nums[10] = 22;
            Console.WriteLine(nums[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error found : " + e);
        }
    }
}