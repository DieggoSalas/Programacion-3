<%@ Page Title="" Language="C#" MasterPageFile="~/GranMaestro.Master" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="Practica_Web.Email" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Contactame:</h2>
    <div class="mb-3">
        <label for="lblCorreo" class="form-label">Correo:</label>
        <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" Text="nombre@gmail.com" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblAsunto" class="form-label">Asunto:</label>
        <asp:TextBox ID="txtAsunto" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblMensaje" class="form-label">Mensaje:</label>
        <asp:TextBox ID="txtMensaje" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" />
</asp:Content>
