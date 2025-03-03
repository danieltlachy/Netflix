//clase para envio y recepcion de datos de usuario evitando usar las clases asociadas a la bd
namespace backendnet.Models;

public class CustomIdentityUserDTO
{
    public string? Id { get; set; }

    public required string Email { get; set; }

    public required string Nombre { get; set; }

    public required string Rol { get; set; }
}