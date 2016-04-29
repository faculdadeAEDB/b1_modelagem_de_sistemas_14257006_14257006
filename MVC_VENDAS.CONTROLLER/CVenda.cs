using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.CONTROLLER
{
    public class CVenda
    {
        public static List<Tuple<int, string, string, decimal, int, DateTime>> ListaVendas()
        {
            return Venda.ListaVendas();
        }

        public static List<Tuple<string, int>> VendedoresQueMaisVendem()
        {
            return Venda.VendedoresQueMaisVendem();
        }

        public static List<Tuple<string, int>> ProdutosMaisVendidos()
        {
            return Venda.ProdutosMaisVendidos();
        }

        public static Venda SelecionarVenda(Int32 Codigo)
        {
            return Venda.SelecionarVenda(Codigo);
        }

        public static int IncluirVenda(Venda oVenda)
        {
            return Venda.IncluirVenda(oVenda);
        }
    }
}
