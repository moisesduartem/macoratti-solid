using System;

namespace ClassesEObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Paulo", 45, "Masculino");

            pessoa1.Identificar();

            //Pessoa pessoa2 = new Pessoa();
            //pessoa2.nome = "José";
            //Console.WriteLine(pessoa2.nome);
        }
    }
}
