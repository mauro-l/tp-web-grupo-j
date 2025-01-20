<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPromo.Default1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="d-flex w-100 mx-4">
        <div>
            <img src="Assets\pngegg.png" class="serpentinas" alt="" />
            <div class="d-flex flex-column hero">
                <picture class="position-relative">
                    <img src="Assets\THRIVE.png" style="width:800px;" alt="" />
                </picture>
                <asp:Button Text="Participar!" runat="server" OnClick="BtnParticipar_Click" CssClass="d-block btn btn-secondary" ID="BtnParticipar" />
            </div>
        </div>        
        <div>
            <img src="Assets\pngegg (1).png" class="serpentinas2" alt="" />
            <div class="premios">
                <img src="Assets\mochila.jpg" class="premio-mochila" alt="" />
                <img src="Assets\mouse.jpg" class="premio-mouse" alt="" />
                <img src="Assets\teclado.jpg" class="premio-teclado" alt="" />
            </div>

            <div class="circle-container">
                <h2 class="text-title">Por la compra de cualquier producto de las marcas participantes,
          recibe un voucher para participar de un fabuloso sorteo!
                </h2>
                <div class="d-flex justify-content-center gap-3">
                    <div class="text-center">
                        <span class="rounded-circle fondo-azul px-3 py-2 fs-1 text-light"><i class="bi bi-cart-plus"></i></span>
                        <div>
                            <p class="texto-iconos">Comprá nuestros</p>
                            <br />
                            <p class="texto-iconos">productos</p>
                        </div>
                    </div>
                    <div class="text-center">
                        <span class="rounded-circle fondo-azul px-3 py-2 fs-1 text-light"><i class="bi bi-receipt-cutoff"></i></span>
                        <div>
                            <p class="texto-iconos">Ingresá el codigo</p>
                            <br />
                            <p class="texto-iconos">de tu factura!</p>
                        </div>
                    </div>
                    <div class="text-center">
                        <span class="rounded-circle fondo-azul px-3 py-2 fs-1 text-light"><i class="bi bi-gift"></i></span>
                        <div>
                            <p class="texto-iconos">Seleccioná el premio</p>
                            <br />
                            <p class="texto-iconos">y participá!</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   
</asp:Content>
