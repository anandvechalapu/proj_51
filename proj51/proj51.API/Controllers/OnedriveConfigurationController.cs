using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj51.DTO;
using proj51.Service;

namespace proj51.API
{
    [Route("[controller]")]
    [ApiController]
    public class OnedriveConfigurationController : ControllerBase
    {
        private readonly OnedriveConfigurationService _onedriveConfigurationService;

        public OnedriveConfigurationController(OnedriveConfigurationService onedriveConfigurationService)
        {
            _onedriveConfigurationService = onedriveConfigurationService;
        }

        [HttpGet]
        public async Task<ActionResult<OnedriveConfigurationModel>> GetOnedriveConfigurationAsync(Guid id)
        {
            var onedriveConfiguration = await _onedriveConfigurationService.GetOnedriveConfigurationAsync(id);
            return Ok(onedriveConfiguration);
        }

        [HttpPost]
        public async Task<ActionResult<OnedriveConfigurationModel>> AddOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            var onedriveConfiguration = await _onedriveConfigurationService.AddOnedriveConfigurationAsync(model);
            return Ok(onedriveConfiguration);
        }

        [HttpPut]
        public async Task<ActionResult<OnedriveConfigurationModel>> UpdateOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            var onedriveConfiguration = await _onedriveConfigurationService.UpdateOnedriveConfigurationAsync(model);
            return Ok(onedriveConfiguration);
        }

        [HttpDelete]
        public async Task DeleteOnedriveConfigurationAsync(Guid id)
        {
            await _onedriveConfigurationService.DeleteOnedriveConfigurationAsync(id);
        }
    }
}