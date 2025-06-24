using Microsoft.AspNetCore.Identity;

namespace RegisterLoginDemo.Models
{
    public class ApplicationUser:IdentityUser

    {
        public string? FirstName { get; set; }
    }
}
