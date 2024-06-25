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
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();

            AccesoadatosUsuario datos = new AccesoadatosUsuario();

            try 
            {
                Usuario.Email = Txtemail.Text;
                Usuario.Contraseña = Txtcontraseña.Text;

                if (datos.ConfirmaIngreso(Usuario)) 
                {
                    Session.Add("Usuario", Usuario);
                    //esto nos va a permitir ingresar o no a las otras pantallas cuando navegemos por las paginas.
                    Response.Redirect("Perfil.aspx", false);
                }
                else 
                {
                    Session.Add("Error", "Contraseña o usuario invalido");
                   Response.Redirect("Error.aspx", false);
                }
                
                

            }
            catch (Exception ex)
            {

                Session.Add("Error",ex.ToString());
                Response.Redirect("Error.aspx");
            }
        }
    }
}