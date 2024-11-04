using System;

namespace Constructor
{
    public class Test
    {
        public string Value;

        public Test()
        {
            Value = "This is default constructor";
        }

        public Test(string name)
        {
            Value = name;
        }

        public void PrintName()
        {
            Console.WriteLine(Value);
        }
    }

    class MainClass
    {
        static void Main()
        {

            Test Test1 = new Test();
            Test1.PrintName();

            Test Test2 = new Test("This is parameterized constructor");
            Test2.PrintName();

            Console.ReadLine();
        }
    }
}
