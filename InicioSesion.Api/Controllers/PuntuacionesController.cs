using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Puntuaciones")]
public class PuntuacionesController:ControllerBase
{
    readonly IPuntuaciones _puntuaciones;
    
    public PuntuacionesController(IPuntuaciones puntuaciones)
    {
        _puntuaciones = puntuaciones;
    }
    
    
    [HttpGet("Consultar")]
    public async Task<IActionResult> ObtenerConsulta()
    {
        var result = await _puntuaciones.Consultar();
        return Ok(result);
    }
    
    [HttpPost("Agregar")]
    public async Task<IActionResult> Agregar(Puntuaciones puntuaciones)
    {   
        var result = await _puntuaciones.Agregar(puntuaciones);
        return  Ok(result);
    }   

    [HttpPut("Actualizar")]
    public async Task<IActionResult> Actualizar(Puntuaciones puntuaciones)
    {
        var result = await _puntuaciones.Actualizar(puntuaciones);
        return Ok(result);
    }

    [HttpDelete("Eliminar")]
    public async Task<IActionResult> Eliminar(int IdPuntuaciones)
    {
        var result = await _puntuaciones.Eliminar(IdPuntuaciones);
        return Ok(result);
    }

    
}