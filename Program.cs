// Screen Sound
// no terminal (ctrl + J): dotnet run Program.cs

Console.Clear();
List<string> listaDeBandas = new List<string>{"Skank", "Jota Quest", "O Rappa"};
Dictionary <string, List<int>> bandasRegistradas = new Dictionary <string, List<int>>();
bandasRegistradas.Add("Skank", new List<int>());


string mensagemDeBoasVindas = "\nBem vindo ao Screen Sound";
void exibeLogo(){

    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
};

void exibeOpcoesDoMenu(){
    exibeLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a nota de uma banda");
    Console.WriteLine("Digite 0 para sair");
    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

  switch (opcaoEscolhidaNumerica){
    case 1: registrarBanda();
        break;
    case 2: exibirBandasRegistradas();
        break;
    case 3: avaliaBanda();
        break;
    case 4: exibeNotaDaBanda();
        break;
    case 0: Console.WriteLine("Volte sempre!");
        break;
    default: Console.WriteLine("Opção inválida");
        break;
    }
}
// Menu - Opção 1
void registrarBanda(){
    Console.Clear();
    string titulo = "Registro de Bandas";
    exibeTituloDaSecao(titulo);
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List <int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibeOpcoesDoMenu();
}

// Menu - Opção 2
void exibirBandasRegistradas(){
    Console.Clear();
    string titulo = "Lista de Bandas";
    exibeTituloDaSecao(titulo);
    
    /* Outra opção para exibir a lista, utilizando FOR ao invés de FOREACH
   for (int i=0; i<listaDeBandas.Count; i++){
        Console.WriteLine($"Banda {i+1}: {listaDeBandas[i]}");
    }*/

    foreach (string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite qualquer tecla para retornar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    exibeOpcoesDoMenu();   
}

void avaliaBanda(){
    Console.Clear();
    string titulo = "Avaliação de Bandas";
    exibeTituloDaSecao(titulo);
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual nota a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        exibeOpcoesDoMenu(); 
    } else {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        exibeOpcoesDoMenu();   
    };

}

void exibeNotaDaBanda(){
    Console.Clear();
    string titulo = "Exibição de Nota das Bandas";
    exibeTituloDaSecao(titulo);
    Console.Write("Digite o nome da banda que você quer saber a nota: ");
    string banda = Console.ReadLine()!;
    if(bandasRegistradas.ContainsKey(banda)){
        double media = bandasRegistradas[banda].Average();
        Console.WriteLine($"A nota média da banda {banda} é {media}");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Thread.Sleep(1000);
        Console.Clear();
        exibeOpcoesDoMenu();
    }else{
        Console.WriteLine($"A banda {banda} não está registrada! Aperte qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Thread.Sleep(1000);
        Console.Clear();
        exibeOpcoesDoMenu();
}
}

// Funçção que cria título de cada seção
void exibeTituloDaSecao(string titulo){
    int quantidadeDeCaracteres = titulo.Length;
    string asteriscos = "";
    asteriscos = asteriscos.PadLeft(quantidadeDeCaracteres, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

exibeOpcoesDoMenu();