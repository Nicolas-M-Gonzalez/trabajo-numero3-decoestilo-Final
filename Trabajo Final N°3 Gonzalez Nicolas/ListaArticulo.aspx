<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="ListaArticulo.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.ListaArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <asp:ScriptManager runat="server" ID="Script"></asp:ScriptManager>
    
    <div class=" p-3 m-auto bg-warning"> 

        <div class="text-dark text-center mb-5">
    <h1><u> lista de Articulos </u></h1>
       </div>

       
                     
       
                              
        <asp:UpdatePanel ID="Update1" runat="server">
            <ContentTemplate>
                <div class="row">
                 <div class="col-3">
                          <div class="mb-3">
   
                              <asp:Label runat="server" Text="Campo" ID="DdlCampoLabel"></asp:Label>
                              <asp:DropDownList runat="server" ID="Ddlcampo" AutoPostBack="true" OnSelectedIndexChanged="Ddlcampo_SelectedIndexChanged"  CssClass="form-control">
                                  <asp:ListItem Text="Nombre"></asp:ListItem>
                                  <asp:ListItem Text="Marca"></asp:ListItem>
                                  
                                  <asp:ListItem Text="Categoria"></asp:ListItem>
                              </asp:DropDownList>
                          </div>
                      </div>
                   
                      <div class="col-3">
                       <div class="mb-3">
                           <asp:Label Text="Criterio" runat="server"></asp:Label>
                           <asp:DropDownList runat="server" ID="DdlCriterio" CssClass="form-control"> </asp:DropDownList>
                       </div>
                    </div>

                      <div class="col-3">
                          <div class=" mb-3">
                              <asp:Label Text="Filtro" runat="server"></asp:Label>
                              <asp:TextBox runat="server" ID="TxtFiltroAvanzado"  CssClass="form-control"></asp:TextBox>
                       </div>
                          </div>
                </div>   

         </ContentTemplate>
            </asp:UpdatePanel>       
                 
            <asp:UpdatePanel>
                <ContentTemplate>
                       
                <div class="row">
                    <div class="col-3">
                        <div class="mb-5">
                            <asp:Button Text="Buscar" runat="server" CssClass="btn btn-dark" ID="BtnBuscar" OnClick="BtnBuscar_Click" />
                            <asp:Button Text="Limpiar" runat="server"  CssClass="btn btn-dark" ID="BtnLimpiar" OnClick="BtnLimpiar_Click" />
                        </div>
                    </div>
                </div>
                </ContentTemplate>
        </asp:UpdatePanel>
        

     <asp:GridView  ID="DgvArticulo" runat="server" CssClass="table"
        AutoGenerateColumns="false" DataKeyNames="Id"
        OnSelectedIndexChanged="DgvArticulo_SelectedIndexChanged"
        OnPageIndexChanging="DgvArticulo_PageIndexChanging"
        AllowPaging="true" PageSize="8">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
            <asp:BoundField HeaderText="Precio" DataField="Precio" />
            <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="✒️" />
        </Columns>
    </asp:GridView>
    <a href="formulario.aspx" class="btn btn-dark">Agregar</a>
        
     </div>   
</asp:Content>

