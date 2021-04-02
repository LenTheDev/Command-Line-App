using System;

namespace Command_Line_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Statement To The Console 
            string userName = "Len";
            string date = DateTime.Today.ToShortDateString();

            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);

            str = $"{str} How are you today?";
            System.Console.WriteLine(str);
        }
    }
}
