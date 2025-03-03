using System.Text.Json.Serialization;

namespace backendnet.Models;

public class Categoria
{
    public int CategoriaId { get; set; } //llave primaria

    public required string Nombre { get; set; }

    public bool Protegida { get; set; } = false;
    
    [JsonIgnore] 
    //indica al framework que no envia al usuario esta coleccion al 
    //momento de enviar la respuesta para evitar un ciclo infinito
    public ICollection<Pelicula>? Peliculas { get; set; }
}