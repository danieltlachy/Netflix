// este modelo recibe los datos de inicio de los clientes
namespace backendnet.Models;

public class LoginDTO
{
    public required string Email { get; set; }
    
    public required string Password { get; set; }
}