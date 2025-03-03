using Microsoft.AspNetCore.Identity;

namespace backendnet.Models;

public class CustomIdentityUser: IdentityUser //hereda de IdentityUser los atributos id, email y contraseña
{
    public required string Nombre { get; set; }

    public bool Protegido { get; set; } = false;
}