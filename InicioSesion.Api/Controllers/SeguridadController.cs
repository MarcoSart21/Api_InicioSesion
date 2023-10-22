using Microsoft.AspNetCore.Mvc;

public class SeguridadController:ControllerBase
{
    [HttpPost("Login")]
    public IActionResult IniciarSesion(User user)
    {
        return  Ok(true);
    }
}