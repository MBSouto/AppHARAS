using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; //Adicionando o provedor o SQL Server (Pacote Nuget add "dotnet add package Microsoft.Data.SqlClient" via Bash)


namespace HARAS_3D87
{
    public class Camada_Raca87
    {
        #region Conecta com a camada de conexão e definindo o DataReader
        // Abrindo comunicação com a camada conexao e definindo leitor de dados (DataReader)
        SqlConnection conexao = new SqlConnection();
        Camada_Conexao87 conexaoDB = new Camada_Conexao87();
        SqlDataReader? Dr;

        //Definindo DataTable para a tabela Raça e variáveis para cada campo da tabela
        public DataTable DtRaca = new DataTable();

        public string sDescricao_Raca = "", sdata = "", shora = "";
        public Int32 iRegistro_Raca = 0;
        #endregion

        #region Método para executar o SP de exibição da lista de Raças
        public string MontarListaRaca(string varDescricao)
        {
            string msg = string.Empty;
            conexao = conexaoDB.AbrirBanco();


            //Montar comando com o stored procedure
            SqlCommand cmd = new SqlCommand("STPMontarListaRaca", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //Parâmetros de entrada (imput) para o stored procedure
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@DESCRICAO", "%" + varDescricao + "%");
            try
            { 
                Dr = cmd.ExecuteReader();
                DtRaca.Clear();
                DtRaca.Load(Dr);
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

        #region Método para localizar Raça pelo código

        public string LocalizarRaca_porCodigo(Int32 varRacaID)
        {
            string msg = string.Empty;

            conexao = conexaoDB.AbrirBanco();
            //Montar comando com o stored procedure
            SqlCommand cmd = new SqlCommand("STPLocalizarRacaChaveID", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //Parâmetros de entrada (imput) para o stored procedure
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@RACA_ID", varRacaID);

            try
            { 
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows) //Se o DataReader encontrou registros
                {
                    Dr.Read();
                    iRegistro_Raca = Convert.ToInt32(Dr["REGISTRO"].ToString());
                    sDescricao_Raca = Dr["DESCRICAO"] as string ?? string.Empty; // Operador de coalescência nula (??) para evitar erro de conversão
                    sdata = Dr["DATA"] as string ?? string.Empty; // Operador de coalescência nula (??) para evitar erro de conversão
                }
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

        #region Método para inserir uma nova Raça
        
        public string InserirRaca(Int32 varRegistro, 
                                    string varDescricao,
                                        DateTime varData,
                                            string varHora)
        {
            string msg = string.Empty;

            try
            { 
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPInserirRaca", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@REGISTRO", varRegistro);
                cmd.Parameters.AddWithValue("@DESCRICAO", varDescricao);
                cmd.Parameters.AddWithValue("@DATA", varData);
                cmd.Parameters.AddWithValue("@HORA", varHora);

                cmd.ExecuteNonQuery();

                conexaoDB.FecharBanco(conexao);
                msg = "Registro inserido com sucesso!";
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

        #region Método para alterar uma Raça existente

        public string AlterarRaca(Int32 varRegistro, string varDescricao,
                                    DateTime ddata, string hora, Int32 varRacaID)
        {
            string msg = string.Empty;

            try
            {
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPAlterarRaca", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@REGISTRO", varRegistro);
                cmd.Parameters.AddWithValue("@DESCRICAO", varDescricao);
                cmd.Parameters.AddWithValue("@DATA", ddata);
                cmd.Parameters.AddWithValue("@HORA", hora);
                cmd.Parameters.AddWithValue("@RACAID", varRacaID);
                cmd.ExecuteNonQuery();

                conexaoDB.FecharBanco(conexao);
                msg = "Registro alterado com sucesso!";
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

        #region Método para excluir uma Raça existente
        public string ExcluirRaca(Int32 varRacaID)
        {
            string msg = string.Empty;

            try
            {
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPExcluirRaca", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@RACAID", varRacaID);
                cmd.ExecuteNonQuery();

                conexaoDB.FecharBanco(conexao);

                msg = "Registro excluído com sucesso!";
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
