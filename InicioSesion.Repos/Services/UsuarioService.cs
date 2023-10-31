using Microsoft.EntityFrameworkCore;
public class UsuarioService : Iusuarios
{

    public async Task<List<Usuarios>> Consultar()
    {
        using (var conexion = new GatoFractalDBContext())
        {
            var consulta = await(from c in conexion.Usuarios select c).ToListAsync();
            return consulta;
        }
    }

    public async Task<bool> Agregar(Usuarios usua)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            conexion.Usuarios.Add(usua);
            var resultado = await conexion.SaveChangesAsync();
            if(resultado==1)
            {
                return true;
            }else{
                return false;
            }
       
        }
        

    }

    public async Task<bool> Actualizar(Usuarios usua)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Usuarios
            where c.IdUsuarios==usua.IdUsuarios select c).FirstOrDefault();
            if(consulta!=null)
            {
                consulta.Nombre = usua.Nombre;
                consulta.Apellidos = usua.Apellidos;
                consulta.Gametag = usua.Gametag;
                consulta.Correo = usua.Correo;
                consulta.Contrasena = usua.Contrasena;
                consulta.Genero = usua.Genero;
                consulta.IdTipoUsuario = usua.IdTipoUsuario;
                consulta.IdRango = usua.IdRango;
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

    public async Task<bool> Eliminar(int IdUsuario)
    {
        using (var conexion=new GatoFractalDBContext())
        {
            var consulta=(from c in conexion.Usuarios
            where c.IdUsuarios==IdUsuario select c).FirstOrDefault();
            if(consulta!=null)
            {
              conexion.Usuarios.Remove(consulta);            
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