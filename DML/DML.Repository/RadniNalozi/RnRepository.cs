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
        public void Save(SaveRnDto data)
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
    }
}
