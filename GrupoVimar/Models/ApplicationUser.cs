using Microsoft.AspNetCore.Identity;

namespace GrupoVimar.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
    }
}
