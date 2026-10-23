using Sistema.Datos;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class NCliente
    {

        public DataTable ListarCliente()
        {
            DCliente objDCliente = new DCliente();
            return objDCliente.ListaClientes();
        }


        public DataTable BuscarCliente(string valor)
        {
            DCliente objDCliente = new DCliente();
            return objDCliente.BuscaClientes(valor);
        }

        public string InsertarCliente(int ID_CLIENTES, string NOMB_CLIENTE, string APE_CLIENTE, string CORRE_CLIENTE, string CELUL_CLIENTE, string DIRECC_CLIENTE,string FOTO_CLIENTE)
        {
            DCliente objDCliente = new DCliente();
            Cliente objCliente = new Cliente();
            objCliente.ID_CLIENTES = ID_CLIENTES;
            objCliente.NOMB_CLIENTE = NOMB_CLIENTE;
            objCliente.APE_CLIENTE = APE_CLIENTE;
            objCliente.CORRE_CLIENTE = CORRE_CLIENTE;
            objCliente.CELUL_CLIENTE = CELUL_CLIENTE;
            objCliente.DIRECC_CLIENTE = DIRECC_CLIENTE;
            objCliente.FOTO_CLIENTE = FOTO_CLIENTE;
            return objDCliente.InsertaCliente(objCliente);

        }

        public string ActualizarCliente(int ID_CLIENTES, string NOMB_CLIENTE, string APE_CLIENTE, string CORRE_CLIENTE, string CELUL_CLIENTE, string DIRECC_CLIENTE, string FOTO_CLIENTE)
        {
            DCliente objDCliente = new DCliente();
            Cliente objCliente = new Cliente();
            objCliente.ID_CLIENTES = ID_CLIENTES;
            objCliente.NOMB_CLIENTE = NOMB_CLIENTE;
            objCliente.APE_CLIENTE = APE_CLIENTE;
            objCliente.CORRE_CLIENTE = CORRE_CLIENTE;
            objCliente.CELUL_CLIENTE = CELUL_CLIENTE;
            objCliente.DIRECC_CLIENTE = DIRECC_CLIENTE;
            objCliente.FOTO_CLIENTE = FOTO_CLIENTE;

            return objDCliente.ActualizaCliente(objCliente);
        }

        public string EliminarCliente(int id)
        {
            DCliente objDCliente = new DCliente();
            return objDCliente.EliminarCliente(id);
        }

    }
}
