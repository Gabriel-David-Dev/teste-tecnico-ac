using System;
using teste_tecnico.Models;

namespace teste_tecnico.Views
{
    internal class ConsoleView
    {
        public string SolicitarEntrada()
        {
            Console.Write("Digite os valores da amostra (separados por vírgula): ");
            return Console.ReadLine();
        }

        public void MostrarResultado(AmostraModel amostra)
        {
            Console.WriteLine("\n==== Resultado ====");
            Console.WriteLine($"Percentual de alunos acima da média: {amostra.Eficiencia:F3}%");
        }

        public void MostrarErro()
        {
            Console.WriteLine("\nErro! Digite apenas números separados por vírgula.");
        }
    }
}
