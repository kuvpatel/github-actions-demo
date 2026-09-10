using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github_actions_demo
{
    public class CustomerService
    {
        public string GetFullName(Customer customer)
        {
            return $"{customer.FirstName} {customer.LastName}";
        }

        public string GetCountry(Customer customer)
        {
            return $"{customer.Country}";
        }
    }
}
