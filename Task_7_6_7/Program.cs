using System;

namespace Task_7_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    class Car<T1>
    {
        public T1 engine;
        public virtual void ChangePart<T2> (T2 newPart) { }
    }
    class ElectricEngine { }
    class GasEngine { }
    class Battery { }
    class Differential { }
    class Wheel { }
}