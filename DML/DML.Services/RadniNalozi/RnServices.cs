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

        public List<BaseDto> GetNarucitelj() => rnRepository.GetNarucitelj();
        public List<BaseDto> GetPrimatelj() => rnRepository.GetPrimatelj();
        public List<BaseDto> GetRadiliste() => rnRepository.GetRadiliste();
        public List<BaseDto> GetRegOznaka() => rnRepository.GetRegOznaka();
        public List<BaseDto> GetRobuIzdao() => rnRepository.GetRobuIzdao();
        public List<BaseDto> GetVozac() => rnRepository.GetVozac();
        public List<BaseDto> GetVrstaRobe() => rnRepository.GetVrstaRobe();
        public List<BaseDto> GetVrstaUsluge() => rnRepository.GetVrstaUsluge();

        public void SaveNarucitelj(string text) => rnRepository.SaveNarucitelj(text);

        public void SavePrimatelj(string text) => rnRepository.SavePrimatelj(text);

        public void SaveVrstaUsluge(string text) => rnRepository.SaveVrstaUsluge(text);

        public void SaveRadiliste(string text) => rnRepository.SaveRadiliste(text);

        public void SaveVrstaRobe(string text) => rnRepository.SaveVrstaRobe(text);

        public void SaveRegOznaka(string text) => rnRepository.SaveRegOznaka(text);

        public void SaveVozac(string text) => rnRepository.SaveVozac(text);

        public void SaveRobuIzdao(string text) => rnRepository.SaveRobuIzdao(text);
    }
}
