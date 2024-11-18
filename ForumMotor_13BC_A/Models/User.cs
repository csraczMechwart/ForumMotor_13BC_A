using Microsoft.AspNetCore.Identity;

namespace ForumMotor_13BC_A.Models
{
    public class User : IdentityUser
    {
        string? VezetkNev {  get; set; }
        string? KeresztNev {  get; set; }
    }
}
