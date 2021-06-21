using System;

namespace communication_log
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change background color
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("This is a simulated response from the Pilot");

            Console.WriteLine("simulated response from control");

            Console.WriteLine("Another response from pilot");

        }
    }
}
