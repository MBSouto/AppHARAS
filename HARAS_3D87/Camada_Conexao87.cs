using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient; //Provedor para o SQL Server

namespace HARAS_3D87
{
    public class Camada_Conexao87
    {
        //Metodo para abrir a conexão com o DataBase
        public SqlConnection AbrirBanco()
        {
            SqlConnection conexao = new SqlConnection("Data Source=" +
                "Localhost;Initial Catalog=HARAS_3D87;Persist Security Info=True;" +
                "User ID=sa; Password=SenhaForte123!;Encrypt=True;TrustServerCertificate=True;");
            SqlCommand cmd = new SqlCommand();

            if (conexao.State == ConnectionState.Open) conexao.Close();
            conexao.Open();
            return conexao;
        }

        //Metodo para fechar a conexão com o DataBase
        public void FecharBanco(SqlConnection conexao)
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }
        public class RetornaErroSqlServer
        {
            List<Erro> lstErros = new List<Erro>()
            {
                new Erro(){ Id=2627, Descricao="Violação de restrição de Chave Única." +
                    "Registro já existente."},
                new Erro(){ Id=547, Descricao="Exclusão de registro não permitida." +
                    "\nProvavelmente existem registros filhos."}
            };
            public string RetornaErro(int erroNumber)
            {
                string msgErro = string.Empty;

                Erro? erroInfo = lstErros.Find(p => p.Id == erroNumber);
                if (erroInfo != null)
                    msgErro = erroInfo.Descricao;
                return msgErro;
            }
        }
        public class Erro
        {
            public int Id { get; set; }
            public string Descricao { get; set; } = string.Empty;
        }
    }
}