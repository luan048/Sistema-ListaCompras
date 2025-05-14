using System;
class Program
{
    static List<Tuple<int, string>> listaPendentes = new List<Tuple<int, string>>();

    static int numProduto = 1;
    static void Main(string[] args) {
        GerenciadorTarefas();
    }

    static void GerenciadorTarefas() {
        Console.Clear();
        Console.WriteLine("Bem-vindo(a) ao gerenciador de lista de compras!");
        Thread.Sleep(1000);
        Console.WriteLine(" ");

        Console.WriteLine("Digite qual operação você deseja realizar:");
        Console.WriteLine("[1] -- Adicionar a lista de compras");
        Console.WriteLine("[2] -- Listar lista de compras pendentes");
        Console.WriteLine("[3] -- Marcar produtos como já comprados");
        Console.WriteLine("[4] -- Listar produtos já comprados");
        Console.WriteLine("[5] -- Atualizar na lista de compras");
        Console.WriteLine("[6] -- Deletar na lista de compras");
        Console.WriteLine("[7] -- Encerrar programa");
        string escolha = Console.ReadLine();

        if(!int.TryParse(escolha, out int opcao)) {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Tente novamente...");
            Thread.Sleep(1200);
            GerenciadorTarefas();
            return;
        }

        switch (opcao) {
            case 1:
                AdicionarCompra();
                break;
            case 2:
                ListarPendentes();
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            default:
                break;
        }
    }

    static void AdicionarCompra() {
        Console.Clear();
        Console.Write($"Informe qual é o {numProduto}º produto da lista de compras: ");
        string produto = Console.ReadLine();
        listaPendentes.Add(Tuple.Create(numProduto, produto));
        numProduto++;
        Thread.Sleep(1200);
        Console.Clear();

        Console.WriteLine("Produto adicionado a lista de compras com sucesso!");
        Thread.Sleep(1000);
        Console.WriteLine(" ");
        Console.WriteLine("O que você deseja fazer?");
        Console.WriteLine("[1] -- Adicionar novo produto a lista");
        Console.WriteLine("[2] -- Voltar ao Home");
        string escolha = Console.ReadLine();

        if(!int.TryParse(escolha, out int opcao)) {
            Console.Clear();
            Console.WriteLine("Entrada inválida. Você será redirecionado ao Home");
            Thread.Sleep(1200);
            GerenciadorTarefas();
            return;
        }

        switch (opcao) {
            case 1:
                Console.Clear();
                AdicionarCompra();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Você será redirecionado ao Home");
                Thread.Sleep(1200);
                GerenciadorTarefas();
                break;
            default:
                Console.Clear();
                Console.WriteLine("Entrada inválida. Você será redirecionado ao Home");
                Thread.Sleep(1200);
                GerenciadorTarefas();
                break;
        }
    }

    static void ListarPendentes() {
        Console.Clear();

        if(listaPendentes.Count == 0) {
            Console.WriteLine("Lista está vazia, necessário haver produtos cadastrados.");
            Console.WriteLine(" ");
            Console.WriteLine("Você será redirecionado ao Home. Cadastre um produto.");
            Thread.Sleep(3000);
            GerenciadorTarefas();
            return;
        }

        Console.WriteLine("Iniciando listagem de produto pendentes...");
        Thread.Sleep(1200);
        Console.WriteLine(" ");

        foreach ((int numProduto, string produto ) in listaPendentes)
        {
            Console.WriteLine($"{numProduto} {produto}");
        }

        Thread.Sleep(1200);
        Console.WriteLine(" ");
        Console.WriteLine("O que você deseja fazer? ");
        Console.WriteLine("[1] -- Voltar ao Home");
        Console.WriteLine("[2] -- Encerrar programa");
        string entrada = Console.ReadLine();

        if(!int.TryParse(entrada, out int opcao)) {
            Console.WriteLine("Entrada inválida. Você será redirecionado ao Home");
            Thread.Sleep(1200);
            GerenciadorTarefas();
            return;
        }

        switch (opcao) {
            case 1:
                GerenciadorTarefas();
                break;
            case 2:
                // Função de encerrar o programa
                break;
            default:
                Console.WriteLine("Entrada inválida. Você será redirecionado ao Home");
                Thread.Sleep(1200);
                GerenciadorTarefas();
                break;
        }
    }
}