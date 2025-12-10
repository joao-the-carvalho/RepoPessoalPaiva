using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWinForms.Controle;
namespace TesteWinForms.Model
{
    internal class Usuario
    {
        public string nome { get; set; }
        public string senha { get; set; }
        public void Registrar(string nome, string senha)
        {
            try
            {
                Controller controle = new Controller();
                controle.Conectar();
                string sql = $"INSERT INTO usuario (nome, senha) VALUES ('{nome}', '{senha}');";
                controle.sql(sql);
                Console.WriteLine("funfou eba!");
            }
            catch (Exception ex) {
                Console.WriteLine($"deu erro :/ {ex.ToString()}");
            }
        }
    }
}
