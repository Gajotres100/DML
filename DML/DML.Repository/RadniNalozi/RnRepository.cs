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
    }
}
