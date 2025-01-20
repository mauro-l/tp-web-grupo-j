using domino;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPromo
{
    public partial class Participar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnValidar_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (!Page.IsValid)
            {
                return;
            }

            string codigo = TextBoxCode.Text;
            VoucherNegocio voucher = new VoucherNegocio();
            Vouchers voucherExistente = new Vouchers();

            voucherExistente = voucher.comparar(codigo);
            if (voucherExistente == null)
            {
                string script = @" 
                <script type='text/javascript'> 
                    document.getElementById('miElemento').classList.add('active'); 
                </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "CambiarOpacidad", script, false);
                LabelError.Text = "El codigo no es valido";

            }
            else if (voucherExistente.FechaCanje != null)
            {
                string script = @" 
                <script type='text/javascript'> 
                    document.getElementById('miElemento').classList.add('active'); 
                </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "CambiarOpacidad", script, false);
                LabelError.Text = "El codigo ya fue utilizado.";
            }
            else
            {
                Session.Add("code", voucherExistente.CodigoVoucher);
                string script = @"
                <script type='text/javascript'>
                    document.getElementById('textoActivo').classList.add('active');
                    setTimeout(function() {
                        window.location.href = 'Premios.aspx';
                    }, 2000);
                </script>";
                ClientScript.RegisterStartupScript(this.GetType(), "ActivarText", script, false);
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string script = @" 
                <script type='text/javascript'> 
                    document.getElementById('miElemento').classList.remove('active');
                </script>";
            ClientScript.RegisterStartupScript(this.GetType(), "Unnamed_Click", script, false);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}