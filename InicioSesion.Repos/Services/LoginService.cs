using InicioSesion.Repos.Interfaces;

public class LoginService : Ilogin
{
    public async Task<bool> Login(User user)
    {
        return true;
    }
    
}
