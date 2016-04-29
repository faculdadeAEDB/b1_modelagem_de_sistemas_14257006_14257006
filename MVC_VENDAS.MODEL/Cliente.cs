using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC_VENDAS.MODEL
{
    public class Cliente
    {
        private int intCodigo;
        private string strNome;
        private string strEndereco;
        private string strBairro;
        private string strCidade;
        private string strTelefone;


        public int Codigo
        {
            get
            {
                return intCodigo;
            }

            set
            {
                intCodigo = value;
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

        public string Endereco
        {
            get
            {
                return strEndereco;
            }

            set
            {
                strEndereco = value;
            }
        }

        public string Bairro
        {
            get
            {
                return strBairro;
            }

            set
            {
                strBairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return strCidade;
            }

            set
            {
                strCidade = value;
            }
        }

        public string Telefone
        {
            get
            {
                return strTelefone;
            }

            set
            {
                strTelefone = value;
            }
        }

        public static List<Cliente> ListaClientes()
        {
            List<Cliente> oRetorno = new List<Cliente>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from Cliente order by CliCodigo";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                Cliente oCli = new Cliente();
                oCli.Codigo = oDr.GetInt32(oDr.GetOrdinal("CliCodigo"));
                oCli.Nome = oDr.GetString(oDr.GetOrdinal("CliNome"));
                oCli.Endereco = oDr.GetString(oDr.GetOrdinal("CliEndereco"));
                oCli.Bairro = oDr.GetString(oDr.GetOrdinal("CliBairro"));
                oCli.Cidade = oDr.GetString(oDr.GetOrdinal("CliCidade"));
                oCli.Telefone = oDr.GetString(oDr.GetOrdinal("CliTelefone"));
                oRetorno.Add(oCli);
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oRetorno;
        }

        public static Cliente SelecionarCliente(int Codigo)
        {
            Cliente oRetorno = null;
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from Cliente where CliCodigo='" + Codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            if (oDr.Read())
            {
                oRetorno = new Cliente();
                oRetorno.Codigo = oDr.GetInt32(oDr.GetOrdinal("CliCodigo"));
                oRetorno.Nome = oDr.GetString(oDr.GetOrdinal("CliNome"));
                oRetorno.Endereco = oDr.GetString(oDr.GetOrdinal("CliEndereco"));
                oRetorno.Bairro = oDr.GetString(oDr.GetOrdinal("CliBairro"));
                oRetorno.Cidade = oDr.GetString(oDr.GetOrdinal("CliCidade"));
                oRetorno.Telefone = oDr.GetString(oDr.GetOrdinal("CliTelefone"));
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oRetorno;
        }

        public static void IncluirCliente(Cliente oCliente)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Insert into Cliente (CliNome, CliEndereco, CliBairro, CliCidade, CliTelefone)";
            SQL += "Values ('" + oCliente.Nome + "','" + oCliente.Endereco + "','" + oCliente.Bairro + "','" + oCliente.Cidade + "','" + oCliente.Telefone + "')";           
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }

        public static void AlterarCliente(Cliente oCliente)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Update Cliente set ";
            SQL += "CliNome ='" + oCliente.Nome + "',";
            SQL += "CliEndereco ='" + oCliente.Endereco + "',";
            SQL += "CliBairro ='" + oCliente.Bairro + "',";
            SQL += "CliCidade ='" + oCliente.Cidade + "',";
            SQL += "CliTelefone ='" + oCliente.Telefone  + "'";
            SQL += " where CliCodigo =" + oCliente.Codigo + "";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }

        public static void ExcluirCliente(int Codigo)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Delete from Cliente where CliCodigo='" + Codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }
    }
}
