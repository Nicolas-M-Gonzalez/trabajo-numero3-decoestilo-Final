using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoaDatosArticulo;
using Dominios;

namespace Trabajo_Final_N_3_Gonzalez_Nicolas
{
    public partial class PaginaMaestra : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImagenIcono.ImageUrl = "https://www.shutterstock.com/image-vector/blank-avatar-photo-place-holder-600nw-1095249842.jpg";


            if (!(Page is Ingresar || Page is Registrarme  || Page is Error )) 
            {

                if (!Seguridad.SesionActiva(Session["Usuario"]))
                    Response.Redirect("Ingresar.aspx", false);
                //me exectua todas las paginas.

                else 
                {
                    Usuario user = (Usuario)Session["Usuario"];

                    if (!string.IsNullOrEmpty(user.ImagenPerfil))//valida sino es nulo o vacio con la negacion.
                        ImagenIcono.ImageUrl = "~/Imagenes/" + user.ImagenPerfil;
                }


            }

           


        }

        protected void BtnAsalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Ingresar.aspx", false);

        }
    }
}