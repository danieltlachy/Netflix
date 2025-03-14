// este middleware se usa para revisar si el token está por expirar, si es así, enviará un nuevo token al cliente.
using System.IdentityModel.Tokens.Jwt; 
using System.Security.Claims;
using backendnet.Services;

namespace backendnet.Middlewares;

public class SlidingExpirationJwt(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context, JwtTokenService jwtTokenService)
    {
        try
        {
            string authorization = context.Request.Headers.Authorization!; 
            JwtSecurityToken? token = null;
            if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer")) 
                token = new JwtSecurityTokenHandler().ReadJwtToken(authorization[7..]);
            
            if (token != null && token.ValidTo > DateTime. UtcNow)
            {
                TimeSpan timeRemaining = token.ValidTo.Subtract(DateTime.UtcNow);
                //si quedan 5 minutos, le mandamos un nuevo token
                if (timeRemaining. Minutes <5)
                {
                    var claims = new List<Claim>
                    {
                        new(ClaimTypes.Name, context.User.FindFirstValue(ClaimTypes.Name)!),
                        new(ClaimTypes.GivenName, context.User.FindFirstValue(ClaimTypes.GivenName)!), 
                        new(ClaimTypes.Role, context.User.FindFirstValue(ClaimTypes.Role)!)
                    };
                    context.Response.Headers.Append("Set-Authorization", jwtTokenService.GeneraToken(claims));
                }
            }
        }
        catch (Exception)
        {
            // Ocurrió un fallo al revisar el token
        }
        await next(context);
    }
}

// Esta clase es para poder agregarlo en Program.cs
public static class SlidingExpirationJwtExtensions
{
    public static IApplicationBuilder UseSlidingExpirationJwt(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<SlidingExpirationJwt>();
    }
}