// List<string> listaDasBandas = new List<string>{"U2", "The Beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirTituloDaOpcao("* Bem vindo ao Screen Sound *");
    Console.WriteLine("\n1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir média de uma banda");
    Console.WriteLine("-1 - sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Saindo...");
            break;
        default:
            Sair();
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("* Registro de bandas *");
    Console.Write("Nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.Write("Adicionar outra banda? [S/N]: ");
    string escolha = Console.ReadLine()!;

    if (escolha == "S" || escolha == "s")
    {
        RegistrarBanda();
    }
    else if (escolha == "N" || escolha == "n")
    {
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        Console.Clear();
        RegistrarBanda();
    }
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("* Listagem de bandas *");

    // for (int i = 0; i < listaDasBandas.Count(); i++) {
    //     Console.WriteLine($"{listaDasBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"{banda}");
    }

    Console.Write("Deseja voltar ao menu? [S/N]: ");

    string escolha = Console.ReadLine()!;

    if (escolha == "S" || escolha == "s")
    {
        ExibirOpcoesDoMenu();
    }
    else if (escolha == "N" || escolha == "n")
    {
        Console.Clear();
        MostrarBandas();
    }
    else
    {
        Console.WriteLine("Opção inválida");
        Thread.Sleep(2000);
        Console.Clear();
        MostrarBandas();
    }
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("* Avaliar banda *");

    int i = 1;
    foreach (var banda in bandasRegistradas)
    {
        Console.WriteLine($"{i} - {banda.Key}");
        i++;
    }

    Console.Write("Escolha o número da banda que deseja avaliar: ");
    if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= bandasRegistradas.Count)
    {
        string bandaEscolhida = bandasRegistradas.ElementAt(escolha - 1).Key;

        Console.Write($"Avalie a banda {bandaEscolhida}: ");

        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaEscolhida].Add(nota);
        Console.WriteLine($"A nota {nota} foi atribuida com sucesso a banda {bandaEscolhida}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Escolha inválida. Por favor, escolha um número válido.");
    }
}


void ExibirMedia()
{
    Console.Clear();
    Console.WriteLine("Media de bandas");
}

void Sair()
{
    Console.Clear();
    Console.WriteLine("Saindo...");
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

ExibirOpcoesDoMenu();