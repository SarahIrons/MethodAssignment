using System;


//MAIN METHOD ASSIGNMENT


namespace MethodAssignment
{
    public class Program
    {

        private static void Main()
        {
            var myClass = new MultiplyClass(); // instatiate my class 
            Console.WriteLine("Please enter a number here,  ");
            int inputA = Int32.Parse(Console.ReadLine()); //gets input as a string and stores it, and converts to integer.
            Console.WriteLine("Optionally pass another number here");
            var inputB = Console.ReadLine(); // because we don't know if the user will input something we can't convert it right away
            bool res;  // We use TryParse to check if we have a result that can be an int
            int a;
            res = int.TryParse(inputB, out a);
            if (res) // Then we use that result as a conditional boolean to determine if we have an inputB to parse/run in the method
            {
                myClass.MultiplyNumbers(inputA, Int32.Parse(inputB)); 
            } else {
                myClass.MultiplyNumbers(inputA); //otherwise we run it with just inputA
             }

        }
    }
}


