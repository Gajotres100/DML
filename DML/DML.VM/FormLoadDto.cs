using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DML.VM
{
    public class FormLoadDto
    {
        public List<NarutiteljDto> NarutiteljDtos { get; set; }
        public List<PrimateljDto> PrimateljDtos { get; set; }
        public List<RadilisteDto> RadilisteDtos { get; set; }
        public List<RegOznakaDto> RegOznakaDtos { get; set; }
        public List<RobuIzdaoDto> RobuIzdaoDtos { get; set; }
        public List<VozacDto> VozacDtos { get; set; }
        public List<VrstaRobeDto> VrstaRobeDtos { get; set; }
        public List<VrstaUslugeDto> VrstaUslugeDtos { get; set; }
    }
}
