using System;

namespace UserInput.Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Promts user to write something
            string input = Console.ReadLine();
            Console.WriteLine(input);
            Console.Read();
        }
    }
}
