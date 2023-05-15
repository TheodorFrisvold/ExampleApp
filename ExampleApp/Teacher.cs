using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Teacher : Person
    {
        private Subject _subject;
        public Teacher(string name, Subject subject) : base(name)
        {
            new Person(name);
            _subject = subject;
        }
        public Subject subject { get { return _subject; } }

    }
}
