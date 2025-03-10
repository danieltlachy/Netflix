namespace backendnet.Models;

public class Pelicula
{
    public int PeliculaId { get; set; } //llave primaria
    
    public string Titulo { get; set; } = "Sin título";

    public string Sinopsis { get; set; } = "Sin sinopsis";
    
    public int Anio { get; set; }

    public string Poster { get; set; } = "N/A";

    public ICollection<Categoria>? Categorias { get; set; }
}