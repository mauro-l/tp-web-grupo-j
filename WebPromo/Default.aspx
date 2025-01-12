<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPromo.Default1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script> 
        const myModal = document.getElementById('myModal')
        const myInput = document.getElementById('myInput')
        myModal.addEventListener('shown.bs.modal', () => {
            myInput.focus()
        })

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container d-flex flex-column justify-content-around mx-auto overflow-hidden">
        <div class="col-6 g-3 mx-auto text-center py-4">
            <div class="mimodal-visible" id="miElemento">
                <div class="mimodal-invisible"> 
                    <div class="card" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title">Error</h5>
                            <asp:Label ID="LabelError" CssClass="card-text" runat="server" Text=""></asp:Label>
                            <a href="#" class="card-link">Volver</a>
                            <asp:Button Text="cerrar" runat="server" CssClass="btn btn-secondary" OnClick="Unnamed_Click" ID="Unnamed" />
                        </div>
                    </div>
                </div>
            </div>

            <div aria-describedby="helpBlock">
                <div class="col-auto">
                    <asp:Label ID="Label1" runat="server" Text="Ingrese el codigo"  CssClass="code-title active"></asp:Label>
                </div>
                <div class="col-4 py-2 mx-auto">
                    <asp:TextBox ID="TextBoxCode" runat="server" CssClass="form-control" MaxLength="10"></asp:TextBox>
                    <asp:Label ID="LabelCodeValidator" for="TextBoxCode" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es requerido" ControlToValidate="TextBoxCode" runat="server" />

                </div>
                <div class="col-auto pt-2">
                    <asp:Button ID="btnValidar" OnClick="btnValidar_Click" CssClass="btn btn-primary mb-3" Text="Validar Codigo" runat="server" />
                </div>
            </div>
            <detail id="helpBlock" class="form-text">Ingrese su codigo promocional para desbloquear las recompensas</detail>
        </div>
    </div>
</asp:Content>
