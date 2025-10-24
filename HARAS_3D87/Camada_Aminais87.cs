using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; //Adicionando o provedor o SQL Server (Pacote Nuget add "dotnet add package Microsoft.Data.SqlClient" via Bash)


namespace HARAS_3D87
{
    public class Camada_Animais87
    {
        #region Abre conexão com o banco de dados e cria tabela animais
        // Abrindo comunicação com a camada conexao e definindo leitor de dados (DataReader)
        SqlConnection conexao = new SqlConnection();
        Camada_Conexao87 conexaoDB = new Camada_Conexao87();
        SqlDataReader? Dr;

        //Definindo DataTable para a tabela Animais e variáveis para cada campo da tabela
        public DataTable DtAnimais = new DataTable();

        public string snome = "", sdtnascimento = "";
        public Int32 inrchip = 0, iraca_id;
        public bool bvendido = false;
        public decimal dvalor = 0;
        #endregion

        #region Cria lista de Animais no Formulário 
        public string MontarListaAnimais(String varNome)
        {
            String msg = string.Empty;
            conexao = conexaoDB.AbrirBanco();


            SqlCommand cmd = new SqlCommand("STPMontarListaAnimais", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NOME", "%" + varNome + "%");
            try
            {
                Dr = cmd.ExecuteReader();
                DtAnimais.Clear();
                DtAnimais.Load(Dr);
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

        #region Método para localizar Animais pelo código

        public string LocalizarAnimais_porCodigo(Int32 varAnimaisID)
        {
            string msg = string.Empty;

            conexao = conexaoDB.AbrirBanco();
            //Montar comando com o stored procedure
            SqlCommand cmd = new SqlCommand("STPLocalizarAnimaisChaveID", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //Parâmetros de entrada (imput) para o stored procedure
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ANIMAIS_ID", varAnimaisID);

            try
            {
                Dr = cmd.ExecuteReader();
                if (Dr.HasRows) //Se o DataReader encontrou registros
                {
                    Dr.Read();
                    inrchip = Convert.ToInt32(Dr["NRCHIP"].ToString());
                    snome = Dr["NOME"] as string ?? string.Empty; // Operador de coalescência nula (??) para evitar erro de conversão
                    sdtnascimento = Dr["DTNASCIMENTO"] as string ?? string.Empty; // Operador de coalescência nula (??) para evitar erro de conversão
                    dvalor = Convert.ToDecimal(Dr["VALOR"].ToString());
                    iraca_id = Convert.ToInt32(Dr["RACA_ID"].ToString());
                    bvendido = Convert.ToBoolean(Dr["VENDIDO"].ToString());
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

        #region Método para inserir um novo Animal

        public string InserirAnimais(Int32 varChip,
                                    string varNome,
                                        DateTime varDtnascimento,
                                            decimal varValor,
                                                bool varVendido,
                                                    int varRacaID)
        {
            string msg = string.Empty;

            try
            {
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPInserirAnimais", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CHIP", varChip);
                cmd.Parameters.AddWithValue("@NOME", varNome);
                cmd.Parameters.AddWithValue("@DTNASCIMENTO", varDtnascimento);
                cmd.Parameters.AddWithValue("@VALOR", varValor);
                cmd.Parameters.AddWithValue("@VENDIDO", varVendido);
                cmd.Parameters.AddWithValue("@RACAID", varRacaID);

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

        #region Método para alterar um Animal existente

        public string AlterarAnimais(Int32 varChip,
                                    string varNome,
                                        DateTime varDtnascimento,
                                            decimal varValor,
                                                bool varVendido,
                                                    Int32 varRacaID,
                                                        Int32 varAnimaisID)
        {
            string msg = string.Empty;

            try
            {
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPAlterarAnimais", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CHIP", varChip);
                cmd.Parameters.AddWithValue("@NOME", varNome);
                cmd.Parameters.AddWithValue("@DTNASCIMENTO", varDtnascimento);
                cmd.Parameters.AddWithValue("@VALOR", varValor);
                cmd.Parameters.AddWithValue("@VENDIDO", varVendido);
                cmd.Parameters.AddWithValue("@RACAID", varRacaID);
                cmd.Parameters.AddWithValue("@ANIMAISID", varAnimaisID);
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

        #region Método para excluir um Animal existente
        public string ExcluirAnimais(Int32 varAnimaisID)
        {
            string msg = string.Empty;

            try
            {
                conexao = conexaoDB.AbrirBanco();

                //Montar comando com o stored procedure
                SqlCommand cmd = new SqlCommand("STPExcluirAnimais", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //Parâmetros de entrada (imput) para o stored procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ANIMAISID", varAnimaisID);
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