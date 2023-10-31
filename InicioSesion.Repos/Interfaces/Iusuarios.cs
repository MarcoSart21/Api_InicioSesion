public interface Iusuarios
{
    Task<List<Usuarios>>Consultar();

    Task<bool>Agregar(Usuarios usua);

    Task<bool>Actualizar(Usuarios usua);

    Task<bool>Eliminar(int IdUsuario);
}
