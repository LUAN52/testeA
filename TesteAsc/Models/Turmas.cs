using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAsc.Models
{
    public class Turmas
    {

        
        public Turmas()
        {

        }

        public Turmas( int Id)
        {
            this.Id = Id;
           
            
        }

       [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [ForeignKey("Alunos")]

        public List<Alunos> alunos { get; set; } = new List<Alunos>();

       public void AddAluno(Alunos aluno)
        {
            alunos.Add(aluno);
        }

         
    }
}


