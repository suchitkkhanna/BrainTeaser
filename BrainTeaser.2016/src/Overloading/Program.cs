using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            int i = 10;

            // What is the output of the following ?
            d.Foo(i);

            Console.ReadLine();
        }
    }
}
