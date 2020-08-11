using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP_WA_GK.Models;
using Newtonsoft.Json.Linq;
using ASP_WA_GK.DtoMapper;
using ASP_WA_GK.Services;

namespace ASP_WA_GK.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CoursesApiController : ControllerBase
    {
        public List<Course> _lista;

        public CourseService _cs;

        public CoursesApiController(CourseService cs)
        {
            _cs = cs;
            _lista = new List<Course>();
            //_lista.Add(
            //    new Course(
            //        0, "123", "Programiranje mrežnih aplikacija", "PMA", "Preddiplomski",
            //        5, "Odjel za informatiku"
            //    )
            //);
            //_lista.Add(
            //    new Course(
            //        1, "342", "Programiranje 2", "P2", "Preddiplomski",
            //        5, "Odjel za informatiku"
            //    )
            //);
            //_lista.Add(new Course(
            //        2, "456", "Primjenjena statistika", "PS", "Preddiplomski",
            //        6, "Odjel za matematiku"
            //    )
            //);
        }

        [HttpGet]
        public ActionResult<List<Course>> Get()
        {
            return _cs.GetAll().ToList();
        }


        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            return _lista.Find(x => x.ID == id);
        }

        [HttpPost]
        public ActionResult<JObject> Save([FromBody] string json)
        {
            JObject aaa = JObject.Parse(@"{ime:'graziano'}");
            Console.WriteLine(aaa);
            //var course = DtoCourse.FromJson(json);
            //_lista.Add(course);
            return aaa;
        }

    }
}