using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.CONTROLLER
{
    public class CFuncionario
    {
        public static List<Funcionario> ListaFuncionarios()
        {
            return Funcionario.ListaFuncionarios();
        }

        public static void AlterarFuncionario(Funcionario oFuncionario)
        {
            Funcionario.AlterarFuncionario(oFuncionario);
        }

        public static Funcionario SelecionarFuncionario(Int32 Codigo)
        {
            return Funcionario.SelecionarFuncionario(Codigo);
        }


        public static void ExcluirFuncionario(Int32 Codigo)
        {
            Funcionario.ExcluirFuncionario(Codigo);
        }

        public static void IncluirFuncionario(Funcionario oFuncionario)
        {
            Funcionario.IncluirFuncionario(oFuncionario);
        }
    }
}
