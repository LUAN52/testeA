using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAsc.Models;

namespace TesteAsc
{
    public class EstadoAlunos
    {

        private Dao data = new Dao();

        public EstadoAlunos()
        {

        }

        public EstadoAlunos(Dao data)
        {
            this.data = data;
        }

        public void VerificarAprovados()
        {


            foreach (var aluno in data.BuscarAlunos())
            {

                var media = Calculo.veriricarMedia(aluno.Prova);
                var boletim = data.BuscaBoletimAluno(aluno.IdAluno);

                if (boletim == null)
                {

                
                    if (media > 6.0)
                    {
                        data.AddBoletim(new BoletimAluno(true, media, aluno));

                    }
                    else
                    {
                        if (media >= 0 && media <= 4)
                        {

                            data.AddBoletim(new BoletimAluno(false, media, aluno));

                        }
                        else
                        {
                            var notaRecuperacao = Calculo.gerarNota();
                            var novaMedia = Math.Round(notaRecuperacao / 2, 2);
                            Provas p = new Provas(novaMedia, "recuperacao", aluno);
                            p.Nota = notaRecuperacao;
                            data.AddProva(p);


                            if (novaMedia >= 5.0)
                            {
                                data.AddBoletim(new BoletimAluno(true, novaMedia, aluno));
                            }
                            else
                            {
                                data.AddBoletim(new BoletimAluno(false, novaMedia, aluno));
                            }

                        }
                     }
                }

            }
        }



        public void GerarCompetidores()
        {
            List<Alunos> alunos = new List<Alunos>();
            var boletins = data.BuscacaBoletimAlunos();
            var competidores = boletins.OrderByDescending(media => media.MediaAluno).Take(5).ToList();

            foreach (var item in competidores)
            {
                var comp = data.BuscaProvasCompetidores().Where(p => p.Aluno.IdAluno == item.Aluno.IdAluno).FirstOrDefault();

                if (comp == null)
                {
                    var nota = Calculo.gerarNota();
                    Provas provaComp = new Provas(nota, "competicao", item.Aluno);
                    item.Aluno.Prova.Add(provaComp);

                    alunos.Add(item.Aluno);
                }
            }

            if (data.BuscCompeticao()==null)
            {   
                var compet = new Competicao(alunos);
                data.AddCompetidores(compet);
            }

           
        }
            
    }

}
