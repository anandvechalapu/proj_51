using System.Threading.Tasks;
using proj51.DataAccess;
using proj51.DTO;

namespace proj51.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddCustomerAsync(string customerName)
        {
            var customerDTO = new CustomerDTO
            {
                Name = customerName
            };

            await _customerRepository.CreateCustomerAsync(customerDTO);
        }

        public async Task DeleteCustomerAsync(string customerName)
        {
            await _customerRepository.DeleteCustomerAsync(customerName);
        }
    }
}