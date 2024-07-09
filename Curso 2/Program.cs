Banda marisaMonte = new Banda("Marisa Monte");

Album albumMarisaMonte = new Album("Mais");


Musica musica1 = new Musica(marisaMonte, "Beija Eu"){
    Duracao = 191,
    Disponivel = true,
};


Musica musica2 = new Musica(marisaMonte, "Volte para o seu lar"){
    Duracao = 287,
    Disponivel = false,
};

/*
albumMarisaMonte.AdicionarMusica(musica1);
albumMarisaMonte.AdicionarMusica(musica2);


albumMarisaMonte.ExibirAlbum();
Console.WriteLine("**************************");

marisaMonte.adicionarAlbum(albumMarisaMonte);

marisaMonte.exibirDiscografia();
Console.WriteLine("**************************");

musica1.exibirFichaTecnica();
Console.WriteLine("**************************");

musica2.exibirFichaTecnica();
*/


Episodio ep381 = new Episodio("Girão Eleitoral", 381, 183);
ep381.adicionarConvidado("Augusto Chidozie");
ep381.adicionarConvidado("Maria Augusta");
ep381.adicionarConvidado("João Murilo");
//Console.WriteLine(ep381.Resumo);

Episodio ep380 = new Episodio ("Rafah", 380, 164);
ep380. adicionarConvidado("Sylvia Colombo,");

Episodio ep379 = new Episodio ("Morte de Ebrahim Raisi", 379, 194);
ep379.adicionarConvidado("Jeff Nascimento");

Podcast xadrez = new Podcast("Xadrez Verbal", "Matias Pinto e Filipe Figueiredo");
xadrez.adicionarEpisodio(ep380);
xadrez.adicionarEpisodio(ep381);
xadrez.adicionarEpisodio(ep379);
xadrez.exibirDetalhes();
