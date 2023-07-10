// See https://aka.ms/new-console-template for more information
using System.Reflection;

var type1 = typeof(ClassLibrary1.Struct1);

var flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.FlattenHierarchy;
foreach (MemberInfo m in type1.GetMembers(flags))
{
    Console.WriteLine($"{m}");
}


