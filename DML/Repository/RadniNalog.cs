//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class RadniNalog
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public int VrstaRobeId { get; set; }
        public Nullable<decimal> Kolicina { get; set; }
        public int RobuIzdaoId { get; set; }
        public int RegOznakaId { get; set; }
        public int VrstaUslugeId { get; set; }
        public int RadilisteId { get; set; }
        public int VozacId { get; set; }
        public int NaruciteljId { get; set; }
        public int PrimateljId { get; set; }
        public string RN { get; set; }
        public int MjeraId { get; set; }
        public string Napomena { get; set; }
        public int VrstaStrojaId { get; set; }
    
        public virtual Postavke Mjera { get; set; }
        public virtual Postavke Narucitelj { get; set; }
        public virtual Postavke Primatelj { get; set; }
        public virtual Postavke Radiliste { get; set; }
        public virtual Postavke RegOznaka { get; set; }
        public virtual Postavke RobuIzdao { get; set; }
        public virtual Postavke Vozac { get; set; }
        public virtual Postavke VrstaRobe { get; set; }
        public virtual Postavke VrstaUsluge { get; set; }
        public virtual Postavke VrstaStroja { get; set; }
    }
}
