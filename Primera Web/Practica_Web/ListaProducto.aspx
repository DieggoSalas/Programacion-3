<%@ Page Title="" Language="C#" MasterPageFile="~/GranMaestro.Master" AutoEventWireup="true" CodeBehind="ListaProducto.aspx.cs" Inherits="Practica_Web.ListaProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="color: blue">Todos los productos:</h2>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-5">
                    <div class="mb-3">
                        <asp:Label ID="lblFiltro" runat="server" CssClass="form-label" Text="Filtro:"></asp:Label>
                        <asp:TextBox ID="txtFiltro" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtFiltro_TextChanged"></asp:TextBox>
                    </div>
                </div>
                <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end;">
                    <div class="mb-3">
                        <asp:CheckBox ID="chkFiltroAvanzado" runat="server" Text="Filtro Avanzado" CssClass="form-check-input"
                            AutoPostBack="true" OnCheckedChanged="chkFiltroAvanzado_CheckedChanged" />
                    </div>
                </div>
            </div>
            <%if (FiltroAvz)
                {%>
                
            <div class="row">
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label ID="lblCampo" runat="server" CssClass="form-label" Text="Campo:"></asp:Label>
                        <asp:DropDownList ID="ddlCampo" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged">
                            <asp:ListItem Text="Código" />
                            <asp:ListItem Text="Nombre" />
                            <asp:ListItem Text="Precio" />
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label ID="lblCriterio" runat="server" CssClass="form-label" Text="Criterio:"></asp:Label>
                        <asp:DropDownList ID="ddlCriterio" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                </div>
                <div class="col-3">
                    <div class="mb-3">
                        <asp:Label ID="lblReferencia" runat="server" CssClass="form-label" Text="Referencia:"></asp:Label>
                        <asp:TextBox ID="txtReferencia" runat="server" CssClass="form-control" />
                    </div>
                </div>
                <div class="col-3" style="display: flex; flex-direction: column; justify-content: flex-end;">
                    <div class="mb-3">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
                    </div>
                </div>
            </div>
               <% } %>

            <asp:GridView ID="gvProductos" runat="server" CssClass="table table-dark table-bordered"
                AutoGenerateColumns="false" DataKeyNames="Id" OnSelectedIndexChanged="gvProductos_SelectedIndexChanged">
                <Columns>
                    <%--<asp:BoundField HeaderText="Id" DataField="Id" />--%>
                    <asp:BoundField HeaderText="Código" DataField="Codigo" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <%--<asp:BoundField HeaderText="Descripción" DataField="Descripcion" />--%>
                    <%--<asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />--%>
                    <asp:BoundField HeaderText="Categoría" DataField="Categoria.Descripcion" />
                    <%--<asp:BoundField HeaderText="Imagen" DataField="ImagenUrl" />--%>
                    <asp:BoundField HeaderText="Precio" DataField="Precio" />
                    <asp:CommandField HeaderText="Modificar" ShowSelectButton="true" SelectText="✍️​" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <a href="Formulario.aspx" class="btn btn-primary">Agregar</a>

</asp:Content>
