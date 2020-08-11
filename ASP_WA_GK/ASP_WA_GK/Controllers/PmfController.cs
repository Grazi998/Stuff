using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_WA_GK.Models;

namespace ASP_WA_GK.Controllers
{
    public class PmfController : Controller
    {
        public IActionResult Odjeli()
        {

            return View();
            //var lista = new List<DepartmentVm>();

            //IEnumerable<string> Informatika = new List<string>() { "Infromatika", "Informatika i tehnika", "Informatika i fizika" };
            //IEnumerable<string> Matematika = new List<string>() { "Inžinjerska matematika", "Matematika i informatika", "Diskretna matematika" };
            //IEnumerable<string> Fizika = new List<string>() { "Fizika", "Bla bla fizika", "meh fizika" };

            //lista.Add(new DepartmentVm("Informatika", "INF", Informatika));
            //lista.Add(new DepartmentVm("Matematika", "MAT", Matematika));
            //lista.Add(new DepartmentVm("Fizika", "FIZ", Fizika));



            //return View(new DepartmentsVm(lista));
        }
    }
}