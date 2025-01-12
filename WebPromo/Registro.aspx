<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="WebPromo.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container w-100 d-flex justify-content-around mx-auto py-5">
        <div class="col-3 g-3 mx-auto text-center w-50 my-auto">
            <div aria-describedby="helpDoc">
                <div class="col-auto">
                    <h3>Ingrese su documento</h3>
                </div>
                <div class="col-4 py-2 mx-auto">
                    <asp:Label ID="LabelDoc" for="TextBoxCode" runat="server" class="text-danger" Text=""></asp:Label>
                    <asp:TextBox ID="TextBoxDoc" runat="server" CssClass="form-control" MaxLength="8"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="TextBoxDoc" runat="server" />
                    <asp:CompareValidator ErrorMessage="Debe contener solo numeros." Type="Integer" ForeColor="Red" Operator="DataTypeCheck" ControlToValidate="TextBoxDoc" runat="server" />
                </div>
                <div class="col-auto pt-2">
                    <asp:Button ID="BtnDoc" OnClick="BtnDoc_Click" CssClass="btn btn-primary mb-3" Text="Siguiente" runat="server" />
                </div>
            </div>
            <detail id="helpDoc" class="form-text">Ingrese su documento para continuar</detail>
        </div>

        <div class="col-9 g-3 w-50">
            <div class=" d-flex flex-column align-items-center w-100">
                <div class="col-md-10">
                    <asp:Label ID="LblRegisNombre" CssClass="form-label" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="InputRegisNombre" CssClass="form-control" runat="server" MaxLength="25"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisNombre" runat="server" />
                    <asp:CompareValidator ErrorMessage="Debe contener solo letras." ControlToValidate="InputRegisNombre" Type="String" runat="server" />
                </div>
                <div class="col-md-10">
                    <asp:Label ID="LblRegisApellido" CssClass="form-label" runat="server" Text="Apellido"></asp:Label>
                    <asp:TextBox ID="InputRegisApellido" CssClass="form-control" runat="server" MaxLength="25"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisApellido" runat="server" />
                    <asp:CompareValidator ErrorMessage="Debe contener solo letras." ControlToValidate="InputRegisApellido" Type="String" runat="server" />
                </div>

                <div class="col-md-10">
                    <asp:Label ID="LblRegisMail" CssClass="form-label" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="InputRegisMail" CssClass="form-control" runat="server" MaxLength="25"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisMail" runat="server" />
                    <asp:RegularExpressionValidator ErrorMessage="Debe ser un mail valido" ControlToValidate="InputRegisMail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" runat="server" />
                </div>
                <div class="col-md-10">
                    <asp:Label ID="LblRegisDni" CssClass="form-label" runat="server" Text="Documento"></asp:Label>
                    <asp:TextBox ID="InputRegisDni" CssClass="form-control" runat="server" MaxLength="8"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisDni" runat="server" />
                    <asp:CompareValidator ErrorMessage="Debe contener solo numeros." Type="Integer" ForeColor="Red" Operator="DataTypeCheck" ControlToValidate="InputRegisDni" runat="server" />
                </div>

                <div class="col-md-10">
                    <asp:Label ID="LblRegisDire" CssClass="form-label" runat="server" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="InputRegisDire" CssClass="form-control" runat="server" placeholder="1234 Main St" MaxLength="50"></asp:TextBox>
                    <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisDire" runat="server" />
                </div>
                <div class="d-flex gap-1 w-100 justify-content-center">
                    <div class="col-md-7">
                        <asp:Label ID="LblRegisCiudad" CssClass="form-label" runat="server" Text="Ciudad"></asp:Label>
                        <asp:TextBox ID="InputRegisCiudad" CssClass="form-control" runat="server" MaxLength="25"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="El campo es obligatorio." ControlToValidate="InputRegisCiudad" runat="server" />
                    </div>
                    <div class="col-md-3">
                        <asp:Label ID="LblRegisCP" CssClass="form-label" runat="server" Text="CP"></asp:Label>
                        <asp:TextBox ID="InputRegisCP" CssClass="form-control" runat="server" MaxLength="6"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage=" " ControlToValidate="InputRegisCP" runat="server" />
                        <asp:CompareValidator ErrorMessage="Debe contener solo numeros." Type="Integer" ForeColor="Red" Operator="DataTypeCheck" ControlToValidate="InputRegisCP" runat="server" />
                    </div>

                </div>
                <div class="col-6">
                    <asp:Button ID="BtnParticipar" OnClick="BtnParticipar_Click" runat="server" CssClass="btn btn-primary col-md-4" Text="Participar!" />
                </div>
                <asp:Label ID="LabelEnd" runat="server" Text=""></asp:Label>
            </div>
        </div>

    </div>
</asp:Content>
