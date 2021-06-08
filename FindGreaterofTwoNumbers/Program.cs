using System;

namespace FindGreaterofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please enter first number");
            number1 = Convert.ToInt32(Console.ReadLine()); // this statement is to convert a string into an int

            Console.WriteLine("Please enter second number");
            number2 = Convert.ToInt32(Console.ReadLine()); // this statement is to convert a string into an int

            if(number1>number2)
            {
                Console.WriteLine(number1.ToString() + " is greater than " + number2.ToString());
            }
            else
            {
                Console.WriteLine("Number 2 is a greater number");
            }
        }
    }
}
