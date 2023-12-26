class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica(){
        Console.WriteLine($"\n{nome} - {artista}");
        Console.WriteLine($"{duracao} min");

        if (disponivel) {
            Console.WriteLine("Disponivel no plano");
        } else {
            Console.WriteLine("Adquira o plano");
        }
    }
}