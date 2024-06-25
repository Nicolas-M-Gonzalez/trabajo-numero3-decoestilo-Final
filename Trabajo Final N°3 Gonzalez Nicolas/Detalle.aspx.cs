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
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                
                if (!IsPostBack) 
                {
                    AccesoDatoElemento Elemento = new AccesoDatoElemento();

                    List<Elemento> Lista = Elemento.ListarCategoria();

                    DdlCategoria.DataSource = Lista;
                    DdlCategoria.DataValueField = "Id";
                    DdlCategoria.DataTextField = "Descripcion";
                    DdlCategoria.DataBind();
                }

                if (!IsPostBack) {
                    AccesoDatoElemento Elemento = new AccesoDatoElemento();

                    List<Elemento> Lista = Elemento.ListarMarca();

                    DdlMarca.DataSource = Lista;
                    DdlMarca.DataValueField = "Id";
                    DdlMarca.DataTextField = "Descripcion";
                    DdlMarca.DataBind();
                }


                string id = Request.QueryString["Id"];

                if (id != "" && !IsPostBack) {
                    AccesoDatosLector Datos = new AccesoDatosLector();

                    Articulo seleccionado = (Datos.Listar(id))[0];
                    //dame el primer elemento de la lista.
                    // ya sabemos que es una lista y me lo guarde en la variable seleccionado.

                    TxtId.Text = id;
                    TxtNombre.Text = seleccionado.Nombre;
                    TxtCodigo.Text = seleccionado.Codigo;
                    TxtDescripción.Text = seleccionado.Descripcion;
                    TxtImagen.Text = seleccionado.Imagen;
                    TxtPrecio.Text = seleccionado.Precio.ToString();
                    DdlMarca.SelectedValue = seleccionado.Marca.Id.ToString();
                    DdlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();

                    TxtImagen_TextChanged(sender, e);
                    //para que me cargue la imagen se llama al evento.
                }
            }
            catch(Exception ex) 
            {
                Session.Add("Error", ex);
                Response.Redirect("Error.aspx", false);
            }
            
        }

        protected void TxtImagen_TextChanged(object sender, EventArgs e)
        {
            ImagenArticulo.ImageUrl = TxtImagen.Text;
        }
    }
}