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

        public List<RnDto> GetRnDtos() => rnRepository.GetAllRn();
        public List<RnDto> GetRnForTimePeriodAndReg(DateTime start, DateTime end, int regId) => rnRepository.GetRnForTimePeriodAndReg(start, end, regId);
        public FormLoadDto GetLoadData() => rnRepository.GetLoadData();
    }
}
