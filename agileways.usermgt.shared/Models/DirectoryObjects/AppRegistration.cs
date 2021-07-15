

namespace agileways.usermgt.shared.Models.DirectoryObjects
{
    public class AppRegistration
    {
        public string DisplayName { get; set; }
        public string Id { get; set; }
        public ServicePrincipal Spn { get; set; }
        public int RoleCount { get; set; }
    }
}