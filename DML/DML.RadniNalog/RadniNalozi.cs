using DML.Services.RadniNalozi;
using DML.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DML.RadniNalog
{
    public partial class RadniNalozi : Form
    {
        RnServices rnServices;
        public RadniNalozi()
        {
            InitializeComponent();

            rnServices = new RnServices();
        }

        private void btnSaveRn_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtKolicinaRobe.Text, out int kolicinaRobe);
            DateTime.TryParse(dtpDatum.Text, out DateTime datum);
            var data = new SaveRnDto
            {
               Datum = datum,
               Kolicina = kolicinaRobe,
               Narucitelj = txtNarucitelj.Text,
               Primatelj = txtPrimateljRobe.Text,
               Radiliste = txtRadilište.Text,
               RegOznaka = txtRegOznakaKamiona.Text,
               Vozac = txtVozac.Text,
               VrstaRobe = txtVrstaRobe.Text,
               VrstaStroja = txtVrstaStroja.Text,
               VrstaUsluge = txtVrstaUsluge.Text,
               Izvrstitelj = txtRobuIzdao.Text
            };

            rnServices.Save(data);
        }
    }
}
