using System.ComponentModel.DataAnnotations;

public class Usuarios

{[Key]
    public int IdUsuarios { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Gametag { get; set; }
    public string? Correo { get; set; } 
    public string? Contrasena { get; set; }
    public string? Genero { get; set; } 
    public int? IdPuntuaciones { get; set; }
    public int? IdTipoUsuario { get; set; }
    public int? IdRango { get; set; }

}