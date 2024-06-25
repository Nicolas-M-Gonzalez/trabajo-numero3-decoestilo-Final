using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoaDatosArticulo;

namespace Trabajo_Final_N_3_Gonzalez_Nicolas
{
    public partial class ListaArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if(!Seguridad.EsAdmin(Session["Usuario"])) 
            {
                Session.Add("Error", "Se requiere permiso de Administrador" );
                Response.Redirect("Error.aspx");

            }
            
            
            AccesoDatosLector Articulo = new AccesoDatosLector();
            DgvArticulo.DataSource = Articulo.Listar();
            DgvArticulo.DataBind();



        }

        protected void DgvArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = DgvArticulo.SelectedDataKey.Value.ToString();  //capturo el valor con el datakeyname.
            Response.Redirect("Formulario.aspx?id=" + id);   //  que viaje por url ala pagina del formulario para poder capturarlo.
        }

   

        protected void DgvArticulo_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DgvArticulo.PageIndex = e.NewPageIndex ; //que capture el valor del page load y vaya cambiando con el formato paginado.
            DgvArticulo.DataBind(); //que lo muestre.
        }

        protected void Ddlcampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DdlCriterio.Items.Clear();

            if (Ddlcampo.SelectedItem.ToString() == "Categoria") {

                DdlCriterio.Items.Add("Empieza con:");
                DdlCriterio.Items.Add("Termina con:");
                DdlCriterio.Items.Add("Contiene:");


            }
            else if (Ddlcampo.SelectedItem.ToString() == "Marca") {
                DdlCriterio.Items.Add("Empieza con:");
                DdlCriterio.Items.Add("Termina con:");
                DdlCriterio.Items.Add("Contiene:");

            }
            else 
            {
                DdlCriterio.Items.Add("Empieza con:");
                DdlCriterio.Items.Add("Termina con:");
                DdlCriterio.Items.Add("Contiene:");

            }

          
           

        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            AccesoDatosLector Datos = new AccesoDatosLector();
           
            DgvArticulo.DataSource = Datos.Filtrar(Ddlcampo.SelectedItem.ToString(), DdlCriterio.SelectedItem.ToString(), TxtFiltroAvanzado.Text);
           
            DgvArticulo.DataBind();
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            AccesoDatosLector Articulo = new AccesoDatosLector();
            DgvArticulo.DataSource = Articulo.Listar();
            DgvArticulo.DataBind();

        }
    }
}