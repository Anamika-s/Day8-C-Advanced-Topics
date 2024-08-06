using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesDemo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
     class CustomAttribute : Attribute
    {
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public string DateOfCreation { get; set; } 
    }

    [Custom(AuthorName ="aaa", Description ="aaa")]
    class Developer
    {
        [Custom(AuthorName ="Deepak", Description ="this method is being used to get details from user", DateOfCreation ="12/12/2023")]
        public void Get()
        {
            Console.WriteLine("inside get");
        }
        [Custom(AuthorName ="Ajay", Description ="to display info", DateOfCreation ="12/12/2022")]
        public void Display()
        {
            Console.WriteLine("inside display");
        }
    }

    class Program
    {
        static void Main()
        {
            Developer dev = new Developer();
            dev.Get();
            dev.Display();
        }
    }

}
