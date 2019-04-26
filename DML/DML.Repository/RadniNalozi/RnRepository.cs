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
                    NaruciteljId = data.NaruciteljId,
                    PrimateljId = data.PrimateljId,
                    RegOznakaId = data.RegOznakaId,
                    RN = data.RN,
                    RadilisteId = data.RadilisteId,
                    RobuIzdaoId = data.RobuIzdaoId,
                    VozacId = data.VozacId,
                    VrstaRobeId = data.VrstaRobeId,
                    VrstaStroja = data.VrstaStroja,
                    VrstaUslugeId = data.VrstaUslugeId
                };

                context.RadniNalog.Add(rn);
                context.SaveChanges();
            }
        }

        public List<RnDto> GetRnForTimePeriodAndReg(DateTime start, DateTime end, 
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
                var rn = context.RadniNalog.Where(x => x.Datum > start && x.Datum < end).ToList();

                if (regId > 0) rn = rn.Where(x => x.RegOznakaId == regId).ToList();
                if (vrstaRobeId > 0) rn = rn.Where(x => x.VrstaRobeId == vrstaRobeId).ToList();
                if (robuIzdaoId > 0) rn = rn.Where(x => x.RobuIzdaoId == robuIzdaoId).ToList();
                if (vrstaUslugeId > 0) rn = rn.Where(x => x.VrstaUslugeId == vrstaUslugeId).ToList();
                if (radilisteId > 0) rn = rn.Where(x => x.RadilisteId == radilisteId).ToList();
                if (vozacId > 0) rn = rn.Where(x => x.VozacId == vozacId).ToList();
                if (naruciteljId > 0) rn = rn.Where(x => x.NaruciteljId == naruciteljId).ToList();
                if (primateljId > 0) rn = rn.Where(x => x.PrimateljId == primateljId).ToList();

                return rn.Select(x => new RnDto
                {
                    Id = x.Id,
                    Datum = x.Datum
                }).ToList(); ;
            }
        }

        public List<RnDto> GetAllRn()
        {
            using (var context = new DMLEntities())
            {
                return context.RadniNalog.Select(x => new RnDto
                {
                    Id = x.Id,
                    Datum = x.Datum
                }).ToList();
            }
        }

        public FormLoadDto GetLoadData()
        {
            using (var context = new DMLEntities())
            {
                return  new FormLoadDto
                {

                    NarutiteljDtos = context.Narucitelj.Select(x => new NarutiteljDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    PrimateljDtos = context.Primatelj.Select(x => new PrimateljDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RadilisteDtos = context.Radiliste.Select(x => new RadilisteDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RegOznakaDtos = context.RegOznaka.Select(x => new RegOznakaDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RobuIzdaoDtos = context.RobuIzdao.Select(x => new RobuIzdaoDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VozacDtos = context.Vozac.Select(x => new VozacDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VrstaRobeDtos = context.VrstaRobe.Select(x => new VrstaRobeDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VrstaUslugeDtos = context.VrstaUsluge.Select(x => new VrstaUslugeDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList()
                };
            }
        }
    }
}
