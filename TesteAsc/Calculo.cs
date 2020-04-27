using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAsc.Models;

namespace TesteAsc
{
    public class Calculo
    {
        public static double veriricarMedia(List<Provas> prova)
        {
            double somaNotas;
            double media;


            var p2 = (0.2 * prova[0].Nota) + prova[0].Nota;
            var p3 = (0.4 * prova[0].Nota)+ prova[0].Nota;


            somaNotas = prova[0].Nota + (p2 * prova[1].Nota) +( p3 * prova[2].Nota);


            media = Math.Round(somaNotas / (p2 + p3),2);

            return media;

        }

        public  static double gerarNota()
        {
            var rand = new Random();
            var notaRand = rand.NextDouble();
            var nota = Math.Round(notaRand * 10, 1);

            return nota;
        }

        

    }
}
