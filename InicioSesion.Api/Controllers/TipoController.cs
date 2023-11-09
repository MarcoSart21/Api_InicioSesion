using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/TiposdeUsuario")]
public class TipoController:ControllerBase
{
    readonly ITipo _TipoService;
    
    public TipoController(ITipo tipo)
    {
        _TipoService = tipo;
    }
    
    
    [HttpGet("Consultar")]
    public async Task<IActionResult> ObtenerConsulta()
    {
        var result = await _TipoService.Consultar();
        return Ok(result);
    }
    
    [HttpPost("Agregar")]
    public async Task<IActionResult> Agregar(TipoUsuario TUsuario)
    {   
        var result = await _TipoService.Agregar(TUsuario);
        return  Ok(result);
    }   

    [HttpPut("Actualizar")]
    public async Task<IActionResult> Actualizar(TipoUsuario TUsuario)
    {
        var result = await _TipoService.Actualizar(TUsuario);
        return Ok(result);
    }

    [HttpDelete("Eliminar")]
    public async Task<IActionResult> Eliminar(int IdTipoUsuario)
    {
        var result = await _TipoService.Eliminar(IdTipoUsuario);
        return Ok(result);
    }

    
}