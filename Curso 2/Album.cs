class Album{

    public Album (string nome){
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();

    public string Nome {get; }
    public int DuracaoTotal => musicas.Sum(musica=> musica.Duracao);

    public void AdicionarMusica(Musica musica){
        musicas.Add(musica);
    }

    public void ExibirAlbum(){
        Console.WriteLine($"O álbum {Nome} possui as seguintes músicas:\n");
        foreach (Musica musica in musicas){
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"\nPara escutá-lo você precisa de {DuracaoTotal} segundos");
    }
}