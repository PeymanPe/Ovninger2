using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal class GroupCustomerCinema
    {
        public uint Price { get;}
        public uint CustomerNumber { get; set; }
        public GroupCustomerCinema( uint customerNumber)
        {
            CustomerNumber = customerNumber;
        }
     


    }


}
