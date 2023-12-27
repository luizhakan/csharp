Podcast flow = new Podcast("Igor 3k", "Flow Podcast");


Episodio rodrigoSilva = new Episodio("Arqueologia sobre Rei Davi", "Arqueologia sobre Rei Davi", 30);
rodrigoSilva.AdicionarConvidado("Rodrigo Silva");
rodrigoSilva.ExibirResumo();
flow.AdicionarEpisodio(rodrigoSilva);

Episodio sergioSacani = new Episodio("Sérgio Sacani x Marco Eberlin", "Sérgio Sacani é um cientista e irá debater com o Marco Eberlin", 120);
sergioSacani.AdicionarConvidado("Sérgio Sacani");
sergioSacani.AdicionarConvidado("Marco Eberlin");

sergioSacani.ExibirResumo();
flow.AdicionarEpisodio(sergioSacani);

flow.ExibirDetalhes();