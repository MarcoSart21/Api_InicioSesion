using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Usuario")]
public class UsuarioController:ControllerBase
{
    readonly Iusuarios _UsuarioService;
    
    public UsuarioController(Iusuarios login)
    {
        _UsuarioService = login;
    }
    
    
    [HttpGet("Consultar")]
    public async Task<IActionResult> ObtenerConsulta()
    {
        var result = await _UsuarioService.Consultar();
        return Ok(result);
    }
    
    [HttpPost("IniciarSesion")]
    public async Task<IActionResult> IniciarSesion(Usuarios usuario)
    {   
        var result = await _UsuarioService.Agregar(usuario);
        return  Ok(result);
    }   

    [HttpPut("Actualizar")]
    public async Task<IActionResult> Actualizar(Usuarios usuario)
    {
        var result = await _UsuarioService.Actualizar(usuario);
        return Ok(result);
    }

    [HttpDelete("Eliminar")]
    public async Task<IActionResult> Eliminar(int usuario)
    {
        var result = await _UsuarioService.Eliminar(usuario);
        return Ok(result);
    }

    
}