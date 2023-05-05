using System;

namespace proj51
{
    public class OnedriveConfigurationModel
    {
        public Guid Id { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string TenantId { get; set; }
        public string Resource { get; set; }
        public string AuthEndpoint { get; set; }
    }
}