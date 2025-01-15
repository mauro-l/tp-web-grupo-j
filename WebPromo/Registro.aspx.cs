using datos;
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
    public partial class Registro : System.Web.UI.Page
    {
        private string codigoVoucher;
        private string premioId;
        private string idCliente;        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                codigoVoucher = Session["code"] != null ? Session["code"].ToString() : " ";
                ViewState["codigoVoucher"] = codigoVoucher;
            }
            else
            {
                if (Request.QueryString["code"] != " ")
                {
                    premioId = Request.QueryString["premioId"];
                }
                codigoVoucher = ViewState["codigoVoucher"] as string;
                idCliente = ViewState["idCliente"] as string;
            }
        }
        protected void BtnDoc_Click(object sender, EventArgs e)
        {
            Page.Validate("GrupoBtnDoc");

            if (!Page.IsValid)
            {
                return;
            }

            string documento = TextBoxDoc.Text.ToString() ;
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente documentoCliente = new Cliente();
            documentoCliente = clienteNegocio.comparar(documento);

            if (documentoCliente != null)
            {
                InputRegisNombre.Text = documentoCliente.Nombre;
                InputRegisApellido.Text = documentoCliente.Apellido;
                InputRegisMail.Text = documentoCliente.Email;
                InputRegisDni.Text = documentoCliente.Documento;
                InputRegisDire.Text = documentoCliente.Direccion;
                InputRegisCiudad.Text = documentoCliente.Ciudad;
                InputRegisCP.Text = documentoCliente.CP.ToString();
                idCliente = documentoCliente.Id.ToString();
                ViewState["idCliente"] = idCliente;
            }
            else
            {
                InputRegisDni.Text = documento;
            }
        }

        protected void BtnParticipar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                return;
            }

            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente newClient = new Cliente();
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            Vouchers newVoucher = new Vouchers();

            try
            {
                if (idCliente == null)
                {
                    newClient.Nombre = InputRegisNombre.Text;
                    newClient.Apellido = InputRegisApellido.Text;
                    newClient.Email = InputRegisMail.Text;
                    newClient.Documento = InputRegisDni.Text.ToString();
                    newClient.Direccion = InputRegisDire.Text;
                    newClient.Ciudad = InputRegisCiudad.Text;
                    newClient.CP = int.Parse(InputRegisCP.Text);

                    idCliente = clienteNegocio.agregar(newClient).ToString();                    
                }

                newVoucher.CodigoVoucher = codigoVoucher;
                newVoucher.IdCliente = int.Parse(idCliente);
                newVoucher.IdArticulo = int.Parse(premioId);

                voucherNegocio.modificar(newVoucher);
                LabelEnd.Text = "Felicidades";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}