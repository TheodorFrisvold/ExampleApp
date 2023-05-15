using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Student : Person
    {
        private List<Subject> _subjects;
        public Student(string name) : base(name)
        {
            new Person(name);
            _subjects = new List<Subject>();
        }

        public List<Subject> Subjects { get { return _subjects; } }

        public void JoinSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
        public void LeaveSubject(Subject subject)
        {
            _subjects.Remove(subject);
        }
    }
}
