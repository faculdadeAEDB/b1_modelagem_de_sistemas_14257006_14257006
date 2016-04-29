using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.SITE
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CVendas" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CVendas.svc or CVendas.svc.cs at the Solution Explorer and start debugging.
    public class CVendas : ICVendas
    {
        public List<Venda> ListaVendas()
        {
            return Venda.ListaVendas();
        }

        public Venda SelecionarVenda(Int32 Codigo)
        {
            return Venda.SelecionarVenda(Codigo);
        }

        public int IncluirVenda(Venda oVenda)
        {
            return Venda.IncluirVenda(oVenda);
        }
    }
}
