using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAsc.Controllers
{
    public class TesteAsc:Controller
    {

        private Dao data;


        public TesteAsc(Dao dado)
        {
            data = dado;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaAlunos()
        {
            return View(data.BuscarAlunos());
        }

        public IActionResult Competidores()
        {
            return View(data.BuscaProvasCompetidores());
        }

        public IActionResult VencedorCompeticao()
        {
            return View(data.BuscarGanhador());
        }


        
    }
}
