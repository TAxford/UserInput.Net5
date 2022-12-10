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

        static void Main(string[] args)
        {
            //Prompts user to write something
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter a number");
            string input2 = Console.ReadLine();
            Console.WriteLine(input + input2);
            Console.Read();
        }


    }
}
