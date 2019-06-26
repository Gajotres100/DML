using System;
using System.Collections.Generic;
using DML.VM;

namespace DML.Services.RadniNalozi
{
    public interface IRnServices
    {
        bool DeletePostavka(int id);
        FormLoadDto GetLoadData();
        RnDto GetRnDto(int id);
        List<RnDtoForGrid> GetRnDtos();
        List<RnDtoForGrid> GetRnForTimePeriodAndReg(DateTime start, DateTime end, int regId, int vrstaRobeId, int robuIzdaoId, int vrstaUslugeId, int radilisteId, int vozacId, int naruciteljId, int primateljId);
        void Save(RnDto data);
        void SaveOrUpdate(BaseDto data);
    }
}