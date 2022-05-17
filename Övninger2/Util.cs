using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal static class Util
    {
        public static string AskForString(string prompt)
        {
            bool success = false;
            string age;

            do
            {
                Console.WriteLine($"{prompt}: ");
                age = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(age))
                {
                    Console.WriteLine($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return age;
        }

        internal static uint AskForUInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);
                if (uint.TryParse(input, out uint answer))
                {
                    return answer;
                }

            } while (true);
        }
    }
}

