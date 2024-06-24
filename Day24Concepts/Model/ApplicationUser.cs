using Microsoft.AspNetCore.Identity;
using System.Data.Common;

namespace BookStoreAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
