using System;

namespace ClassesEObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Paulo";
            pessoa1.idade = 45;
            pessoa1.genero = "Masculino";

            pessoa1.Identificar();

            //Pessoa pessoa2 = new Pessoa();
            //pessoa2.nome = "José";
            //Console.WriteLine(pessoa2.nome);
        }
    }
}
