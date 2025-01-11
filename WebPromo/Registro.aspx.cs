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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnDoc_Click(object sender, EventArgs e)
        {
            string documento = TextBoxDoc.Text;
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
            }
            else
            {
                InputRegisDni.Text = documento;
            }
        }

        protected void BtnParticipar_Click(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente newClient = new Cliente();

            try
            {                
                newClient.Nombre = InputRegisNombre.Text;
                newClient.Apellido = InputRegisApellido.Text;
                newClient.Email = InputRegisMail.Text;
                newClient.Documento = InputRegisDni.Text;
                newClient.Direccion = InputRegisDire.Text;
                newClient.Ciudad = InputRegisCiudad.Text;
                newClient.CP = int.Parse(InputRegisCP.Text);

                clienteNegocio.agregar(newClient);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}