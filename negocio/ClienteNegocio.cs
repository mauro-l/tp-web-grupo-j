using datos;
using domino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ClienteNegocio
    {
        private Datos datos;
        public ClienteNegocio()
        {
            datos = new Datos();
        }
        public List<Cliente> Listar()
        {
            List<Cliente> listaClientes = new List<Cliente>();

            try
            {
                datos.SetearDatos("select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes");
                datos.EjecutarDatos();

                while (datos.Reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Id = (int)datos.Reader["Id"];
                    cliente.Documento = (string)datos.Reader["Documento"];
                    cliente.Nombre = (string)datos.Reader["Nombre"];
                    cliente.Apellido = (string)datos.Reader["Apellido"];
                    cliente.Email = (string)datos.Reader["Email"];
                    cliente.Direccion = (string)datos.Reader["Direccion"];
                    cliente.Ciudad = (string)datos.Reader["Ciudad"];
                    cliente.CP = (int)datos.Reader["CP"];

                    listaClientes.Add(cliente);

                }

                return listaClientes;
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public void agregar(Cliente newClient)
        {
            try
            {
                datos.SetearDatos("insert into Clientes(Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) values(@doc, @nombre, @apellido, @email, @dire, @ciudad, @cp)");
                datos.SetearParametros("@doc", newClient.Documento);
                datos.SetearParametros("@nombre", newClient.Nombre);
                datos.SetearParametros("@apellido", newClient.Apellido);
                datos.SetearParametros("@email", newClient.Email);
                datos.SetearParametros("@dire", newClient.Direccion);
                datos.SetearParametros("@ciudad", newClient.Ciudad);
                datos.SetearParametros("@cp", newClient.CP);
                datos.EjecutarAccionDatos();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }

        public Cliente comparar(string dni)
        {
            List<Cliente> clientes = Listar();
            return clientes.FirstOrDefault(cliente => cliente.Documento == dni);
        }
    }
}
