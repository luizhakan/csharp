class Musica
{
    public string Nome {get; set;}
    public string Artista {get; set;}
    public int Duracao {get; set;}
    public bool Disponivel {get; set;}
    public string DescricaoResumida => $"A música {Nome} pertence à {Artista}";
    // public int Somar(int a, int b) => a + b;

    public void EscreveDisponivel(bool value){
        Disponivel = value;
    }

    public bool LeDisponivel(){
        return Disponivel;
    }

    public void ExibirFichaTecnica(){
        Console.WriteLine($"\n{Nome} - {Artista}");
        Console.WriteLine($"{Duracao} min");

        if (Disponivel) {
            Console.WriteLine("Disponivel no plano");
        } else {
            Console.WriteLine("Adquira o plano");
        }
    }
}