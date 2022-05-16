using System;

namespace Övninger2
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
                        Console.WriteLine("felaktig input");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            }
            while (true);
            Console.WriteLine("Hello World!");
        }
        private static void ShowMainMeny()
        {
            Console.WriteLine("0: Ungdom eller pensionär ");
           
        }
    }
}
