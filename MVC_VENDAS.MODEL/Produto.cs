using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC_VENDAS.MODEL
{
    public class Produto
    {
        private string strCodigo;
        private string strNome;
        private decimal decPrecoCompra;
        private decimal decPercLucro;
        private decimal decQtdEstoque;
        private decimal decPrecoVenda;

        public string Codigo
        {
            get
            {
                return strCodigo;
            }

            set
            {
                strCodigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return strNome;
            }

            set
            {
                strNome = value;
            }
        }

        public Decimal PrecoCompra
        {
            get
            {
                return decPrecoCompra;
            }

            set
            {
                decPrecoCompra = value;
            }
        }

        public Decimal PercLucro
        {
            get
            {
                return decPrecoCompra;
            }

            set
            {
                decPrecoCompra = value;
            }
        }

        public Decimal QtdEstoque
        {
            get
            {
                return decQtdEstoque;
            }

            set
            {
                decQtdEstoque = value;
            }
        }

        public Decimal PrecoVenda
        {
            get
            {
                return (decPrecoCompra + (decPrecoCompra * decPercLucro));
            }
        }

        public static List<Produto> ListaProdutos()
        {
            List<Produto> oRetorno = new List<Produto>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from Produto order by ProCodigo";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                Produto oProd = new Produto();
                oProd.Codigo = oDr.GetString(oDr.GetOrdinal("ProCodigo"));
                oProd.Nome = oDr.GetString(oDr.GetOrdinal("ProNome"));
                oProd.PrecoCompra = oDr.GetDecimal(oDr.GetOrdinal("ProPrecoCompra"));
                oProd.PercLucro = oDr.GetDecimal(oDr.GetOrdinal("ProPercLucro"));
                oProd.QtdEstoque = oDr.GetDecimal(oDr.GetOrdinal("ProQtdEstoque"));
                oRetorno.Add(oProd);
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oRetorno;
        }

        public static void Incluir(Produto oProduto)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Insert into Produto (ProCodigo, ProNome, ProPrecoCompra, ProQtdEstoque, ProPercLucro)";
            SQL += "Values ('" + oProduto.Codigo + "','" + oProduto.Nome + "'";
            SQL += "," + oProduto.PrecoCompra.ToString().Replace(",", ".");
            SQL += "," + oProduto.QtdEstoque.ToString().Replace(",", ".");
            SQL += "," + oProduto.PercLucro.ToString().Replace(",", ".") + ")";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
            oCn.Close();
            oCn.Dispose();
        }

        public static void AlterarProduto(Produto oProduto)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Update Produto set ";
            SQL += "ProNome='" + oProduto.Nome + "',";
            SQL += "ProPrecoCompra=" + oProduto.PrecoCompra.ToString().Replace(",",".") + ",";
            SQL += "ProQtdEstoque=" + oProduto.QtdEstoque.ToString().Replace(",", ".") + ",";
            SQL += "ProPercLucro=" + oProduto.PercLucro.ToString().Replace(",", ".");
            SQL += " where ProCodigo='" + oProduto.Codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
            oCn.Close();
            oCn.Dispose();
        }

        public static void ExcluirProduto(String Codigo)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Delete from Produto where ProCodigo='" +Codigo  + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
            oCn.Close();
            oCn.Dispose();
        }

        public static Produto SelecionarProduto(String Codigo)
        {
            Produto oRetorno = null;
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from Produto where ProCodigo='" + Codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            if (oDr.Read())
            {
                oRetorno = new Produto();
                oRetorno.Codigo = oDr.GetString(oDr.GetOrdinal("ProCodigo"));
                oRetorno.Nome = oDr.GetString(oDr.GetOrdinal("ProNome"));
                oRetorno.PrecoCompra = oDr.GetDecimal(oDr.GetOrdinal("ProPrecoCompra"));
                oRetorno.PercLucro = oDr.GetDecimal(oDr.GetOrdinal("ProPercLucro"));
                oRetorno.QtdEstoque = oDr.GetDecimal(oDr.GetOrdinal("ProQtdEstoque"));
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oRetorno;
        }
    }
}
