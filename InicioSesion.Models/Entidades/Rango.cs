using System.ComponentModel.DataAnnotations;
public class Rango
{
    [Key]
    public int IdRango { get; set; }
    public string? NombreRango { get; set; }
}