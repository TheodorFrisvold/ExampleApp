﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }
        public string Name { get { return _name; } }
    }
}
