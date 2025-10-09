using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; //Adicionando o provedor o SQL Server (Pacote Nuget add "dotnet add package Microsoft.Data.SqlClient" via Bash)

namespace HARAS_3D87
{
    public class Camada_Usuarios87
    {
        // Abrindo comunicação com a camada conexao e definindo leitor de dados (DataReader)
        SqlConnection conexao = new SqlConnection();
        Camada_Conexao87 conexaoDB = new Camada_Conexao87();
        SqlDataReader? Dr;

        //Definindo DataTable para a tabela Usuarios e variáveis para cada campo da tabela
        public DataTable DtUsuarios = new DataTable();

        public Int32 iAcesso_usuario = 0;
        public string sSenha_usuario = "", sTelefone = "";

        #region Método para executar o SP de exibição da lista de Usuários
        public string MontarListaUsuarios(string varDescricao)
        {
            string msg = string.Empty;
            conexao = conexaoDB.AbrirBanco();


            //Montar comando com o stored procedure
            SqlCommand cmd = new SqlCommand("STPMontarListaUsuarios", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //Parâmetros de entrada (imput) para o stored procedure
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NOME", "");

            try
            {
                Dr = cmd.ExecuteReader();
                DtUsuarios.Clear();
                DtUsuarios.Load(Dr);
                Dr.Close();
                conexaoDB.FecharBanco(conexao);
            }
            catch (SqlException sqlErrr)
            {
                Camada_Conexao87.RetornaErroSqlServer retErro = new Camada_Conexao87.RetornaErroSqlServer();
                string msgErro = retErro.RetornaErro(sqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro))
                    msgErro = sqlErrr.Message;
                msg = msgErro;
            }
            catch (Exception err)
            {
                //Armazenar a mensagem de erro na variável msg
                msg = err.Message.ToString();
            }
            finally
            {
                if (conexao.State == ConnectionState.Open) conexaoDB.FecharBanco(conexao);
            }
            return msg; //Retorna mensagem para o formulário
        }
        #endregion

    }
}
