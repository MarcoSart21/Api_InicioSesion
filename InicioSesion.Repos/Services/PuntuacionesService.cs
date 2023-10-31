using Microsoft.EntityFrameworkCore;
public class PuntuacionesService : IPuntuaciones
{

    public async Task<List<Puntuaciones>> Consultar()
    {
        using (var conexion = new GatoFractalDBContext())
        {
            var consulta = await(from c in conexion.Puntuaciones select c).ToListAsync();
            return consulta;
        }
    }

    public async Task<bool> Agregar(Puntuaciones puntuaciones)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            conexion.Puntuaciones.Add(puntuaciones);
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }   
        }
    }

    public async Task<bool> Actualizar(Puntuaciones puntuaciones)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Puntuaciones
            where c.IdPuntuaciones==puntuaciones.IdPuntuaciones select c).FirstOrDefault();
            if(consulta!=null)
            {
                consulta.Victorias = puntuaciones.Victorias;
                consulta.Derrotas = puntuaciones.Derrotas;
                consulta.Empates = puntuaciones.Empates;
                consulta.IdUsuarios = puntuaciones.IdUsuarios;

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

    public async Task<bool> Eliminar(int IdPuntuaciones)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Puntuaciones
            where c.IdPuntuaciones==IdPuntuaciones select c).FirstOrDefault();
            if(consulta!=null)
            {
              conexion.Puntuaciones.Remove(consulta);            
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