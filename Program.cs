using Delegates;

namespace Delegates
{
    internal class Program
    {
        delegate bool ClassFilter(Student student);

        static bool IsExcellent(Student student)
        {
            return student.Name == "avi";
        }
        

        static void Main(string[] args)
        {
            Student student = new Student("avi", "יא7");

            ClassFilter myFilter = IsExcellent;

            Console.WriteLine(myFilter(student));
            myFilter = delegate (Student student){
                return student.StudentClass == "יב1";
            };
            myFilter = (Student student) =>
            {
                return student.StudentClass == "יב1";
            };
            myFilter = student => student.StudentClass == "יב1";
            Func<Student,string > getName = student => student.Name.ToUpper();
            Action<Student> printStudent = student => Console.WriteLine($"Name: {student.Name}, Class: {student.StudentClass}");
            Predicate<Student> nameLongerThan4 = student => student.Name.Length > 4;
            Action<Student> printName = student => Console.WriteLine(student.Name);
            printName += student => Console.WriteLine(student.StudentClass);
            List<Student> students = new List<Student>
            {
                new Student("avi", "יא7"),
                new Student("david", "יב1"),
                new Student("michael", "2יב"),
                new Student("noa", "יא7"),
                new Student("rachel", "יב1")
            };  
            int count=students.Count(student=>student.StudentClass=="יב2");
            Student student1=students.Find(student => student.Name == "noa");
            List<Student> students12 = students.Where(student => student.StudentClass == "יב3").ToList();





        }
    }
}


