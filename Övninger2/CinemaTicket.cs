using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal class CinemaTicket
    {

        public uint TicketPrice { get; set; }
        //public int CustomerAge { get; set; }
        public AgeCategory AgeCategory { get; set; }

        public CinemaTicket(AgeCategory ageCategory)
        {

            AgeCategory = ageCategory;
        }

        public string Íssueticket()
        {
            if (AgeCategory ==AgeCategory.Juvenile)
            {
                TicketPrice = 80;
                return "80kr";
            }
            else if (AgeCategory == AgeCategory.Pensioner)
            {
                TicketPrice = 90;
                return "90kr";
            }
            else
            {
                TicketPrice = 120;
                return "120kr";
            }

        }

        //{
        //    if (CustomerAge < 20)
        //    {
        //        ticketPrice = "80kr";
        //        return "80kr";
        //    }
        //    else if (CustomerAge > 64)
        //    {
        //        ticketPrice = "90kr";
        //        return "90kr";
        //    }
        //    else
        //    {
        //        ticketPrice = "120kr";
        //        return "120kr";
        //    }

        //}



    }
}
