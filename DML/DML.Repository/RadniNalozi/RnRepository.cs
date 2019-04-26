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
                    
                };

                context.RadniNalog.Add(rn);
                context.SaveChanges();
            }
        }

        public List<RnDto> GetRnForTimePeriodAndReg(DateTime start, DateTime end, int regId)
        {
            using (var context = new DMLEntities())
            {
                return context.RadniNalog.Where(x => x.Datum > start && x.Datum < end && x.RegOznakaId == regId).Select(x => new RnDto
                {
                    Id = x.Id,
                    Datum = x.Datum
                }).ToList();
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
