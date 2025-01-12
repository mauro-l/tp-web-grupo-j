<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="WebPromo.Premios" %>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="col-10 d-flex flex-column justify-content-center mx-auto gap-2">
        <%if (user != null){%>
            <h3>Selecciona un premio!</h3>
        <%}else {%>
            <h3>Uno de estos premios puede ser tuyo!</h3>
        <%} %>
        <div class="container d-flex justify-content-evenly p-4">
            <asp:Repeater ID="RepeaterArt" runat="server">
                <ItemTemplate>
                    <div class="card" style="width: 18rem;">
                        <div class="h-50 p-1 text-center">
                            <img src="<%#Eval("UrlImagen") %>" class="card-img-top w-50" style="height: 10rem;" alt="...">
                        </div>
                        <div class="card-body h-50 py-0">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <div class="d-flex flex-column">
                                <detail class="card-text mb-2"><%#Eval("Descripcion") %></detail>
                            </div>
                        </div>
                        <%if (user != null){%>
                            <div class="card-footer p-0 text-center">
                                <asp:HyperLink ID="lnkPremio" CssClass="btn btn-primary m-2" NavigateUrl='<%# "Registro.aspx?premioId=" + Eval("Id") %>' runat="server" Text="Seleccionar" />
                            </div>
                        <%}%>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
