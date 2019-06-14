using DML.VM;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    NaruciteljId = data.NaruciteljId,
                    PrimateljId = data.PrimateljId,
                    RegOznakaId = data.RegOznakaId,
                    RN = data.RN,
                    RadilisteId = data.RadilisteId,
                    RobuIzdaoId = data.RobuIzdaoId,
                    VozacId = data.VozacId,
                    VrstaRobeId = data.VrstaRobeId,
                    VrstaStroja = data.VrstaStroja,
                    VrstaUslugeId = data.VrstaUslugeId,
                    Kolicina = data.kolicinaRobe,
                    MjeraId = data.MjeraId
                };

                context.RadniNalogs.Add(rn);
                context.SaveChanges();
            }
        }

        public List<RnDtoForGrid> GetRnForTimePeriodAndReg(DateTime start, DateTime end,
            int regId,
            int vrstaRobeId,
            int robuIzdaoId,
            int vrstaUslugeId,
            int radilisteId,
            int vozacId,
            int naruciteljId,
            int primateljId)
        {
            using (var context = new DMLEntities())
            {
                var rn = context.RadniNalogs.Where(x => x.Datum > start && x.Datum < end).ToList();

                if (regId > 0) rn = rn.Where(x => x.RegOznakaId == regId).ToList();
                if (vrstaRobeId > 0) rn = rn.Where(x => x.VrstaRobeId == vrstaRobeId).ToList();
                if (robuIzdaoId > 0) rn = rn.Where(x => x.RobuIzdaoId == robuIzdaoId).ToList();
                if (vrstaUslugeId > 0) rn = rn.Where(x => x.VrstaUslugeId == vrstaUslugeId).ToList();
                if (radilisteId > 0) rn = rn.Where(x => x.RadilisteId == radilisteId).ToList();
                if (vozacId > 0) rn = rn.Where(x => x.VozacId == vozacId).ToList();
                if (naruciteljId > 0) rn = rn.Where(x => x.NaruciteljId == naruciteljId).ToList();
                if (primateljId > 0) rn = rn.Where(x => x.PrimateljId == primateljId).ToList();

                return rn.Select(x => new RnDtoForGrid
                {
                    Id = x.Id,
                    Datum = x.Datum,
                    Narucitelj = x.Narucitelj?.Name,
                    Primatelj = x.Primatelj?.Name,
                    Radiliste = x.Radiliste?.Name,
                    RegOznaka = x.RegOznaka.Name,
                    RN = x.RN,
                    RobuIzdao = x.RobuIzdao?.Name,
                    Vozac = x.Vozac?.Name,
                    VrstaRobe = x.VrstaRobe?.Name,
                    VrstaStroja = x.VrstaStroja,
                    VrstaUsluge = x.VrstaUsluge?.Name,
                    Mjera =  x.Mjera?.Name,
                    Kolicina = x.Kolicina
                }).ToList();
            }
        }

        public void DeletePostavka(int id)
        {
            using (var context = new DMLEntities())
            {
                var postavka = context.Postavkes.FirstOrDefault(x => x.Id == id);
                context.Postavkes.Remove(postavka);
                context.SaveChanges();
            }
        }

        public List<RnDtoForGrid> GetAllRn()
        {
            using (var context = new DMLEntities())
            {
                return context.RadniNalogs.Select(x => new RnDtoForGrid
                {
                    Id = x.Id,
                    Datum = x.Datum,
                    Narucitelj = x.Narucitelj.Name,
                    Primatelj = x.Primatelj.Name,
                    Radiliste = x.Radiliste.Name,
                    RegOznaka = x.RegOznaka.Name,
                    RN = x.RN,
                    RobuIzdao = x.RobuIzdao.Name,
                    Vozac = x.Vozac.Name,
                    VrstaRobe = x.VrstaRobe.Name,
                    VrstaStroja = x.VrstaStroja,
                    VrstaUsluge = x.VrstaUsluge.Name
                }).ToList();
            }
        }

        public void SaveOrUpdate(BaseDto postavke)
        {
            using (var context = new DMLEntities())
            {
                var postavka = context.Postavkes.FirstOrDefault(x => x.Id == postavke.Id);
                if (postavka == null)
                {
                    var narucitelj = new Postavke
                    {
                        Id = postavke.Id,
                        Name = postavke.Name,
                        PostavkeId = postavke.PostavkaId
                    };

                    context.Postavkes.Add(narucitelj);
                    context.SaveChanges();
                }
                else
                {
                    postavka.Name = postavke.Name;
                    context.SaveChanges();
                }
            }
        } 

        public FormLoadDto GetLoadData()
        {
            using (var context = new DMLEntities())
            {
                return  new FormLoadDto
                {
                    BaseDtos = context.Postavkes.Select(x => new BaseDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                        PostavkaId = x.PostavkeId
                    }).ToList(),
                };
            }
        }
    }
}
