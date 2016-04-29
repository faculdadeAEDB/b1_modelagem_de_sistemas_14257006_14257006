using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CCliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CCliente.svc or CCliente.svc.cs at the Solution Explorer and start debugging.
    public class CCliente : ICCliente
    {
        public List<Cliente> ListaClientes()
        {
            return Cliente.ListaClientes();
        }

        public void AlterarCliente(Cliente oCliente)
        {
            Cliente.AlterarCliente(oCliente);
        }

        public Cliente SelecionarCliente(Int32 Codigo)
        {
            return Cliente.SelecionarCliente(Codigo);
        }

        public void ExcluirCliente(Int32 Codigo)
        {
            Cliente.ExcluirCliente(Codigo);
        }

        public void IncluirCliente(Cliente oCliente)
        {
            Cliente.IncluirCliente(oCliente);
        }
    }
}
