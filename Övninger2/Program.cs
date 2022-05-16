using System;

namespace Ovninger2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ShowMainMeny();
                string input= Console.ReadLine();
                switch (input)
                {
                    case "0":
                        Console.WriteLine("Incorrect input");
                        Environment.Exit(0);
                        break;
                    case "1":
                        AskAge();
                        
                      
                        break;
                    default:
                        break;
                }

            }
            while (true);
            Console.WriteLine("Hello World!");
        }
        private static void AskAge()
        {
            Console.WriteLine("Enter your age");

            uint age = Util.AskForUInt("age");
            CinemaAge cinemaAgeControl = new CinemaAge(age);
            cinemaAgeControl.PrintAge();

        
        }
        private static void ShowMainMeny()
        {
            Console.WriteLine("1: Youth or pensioner ");
            Console.WriteLine("Repeat ten times");
            Console.WriteLine("The third word");
           
        }
    }
}
