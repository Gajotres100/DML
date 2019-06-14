using DML.Repository.RadniNalozi;
using DML.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DML.Services.RadniNalozi
{
    public class RnServices
    {
        RnRepository rnRepository;
        public RnServices()
        {
            rnRepository = new RnRepository();
        }

        public void Save(RnDto data)
        {
            rnRepository.SaveRn(data);
        }

        public List<RnDtoForGrid> GetRnDtos() => rnRepository.GetAllRn();
        public List<RnDtoForGrid> GetRnForTimePeriodAndReg(DateTime start, DateTime end, int regId,
            int vrstaRobeId,
            int robuIzdaoId,
            int vrstaUslugeId,
            int radilisteId,
            int vozacId,
            int naruciteljId,
            int primateljId) => rnRepository.GetRnForTimePeriodAndReg(start, end, regId,vrstaRobeId,robuIzdaoId,vrstaUslugeId,radilisteId, vozacId,naruciteljId,primateljId);
        public FormLoadDto GetLoadData() => rnRepository.GetLoadData();

        public void SaveOrUpdate(BaseDto data)
        {
            rnRepository.SaveOrUpdate(data);
        }

        public void DeletePostavka(int id)
        {
            rnRepository.DeletePostavka(id);
        }
    }
}
