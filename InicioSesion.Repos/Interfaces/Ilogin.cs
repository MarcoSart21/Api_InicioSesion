
namespace InicioSesion.Repos.Interfaces
{
    public interface Ilogin
    {
       Task<bool> Login(User user);
    }
}