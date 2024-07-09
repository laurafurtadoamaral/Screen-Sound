class Episodio{

    private List <string> listaDeConvidados = new List <string> ();

    public Episodio (string titulo, int ordem, int duracao){ 
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public string Titulo {get; }
    public int Duracao {get; }
    public int Ordem {get; }
    public string Resumo => ($"Episódio {Ordem} - {Titulo} \nDuração: {Duracao} minutos \nConvidados: {string.Join (", ", listaDeConvidados)}");
    

    public void adicionarConvidado(string convidado){
        listaDeConvidados.Add(convidado);
    }
}