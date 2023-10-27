using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Seguridad")]
public class SeguridadController:ControllerBase
{
    readonly Ilogin _loginService;
    
    public SeguridadController(Ilogin login)
    {
        _loginService = login;
        // _loginService = new LoginService();
    }
    
    [HttpPost("Login")]
    public async Task<IActionResult> Login(User user)
    {   
    
        var result = await _loginService.Login(user);
        return  Ok(result);
    }
}