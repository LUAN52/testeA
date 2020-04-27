using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAsc.Models;

namespace TesteAsc
{
    public class Dao
    {

        private TesteContext context = new TesteContext();

       public List<Alunos>  BuscarAlunos()
        {
                var Alunos = context.Alunos
                .Include(p => p.Prova).ToList();

            return Alunos;

        } 

        public Turmas BuscarTurma (int turmaId) {

            var turma = context.Turmas.FirstOrDefault(i=>i.Id==turmaId);
            return turma;
        }

        public void SalvarTurmas(Turmas turma)
        {
            context.Turmas.Add(turma);
            context.SaveChanges();
        }


        public void AddTurmas(Turmas turmas)
        {
            context.Turmas.Add(turmas);
            context.SaveChanges();
        }

        public Alunos BuscarAluno(string nomeAluno)
        {

            var alunos = context.Alunos.FirstOrDefault(nome => nome.Nome == nomeAluno);
            return alunos;

           
        }

        public void AddAluno(Alunos al)
        {
            context.Alunos.Add(al);
            context.SaveChanges();


        }

        public void AddBoletim(BoletimAluno alunoB)
        {
            context.Boletim.Add(alunoB);
            context.SaveChanges();
        }

        public void AddProva(Provas prova)
        {
            context.Provas.Add(prova);
            context.SaveChanges();
        }

        public List<BoletimAluno> BuscacaBoletimAlunos()
        {
            var alunos = context.Boletim
                 .Include(p => p.Aluno).ToList();

            return alunos;
        }

        public void AddCompetidores(Competicao compet)
        {
            context.Competicao.Add(compet);
            context.SaveChanges();
        }
        
        public Alunos BuscarGanhador()
        {
            var competidores = BuscaProvasCompetidores();
                


            var ganhadador = competidores.OrderByDescending(p => p.Nota).FirstOrDefault();

            return ganhadador.Aluno;
        }


        public BoletimAluno BuscaBoletimAluno(int id)
        {
            var bol = BuscacaBoletimAlunos();

            var alunoB = bol.Where(i => i.Aluno.IdAluno == id).FirstOrDefault();


            return alunoB;

        }


       public List<Provas> BuscaProvasCompetidores()
        {
            var competidores = context.Provas
                .Include(p => p.Aluno).Where(p => p.TipoProva == "competicao").ToList();

            return competidores;
        }

        public Competicao BuscCompeticao()
        {
            return context.Competicao.FirstOrDefault();
        }

    }
}
