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

                switch (opcao) {

                    case "1":

                        Console.Write("Título da tarefa: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Descrição da tarefa: ");
                        string descricao = Console.ReadLine();

                        Tarefa novaTarefa = new(titulo, descricao);
                        gerenciador.AdicionarTarefa(novaTarefa);

                        break;

                    case "2":

                        Console.WriteLine("Título");
                        string tituloRemover = Console.ReadLine();
                        
                        gerenciador.RemoverTarefa(tituloRemover);
                        break;
