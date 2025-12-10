using System;
using System.Collections.Generic;
using System.Text;

namespace TestesCSharp.Homem
{
    internal class Homem
    {
        public string nome { get { return nome; } set {nome = value;} }
        public int idade { get {return idade;} set { idade = value; } }
        public Homem() { nome = ""; idade = 0; }

    }
}
