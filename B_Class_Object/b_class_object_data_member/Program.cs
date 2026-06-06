namespace b_class_object_data_member;
#nullable disable
class Addition
{
    int num1;
    int num2;
    static void Main(string[] args)
    {
        Addition obj = new Addition();
        obj.num1 = 20;
        obj.num2 = 30;
        Console.WriteLine("The sum of num1 and num2 is : " + (obj.num1+obj.num2));
    }
}
