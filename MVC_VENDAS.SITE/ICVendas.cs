using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICVendas" in both code and config file together.
    [ServiceContract]
    public interface ICVendas: WebController
    {
        [OperationContract]
        List<Venda> ListaVendas();

        [OperationContract]
        Venda SelecionarVenda(Int32 Codigo);

        [OperationContract]
        int IncluirVenda(Venda oVenda);
    }
}
