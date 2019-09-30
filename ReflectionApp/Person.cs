using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    public class Person
    {
        public string Name { get; set; }
        public string SayName()
        {
            return Name;
        }
    }
}
