using System;
using System.Linq;

namespace teste_tecnico.Models
{
    internal class AmostraModel
    {
        public int[] Valores { get; private set; }
        public double Media { get; private set; }
        public double Eficiencia { get; private set; }

        public AmostraModel(string entrada)
        {
            Valores = entrada.Split(',').Select(x => int.Parse(x.Trim())).ToArray();
        }

        public void CalcularEficiencia()
        {
            Media = Valores.Average();
            int acimaDaMedia = Valores.Count(x => x > Media);
            Eficiencia = (acimaDaMedia / (double)Valores.Length) * 100;
        }
    }
}
