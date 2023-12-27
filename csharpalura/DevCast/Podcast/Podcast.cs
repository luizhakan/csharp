class Podcast {
    public Podcast(string host, string nome) {
        Host = host;
        Nome = nome;
    }

    private string Host, Nome;
    private List<string> TotalEpisodios = new List<string>();

    public void AdicionarEpisodio(Episodio episodio) {
        TotalEpisodios.Add(episodio.Titulo);
    }

    public void ExibirDetalhes(){
        Console.WriteLine($"O podcast {Nome}, apresentado por {Host} tem {TotalEpisodios.Count()} episodio(s)");

        Console.WriteLine("Episodios: ");
        for (int i = 1; i <= TotalEpisodios.Count(); i++){
            Console.WriteLine($"{i} - {TotalEpisodios[i-1]}");
        }
    }
}