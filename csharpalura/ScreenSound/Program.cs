Album eaglesCalifornia = new Album("Eagles Album");

Banda eagles = new Banda("Eagles");

Musica musica1 = new Musica(eagles, "Hotel California", 390, true);
musica1.ExibirFichaTecnica();

Musica musica2 = new Musica(eagles, "Take It Easy", 210, false);
musica2.ExibirFichaTecnica();

Musica musica3 = new Musica(eagles, "Desesperado", 210, true);

Musica musica4 = new Musica(eagles, "New Kid in Town", 340, true);

Musica musica5 = new Musica(eagles, "Peaceful Easy Feeling", 256, true);

eaglesCalifornia.AdicionarMusica(musica1);
eaglesCalifornia.AdicionarMusica(musica2);
eaglesCalifornia.AdicionarMusica(musica3);
eaglesCalifornia.AdicionarMusica(musica4);
eaglesCalifornia.AdicionarMusica(musica5);

eagles.AdicionarAlbum(eaglesCalifornia);
eagles.ExibirDiscografia();

// List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// List<int> numerosPares = numeros.FindAll(x => x % 2 == 0);

// Console.WriteLine("Numeros pares:");
// foreach (int num in numerosPares)
// {
//     Console.WriteLine(num);
// }

// Console.WriteLine(musica1.Somar(1, 2));