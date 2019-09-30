using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = GetObject<Person>();
            person.Name = "Roman";
            var methods = typeof(Person).GetMethods();
            foreach (var item in methods)
            {
                if (item.GetParameters().Length ==0)
                {
                    var message = item.Invoke(person, new object[] { });
                    Console.WriteLine($"{item.Name}:{message}");
                }                
            }
            
            var currentMethodName = MethodBase.GetCurrentMethod();
            Console.WriteLine(currentMethodName.Name);
            Console.Read();
        }
        static T GetObject<T>()
        {
            return (T)typeof(T)
                .GetConstructor(new Type[] { })
                .Invoke(new object[] { });
        }
    }
}
