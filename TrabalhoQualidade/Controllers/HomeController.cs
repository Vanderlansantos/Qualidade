using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoQualidade.Models;

namespace TrabalhoQualidade.Controllers
{
    public class HomeController : Controller
    {
        Calculadora calculadora = new Calculadora();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BinarioParaDecimal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BinarioParaDecimal(int Numero = 0)
        {
            int resultado = calculadora.BinarioParaDecimal(Numero);
            if(calculadora.Notificacoes.Count > 0)
            {
                foreach(var n in calculadora.Notificacoes)
                {
                    ViewBag.Resultado += n;
                }
            }
            else
            {
                ViewBag.Resultado = $"{Numero} em decimal é: {resultado}";
            }
            return View();
        }

        public ActionResult DecimalParaBinario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DecimalParaBinario(int Numero = 0)
        {
            int resultado = calculadora.DecimalParaBinario(Numero);
            if (calculadora.Notificacoes.Count > 0)
            {
                foreach (var n in calculadora.Notificacoes)
                {
                    ViewBag.Resultado += n;
                }
            }
            else
            {
                ViewBag.Resultado = $"{Numero} em binário é: {resultado}";
            }
            return View();
        }
    }
}