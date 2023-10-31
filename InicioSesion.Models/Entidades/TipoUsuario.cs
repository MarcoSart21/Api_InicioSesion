using System.ComponentModel.DataAnnotations;

public class TipoUsuario
{
    [Key]
    public int IdTipoUsuario { get; set; }
    public string? NombreTipoUsuario { get; set; }
    public string? Descripcion { get; set; }
}