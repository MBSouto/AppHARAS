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
        // Abrindo comunicação com a camada conexao e definindo leitor de dados (DataReader)
        SqlConnection conexao = new SqlConnection();
        Camada_Conexao87 conexaoDB = new Camada_Conexao87();
        SqlDataReader Dr;

        //Definindo DataTable para a tabela Raça e variáveis para cada campo da tabela
        public DataTable DtAnimais = new DataTable();

        public string snome = "";
        public Int32 inrchip = 0;
        public bool bvendido = false;
        public DateTime? ddtNascimento = null;
        public decimal dvalor = 0;
    }
}

