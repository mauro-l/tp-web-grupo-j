<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPromo.Default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="RepeaterArt" runat="server">
    <ItemTemplate>
        <div class="card" style="width: 18rem;">
            <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                <blockquote class="blockquote mb-0">
                    <p class="card-text"><%#Eval("Descripcion") %></p>
                    <footer class="blockquote-footer">$<cite title="Source Title"><%#Eval("Precio") %></cite></footer>
                </blockquote>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
</asp:Content>
