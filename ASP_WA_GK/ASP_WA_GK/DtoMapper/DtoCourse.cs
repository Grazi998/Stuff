using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_WA_GK.Models;
using Newtonsoft.Json.Linq;

namespace ASP_WA_GK.DtoMapper
{
    public class DtoCourse
    {
        public static Course FromJson(string js)
        {
            JObject json = JObject.Parse(js);
            var name = json["name"].ToObject<string>();
            var sname = json["sname"].ToObject<string>();
            var id = json["ID"].ToObject<int>();
            var isvu = json["ISVU"].ToObject<string>();
            var level = json["level"].ToObject<string>();
            var ects = json["ECTS"].ToObject<int>();
            var department = json["department"].ToObject<int>();


            return new Course(id, isvu, name, sname, level, ects, department);
        }
    }
}
