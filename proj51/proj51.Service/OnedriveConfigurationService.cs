using proj51.DTO;
using proj51.DataAccess;
using System;
using System.Threading.Tasks;

namespace proj51.Service
{
    public class OnedriveConfigurationService : IOnedriveConfigurationService
    {
        private readonly IOnedriveConfigurationRepository _onedriveConfigurationRepository;

        public OnedriveConfigurationService(IOnedriveConfigurationRepository onedriveConfigurationRepository)
        {
            _onedriveConfigurationRepository = onedriveConfigurationRepository;
        }

        public async Task<OnedriveConfigurationModel> GetOnedriveConfigurationAsync(Guid id)
        {
            return await _onedriveConfigurationRepository.GetOnedriveConfigurationAsync(id);
        }

        public async Task<OnedriveConfigurationModel> AddOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            return await _onedriveConfigurationRepository.AddOnedriveConfigurationAsync(model);
        }

        public async Task<OnedriveConfigurationModel> UpdateOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            return await _onedriveConfigurationRepository.UpdateOnedriveConfigurationAsync(model);
        }

        public async Task DeleteOnedriveConfigurationAsync(Guid id)
        {
            await _onedriveConfigurationRepository.DeleteOnedriveConfigurationAsync(id);
        }
    }
}