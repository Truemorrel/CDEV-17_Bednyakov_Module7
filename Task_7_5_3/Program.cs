using System;

namespace Task_7_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 3;
            int num2 = 58;

            Helper.Swap(ref num1,ref num2);

            Console.WriteLine(num1); //58
            Console.WriteLine(num2); //3
        }
        class Helper
        {
            public static int Sum(int a, int b, int c)
            {
                return a + b + c;
            }
            public static void Swap(ref int a, ref int b)
            {
                var c = a;
                a = b;
                b = c; 
            }
        }
    }
}
