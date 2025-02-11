namespace Gerenciador_de_tarefas {
    internal class Program {
        static void Main(string[] args) {

            GerenciadorDeTarefas gerenciador = new();

            bool continuar = true;

             while (continuar) {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Remover Tarefa");
                Console.WriteLine("3. Listar Tarefa");
                Console.WriteLine("4. Sair.");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();