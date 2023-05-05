Visual Studio

using System;
using proj51.DTO;

namespace proj51.Service 
{
    public class CustomerService
    {
        public Customer GetCustomer(string custId)
        {
            //some code
        }
    }

}

using System;
using proj51.DTO;

namespace proj51.Service
{
    public interface ICustomerService
    {
        Customer GetCustomer(string custId);
    }
}