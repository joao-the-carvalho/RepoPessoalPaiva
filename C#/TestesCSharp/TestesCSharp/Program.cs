using TestesCSharp;
using TestesCSharp.Homem;
using System;
using Zxcvbn;
class Program
{
    static void Main(String[] args)
    {
        /*Homem home = new Homem();
        home.nome = "seon";
        Console.WriteLine(home.nome);
        home.idade = 16;
        Console.WriteLine(home.idade);*/
        Random rand = new Random();
        string[] simbolos = {"#", "@", "!", "*", "_", "&"};
        string[] letras = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n","o","p","q","r","s","t","u","v","w","x","y","z","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        string[] numeros = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
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
        var resultado = Zxcvbn.Core.EvaluatePassword(senha);
        Console.WriteLine($"Essa é sua senha: {senha}");
        switch (resultado.Score)
        {
            case 0:
                Console.WriteLine("Sua senha é beeem fraca!");
                break;
            case 1:
                Console.WriteLine("Sua senha é fraca!");
                break;
            case 2:
                Console.WriteLine("Sua senha é mediana!");
                break;
            case 3:
                Console.WriteLine("Sua senha é forte!");
                break;
            case 4:
                Console.WriteLine("Sua senha é MUITO FORTE! MEUDEUS DO CEU!!!! PARABENS");
                break;
        }

    }
}