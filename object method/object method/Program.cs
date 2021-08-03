using System;

namespace object_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("yousef", "medical", 3.6);
            Student student2 = new Student("omar", "eng", 3);

            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student1.HasHonors());

            Console.ReadLine();

        }
    }
}
