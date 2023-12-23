string mensagem = "🇸​​​​​🇨​​​​​🇷​​​​​🇪​​​​​🇪​​​​​🇳​​​​​ 🇸​​​​​🇴​​​​​🇺​​​​​🇳​​​​​🇩​​​​​";
string mensagemBoasVindas = "Bem vindo ao Screen Sound";

List<string> listaDasBandas = new List<string>{"U2", "The Beatles"};

void ExibirLogo()
{
    Console.WriteLine("*********************");
    Console.WriteLine(mensagem);
    Console.WriteLine(mensagemBoasVindas);
    Console.WriteLine("*********************");
};


void ExibirOpcoesDoMenu()
{
    Console.Clear();
    ExibirLogo();
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
    Console.WriteLine("Registro de bandas");
    Console.Write("Nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Console.Write("Adicionar outra banda? [S/N]: ");
    string escolha = Console.ReadLine()!;

    if (escolha == "S" || escolha == "s") {
        RegistrarBanda();
    } else if (escolha == "N" || escolha == "n") {
        ExibirOpcoesDoMenu();
    } else {
        Console.WriteLine("Opção inválida!");
        Console.Clear();
        RegistrarBanda();
    }
}

void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("Listagem de bandas");
    
    // for (int i = 0; i < listaDasBandas.Count(); i++) {
    //     Console.WriteLine($"{listaDasBandas[i]}");
    // }

    listaDasBandas.ForEach(Console.WriteLine);

    Console.Write("Deseja voltar ao menu? [S/N]: ");

    string escolha = Console.ReadLine()!;

    if (escolha == "S" || escolha == "s") {
        ExibirOpcoesDoMenu();
    } else if (escolha == "N" || escolha == "n") {
        Console.Clear();
        MostrarBandas();
    } else {
        Console.WriteLine("Opção inválida");
        Thread.Sleep(2000);
        Console.Clear();
        MostrarBandas();
    }
}

void AvaliarBanda()
{
    Console.Clear();
    Console.WriteLine("Avaliação de bandas");
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

ExibirOpcoesDoMenu();