using System;
using System.Reflection;

namespace Reflection_Demo
{

    class Reflection1
    {

        // Main Method
        static void Main(string[] args)
        {
            // Initialise t as typeof string
            Type t = typeof(int);

            // Use Reflection to find about
            // any sort of data related to t
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
        }
    }
}
