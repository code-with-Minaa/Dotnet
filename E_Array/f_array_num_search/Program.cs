namespace f_array_num_search;

#nullable disable
class Program
{
    static void Main(string[] args)
    {
        //single dimensional array to find a number from an array
        int[] myArray = {40,55,78,69,22,14,30,25,52,9,11};
        Console.WriteLine("Enter number to search it in array:");
        int num = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (num == myArray[i])
            {
                found = true;
                break;
            }
        }
        if (found == true)
        {
            Console.WriteLine("Number found");
        }
        else
        {
            Console.WriteLine("Number not found");
        }   
    }
}
