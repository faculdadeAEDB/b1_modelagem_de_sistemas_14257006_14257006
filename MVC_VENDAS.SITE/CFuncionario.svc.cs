using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CFuncionario" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CFuncionario.svc or CFuncionario.svc.cs at the Solution Explorer and start debugging.
    public class CFuncionario : ICFuncionario
    {
        public List<Funcionario> ListaFuncionarios()
        {
            return Funcionario.ListaFuncionarios();
        }

        public void AlterarFuncionario(Funcionario oFuncionario)
        {
            Funcionario.AlterarFuncionario(oFuncionario);
        }

        public Funcionario SelecionarFuncionario(Int32 Codigo)
        {
            return Funcionario.SelecionarFuncionario(Codigo);
        }

        public void ExcluirFuncionario(Int32 Codigo)
        {
            Funcionario.ExcluirFuncionario(Codigo);
        }

        public void IncluirFuncionario(Funcionario oFuncionario)
        {
            Funcionario.IncluirFuncionario(oFuncionario);
        }
    }
}
