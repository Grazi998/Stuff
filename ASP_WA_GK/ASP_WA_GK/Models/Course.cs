using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_WA_GK.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string ISVU { get; set; }
        public string Ime { get; set; }
        public string Kratko_ime { get; set; }
        public string Razina { get; set; }
        public int ECTS { get; set; }
        public int Odjel { get; set; }

        public Course(int id, string isvu, string ime, string kratko_ime, string razina, int ects, int odjelID)
        {
            ID = id;
            ISVU = isvu;
            Ime = ime;
            Kratko_ime = kratko_ime;
            Razina = razina;
            ECTS = ects;
            Odjel = odjelID;
        }

    }
}
