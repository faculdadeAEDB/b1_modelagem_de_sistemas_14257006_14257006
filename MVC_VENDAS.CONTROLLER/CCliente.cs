using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.CONTROLLER
{
    public class CCliente
    {
        public static List<Cliente> ListaClientes()
        {
            return Cliente.ListaClientes();
        }
       
        public static void AlterarCliente(Cliente oCliente)
        {
            Cliente.AlterarCliente(oCliente);
        }

        public static Cliente SelecionarCliente(Int32 Codigo)
        {
            return Cliente.SelecionarCliente(Codigo);
        }
        
       
        public static void ExcluirCliente(Int32 Codigo)
        {
            Cliente.ExcluirCliente(Codigo);
        }

        public static void IncluirCliente(Cliente oCliente)
        {
            Cliente.IncluirCliente(oCliente);
        }
        
    }
}
