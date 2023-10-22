using InicioSesion.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class SeguridadController:ControllerBase
{
    readonly Ilogin _loginService;
    
    public SeguridadController(Ilogin login)
    {
        _loginService = login;
        // _loginService = new LoginService();
    }
    
    [HttpPost("Login")]
    public IActionResult IniciarSesion(User user)
    {   
        var result = _loginService.Login(user);
        return  Ok(true);
    }
}