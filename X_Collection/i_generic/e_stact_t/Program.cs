namespace e_stact_t;

class Program
{
    static void Main(string[] args)
    {
        /* Stack<int> myNums = new Stack<int>();
        myNums.Push(78);
        myNums.Push(45);
        myNums.Push(98);
        myNums.Push(12);
        myNums.Push(9); */

        //int [] myArray = new int [] {};
        int [] myArray = new int [] {31,78,45,96,33,9,7,99};
        Stack<int> myNums = new Stack<int>(myArray);

        Console.WriteLine("The total number of elements in the stack = " + muNums.Count);
        if(myNums.Count > 0)
        {
            foreach (var item in myNums)
        {
            Console.WriteLine(item);
        }
        } else 
    }
}
