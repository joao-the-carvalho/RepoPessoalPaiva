using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace TesteWinForms.Controle
{
    public class Controller
    {
        private MySqlConnection conexao;
        public string prompt
        {
            get;
            set;
        }
        public void Conectar()
        {
            conexao = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=c_sharp_teste");
            conexao.Open();
            Console.WriteLine("Conexao Aberta!");
        }
        public void sql(string sql)
        {
            if (conexao == null) {
                Console.Write("Abre a conexão, palerma!");
            }
            var cmd = new MySqlCommand(sql, conexao);
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
