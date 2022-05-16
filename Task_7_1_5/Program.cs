using System;

namespace Task_7_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class Herbal
        {
            private string PlantName
            {
                get { return PlantName; }
                set { PlantName = value; }  
            }
        }
        class Fruite : Herbal
        {
            private string Name
            {
                get { return Name; }
                set { Name = value; }
            }
        }
        class Vegetable : Herbal
        {
            private string Name
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name = value;
                }
            }
        }
        class Apple : Fruite { }
        class Banana : Fruite { }
        class Pear : Fruite { }
        class Potato : Vegetable { }
        class Carrot : Vegetable { }
    }
}
