using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Tipo de Rangos")]
public class RangoController:ControllerBase
{
    readonly IRango _Rango;
    
    public RangoController(IRango rango)
    {
        _Rango = rango;
    }
    
    
    [HttpGet("Consultar")]
    public async Task<IActionResult> ObtenerConsulta()
    {
        var result = await _Rango.Consultar();
        return Ok(result);
    }
    
    [HttpPost("Agregar")]
    public async Task<IActionResult> Agregar(Rango rango)
    {   
        var result = await _Rango.Agregar(rango);
        return  Ok(result);
    }   

    [HttpPut("Actualizar")]
    public async Task<IActionResult> Actualizar(Rango rango)
    {
        var result = await _Rango.Actualizar(rango);
        return Ok(result);
    }

    [HttpDelete("Eliminar")]
    public async Task<IActionResult> Eliminar(int IdRango)
    {
        var result = await _Rango.Eliminar(IdRango);
        return Ok(result);
    }

    
}