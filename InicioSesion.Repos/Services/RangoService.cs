using Microsoft.EntityFrameworkCore;
public class RangoService : IRango
{

    public async Task<List<Rango>> Consultar()
    {
        using (var conexion = new GatoFractalDBContext())
        {
            var consulta = await(from c in conexion.Rango select c).ToListAsync();
            return consulta;
        }
    }

    public async Task<bool> Agregar(Rango rango)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            conexion.Rango.Add(rango);
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }   
        }
    }

    public async Task<bool> Actualizar(Rango rango)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Rango
            where c.IdRango==rango.IdRango select c).FirstOrDefault();
            if(consulta!=null)
            {
                consulta.NombreRango = rango.NombreRango;
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

    public async Task<bool> Eliminar(int IdRango)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Rango
            where c.IdRango==IdRango select c).FirstOrDefault();
            if(consulta!=null)
            {
              conexion.Rango.Remove(consulta);            
            }
          
            var resultado=  await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }
        }
    }
}   