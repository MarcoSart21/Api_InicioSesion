using InicioSesion.Repos.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class SeguridadController:ControllerBase
{
    readonly Ilogin _loginService;
    readonly GatoFractalDBContext _GatoFractalDBContext;
    
    public SeguridadController(Ilogin login)
    {
        _loginService = login;
        // _loginService = new LoginService();
    }
    
    [HttpPost("Login")]
    public async Task<IActionResult> IniciarSesion(User user)
    {   
        var result = await _loginService.Login(user);
        return  Ok(result);
    }
}