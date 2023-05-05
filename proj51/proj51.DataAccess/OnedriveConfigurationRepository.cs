using proj51.DTO;
using System;
using System.Threading.Tasks;

namespace proj51
{
    public class OnedriveConfigurationRepository : IOnedriveConfigurationRepository
    {
        public async Task<OnedriveConfigurationModel> GetOnedriveConfigurationAsync(Guid id)
        {
            //TODO: Get onedrive configuration from repository
            return await Task.FromResult(new OnedriveConfigurationModel());
        }

        public async Task<OnedriveConfigurationModel> AddOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            //TODO: Add onedrive configuration to repository
            return await Task.FromResult(new OnedriveConfigurationModel());
        }

        public async Task<OnedriveConfigurationModel> UpdateOnedriveConfigurationAsync(OnedriveConfigurationModel model)
        {
            //TODO: Update onedrive configuration to repository
            return await Task.FromResult(new OnedriveConfigurationModel());
        }

        public async Task DeleteOnedriveConfigurationAsync(Guid id)
        {
            //TODO: Delete onedrive configuration to repository
            await Task.CompletedTask;
        }
    }
}