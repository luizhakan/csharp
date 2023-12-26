class Album
{
    public Album(string nome){
        Nome = nome;
    }
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(x => x.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Musicas do album: {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }

        Console.WriteLine($"\nDuracao total do album: {DuracaoTotal / 60} min");
    }
}