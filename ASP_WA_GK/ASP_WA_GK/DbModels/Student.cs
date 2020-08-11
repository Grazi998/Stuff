using System;
using System.Collections.Generic;

namespace ASP_WA_GK.DbModels
{
    public partial class Student
    {
        public Student()
        {
            StudentCourse = new HashSet<StudentCourse>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int? Jmbag { get; set; }

        public virtual ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
