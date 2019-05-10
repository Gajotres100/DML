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
                    VrstaUsluge = x.VrstaUsluge?.Name
                }).ToList(); ;
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

        public List<BaseDto> GetNarucitelj()
        {
            using (var context = new DMLEntities())
            {
                return context.Naruciteljs.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveNarucitelj(string name)
        {
            using (var context = new DMLEntities())
            {
                var narucitelj = new Narucitelj
                {
                    Name = name
                };

                context.Naruciteljs.Add(narucitelj);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetPrimatelj()
        {
            using (var context = new DMLEntities())
            {
                return context.Primateljs.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SavePrimatelj(string name)
        {
            using (var context = new DMLEntities())
            {
                var primatelj = new Primatelj
                {
                    Name = name
                };

                context.Primateljs.Add(primatelj);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetRadiliste()
        {
            using (var context = new DMLEntities())
            {
                return context.Radilistes.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveRadiliste(string name)
        {
            using (var context = new DMLEntities())
            {
                var radiliste = new Radiliste
                {
                    Name = name
                };

                context.Radilistes.Add(radiliste);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetRegOznaka()
        {
            using (var context = new DMLEntities())
            {
                return context.RegOznakas.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveRegOznaka(string name)
        {
            using (var context = new DMLEntities())
            {
                var regOznaka = new RegOznaka
                {
                    Name = name
                };

                context.RegOznakas.Add(regOznaka);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetRobuIzdao()
        {
            using (var context = new DMLEntities())
            {
                return context.RobuIzdaos.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveRobuIzdao(string name)
        {
            using (var context = new DMLEntities())
            {
                var robuIzdao = new RobuIzdao
                {
                    Name = name
                };

                context.RobuIzdaos.Add(robuIzdao);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetVozac()
        {
            using (var context = new DMLEntities())
            {
                return context.Vozacs.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveVozac(string name)
        {
            using (var context = new DMLEntities())
            {
                var vozac = new Vozac
                {
                    Name = name
                };

                context.Vozacs.Add(vozac);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetVrstaRobe()
        {
            using (var context = new DMLEntities())
            {
                return context.VrstaRobes.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveVrstaRobe(string name)
        {
            using (var context = new DMLEntities())
            {
                var vrstaRobe = new VrstaRobe
                {
                    Name = name
                };

                context.VrstaRobes.Add(vrstaRobe);
                context.SaveChanges();
            }
        }

        public List<BaseDto> GetVrstaUsluge()
        {
            using (var context = new DMLEntities())
            {
                return context.VrstaUsluges.Select(x => new BaseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
            }
        }

        public void SaveVrstaUsluge(string name)
        {
            using (var context = new DMLEntities())
            {
                var vrstaUsluge = new VrstaUsluge
                {
                    Name = name
                };

                context.VrstaUsluges.Add(vrstaUsluge);
                context.SaveChanges();
            }
        }

        public FormLoadDto GetLoadData()
        {
            using (var context = new DMLEntities())
            {
                return  new FormLoadDto
                {
                    NarutiteljDtos = context.Naruciteljs.Select(x => new NarutiteljDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    PrimateljDtos = context.Primateljs.Select(x => new PrimateljDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RadilisteDtos = context.Radilistes.Select(x => new RadilisteDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RegOznakaDtos = context.RegOznakas.Select(x => new RegOznakaDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    RobuIzdaoDtos = context.RobuIzdaos.Select(x => new RobuIzdaoDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VozacDtos = context.Vozacs.Select(x => new VozacDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VrstaRobeDtos = context.VrstaRobes.Select(x => new VrstaRobeDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    VrstaUslugeDtos = context.VrstaUsluges.Select(x => new VrstaUslugeDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList(),

                    MjeraDtos = context.Mjeras.Select(x => new MjeraDto
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).ToList()
                };
            }
        }
    }
}
