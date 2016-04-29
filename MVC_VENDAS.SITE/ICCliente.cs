using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICCliente" in both code and config file together.
    [ServiceContract]
    public interface ICCliente
    {
        [OperationContract]
        List<Cliente> ListaClientes();

        [OperationContract]
        void AlterarCliente(Cliente oCliente);

        [OperationContract]
        Cliente SelecionarCliente(Int32 Codigo);

        [OperationContract]
        void ExcluirCliente(Int32 Codigo);

        [OperationContract]
        void IncluirCliente(Cliente oCliente);
    }
}
