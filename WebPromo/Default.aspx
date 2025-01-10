<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPromo.Default1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-6 g-3" aria-describedby="helpBlock">
            <div class="col-auto">
                <h2>Ingrese el codigo del voucher</h2>
            </div>
            <div class="col-3 py-2">
                <asp:Label ID="LabelCodeValidator" for="TextBoxCode" runat="server" class="text-danger" Text=""></asp:Label>
                <asp:TextBox ID="TextBoxCode" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-auto pt-2">
                <asp:Button ID="btnValidar" OnClick="btnValidar_Click" CssClass="btn btn-primary mb-3" Text="Validar Codigo" runat="server"/>
            </div>
        </div>
        <div id="helpBlock" class="form-text">Ingrese su codigo promocional para desbloquear las recompensas</div>
    </div>
</asp:Content>
