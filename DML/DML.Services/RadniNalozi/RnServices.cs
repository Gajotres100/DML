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
        public void Save(SaveRnDto data)
        {
            rnRepository.Save(data);
        }
    }
}
