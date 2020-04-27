using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAsc.Models;

namespace TesteAsc
{
    public class LeituraArquvio
    {
        private Dao data;
        public LeituraArquvio(Dao dado)
        {
            data = dado;
        }
        
        public void LerArquivo()
        {
            using (var lerAquivo = new StreamReader("nome3.csv"))
            {
                while (!lerAquivo.EndOfStream)
                {
                    var linha = lerAquivo.ReadLine().Split(";");

                    var nTurma = int.Parse(linha[0]);
                    var nomeAluno = linha[1];
                    var notaA = double.Parse(linha[2],CultureInfo.InvariantCulture);
                    var notaB = double.Parse(linha[3], CultureInfo.InvariantCulture);
                    var notaC = double.Parse(linha[4], CultureInfo.InvariantCulture);


                    var turma = data.BuscarTurma(nTurma);

                    if (turma == null)
                    {

                        Turmas novaTurma = new Turmas( nTurma);
                        Alunos alu = new Alunos(nomeAluno, novaTurma, new List<Provas>());

                        Provas prova1 = new Provas(notaA, "bimestral",alu);
                        Provas prova2 = new Provas(notaB, "bimestral",alu);
                        Provas prova3 = new Provas(notaC, "bimestral",alu);


                        alu.Prova.Add(prova1);
                        alu.Prova.Add(prova2);
                        alu.Prova.Add(prova3);
                        novaTurma.alunos.Add(alu);
                        data.AddTurmas(novaTurma);
                    }
                    else
                    { var alunos = data.BuscarAluno(nomeAluno);
                        if (alunos == null)
                        {


                           Alunos al = new Alunos(nomeAluno, turma, new List<Provas>());
                            Provas provaA = new Provas(notaA, "bimestral", al);
                            Provas provaB = new Provas(notaB, "bimestral", al);
                            Provas provaC = new Provas(notaC, "bimestral", al);


                            al.Prova.Add(provaA);
                            al.Prova.Add(provaB);
                            al.Prova.Add(provaC);

                            data.AddAluno(al);

                           
                        }

                    }


                }
            }
          
        }
    }
}
