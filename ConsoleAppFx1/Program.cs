using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFx1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var type1 = typeof(ClassLibrary1.Struct1);

            var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
            foreach (MemberInfo m in type1.GetMembers(flags))
            {
                Console.WriteLine($"{m}");
            }

        }
    }
}
