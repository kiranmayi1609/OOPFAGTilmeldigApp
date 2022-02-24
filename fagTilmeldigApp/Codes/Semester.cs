using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fagTilmeldigApp.Codes
{
    internal class Semester:School
    {
        public string? SemesterNavn { get; set; }
        public Semester(string? schoolnavn, string? semesterNavn) : base(schoolnavn)

        {
            SemesterNavn = semesterNavn;

        }
    }
}
