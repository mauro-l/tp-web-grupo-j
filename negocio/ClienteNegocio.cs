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

        public int agregar(Cliente newClient)
        {
            try
            {                
                datos.SetearDatos("agregarCliente");
                datos.SetearParametros("@Documento", newClient.Documento);
                datos.SetearParametros("@Nombre", newClient.Nombre);
                datos.SetearParametros("@Apellido", newClient.Apellido);
                datos.SetearParametros("@Email", newClient.Email);
                datos.SetearParametros("@Direccion", newClient.Direccion);
                datos.SetearParametros("@Ciudad", newClient.Ciudad);
                datos.SetearParametros("@CP", newClient.CP);
                return datos.EjecutarAccion();
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
