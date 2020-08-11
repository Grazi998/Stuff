using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP_WA_GK.Models
{
    public class DepartmentsVm
    {
        public IEnumerable<DepartmentVm> _odjeli { get; set; }

        public DepartmentsVm(IEnumerable<DepartmentVm> odj)
        {
            this._odjeli = odj;
        }
    }
}
