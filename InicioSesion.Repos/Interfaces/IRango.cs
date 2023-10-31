public interface IRango
{
    Task<List<Rango>> Consultar();

    Task<bool>Agregar(Rango rango);

    Task<bool>Actualizar(Rango rango);

    Task<bool>Eliminar(int IdRango);
}