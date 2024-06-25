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
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                if (!IsPostBack) 
                {
                    if (Seguridad.SesionActiva(Session["Usuario"])) 
                    {
                        Usuario usuario = (Usuario)Session["Usuario"];//cargo en la variable el id guardada en la session.
                        TxtEmail.Text = usuario.Email;
                        TxtEmail.ReadOnly = true; //para que no lo puedan cambiar.
                        TxtNombre.Text = usuario.Nombre;
                        TxtApellido.Text = usuario.Apellido;
                        
                        if (!string.IsNullOrEmpty(usuario.ImagenPerfil))
                            ImgPerfil.ImageUrl = "~/Imagenes/" + usuario.ImagenPerfil;

                    }
                }


            }
            catch (Exception ex) {

                Session.Add("Error", ex.ToString());
            }

        }


    

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                AccesoadatosUsuario Datos = new AccesoadatosUsuario();
                //creo el objeto para agregar los datos del usuario ala base de datos

                Usuario User = (Usuario)Session["Usuario"];
                //me traigo el objeto de la session con el id.
                
                
                //guardar imagen

                if (TxtImagen.PostedFile.FileName != "")
                {
                    string Ruta = Server.MapPath("./Imagenes/");
                    //le digo la ruta y la coloco en la variable guardada.

                   

                    TxtImagen.PostedFile.SaveAs(Ruta + "Perfil-" + User.Id + ".jpg");
                    // que me guarde la foto fisica en la carpeta con el perfil y el id y la extencion.

                    User.ImagenPerfil = "Perfil-" + User.Id + ".jpg";
                    //guardo la imagen en la base de datos con estos indicadores.

                }
                
                User.Nombre = TxtNombre.Text;
                User.Apellido = TxtApellido.Text;

                Datos.Actualizar(User);

                //leer imagen

                Image Icono = (Image)Master.FindControl("ImagenIcono");
                //que me busque la imagen del icono del perfil de la master.le digo que es una imagen.

                Icono.ImageUrl = "~/Imagenes/" + User.ImagenPerfil;
                //le doy la direccion para que lea la imagen.



            }
            catch (Exception ex) 
            {

                Session.Add("Error", ex.ToString());
            }


        }
    }
}