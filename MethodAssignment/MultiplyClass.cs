using System;
using System.Runtime.InteropServices;


namespace MethodAssignment
{
    internal class MultiplyClass
    {
        public void MultiplyNumbers(int a, [Optional] int b)
        {
            int output = (a * 2) + (b * 2);
            Console.WriteLine("Your number(s) times two, and then added together, is: " + output);
        }
    }
}