<%@ Page Title="" Language="C#" MasterPageFile="~/GranMaestro.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Practica_Web.Formulario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mb-3">
        <label for="lblId" class="form-label">Id: </label>
        <asp:TextBox ID="txtId" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblCodigo" class="form-label">Código: </label>
        <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblNombre" class="form-label">Nombre: </label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblDescripcion" class="form-label">Descripción: </label>
        <asp:TextBox ID="txtDescripcion" TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="mb-3">
        <label for="lblMarca" class="form-label">Marca: </label>
        <asp:DropDownList ID="ddlMarca" CssClass="form-select" runat="server"></asp:DropDownList>
    </div>
    <div class="mb-3">
        <label for="lblCategoria" class="form-label">Categoria: </label>
        <asp:DropDownList ID="ddlCategoria" CssClass="form-select" runat="server"></asp:DropDownList>
    </div>
    <div class="mb-3">
        <label for="lblPrecio" class="form-label">Precio: </label>
        <asp:TextBox ID="txtPrecio" TextMode="Number" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>            
            <div class="mb-3">
                <label for="lblImagen" class="form-label">Imagen: </label>
                <asp:TextBox type="text" class="form-control" ID="txtImagen" runat="server" AutoPostBack="true" OnTextChanged="txtImagen_TextChanged"></asp:TextBox>
            </div>
            <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" ID="imgUrl" runat="server" Width="60%" />
        </ContentTemplate>
    </asp:UpdatePanel>
    <div class="mb-3">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary"/>
        <a href="ListaProducto.aspx" class="btn btn-primary">Cancelar</a>
    </div>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
    <div class="mb-3">
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger"/>
    </div>
            <%if (confEliminacion)
                {%>
                <asp:CheckBox ID="ChbxConfirmarEliminar" Text="Confirmar Eliminación" runat="server" CssClass="form-check-input" />
                <asp:Button ID="btnConfirmarEliminar" runat="server" Text="Eliminar" OnClick="btnConfirmarEliminar_Click" CssClass="btn btn-outline-danger" />
                <%} %>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
