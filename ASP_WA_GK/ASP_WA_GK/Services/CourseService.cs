using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_WA_GK.DbModels;
using ASP_WA_GK.Repositories;

namespace ASP_WA_GK.Services
{
    public class CourseService
    {

        private CourseRepository _cr;
        public CourseService(CourseRepository cr)
        {
            _cr = cr;
        }
        public IEnumerable<Models.Course> GetAll()
        {
            return _cr.GetAll();
        }
    }
}
