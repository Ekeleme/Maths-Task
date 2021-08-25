using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes two numbers and Subtracts them from each other. 
            Console.WriteLine("Hi, This application will Subtract the two numbers you'll be asked to provide.");

            Console.Write("Please Enter Your First Number... ");
            int firstInput = int.Parse(Console.ReadLine());
            
            Console.Write("Please Enter Your Second Number... ");
            int secondInput = int.Parse(Console.ReadLine());

            int result = firstInput - secondInput;

            Console.WriteLine("Your Answer is " + result);
        }
    }
}
