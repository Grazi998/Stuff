using ASP_WA_GK.DbModels;
using ASP_WA_GK.Models;
using ASP_WA_GK.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_WA_GK.Repositories
{
    public class CourseRepository
    {
        private pma_pmfContext _dbContext;

        public CourseRepository(pma_pmfContext pmfctxt)
        {
            _dbContext = pmfctxt;
        }

        public IEnumerable<Models.Course> GetAll()
        {
            return _dbContext.Course.Select(x => CourseMapper.FromDatabase(x));
        }
    }
}
