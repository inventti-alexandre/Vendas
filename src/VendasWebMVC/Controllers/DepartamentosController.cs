using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendasWebMVC.Models;

namespace VendasWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list1 = new List<Departamento>();
            List<Departamento> list = list1;
            list.Add(new Departamento( 1, "Informática " ));
            list.Add(new Departamento(2, "Eletrônicos"));
            list.Add(new Departamento(3, "Moda "));
            return View(list); 
        }
    }
}