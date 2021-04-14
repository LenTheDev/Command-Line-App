using System;

namespace Command_Line_App
{
    class Program
    {
        static void Main(string[] args)
        {

            // Print Statement To The Console 

            Console.WriteLine("Enter username:");

            string formatLine = ("------------------------");

            System.Console.WriteLine(formatLine);

            string userName = Console.ReadLine();


            string date = DateTime.Today.ToShortDateString();

            System.Console.WriteLine(formatLine);

            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);


            System.Console.WriteLine(formatLine);

            str = $"How are you today {userName} ?";
            System.Console.WriteLine(str);
        }
    }
}
