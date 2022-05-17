using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal class Customer
    {
       
        public uint Age { get; }
        public uint CustemorNumber { get;}
        public uint Price { get; set; }

        //public static int Count { get; set; }


        public AgeCategory AgeCategory
        {
            get 
            {if (Age < 20) 
                {
                    return AgeCategory.Juvenile; 
                } 
            else if (Age > 65)
                {
                    return AgeCategory.Pensioner;
                }
            else 
                {
                    return AgeCategory.Normal;
                }


            }
        }


        public Customer(uint age, uint custemorNumber=1)
        {

            Age = age;
            CustemorNumber = custemorNumber;
        }

        public override string ToString()
        {
            CinemaTicket cinemaTicket = new CinemaTicket(AgeCategory);
 
            cinemaTicket.Íssueticket();
            Price =cinemaTicket.TicketPrice;
 
            //return $" Ticket  price: {cinemaTicket.Íssueticket()}";
            //return $" Ticket  price: {cinemaTicket.TicketPrice}";
            return $" Ticket  price: {Price}";
        }

    }
}
