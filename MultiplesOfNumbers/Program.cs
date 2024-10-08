
using System.Runtime.CompilerServices;//includes library

namespace MultiplesOfNumbers//names the program

{
    class Program//allows for classes
    {
        static void Main(string[] args)//main entrypoint function
        {
            int i, number;//initiates variables
            
            Console.Write("What is the number you want multiplied?: ");//prompt to user
            number = Convert.ToInt32(Console.ReadLine());//takes input, converts to integer and stores in a variable


            Console.Write("How many times do you want it done?: ");//prompt to user
            int times = Convert.ToInt32(Console.ReadLine());//takes input, converts to integer and stores in a variable

            for (i = 1; i <= times; i++)//for loop assignment, condition and increment
            {
                //prints result to user with placeholders, new line and rotates through numbers
                Console.WriteLine(" {0} x {1} = {2} \n ", number, i, number * i);
            }

          

            Console.ReadKey();//prevents console from closing until a key is hit
        }

    }
}
