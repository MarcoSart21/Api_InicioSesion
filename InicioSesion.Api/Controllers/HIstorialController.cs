using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Historial de Partidas")]
public class HistorialController:ControllerBase
{
    readonly IHistorial _Historial;
    
    public HistorialController(IHistorial historial)
    {
        _Historial = historial;
    }
    
    
    [HttpGet("Consultar")]
    public async Task<IActionResult> ObtenerConsulta()
    {
        var result = await _Historial.Consultar();
        return Ok(result);
    }
    
    [HttpPost("Agregar")]
    public async Task<IActionResult> Agregar(HistorialPartidas Historial)
    {   
        var result = await _Historial.Agregar(Historial);
        return  Ok(result);
    }   

    [HttpPut("Actualizar")]
    public async Task<IActionResult> Actualizar(HistorialPartidas Historial)
    {
        var result = await _Historial.Actualizar(Historial);
        return Ok(result);
    }

    [HttpDelete("Eliminar")]
    public async Task<IActionResult> Eliminar(int IdHistorial)
    {
        var result = await _Historial.Eliminar(IdHistorial);
        return Ok(result);
    }

    
}