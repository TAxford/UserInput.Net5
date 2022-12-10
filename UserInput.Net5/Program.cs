using System;

namespace UserInput.Net5
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            //Prompts user to write something
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
        }*/

        /*static void Main(string[] args)
        {
            //Prompts user to write something
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter a number");
            string input2 = Console.ReadLine();
            Console.WriteLine(input + input2);
            Console.Read();
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }

        public static int Calculate()
        {

            Console.WriteLine("Please enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string number2 = Console.ReadLine();

            int input1 = int.Parse(number1);
            int input2 = int.Parse(number2);

            int result = input1 + input2;


            return result;
        }


    }
}
