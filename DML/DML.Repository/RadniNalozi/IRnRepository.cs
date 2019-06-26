using System;
using System.Collections.Generic;
using DML.VM;

namespace DML.Repository.RadniNalozi
{
    public interface IRnRepository
    {
        void DeletePostavka(int id);
        List<RnDtoForGrid> GetAllRn();
        FormLoadDto GetLoadData();
        RnDto GetRn(int id);
        List<RnDtoForGrid> GetRnForTimePeriodAndReg(DateTime start, DateTime end, int regId, int vrstaRobeId, int robuIzdaoId, int vrstaUslugeId, int radilisteId, int vozacId, int naruciteljId, int primateljId);
        void SaveOrUpdate(BaseDto postavke);
        void SaveRn(RnDto data);
    }
}