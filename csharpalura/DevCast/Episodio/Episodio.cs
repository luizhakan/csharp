class Episodio
{
    public Episodio(string titulo, string resumo, int duracao)
    {
        Titulo = titulo;
        Resumo = resumo;
        Duracao = duracao;
    }


    private List<string> Convidado = new List<string>();
    public string Titulo, Resumo;
    public int Duracao;

    public void AdicionarConvidado(string nome)
    {
        Convidado.Add(nome);
    }

    public void ExibirResumo()
{
    Console.WriteLine($"Título: {Titulo}\nConvidados:");

    foreach (var convidado in Convidado)
    {
        Console.WriteLine($" - {convidado}");
    }

    Console.WriteLine($"Resumo: {Resumo}\nDuração: {Duracao} min\n");
}

}