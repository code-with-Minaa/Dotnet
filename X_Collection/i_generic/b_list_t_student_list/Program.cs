namespace a_list_t_student_list;
#nullable disable

public class Student
{
    public int roll {get; set;}
    public string name {get; set;}
}
class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
            new Student() {roll = 222, name = "Hania Amir"},
            new Student() {roll = 223, name = "Yumna Zaidi"},
            new Student() {roll = 224, name = "Maya Ali"},
            new Student() {roll = 225, name = "Sara Khan"},
        };

        var StudNames = 
        from s in students
            where s.name == "Maya Ali"
            select s;

        foreach (var student in StudNames)
        {
            Console.WriteLine(student.roll + " " + student.name);
        }    
    }
}
