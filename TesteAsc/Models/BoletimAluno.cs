using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAsc.Models
{
    public class BoletimAluno
    {
        public BoletimAluno()
        {

        }

        public BoletimAluno(bool situacaoAluno, double mediaAluno, Alunos aluno)
        {
            AlunoAprovado = situacaoAluno;
            MediaAluno = mediaAluno;
            Aluno = aluno;
        }

        public Alunos Aluno { get; set; }
        public int id { get; set; }
        public bool AlunoAprovado { get; set; }

        public double MediaAluno { get; set; }
    }
}
