using System.ComponentModel.DataAnnotations;

public class HistorialPartidas
{
    [Key]
    public int IdHistorial { get; set; }
    public int? Victorias { get; set; } 
    public int? Derrotas { get; set; } 
    public int? Empates { get; set; }
    public int IdUsuarios { get; set; }
}