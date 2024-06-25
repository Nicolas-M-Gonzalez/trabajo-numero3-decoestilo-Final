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
    public partial class Registrarme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrarme_Click(object sender, EventArgs e)
        {
            try 
            {
                Usuario Usuario = new Usuario();
                AccesoadatosUsuario UsuarioDatos = new AccesoadatosUsuario();
                Usuario.Email = Txtemail.Text;
                Usuario.Contraseña = Txtcontraseña.Text;

                Usuario.Id = UsuarioDatos.InsertarUsuario(Usuario);

                Session.Add("Usuario", Usuario);
                //para que deje la session abierta y no tengas que ingresar si ya te registraste.


               
                Response.Redirect("Default.aspx", false);


            }
            catch (Exception ex) 
            {

                Session.Add("Error",ex.ToString());
            }
        }
    }
}