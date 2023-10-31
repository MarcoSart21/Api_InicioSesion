public interface ITipo
{
    Task<List<TipoUsuario>> Consultar();

    Task<bool> Agregar(TipoUsuario TUsuario);

    Task<bool>Actualizar(TipoUsuario TUsuario);

    Task<bool>Eliminar(int IdTipoUsuario);
}