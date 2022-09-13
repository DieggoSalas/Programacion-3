<%@ Page Title="" Language="C#" MasterPageFile="~/GranMaestro.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practica_Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: blueviolet">Hola!</h1>
    <h3>Bienvenido a tu primera practica</h3>
    <div class="row row-cols-1 row-cols-md-3 g-4">
    <% foreach (Clases.Articulo articulo in articulos)
        {%>    
        <div class="col">
            <div class="card">
                <img src="<%:articulo.ImagenUrl %>" class="card-img-top" alt="https://coffeesearch.guatemalancoffees.com//uploads/coverPhoto.png">
                <div class="card-body">
                    <h5 class="card-title"><%:articulo.Nombre %></h5>
                    <p class="card-text"><%:articulo.Descripcion %></p>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item"><%:articulo.Categoria.Descripcion %></li>
                    <li class="list-group-item"><%:articulo.Marca.Descripcion %></li>
                    <li class="list-group-item"><%:articulo.Codigo %></li>
                    <li class="list-group-item"><%:articulo.Precio %></li>
                </ul>
                <div class="card-body">
                    <a href="#" class="card-link">Card link</a>
                    <a href="#" class="card-link">Another link</a>
                </div>
            </div>
        </div>
    <%     
        }%>
        </div>
</asp:Content>
