using System.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_atv5_Juliano_araujo_de_oliveira.Models;


namespace PI_atv5_Juliano_araujo_de_oliveira.Controllers
{
    public class HomeController : Controller
    {
       
        
           public IActionResult Index()
        {
            Encomendas teste = new Encomendas();

           teste.TestarConexao();


         
            return View();
        }
          
       
       
        
        
        
        public IActionResult encomendar()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
        
       
       

         public IActionResult PaginaAgenda(DetalheAgenda detalhe)
        {
        BaseDados.Incluir(detalhe);
         List<DetalheAgenda> agenda=BaseDados.Listar();

            return View(agenda);
        }
       
    }
}
