using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.CONTROLLER
{
    public class CProduto
    {
        public static List<Produto> ListaProdutos()
        {
            return Produto.ListaProdutos();
        }

        public static void IncluirProduto(Produto oProduto)
        {
            Produto.Incluir(oProduto);
        }

        public static void AlterarProduto(Produto oProduto)
        {
            Produto.AlterarProduto(oProduto);
        }

        public static Produto SelecionarProduto(String Codigo)
        {
            return Produto.SelecionarProduto(Codigo);
        }
        public static void ExcluirProduto(String Codigo)
        {
            Produto.ExcluirProduto(Codigo);
        }
    }
}
