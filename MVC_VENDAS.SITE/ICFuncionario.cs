using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICFuncionario" in both code and config file together.
    [ServiceContract]
    public interface ICFuncionario
    {
        [OperationContract]
        List<Funcionario> ListaFuncionarios();

        [OperationContract]
        void AlterarFuncionario(Funcionario oFuncionario);

        [OperationContract]
        Funcionario SelecionarFuncionario(Int32 Codigo);

        [OperationContract]
        void ExcluirFuncionario(Int32 Codigo);

        [OperationContract]
        void IncluirFuncionario(Funcionario oFuncionario);
    }
}
