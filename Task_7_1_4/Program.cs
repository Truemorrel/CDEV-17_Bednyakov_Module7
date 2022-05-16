using System;

namespace Task_7_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //ProjectManager и Developer
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }
        class ProjectManager : Employee
        {
            public string ProjectName;
        }
        class Developer : Employee
        {
            private string ProgrammingLanguage;
        }
    }
}
