using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using ASP_WA_GK.Models;

namespace ASP_WA_GK.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentApiController : ControllerBase
    {
        public List<DepartmentVm> lista_odjela;

        public DepartmentApiController()
        {
            lista_odjela = new List<DepartmentVm>();
            IEnumerable<string> Informatika = new List<string>() { "Informatika", " Informatika i tehnika", " Informatika i fizika" };
            IEnumerable<string> Matematika = new List<string>() { "Inžinjerska matematika", " Matematika i informatika", " Diskretna matematika" };
            IEnumerable<string> Fizika = new List<string>() { "Fizika", " Bla bla fizika", " meh fizika" };
            lista_odjela.Add(
                new DepartmentVm(
                    "Informatika", "INF", Informatika
                )
            );
            lista_odjela.Add(
                new DepartmentVm(
                    "Matematika", "MAT", Matematika
                )
            );
            lista_odjela.Add(new DepartmentVm(
                    "Fizika", "FIZ",  Fizika
                )
            );
        }

        [HttpGet]
        public ActionResult<List<DepartmentVm>> Get()
        {
            return lista_odjela;
        }

        [HttpGet("{name}")]
        public ActionResult<DepartmentVm> Get(string name)
        {
            return lista_odjela.Find(x => x._ime == name);
        }


    }
}