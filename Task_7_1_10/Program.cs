using System;

namespace Task_7_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class BaseClass
        {
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;
            public DerivedClass(string name, string Description) : base(name) 
            {
                this.Description = Description;
            }
            public DerivedClass(string name, string Description, int Counter) : this(name, Description)   
            {
                this.Counter = Counter;
            }
        }
    }
}
