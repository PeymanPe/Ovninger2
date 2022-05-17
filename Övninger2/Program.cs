using System;
using System.Collections.Generic;

namespace Ovninger2
{
    internal class Program
    {
        static CustomerCinema customerCinema = new CustomerCinema();
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
                        PrintCustomer();



                        break;
                    case "4":
                        AskCustomerNumber();

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
            
            customerCinema.AddCustomer(age);

        
        }
        private static void AskCustomerNumber()
        {
            Console.WriteLine("Enter the number of people in your group: ");

            uint num = Util.AskForUInt("number");
            for (int i = 0; i < num; i++)
            {
                AskAge();
            }
            PrintCustomer();


        }
        private static void PrintCustomer(uint custemorNumber = 1)
        {
            List<Customer> customers = customerCinema.GetCustomer();
            if (custemorNumber == 1)
            {
                Console.WriteLine(customers[customers.Count-1]);
            }
            else
            {

                
                Console.WriteLine(customers[customers.Count-1]);
            }

            //foreach (var customer in customers)
            //{
            //    //Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            //    Console.WriteLine(customer);
            //}
        }
        private static void ShowMainMeny()
        {
            Console.WriteLine("1: Youth or pensioner ");
            Console.WriteLine("2: Repeat ten times");
            Console.WriteLine("3: The third word");
            Console.WriteLine("4: Cinema Group tickets");

        }
    }
}
