using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Subject
    {
        private string _name;
        private Teacher _teacher;
        private List<Student> _students;

        public Subject(string name, string teacherName)
        {
            _name = name;
            _teacher = new Teacher(teacherName, this);
            _students = new List<Student>();
        }

        public string Name { get { return _name; } }
        public Teacher Teacher { get { return _teacher; } }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            _students.Remove(student);
        }

    }
}
