<%@ Page Title="" Language="C#" MasterPageFile="~/GranMaestro.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Practica_Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-4">
            <h2>Crea tu perfil</h2>            
                <div class="mb-3">
                    <label for="lblCorreo" class="form-label">Correo:</label>
                    <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" Text="Ejemplo@gmail.com" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="lblContraseña" class="form-label">Contraseña:</label>
                    <asp:TextBox ID="txtContra" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 form-check">
                    <input type="checkbox" class="form-check-input" id="exampleCheck1">
                    <label class="form-check-label" for="exampleCheck1">Check me out</label>
                </div>
            <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" />
            <a href="Default.aspx" class="btn btn-secundary">Cancelar</a>

        </div>
    </div>
</asp:Content>
