public interface IPuntuaciones
{
    Task<List<Puntuaciones>> Consultar();

    Task<bool> Agregar(Puntuaciones puntuaciones);

    Task<bool>Actualizar(Puntuaciones puntuaciones);

    Task<bool>Eliminar(int IdPuntuaciones);
}