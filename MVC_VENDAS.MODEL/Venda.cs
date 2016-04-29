using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC_VENDAS.MODEL
{
    public class Venda
    {
        public int Codigo { get; set; }
        public Cliente oCliente { get; set; }
        public Funcionario oFuncionario { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda()
        {
            Itens = new List<ItemVenda>();
        }

        public static List<Tuple<int, string, string, decimal, int, DateTime>> ListaVendas()
        {
            List<Tuple<int, string, string, decimal, int, DateTime>> retorno = new List<Tuple<int, string, string, decimal, int, DateTime>>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = @"select 
	                    VenCodigo, max(CliNome) Cliente, max(FunNome) Vendedor,
	                    sum(ProPrecoCompra + ProPercLucro) Total,
	                    count(ProCodigo) QtdItensVendidos, max(VenData) DataVenda from VENDA
                    join FUNCIONARIO on FunCodigo = VenCodigoFuncionario
                    join CLIENTE on CliCodigo = VenCodigoCliente
                    join ITEMVENDA on IVCodigoVenda = VenCodigo
                    join PRODUTO on ProCodigo = IVCodigoProduto
                    group by VenCodigo";

            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                int venCodigo = oDr.GetInt32(oDr.GetOrdinal("VenCodigo"));
                string cliente = oDr.GetString(oDr.GetOrdinal("Cliente"));
                string vendedor = oDr.GetString(oDr.GetOrdinal("Vendedor"));
                decimal total = oDr.GetDecimal(oDr.GetOrdinal("Total"));
                int qtdItensVendidos = oDr.GetInt32(oDr.GetOrdinal("QtdItensVendidos"));
                DateTime dataVenda =  oDr.GetDateTime(oDr.GetOrdinal("DataVenda"));

                retorno.Add(
                    new Tuple<int, string, string, decimal, int, DateTime>
                    (
                        venCodigo,
                        cliente,
                        vendedor,
                        total,
                        qtdItensVendidos,
                        dataVenda
                    )
                );
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return retorno;
        }

        public static Venda SelecionarVenda(int codigo)
        {
            throw new NotImplementedException();
        }

        public static List<Tuple<string, int>> VendedoresQueMaisVendem()
        {
            List<Tuple<string, int>> retorno = new List<Tuple<string, int>>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = @"select FunNome, count(VenCodigo) QtdVendas from VENDA
                    join FUNCIONARIO on FunCodigo = VenCodigoFuncionario
                    group by FunNome
                    order by QtdVendas desc";

            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                string funNome = oDr.GetString(oDr.GetOrdinal("FunNome"));
                int qtdVendas = oDr.GetInt32(oDr.GetOrdinal("QtdVendas"));
                retorno.Add(
                    new Tuple<string, int>
                    (
                        funNome,
                        qtdVendas
                    )
                );
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return retorno;
        }

        public static List<Tuple<string, int>> ProdutosMaisVendidos()
        {
            List<Tuple<string, int>> retorno = new List<Tuple<string, int>>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = @"select ProNome, count(IVCodigoProduto) QtdProduto from ITEMVENDA
                    join PRODUTO on IVCodigoProduto = ProCodigo
                    group by ProNome";

            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                string prodNome = oDr.GetString(oDr.GetOrdinal("ProNome"));
                int qtdProduto = oDr.GetInt32(oDr.GetOrdinal("QtdProduto"));
                retorno.Add(
                    new Tuple<string, int>
                    (
                        prodNome,
                        qtdProduto
                    )
                );
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return retorno;
        }

        public static int IncluirVenda(Venda oVenda)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Insert into VENDA (VenCodigoCliente, VenCodigoFuncionario, VenData)";
            SQL += "Values (" + oVenda.oCliente.Codigo;
            SQL += "," + oVenda.oFuncionario.Codigo;
            SQL += ", GETDATE())";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();

            SQL = "select top 1 VenCodigo from VENDA order by VenCodigo desc";
            oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            Venda oRetorno = new Venda();
            if (oDr.Read())
            {
                oRetorno.Codigo = oDr.GetInt32(oDr.GetOrdinal("VenCodigo"));
            }
            oDr.Close();

            foreach (var item in oVenda.Itens)
            {
                SQL = "Insert into ITEMVENDA (IVCodigoVenda, IVCodigoProduto, IVValorVenda, IVQtd)";
                SQL += " values (" + 
                         + oRetorno.Codigo +
                    ", '" + item.oProduto.Codigo + "'" +
                    ", " + item.oProduto.PrecoVenda.ToString().Replace(",", ".") +
                    ", " + item.Quantidade +
                ")";
                oComando = new SqlCommand(SQL, oCn);
                oComando.ExecuteNonQuery();

                SQL = "update PRODUTO set ProQtdEstoque = ProQtdEstoque -" + item.Quantidade + " where ProCodigo = '" + item.oProduto.Codigo + "'";
                oComando = new SqlCommand(SQL, oCn);
                oComando.ExecuteNonQuery();
            }
            oCn.Close();
            oCn.Dispose();
            return oRetorno.Codigo;
        }
    }
}
