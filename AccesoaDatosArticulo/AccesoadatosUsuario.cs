using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;

namespace AccesoaDatosArticulo
{
    public class AccesoadatosUsuario
    {
        public int InsertarUsuario(Usuario Nuevo)
        {
            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.setearconsulta(" Insert Into USERS (Email,Pass,Admin) output inserted.Id values (@Email,@Pass,0)");
                datos.Setearparametro("Email", Nuevo.Email);
                datos.Setearparametro("Pass", Nuevo.Contraseña);
                return datos.EjecutaraccionScarlar();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public bool ConfirmaIngreso(Usuario Usuario)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {
                datos.setearconsulta("Select Id, email, pass, urlImagenPerfil, Nombre, Apellido, admin from USERS Where Email = @email And Pass = @pass");

                datos.Setearparametro("@email", Usuario.Email);
                datos.Setearparametro("@pass", Usuario.Contraseña);
                
                datos.ejecutarlectura();
                
                if(datos.lector.Read())//que lea el lector y lo posicione.
                {
                    Usuario.Id = (int)datos.lector["Id"];
                    Usuario.Administrador = (bool)datos.lector["admin"];

                    if(!(datos.lector["urlImagenPerfil"] is DBNull))
                    Usuario.ImagenPerfil = (string)datos.lector["urlImagenPerfil"];
                    
                    if(!(datos.lector["Nombre"] is DBNull))
                    Usuario.Nombre = (string)datos.lector["Nombre"];

                    if(!(datos.lector["Apellido"] is DBNull))
                    Usuario.Apellido = (string)datos.lector["Apellido"];
                    
                    
                    
                    return true;
                }
                
                return false;
            
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }

        }

        public void Actualizar(Usuario user)
        {
          
            AccesoaDatos Datos = new AccesoaDatos();
                //creo el objeto para entrar ala base de datos.
            
            try
            {
                

                Datos.setearconsulta("Update USERS set UrlImagenPerfil = @Imagen, Nombre = @Nombre, Apellido = @Apellido Where Id = @Id");
                Datos.Setearparametro("@Imagen", (object)user.ImagenPerfil ?? DBNull.Value);
                Datos.Setearparametro("@Id", user.Id);
                Datos.Setearparametro("@Nombre", user.Nombre);
                Datos.Setearparametro("@Apellido", user.Apellido);

                Datos.Ejecutaraccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarconexion();  
                
            }


        }
    }

}
