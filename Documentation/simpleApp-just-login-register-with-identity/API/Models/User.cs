using API.Models;
using Microsoft.AspNetCore.Identity;

public class User : IdentityUser<int>
{
    public ICollection<UserRole> UserRoles { get; set; }
}