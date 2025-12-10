using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zxcvbn;
using TesteWinForms.Model;
using TesteWinForms.Controle;
using TesteWinForms.View;

namespace TesteWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            Random rand = new Random();
            string[] simbolos = { "#", "@", "!", "*", "_", "&" };
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] numeros = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> senhaFinal = new List<string>();
            int i = 0;
            while (i < 12)
            {
                int indexRandom = rand.Next(simbolos.Length);
                string simboloRandom = simbolos[indexRandom];

                indexRandom = rand.Next(letras.Length);
                string letraRandom = letras[indexRandom];

                indexRandom = rand.Next(numeros.Length);
                string numeroRandom = numeros[indexRandom];

                string[] arrayRandom = { numeroRandom, letraRandom, simboloRandom };
                indexRandom = rand.Next(arrayRandom.Length);
                string arrayRandomizada = arrayRandom[indexRandom];
                senhaFinal.Add(arrayRandomizada);
                i++;
            }
            var senha = String.Join("", senhaFinal);
            textBox2.Text = senha;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto1 = textBox1.Text;
            string texto2 = textBox2.Text;
            Usuario usu = new Usuario();
            if (texto1 != "" && texto2 != "") {
                var averiguar = Zxcvbn.Core.EvaluatePassword(texto2);
                switch (averiguar.Score)
                {
                    case 0:
                        label3.Text = "Sua senha é fraca!";
                        break;
                    case 1:
                        label3.Text = "Sua senha é razoavelmente fraca.";
                        break;
                    case 2:
                        label3.Text = "Sua senha está na média, o usuário está sendo criado.";
                        usu.Registrar(texto1, texto2);
                        break;
                    case 3:
                        label3.Text = "Sua senha é forte!";
                        usu.Registrar(texto1, texto2);
                        break;
                    case 4:
                        label3.Text = "Sua senha é MUITO FORTE! MEUDEUS DO CEU!!!! PARABENS";
                        usu.Registrar(texto1, texto2);
                        break;
                }
                    
            }     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
