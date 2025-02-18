using System;

namespace SistemaTarefas.Layout
{
    public static class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()
        {
            Console.Clear();
            Cor("***************************************\n", ConsoleColor.Blue);
            Cor("*       GERENCIADOR DE TAREFAS        *\n", ConsoleColor.Yellow);
            Cor("***************************************\n\n", ConsoleColor.Blue);
        }
    }
}