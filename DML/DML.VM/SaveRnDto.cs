using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DML.VM
{
    public class SaveRnDto
    {
        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public string VrstaRobe { get; set; }
        public int? Kolicina { get; set; }
        public string Izvrstitelj { get; set; }
        public string RegOznaka { get; set; }
        public string VrstaUsluge { get; set; }
        public string Radiliste { get; set; }
        public string Vozac { get; set; }
        public string VrstaStroja { get; set; }
        public string Narucitelj { get; set; }
        public string Primatelj { get; set; }
    }
}
