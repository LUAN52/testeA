using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAsc.Models
{
    public class Competicao 
    {
        public Competicao() 
        {

        }

        public Competicao(List<Alunos> aluno)
        {
            
            Aluno = aluno;
        }

        public int id { get; set; }
        public List<Alunos> Aluno { get; set; }

        


    }
}
