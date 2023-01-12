using Microsoft.AspNetCore.Identity;

namespace Boake_BackEnd.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
