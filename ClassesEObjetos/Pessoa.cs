namespace ClassesEObjetos
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public string genero;

        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public void Identificar()
        {
            System.Console.WriteLine($"Olá, sou o {nome}, tenho {idade} e sou do gênero {genero}");
        }
    }
}
