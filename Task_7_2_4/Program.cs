using System;

namespace Task_7_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class BaseClass
        {
            virtual public int Counter
            {
                get;
                set;
            }
        }

        class DerivedClass : BaseClass
        {
            override public int Counter
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Значение должно быть > 0.");
                    }
                    else
                    {
                        Counter = value;
                    }
                };
            }
        }
    }
}
