#define C1
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesDemo
{
    internal class Attribute1
    {

        [Obsolete("use NewAddNumbers() method", false)]
        static void AddNumbers() {
            Console.WriteLine("inside AddNumbers");
        }

        static void NewAddNumbers()
        {
            Console.WriteLine("inside NewAddNumbers");
        }
        [Conditional("C1")]
        static void Add()
        {
            Console.WriteLine("inside Add");
        }


static void Main()
        {
            AddNumbers();
            Add();
        }
    }
}
