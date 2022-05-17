using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovninger2
{
    internal class CustomerCinema
    {
        private List<Customer> customerCinema;

        public CustomerCinema()
        {
            customerCinema = new List<Customer>();
        }

        public void AddCustomer(uint age)
        {
            Customer customer = new Customer(age);
            customerCinema.Add(customer);
        }

        internal List<Customer> GetCustomer()
        {
            return customerCinema.ToList();
        }
    }
}
