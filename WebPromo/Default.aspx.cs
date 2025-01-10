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
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            string codigo = TextBoxCode.Text;
            VoucherNegocio voucher = new VoucherNegocio();
            Vouchers voucherExistente = new Vouchers();
            
            voucherExistente = voucher.comparar(codigo);
            if (voucherExistente == null)
            {
                LabelCodeValidator.Text = "segui participando mi rei";
            } else if (voucherExistente.FechaCanje != null)
            {
                LabelCodeValidator.Text = "es correcto";
            }
            else
            {
                LabelCodeValidator.Text = "te durmieron el code perri";
            }
        }
    }
}