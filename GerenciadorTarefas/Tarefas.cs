using SistemaTarefas.Layout; // Adicione esta linha
namespace SistemaTarefas.Modelos // Corrigido de "Modelos" para "Modelos"
{
    public class Tarefa
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        public Tarefa(int id, string descricao)
        {
            ID = id;
            Descricao = descricao;
            Concluida = false;
        }

        public void ExibirTarefa()
        {
            var status = Concluida ? "[X]" : "[ ]";
            Console.Write($"{ID.ToString().PadRight(5)} {status} ");
            Formatacao.Cor($"{Descricao}\n", Concluida ? ConsoleColor.Green : ConsoleColor.White);
        }
    }
}
