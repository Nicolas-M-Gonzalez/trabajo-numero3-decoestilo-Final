using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominios;
using AccesoaDatosArticulo;

namespace Trabajo_Final_N_3_Gonzalez_Nicolas
{

    

    public partial class ArtFavorito : System.Web.UI.Page
    {



        public List<Articulo> ListaFavorito { get; set; }

        
        
        protected void Page_Load(object sender, EventArgs e)
        {


            Usuario user = ((Usuario)Session["Usuario"]);

            string id = Request.QueryString["Id"];

            

            
          
            if (!string.IsNullOrEmpty(id) && int.TryParse(id, out int idArticulo)) 
            {
               

                ArticuloFavorito Datos = new ArticuloFavorito();

                ArtFavoritos Nuevo = new ArtFavoritos();


                Nuevo.IdUser = user.Id;

                Nuevo.IdArticulo = int.Parse(id);

                Datos.FavoritoAgregar(Nuevo);

                

            }

            ListaFavorito = new List<Articulo>();

            if(user != null) 
            {
                ArticuloFavorito Art = new ArticuloFavorito();

                List<int> IdArt = Art.ListarFavUser(user.Id);
            
                if(IdArt.Count>0) 
                {
                    AccesoDatosLector datos = new AccesoDatosLector();

                    ListaFavorito = datos.ListarArt(IdArt);

                    RepCarrusel.DataSource = ListaFavorito;
                    RepCarrusel.DataBind();


                }
            
            
            }



        }

        protected void BtnEliminarFav_Click(object sender, EventArgs e)
        {
            Usuario user = (Usuario)Session["Usuario"];

            ArticuloFavorito Datos = new ArticuloFavorito();

            ArtFavoritos fav = new ArtFavoritos();

            try 
            {
                

                int IdArticulo = int.Parse(((Button)sender).CommandArgument);
                //obtengo el id del articulo del boton que se hizo click.

                int IdUser = user.Id;
                //el id del usuario ingresado.

               

                Datos.eliminarFavorito(IdArticulo, IdUser  );

                Page_Load(sender, e);
                //actualiza la pagina

            }
            catch (Exception ex) 
            {

                Session.Add("Error", ex.ToString());
            }
        }
    }

}
           


        
    
