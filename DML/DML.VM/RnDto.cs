using System;

namespace DML.VM
{
    public class RnDto
    {
        public int Id { get; set; }
        public DateTime? Datum { get; set; }
        public int NaruciteljId { get; set; }
        public int PrimateljId { get; set; }
        public int RegOznakaId { get; set; }
        public string RN { get; set; }
        public int RadilisteId { get; set; }
        public int RobuIzdaoId { get; set; }
        public int VozacId { get; set; }
        public int VrstaRobeId { get; set; }
        public string VrstaStroja { get; set; }
        public int VrstaUslugeId { get; set; }
        public int MjeraId { get; set; }
        public decimal? kolicinaRobe { get; set; }
    }
}
