class Musica
{
    public Musica(Banda artista, string nome, int duracao, bool disponivel){
        Artista = artista;
        Nome = nome;
        Duracao = duracao;
        Disponivel = disponivel;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; }
    public bool Disponivel { get; }
    public string DescricaoResumida => $"A música {Nome} pertence à {Artista}";
    // public int Somar(int a, int b) => a + b;


    public bool LeDisponivel()
    {
        return Disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\n{Nome} - {Artista.Nome}");
        Console.WriteLine($"{Duracao / 60} min");

        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano\n");
        }
        else
        {
            Console.WriteLine("Adquira o plano\n");
        }
    }
}