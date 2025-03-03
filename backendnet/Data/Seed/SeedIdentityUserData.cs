using backendnet.Models;
using Microsoft.AspNetCore.Identity; 
using Microsoft.EntityFrameworkCore;

namespace backendnet.Data.Seed;

public static class SeedIdentityUserData
{
    public static void SeedUserIdentityData(this ModelBuilder modelBuilder){
        
        // Agregar el rol "Administrador" a la tabla AspNetRoles 
        string AdministradorRoleId = Guid.NewGuid().ToString(); 
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = AdministradorRoleId,
            Name = "Administrador",
            NormalizedName = "Administrador".ToUpper()
        });

        // Agregar el rol "Usuario" a la tabla AspNetRoles 
        string UsuarioRoleId = Guid.NewGuid().ToString(); 
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = UsuarioRoleId,
            Name = "Usuario",
            NormalizedName = "Usuario".ToUpper()
        });
        
        // Agregamos un usuario a la tabla AspNetUsers 
        var UsuarioId = Guid.NewGuid().ToString(); 
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId, // primary key
                UserName = "tlacho@uv.mx",
                Email = "tlacho@uv.mx",
                NormalizedEmail = "tlacho@uv.mx".ToUpper(),
                Nombre = "Daniel Mongeote Tlachy",
                NormalizedUserName = "tlacho@uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "tlacho"), 
                Protegido = true // Este no se puede eliminar
            }
        );

        // Aplicamos la relación entre el usuario y el rol en la tabla AspNetUserRoles 
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = AdministradorRoleId,
                UserId = UsuarioId
            }
        );

        // Agregamos un usuario a la tabla AspNetUsers 
        UsuarioId = Guid.NewGuid().ToString(); 
        modelBuilder.Entity<CustomIdentityUser>().HasData(
            new CustomIdentityUser
            {
                Id = UsuarioId, // primary key
                UserName = "patito@uv.mx",
                Email = "patito@uv.mx",
                NormalizedEmail = "patito@uv.mx". ToUpper(),
                Nombre = "Usuario patito",
                NormalizedUserName = "patito@uv.mx".ToUpper(),
                PasswordHash = new PasswordHasher<CustomIdentityUser>().HashPassword(null!, "patito")
            }
        );

        // Aplicamos la relación entre el usuario y el rol en la tabla AspNetUserRoles 
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = UsuarioRoleId,
                UserId = UsuarioId
            }
        );
    }
}