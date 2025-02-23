using Microsoft.AspNetCore.Identity;

namespace TamirhanemBackend.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
    }
}