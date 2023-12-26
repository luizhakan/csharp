Musica musica1 = new Musica();
musica1.Nome = "Girl from Ipanema";
musica1.Artista = "Frank Sinatra";
musica1.Duracao = 3;
musica1.EscreveDisponivel(true);
musica1.ExibirFichaTecnica();

Musica musica2 = new Musica();
musica2.Nome = "Fly me to the moon";
musica2.Artista = "Frank Sinatra";
musica2.Duracao = 4;
Console.WriteLine(musica2.DescricaoResumida);
musica2.ExibirFichaTecnica();

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// List<int> numerosPares = numeros.FindAll(x => x % 2 == 0);

// Console.WriteLine("Numeros pares:");
// foreach (int num in numerosPares)
// {
//     Console.WriteLine(num);
// }

// Console.WriteLine(musica1.Somar(1, 2));