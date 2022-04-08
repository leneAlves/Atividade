using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTarefa.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["projetotarefa"].ConnectionString;

            return new MySqlConnection(conexao);
        }


    }
}
