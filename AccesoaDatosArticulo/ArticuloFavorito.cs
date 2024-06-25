using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominios;
using AccesoaDatosArticulo;

namespace AccesoaDatosArticulo
{
     public class ArticuloFavorito
    {

        public void FavoritoAgregar(ArtFavoritos nuevo)
        {

            AccesoaDatos datos = new AccesoaDatos();

            try
            {

                // Comprobar si el usuario ya tiene el artículo en su lista de favoritos
                datos.setearconsulta("Select  Count(*) from Favoritos where IdUser = @IdUser And IdArticulo = @IdArticulo ");
                
                datos.Setearparametro("@IdUser", nuevo.IdUser);

                datos.Setearparametro("@IdArticulo", nuevo.IdArticulo);

                datos.ejecutarlectura();


                // Si la consulta devuelve algún resultado, el artículo ya está en la lista de favoritos del usuario y no se debe insertar un nuevo registro

                if (datos.lector.Read())
                {
                    int cantidad = Convert.ToInt32(datos.lector[0]);

                    if (cantidad  > 0)
                    {
                        datos.cerrarconexion();
                        return ;
                    }
                }





                    datos.cerrarconexion();    
                    datos = new AccesoaDatos();

                    datos.setearconsulta("insert into Favoritos (IdUser, IdArticulo) Values (@IdUser, @IdArticulo)");
                    datos.Setearparametro("@IdUser", nuevo.IdUser);
                    datos.Setearparametro("@IdArticulo", nuevo.IdArticulo);
                    datos.Ejecutaraccion();
                


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

        public List<int> ListarFavUser (int IdUsuario)
        {
            AccesoaDatos datos = new AccesoaDatos();

            List<int> Lista = new List<int>();

            try
            {
                datos.setearconsulta("select IdArticulo from Favoritos Where IdUser = @IdUser");
                datos.Setearparametro("@IdUser", IdUsuario);
                datos.ejecutarlectura();

                while(datos.lector.Read())
                {
                    int aux = (int)datos.lector["IdArticulo"];

                    Lista.Add(aux);

                }

                return Lista;

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

        public void eliminarFavorito(int idArticulo, int idUser)
        {

            AccesoaDatos Datos = new AccesoaDatos();

            try
            {

                Datos.setearconsulta("DELETE FROM FAVORITOS WHERE IdArticulo = @idArticulo AND IdUser = @idUser");
                Datos.Setearparametro("@idArticulo", idArticulo);
                Datos.Setearparametro("@idUser", idUser);
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
