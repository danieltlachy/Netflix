using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backendnet.Migrations
{
    /// <inheritdoc />
    public partial class Relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7cd5f56f-9301-40bb-b92a-3ff0f65bd44b", "2b10c10c-1a62-4ca2-b751-bcd54cb1f1f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a2e0dddd-5f90-4ee1-8f9d-0ef54858bf37", "bbff43f8-581d-492b-8173-5042438bfd66" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cd5f56f-9301-40bb-b92a-3ff0f65bd44b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2e0dddd-5f90-4ee1-8f9d-0ef54858bf37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b10c10c-1a62-4ca2-b751-bcd54cb1f1f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbff43f8-581d-492b-8173-5042438bfd66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a6c8ce2-d730-42f2-ac91-5085f27a7b21", null, "Administrador", "ADMINISTRADOR" },
                    { "b122054d-a0a3-491d-bef1-5dc573d7faaa", null, "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b10b5398-46a2-486a-8c6d-45153adfb855", 0, "0bacf698-c0f8-42e2-8792-1146e7dfd9a2", "tlacho@uv.mx", false, false, null, "Daniel Mongeote Tlachy", "TLACHO@UV.MX", "TLACHO@UV.MX", "AQAAAAIAAYagAAAAEHarf3O6NbIT19ebchB8LoDAeqZPproAFZJXW/Wdtx89UvIhmb0jk47i13WRW6z84g==", null, false, true, "89f9bf42-1b82-4a02-aa76-a3905dc20056", false, "tlacho@uv.mx" },
                    { "b3ea40c8-bef7-4cf4-8355-85e0d4f4b5ba", 0, "22f615a0-52cc-4dea-861e-cb527a86de95", "patito@uv.mx", false, false, null, "Usuario patito", "PATITO@UV.MX", "PATITO@UV.MX", "AQAAAAIAAYagAAAAEDMiRk1TcvTDoHxEDdnvp4pRRb3pDkSNzIkDsrdz+25yMb6dvgQTkSQRfRr3Eox+0w==", null, false, false, "b9d9c56c-5e32-4aab-90aa-e0b772d5bd88", false, "patito@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "CategoriaPelicula",
                columns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 2, 3 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 4, 10 },
                    { 4, 11 },
                    { 4, 13 },
                    { 4, 14 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 5 },
                    { 8, 2 },
                    { 8, 3 },
                    { 8, 4 },
                    { 8, 5 },
                    { 8, 6 },
                    { 8, 7 },
                    { 8, 12 },
                    { 10, 9 },
                    { 10, 15 },
                    { 15, 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0a6c8ce2-d730-42f2-ac91-5085f27a7b21", "b10b5398-46a2-486a-8c6d-45153adfb855" },
                    { "b122054d-a0a3-491d-bef1-5dc573d7faaa", "b3ea40c8-bef7-4cf4-8355-85e0d4f4b5ba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0a6c8ce2-d730-42f2-ac91-5085f27a7b21", "b10b5398-46a2-486a-8c6d-45153adfb855" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b122054d-a0a3-491d-bef1-5dc573d7faaa", "b3ea40c8-bef7-4cf4-8355-85e0d4f4b5ba" });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 8, 12 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "CategoriaPelicula",
                keyColumns: new[] { "CategoriasCategoriaId", "PeliculasPeliculaId" },
                keyValues: new object[] { 15, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a6c8ce2-d730-42f2-ac91-5085f27a7b21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b122054d-a0a3-491d-bef1-5dc573d7faaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10b5398-46a2-486a-8c6d-45153adfb855");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3ea40c8-bef7-4cf4-8355-85e0d4f4b5ba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7cd5f56f-9301-40bb-b92a-3ff0f65bd44b", null, "Usuario", "USUARIO" },
                    { "a2e0dddd-5f90-4ee1-8f9d-0ef54858bf37", null, "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Protegido", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b10c10c-1a62-4ca2-b751-bcd54cb1f1f6", 0, "d7b33ad1-2d5a-4f8c-bbbf-24d4bf217ddd", "patito@uv.mx", false, false, null, "Usuario patito", "PATITO@UV.MX", "PATITO@UV.MX", "AQAAAAIAAYagAAAAEJehdJQ9yiYIchv2O17FFOTz+Q/Izi9bmOpPOBhMTXXU3VRabTiKACfdW7l9ovha5g==", null, false, false, "b52ec16d-db44-40ed-9e2c-f8379824742d", false, "patito@uv.mx" },
                    { "bbff43f8-581d-492b-8173-5042438bfd66", 0, "e7e91c25-6a58-46ee-bc2a-e88600e60c15", "tlacho@uv.mx", false, false, null, "Daniel Mongeote Tlachy", "TLACHO@UV.MX", "TLACHO@UV.MX", "AQAAAAIAAYagAAAAEFwZoDGMV0GLZKD84X33RpMhx35SbfKHAe4YfMrnFql+PGqPyneGsrOAx+8ax74qjA==", null, false, true, "451ceac7-ac98-43fe-810f-f975c4f974e0", false, "tlacho@uv.mx" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7cd5f56f-9301-40bb-b92a-3ff0f65bd44b", "2b10c10c-1a62-4ca2-b751-bcd54cb1f1f6" },
                    { "a2e0dddd-5f90-4ee1-8f9d-0ef54858bf37", "bbff43f8-581d-492b-8173-5042438bfd66" }
                });
        }
    }
}
