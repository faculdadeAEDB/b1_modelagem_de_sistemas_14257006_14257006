using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICProduto" in both code and config file together.
    [ServiceContract]
    public interface ICProduto
    {
        [OperationContract]
        List<Produto> ListaProdutos();

        [OperationContract]
        void IncluirProduto(Produto oProduto);

        [OperationContract]
        void AlterarProduto(Produto oProduto);

        [OperationContract]
        Produto SelecionarProduto(String Codigo);

        [OperationContract]
        void ExcluirProduto(String Codigo);
    }
}
