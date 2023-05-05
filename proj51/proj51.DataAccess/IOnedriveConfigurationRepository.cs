using proj51.DTO;
namespace proj51.Service
{
    public interface IOnedriveConfigurationRepository
    {
        Task<OnedriveConfigurationModel> GetOnedriveConfigurationAsync(Guid id);
        Task<OnedriveConfigurationModel> AddOnedriveConfigurationAsync(OnedriveConfigurationModel model);
        Task<OnedriveConfigurationModel> UpdateOnedriveConfigurationAsync(OnedriveConfigurationModel model);
        Task DeleteOnedriveConfigurationAsync(Guid id);
    }
}