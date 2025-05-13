using System;
class Program
{
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
                break;
            case 2:
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
}