<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.Detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" ID="Update"> </asp:ScriptManager>

    <div class=" p-3 m-auto bg-warning text-dark">

        <div class="text-center mb-5">
        <h1><u>Detalle </u></h1>
        </div>

        <div class="row">
            <div class="col-6">



                <div class="mb-3">
                    <label for="TxtId" class="form-label ">Id:</label>
                    <asp:TextBox runat="server" ID="TxtId" CssClass="form-control" />
                </div>

                <div class="mb-3">
                    <label for="TxtNombre" class=" form-label ">Nombre:</label>
                    <asp:TextBox runat="server" ID="TxtNombre" CssClass=" form-control" />
                </div>

                <div class=" mb-3">
                    <label for="TxtNumero" class=" form-label ">Codigo:</label>
                    <asp:TextBox runat="server" ID="TxtCodigo" CssClass=" form-control" />
                </div>

                <div class="mb-3">
                    <label for="TxtId" class="form-label ">Precio:</label>
                    <asp:TextBox runat="server" ID="TxtPrecio" CssClass="form-control" />
                </div>

                <div class=" mb-3">
                    <label for="DdlDebilidad" class=" form-label ">Marca:</label>
                    <asp:DropDownList ID="DdlMarca" CssClass="form-select" runat="server" />
                </div>



                <div class=" mb-3">
                    <label for="DdlTipo" class=" form-label ">Categoria:</label>
                    <asp:DropDownList ID="DdlCategoria" CssClass="form-select" runat="server" />
                </div>
            </div>



            <div class=" col-6">
                <div class=" mb-3">
                    <label for="TxtDescripcion" runat="server" class="form-label">Descripción:</label>
                    <asp:TextBox runat="server" CssClass=" form-control" TextMode="MultiLine" ID="TxtDescripción"></asp:TextBox>
                </div>
                <asp:UpdatePanel ID="UpdatePanel" runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <label for="LblImagen" runat="server" class="form-label">Imagen:</label>
                            <asp:TextBox runat="server" ID="TxtImagen" CssClass="form-control" AutoPostBack="true"
                                 OnTextChanged="TxtImagen_TextChanged"></asp:TextBox>
                        </div>
 
                        <asp:Image ImageUrl="https://www.shutterstock.com/image-vector/default-ui-image-placeholder-wireframes-600nw-1037719192.jpg"
                            runat="server" ID="ImagenArticulo" Width="40%" />
                    </ContentTemplate>
                </asp:UpdatePanel>
                </div>
            </div>
        <br />
                <div class="row">

                <div class=" mb-3">
                 <a href="Home.aspx" class="btn btn-dark ">Regresar</a>
                </div>
             </div>
            
    </div>
       
       
</asp:Content>
