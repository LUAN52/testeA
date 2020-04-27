using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAsc.Models
{
    public class Provas
    {
        public Provas()
        {

        }


        public Provas(double nota,string tipoProva,Alunos aluno)
        {
            Nota = nota;
            TipoProva = tipoProva;
            Aluno = aluno;
            

        }

        public string TipoProva { get; set; }
        public int Id { get; }
        public double Nota { get; set; }

        public Alunos Aluno { get; set; }



    }
}
