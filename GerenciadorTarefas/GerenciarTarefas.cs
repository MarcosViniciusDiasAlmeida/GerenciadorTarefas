using SistemaTarefas.Modelos; // Adicione esta linha
namespace SistemaTarefas.Servicos // Corrigido de "Servicos" se necessário
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>();
        private int proximoId = 1;

       public void AdicionarTarefa(string descricao)
{
    if (string.IsNullOrWhiteSpace(descricao))
    {
        Console.WriteLine("Descrição não pode ser vazia.");
        return;
    }
    tarefas.Add(new Tarefa(proximoId, descricao));
    proximoId++;
}

        public void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.ID == id);
            if (tarefa != null) tarefa.Concluida = true;
        }

        public void ListarTarefas()
        {
            Formatacao.Cor("\nLISTA DE TAREFAS:\n", ConsoleColor.Cyan);
            Formatacao.Cor("ID    Status Descrição\n", ConsoleColor.DarkYellow);
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
            }
            Console.WriteLine();
        }

        public void RemoverTarefa(int id)
        {
            tarefas.RemoveAll(t => t.ID == id);
        }
    }
}
