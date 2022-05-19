using System;

namespace Task_7_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начнём!");
            Dirived dc = new Dirived();
            dc.Display();
        }
        class BaseClass
        {
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }

        }
        class Dirived : BaseClass
        {
            public override void Display()
            {
                base.Display();
                Console.WriteLine("Метод класса DerivedClass");
            }
        }
    }
}
