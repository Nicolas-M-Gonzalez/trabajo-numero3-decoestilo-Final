﻿<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Trabajo_Final_N_3_Gonzalez_Nicolas.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class=" p-3 m-auto bg-warning text-dark">
     
        <div class="text-center mb-5 ">
  <h1> <u> Perfil  </u></h1>
         </div>

    <div class=" row">
        <div class=" col-4">
        
            <div class="mb-3">
                <label class="form-label ">Email:</label>
                <asp:TextBox runat="server" id="TxtEmail" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label class=" form-label ">Nombre:</label>
                <asp:TextBox runat="server" ID="TxtNombre" CssClass=" form-control"  />
            </div>

            <div class=" mb-3">
                <label  class=" form-label ">Apellido</label>
                <asp:TextBox runat="server" ID="TxtApellido" CssClass=" form-control"  />
            </div>

             

            

         

            </div>
       
    <div class="col-md-5">

         

        <div class=" mb-3">
            <label class="form-label">Imagen Perfil</label>
            <input type="file" Id="TxtImagen" runat="server" class="form-control" />
        </div>

        <asp:Image ID="ImgPerfil" ImageUrl="https://img.freepik.com/vector-premium/icono-perfil-usuario-estilo-plano-ilustracion-vector-avatar-miembro-sobre-fondo-aislado-concepto-negocio-signo-permiso-humano_157943-15752.jpg?w=740"
          runat="server" Width="50%" CssClass=" img-fluid mb-3" />
    </div>
        </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Button Text="Guardar"  runat="server" ID="BtnGuardar" OnClick="BtnGuardar_Click"  CssClass="btn btn-outline-dark" />
            <a href="/" class="btn btn-outline-dark">Regresar</a>
        </div>
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
 </div>
</asp:Content>
