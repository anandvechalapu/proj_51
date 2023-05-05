using proj51.DTO;
using proj51.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace proj51.API
{
    [Route("api/[controller]")]
    public class JiraActivationController : Controller
    {
        private readonly ICustomerService _customerService;

        public JiraActivationController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> ActivateJira([FromBody] CustomerDTO customerDTO)
        {
            await _customerService.AddCustomerAsync(customerDTO.Name);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeactivateJira([FromBody] CustomerDTO customerDTO)
        {
            await _customerService.DeleteCustomerAsync(customerDTO.Name);
            return Ok();
        }
    }
}