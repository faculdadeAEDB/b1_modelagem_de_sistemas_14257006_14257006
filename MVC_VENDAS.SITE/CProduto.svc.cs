using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CProduto" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CProduto.svc or CProduto.svc.cs at the Solution Explorer and start debugging.
    public class CProduto : ICProduto
    {
        public List<Produto> ListaProdutos()
        {
            return Produto.ListaProdutos();
        }

        public void IncluirProduto(Produto oProduto)
        {
            Produto.Incluir(oProduto);
        }

        public void AlterarProduto(Produto oProduto)
        {
            Produto.AlterarProduto(oProduto);
        }

        public Produto SelecionarProduto(String Codigo)
        {
            return Produto.SelecionarProduto(Codigo);
        }

        public void ExcluirProduto(String Codigo)
        {
            Produto.ExcluirProduto(Codigo);
        }
    }
}
