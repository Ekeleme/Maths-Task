using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Takes three numbers and Multiplies them. 
            Console.WriteLine("Hi, This application will Multiply the three numbers you'll be asked to provide.");
            
            Console.Write("Please Enter Your First Number... ");
            int firstInput = int.Parse(Console.ReadLine());
            
            Console.Write("Please Enter Your Second Number... ");
            int secondInput = int.Parse(Console.ReadLine());
            
            Console.Write("Please Enter Your Third Number... ");
            int thirdInput = int.Parse(Console.ReadLine());

            int result = firstInput * secondInput * thirdInput;

            Console.WriteLine("Your Answer is " + result); 
        }
    }
}
