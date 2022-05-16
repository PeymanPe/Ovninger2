using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal class CinemaTicket
    {
        private string ticketPrice;
        public int CustomerAge { get; set; }
        public string Íssueticket()
        {
            if(CustomerAge <20)
            {
                return "80kr"; 
            }
            else
            {
                return "ff";
            }
        }

    }
}
