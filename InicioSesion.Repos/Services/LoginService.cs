using System.Data.SqlClient;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

public class LoginService : Ilogin
{
    //public async Task<bool> Login(User user)
    //{

    //Logica de la Conexion a la Base de Datos

    /* Metodo Largo---
    bool resultado=false;
        using (var conexion = new SqlConnection(ValoresEstaticos.ConexionDB))
        {
            try 
            {
                var Comando = new SqlCommand();
                Comando.Connection=conexion;
                Comando.CommandText= "[dbo].[ProcedimientoUsuarios]";
                Comando.CommandType=System.Data.CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@Usuario",user.UserName);
                Comando.Parameters.AddWithValue("@Password", user.Password);

                await conexion.OpenAsync();
                
                var lectura = await Comando.ExecuteReaderAsync();

                if(lectura.HasRows)
                {
                    if(lectura.Read())
                    {   
                        resultado = true;
                        
                        //Resultado.IdEmpleado = lectura.GetGuid(0);
                        //Resultado.Nombre = lectura.GetGuid(1);
                        //Resultado.Nombre = lectura.GetGuid(2);
                        
                    }else
                    {
                       resultado=false;
                    }
                }    
            }        
            catch(System.Exception)
            {

            }
            
        }

        return resultado;

        
    }
    Termina metodo largo */
    public async Task<bool> Login(User user)
    {
  
        using (var conexion = new GatoFractalDBContext())
        {
            //Consultas LINQ
            var consulta = await(from c in conexion.Usuarios
            where c.Nombre==user.UserName && c.Contrasena==user.Password
            select c).FirstOrDefaultAsync();

            if (consulta != null)
            {
                return true;
            }else{
                return false;
            }
       
        }
        

    }
}
