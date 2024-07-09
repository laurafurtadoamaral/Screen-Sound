
class Banda{

    public Banda (string nome){
        Nome = nome;
    }

    private List<Album> albuns = new List<Album>();

    public string Nome { get; }

    public void adicionarAlbum (Album album){
        albuns.Add(album);
    }

    public void exibirDiscografia(){
        Console.WriteLine($"A banda {Nome} possui os seguintes álbuns:\n");
        foreach( Album album in albuns){
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal} segundos)");
        }
    }
}