using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DML.VM
{
    public class RnDtoForGrid
    {
        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public string Narucitelj { get; set; }
        public string Primatelj { get; set; }
        public string RegOznaka { get; set; }
        public string RN { get; set; }
        public string Radiliste { get; set; }
        public string RobuIzdao { get; set; }
        public string Vozac { get; set; }
        public string VrstaRobe { get; set; }
        public string Napomena { get; set; }
        public string VrstaUsluge { get; set; }
        public string Mjera { get; set; }
        public int? Kolicina { get; set; }
    }
}
