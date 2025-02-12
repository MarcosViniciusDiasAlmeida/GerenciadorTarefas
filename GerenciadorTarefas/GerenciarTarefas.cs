using System;

namespace Gerenciador_de_tarefas {
    internal class GerenciadorDeTarefas {

         List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(Tarefa tarefa) {
            tarefas.Add(tarefa);
        }
        public void RemoverTarefa(String titulo) {
            Tarefa tarefaParaRemover = tarefas.Find(t => t.Titulo == titulo);
            if (tarefaParaRemover != null) {
                tarefas.Remove(tarefaParaRemover);
            }
            else {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
