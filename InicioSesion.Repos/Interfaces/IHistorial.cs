public interface IHistorial
{
    Task<List<HistorialPartidas>> Consultar();

    Task<bool> Agregar(HistorialPartidas Historial);

    Task<bool>Actualizar(HistorialPartidas Historial);

    Task<bool>Eliminar(int IdHistorial);
}