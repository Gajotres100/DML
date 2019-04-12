using DML.VM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DML.Repository.RadniNalozi
{
    public class RnRepository
    {
        public void SaveRn(RnDto data)
        {
            using (var context = new DMLEntities())
            {
                var rn = new RadniNalog
                {
                    Datum = data.Datum,
                    Izvrstitelj = data.Izvrstitelj,
                    Kolicina = data.Kolicina,
                    Narucitelj = data.Narucitelj,
                    Primatelj = data.Primatelj,
                    Radiliste = data.Radiliste,
                    RegOznaka = data.RegOznaka,
                    Vozac = data.Vozac,
                    VrstaRobe = data.VrstaRobe,
                    VrstaStroja = data.VrstaStroja,
                    VrstaUsluge = data.VrstaUsluge
                };

                context.RadniNalog.Add(rn);
                context.SaveChanges();
            }
        }

        public List<RnDto> GetAllRn()
        {
            using (var context = new DMLEntities())
            {
                return context.RadniNalog.Select(x => new RnDto
                {
                    Datum = x.Datum,
                    Izvrstitelj = x.Izvrstitelj,
                    Kolicina = x.Kolicina,
                    Narucitelj = x.Narucitelj,
                    Primatelj = x.Primatelj,
                    Radiliste = x.Radiliste,
                    RegOznaka = x.RegOznaka,
                    Vozac = x.Vozac,
                    VrstaRobe = x.VrstaRobe,
                    VrstaStroja = x.VrstaStroja,
                    VrstaUsluge = x.VrstaUsluge
                }).ToList();
            }
        }
    }
}
