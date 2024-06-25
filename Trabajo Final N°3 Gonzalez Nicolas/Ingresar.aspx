<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Ingresar.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.Ingresar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   

    <div class=" container-fluid p-lg-5 bg-warning text-dark mb-5">    
    
        <div class="row">
        
            <div class=" col-6">
            
                <div  class="text-center mb-5">
            <h2><u> Ingresar </u></h2>
                </div>
            
                <div class="mb-5">
                <label class=" form-label"> E-mail </label>
                <asp:TextBox runat="server" CssClass="form-control" ID="Txtemail"></asp:TextBox>
           </div>
            
                <div class="mb-5">
                <label class=" form-label"> Contraseña </label>
                <asp:TextBox runat="server" CssClass="form-control" ID="Txtcontraseña" TextMode="Password"></asp:TextBox>
           </div>
            
                <div class="mb-5">
                <asp:Button Text="Aceptar" CssClass="btn btn-outline-dark" ID="BtnIngresar" OnClick="BtnIngresar_Click" runat="server" />
            <a class="btn btn-outline-dark" href="/">Cancelar</a>
                </div>
      
        </div>
    </div>
        
        <br />
          <hr />
        <br />


      </div>
    
</asp:Content>

