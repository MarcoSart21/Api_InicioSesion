using Microsoft.EntityFrameworkCore;
public class TipoService : ITipo
{

    public async Task<List<TipoUsuario>> Consultar()
    {
        using (var conexion = new GatoFractalDBContext())
        {
            var consulta = await(from c in conexion.TipoUsuario select c).ToListAsync();
            return consulta;
        }
    }

    public async Task<bool> Agregar(TipoUsuario TUsuario)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            conexion.TipoUsuario.Add(TUsuario);
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }
       
        }
        

    }

    public async Task<bool> Actualizar(TipoUsuario TUsuario)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.TipoUsuario
            where c.IdTipoUsuario==TUsuario.IdTipoUsuario select c).FirstOrDefault();
            if(consulta!=null)
            {
                consulta.NombreTipoUsuario = TUsuario.NombreTipoUsuario;
                consulta.Descripcion = TUsuario.Descripcion;
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

    public async Task<bool> Eliminar(int IdTipoUsuario)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.TipoUsuario
            where c.IdTipoUsuario==IdTipoUsuario select c).FirstOrDefault();
            if(consulta!=null)
            {
              conexion.TipoUsuario.Remove(consulta);            
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