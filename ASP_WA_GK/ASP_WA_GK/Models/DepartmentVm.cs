using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_WA_GK.Models
{
    public class DepartmentVm
    {
        public string _ime { get; set; }
        public string _kratko_ime { get; set; }
        public IEnumerable<string> _smjerovi { get; set; }

        public DepartmentVm(string Ime , string Kratko_ime, IEnumerable<string> Smjerovi)
        {
            this._ime = Ime;
            this._kratko_ime = Kratko_ime;
            this._smjerovi = Smjerovi;
        }

    }
}
