
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TesteAsc.Models
{
    public class Alunos
    {

        public Alunos() 
        {
            
        }
        public Alunos(string nome,Turmas turma, List<Provas> prova)
        {

            this.Nome = nome;
            this.Turma = turma;
            this.Prova = prova;
        }

        [Key]
        public int IdAluno { get; }
        [Column("Nome", Order = 2, TypeName = "nvarchar(100)")]
        public string Nome { get; set; }

        public List<Provas> Prova { get; set; } = new List<Provas>();


        public Turmas Turma { get; set; }


    }
}
