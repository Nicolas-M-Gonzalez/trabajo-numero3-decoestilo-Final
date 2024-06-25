<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <asp:ScriptManager ID="update" runat="server"></asp:ScriptManager>

    <div class="bg-warning p-3 m-auto text-dark">
        <div class="text-center  bg-warning mb-5">
            <h1><u>Home</u></h1>
        </div>

                  
        <div class="row row-cols-1 row-cols-md-3 g-4 ms-5 ">

                    <asp:Repeater runat="server" ID="RepCarrusel">
                <ItemTemplate>
                    
                    <div class="card text-white bg-dark ms-5 me-2" style="max-width: 18rem;">
                        
                        <div class="card-group">
                              
                            <div class="w-50">
                            
                                <div class="card-header">
                           
                            
                                <h6><u><%#Eval("Nombre") %></u></h6> 

                                  </div>  
                            
                                
                                <Image src="<%#Eval("Imagen")%>" class=" img-fluid " alt="Imagen del Aritculo">
                                
                                <div class="card-body" >
                                    <h8 class=" card-title mb-2"><u>Precio:</u> $<%#Eval("Precio") %> </h8>
                                    <a href="Detalle.aspx?Id=<%#Eval("Id") %>" class=" btn btn-outline-warning mb-2 ">Detalle</a>
                                    <a href="ArtFavorito.aspx?Id=<%#Eval("Id") %>" class="btn btn-outline-warning">⭐Favorito</a>
                                

                            </div>
                            </div>
                            </div>
                        </div>
    </ItemTemplate>
    </asp:Repeater>
 </div>
</div>
</asp:Content>
