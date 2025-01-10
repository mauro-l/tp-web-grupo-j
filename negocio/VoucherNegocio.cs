using datos;
using domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class VoucherNegocio
    {
        private Datos datos;
        public VoucherNegocio()
        {
            datos = new Datos();
        }
        public List<Vouchers> Listar()
        {

            List<Vouchers> vouchers = new List<Vouchers>();

            try
            {
                datos.SetearDatos("select CodigoVoucher, IdCliente, FechaCanje, IdArticulo from Vouchers");
                datos.EjecutarDatos();

                while (datos.Reader.Read())
                {
                    Vouchers voucher = new Vouchers();
                    voucher.CodigoVoucher = (string)datos.Reader["CodigoVoucher"];
                    voucher.IdCliente = datos.Reader["IdCliente"] as int?;
                    voucher.FechaCanje = datos.Reader["FechaCanje"] as DateTime?;
                    voucher.IdArticulo = datos.Reader["IdArticulo"] as int?;
                    vouchers.Add(voucher);
                }

                return vouchers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }            
        }

        public void modificar(Vouchers UpdateVoucher)
        {
            try
            {
                datos.SetearDatos("update Vouchers set IdCliente = @cliente, FechaCanje = @fecha, IdArticulo = @art Where CodigoVoucher = @codigo");
                datos.SetearParametros("@cliente", UpdateVoucher.IdCliente);
                datos.SetearParametros("@fecha", UpdateVoucher.FechaCanje);
                datos.SetearParametros("@art", UpdateVoucher.IdArticulo);
                datos.SetearParametros("@codigo", UpdateVoucher.CodigoVoucher);
                datos.EjecutarAccionDatos();
            }
            catch (Exception ex){ throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public Vouchers comparar(string userCode)
        {
            List<Vouchers> listaVoucher = Listar();
            return listaVoucher.FirstOrDefault(voucher => voucher.CodigoVoucher.Equals(userCode));
        }
        
    }
}
