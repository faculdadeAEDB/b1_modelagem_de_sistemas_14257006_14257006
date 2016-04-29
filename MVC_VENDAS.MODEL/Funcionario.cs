using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MVC_VENDAS.MODEL
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string cpf { get; set; }
        public decimal Salario { get; set; }
        public string Endereco { get; set; }

        public static List<Funcionario> ListaFuncionarios()
        {
            List<Funcionario> oRetorno = new List<Funcionario>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from FUNCIONARIO order by FunCodigo";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            while (oDr.Read())
            {
                Funcionario  oFun = new Funcionario();
                oFun.Codigo = oDr.GetInt32(oDr.GetOrdinal("FunCodigo"));
                oFun.Nome = oDr.GetString(oDr.GetOrdinal("FunNome"));
                oFun.Cargo = oDr.GetString(oDr.GetOrdinal("FunCargo"));
                oFun.cpf = oDr.GetString(oDr.GetOrdinal("FunCPF"));
                oFun.Salario = oDr.GetDecimal(oDr.GetOrdinal("FunSalario"));
                oFun.Endereco = oDr.GetString(oDr.GetOrdinal("FunEndereco"));
                oRetorno.Add(oFun);
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oRetorno;
        }

        public static void AlterarFuncionario(Funcionario oFuncionario)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Update FUNCIONARIO set ";
            SQL += "FunNome ='" + oFuncionario.Nome + "',";
            SQL += "FunCargo ='" + oFuncionario.Cargo + "',";
            SQL += "FunEndereco ='" + oFuncionario.Endereco + "',";
            SQL += "FunCPF ='" + oFuncionario.cpf + "',";
            SQL += "FunSalario =" + oFuncionario.Salario + "";
            SQL += " where FunCodigo =" + oFuncionario.Codigo + "";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }

        public static Funcionario SelecionarFuncionario(int codigo)
        {
            Funcionario oFun = null;
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Select * from FUNCIONARIO where FunCodigo='" + codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = oComando.ExecuteReader();
            if (oDr.Read())
            {
                oFun = new Funcionario();
                oFun.Codigo = oDr.GetInt32(oDr.GetOrdinal("FunCodigo"));
                oFun.Nome = oDr.GetString(oDr.GetOrdinal("FunNome"));
                oFun.Cargo = oDr.GetString(oDr.GetOrdinal("FunCargo"));
                oFun.cpf = oDr.GetString(oDr.GetOrdinal("FunCPF"));
                oFun.Salario = oDr.GetDecimal(oDr.GetOrdinal("FunSalario"));
                oFun.Endereco = oDr.GetString(oDr.GetOrdinal("FunEndereco"));
            }
            oDr.Close();
            oComando.Dispose();
            oCn.Close();
            return oFun;
        }

        public static void ExcluirFuncionario(int codigo)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Delete from FUNCIONARIO where FunCodigo='" + codigo + "'";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }

        public static void IncluirFuncionario(Funcionario oFuncionario)
        {
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL;
            SQL = "Insert into FUNCIONARIO (FunNome, FunCargo, FunCPF, FunSalario, FunEndereco)";
            SQL += "Values ('" + oFuncionario.Nome + "','" + oFuncionario.Cargo + "','" + oFuncionario.cpf + "','" + oFuncionario.Salario + "','" + oFuncionario.Endereco + "')";
            SqlCommand oComando = new SqlCommand(SQL, oCn);
            oComando.ExecuteNonQuery();
            oCn.Close();
            oCn.Dispose();
        }

        public static List<Tuple<string, int>> FuncionariosQueMaisVendem()
        {
            List<Tuple<string, int>> listTuplesFuncionarios = new List<Tuple<string, int>>();
            SqlConnection oCn = HELPER.Conexao.getConnection();
            string SQL =
            "select FunNome, count(*) as Quantidade from VENDA" +
                "join FUNCIONARIO on VenCodigoFuncionario = FunCodigo" +
                " group by FunNome";
            SqlCommand cmd = new SqlCommand(SQL, oCn);
            SqlDataReader oDr = cmd.ExecuteReader();
            while(oDr.Read())
            {
                listTuplesFuncionarios.Add(new Tuple<string, int>(
                    oDr.GetString(oDr.GetOrdinal("FunNome")),
                    oDr.GetInt16(oDr.GetOrdinal("Quantidade"))
                ));
            }

            return listTuplesFuncionarios;
        }
    }
}
