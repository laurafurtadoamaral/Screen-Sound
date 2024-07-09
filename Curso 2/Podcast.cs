class Podcast{

    private List <Episodio> listaDeEpisodios = new List <Episodio>();
    
    public Podcast (string nome, string host){
        Nome = nome;
        Host = host;
    }

    public string Nome {get;}
    public string Host {get;}
    public int totalEpisodios => listaDeEpisodios.Count;

    public void adicionarEpisodio (Episodio novoEpisodio){
        listaDeEpisodios.Add(novoEpisodio);
    }

    public void exibirDetalhes(){
        Console.WriteLine ($"Nome do Podcast: {Nome}");
        Console.WriteLine ($"Host: {Host}");
        Console.WriteLine("Lista de episódios:");
        foreach (Episodio episodio in listaDeEpisodios.OrderBy (episodio => episodio.Ordem)){
            Console.WriteLine ($"Episódio {episodio.Ordem} - {episodio.Titulo}");
        }
        Console.WriteLine ($"Total de episódios: {totalEpisodios}");
    }
}