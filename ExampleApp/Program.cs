using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Program
    {
        static void Main()
        {
            Student student = new Student("Arne");
            Subject subject1 = new Subject("Maths", "Petter Stordalen");
            Subject subject2 = new Subject("History", "Stor Peterdalen");
            Teacher teacher1 = subject1.Teacher;
            Teacher teacher2 = subject2.Teacher;

            student.JoinSubject(subject1);
            student.JoinSubject(subject2);

            Console.WriteLine(student.Name);
            List<Subject> StudentSubjects = student.Subjects;

            foreach (Subject s in StudentSubjects)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
