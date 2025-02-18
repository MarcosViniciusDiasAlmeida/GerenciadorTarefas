using SistemaTarefas.Layout;
using SistemaTarefas.Servicos;
using SistemaTarefas.Modelos; // Adicione esta linha
using System;
// ... resto do código
namespace SistemaTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorTarefas();
            
            while (true)
            {
                Formatacao.ImprimirCabecalho();
                
                Formatacao.Cor("1 - Adicionar Tarefa\n", ConsoleColor.White);
                Formatacao.Cor("2 - Listar Tarefas\n", ConsoleColor.White);
                Formatacao.Cor("3 - Concluir Tarefa\n", ConsoleColor.White);
                Formatacao.Cor("4 - Remover Tarefa\n", ConsoleColor.White);
                Formatacao.Cor("0 - Sair\n\n", ConsoleColor.Red);
                Formatacao.Cor("Escolha uma opção: ", ConsoleColor.Yellow);

                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Formatacao.Cor("\nDescrição da tarefa: ", ConsoleColor.Gray);
                        var desc = Console.ReadLine();
                        gerenciador.AdicionarTarefa(desc);
                        break;

                    case "2":
                        gerenciador.ListarTarefas();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        Formatacao.Cor("\nID da tarefa a concluir: ", ConsoleColor.Gray);
                        if (int.TryParse(Console.ReadLine(), out int idConcluir))
                            gerenciador.ConcluirTarefa(idConcluir);
                        break;

                    case "4":
                        Formatacao.Cor("\nID da tarefa a remover: ", ConsoleColor.Gray);
                        if (int.TryParse(Console.ReadLine(), out int idRemover))
                            gerenciador.RemoverTarefa(idRemover);
                        break;

                    case "0":
                        return;
                }
            }
        }
    }
}