using Microsoft.AspNetCore.Identity;

namespace GrupoVimar.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Puedes agregar campos personalizados si quieres
        public string Nombre { get; set; }
    }
}
