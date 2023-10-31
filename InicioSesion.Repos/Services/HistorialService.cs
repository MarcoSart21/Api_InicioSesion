using Microsoft.EntityFrameworkCore;
public class HistorialService : IHistorial
{

    public async Task<List<HistorialPartidas>> Consultar()
    {
        using (var conexion = new GatoFractalDBContext())
        {
            var consulta = await(from c in conexion.HistorialPartidas select c).ToListAsync();
            return consulta;
        }
    }

    public async Task<bool> Agregar(HistorialPartidas historialPartidas)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            conexion.HistorialPartidas.Add(historialPartidas);
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }   
        }
    }

    public async Task<bool> Actualizar(HistorialPartidas historialPartidas)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.HistorialPartidas
            where c.IdHistorial==historialPartidas.IdHistorial select c).FirstOrDefault();
            if(consulta!=null)
            {
                consulta.Victorias = historialPartidas.Victorias;
                consulta.Derrotas = historialPartidas.Derrotas;
                consulta.Empates = historialPartidas.Empates;
                consulta.IdUsuarios = historialPartidas.IdUsuarios;

            }
          
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }
        }
    }

    public async Task<bool> Eliminar(int IdHistorial)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.HistorialPartidas
            where c.IdHistorial==IdHistorial select c).FirstOrDefault();
            if(consulta!=null)
            {
              conexion.HistorialPartidas.Remove(consulta);            
            }
          
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}   