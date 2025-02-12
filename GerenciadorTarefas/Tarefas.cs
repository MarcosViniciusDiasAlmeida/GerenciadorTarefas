using System;

namespace Gerenciador_de_tarefas {
    internal class Tarefa {
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public Tarefa() { }

          public Tarefa(string Titulo, string Descricao) {
            this.Titulo = Titulo;
            this.Descricao = Descricao;
        }

        public override string ToString() {
            return $"Título: {Titulo}\ndescrição: {Descricao}";
        }
    }
}