using ASP_WA_GK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_WA_GK.Mappers
{
    public class CourseMapper
    {
        public static Course FromDatabase(DbModels.Course course)
        {
            return new Course(
                course.Id,
                course.Isvu,
                course.Name,
                course.Shortname,
                course.Level,
                course.Ects,
                course.DepartmentId.Value
             );
        }
    }
}
