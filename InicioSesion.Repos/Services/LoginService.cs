using InicioSesion.Repos.Interfaces;

public class LoginService : Ilogin
{
    public async Task<bool> Login(User user)
    {
        return await Task.FromResult(true);
    }
    
}
