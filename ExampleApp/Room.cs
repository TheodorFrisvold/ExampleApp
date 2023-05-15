using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp
{
    internal class Room
    {
        private int _id;

        public Room(int id) {
            _id = id;
        }

        public int Id { get { return _id;} }
    }
}
